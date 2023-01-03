namespace _01_DataTypes.DataTypes;

internal static class DataType_Guid
{
    public static void Example()
    {

        /*
            C#: GUID -  Globally Unique Identifier / JS: UUID - Universal Unique Identifier
            --------------------------------------------------------------------------------
            Unik kod som med största sannolighet inte kommer att återkomma igen.         
            Exempel på en GUID:     54601f42-dc20-42a5-8b18-5d1d7e14960c
         
            
            Skapa ett GUID
            -------------------------------------------
            Guid id = Guid.NewGuid();
            string id = Guid.NewGuid().ToString();


            Convert/CAST
            -------------------------------------------
            object guid_object = "54601f42-dc20-42a5-8b18-5d1d7e14960c";
            string guid = (string)guid_object;

            Guid id = Guid.Parse(guid);      
            Guid id = Guid.Parse("54601f42-dc20-42a5-8b18-5d1d7e14960c");
            
        */
    }
}
