# NewRepo

Proje tasarımı olarak uzun zamandır kendi projelerimde de kullandığım Onion Architecture mimarisinin basitleştirilmiş hali şeklinde yapmaya çalıştım. Modelleri ayırdım, service ve repository kullandım. 

CodeFirst yaklaşımı ile veritabanını EntityFramework ile oluşturdum. 
Örnek proje olduğu için veritabanı nesneleri için herhangi bri ayarlama işlemlerini eklemedim. Girilen tüm değerler zorunlu alan olarak yazılmıştır.
Migration eklerken Migration verilerinin Persistence altında tutulabilmesi için aşağıdaki komutu kullandım.
Add-Migration Mig_1_Initial -OutputDir Infrastructure/Persistence/Migrations

Veritabanı olarak VMware Workstation'da sanal olarak kurulu olan Ubuntu işletim sistemi içerisinde Docker container olarak MSSQL kullandım. Id değerlerini Guid olarak belirledim. 

Her DI işleminin gerekli proje yapısı içinde olabilmesi için (Program.cs içerisinde olmaması için) PersistenceServiceRegistration isimli bir class oluşturdum ve DI dış servis ve veritabanı ayarlarını o bölümden yaptım.

Herhangi bir sorunuz olması durumunda benimle her zaman iletişime geçebilirsiniz.

Kolay gelsin.
