# Ödev 4 – Seri Port ve GUI Haberleşmesi

Bu ödevde Tiva TM4C123GH6PM mikrodenetleyicisi ile bilgisayar
arasında UART haberleşmesi kurulmuş ve bir grafik arayüz (GUI)
üzerinden veri alışverişi sağlanmıştır.

## Sistem Yapısı
- Mikrodenetleyici tarafında UART modülü kullanılmıştır.
- Bilgisayar tarafında GUI uygulaması ile seri haberleşme sağlanmıştır.

## İçerik
- Gömülü Kod: UART konfigürasyonu ve veri gönderme/alma işlemleri
- GUI Kodu: Kullanıcı arayüzü ve seri port kontrolü
- gui/ : GUI kaynak dosyaları

## GUI Açıklaması
- Butonlar üzerinden mikrodenetleyiciye komut gönderilmektedir.
- Gelen veriler GUI ekranında kullanıcıya gösterilmektedir.
- Veri akışı çift yönlü olarak çalışmaktadır.

## Not
- UART baud rate, veri bitleri ve stop bitleri kod içerisinde
  açıklamalı şekilde belirtilmiştir.

## Bağlantı Şeması
![ADC Bağlantı Şeması](Baglanti_Semasi_ADC.png)
