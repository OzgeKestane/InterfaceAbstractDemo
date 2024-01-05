//Kahve dükkanları için müşteri yönetimi yapan bir sistem yazıyoruz.
//Starbucks ve Nero firması için
//İki firma da müşterilerini veri tabanına kaydetmek istiyor. Starbucks müşterileri kayıt ederken mutlaka mernis doğrulaması istiyor. Nero ise istemiyor. 


using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;

//BaseCustomerManager customerManager = new NeroCustomerManager();
BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());

customerManager.Save(new InterfaceAbstractDemo.Entities.Customer { DateOfBirth = new DateTime(1997, 7, 11), FirstName = "Özge", LastName = "Kestane", NationalityId = "13534739926" });
Console.ReadLine();


