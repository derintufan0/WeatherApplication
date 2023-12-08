# WeatherApplication

##### Bu C# konsol uygulaması, belirli şehirler için hava durumu bilgilerini almak ve ekrana yazdırmak amacıyla geliştirilmiştir. Aşağıda, uygulamanın temel bileşenleri ve kullanım adımları açıklanmaktadır.

## Bileşenler  
#### WeatherInfo Sınıfı:
-City: Şehir adını temsil eder.  
-Description: Hava durumu açıklamasını içerir.    
-Temperature: Sıcaklık bilgisini içerir.  
-Humidity: Nem oranını içerir.  
-Wind: Rüzgar hızını içerir.  
### WeatherService Sınıfı:
-HttpClient kullanarak bir hava durumu API'sine bağlantı sağlar.
-GetWeather metodu, belirli bir şehir için hava durumu bilgilerini alır ve bu bilgileri WeatherInfo nesnesine dönüştürerek geri döner.  
### WeatherPrinter Sınıfı:
-WeatherInfo nesnesini alır ve bu bilgileri konsola yazdırır.
### Program Sınıfı:
-Main metodu, uygulamayı başlatır.
-WeatherService ve WeatherPrinter sınıflarını kullanarak belirli şehirlerin hava durumu bilgilerini alır ve ekrana yazdırır.
