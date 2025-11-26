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

Uygulamanın tüm arayüz ve özelliklerinden kareler:

| 🔐 Giriş Ekranı | 📝 Kayıt Ol Ekranı |
| :---: | :---: |
| <img src="Görseller/Login.png" width="400"> | <img src="Görseller/Register.png" width="400"> |
| *Kullanıcı Girişi* | *Yeni Kullanıcı Kaydı* |

| 📩 Gelen Kutusu (Inbox) | 📤 Gönderilmiş Postalar |
| :---: | :---: |
| <img src="Görseller/Homepage.png" width="400"> | <img src="Görseller/SendBox.png" width="400"> |
| *Gelen Mesajlar Listesi* | *Giden Mesajlar Listesi* |

| ✍️ Yeni Mesaj Oluştur | ⭐ Yıldızlı Mesajlar |
| :---: | :---: |
| <img src="Görseller/Create%20Message.png" width="400"> | <img src="Görseller/Starred%20Message.png" width="400"> |
| *Mesaj Gönderme Formu* | *Favorilere Eklenenler* |

| 👤 Profil Sayfası | 🗑️ Çöp Kutusu |
| :---: | :---: |
| <img src="Görseller/Profile.png" width="400"> | <img src="Görseller/Trash.png" width="400"> |
| *Kişisel Bilgi Güncelleme* | *Silinen Mesajlar* |

| 🔍 Arama Sonucu | ✅ Başarılı İşlem |
| :---: | :---: |
| <img src="Görseller/Search.png" width="400"> | <img src="Görseller/Successful%20query.png" width="400"> |
| *Konu Başlığına Göre Filtreleme* | *SweetAlert Başarılı Bildirimi* |

| ⚠️ Silme Onayı | |
| :---: | :---: |
| <img src="Görseller/Delete%20query.png" width="400"> | |
| *Silme İşlemi İçin Onay Penceresi* | |
