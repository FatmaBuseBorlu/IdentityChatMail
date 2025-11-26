<h1 style="border-bottom: none;">📧 IdentityChatMail</h1>

## 🚀 Proje Hakkında

**IdentityMail**, ASP.NET Core altyapısı üzerine kurgulanmış, modern Quixlab admin teması ile giydirilmiş bir iç mesajlaşma (mail) simülasyonudur.

Proje, standart bir CRUD uygulamasının ötesine geçerek; **Soft Delete (Çöp Kutusu)**, **Favorilere Ekleme (Yıldızlama)**, **Akıllı Arama** ve **Profil Yönetimi** gibi gelişmiş özellikleri barındırır. Identity kütüphanesi ile güvenli bir kullanıcı altyapısı sunar.

---

## 🔥 Temel Özellikler

* **Modern UI/UX:** Quixlab teması projenin ihtiyaçlarına göre özel olarak revize edildi. Gereksiz menüler atıldı, kullanıcıyı yormayan sade ve odaklı bir yapı kuruldu.
* **Mesajlaşma Sistemi:**
    * **Gelen & Giden Kutusu:** Kullanıcılar sistemdeki diğer kullanıcılara mail gönderebilir ve gelenleri okuyabilir.
    * **Akıllı Cevapla (Reply):** Gelen mesaja "Cevapla" denildiğinde, alıcı adresi ve konu başlığı (Re: formatında) otomatik olarak doldurulur.
    * **Anlık Arama:** Konu başlıklarında büyük/küçük harf duyarlılığı olmadan anlık arama yapılabilir.
* **Soft Delete (Çöp Kutusu):** Silinen mesajlar veritabanından hemen uçmaz. Gerçek bir mail deneyimi için önce "Çöp Kutusu"na taşınır (`IsTrash`), istenirse oradan kalıcı olarak silinebilir.
* **Favoriler (Yıldızlama):** Önemli mesajlar tek tıkla yıldızlanarak ayrı bir sekmede filtrelenebilir.
* **Profil Yönetimi:**
    * Kullanıcılar Ad, Soyad ve Şifre bilgilerini güncelleyebilir.
* **Bildirimler:** Mesaj gönderimi veya silme işlemlerinde standart, sıkıcı tarayıcı uyarıları yerine modern **SweetAlert** popup'ları kullanıldı.

---

## 🛠️ Teknik Detaylar

* **Framework:** .NET 6.0 / .NET 8.0 (Core MVC)
* **Veritabanı:** MSSQL Server
* **ORM:** Entity Framework Core (Code First Yaklaşımı)
* **Authentication:** ASP.NET Core Identity
* **Frontend:** HTML5, CSS3, Bootstrap, jQuery

---

## 📸 Proje Görselleri

Uygulamanın modern arayüzünden kareler:

| 🔐 Giriş Ekranı | 📩 Gelen Kutusu (Inbox) |
| :---: | :---: |
| <img src="GÖRSEL_LINKI_BURAYA_1" width="400"> | <img src="GÖRSEL_LINKI_BURAYA_2" width="400"> |
| *Sadeleştirilmiş Login* | *İsimsiz, Konu Odaklı Liste* |

| 📝 Mesaj Oluştur | 📖 Mesaj Okuma |
| :---: | :---: |
| <img src="GÖRSEL_LINKI_BURAYA_3" width="400"> | <img src="GÖRSEL_LINKI_BURAYA_4" width="400"> |
| *Odaklanmış Form Yapısı* | *Tam Ekran Okuma & Aksiyonlar* |

| 🗑️ Çöp Kutusu | |
| :---: | :---: |
| <img src="GÖRSEL_LINKI_BURAYA_5" width="400"> | |
| *Silinen Mesaj Yönetimi* | |



