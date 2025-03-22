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

 


