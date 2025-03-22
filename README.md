# ASP.NET Core ile Geliştirilmiş Identity Mail Projesi

Yazılım geliştirme sürecimde, MY YAZILIM EĞİTİM AKADEMİ DANIŞMANLIK bünyesinde, Murat Yücedağ öncülüğünde gerçekleştirdiğim dördüncü proje olan Identity Mail projesini başarıyla tamamladım. Bu proje, kullanıcı kimlik doğrulama ve yetkilendirme süreçlerini yönetmek için ASP.NET Core Identity kütüphanesi temel alınarak geliştirilmiştir.

##  Proje Senaryosu
Bu projede kullanıcılar:  sisteme kayıt olabilir, Giriş yaparak diğer kayıtlı kullanıcılarla mesajlaşabilir, Şifrelerini sıfırlayabilir ve değiştirebilir, LockOutEnable özelliği sayesinde belirli sayıda hatalı giriş denemesinden sonra sistem tarafından engellenebilir.

## Güvenlik ve Kimlik Doğrulama Özellikleri
Projenin en önemli yapı taşlarından biri olan ASP.NET Core Identity kütüphanesi sayesinde şu özellikler başarıyla entegre edilmiştir:
Kayıt ve giriş işlemleri,
Şifre sıfırlama ve değiştirme,
LockOutEnable ile belirli süre giriş kitleme,
Kullanıcı bazlı mesajlaşma sistemi.


## Diğer Kullanılan Teknolojiler
ASP.NET Core 6.0
Entity Framework / Code First
Microsoft SQL Server (MSSQL)
Repository Design Pattern
ViewComponents
LINQ Sorguları
Async Programming

## Kullanılan  Mimari
Bu projeyi geliştirirken N-Tier Architecture (Katmanlı Mimari) prensiplerine tam anlamıyla uyuldu. Proje, 4 ana katmandan oluşmaktadır:
 Entity Layer: Veritabanı tablolarını temsil eden entity sınıflarını içerir.
 DataAccess Layer: Veritabanı işlemlerini yönetir ve Repository Design Pattern uygulanarak kodun daha modüler ve sürdürülebilir olmasını sağlar.
 Business Layer: İş mantığını kapsar ve Fluent Validation kullanarak veri doğrulama işlemlerini gerçekleştirir.
 Web UI: HTML, CSS ve Bootstrap kullanılarak geliştirilen arayüz, kullanıcı dostu bir deneyim sunmaktadır.
<br/>
<br/>
### Giriş Yapma Ve Kayıt Olma İşlemleri
![Image](https://github.com/user-attachments/assets/3dcb4b08-6522-455f-ac67-749af730162f)
![Image](https://github.com/user-attachments/assets/7dd30970-c976-4bd4-882c-953e334b7e64)
<br/>
<br/>
 ### Dashboard 
 _Sisteme Giriş Yapan Kullanıcının Bilgileriyle Geliyor
![Skydash Admin ve diğer 1 sayfa - Profil 1 - Microsoft​ Edge 22 03 2025 15_16_07](https://github.com/user-attachments/assets/f8776e0b-e275-4d89-b089-1e624e14316e)
![Skydash Admin ve diğer 1 sayfa - Profil 1 - Microsoft​ Edge 22 03 2025 15_15_38](https://github.com/user-attachments/assets/78ae46fc-1dc7-4100-8fd2-98ed2aec7e02)
![Skydash Admin - Profil 1 - Microsoft​ Edge 22 03 2025 15_20_45](https://github.com/user-attachments/assets/754f4997-ed8e-4a68-baf7-4f959dd7af3e)
![Skydash Admin ve diğer 1 sayfa - Profil 1 - Microsoft​ Edge 22 03 2025 15_16_21](https://github.com/user-attachments/assets/e85bec44-50fd-4cec-8687-43c73a32f90a)
![Skydash Admin ve diğer 1 sayfa - Profil 1 - Microsoft​ Edge 22 03 2025 15_16_14](https://github.com/user-attachments/assets/a0c60bf0-cc32-4f71-9a71-461f80a38a26)
<br/>
<br/>
### Profilim 
![Image](https://github.com/user-attachments/assets/1ab93967-d117-4f27-94b4-11cbf2f1a894)
<br/>
<br/>
### Mesajlaşma İşlemi, Yeni Mesaj Gönderme İşlemi
![Image](https://github.com/user-attachments/assets/21972e8a-9f40-4423-8cf1-a819cc4acedb)
![Image](https://github.com/user-attachments/assets/21d1568c-2a11-4681-8de1-49b73969e296)
![Image](https://github.com/user-attachments/assets/b8ac3fcc-11a4-4e80-b08e-04e03f3bccd4)
![Image](https://github.com/user-attachments/assets/dfc48432-d812-4cf5-8485-0b20aeecbfda)

