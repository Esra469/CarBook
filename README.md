# CarBook — Araç Kiralama ve Rezervasyon Sistemi

**CarBook**, araç kiralama süreçlerini, araç özellik/fiyatlandırma yönetimini, lokasyon bazlı rezervasyon akışını ve içerik/blog modüllerini katmanlı ve CQRS odaklı bir yapıda sunan **.NET** tabanlı bir web ve API uygulamasıdır.

---

## Mimari Yapı

Projede iş kuralları, veri erişimi, API ve sunum katmanları birbirinden ayrıştırılarak şu dizin yapısıyla kurgulanmıştır:

* **`Core/`**: Temel domain modelleri (`Entities`), uygulama katmanı (`Application`), iş kuralları ve CQRS (`Commands` / `Queries` / `Handlers` / `DTOs`) bileşenleri.
* **`Infrasturcture/CarBookPersistence/`**: Veritabanı bağlamı (`Context`), Entity Framework Core konfigürasyonları ve repository uygulamaları.
* **`Presentation/CarBook.WebApi/`**: Dış dünyaya ve istemcilere açılan RESTful API uç noktaları ve controller katmanı.
* **`Frontends/`**: Kullanıcı arayüzü, sayfa görünümleri (`Views` / `ViewComponents`) ve API ile haberleşen istemci katmanı.
* **`CarBook.sln`**: Tüm projeleri bir arada yöneten Visual Studio çözüm dosyası.

---

## Kullanılan Teknolojiler

* **Platform & Dil:** C#, .NET (ASP.NET Core WebApi & Frontend)
* **Mimari Yaklaşım:** Katmanlı Mimari, CQRS Pattern
* **Veri Erişimi:** Entity Framework Core, SQL Server
* **Araçlar:** Visual Studio, Git / GitHub

---

## Öne Çıkan Özellikler

* **Araç ve Fiyatlandırma Yönetimi:** Marka, model, araç özellikleri ve farklı kiralama periyotlarına göre fiyatlandırma kayıtlarının yönetilmesi.
* **Lokasyon ve Rezervasyon Akışı:** Alış/bırakış lokasyonlarının seçimi ve araç rezervasyon kayıtlarının oluşturulması.
* **İçerik ve İstatistik Modülleri:** Blog yazıları, yazar/etiket yapıları ve araç/fiyat istatistiklerinin sunumu.

---

## Kurulum ve Çalıştırma

### 1. Repoyu Klonlayın
```bash
git clone [https://github.com/Esra469/CarBook.git](https://github.com/Esra469/CarBook.git)
cd CarBook
