// Wzorzec projektowy - dekorator
// Prosty wzorzec projektowy, który pozwala zastąpić trudną, zawiłą hierarchie w prosty sposób

// Wyobraź sobie, że potrzebujesz stworzyć aplikację dla np. handlarza samochodów.
// Na początku w ofercie jest jedna marka samochodu - BMW
// Dodatkowo samochody mogą dostać dodatkowe wyposażenie - Radio, WIFI, GPS. 
//
// Na pierwszą myśl przychodzą mi 3 rozwiązania:
// A) Tworzenie każdej kombinacji klasy - FordZWifi, FordZRadio, FordZGPS, FordZWifiIGps itp...
// B) Stworzenie klasy BMW i stowrzenie properties jako List<Extension> extensions
// C) Użyć wzorca projektowego dekorator!
// Inne pomysły?

// Dlaczego nie A? Kompletnie zła droga. O ile przy jednej marce jest to do ogarnięcia ( 7 klas) to rozwiąznie nieskalowalne
// Dlaczego może być B? Nie jest to złym wyjściem, ale mało eleganckim. Policzenie ceny, czy wypisanie extensions wymagałoby
// iterowania po liście za każdym razem. Dodatkowo taką listę trzeba by było stworzyć, zapełnić obiektami i dostarczyć.
// Są pewnie również inne rozwiązania, ale naturalnie nasuwa się jedno.
// To dekorator. Dlaczego dekorator? Zobaczmy w przykładzie.