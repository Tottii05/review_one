using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        const string AverageMessage = "\nEl promig de les notes es: ";
        const string PassedMessage = "Aprovat";
        const string FailedMessage = "Suspès";
        const string AddressMessage = "\nLlistat de ciutats y codi postals";
        const int TotalNotes = 3, MinimalNote = 6;

        int[] notas = new int[TotalNotes];
        int suma = 0;
        List<List<string>> addresses = new List<List<string>>();

        for (int i = 0; i < TotalNotes; i++)
        {
            notas[i] = GetNote(i);
            suma += notas[i];
            addresses.Add(Address());
        }

        float promedio = (float)suma / TotalNotes;
        Console.WriteLine(AverageMessage + promedio);
        Console.WriteLine(promedio >= MinimalNote ? PassedMessage : FailedMessage);
        Console.WriteLine(AddressMessage);
        foreach (var address in addresses)
        {
            Console.WriteLine($"Adreça: {address[0]}, Codi Postal: {address[1]}");
        }
    }

    public static int GetNote(int noteIndex)
    {
        const string FirstNoteMessage = "Introdueix la primera qualificació:";
        const string SecondNoteMessage = "Introdueix la segona qualificació:";
        const string ThirdNoteMessage = "Introdueix la tercera qualificació:";

        switch (noteIndex)
        {
            case 0:
                Console.WriteLine(FirstNoteMessage);
                break;
            case 1:
                Console.WriteLine(SecondNoteMessage);
                break;
            case 2:
                Console.WriteLine(ThirdNoteMessage);
                break;
        }
        return Convert.ToInt32(Console.ReadLine());
    }

    public static List<string> Address()
    {
        const string AddressMessage = "Introdueix la teva ciutat:";
        const string PostalCodeMessage = "Introdueix el teu codi postal:";

        Console.WriteLine(AddressMessage);
        string address = Console.ReadLine();
        Console.WriteLine(PostalCodeMessage);
        int postalCode = Convert.ToInt32(Console.ReadLine());
        List<string> addressData = new List<string> { address, postalCode.ToString() };
        return addressData;
    }
}
