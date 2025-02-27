using System.Threading.Channels;
//fin
namespace Topic_7
{
    public class Program
    {


        static void Main(string[] args)
        {
            //run
            int run;
            int numOfParts = 2;

            Random generator = new Random();

            while (true)
            {
                {
                    Console.WriteLine("what part would you like to run?");
                    Console.WriteLine("for Topic 7.1,         enter '1'");
                    Console.WriteLine("for Topic 7.2 part 1,  enter '2'");
                    Console.WriteLine("for Topic 7.2 part 2,  enter '3'");
                    Console.WriteLine("for Topic 7.2 part 3,  enter '4'");

                    while (!int.TryParse(Console.ReadLine(), out run))
                    {
                        Console.WriteLine("invalid input, input a number");
                    }
                    Console.Clear();
                    if (run == 1)
                    {
                        part1();
                    }
                    else if (run == 2)
                    {
                        part2();
                    }
                    else if (run == 3)
                    {
                        part3();
                    }
                    else if (run == 4)
                    {
                        part4();
                    }


                }
                Console.WriteLine();
                Console.Write("press enter to continue");
                Console.ReadLine();
                Console.Clear();

            }

            void part1()
            {
                //Topic 7.1
                int score = 3;
                bool done = false;
                string input;
                string[] heads_tails = {"heads", "tails"};

                string chance;
                while (!done)
                {
                    Console.WriteLine("THE CASINO!!                            Current Score:" + score);
                    Console.WriteLine("----------------------------------------------------------");
                    Console.Write("heads, tails, or quit: ");
                    input = Console.ReadLine().ToLower();
                    chance = heads_tails[generator.Next(2)];
                    Console.WriteLine();
                    if (input != "quit" && input != "heads" && input != "tails")
                    {
                        Console.WriteLine("INVALID INPUT");
                        Console.WriteLine("TYPE 'heads,' 'tails,' OR 'quit'");

                    }
                    else if (input == "quit")
                    {
                        done = true;
                        Console.WriteLine("thank you for playing.");
                    }
                    else if (input == chance)
                    {
                        Console.WriteLine("YOU WON THE BET!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("YOU LOST THE BET.");
                        score--;
                        if (score <= 0)
                        {
                            done = true;
                            Console.WriteLine();
                            Console.WriteLine("GAME OVER.");
                            Console.WriteLine("thank you for playing.");
                        }
                    }

                    Console.WriteLine();
                    Console.WriteLine("press enter to continue");
                    Console.ReadLine();
                    Console.Clear();


                }
            }

            void part2()
            {
                //Topic 7.2 part 1
                for (int i = 10; i > 0; i--)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("BLASTOFF!");
            }

            void part3()
            {
                //Topic 7.2 part 2
                Console.WriteLine("X      Y");
                Console.WriteLine("--------------");
                for (int i = -10; i < 10; i=i+2)
                {
                    Console.WriteLine($"{i}\t{i*i}");

                }

            }

            void part4()
            {
                //Topic 7.2 part 3
                string name;
                int repeat_amount = 10;
                Console.Write("Enter your name: ");
                name = Console.ReadLine();

                if (name.ToLower() == "aldworth")
                {
                    repeat_amount = 5;
                }

                for (int i = 0;i < repeat_amount; i++)
                {
                    Console.WriteLine(name);
                }
            }

        }
    }
}
