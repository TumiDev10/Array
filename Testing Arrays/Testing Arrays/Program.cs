// See https://aka.ms/new-console-template for more information

string[] Names = new string[6];

Names[0] = "Tumi";
Names[1] = "Tshepo";
Names[2] = "Tshepi";
Names[3] = "Trevor";
Names[4] = "Palesa";
Names[5] = "Stuart";

Console.WriteLine("These are my friends: ");
Console.WriteLine($"1. {Names[0]}");
Console.WriteLine($"2. {Names[1]}");
Console.WriteLine($"3. {Names[2]}");
Console.WriteLine($"4. {Names[3]}");
Console.WriteLine($"5. {Names[4]}");
Console.WriteLine($"6. {Names[5]}");

foreach(string name in Names)
{
    if(name.StartsWith("P"))
    {
        Console.WriteLine($"That's my female best friend: {name}");
    }

    else if(name.StartsWith("S"))
    {
        Console.WriteLine($"That's my only friend from primary school: {name}");
    }

    else if(name.StartsWith("T"))
    {
        Console.WriteLine($"This is my broer: {name}");
    }


}

