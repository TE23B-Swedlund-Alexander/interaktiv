Console.WriteLine("du går på en väg");
Console.WriteLine("vägen delar sig, vilket håll går du [höger/vänster]");
string hall = Console.ReadLine();

if (hall.ToLower() == "höger")
{
    Console.WriteLine("du ser ett barn vid sidan av vägen");
    Console.WriteLine("dödar du barnet [ja/nej]");
    string childmurder = Console.ReadLine();
    if (childmurder.ToLower() == "ja")
    {
        Console.WriteLine("barnet hade en kniv du räddade dit liv bra jobbat.");
        Console.ReadLine();
    }
    if (childmurder.ToLower() == "nej")
    {
        Console.WriteLine("barnet hoppar emot dig med en kniv du är död.");
        Console.ReadLine();
    }
}
if (hall.ToLower() == "vänster")
{
    Console.WriteLine("du går vänster, ser du bananskalet? [ja/nej]");
    string bananskal = Console.ReadLine();
    if (bananskal.ToLower() == "ja")
    {
        Console.WriteLine("trampar du på bananskalet? [ja/nej]");
        string trampa = Console.ReadLine();

        if (trampa.ToLower() == "ja")
        {
            Console.WriteLine("du halkar och bryter nacken (det var meningen, good ending)");
            Console.ReadLine();
        }
        if (trampa.ToLower() == "nej")
        {
            Console.WriteLine("du trampar inte på bananskalet :)");
            Console.ReadLine();
        }
    }
    if (bananskal.ToLower() == "nej")
    {
        Console.WriteLine("du halkar och bryter nacken (bad ending)");
        Console.ReadLine();
    }
}
