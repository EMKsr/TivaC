#include <stdint.h>
#include <stdbool.h>
#include <stdio.h>
#include "inc/hw_memmap.h"
#include "inc/hw_types.h"
#include "inc/hw_ints.h"
#include "inc/hw_uart.h"
#include "driverlib/sysctl.h"
#include "driverlib/gpio.h"
#include "driverlib/interrupt.h"
#include "driverlib/timer.h"
#include "driverlib/uart.h"
#include "driverlib/pin_map.h"
#include "driverlib/adc.h"
#include "lcd.h"

// --- Deðiþkenler ---
volatile int saat = 0;
volatile int dakika = 0;
volatile int saniye = 0;
volatile int btndurumu = 0;

char buffer[20];

// --- Fonksiyon Tanýmlarý ---
void ilkayarlar(void);
void timerkesme(void);
void butonkesme(void);
void UART_Yaz(char *s);

int main(void)
{
    ilkayarlar();
    UART_Yaz("#byEMK\r\n");

    char c;
    char temp_str[2];
    char gelen_saat[8];
    int i;

    while(1)
    {
        // --- POLING YÖNTEMÝ ---
        if(UARTCharsAvail(UART0_BASE))
        {
            // Veri varsa al
            c = UARTCharGet(UART0_BASE);

            // 1. DURUM: METÝN YAZDIRMA (#)
            if(c == '#')
            {
                IntMasterDisable();
                Lcd_Goto(1, 1);
                Lcd_Puts("                "); // Temizle
                Lcd_Goto(1, 1);
                IntMasterEnable();
            }

            // 2. DURUM: ZAMAN AYARLAMA (&)
            else if(c == '&')
            {
                for(i = 0; i < 8; i++)
                {
                    while(!UARTCharsAvail(UART0_BASE));
                    gelen_saat[i] = UARTCharGet(UART0_BASE);
                }

                int gelen_saat_val   = (gelen_saat[0] - '0') * 10 + (gelen_saat[1] - '0');
                int gelen_dakika_val = (gelen_saat[3] - '0') * 10 + (gelen_saat[4] - '0');
                int gelen_saniye_val = (gelen_saat[6] - '0') * 10 + (gelen_saat[7] - '0');

                if(gelen_saat_val < 24 && gelen_dakika_val < 60 && gelen_saniye_val < 60)
                {
                    IntMasterDisable();
                    saat = gelen_saat_val;
                    dakika = gelen_dakika_val;
                    saniye = gelen_saniye_val;
                    IntMasterEnable();

                    UART_Yaz("#Saat Guncellendi!\r\n");
                }
            }

            // 3. DURUM: LED KONTROLÜ (*)
            else if(c == '*')
            {
                while(!UARTCharsAvail(UART0_BASE));
                char led_komut = UARTCharGet(UART0_BASE);

                if(led_komut == 'A') // A gelirse YEÞÝL LED YAK
                {
                    GPIOPinWrite(GPIO_PORTF_BASE, GPIO_PIN_3, GPIO_PIN_3);
                }
                else if(led_komut == 'B') // B gelirse YEÞÝL LED SÖNDÜR
                {
                    GPIOPinWrite(GPIO_PORTF_BASE, GPIO_PIN_3, 0);
                }
            }

            // 4. DURUM: DÝÐER KARAKTERLERÝ LCD'YE YAZ
            else if(c != '\n' && c != '\r' && c != '*' && c != '&' && c != '#')
            {
                IntMasterDisable();
                temp_str[0] = c;
                temp_str[1] = '\0';
                Lcd_Puts(temp_str);
                IntMasterEnable();
            }
        }
    }
}

void ilkayarlar(void){
    // 1. Ýþlemci Hýzý 50 MHz
    SysCtlClockSet(SYSCTL_SYSDIV_4 | SYSCTL_USE_PLL | SYSCTL_XTAL_16MHZ | SYSCTL_OSC_MAIN);

    // 2. Donanýmlarý Aktifleþtir
    SysCtlPeripheralEnable(SYSCTL_PERIPH_TIMER0);
    SysCtlPeripheralEnable(SYSCTL_PERIPH_GPIOF);
    SysCtlPeripheralEnable(SYSCTL_PERIPH_GPIOA);
    SysCtlPeripheralEnable(SYSCTL_PERIPH_UART0);

    // ADC ve Port E Aktifleþtirme
    SysCtlPeripheralEnable(SYSCTL_PERIPH_ADC0);
    SysCtlPeripheralEnable(SYSCTL_PERIPH_GPIOE);

    // 3. UART Ayarlarý
    GPIOPinConfigure(GPIO_PA0_U0RX);
    GPIOPinConfigure(GPIO_PA1_U0TX);
    GPIOPinTypeUART(GPIO_PORTA_BASE, GPIO_PIN_0 | GPIO_PIN_1);

    UARTConfigSetExpClk(UART0_BASE, SysCtlClockGet(), 9600,(UART_CONFIG_WLEN_8 | UART_CONFIG_STOP_ONE | UART_CONFIG_PAR_NONE));
    UARTIntEnable(UART0_BASE, UART_INT_RX | UART_INT_RT);
    UARTEnable(UART0_BASE);

    // ADC Ayarlarý
    GPIOPinTypeADC(GPIO_PORTE_BASE, GPIO_PIN_3);
    ADCSequenceConfigure(ADC0_BASE, 3, ADC_TRIGGER_PROCESSOR, 0);
    ADCSequenceStepConfigure(ADC0_BASE, 3, 0, ADC_CTL_CH0 | ADC_CTL_IE | ADC_CTL_END);
    ADCSequenceEnable(ADC0_BASE, 3);
    ADCIntClear(ADC0_BASE, 3);

    // 4. Timer Ayarlarý
    TimerConfigure(TIMER0_BASE, TIMER_CFG_PERIODIC);
    TimerLoadSet(TIMER0_BASE, TIMER_A, SysCtlClockGet() - 1);
    IntEnable(INT_TIMER0A);

    TimerIntEnable(TIMER0_BASE, TIMER_TIMA_TIMEOUT);
    TimerIntRegister(TIMER0_BASE, TIMER_A, timerkesme);
    TimerEnable(TIMER0_BASE, TIMER_A);

    // 5. LCD Baþlat
    Lcd_init();
    Lcd_Temizle();

    // 6. Buton ve LED Ayarlarý
    GPIOPinTypeGPIOInput(GPIO_PORTF_BASE, GPIO_PIN_4);
    GPIOPinTypeGPIOOutput(GPIO_PORTF_BASE, GPIO_PIN_1 | GPIO_PIN_3);
    GPIOPadConfigSet(GPIO_PORTF_BASE, GPIO_PIN_4, GPIO_STRENGTH_2MA, GPIO_PIN_TYPE_STD_WPU);
    GPIOIntTypeSet(GPIO_PORTF_BASE, GPIO_PIN_4, GPIO_BOTH_EDGES);
    GPIOIntRegister(GPIO_PORTF_BASE, butonkesme);
    GPIOIntEnable(GPIO_PORTF_BASE, GPIO_PIN_4);
    IntEnable(INT_GPIOF);

    IntMasterEnable();
}

void UART_Yaz(char *s) {
    while(*s) {
        UARTCharPut(UART0_BASE, *s++);
    }
}

// --- TIMER KESMESÝ ---
void timerkesme(void)
{
    uint32_t adc_degeri[1];
    char pc_gonderim_buffer[10]; // Sadece PC'ye saat göndermek için geçici buffer
    char adc_pc_buffer[16];      // Sadece PC'ye ADC göndermek için geçici buffer

    // Bayraðý temizle
    TimerIntClear(TIMER0_BASE, TIMER_TIMA_TIMEOUT);

    // 1. ÖNCE ADC OKU (Ekrana yazdýrmadan önce elimizde veri olsun)
    ADCProcessorTrigger(ADC0_BASE, 3);
    while(!ADCIntStatus(ADC0_BASE, 3, false));
    ADCIntClear(ADC0_BASE, 3);
    ADCSequenceDataGet(ADC0_BASE, 3, adc_degeri);

    // 2. SAAT HESABI
    saniye++;
    if(saniye > 59) {
        saniye = 0;
        dakika++;
        if(dakika > 59) {
            dakika = 0;
            saat++;
            if(saat > 23) saat = 0;
        }
    }

    // 3. LCD ÝÇÝN BÝRLEÞTÝR VE YAZ
    // Format: "12:21:12   V2096"
    sprintf(buffer, "%02d:%02d:%02d   V%4d", saat, dakika, saniye, (int)adc_degeri[0]);

    Lcd_Goto(2, 1);
    Lcd_Puts(buffer);

    // 4. PC'YE VERÝLERÝ GÖNDER

    // a) Saati Gönder (C# tarafý "&" bekliyor, ADC'yi karýþtýrmadan sadece saati atýyoruz)
    sprintf(pc_gonderim_buffer, "%02d:%02d:%02d", saat, dakika, saniye);
    UARTCharPut(UART0_BASE, '&');
    UART_Yaz(pc_gonderim_buffer);
    UART_Yaz("\r\n");

    // b) ADC'yi Gönder (C# tarafý "$" bekliyor)
    sprintf(adc_pc_buffer, "$%d\r\n", (int)adc_degeri[0]);
    UART_Yaz(adc_pc_buffer);
}

void butonkesme(void)
{
    GPIOIntClear(GPIO_PORTF_BASE, GPIO_PIN_4);

    if(btndurumu == 0)
    {
        btndurumu = 1;
        GPIOPinWrite(GPIO_PORTF_BASE, GPIO_PIN_1, GPIO_PIN_1);
        UART_Yaz("*Basti Basti Butona Basti\r\n");
    }
    else
    {
        btndurumu = 0;
        GPIOPinWrite(GPIO_PORTF_BASE, GPIO_PIN_1, 0);
        UART_Yaz("*Butondan Cekti\r\n");
    }
}
