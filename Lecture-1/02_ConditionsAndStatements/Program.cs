/*
    Operators                                           Operators
    ----------------------------------------------      ------------------------------------------
    C#                                                  JS
    ----------------------------------------------      -------------------------------------------
    ??=      null-coalescing
    ==      lika med                                    ==      lika med             (problematiskt kan jämnföra text med tal)
    !=      inte lika med                               !=      inte lika med        (problematiskt kan jämnföra text med tal)
    <       mindre än                                   <       mindre än
    >       större än                                   >       större än 
    <=      mindre eller lika med                       <=      mindre eller lika med
    >=      större eller lika med                       >=      större eller lika med    
    &&      och                                         &&      och                  (problematiskt kan jämnföra text med tal)
    ||      eller                                       ||      eller      
    !       är inte lika med                            !       är inte lika med 
                                                        ===     lika med och samma datatyp
                                                        !==     inte lika med och samma datatyp
                                                        &&&     och och samma datatyp




    IF-satser
    -------------------------------------------------------------------------------------------------
    Kollar om ett tillstånd är sant, om det är det så utför vi någon åtgärd. 

    if (condition) {}

    if (condition) {}
    else {}

    if (condition) {}
    else if (condition) {}
    else {}

    if (condition) {}
    else if (condition) {}
    else if (condition) {}
    else {}


    (condition) ? do_work : do_else_work;




    
    SWITCH 
    -------------------------------------------------------------------------------------------------
    Switch är som en if-sats men kan bara kontrollera == conditions. Är effektivare om du har 
    många olika alternativ du ska titta på.

    int value = 20;

    switch(value) 
    {
        case 10:
            Console.WriteLine("Talet är tio");
            break;

        case 20:
            Console.WriteLine("Talet är tjugo");
            break;

        case 30:
            Console.WriteLine("Talet är trettio");
            break;

        default:
            Console.WriteLine("Talet är något annat...");
            break;
    }
    
*/


Console.ReadKey();