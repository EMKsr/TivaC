#include <stdint.h>
#include <stdbool.h>
#include <stdio.h>
#include "inc/hw_memmap.h"
#include "inc/hw_ints.h"
#include "driverlib/sysctl.h"
#include "driverlib/gpio.h"
#include "driverlib/interrupt.h"
#include "driverlib/timer.h"
#include "lcd.h"

// --- Global Zaman Deðiþkenleri ---
volatile int saat = 12;   // Baþlangýç saati
volatile int dakika = 59;
volatile int saniye = 45;

char zaman_buffer[16];    // LCD'ye yazýlacak metin için tampon bellek

// --- Fonksiyon Tanýmlarý ---
void Donanim_Ayarlari(void);
void Timer0_Kesme_Handler(void);

int main(void)
{
    // Donaným birimlerini ve LCD'yi hazýrla
    Donanim_Ayarlari();

    while(1)
    {
        // Ana döngü içerisinde sadece ekran güncellemesi yapýlýr.
        // Kesme fonksiyonu (Interrupt) arka planda zamaný sürekli sayar.

        Lcd_Goto(1, 1);
        Lcd_Puts("  DIJITAL SAAT  ");

        // Zaman verisini SS:DD:SN formatýna getir
        sprintf(zaman_buffer, "    %02d:%02d:%02d    ", saat, dakika, saniye);

        Lcd_Goto(2, 1);
        Lcd_Puts(zaman_buffer);

        SysCtlDelay(100000); // Ekran titremesini önlemek için küçük bir tazeleme gecikmesi
    }
}

void Donanim_Ayarlari(void)
{
    // Ýþlemci hýzýný 50 MHz olarak ayarla
    SysCtlClockSet(SYSCTL_SYSDIV_4 | SYSCTL_USE_PLL | SYSCTL_XTAL_16MHZ | SYSCTL_OSC_MAIN);

    // 1. Timer0 Çevre Birimini Aktifleþtir
    SysCtlPeripheralEnable(SYSCTL_PERIPH_TIMER0);

    // 2. LCD'yi Baþlat
    Lcd_init();
    Lcd_Temizle();

    // 3. Timer0 Konfigürasyonu: Periyodik Mod
    TimerConfigure(TIMER0_BASE, TIMER_CFG_PERIODIC);

    // Timer yükleme deðeri: Ýþlemci hýzý kadar (50M).
    // Bu deðer, her 1 saniyede bir kesme oluþmasýný saðlar.
    TimerLoadSet(TIMER0_BASE, TIMER_A, SysCtlClockGet() - 1);

    // 4. Kesme (Interrupt) Ayarlarý
    TimerIntEnable(TIMER0_BASE, TIMER_TIMA_TIMEOUT);      // Timer timeout kesmesini aç
    TimerIntRegister(TIMER0_BASE, TIMER_A, Timer0_Kesme_Handler); // Kesme fonksiyonunu kaydet
    IntEnable(INT_TIMER0A);                               // Genel kesme yöneticisinde Timer0A'yý aç
    IntMasterEnable();                                    // Tüm iþlemci kesmelerini aktif et

    // 5. Timer'ý Çalýþtýr
    TimerEnable(TIMER0_BASE, TIMER_A);
}

// --- TIMER KESME FONKSÝYONU ---
// Bu fonksiyon iþlemci tarafýndan her 1 saniyede bir otomatik çaðrýlýr.
void Timer0_Kesme_Handler(void)
{
    // Kesme bayraðýný temizle (Sistemin tekrar kesmeye girebilmesi için þarttýr)
    TimerIntClear(TIMER0_BASE, TIMER_TIMA_TIMEOUT);

    // Zamaný ilerlet
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
}
