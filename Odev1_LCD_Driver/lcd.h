#ifndef LCD_H_
#define LCD_H_

#include <stdint.h>
#include <stdbool.h>

// --- LCD Baðlantý Port Tanýmlarý ---
#define LCDPORT          GPIO_PORTB_BASE      // LCD'nin baðlý olduðu fiziksel port (Port B)
#define LCDPORTENABLE    SYSCTL_PERIPH_GPIOB  // Port B'ye saat sinyali (clock) vermek için kullanýlan sabit

// --- LCD Pin Tanýmlarý (4-Bit Modu) ---
#define RS               GPIO_PIN_0           // Register Select: 0=Komut, 1=Veri
#define E                GPIO_PIN_1           // Enable: Veriyi LCD'ye kilitlemek için clock sinyali
#define D4               GPIO_PIN_4           // Veri yolu yüksek nibble pinleri
#define D5               GPIO_PIN_5
#define D6               GPIO_PIN_6
#define D7               GPIO_PIN_7

// --- Fonksiyon Prototipleri ---
void Lcd_Komut(unsigned char);       // LCD'ye yapýlandýrma komutu gönderir
void Lcd_Temizle(void);              // Ekran içeriðini siler
void Lcd_Puts(char*);                // String (metin) yazdýrýr
void Lcd_Goto(char, char);           // Kursörü belirtilen (satýr, sütun) konumuna götürür
void Lcd_init(void);                 // LCD'yi 4-bit modunda baþlatýr ve ayarlarýný yapar
void Lcd_Putch(unsigned char);       // Ekrana tek bir karakter yazdýrýr

#endif
