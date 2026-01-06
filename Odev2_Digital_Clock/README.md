# Ödev 2 – LCD Dijital Saat Uygulaması

Bu ödevde Tiva TM4C123GH6PM mikrodenetleyicisi ve 16x2 LCD ekran
kullanılarak dijital saat uygulaması geliştirilmiştir.

## Çalışma Prensibi
- Zaman sayımı Timer kesmeleri (interrupt) kullanılarak yapılmıştır.
- Saat formatı SS:DD:SN (Saat:Dakika:Saniye) şeklindedir.
- LCD ekran periyodik olarak güncellenmektedir.

## İçerik
- main.c : Timer yapılandırması ve LCD güncelleme kodları

## Açıklamalar
- Timer interrupt kullanımı sayesinde saat doğruluğu artırılmıştır.
- LCD yenileme hızı gözle fark edilmeyecek seviyededir.
- Kod okunabilirliği için gerekli yorum satırları eklenmiştir.
