# 📦 Anbar İdarəetmə Sistemi (ASP.NET Core MVC)

Bu layihə, kiçik və orta ölçülü anbarlar üçün məhsulların giriş-çıxışını izləmək məqsədilə hazırlanmış sadə və effektiv bir idarəetmə sistemidir. İstifadəçilər məhsul əlavə edə, mövcud məhsulların sayını artıra, satış edə və tükənmiş məhsulları sistemdən silə bilərlər.

## 🚀 Özəlliklər

* **Məhsul Əlavə Etmə:** Yeni məhsul adı və miqdarı ilə anbara daxil edilir.
* **Ağıllı Axtarış:** Əgər əlavə edilən məhsul artıq bazada varsa (böyük-kiçik hərf fərqi olmadan), sistem yeni sətir yaratmır, sadəcə mövcud olanın sayını artırır.
* **Satış Modulu:** Hər klikdə məhsulun sayı bir vahid azalır.
* **Stok Xəbərdarlığı:** Məhsulun sayı 0-a düşdükdə vizual olaraq "Tükənib" xəbərdarlığı çıxır və brauzer tərəfindən bildiriş (alert) göstərilir.
* **Təmizlik:** Tükənmiş məhsulları tək düymə ilə sistemdən tamamilə silmək mümkündür.
* **Modern Dizayn:** Tamamilə "responsive" və gözyormayan interfeys.

## 🛠 Texnologiyalar

* **Framework:** ASP.NET Core 8.0 (MVC)
* **Verilənlər Bazası:** SQLite (Fayl əsaslı baza)
* **ORM:** Entity Framework Core
* **Frontend:** HTML5, CSS3 (Modern UI)

## 📂 Layihə Strukturu

* `Controllers/HomeController.cs`: Bütün məntiqi əməliyyatların (Add, Sell, Delete) idarə olunduğu mərkəz.
* `Models/Product.cs`: Məhsulun verilənlər bazasındakı model quruluşu.
* `Views/Home/Index.cshtml`: İstifadəçi interfeysi və CSS üslubları.
* `anbar.db`: Məlumatların saxlandığı SQLite baza faylı.

## ⚙️ Quraşdırma və İşə Salma

Layihəni öz kompüterinizdə işə salmaq üçün aşağıdakı addımları izləyin:

1.  Layihəni klonlayın:
    ```bash
    git clone [https://github.com/istifadeci_adin/anbar-sistemi.git](https://github.com/istifadeci_adin/anbar-sistemi.git)
    ```
2.  Qovluğa daxil olun:
    ```bash
    cd tapsirig
    ```
3.  Kitabxanaları bərpa edin:
    ```bash
    dotnet restore
    ```
4.  Verilənlər bazasını yaradın (Miqrasiyaları tətbiq edin):
    ```bash
    dotnet ef database update
    ```
5.  Layihəni işə salın:
    ```bash
    dotnet run
    ```
6.  Brauzerdə açın: `http://localhost:5000` (və ya terminalda göstərilən portda)

## 📸 Ekran Görüntüsü
![Anbar Sistemi Interfeysi](https://via.placeholder.com/600x400?text=Anbar+Sistemi+UI)

---
Hazırladı: **Farhad Karimov**
