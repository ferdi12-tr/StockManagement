# StockManagement

1. Giriş Ekranı:

- Admin Giriş:
  Admin kullanıcı adı ve şifre ile giriş yapabilir.
- Kullanıcı Giriş:
  Satın alma işlemleri için kullanıcı adı ve şifre ile giriş yapabilir.

<hr/>
2. Admin Ana Ekran:

- Ürün Listesi ve Yönetimi:
  Tüm ürünleri görüntüleme, ekleme, düzenleme ve silme yetkisi.
  Stok durumu gibi bilgileri detaylı bir şekilde takip edebilme.
- Müşteri Yönetimi:
  Tüm müşteri bilgilerini görüntüleme, ekleme, düzenleme ve silme yetkisi.

- Raporlama:
  Genel satış raporlarına erişim.

<hr/>
3. Kullanıcı Ana Ekran:

- Ürün Listesi:
  Ürünleri görüntüleme ve sepete ekleme yetkisi.
- Sepet İşlemleri:
  Sepeti görüntüleme, ürün ekleyip çıkarma yetkisi.
  Satın alma işlemini gerçekleştirme.

<hr/>
4. Ürün Ekleme ve Düzenleme:

- Admin:
  Yeni ürün ekleme, varolan ürünleri düzenleme ve silme yetkisi.
- Kullanıcı:
  Ürün bilgilerini görüntüleme ve sepete ekleme yetkisi.

<hr/>
5. Satış İşlemleri:

- Admin:
  Tüm satış işlemlerini görüntüleme ve raporlama yetkisi.
- Kullanıcı:
  Kullanıcının kendi satış işlemlerini görüntüleme.

<hr/>
6. Stok Takibi:

- Admin:
  Stok durumunu detaylı bir şekilde takip etme yetkisi.
- Kullanıcı:
  Kullanıcının kendi sepetindeki ürünlerin stok durumunu kontrol etme.

<hr/>
7. Raporlama:

- Admin:
  Günlük, Haftalık, Aylık Satış Raporları:
  Belirli bir zaman aralığındaki satışları raporlama.
- En Çok Satılan Ürünler:
  Satılan ürünleri sayarak en popüler ürünleri belirleme.
- Kullanıcı:
  Kullanıcının kendi satış raporlarına erişim.

<hr/>
8. Önemli Not:

Bütün herşey oop ile ve Crud işlemleri ile gerçekleştirilecek. Kod tekrarını önlemek için Fonksiyon classı oluşturup buradan metodları çekin.

İstenilen Tablolar
User- surnane,email,password, CommonProperty
Role-CommonProperty
Category-CommonProperty
Product-price,stock,CommonProperty
SellProduct - Id,OrderId,ProductId,Quantity,Price,TotalPrice,İsDelete
BuyProduct - Id,UserId, ProductId, Quantity, İsDelete
Order, Id, UserId,OrderDateTine,İsDelete

CommonProperty - İd, Name,Description,İmage,İsStatus, İsDelete
