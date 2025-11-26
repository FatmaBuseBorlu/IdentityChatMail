<div align="center">

  <img src="https://cdn-icons-png.flaticon.com/512/9069/9069049.png" alt="IdentityMail Logo" width="120" height="120" />
  
  <h1>📧 IdentityMail</h1>
  
  <p>
    <b>ASP.NET Core & Quixlab Teması ile Geliştirilmiş<br>Modern Kurumsal İçi Mesajlaşma Sistemi</b>
  </p>

  <p>
    <a href="https://dotnet.microsoft.com/en-us/apps/aspnet/mvc">
      <img src="https://img.shields.io/badge/.NET%20Core-6.0%20%2F%208.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" alt=".NET Core">
    </a>
    <a href="https://getbootstrap.com/">
      <img src="https://img.shields.io/badge/Bootstrap-5-563D7C?style=for-the-badge&logo=bootstrap&logoColor=white" alt="Bootstrap">
    </a>
    <a href="https://www.microsoft.com/en-us/sql-server">
      <img src="https://img.shields.io/badge/MSSQL-Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white" alt="MSSQL">
    </a>
    <a href="https://learn.microsoft.com/en-us/ef/">
      <img src="https://img.shields.io/badge/Entity%20Framework-Code%20First-blue?style=for-the-badge&logo=nuget&logoColor=white" alt="EF Core">
    </a>
  </p>

  <br>
</div>

---

## 🚀 Proje Hakkında

Merhaba! 👋 **IdentityMail**, ASP.NET Core altyapısı üzerine inşa ettiğim ve modern **Quixlab Admin Teması** ile giydirdiğim kapsamlı bir kurumsal içi mesajlaşma (mail) simülasyonudur.

Bu projeye başlarken aslında basit bir sohbet uygulaması yapmayı planlıyordum. Ancak geliştirme sürecinde *"Neden daha profesyonel bir yapı olmasın?"* diyerek projeyi; Gelen/Giden kutusu, Çöp kutusu mantığı (Soft Delete), Yıldızlama ve detaylı Profil yönetimi gibi özelliklerle donattım. Sonuç olarak ortaya tam fonksiyonlu, yaşayan bir e-posta yönetim sistemi çıktı.

### 🎯 Neden Bu Projeyi Yaptım?
Bu projeyi geliştirirken temel motivasyonum sadece kod yazmak değildi. Asıl hedefim; hazır ve karmaşık bir Admin Paneli temasının (Quixlab), **ASP.NET Core MVC** mimarisine parçalanarak (Partial Views, Layouts, Components) nasıl hatasız bir şekilde entegre edileceğini öğrenmekti. Aynı zamanda arka planda **Identity** kütüphanesi ile güvenli ve yönetilebilir bir üyelik sisteminin mimarisini deneyimlemek istedim.

---

## 🔥 Temel Özellikler

* **Modern UI/UX:** Quixlab teması projenin ihtiyaçlarına göre özel olarak revize edildi. Gereksiz menüler atıldı, kullanıcıyı yormayan sade ve odaklı bir yapı kuruldu.
* **Mesajlaşma Sistemi:**
    * **Gelen & Giden Kutusu:** Kullanıcılar sistemdeki diğer kullanıcılara mail gönderebilir ve gelenleri okuyabilir.
    * **Akıllı Cevapla (Reply):** Gelen mesaja "Cevapla" denildiğinde, alıcı adresi ve konu başlığı (Re: formatında) otomatik olarak doldurulur.
    * **Anlık Arama:** Konu başlıklarında büyük/küçük harf duyarlılığı olmadan anlık arama yapılabilir.
* **Soft Delete (Çöp Kutusu):** Silinen mesajlar veritabanından hemen uçmaz! Gerçek bir mail deneyimi için önce "Çöp Kutusu"na taşınır (`IsTrash`), istenirse oradan kalıcı olarak silinebilir.
* **Favoriler (Yıldızlama):** Önemli mesajlar tek tıkla (AJAX ile sayfa yenilenmeden) yıldızlanarak ayrı bir sekmede filtrelenebilir.
* **Profil Yönetimi:**
    * Kullanıcılar Ad, Soyad ve Şifre bilgilerini güncelleyebilir.
    * **Profil Resmi:** Kullanıcılar kendi profil fotoğraflarını yükleyebilir. Yüklenen fotoğraflar sunucuda (`wwwroot`) saklanır ve sistem genelinde dinamik olarak görünür.
* **Bildirimler:** Mesaj gönderimi veya silme işlemlerinde standart, sıkıcı tarayıcı uyarıları yerine modern **SweetAlert** popup'ları kullanıldı.

---

## 🛠️ Teknik Detaylar

* **Framework:** .NET 6.0 / .NET 8.0 (Core MVC)
* **Veritabanı:** MSSQL Server
* **ORM:** Entity Framework Core (Code First Yaklaşımı)
* **Authentication:** ASP.NET Core Identity
* **Frontend:** HTML5, CSS3, Bootstrap, jQuery
* **Kütüphaneler:** SweetAlert2, FontAwesome

---

## 📸 Proje Ekran Görüntüleri

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


<div align="center">
  <sub>IdentityMail © 2025</sub>
</div>
