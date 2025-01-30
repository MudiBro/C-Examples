string[] places = { "", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
string player = "x";
string checker = "x";
bool win = false;

void printplaces()
{
    Console.WriteLine(places[1] + " | " + places[2] + " | " + places[3]);
    Console.WriteLine(places[4] + " | " + places[5] + " | " + places[6]);
    Console.WriteLine(places[7] + " | " + places[8] + " | " + places[9]);
}

int checkwin()
{
    checker = "x";
    if (places[1] == checker & places[2] == checker & places[3] == checker || places[4] == checker & places[5] == checker & places[6] == checker || places[7] == checker & places[8] == checker & places[9] == checker
        || places[1] == checker & places[5] == checker & places[9] == checker || places[3] == checker & places[5] == checker & places[7] == checker || places[1] == checker & places[4] == checker & places[7] == checker
        || places[2] == checker & places[5] == checker & places[8] == checker || places[3] == checker & places[6] == checker & places[9] == checker)
    {
        return 1;
    } else
    {
        checker = "o";
        if (places[1] == checker & places[2] == checker & places[3] == checker || places[4] == checker & places[5] == checker & places[6] == checker || places[7] == checker & places[8] == checker & places[9] == checker
        || places[1] == checker & places[5] == checker & places[9] == checker || places[3] == checker & places[5] == checker & places[7] == checker || places[1] == checker & places[4] == checker & places[7] == checker
        || places[2] == checker & places[5] == checker & places[8] == checker || places[3] == checker & places[6] == checker & places[9] == checker)
        {
            return 2;
        } else
        {
            return 0;
        }
    }
}

void main()
{
    while (!win)
    {
        printplaces();

        int input = int.Parse(Console.ReadLine());
        places[input] = player;
        if (checkwin() == 1)
        {
            win = true;
        }
        else if (checkwin() == 2)
        {
            win = true;
        }

        if (player == "x")
        {
            player = "o";
        }
        else
        {
            player = "x";
        }
    }
}
main();

if (checkwin() == 1)
{
    printplaces();
    Console.WriteLine("Player X has won!");
}
else if (checkwin() == 2)
{
    printplaces();
    Console.WriteLine("Player O has won!");
} else
{
    Console.WriteLine("Unknown Error");
}
