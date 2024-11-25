// See https://aka.ms/new-console-template for more information

//Oppgave 2 i PP.

//Model.KevinTunge();
Model.Per();

public class Model
{
    public static void KevinTunge()
    {
        string intro = "Hei, jeg heter Kevin.Jeg er 32 år gammel og har brunt hår.";
        string hobby = "Jeg liker PC bygging";
        Console.WriteLine(intro + hobby);
    }

    public static void Per()
    {
        string intro = "Hei, jeg heter Per, hva heter du?";
        Console.WriteLine(intro);
        var input = Console.ReadLine();
        Console.WriteLine($"Velkommen {input}");
        Console.WriteLine("Kan du fortelle litt om deg selv?");
        var input2 = Console.ReadLine();

        if (input2.ToLower() == "ja")
        {
            KevinTunge();
        }
        else
        {
            Console.WriteLine("Er du sjenert?");
        }
    }
}
