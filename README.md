# Bir AzureDevOps ortamına  WebHook nasıl tanımlanır  ?


## Öncelikle AzureDevOps nedir ? 

Azure Devops kısaca uçtan uca proje geliştirme yapabilmeniz için tasarlanmış bir bulut 
tabanlı Devops ürünüdür . Azure Devops sadece kod geliştrmek için değil, scrum projelerinizi 
yönetmek, Kanban boardlarınızı yönetmek, kod versiyonlamanızı yapmak, projenizi dev,test, prod 
ortamlarına deploy etmek, test süreçlerinizi yönetmek gibi uçtan uca gerekli olan tüm proje aşamaları
 için gerekli araçları sunmaktadır . AzureDevOps hizmetlerinin daha detaylı anlatımına 
[linkden ulaşabilirsiniz .](https://dev.azure.com)

  ## Peki bir AzureDevOps ortamına WebHook nasıl tanımlanır ?  

Bir makalede okuduğum bilgisayar bilimleri tabiri olan Hooking, sistemdeki bileşenlerin çalışmaları 
esnasında bazı noktalarda (interceptor gibi yöntemler ile) araya girerek bizi ilgilendiren mesajları 
yakalamamızı sağlayan bir yöntemdir. Bir nevi bize ait olmayan bir uygulamanın belli bir noktasında, 
bize ait olan kodu çalıştırmak için callback atmışız gibi düşünebiliriz. WebHook sağlayan servisler 
(WebHook Providers), bizi ilgilendiren bir olay (event) gerçekleştiğinde bizim tanımladığımız bir URL’e 
HTTP isteği atarak uygulamamızı haberdar ederler. Bir nevi back-end’ler kendi aralarında event 
gönderirler. Bu sayede yazılımımız gerçek zamanlı (real-time) olarak olaydan haberdar olur ve alması 
gereken aksiyonları alır.
Bir Azure Boards da oluşturulan WorkItem üzerinde gerçekleştirilen her değişiklikten bir başka 
sistemin haberdar olması ve bu değişiklik bilgisini işleyerek sistemin bir başka yerinde kullanılması 
gerekiyor ise burada Azure üzerinden tanımlanacak olan bir WebHook en etkili çözümlerden birisi 
olacaktır . 

 ![image](https://user-images.githubusercontent.com/45935701/183987926-4f410961-01de-435e-99d6-5d71792f33fb.png) 
                                                     Şekil 1.0




Örnek olarak oluşturduğum AzureDevOps Ortamı ekran görüntüsü şekil 1.0 daki gibidir . 
Oluşturmuş olduğumuz örnek proje olan AzureDevopsSample ye tıklayarak proje detayına gidilir . 

![image](https://user-images.githubusercontent.com/45935701/183987999-3da15306-fdb1-40cd-bdb4-113a751ba904.png) 
                                                       Şekil 1.1


Şekil 1.1 de sarı işaretli alanda bulunan Project Settings sekmesine tıklanarak ilgili projemiz için 
ayarlar yapabileceğimiz sekme açılır .  Burada General altında bulunan Service Hooks sekmesinden 
Create Subscription oluşturularak WebHookumuzun entegrasyonu yapılır . Bu abonelik esnasında 
Azure ortamına pek çok platformdan abone olabildiğimiz için pek çok servisin listelendiği bir ekran 
açılır . Biz buradan Web Hooks olanı seçiyoruz . 

**Unutulmaması gereken bir nokta : Azure Servisi olan WebHooks sadece POST metodunu destekler .**




![image](https://user-images.githubusercontent.com/45935701/183988488-4c6afe4e-2ee0-4c1a-86d8-a00741098597.png)
                                                       Şekil 1.2
                                                       
                                                       
                                                       
Trigger on this type of event  selectboxı üzerinden WebHookumuzun hangi olaylarda  
tetiklenmesini istediğimizi seçeriz (Örnek : Work Item Updated ) . 
Filters üzerinden hangi Area üzerinde hangi WorkItemType sine ait itemlerde bir güncelleme işlemi 
gerçekleştiğinde WebHookumuzun tetiklenmesi gereken  durumlarını filtreleyebiliriz . 




![image](https://user-images.githubusercontent.com/45935701/183988651-5a5dd835-b776-4adb-80b0-68618799d632.png)
                                                       Şekil 1.3

Bir sonraki adımda oluşturduğumuz API projesinde tetiklenecek metodun linkini vererek eğer istersek 
Bu metoda bir Authentication yapısı da uygulayabiliriz . Finish diyerek Web Hook entegrasyonumuzu 
sağlamış oluruz . 

**Not : API projesinin canlı ortamda olması gerekmektedir . Azure Portal üzerinden ücretsiz ve kolay bir şekilde canlıya alınması işlemini gerçekleştirebilirsiniz .** 
[Azure Ortamı Üzerinden Ücretsiz Bir Şekilde Deployment İçin Linke Tıklayabilirsiniz ](https://docs.microsoft.com/tr-tr/aspnet/core/tutorials/publish-to-azure-api-management-using-vs?view=aspnetcore-6.0)

