/*
    LOOPS
    -------------------------------------------------------------------------------------------------
    Conditional Loops                   while(condition) {}, do {} while(condition);, for(init;condition;increment){}
    Foreach Loops                       foreach() {}
 
 



        WHILE LOOP
        --------------------------------------------------------------------
        Används när vi vill kolla ett tillstånd först. Om tillståndet är uppfyllt
        så gör det som står i loopen. Därefter kontrollera tillståndet igen.

        while(condition) 
        {

        }


        DO WHILE LOOP
        ------------------------------------------------------------------------------
        Kör det som står i loopen minst en gång. Därefter kontrollera om tillståndet
        är sant. Om det är det så kör loopen igen.

        do 
        {

        }
        while(condition);










        FOR LOOP
        ----------------------------------------------------------------------------------
        Används när vi vill loopa igenom ett givet antal gånger. Exempelvis loopa 10 ggr
        eller loopa igenom listans längd. Alternativt när vi vill jämnföra varje tecken ifrån
        två olika texter.
    
        for (init value; condition; increment value) {}


        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Loop Number: {i}");
        }


        string password = "Password123!";
        string compare_password = "Password120!";
        bool isEqual = false;
        for (int i = 0; i < password.Length; i++)
        {
            if (password[i] != compare_password[i])
            {
                isEqual = false;
                break;
            }

            isEqual = true;
        }

        Console.WriteLine($"Is Equal: {isEqual}");


        string[] names = { "Hans", "Tommy", "Joakim", "Haithem", "Angelica", "Amanda" };
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine(names[i]);
        }








        FOREACH LOOP
        ---------------------------------------------------------------------------------------------------
        Används när vi vill loppa igenom en hel lista eller en array med värden och göra något med varje
        värde som finns i den listan


        string[] names = { "Hans", "Tommy", "Joakim", "Haithem", "Angelica", "Amanda" };
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

*/





Console.ReadKey();