int BananerHemmad = 100;
int BananerHemmas = 100;

Console.WriteLine("Du har 100 bananer hemma, datorn har också 100 bananer hemma. För att vinna måste du stjäla datorns bananer innan datorn stjäl dina.");
while (true)
{
    if (BananerHemmas <= 0)
    {
        Console.WriteLine("Du har inga bananer kvar.");
        Console.WriteLine("\n--- YOU LOSE! ---");
        break;
    }

    if (BananerHemmad <= 0 && BananerHemmas <= 0)
    {
        Console.WriteLine("Varken du eller datorn har några bananer kvar.");
        Console.WriteLine("\n--- DRAW! ---");
        break;
    }

    int datorval = Random.Shared.Next(0, 2);
    int StulnaBananer = 5 + Random.Shared.Next(0, 16);
    int StulnaBananer2 = 5 + Random.Shared.Next(0, 16);
    Console.WriteLine("\nVill du: ATTACKERA eller FÖRSVARA?");
    string val = Console.ReadLine();

       if (BananerHemmad <= 0)
        {
            Console.WriteLine($"Du stjäl {StulnaBananer} bananer från datorn. Datorn har inga bananer kvar!");
            Console.WriteLine("\n--- YOU WIN! ---");
            break;
        }

    if (val == "attackera")
    {
        Console.WriteLine("\n--<<||>>--<<||>>--<<||>>--<<||>>--<<||>>--");
        Console.WriteLine("\nDu väljer att stjäla bananer från datorn.");
        //int StulnaBananer = 5 + Random.Shared.Next(0, 16);

        if (datorval == 1)
        {
            StulnaBananer = StulnaBananer - 5;
            Console.WriteLine("Datorn väljer att försvara sina bananer.");
        }

        BananerHemmad -= StulnaBananer;

        if (BananerHemmad > 0)
        {
            Console.WriteLine($"Du stjäl {StulnaBananer} bananer från datorn, datorn har {BananerHemmad} bananer kvar.");
        }

       // if (BananerHemmad <= 0)
       // {
       //     Console.WriteLine($"Du stjäl {StulnaBananer} bananer från datorn. Datorn har inga bananer kvar!");
       //    Console.WriteLine("\n--- YOU WIN! ---");
       //     break;
       // }

       // StulnaBananer = 0;

        if (datorval == 0)
        {
            BananerHemmas -= StulnaBananer2;
            Console.WriteLine($"Datorn stjäl {StulnaBananer2} bananer ifrån dig, du har {BananerHemmas} bananer kvar.");
        }
    }

    else if (val == "försvara")
    {
        Console.WriteLine("\n--<<||>>--<<||>>--<<||>>--<<||>>--<<||>>--");
        Console.WriteLine("\nDu väljer att försvara dina egna bananer.");

        if (datorval == 0)
        {
            Console.WriteLine("Datorn väljer att försvara sina bananer.");
            Console.WriteLine("Inga bananer blev stulna.");
        }

        else if (datorval == 1)
        {
            StulnaBananer2 = StulnaBananer2 - 5;
            BananerHemmas -= StulnaBananer2;

            if (StulnaBananer2 > 0)
            {
                Console.WriteLine($"Datorn stjäl {StulnaBananer2} bananer ifrån dig, du har {BananerHemmas} bananer kvar.");
            }

            if (StulnaBananer2 == 0)
            {
                int Kontring = Random.Shared.Next(0,16);
                BananerHemmas += Kontring;
                BananerHemmad -= Kontring;
                Console.WriteLine("Datorn försöker attackera men misslyckas och lämmnar sig öppen för en kontring");
                Console.WriteLine($"Du lyckas ta {Kontring} bananer från datorn.");
                Console.WriteLine($"Du har nu {BananerHemmas} bananer hemma, datorn har {BananerHemmad} bananer hemma.");
            }

        }
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