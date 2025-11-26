<div align="center">

  <img src="https://cdn-icons-png.flaticon.com/512/9069/9069049.png" alt="logo" width="100" height="100" />
  
  <h1>📧 IdentityMail</h1>
  
  <p>
    <b>ASP.NET Core & Quixlab Teması ile Geliştirilmiş<br>Modern Kurumsal İçi Mesajlaşma Sistemi</b>
  </p>

  <a href="https://dotnet.microsoft.com/">
    <img src="https://img.shields.io/badge/.NET%20Core-6.0%20%2F%208.0-512BD4?style=for-the-badge&logo=dotnet" alt=".NET Core">
  </a>
  <a href="#">
    <img src="https://img.shields.io/badge/Bootstrap-5-563D7C?style=for-the-badge&logo=bootstrap" alt="Bootstrap">
  </a>
  <a href="#">
    <img src="https://img.shields.io/badge/MSSQL-Server-CC2927?style=for-the-badge&logo=microsoft-sql-server" alt="MSSQL">
  </a>
  <a href="#">
    <img src="https://img.shields.io/badge/Entity%20Framework-Code%20First-blue?style=for-the-badge" alt="EF Core">
  </a>

  <br><br>
</div>

---

## 🚀 Proje Hakkında

**IdentityMail**, standart bir CRUD uygulamasının ötesine geçerek; kullanıcıların güvenli bir şekilde mesajlaşabildiği, **Identity** kütüphanesi ile korunan ve **Quixlab Admin Paneli** ile modernize edilmiş tam kapsamlı bir e-posta simülasyonudur.

Proje, hem frontend (UI/UX) hem de backend tarafında **gerçek dünya senaryoları** (Soft Delete, Profil Yönetimi, Dinamik Resim Yükleme vb.) dikkate alınarak geliştirilmiştir.

---

## 📸 Proje Ekran Görüntüleri

Uygulamanın modern arayüzünden ve özelliklerinden kareler:

### 1. Giriş ve Kayıt Ekranı
*Quixlab temasının sadeleştirilmiş, `_Layout`'tan bağımsız tam ekran login/register arayüzü.*

<br>
[GÖRSEL BURAYA GELECEK - Login Ekranı]
<br>
<br>

---

### 2. Gelen Kutusu (Inbox) & Gönderilmiş Postalar
*Kullanıcı dostu liste yapısı. Karmaşık mail adresleri yerine sadece **Konu Başlığı** ve **Mesaj Özeti** gösterimi. Sağ tarafta tarih ve yıldızlama özelliği.*

<br>
[GÖRSEL BURAYA GELECEK - Inbox Ekranı]
<br>
<br>

---

### 3. Mesaj Okuma ve Detay
*Tam ekran okuma modu. Gönderen kişinin baş harfiyle oluşturulmuş dinamik avatar, tarih bilgisi ve sağ üstte akıllı aksiyon butonları (Geri Dön, Sil).*

<br>
[GÖRSEL BURAYA GELECEK - Message Detail Ekranı]
<br>
<br>

---

### 4. Yeni Mesaj Oluşturma (Compose)
*Sadeleştirilmiş form yapısı. Sol menü gizlenerek odaklanma sağlandı. Gönderim sonrası **SweetAlert** ile başarılı bildirimi.*

<br>
[GÖRSEL BURAYA GELECEK - Create Message Ekranı]
<br>
<br>

---

### 5. Profil Yönetimi ve Resim Yükleme
*Kullanıcının bilgilerini güncelleyebildiği ve profil fotoğrafı yükleyebildiği kart yapısı. Yüklenen resim header ve mesajlarda dinamik görünür.*

<br>
[GÖRSEL BURAYA GELECEK - Profil Ekranı]
<br>
<br>

---

## ✨ Geliştirilen Özellikler (12 Madde ve Fazlası)

Proje sürecinde aşağıdaki gereksinimler ve ekstra özellikler hayata geçirilmiştir:

### 🎨 Tasarım ve Arayüz
* **Quixlab Entegrasyonu:** Admin teması parçalanarak (Layout, Partial Views) MVC yapısına hatasız entegre edildi.
* **Sadeleştirilmiş Menü:** Gereksiz tüm linkler kaldırıldı. Sol menüde sadece *Mesaj Oluştur, Gelen, Giden, Çöp Kutusu* bırakıldı.
* **Temiz Liste Görünümü:** Mesaj listelerinde gönderen maili yerine, daha okunabilir olması için **Konu** ve **İçerik Özeti** ön plana çıkarıldı.

### ⚙️ Backend ve Fonksiyonlar
* **Soft Delete (Çöp Kutusu):** Silinen mesajlar veritabanından uçmaz (`IsTrash` flag), önce Çöp Kutusuna taşınır. İstenirse oradan kurtarılabilir.
* **Yıldızlama (Favorites):** Önemli mesajlar tek tıkla (AJAX ile sayfa yenilenmeden) favorilere eklenir.
* **Akıllı Arama:** Mesaj başlıklarında `Contains` metodu ile büyük/küçük harf duyarlılığı olmadan anlık arama yapılır.
* **Reply (Cevapla) Mekanizması:** Gelen mesaja cevap verilirken "Alıcı" ve "Konu" (Başına `Re:` eklenerek) otomatik doldurulur.

### 👤 Kullanıcı Deneyimi (UX)
* **SweetAlert:** İşlem başarılı uyarıları standart `alert()` yerine modern popup'larla sağlanır.
* **Profil Resmi:** Kullanıcılar profil fotoğrafı yükleyebilir. Bu fotoğraflar sunucuda (`wwwroot/userimages`) saklanır ve sistem genelinde dinamik gösterilir.
* **Geri Dön Butonu:** Mesaj detayındayken kullanıcının geldiği listeye dönmesini sağlayan akıllı navigasyon.

---

## 🛠️ Kullanılan Teknolojiler

* **Backend:** ASP.NET Core MVC (.NET 6.0 / 8.0)
* **Veritabanı:** MSSQL Server
* **ORM:** Entity Framework Core (Code First)
* **Authentication:** ASP.NET Core Identity
* **Frontend:** HTML5, CSS3 (Quixlab Theme), JavaScript (jQuery)
* **Kütüphaneler:** SweetAlert2, FontAwesome

---

<div align="center">
  <sub>IdentityMail © 2025 - Geliştirici: [Senin Adın]</sub>
</div>
