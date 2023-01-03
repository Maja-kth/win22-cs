namespace _01_DataTypes.DataTypes;

internal static class DataType_Integrals
{
    public static void Example()
    {
        /*
            Integrals
            ---------------------------------------------------------------------------------------------------------------------
            sbyte,byte,short,ushort,int,uint,long,ulong             integral numeric                används för heltal
            double,decimal,float                                    floating-point numeric          används för decimaltal

            sbyte   -128 till 127                                   8 bit   (1 byte)
            byte    0 till 255                                      8 bit   (1 bytes)
            short   -32768 till 32767                               16 bit  (2 bytes)
            ushort  0 till 65535                                    16 bit  (2 bytes)
            int     -2147483648 till 2147483647                     32 bit  (4 bytes)
            uint    0 till 4294967295                               32 bit  (4 bytes)           Win 95/98/XP (32-bit)  4.2 GB RAM
            long    -9223372036854775808 till 9223372036854775807   64 bit  (8 bytes)           
            ulong   0 till 18446744073709551615                     64 bit  (8 bytes)           XP/Win 8/Win 10/Win 11 (64-bit)
         
         
            Floating-Points
            -------------------------------------------------------------------------------------
            float       4  bytes        6-9 digits          (±1.5 x 10−45 to ±3.4 x 1038)           mcu, sensor, iot, hårdvara
            double      8  bytes        15-17 digits        (±5.0 × 10−324 to ±1.7 × 10308)         machine learning, prestanda
            decimal     16 bytes        28-29 digits        (±1.0 x 10-28 to ±7.9228 x 1028)        valuta, beräkningar, finansiella värden
            
            suffix:
            -----------------------
            float       f eller F   
            double      d eller D eller ingenting
            decimal     m eller M
         
            float sum   = 0.1f + 0.1f + 0.1F;           <= 0.3
            double sum  = 0.1  + 0.1d + 0.1D;           <= 0.30000000000000004
            decimal sum = 0.1m  + 0.1m + 0.1M;          <= 0.3



            Convert/CAST
            --------------------------------------------------------
            object text = "1";

            string cast_text = (string)text;
            int convert_number = int.Parse(cast_text);

            double.Parse()
            float.Parse()
            decimal.Parse()
            int.Parse()
            long.Parse()
            ...






            Sammanfattning
            ---------------------------------------------------------------------------------------------------------------------
            deklarera ett heltalsvärde                      int number = 100;
                                                            long number = 10000;

            deklarera flyttal                               decimal number = 0.1m;
                                                            float number = 0.1f;
                                                            double number = 0.1;

            konvertera text till tall                       int number = int.Parse(text);


         */

    }
}