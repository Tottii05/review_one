using System;

class Program
{
    static void Main(string[] args)
    {
        const string AverageMessage = "El promig de les notes es: ";
        const string PassedMessage = "Aprovat";
        const string FailedMessage = "Suspès";
        const int TotalNotes = 3, MinimalNote = 6;

        int[] notas = new int[TotalNotes];
        int suma = 0;

        for (int i = 0; i < TotalNotes; i++)
        {
            notas[i] = GetNote(i);
            suma += notas[i];
        }

        float promedio = (float)suma / TotalNotes;
        Console.WriteLine(AverageMessage + promedio);
        Console.WriteLine(promedio >= MinimalNote ? PassedMessage : FailedMessage);
    }

    static int GetNote(int noteIndex)
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
}
