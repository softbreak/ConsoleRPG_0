# Console RPG — C# ile Metin Tabanlı RPG Projesi

Bu repository, C# ve nesne yönelimli programlama prensipleri kullanılarak geliştirilmiş metin tabanlı bir RPG/MMORPG console uygulamasını içerir.

Proje; karakter oluşturma, sınıf ve ırk seçimi, savaş mekanikleri, ekipman, bonus özellikler ve ödül sistemi gibi temel RPG kavramlarını C# nesneleri üzerinden modellemek amacıyla hazırlanmıştır.

Bu çalışma aynı zamanda Softbreak YouTube kanalındaki C# OOP serisinde kullanılan MMORPG senaryosunun daha geniş bir uygulama örneğidir.

---

## Projede Neler Var?

Uygulamada kullanıcı:

- oyuna giriş yapar,
- karakter oluşturur,
- karakter sınıfı seçer,
- karakter ırkı seçer,
- maceraya çıkar,
- yaratıklarla savaşır,
- yakın veya uzak saldırı yapar,
- ödül kazanır,
- ekipman elde edebilir.

Oyun dünyası farklı domain nesneleriyle modellenmiştir.

---

## Domain Modeli

Projede yer alan bazı temel sınıflar:

- `Karakter`
- `Sinif`
- `Irk`
- `Yaratik`
- `ElitYaratik`
- `Silah`
- `Zirh`
- `Esya`
- `Gorev`
- `Bolge`
- `Sehir`
- `Kita`
- `Zindan`
- `Tilsim`

Ayrıca bonus özellikleri için enum ve ortak davranışlar için interface yapıları kullanılmaktadır.

---

## Oyun Akışı

Temel akış:

**Giriş → Karakter Oluşturma → Sınıf Seçimi → Irk Seçimi → Macera → Savaş → Ödül**

Savaş sırasında karakter ve yaratıkların:

- can,
- defans,
- yakın saldırı,
- uzak saldırı

değerleri üzerinden sonuç hesaplanır.

Bazı savaşların sonunda karakter para veya bonus özelliklere sahip bir silah kazanabilir.

---

## OOP ile İlişkisi

Bu proje yalnızca bir console oyunu değildir.

MMORPG senaryosu üzerinden:

- class ve object,
- constructor,
- encapsulation,
- inheritance,
- polymorphism,
- interface,
- composition,
- domain modelleme

gibi nesne yönelimli programlama konularını somutlaştırmak için kullanılabilir.

---

## YouTube OOP Serisi

Bu projenin kullandığı MMORPG senaryosunun OOP kavramları üzerinden adım adım geliştirildiği eğitim serisine buradan ulaşabilirsin:

[C# Nesne Yönelimli Programlama — MMORPG Senaryosu](https://www.youtube.com/playlist?list=PLDSvesNxEuJPY01yOb-wzLP7Ykv4v5nTI)

Serinin ders bazındaki kaynak kodları ayrıca şu repository'de bulunur:

[softbreak/OOP](https://github.com/softbreak/OOP)

---

## Teknolojiler

- C#
- .NET Framework 4.7.2
- Console Application
- Object-Oriented Programming

---

## Projeyi Çalıştırmak

Repository'yi clone et:

    git clone https://github.com/softbreak/ConsoleRPG_0.git

Proje klasörüne geç:

    cd ConsoleRPG_0

Solution dosyasını Visual Studio ile aç:

    ConsoleRPG_0.sln

Proje .NET Framework 4.7.2 kullanmaktadır.

---

## Not

Bu repository, OOP eğitim serisinin ders bazında ayrılmış kaynak kodlarından farklı olarak RPG senaryosunu daha geniş bir uygulama halinde gösterir.

Dersleri adım adım takip etmek için `softbreak/OOP` repository'sini kullanabilirsin.

---

## Softbreak

📺 [YouTube](https://youtube.com/@softbreak)

🌐 [softbreak.net](https://softbreak.net)
