# Proje Hakkında
Katmanlı mimari olarak tasarlanmış basit bir E-Ticaret Sistemi içermektedir.

# Projede Kullanılan Teknolojiler
+ Asp.NetCore 5.0
+ Mysql DBMS
## Projede Kullanılan Paketler
+ EntityFramewokCore
+ Newtonsoft

## Katmanlar
<details>
  <summary>İçeriği Göster</summary>
  
### Business

Gelen bilgileri gerekli koşullara göre işlemek veya kontrol etmek için oluşturulan İş Katmanı.

### Core

Projeden bağımsız çeşitli parçacıklar içeren çekirdek katman.

### DataAccess

Veritabanı CRUD işlemlerini gerçekleştirmek için oluşturulan Veri Erişim Katmanı.
### Entities

Veritabanı tabloları için oluşturulan Varlık Katmanı.

### MvcWebUI

İş katmanını internete açan Mvc Katmanı.
  </details>

  ## Mysql Modeller
  <details>
    <summary>İçeriği Göster</summary>

### Product
| Name          | Data Type     | Allow Nulls | Default |
| :------------ | :------------ | :---------- | :------ |
| ProductId     | int           | False       |         |
| CategoryId    | int           | False       |         |
| ProductName   | string        | False       |         |
| UnitPrice     | decimal       | False       |         |
| UnitsInStock  | short         | False       |         |

### Product
| Name          | Data Type     | Allow Nulls | Default |
| :------------ | :------------ | :---------- | :------ |
| CategoryId    | int           | False       |         |
| CategoryName  | string        | False       |         |
  </details>

  ## Kullanıcı İşlemleri
  <details>
    <summary>İçeriği Göster</summary>

### Microsoft.AspNetCore.Identity.EntityFrameworkCore ile kullanılmıştır.
  + DbContext
     + CustomIdentityDbContext
     + CustomIdentityUser
     + CustomIdentityRole

</details>

  ## Sepet İşlemeleri
  <details>
    <summary>İçeriği Göster</summary>

   + ISession'a Serialize edilerek set edilmiştir.
   + ISession'dan Deserialize edilerek get edilmiştir.
   
    ## Modeller
### Basket
| Name              | Data Type     | Allow Nulls | Default |
| :-----------------| :------------ | :---------- | :------ |
| List<BasketLine>  | BasketLine    | False       |         |
| Total             | decimal       | False       |         |

### BasketLine
| Name          | Data Type     | Allow Nulls | Default |
| :------------ | :------------ | :---------- | :------ |
|  Product      | Product       | False       |         |
| Quantity      | İnt        | False       |         |
  
</details>

  ## Images
 <details>
<summary>İçeriği Göster</summary>



 </details>

 ## Teşekkürler
 