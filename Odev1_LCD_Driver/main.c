#include <stdint.h>
#include <stdbool.h>
#include "inc/hw_memmap.h"
#include "driverlib/sysctl.h"
#include "lcd.h"

int main(void)
{
    // Ýþlemci hýzýný 50 MHz olarak ayarla (400MHz PLL / 8 = 50MHz)
    SysCtlClockSet(SYSCTL_SYSDIV_4 | SYSCTL_USE_PLL | SYSCTL_XTAL_16MHZ | SYSCTL_OSC_MAIN);

    // LCD baþlatma ayarlarýný yap
    Lcd_init();

    while(1)
    {
        Lcd_Temizle();              // Ekraný temizle
        Lcd_Goto(1,1);              // 1. Satýr 1. Sütun
        Lcd_Puts("Tiva C Odev 1");   // Mesaj yazdýr

        Lcd_Goto(2,1);              // 2. Satýr 1. Sütun
        Lcd_Puts("LCD Surucu Hazir");

        SysCtlDelay(SysCtlClockGet() / 3); // Yaklaþýk 1 saniye bekle
    }
}
