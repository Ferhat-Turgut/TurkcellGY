# HANGFIRE

Hangfire, .NET geliştiricilerine, uygulamalarına arka planda çalışan görevleri eklemek ve yönetmek için bir yol sunan bir kütüphanedir. Bu görevler, genellikle zamanlanmış veya tekrarlayan işlerdir. Örneğin, kullanıcıya hoş geldin e-postası gönderme, veritabanı temizliği, rapor oluşturma gibi görevler Hangfire ile arka planda çalıştırılabilir.

Hangfire, basit ve anlaşılır bir API'ye sahiptir, bu da geliştiricilerin işleri kolayca tanımlayabilmesini sağlar. Hangfire, seçtiğiniz depolama sağlayıcısı üzerinde işleri saklar. Bu depolama sağlayıcısı, genellikle SQL Server, Redis veya PostgreSQL gibi veritabanlarıdır. Bu şekilde, işlerin durumunu takip edebilir, tamamlanan veya hata veren işleri yönetebilirsiniz.

Hangfire, uygulama durduğunda bile işleri korur ve devam eden işleri sürdürebilir. Böylece uygulamanızın sürekli çalışmasını sağlar ve işleri zamanında tamamlamanızı sağlar. Ayrıca, Hangfire'ın web tabanlı arayüzü ile işleri izleyebilir, durdurabilir, yeniden başlatabilir ve yönetebilirsiniz.

Hangfire, .NET uygulamalarında kullanıldığında performansı artırır ve ölçeklenebilir bir arka plan iş kuyruğu sağlar. Bu sayede uygulamalarınız daha etkili bir şekilde çalışabilir ve kullanıcılarınıza daha hızlı ve düzenli bir deneyim sunabilirsiniz.
<br/>

**Örneğin** her gün saat 18:30'da yapılması gereken bir işlem var.Bu mail atmak olabilir, gün sonu raporu olabilir.
Bu gibi durumlarda Hangfire kullanımı, zaman ve performans yönetimi açısından oldukça yararlıdır.Ayrıca kullanımı da oldukça basittir.
<br/><br/>
Aşağıdaki işlem belli bir zamanda ve sürekli yapılan bir işlem olsun.<br/>
![Yapılacak işlem](https://github.com/Ferhat-Turgut/TurkcellGY/blob/master/Hangfire/Images/Yap%C4%B1lacak%20i%C5%9F.JPG)
<br/><br/><br/>
Bu işlemi Hangfire ile şu şekilde yapabiliriz.
Öncelikle **Program.cs** içinde bir yapılandırma yapmalıyız.Fakat bunun için manage nuget packages'lerden **Hangfire**'yi eklemeliyiz.
Sonrasında **Program.cs**'ye kütüphane olarak `using Hangfire`'ı eklemeliyiz.<br/>
![Program.cs](https://github.com/Ferhat-Turgut/TurkcellGY/blob/master/Hangfire/Images/Programcs%20yap%C4%B1land%C4%B1rma%20ve%20addHangfire.JPG)
<br/><br/>
**builder.Services.AddHangfire** ile projemize Hangfire ekleyip yapılandırıyoruz.
Veritabanı adresini `connectionString` ile `UseSqlServerStorage`'e vererek SQL kullanacağımızı belirtiyoruz.
`RecurringJob` tekrar eden işlemler için kullanılır.`Delayjob` gecikmeli işlemler için kullanılır.
Biz burada `RecurringJob` kullanacağız.Çünkü belli bir zaman gelince işlemin sürekli tekrar etmesini istiyoruz.<br/>
`RecurringJob.AddOrUpdate` ise yoksa bu konfigürasyonu ekleyecek, varsa güncelleyecek.
`AddOrUpdate<Job>(j => j.DbControl(), "50 03  * * *")` kısmında generic olarak kullandık ve **Job** class'ını verdik.
**Job** class'ının DbControl() methodunu çalıştırmasını istedik.
Buradaki `"30 18  * * *"` formatı bir zamanlama formatıdır ve Hangfire gibi zamanlanmış görevlerin belirlenmesi için kullanılır.
Bu format, bir cron tablosu formatıdır ve görevin ne zaman çalışacağını belirtir.
Bu örnekte 18:30'da zamanlanmıştır.Yapılandırmada son olarak `builder.Services.AddHangfireServer();` ile servisi ekliyoruz.
<br/>
![useHandfire](https://github.com/Ferhat-Turgut/TurkcellGY/blob/master/Hangfire/Images/UseHandfireDasboard.JPG)
Son olarak yine **Program.cs**'de `app.UseHangfireDashboard();` ile kullanıyoruz.
<br/>
Projemizi çalıştırdığımızda belirttiğimiz isimde bir veritabanı ve tabloları oluşacak.Bu tablolar içinde kuyruktaki işlemler,işlem geçmişi vb. gibi birçok kayıt tutulur.
![hangfireTarayici](https://github.com/Ferhat-Turgut/TurkcellGY/blob/master/Hangfire/Images/Hangfire%20Taray%C4%B1c%20%C4%B0zlemesi.JPG)
<br/>
Ayrıca projenizde adres çubuğuna **/hangfire** ekleyerek birçok işlemi takip edebilirsiniz.
