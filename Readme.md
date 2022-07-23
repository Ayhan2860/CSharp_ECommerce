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
| BasketLine        | List          | False       |         |
| Total             | decimal       | False       |         |

### BasketLine
| Name          | Data Type     | Allow Nulls | Default |
| :------------ | :------------ | :---------- | :------ |
|  Product      | Product       | False       |         |
| Quantity      | İnt           | False       |         |
  
</details>

  ## Images
 <details>
<summary>İçeriği Göster</summary>
 <img width="1438" alt="Ekran Resmi 2022-07-23 16 47 52" src="https://user-images.githubusercontent.com/68536015/180611801-a1b8d0fb-6744-4597-8790-146b79c41425.png">
<img width="1435" alt="Ekran Resmi 2022-07-23 16 47 14" src="https://user-images.githubusercontent.com/68536015/180611846-56ede896-3ebf-432d-8449-70b16d2bcf33.png">
<img width="1438" alt="Ekran Resmi 2022-07-23 16 46 43" src="https://user-images.githubusercontent.com/68536015/180611867-7e3a9fa3-49a3-413a-a5c8-8ba36795cb48.png">
<img width="1440" alt="Ekran Resmi 2022-07-23 16 45 39" src="https://user-images.githubusercontent.com/68536015/180611870-7ba7db40-9e07-4bff-919e-0d6b1a44729c.png">
<img width="1436" alt="Ekran Resmi 2022-07-23 16 48 12" src="https://user-images.githubusercontent.com/68536015/180611880-5ad987b3-712a-4e5f-8337-e28a21d59ae7.png">
<img width="1440" alt="Ekran Resmi 2022-07-23 16 48 33" src="https://user-images.githubusercontent.com/68536015/180611886-2c0ed208-b23e-422e-99a3-8a0ef50a6df0.png">
<img width="1435" alt="Ekran Resmi 2022-07-23 16 49 07" src="https://user-images.githubusercontent.com/68536015/180611891-6e5a6292-800b-4b02-941b-96acc91bc02b.png">
<img width="1440" alt="Ekran Resmi 2022-07-23 16 49 28" src="https://user-images.githubusercontent.com/68536015/180611898-45e8b25d-4096-49eb-8339-42b3d7076c54.png">


   


 </details>

 ## Teşekkürler
  
- [Engin Demiroğ](https://www.linkedin.com/in/engindemirog/)

 
