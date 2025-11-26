📧 IdentityMail - Kurumsal İçi Mesajlaşma Sistemi
IdentityMail, ASP.NET Core altyapısı üzerine kurgulanmış, modern Quixlab admin teması ile giydirilmiş bir iç mesajlaşma (mail) simülasyonudur.

Proje, standart bir CRUD uygulamasının ötesine geçerek; Soft Delete (Çöp Kutusu), Favorilere Ekleme (Yıldızlama), Akıllı Arama ve Profil Yönetimi gibi gelişmiş özellikleri barındırır. Identity kütüphanesi ile güvenli bir kullanıcı altyapısı sunar.

📸 Proje Ekran Görüntüleri
Uygulamanın arayüzünden ve temel özelliklerinden kareler:

1. Giriş ve Kayıt Ekranı
Quixlab temasının sadeleştirilmiş login/register arayüzü.

2. Gelen Kutusu (Inbox)
Kullanıcı dostu liste yapısı. Gönderen ismi yerine konu ve mesaj özeti gösterimi. Sağ tarafta tarih ve yıldızlama özelliği.

3. Mesaj Okuma ve Detay
Tam ekran okuma modu. Gönderen profil ikonu, tarih ve sağ üstte akıllı aksiyon butonları (Geri Dön, Sil).

4. Yeni Mesaj Oluşturma (Compose)
Sadeleştirilmiş form yapısı. Sol menü gizlenerek odaklanma sağlandı.

5. Profil Yönetimi
Kullanıcının bilgilerini güncelleyebildiği ve profil fotoğrafı yükleyebildiği kart yapısı.

✨ Öne Çıkan Özellikler
Modern UI Entegrasyonu: Quixlab Admin Dashboard teması projeye başarıyla entegre edildi (Layout, Partial Views).

Akıllı Arama: Mesaj başlıklarında anlık arama yapılabilir (Case-insensitive).

Soft Delete (Çöp Kutusu): Silinen mesajlar veritabanından tamamen uçmaz, önce Çöp Kutusuna taşınır (IsTrash).

Favoriler: Önemli mesajlar tek tıkla yıldızlanarak ayrı bir listede tutulur.

UX İyileştirmeleri:

SweetAlert: İşlem başarılı uyarıları için modern popup'lar.

Reply (Cevapla): Gelen mesaja cevap verirken alıcı ve konu (Re:) otomatik dolar.

Profil Resmi: Yüklenen resimler sunucuda (wwwroot) saklanır ve sistem genelinde dinamik olarak gösterilir.

🛠️ Teknolojiler
Backend: ASP.NET Core MVC (.NET 6.0 / 8.0)

Veritabanı: MSSQL Server, Entity Framework Core (Code First)

Authentication: ASP.NET Core Identity

Frontend: HTML5, CSS3, JavaScript (jQuery)

Kütüphaneler: SweetAlert2, FontAwesome
