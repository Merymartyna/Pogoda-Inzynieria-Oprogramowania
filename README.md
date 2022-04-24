# Pogoda-InzynieriaOprogramowania


Charakterystyka oprogramowania
Nazwa skrócona
Porównywarka prognoz „Nasza Pogoda”


Nazwa pełna
Aplikacja pozwalająca na porównywanie prognoz pogody z różnych stron internetowych


Krótki opis ze wskazaniem celu
Aplikacja składa się z dwóch stron. Pierwsza skierowana do mieszkańców miasta Gdańsk pokazująca temperatury z serwisów pogodowych Interia, Meteo, Wp, Pogoda Trójmiasto. Druga pozwalająca na weryfikację pogody w dowolnie wybranym mieście z różnych ogólnodostępnych API pogodowych. Użytkownik otrzymuje analizę danych w postaci najniższej, najwyższej temperatury oraz ich różnicy.
Przyjemny interfejs użytkownika pozwala w przyjazny sposób przedstawić informacje pogodowe.




Prawa autorskie
Autorzy

* Weronika Przymuszała
* Martyna Lange

Warunki licencyjne
   * Tło Aplikacji: Legal Simplicity: Można swobodnie modyfikować i wykorzystywać zdjęcia. Atrybucja nie jest wymagana
warunki licencyjne znajdują się na stronie: www.pexels.com/license/
   * Dane z API OpenWeatherMap: Można swobodnie korzystać z naszych produktów i danych do celów niekomercyjnych lub komercyjnych, uznając OpenWeather (TM) za dostawcę danych pogodowych w swoim produkcie. Nasze produkty dostarczamy na licencji Creative Commons Attribution-ShareAlike 4.0 International (CC BY-SA 4.0).
Dane i bazy danych są otwarte i licencjonowane przez Open Data Commons Open Database License (ODbL).
   * Dane z API WeatherAPI: Można swobodnie korzystać z naszych produktów i danych do celów niekomercyjnych lub komercyjnych. Możliwość modyfikacji i dystrybucji.
Uznanie autorstwa 4.0
 Wolno:
      * Dzielenie się — kopiuj i rozpowszechniaj utwór w dowolnym medium i formacie
      * Adaptacje — remiksuj, zmieniaj i twórz na bazie utworu
      * dla dowolnego celu, także komercyjnego




Uznanie autorstwa 4.0

Specyfikacja wymagań


ID
	Nazwa
	Opis
	Priorytet
	1
	Pobieranie danych pogodowych z kodu HTML serwisu internetowego Interia
	Wyciągnięcie z kodu HTML serwisu internetowego interia potrzebnych danych.
	1
	2
	Pobieranie danych pogodowych z kodu HTML serwisu internetowego Meteo
	Wyciągnięcie z kodu HTML serwisu internetowego Meto potrzebnych danych.
	1
	3
	Pobieranie danych pogodowych z kodu HTML serwisu internetowego Wp
	Wyciągnięcie z kodu HTML serwisu internetowego Wp potrzebnych danych.
	1
	4
	Pobieranie danych pogodowych z kodu HTML serwisu internetowego Pogoda Trójmiasto
	Wyciągnięcie z kodu HTML serwisu internetowego Pogoda Trójmiasto potrzebnych danych.
	1
	5
	Pobieranie danych pogodowych z API OpenWeatherMap
	Użycie danych związanych z warunkami pogodowymi poprzez zwracany plik Json.
	1
	6
	Pobieranie danych pogodowych z API WeatherMap
	Użycie danych związanych z warunkami pogodowymi poprzez zwracany plik Json.
	1
	7
	Wyświetlanie danych pogodowych z kodu HTML dla miasta Gdańsk
	Wyświetlone dane służą do zaprezentowania różnic między danymi podawanymi przez wybrane serisy internetowe.
	2
	8
	Wyświetlanie danych pogodowych z kodu HTML dla wybranego Miasta
	Wyświetlone dane służą do zaprezentowania różnic między danymi podawanymi przez wybrane serisy internetowe.
	3
	9
	Wyświetlanie danych pogodowych z API dla wybranego miasta
	Wyświetlone dane służą do zaprezentowania różnic między danymi podawanymi przez wybrane serisy internetowe.
	2
	10
	Porównanie danych pogodowych pobranych z różnych stron Wartość Minimalna
	Przedstawienie wartości skrajnych, 
	3
	11
	Porównanie danych pogodowych pobranych z różnych stron Wartość Maksymalna
	Przedstawienie wartości skrajnych
	3
	12
	Porównanie danych pogodowych pobranych z różnych stron Wartość średnia
	Przedstawienie wartości średniej
	3
	13
	Wyświetlenie odpowiedniego obrazka ukazującego warunki pogodowe
	Wyświetlenie obrazka
	2
	Miara priorytetu:
1- wymagane
2- przydatne
3- opcjonalne
M
Wymagania funkcjonalne
Wyświetlanie temperatury, ciśnienia oraz prędkości wiatru
Wyświetlane miary to stopnie celsjusza, hPA, km\h
Wyświetlenie informacji pogodowych w języku polskim
Wyświetlenie informacji pogodowych dla miasta uzupełnionego przez użytkownika
Wyświetlenie informacji pogodowych dla tego samego miasta z różnych portali internetowych
Wyświetlenie obrazka charakteryzującego pogodę dla danego miasta
Wymagania niefunkcjonalne
Kompatybilność z systemami Windows
Użyteczność, łatwość korzystania z aplikacji, estetyka i szybka nauka obsługi aplikacji
Responsywność 
Dostępność


Architektura oprogramowania
Architektura rozwoju
. Google maps
. ASP .NET 
Architektura uruchomieniowa
      *  Visual studio
      *  C#
      *  .net
      *  Html Agility Pack
      *  Open Weather Map
      *  Weather Api
      *  Canva.com
      *  Interia
      *  Meteo
      *  Pogoda Trójmiasto
      *  Wp
      * Paint 3D
      * xpather.com
Testy
Scenariusze testów
ID
	Opis
	Warunki wstępne
	Wymagania
	Oczekiwany wynik
	Rzeczywisty wynik dla porównywarki pogody z ogólno-
dostępnych API
	Rzeczywisty wynik  dla porównywarki pogody z powszechnie znanych stron internetowych
	1
	Możliwość wpisania nazwy miejscowości 
	Na stronie znajduje się pole do wpisania nazwy miejscowości
	Uzupełnione pole zaczytuje się do zmiennej w programie
	pozytywny
	pozytywny
	negatywny
	3
	Pobieranie danych pogodowych dla uzupełnionego miasta dla porównywarki pogody z ogólnodostępnych API
	Zmienna z nazwą miasta uzupełnia się w łączu do zewnętrznego serwisu pogodowego
	Pobieranie danych pogodowych dla uzupełnionego przez użytkownika miasta
	pozytywny
	pozytywny
	negatywny
	3
	Wyświetlanie temperatury
	Pobieranie z zewnętrznego serwisu informacji pogodowej
	Wyświetlanie temperatury
	pozytywny
	pozytywny
	pozytywny
	4
	Wyświetlanie ciśnienia
	Pobieranie z zewnętrznego serwisu informacji odnośnie ciśnienia
	Wyświetlanie ciśnienia
	pozytywny
	pozytywny
	pozytywny
	5
	Wyświetlanie prędkości powietrza 
	Pobieranie z zewnętrznego serwisu informacji odnośnie prędkości powietrza
	Wyświetlanie prędkości powietrza 
	pozytywny
	pozytywny
	negatywny
	6
	Wyświetlanie godziny wschodu słońca
		Wyświetlanie godziny wschodu słońca
	pozytywny
	pozytywny
	negatywny
	7
	Wyświetlanie godziny zachodu słońca 
		Wyświetlanie godziny zachodu słońca 
	pozytywny
	pozytywny
	negatywny
	8
	Wyświetlenie obrazka odpowiadającego wyświetlanej pogodzenie
		Wyświetlenie obrazka odpowiadającego wyświetlanej pogodzenie
	pozytywny
	pozytywny
	negatywny
	9
	Wyświetlanie temperatury maksymalnej
		Wyświetlanie temperatury maksymalnej
	pozytywny
	pozytywny
	negatywny
	10
	Wyświetlanie temperatury minimalnej
		Wyświetlanie temperatury minimalnej
	pozytywny
	pozytywny
	negatywny
	11
	Wyświetlanie średniej temperatury
		Wyświetlanie średniej temperatury
	pozytywny
	pozytywny
	negatywny
	





NaszaPogoda
