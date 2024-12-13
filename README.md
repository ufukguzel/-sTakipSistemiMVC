# İş Takip Sistemi (MVC)

Bu proje, iş süreçlerini takip etmek ve yönetmek için bir İş Takip Sistemi geliştirmek amacıyla oluşturulmuştur. Sistem, kullanıcıların işlerini daha etkili bir şekilde organize etmelerine ve iş akışlarını kontrol etmelerine yardımcı olur.

## Özellikler

- **Görev Yönetimi**: Yeni görev ekleme, mevcut görevleri düzenleme ve silme.
- **Kullanıcı Yönetimi**: Farklı roller ve yetkilerle kullanıcılar ekleme.
- **Proje Takibi**: Projelerin ilerleme durumunu izleme ve raporlama.
- **Bildirimler**: Önemli güncellemeler için sistem içi bildirimler.
- **Raporlama**: İş süreçleriyle ilgili detaylı raporlar oluşturma.

## Teknolojiler

Proje aşağıdaki teknolojilerle geliştirilmiştir:

- **Backend**: ASP.NET MVC
- **Frontend**: HTML, CSS, JavaScript
- **Veritabanı**: MSSQL
- **Diğer Araçlar**:
  - Entity Framework: ORM işlemleri için
  - Bootstrap: Kullanıcı arayüzü tasarımı

## Kurulum

1. **Gereksinimleri Yükleyin**:
   - Visual Studio (2022 veya daha yeni)
   - MSSQL Server

2. **Projeyi İndirin**:
   ```bash
   git clone https://github.com/ufukguzel/-sTakipSistemiMVC.git
   cd -sTakipSistemiMVC
   ```

3. **Veritabanını Ayarlayın**:
   - MSSQL Server üzerinde bir veritabanı oluşturun.
   - `appsettings.json` dosyasındaki veritabanı bağlantı ayarlarını güncelleyin.

4. **Projeyi Çalıştırın**:
   - Visual Studio'da projeyi açın.
   - Çözümü derleyin ve çalıştırın.

5. **Veritabanı Migrasyonlarını Uygulayın**:
   - Paket Yöneticisi Konsolu'nda aşağıdaki komutları çalıştırın:
     ```bash
     Update-Database
     ```

6. **Uygulamayı Test Edin**:
   - Uygulama çalıştıktan sonra [http://localhost:5000](http://localhost:5000) adresinden erişebilirsiniz.

## Kullanım

1. Sisteme giriş yaparak kullanıcı yetkilerinize uygun özellikleri kullanabilirsiniz.
2. Görevlerinizi ekleyebilir, düzenleyebilir ve tamamlayabilirsiniz.
3. Proje detaylarını takip edebilir ve raporlar oluşturabilirsiniz.

## Katkıda Bulunma

Katkıda bulunmak için aşağıdaki adımları takip edin:

1. Bu projeyi forklayın.
2. Yeni bir özellik veya düzeltme için bir dal oluşturun.
   ```bash
   git checkout -b yeni-ozellik
   ```
3. Değişikliklerinizi yapın ve commit'leyin.
   ```bash
   git commit -m "Yeni bir özellik ekledim"
   ```
4. Değişiklikleri dalınıza push'layın.
   ```bash
   git push origin yeni-ozellik
   ```
5. Bir Pull Request (PR) oluşturun.

## Lisans

Bu proje [MIT Lisansı](LICENSE) ile lisanslanmıştır.

---

### İletişim
Herhangi bir soru ya da öneri için benimle iletişime geçebilirsiniz:
- **E-posta**: ufukguzel@example.com
- **GitHub**: [@ufukguzel](https://github.com/ufukguzel)
