# OOP-Labb-3

## Utmaning
- [x]  Du ska skapa en klass som ska vara en överordnad klass (parent class) för de andra klasserna som ska ärva från den. Klassen ska heta Geometry och den ska ha en metod som heter `Area()` med returtypen double.
- [x]  Du ska skapa tre klasser till (child classes) som ska ärva från Geometry-klassen och klasserna ska heta `Rectangle`, `Square` och `Circle.` ****Alla klasser ska implementera metoden `Area().`
- [x]  Varje klass ska ha minst en egenskap, till exempel:
    
    ```csharp
    public class Circle
    {
         public double Radius {get; set;}
    }
    ```
    
- [x]  I alla underklasser ska det finnas en override av metoden `Area()` med olika implementeringar. Detta eftersom arean för en cirkel beräknas annorlunda jämfört med arean för en fyrkant.
- [x]  Alla underklasser måste ha en konstruktor för att ge värde till egenskaper. Du ska ge dem ett fast värde i konstruktorn. Till exempel:
    
    ```csharp
    public Circle()
    {
          Radius = 4;
    }
    ```
    
- [x]  I Main-metoden ska du skapa objektreferenser från Geometry-klassen och låta dem peka på ett objekt av varje underklass.
    
    Exempel:
    
    ```csharp
    Geometry circle = new Circle();
    ```
    
- [x]  Du ska skapa en loop i Main-metoden som går igenom alla objektreferenser och anropar Area()-metoden för varje objekt. Detta demonstrerar polymorfism i praktiken.
- [x]  Skriv ut resultatet av Area()-beräkningen för varje objekt på ett läsbart sätt. Se exempel på förväntad output i bilden nedan.
- [x]  Kommentera din kod för att förklara hur polymorfism används i ditt program.

## Extra utmaningar

För dig som vill utmana dig själv ytterligare, här är några förslag på extra uppgifter:

- [x]  Implementera en ny geometrisk form, till exempel en triangel, och inkludera den i din hierarki.
- [x]  Lägg till ytterligare en konstruktor som tar emot värden för varje forms unika egenskaper. (Så att du kan skapa former i olika storlekar)
- [x]  Lägg till en metod för att beräkna omkretsen för varje form och demonstrera polymorfism med denna metod också.
- [x]  Skapa en funktion som sorterar formerna baserat på deras area och skriv ut dem i ordning.
- [x]  Implementera felhantering för ogiltiga inmatningar (t.ex. negativa längder eller radier) i dina konstruktorer.
- [x]  Skapa en enkel konsolbaserad meny där användaren kan välja vilken form de vill skapa och mata in dimensioner.