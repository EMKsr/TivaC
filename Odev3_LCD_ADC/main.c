#include <stdint.h>
#include <stdbool.h>
#include <stdio.h>
#include "inc/hw_memmap.h"
#include "driverlib/sysctl.h"
#include "driverlib/gpio.h"
#include "driverlib/adc.h"
#include "lcd.h"

// ADC verisini saklamak için dizi (Sequencer 3 tek bir örnek aldýðý için 1 elemanlý)
uint32_t adc_sonuc[1];
char lcd_buffer[16];

void ADC_Donanim_Ayarlari(void);

int main(void)
{
    // Ýþlemci hýzý 50 MHz
    SysCtlClockSet(SYSCTL_SYSDIV_4 | SYSCTL_USE_PLL | SYSCTL_XTAL_16MHZ | SYSCTL_OSC_MAIN);

    // LCD ve ADC yapýlandýrmasýný yap
    Lcd_init();
    ADC_Donanim_Ayarlari();

    Lcd_Temizle();
    Lcd_Goto(1,1);
    Lcd_Puts("ADC Okuma Odevi");

    while(1)
    {
        // 1. ADC Çevrimini Tetikle (Yazýlýmsal Tetikleme)
        ADCProcessorTrigger(ADC0_BASE, 3);

        // 2. Çevrimin bitmesini bekle (Polling - Meþgul Bekleme)
        while(!ADCIntStatus(ADC0_BASE, 3, false));

        // 3. Kesme bayraðýný temizle ve veriyi oku
        ADCIntClear(ADC0_BASE, 3);
        ADCSequenceDataGet(ADC0_BASE, 3, adc_sonuc);

        // 4. Veriyi Formatla (0-4095 arasý deðer)
        // %4d ifadesi sayýnýn her zaman 4 hane kaplamasýný saðlar (Sola boþluk býrakýr)
        sprintf(lcd_buffer, "Deger: %4d", (int)adc_sonuc[0]);

        // 5. LCD'ye Yazdýr
        Lcd_Goto(2, 1);
        Lcd_Puts(lcd_buffer);

        // Okumayý stabilize etmek için kýsa bir gecikme
        SysCtlDelay(SysCtlClockGet() / 30);
    }
}

void ADC_Donanim_Ayarlari(void)
{
    // ADC0 ve Port E birimlerini aktifleþtir
    SysCtlPeripheralEnable(SYSCTL_PERIPH_ADC0);
    SysCtlPeripheralEnable(SYSCTL_PERIPH_GPIOE);

    // PE3 pinini ADC giriþi (Analog Pin) olarak ayarla (Channel 0)
    GPIOPinTypeADC(GPIO_PORTE_BASE, GPIO_PIN_3);

    // Sequencer 3'ü yapýlandýr: Ýþlemci tarafýndan tetiklenir, en yüksek öncelik (0)
    ADCSequenceConfigure(ADC0_BASE, 3, ADC_TRIGGER_PROCESSOR, 0);

    // Sequencer 3'ün 0. adýmýný yapýlandýr:
    // Kanal 0'dan oku (PE3), kesme oluþtur (IE) ve bu adýmýn son olduðunu bildir (END)
    ADCSequenceStepConfigure(ADC0_BASE, 3, 0, ADC_CTL_CH0 | ADC_CTL_IE | ADC_CTL_END);

    // Yapýlandýrma bittikten sonra ADC birimini çalýþtýr
    ADCSequenceEnable(ADC0_BASE, 3);
}
