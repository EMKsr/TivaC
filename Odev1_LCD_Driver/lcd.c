#include "lcd.h"
#include "inc/hw_memmap.h"
#include "driverlib/sysctl.h"
#include "driverlib/gpio.h"

void Lcd_init() {
    SysCtlPeripheralEnable(LCDPORTENABLE);           // Port B birimini aktifleþtir
    while(!SysCtlPeripheralReady(LCDPORTENABLE));    // Portun hazýr olduðundan emin ol

    GPIOPinTypeGPIOOutput(LCDPORT, 0xFF);            // Port B'deki ilgili pinleri çýkýþ yap
    SysCtlDelay(100000);                             // LCD'nin voltajýnýn oturmasý için bekle

    // --- Reset Prosedürü (HD44780 Standart) ---
    // LCD'yi kararlý hale getirmek için 3 kez 0x30 komutu gönderilir
    for(int i=0; i<3; i++) {
        GPIOPinWrite(LCDPORT, D4 | D5 | D6 | D7, 0x30);
        GPIOPinWrite(LCDPORT, E, 0x02);              // Enable high
        SysCtlDelay(2000);
        GPIOPinWrite(LCDPORT, E, 0x00);              // Enable low (Düþen kenarda veri iþlenir)
        SysCtlDelay(100000);
    }

    // 4-Bit moduna geçiþ komutu (0x20)
    GPIOPinWrite(LCDPORT, D4 | D5 | D6 | D7, 0x20);
    GPIOPinWrite(LCDPORT, E, 0x02);
    SysCtlDelay(2000);
    GPIOPinWrite(LCDPORT, E, 0x00);
    SysCtlDelay(100000);

    // Genel Ayarlar
    Lcd_Komut(0x28); // 2 Satýr, 5x7 Font, 4-Bit haberleþme
    Lcd_Komut(0x06); // Giriþ modu: Yazdýkça kursör saða ilerlesin
    Lcd_Komut(0x0C); // Ekraný aç, kursörü gizle
    Lcd_Temizle();   // Baþlangýçta ekraný süpür
}

void Lcd_Komut(unsigned char c) {
    // Üst 4 bit gönderilir
    GPIOPinWrite(LCDPORT, D4 | D5 | D6 | D7, (c & 0xf0));
    GPIOPinWrite(LCDPORT, RS, 0);                    // RS=0: Komut gönderiliyor
    GPIOPinWrite(LCDPORT, E, 0x02);
    SysCtlDelay(2000);
    GPIOPinWrite(LCDPORT, E, 0x00);

    SysCtlDelay(2000); // Küçük gecikme

    // Alt 4 bit gönderilir
    GPIOPinWrite(LCDPORT, D4 | D5 | D6 | D7, (c & 0x0f) << 4);
    GPIOPinWrite(LCDPORT, E, 0x02);
    SysCtlDelay(2000);
    GPIOPinWrite(LCDPORT, E, 0x00);
    SysCtlDelay(50000); // Komutun iþlenmesi için gereken süre
}

void Lcd_Putch(unsigned char d) {
    // Üst 4 bit gönderilir
    GPIOPinWrite(LCDPORT, D4 | D5 | D6 | D7, (d & 0xf0));
    GPIOPinWrite(LCDPORT, RS, 0x01);                 // RS=1: Veri (karakter) gönderiliyor
    GPIOPinWrite(LCDPORT, E, 0x02);
    SysCtlDelay(2000);
    GPIOPinWrite(LCDPORT, E, 0x00);

    SysCtlDelay(2000);

    // Alt 4 bit gönderilir
    GPIOPinWrite(LCDPORT, D4 | D5 | D6 | D7, (d & 0x0f) << 4);
    GPIOPinWrite(LCDPORT, E, 0x02);
    SysCtlDelay(2000);
    GPIOPinWrite(LCDPORT, E, 0x00);
    SysCtlDelay(2000);
}

void Lcd_Goto(char x, char y){
    if(x==1)
        Lcd_Komut(0x80 + ((y-1) % 16)); // 1. Satýr baþlangýç adresi + sütun offseti
    else
        Lcd_Komut(0xC0 + ((y-1) % 16)); // 2. Satýr baþlangýç adresi + sütun offseti
}

void Lcd_Temizle(void){
    Lcd_Komut(0x01);       // Ekraný temizleme komutu
    SysCtlDelay(100000);   // Temizleme iþlemi yavaþtýr, uzun bekleme gerekir
}

void Lcd_Puts(char* s){
    while(*s)              // Null karakterine kadar her karakteri sýrayla yaz
        Lcd_Putch(*s++);
}
