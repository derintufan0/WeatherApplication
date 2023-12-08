# Derin Tufan - 20220108065

# WeatherApplication

Bu C# konsol uygulaması, belirli şehirler için hava durumu bilgilerini almak ve ekrana yazdırmak amacıyla geliştirilmiştir.Programın ana sınıfları şunlardır:

# WeatherData:

- Location: Hava durumunu görmek istediğimiz yerin şehir olarak konumunu temsil eder.

- Conditions: Hava durumu açıklamasını içerir.

- Temperature: Sıcaklık bilgisini içerir.

- Humidity: Nem oranını içerir.

-WindSpeed: Rüzgar hızını içerir.

# WeatherFetcher:

- HttpClient kullanarak bir hava durumu API'sine bağlantı sağlar. 

- GetWeatherInfo metodu, belirli bir şehir için hava durumu bilgilerini alır ve bu bilgileri WeatherData nesnesine dönüştürür.

# WeatherReporter:

- WeatherData nesnesini alır ve bilgileri konsola yazdırır.

# WeatherApp:

- Uygulamayı başlatır.
- WeatherFetcher ve WeatherReporter sınıflarını kullanarak belirli şehirlerin hava durumu bilgilerini alır ve ekrana yazdırır.
