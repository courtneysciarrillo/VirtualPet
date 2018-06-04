using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            VirtualPet porkchop = new VirtualPet("Porkchop the Dog", 5, 30, 25, 15, 10, 0);
            
            Console.WriteLine(@" _   _");
            Console.WriteLine(@"/(. .)\    )");
            Console.WriteLine(@"  (*)____/|");
            Console.WriteLine(@"  /       |");
            Console.WriteLine(@" /   |--\ |");
            Console.WriteLine(@"(_)(_)  (_)");

            Console.WriteLine(porkchop.Name);
            Console.WriteLine();

            Console.WriteLine("Hunger: {0}", porkchop.Hunger);
            Console.WriteLine("Thirst: {0}", porkchop.Thirst);
            Console.WriteLine("Sleep: {0}", porkchop.Sleep);
            Console.WriteLine("Potty: {0}", porkchop.Potty);
            Console.WriteLine("Boredom: {0}", porkchop.Boredom);
            Console.WriteLine("Sickness: {0}", porkchop.Sickness);

            Console.WriteLine("\nWhat do you want Porkchop to do?\n");
            Console.WriteLine("1. Eat");
            Console.WriteLine("2. Drink");
            Console.WriteLine("3. Take Nap");
            Console.WriteLine("4. Go Potty");
            Console.WriteLine("5. Play");
            Console.WriteLine("6. See Doctor");
            Console.WriteLine("7. Do Nothing\n");

            Console.Write("> ");
            int response = int.Parse(Console.ReadLine());

            while  (response != 7)
            {
                if (response <= 0 || response >= 8)
                {
                    Console.WriteLine("\nPlease choose a valid menu option 1 through 7.");
                }

                switch (response)
                {
                    case 1:
                        porkchop.Eat();
                        porkchop.Tick();
                        Console.WriteLine("\nPorkchop ate food.\n");
                        Console.WriteLine("Hunger: {0}", porkchop.Hunger);
                        Console.WriteLine("Thirst: {0}", porkchop.Thirst);
                        Console.WriteLine("Sleep: {0}", porkchop.Sleep);
                        Console.WriteLine("Potty: {0}", porkchop.Potty);
                        Console.WriteLine("Boredom: {0}", porkchop.Boredom);
                        Console.WriteLine("Sickness: {0}", porkchop.Sickness);
                        break;
                    case 2:
                        porkchop.Drink();
                        porkchop.Tick();
                        Console.WriteLine("\nPorkchop drank water.\n");
                        Console.WriteLine("Hunger: {0}", porkchop.Hunger);
                        Console.WriteLine("Thirst: {0}", porkchop.Thirst);
                        Console.WriteLine("Sleep: {0}", porkchop.Sleep);
                        Console.WriteLine("Potty: {0}", porkchop.Potty);
                        Console.WriteLine("Boredom: {0}", porkchop.Boredom);
                        Console.WriteLine("Sickness: {0}", porkchop.Sickness);
                        break;
                    case 3:
                        porkchop.TakeNap();
                        porkchop.Tick();
                        Console.WriteLine("\nPorkchop took a nap.\n");
                        Console.WriteLine("Hunger: {0}", porkchop.Hunger);
                        Console.WriteLine("Thirst: {0}", porkchop.Thirst);
                        Console.WriteLine("Sleep: {0}", porkchop.Sleep);
                        Console.WriteLine("Potty: {0}", porkchop.Potty);
                        Console.WriteLine("Boredom: {0}", porkchop.Boredom);
                        Console.WriteLine("Sickness: {0}", porkchop.Sickness);
                        break;
                    case 4:
                        porkchop.GoPotty();
                        porkchop.Tick();
                        Console.WriteLine("\nPorkchop went potty.\n");
                        Console.WriteLine("Hunger: {0}", porkchop.Hunger);
                        Console.WriteLine("Thirst: {0}", porkchop.Thirst);
                        Console.WriteLine("Sleep: {0}", porkchop.Sleep);
                        Console.WriteLine("Potty: {0}", porkchop.Potty);
                        Console.WriteLine("Boredom: {0}", porkchop.Boredom);
                        Console.WriteLine("Sickness: {0}", porkchop.Sickness);
                        break;
                    case 5:
                        porkchop.Play();
                        porkchop.Tick();
                        Console.WriteLine("\nPorkchop played fetch.\n");
                        Console.WriteLine("Hunger: {0}", porkchop.Hunger);
                        Console.WriteLine("Thirst: {0}", porkchop.Thirst);
                        Console.WriteLine("Sleep: {0}", porkchop.Sleep);
                        Console.WriteLine("Potty: {0}", porkchop.Potty);
                        Console.WriteLine("Boredom: {0}", porkchop.Boredom);
                        Console.WriteLine("Sickness: {0}", porkchop.Sickness);
                        break;
                    case 6:
                        porkchop.SeeDoctor();
                        porkchop.Tick();
                        Console.WriteLine("\nPorkchop went to the doctor.\n");
                        Console.WriteLine("Hunger: {0}", porkchop.Hunger);
                        Console.WriteLine("Thirst: {0}", porkchop.Thirst);
                        Console.WriteLine("Sleep: {0}", porkchop.Sleep);
                        Console.WriteLine("Potty: {0}", porkchop.Potty);
                        Console.WriteLine("Boredom: {0}", porkchop.Boredom);
                        Console.WriteLine("Sickness: {0}", porkchop.Sickness);
                        break;

                } // end switch case

                Console.WriteLine("\nWhat do you want Porkchop to do?\n");
                Console.WriteLine("1. Eat");
                Console.WriteLine("2. Drink");
                Console.WriteLine("3. Take Nap");
                Console.WriteLine("4. Go Potty");
                Console.WriteLine("5. Play");
                Console.WriteLine("6. See Doctor");
                Console.WriteLine("7. Do Nothing\n");

                Console.Write("> ");
                response = int.Parse(Console.ReadLine());

            } // end while loop

            if (response == 7)
            {
                Console.WriteLine("Please come back and check on Porkchop again soon!");
            }

        } // end Main method
    } // end Program class
} // end VirtualPet namespace
