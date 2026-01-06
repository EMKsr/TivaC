# Ödev 3 – LCD Üzerinde ADC Değer Okuma

Bu ödevde analog bir girişten (potansiyometre veya sensör)
alınan gerilim değeri ADC ile okunarak LCD ekran üzerinde
gösterilmiştir.

## Çalışma Prensibi
- ADC modülü uygun çözünürlükte yapılandırılmıştır.
- Okunan ADC değeri string formatına dönüştürülerek LCD'ye yazdırılmıştır.

## İçerik
- main.c : ADC konfigürasyonu ve LCD gösterimi
- devre.png : ADC ve LCD bağlantı şeması / sistem görseli

## Açıklamalar
- ADC örnekleme süresi ve referans ayarları kod içerisinde açıklanmıştır.
- Gerilim değişimi LCD ekran üzerinde gerçek zamanlı izlenebilmektedir.
