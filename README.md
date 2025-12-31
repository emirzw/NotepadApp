# 📝 Modern Not Defteri

Windows Forms ile geliştirilmiş, zengin metin desteği sunan gelişmiş bir not defteri uygulamasıdır.

## 📋 Özellikler

### Dosya İşlemleri
- Yeni dosya oluşturma
- RTF ve TXT formatlarında açma/kaydetme
- UTF-8 kodlama desteği

### Düzenleme
- Bul (Find) - `Ctrl+F`
- Bul ve Değiştir (Find & Replace)
- Satıra Git (Go To Line)
- Tümünü Seç (Select All)

### Görünüm
- **Açık/Koyu Tema** desteği
- **Yazı Tipi** değiştirme
- **Yakınlaştırma/Uzaklaştırma** - `Ctrl+Plus/Minus`
- **Sözcük Kaydırma** (Word Wrap)
- **Durum Çubuğu** göster/gizle

### Klavye Kısayolları
| Kısayol | İşlev |
|---------|-------|
| `Ctrl+F` | Bul |
| `Ctrl+H` | Bul ve Değiştir |
| `Ctrl+G` | Satıra Git |
| `Ctrl++` | Yakınlaştır |
| `Ctrl+-` | Uzaklaştır |
| `Ctrl+0` | Varsayılan Yakınlaştırma |

## 🛠️ Teknolojiler

- **C#** - .NET Windows Forms
- **RichTextBox** - Zengin metin desteği
- **Encoding** - UTF-8 dosya işleme

## 🚀 Kurulum

1. Visual Studio'da projeyi açın
2. Projeyi derleyin ve çalıştırın

## 📁 Proje Yapısı

```
NotepadApp/
├── Form1.cs          # Ana form, tüm editör mantığı
├── Form1.Designer.cs # Form tasarımcı ve menü yapısı
└── Program.cs        # Uygulama giriş noktası
```

## ✨ Öne Çıkan Özellikler

- Kaydedilmemiş değişikliklerde uyarı
- Başlık çubuğunda dosya adı ve değişiklik durumu (*)
- Özel giriş diyalogları (Find, Replace, Go To)
- RTF ve düz metin arasında geçiş

## 👨‍💻 Geliştirici

Yazılım Mühendisliği 2. Sınıf - Haftalık Proje
