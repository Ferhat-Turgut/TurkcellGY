# PKCE

PKCE (Proof Key for Code Exchange), OAuth 2.0 yetkilendirme akışının güvenliğini artıran bir mekanizmadır.

OAuth 2.0, API'ler ve diğer web tabanlı hizmetler arasında kullanıcı yetkilendirmesi için yaygın olarak kullanılan bir protokoldür. Ancak, temel OAuth 2.0 akışında yetkilendirme kodunun korunması zorluklar doğurabilir. PKCE, bu zorlukları ele almak için geliştirilmiştir.

PKCE, yetkilendirme kodlarının kötü niyetli saldırılara karşı korunmasını sağlamak için kullanılan bir güvenlik mekanizmasıdır. PKCE, OAuth 2.0 yetkilendirme akışına eklenen bir dizi ek adımdan oluşur ve yetkilendirme kodunun doğrulanması için bir kanıt sunar.

PKCE'nin çalışma mantığı şu adımlarla özetlenebilir:

1. Yetkilendirme İstemcisi (Client), rastgele bir dize olan Code Verifier'ı oluşturur.
2. Code Verifier, Base64 URL güvenli bir şekilde kodlanarak Code Challenge oluşturulur.
3. Yetkilendirme İstemcisi, yetkilendirme isteği yaparken Code Challenge'ı yetkilendirme isteğine ekler.
4. Yetkilendirme Sunucusu (Authorization Server), Code Challenge'ı alır ve saklar.
5. Kullanıcı kimlik doğrulamasını tamamlar ve Yetkilendirme Sunucusu, yetkilendirme kodunu oluşturur ve kullanıcının tarayıcısına yönlendirir.
6. Yetkilendirme İstemcisi, yetkilendirme kodunu alır ve Code Verifier'ı kullanarak bir yetkilendirme isteği yapar.
7. Yetkilendirme Sunucusu, Code Verifier'ı Code Challenge ile karşılaştırarak doğrular.
8. Doğrulama başarılıysa, Yetkilendirme Sunucusu erişim tokeni ve yenileme tokenini Yetkilendirme İstemcisine sağlar.

PKCE, yetkilendirme kodunun güvenliğini artırır ve saldırıların önlenmesine yardımcı olur. Özellikle, mobil uygulamalar gibi güvenli olmayan ortamlarda yetkilendirme yaparken PKCE kullanmak önemlidir. Çünkü mobil uygulamaların kodlarının saldırganlar tarafından tersine mühendislikle analiz edilebilmesi riski vardır.

PKCE'nin faydaları şunlardır:

1. Yetkilendirme kodunun gizliliğini korur: PKCE, yetkilendirme kodunun güvenli bir şekilde taşınmasını sağlar ve kodun kö

tü niyetli saldırganlar tarafından ele geçirilmesini önler.
2. Çift faktörlü kimlik doğrulama sağlar: Code Verifier'ı oluşturma ve kullanma adımları, bir ek güvenlik katmanı olarak hizmet eder ve çift faktörlü kimlik doğrulama sağlar.
3. Güvenli mobil uygulama yetkilendirmesi: Mobil uygulamalar, güvenli olmayan ortamlarda çalıştıklarından PKCE kullanmak önemlidir. PKCE, yetkilendirme akışında ek bir güvenlik katmanı sağlar.

PKCE, OAuth 2.0 yetkilendirme akışının güvenliğini artıran önemli bir mekanizmadır. Yetkilendirme kodlarının güvenli bir şekilde taşınmasını ve kötü niyetli saldırılara karşı korunmasını sağlar. PKCE'nin özellikle mobil uygulamalar gibi güvenli olmayan ortamlarda kullanılması tavsiye edilir. Bu sayede, kullanıcıların kimlik bilgileri güvende tutulur ve yetkilendirme süreci güvenli bir şekilde gerçekleştirilir.
