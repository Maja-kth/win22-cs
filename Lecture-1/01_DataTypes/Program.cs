/*   
    DATA TYPES
    ------------------------------------------------------------------------------------------------------------------------------
    JS                      C#                                                  Beskrivning
    ------------------------------------------------------------------------------------------------------------------------------
    undefined               (finns inte)                                        Hanterar något som inte är deklarerat                                       
    String                  char, string                                        Hantera texter och tecken
    Number                  sbyte,byte,short,ushort,int,uint,long,ulong         Hanterar tal
                            double,decimal,float
    Boolean                 bool                                                Hanterar sant/falskt - true/false
    Object                  object                                              Hanterar ett objekt med flera olika värden i.
    UUID                    GUID                                                Hanterar ett unikt id (c3f106e2-ba43-43ed-9a20-459d9fb57f25)
                            dynamic                                             Hanterar värden av olika typer

 
 
    DEKLARERA VARIABLER
    ----------------------------------------------------------------------------------------------------
    Normalt sätt och det sättet du "ska" göra det på är att deklarera en variabel med rätt datatyp.
    
        Guid id = Guid.NewGuid();    
        string firstName = "Hans";
        int age = 38;
        bool isEnabled = true;

    MEN! ibland är man lite lat eller man kanske inte riktigt vet vad det ska vara för datatyp då kan man
    deklarera en dynamisk deklarering med hjälp av var. (Inte samma som dynamic som är en datatyp.)
    var är samma sak som let i javascript


        var firstName = "Hans";
        var age = 38;

    
    Namngivning av variabler (vi kommer tillbaka till det här)
    ------------------------------------------------------------------------
    Pascal                  C#              FirstName
    camelCase               JS              firstName
    snake_notation          PY              first_name


    Jag brukar namnge variabler på följande sätt:
    string firstName;
    

*/