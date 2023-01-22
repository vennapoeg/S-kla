namespace Söökla;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Söökla menüüd");
        Console.WriteLine("Hommikusöök,löuna või öhtusöök?");
        string söögikord = Console.ReadLine();

        switch (söögikord)
        {
            //hommikusöök ja selle valikud
            case "hommikusöök":
                Console.WriteLine("Valisid hommikusöögi.Täna menüüs:\n" +
                    "1.Munapuder ja peekon\n" + "2.Kaerahelbepuder\n"
                    + "3.Müsli ja mahl\n" + "Tee oma valik: 1,2 või 3");
                byte selection = byte.Parse(Console.ReadLine());
                if (selection == 1)
                    Console.WriteLine("Sinu valik: Munapuder ja peekon. Head isu!");
                else if (selection == 2)
                    Console.WriteLine("Sinu valik: Kaerahelbepuder. Head isu!");
                else if (selection == 3)
                        Console.WriteLine("Sinu valik: Müsli ja mahl. Head isu!");
                else
                    Console.WriteLine("Tee palun oma valik! Valik 1, 2 või 3");
                break;

                //lõunasöök ja selle valikud
            case "löuna":
                Console.WriteLine("Valisid lõuna. Täna menüüs: \n" + "1.Seljanka\n"
                     + "2.Kartulipuder ja kotlett\n" + "3.Köögiviljalasanje\n" +
                     "Tee oma valik: 1, 2 või 3");
                byte selection1 = byte.Parse(Console.ReadLine());
                if (selection1 == 1)
                    Console.WriteLine("Sinu valik on Seljanka. Head isu");
                else if (selection1 == 2)
                    Console.WriteLine("Sinu valik on Kartulipuder ja kotlett. Head isu!");
                else if (selection1 == 3)
                    Console.WriteLine("Sinu valik on Köögiviljalasajne. Head isu!");
                else
                    Console.WriteLine("Tee palun oma valik! Valik 1,2 või 3");
                break;

                //õhtusöök ja selle valikud
            case "öhtusöök":
                Console.WriteLine("Valisid õhtusöögi.Täna menüüs: \n" + "1.Puljong " +
                    "ja pirukas\n" + "2.Pannkoogid ja kakao\n" + "3.Poke bowl");
                byte selection2 = byte.Parse(Console.ReadLine());
                if (selection2 == 1)
                    Console.WriteLine("Sinu valik on Puljong ja pirukas. Head isu!");
                else if (selection2 == 2)
                    Console.WriteLine("Sinu valik on pannkoogid ja kakao.Head isu!");
                else if (selection2 == 3)
                    Console.WriteLine("Sinu valik on Poke bowl. Head isu!");
                else
                    Console.WriteLine("Tee palun oma valik! Valik 1,2 või 3");
                break;

            default:
                Console.WriteLine("Tee oma valik!");
                break;
        }

    }
}