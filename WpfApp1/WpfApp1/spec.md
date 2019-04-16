# Egyszerű játék XAML alapokon

A játék egy egyszerű desktop alkalmazás (fontos döntés!) ami méri és így segít fejleszteni a reakcióidőnket. A játék lényege, hogy kártyákat mutatunk egymás után, és minden alkalommal el kell dönteni, hogy az adott kártya egyforma-e az előzővel.

Mivel az egyes reakióidők és a játékidő hosszának mérése fontos, ezért adja magát a számítógépes megvalósítás.


## Szereplők
- Tudom Ányos

  A szellemi képességeinek  növekedését kívánja nyomon követni.

## Forgatókönyvek
-Játék

Ányos elindítja az alkalmazást (fontos döntés), majd, ha lefkészült, akkor elindítja a játékot. A végén a játék kijelzi az eredmént.

Mivel rövid reakcióidőt mérünk, ezért az alkalmazás indításánk idejére nem használhatjuk a játékot. Ezért az alkalmazás indítása és a játék indítása között különbséget kell tenni.

Hány képernyő legyen?
Egy és három között
- alkalmazás induló képrnyő
- játék képernyő
- eredmény kijelzés

Kezdetben indulhatunk úgy, hogy a játék kezdőképernyője egyben az alkalmazás kezdőképernyője.

Fontos, hogy a lényeg a reakcióidő mérése, így nem gompokra, hanem  billenyűleütésekre tesszük a játékos reakcióit. Viszont érdemes megjeleníteni a lehetőségeket, erre jók a gombok.

