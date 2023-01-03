namespace _01_DataTypes.DataTypes;

internal static class DataType_String
{
    public static void Example()
    {
        /*
            * (array = statisk lista med ett fast antal platser) 


            STRING - Hanterar text
            --------------------------------------------------------------------------------------------------------------
            char            hanterar endast ett tecken
            string          hanterar en text som består av ett eller flera tecken (är egentligen en char array aka. char*)
         
            char letter = '';
            string name = "";


            Declaration JS                                          Declaration C#
            -------------------------------                         ------------------------------
            let firstName = "Hans"                                  string firstName = "Hans";
            let firstName = 'Hans'
            let firstName = `Hans`



            Placeholders JS                                         Placeholders C#
            ---------------------------------                       -------------------------------------------------------------------
            let firstName = "Hans"                                  string firstName = "Hans";
            let lastName = "Mattin-Lassei"                          string lastName = "Mattin-Lassei";
       
            let displayName = firstName + " " + lastName            string displayName = firstName + " " + lastName;
            let displayName = ""+ firstName +" "+ lastName +"";     string displayName = ""+ firstName +" "+ lastName +"";
            let displayName = `${firstName} ${lastName}`            string displayName = $"{firstName} {lastName}";
                                                                    string displayName = string.Format("{0} {1}", firstName, lastName);
            
        
        
            Escapers
            ---------------------------------------------------------------------------------------------------------------------------
            \   =   läs nästkommande tecken som vanlig text  (gäller inte för \n eller \t)        
            '   =   Används för att göra ett citat inuti en textsträng om man inte väljer att använda \"
            @   =   ignorerar allt och läser allt som en helt vanlig text när det kommer till \ tecknet i exempelvis sökvägar
            

            string text = "Hans är den \"vackraste\" människan i världen.";
            string text = "Hans är den 'vackraste' människan i världen.";

            string url = "C:\\Users\\HansMattin-Lassei\\Documents\\Utbildning\\WIN22\\win22-cs\\Lecture-1";
            string url= @"C:\Users\HansMattin-Lassei\Documents\Utbildning\WIN22\win22-cs\Lecture-1";
        
         
         
        
        
            Sammanfattning
            ---------------------------------------------------------------------------------------------------------------------
            deklarera ett textvärde                         string firstName = "Hans";
            
            använd placeholders                             string greeting = $"Hej {firstName}. Hoppas allt är bra med dig.";
            
            escape värden i texter och urler                string json = "{ \"firstName\": \"Hans\" }";
                                                            string url = @"c:\Users\HansMattin-Lassei\files\jsonfile.json";

         
        */
    }
}
