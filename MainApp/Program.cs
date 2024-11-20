#region Basic consol version 

//Console.WriteLine("Välkommen");

//Console.Write("Vad heter du? ");
//string namn = Console.ReadLine();
//Console.WriteLine();

//Console.Write("Kan du skriva ditt e-post adress? ");
//string epost = Console.ReadLine();
//Console.WriteLine();

//Console.WriteLine($"Hej {namn}! Jag ska skicka ett meddelande till dig på adressen {epost}");

//Console.ReadKey();

#endregion

#region User information consol app

string name = "";
string email = "";

do
{
    Console.Clear();
    Console.Write("Ange ditt namn: ");
    name = Console.ReadLine();

    //if (name == "")
    if (string.IsNullOrEmpty(name)) 
        //Eger kullanici name degeri girmemisse
    {
        Console.WriteLine("Du måste ange ett namn");
        Console.ReadKey();
        Console.Clear();
    } 
}
while (string.IsNullOrEmpty(name)); //Kullanici name degeri girmezse tekrar name degeri istenir.


do
{
    Console.Clear();
    Console.Write("Ange ditt e-post: ");
    email = Console.ReadLine();

    if (string.IsNullOrEmpty(email))
    //Eger kullanici epost degeri girmemisse
    {
        Console.WriteLine("Du måste ange ett epost adress");
        Console.ReadKey();
        Console.Clear();
    }
}
while (string.IsNullOrEmpty(email)); //Kullanici name degeri girmezse tekrar name degeri istenir.


Console.Clear();
Console.WriteLine($"Hej {name}! Jag ska skicka ett meddelande till dig på adressen {email}");


#endregion