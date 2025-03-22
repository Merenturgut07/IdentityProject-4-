# ASP.NET Core ile Geliştirilmiş Identity Mail Projesi

Yazılım geliştirme sürecimde, MY YAZILIM EĞİTİM AKADEMİ DANIŞMANLIK bünyesinde, Murat Yücedağ öncülüğünde gerçekleştirdiğim dördüncü proje olan Identity Mail projesini başarıyla tamamladım. Bu proje, kullanıcı kimlik doğrulama ve yetkilendirme süreçlerini yönetmek için ASP.NET Core Identity kütüphanesi temel alınarak geliştirilmiştir.

##  Proje Senaryosu

Bu projede kullanıcılar:

E-posta adresleriyle sisteme kayıt olabilir,

Giriş yaparak diğer kayıtlı kullanıcılarla mesajlaşabilir,

Gelen mesajlarını sınıflandırabilir ve yönetebilir,

Şifrelerini sıfırlayabilir ve değiştirebilir,

E-posta üzerinden doğrulama bağlantıları alarak güvenlik işlemlerini gerçekleştirebilir,

LockOutEnable özelliği sayesinde belirli sayıda hatalı giriş denemesinden sonra sistem tarafından engellenebilir.

🚀 Kullanılan Teknolojiler ve Mimari

Bu projeyi geliştirirken N-Tier Architecture (Katmanlı Mimari) prensiplerine tam anlamıyla uyuldu. Proje, 5 ana katmandan oluşmaktadır:

📃 Entity Layer

Veritabanı tablolarını temsil eden entity sınıflarını içerir.

🔎 DataAccess Layer

Veritabanı işlemlerini yönetir ve Repository Design Pattern uygulanarak kodun daha modüler ve sürdürülebilir olmasını sağlar.

⚙️ Business Layer

İş mantığını kapsar ve Fluent Validation kullanarak veri doğrulama işlemlerini gerçekleştirir.

🌐 Web API

RESTful API mimarisine uygun olarak dış dünya ile iletişimi sağlar.

📚 Web UI

HTML, CSS ve Bootstrap kullanılarak geliştirilen arayüz, kullanıcı dostu bir deneyim sunmaktadır.

JavaScript ve LINQ ile dinamik işlemler gerçekleştirilmiştir.

🔐 Güvenlik ve Kimlik Doğrulama Özellikleri

Projenin en önemli yapı taşlarından biri olan ASP.NET Core Identity kütüphanesi sayesinde şu özellikler başarıyla entegre edilmiştir:

Kayıt ve giriş işlemleri,

Şifre sıfırlama ve değiştirme,

E-posta doğrulama ile hesap aktivasyonu,

Google ve Facebook entegrasyonları sayesinde sosyal medya hesapları ile giriş yapabilme,

LockOutEnable ile belirli süre giriş kitleme,

Kullanıcı bazlı mesajlaşma sistemi.

📧 Öne Çıkan Özellikler

Bu projede kullanıcıların mesajlarını daha etkin yönetebilmesi için özel bir silme mekanizması geliştirildi. Mesajlaşma sistemlerinde genellikle bir kullanıcı bir mesajı sildiğinde karşı tarafın mesaj kutusunda görünmeye devam eder. Ancak bu projede bool tipi değişkenler kullanılarak her iki tarafın da mesaj geçmişini kontrol edebilmesi sağlandı.

📌 Diğer Kullanılan Teknolojiler

ASP.NET Core 6.0

Entity Framework / Code First

Microsoft SQL Server (MSSQL)

Repository Design Pattern

ViewComponents

DTOs (Data Transfer Objects)

DataTable Kullanımı

LINQ Sorguları

Async Programming

🌟 Sonuç

Bu proje sayesinde ASP.NET Core Identity ve katmanlı mimari konularında derinlemesine bilgi sahibi oldum. Kullanıcı deneyimini geliştirmek için Fluent Validation gibi doğrulama tekniklerini, veri güvenliğini artırmak için ise kimlik doğrulama ve yetkilendirme süreçlerini detaylıca inceledim.

Siz de projeyi incelemek ve geri bildirimde bulunmak için bağlantıyı ziyaret edebilirsiniz! 🙌
