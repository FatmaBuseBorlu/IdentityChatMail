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

Proje sadece kod yazmak için değil; **UI/UX (Kullanıcı Deneyimi)**, **Soft Delete (Çöp Kutusu)** ve **Akıllı Arama** gibi gerçek dünya senaryolarını simüle etmek için tasarlanmıştır.

---

## 📸 Ekran Görüntüleri

Uygulamanın modern arayüzünden kareler:

| 🔐 Giriş Ekranı | 📩 Gelen Kutusu (Inbox) |
| :---: | :---: |
| <img src="GÖRSEL_LINKI_BURAYA_1" width="400"> | <img src="GÖRSEL_LINKI_BURAYA_2" width="400"> |
| *Sadeleştirilmiş Login* | *İsimsiz, Konu Odaklı Liste* |

| 📝 Mesaj Oluştur | 👤 Profil Kartı |
| :---: | :---: |
| <img src="GÖRSEL_LINKI_BURAYA_3" width="400"> | <img src="GÖRSEL_LINKI_BURAYA_4" width="400"> |
| *Odaklanmış Form Yapısı* | *Kişisel Bilgi Yönetimi* |

| 📖 Mesaj Okuma | 🗑️ Çöp Kutusu |
| :---: | :---: |
| <img src="GÖRSEL_LINKI_BURAYA_5" width="400"> | <img src="GÖRSEL_LINKI_BURAYA_6" width="400"> |
| *Tam Ekran Okuma & Aksiyonlar* | *Silinen Mesaj Yönetimi* |

---

## ✨ Öne Çıkan Özellikler

### 🎨 1. Modern UI & UX
* **Quixlab Entegrasyonu:** Admin teması parçalanarak (Layout) MVC yapısına hatasız entegre edildi.
* **Akıllı Navigasyon:** Mesaj detayındayken "Geri Dön" butonu ile geldiğiniz listeye (Gelen/Giden/Çöp) dönebilirsiniz.
* **Temiz Liste:** Mesaj listelerinde karmaşık mail adresleri yerine sadece **Konu** ve **Mesaj Özeti** gösterilir.

### ⚙️ 2. Teknik Özellikler
* **Soft Delete (Çöp Kutusu):** Sil butonuna basıldığında veri silinmez, `IsTrash` flag'i ile Çöp Kutusuna taşınır.
* **Yıldızlama (AJAX):** Sayfa yenilenmeden mesajlar favorilere eklenir.
* **Akıllı Arama:** `Contains` ve `ToLower` algoritmalarıyla konu başlıklarında anlık arama yapılır.
* **Reply (Cevapla):** Gelen mesaja cevap verirken `Re:` konusu ve alıcı otomatik doldurulur.

### 🛡️ 3. Güvenlik
* **ASP.NET Core Identity:** Güvenli giriş, kayıt ve çıkış işlemleri.
* **Profil Yönetimi:** Kullanıcılar şifrelerini ve profil fotoğraflarını güncelleyebilir. Yüklenen resimler sunucuda (`wwwroot`) saklanır.

---

## 👨‍💻 Geliştirici Notu

> Bu proje, bir Admin Temasının MVC mimarisine **"Best Practice"** (En İyi Uygulama) yöntemleriyle nasıl giydirileceğini ve kullanıcı deneyiminin (UX) backend kodlarıyla nasıl destekleneceğini göstermek amacıyla geliştirilmiştir.

<div align="center">
  <sub>IdentityMail © 2025 - Geliştirici: Adınız Soyadınız</sub>
</div>
