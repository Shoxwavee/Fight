int BananerHemma = 100;
int BananerHemma2 = 100;

Console.WriteLine("Du har 100 bananer hemma, datorn har också 100 bananer hemma. För att vinna måste du stjäla datorns bananer innan datorn stjäl dina.");
while (true)
{
    if (BananerHemma <= 0 && BananerHemma2 <= 0)
    {
        Console.WriteLine("Varken du eller datorn har några bananer kvar");
    }

    Console.WriteLine("\nVill du: ATTACKERA eller FÖRSVARA?");
    string val = Console.ReadLine();
   
    if (val == "attackera")
    {
        Console.WriteLine("\n--<<||>>--<<||>>--<<||>>--<<||>>--<<||>>--");
        Console.WriteLine("\nDu väljer att stjäla bananer från datorn.");
        int StulnaBananer = 5 + Random.Shared.Next(0,16);
        BananerHemma -= StulnaBananer;
       
        if (BananerHemma >= 0)
        {
            Console.WriteLine($"Du stjäl {StulnaBananer} bananer från datorn, datorn har {BananerHemma} bananer kvar.");
        }
       
        StulnaBananer = 0;
        if (BananerHemma <= 0)
        {
            Console.WriteLine($"Du stjäl {StulnaBananer} bananer från datorn. Datorn har inga bananer kvar!");
            break;
        }
       
        int StulnaBananer2 = 5 + Random.Shared.Next(0,16);
        BananerHemma2 -= StulnaBananer2;
        Console.WriteLine($"Datorn stjäl {StulnaBananer2} bananer ifrån dig, du har {BananerHemma2} bananer kvar");
    }
   
    else if (val == "försvara")
    {
        Console.WriteLine("\nDu väljer att försvara dina egna bananer");
        Console.WriteLine("Datorn väljer att försvara sina bananer");
        Console.WriteLine("Inga bananer blev stulna");
    }
}



// while (BananerHemma > 0 && BananerHemma2 > 0)
// {
//     Console.WriteLine("BANANAMAN");
//     BananerHemma -= 10;
// }

// Console.WriteLine("Hello, World!");

// int StulnaBananer = 5 + Random.Shared.Next(0,16);

// Console.WriteLine(StulnaBananer);
Console.ReadLine();