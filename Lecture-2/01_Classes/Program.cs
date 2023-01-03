/*
    CLASSES  -   Class, Object, Entity, Dto, Model, Service, Helper, Controller 
    ----------------------------------------------------------------------------------------
    En klass är en representation över någonting. Det vill säga en mall. det kan vara en mall
    över hur en Användare ser ut, hur en Kontaktperson ser hur, hur en Order ser ut, hur en Produkt ser ut...
    

    static                  statisk deklarerad redan i början av programmet
    dynamic/instance        dynamisk deklarerar som skapar ett objekt när vi behöver det

    heap        - minne som är långsamt men inga direkta begräsningar
                - allt finns kvar och måste manuellt tas bort för att frigöra minne (free())
                - allokeras av exempelvis objekt (malloc())
                - instansieringar dvs när vi använder ordet new
                - använder sig av en pekare

    stack       - minne som är snabbt men begränsat
                - tas bort efter att det har blivit använt
                - allokeras av exemplvis variabler (malloc())
                - variabler
                - pekare

    static kommer skapa utrymme i stacken
    När vi fyller upp hela stacken kallas det för stack overflow

 */
/*
    ACCESS MODIFIERS
    -------------------------------------------------------------------------------------------------------------
    Talar om vilken säkerhetsnivå en klass, fält, egenskap, metod har. Har med hur vi får tillgång till detta.
    
    protected           används vid arv
    public              accessbart i hela vår solution, dvs det är nåbart i andra projekt 
    internal            accessbart inom själva projektet
    private             accessbart inom själva klassen ingen annanstans

    en klass kan bara använda sig av public eller internal om du är osäker på vad du ska använda så använd alltid
    public.
 
*/
/*
    GETTERS AND SETTERS
    --------------------------------------------------------------------------------------
    Getters och setters handlar om läs och skrivrättigheter till en Property
    GET = läsrättighet dvs jag får hämta ut värdet som finns på den här Property
    SET = skrivrättighet dvs jag får sätta ett värde på den här Property
 
    GET = Console.WriteLine("Förnamn: " + product.FirstName);    
    SET = product.FirstName = "Hans";

 */
/*
    METHODS
    -------------------------------------------------------------------
    En metod är något som utför någon form av handling och det är där vi
    har vår program logik. En metod är mer eller mindre samma sak som en
    funktion i javascript.

    JS
    function getDisplayName() {
        return `${firstName} ${lastName}`
    }

    getDisplayName()

   
    C#
    public string GetDisplayName() 
    {
        return $"{FirstName} {LastName}";
    }

    var person = new Person();
    person.GetDisplayName();


    RETURN TYPES
    -------------------------------------------------------------------
    En metod kan om man vill ge tillbaka ett resultat. Då behöver man
    specificera upp vilken datatyp som man ska retunera tillbaka. Om det
    är så att man inte vill att metoden ska ge något värde tillbaka så
    måste man ange ordet void, som betyder tomrum.

    void talar alltså om att denna metod inte kommer ge något värde tillbaka

    

 */

using _01_Classes.Classes;

Product product = new Product();
product.Name = "Product 1";
product.ApplyDiscount();
Console.WriteLine("Produktens namn: " + product.Name);
Console.WriteLine(product.GetProductInformation());


Product product_2 = new Product("Product 2", 2000);
product_2.ApplyDiscount();
Console.WriteLine("Produktens namn: " + product_2.Name);
Console.WriteLine(product_2.GetProductInformation());


Person person= new Person();
person.FirstName= "Hans";
person.LastName = "Mattin-Lassei";
Console.WriteLine(person.DisplayName);

User user = new User
{
    FirstName = "Hans",
    LastName = "Mattin-Lassei",
    Email = "hans@domain.com"
};

user.GenerateSecurePassword("BytMig123!");
var isValid = user.ValidatePassword("BytMig123!");
Console.WriteLine("User Password is valid: " + isValid);




Console.ReadKey();