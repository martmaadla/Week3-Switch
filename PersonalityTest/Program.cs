using System;

namespace PersonalityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada tema lemmikvärv;
            //kui kasutaja sisestab "punane", konsool kuvab "Oled romantiline";
            //kui kasutaja sisestab "sinine", konsool kuvab "Oled töökas";
            //kui kasutaja sisestab "roheline", konsool kuvab "Oled looduse sõber";
            //kui kasutaja sisestab midagi muud, konsool kuvab "Oled {userColor} üksarvik";

            Console.WriteLine("Sisesta oma lemmikvärv:");
            string userColor = Console.ReadLine();

            if(userColor == "punane")
            {
                Console.WriteLine("Oled romantiline.");
            }
            
            else if(userColor == "sinine")
            {
                Console.WriteLine("Oled töökas.");
            }
            else if (userColor == "roheline")
            {
                Console.WriteLine("Oled looduse sõber.");
            }
            else 
            {
                Console.WriteLine($"Oled {userColor} üksarvik.");
            }
            Console.WriteLine("Kena päeva!");

        }
    }
}
