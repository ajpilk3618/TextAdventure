using System;

namespace TheThing
{
    class Program
    {
        static void Main(string[] args)
        {
            titleScreen();
        }

        public static void titleScreen()
        {
            Console.WriteLine("Welcome to the game");
            Console.WriteLine("Press 'Enter' to begin");
            Console.ReadLine();
            Console.Clear();
            first();
        }

        public static void first()
        {
            string option;
            Console.WriteLine("You wake up in the middle of a jungle in the drivers seat of a crashed SUV.");
            Console.WriteLine("Overhead, you see a helicopter and a dog barks nearby.");
            Console.WriteLine("You also see a military compound in the distance.");
            Console.WriteLine("What do you investigate?");
            Console.WriteLine("1: The helicopter");
            Console.WriteLine("2: The dog");
            Console.WriteLine("3: The compound");
            Console.WriteLine("4: You run away");
            Console.Write("Option # ");
            option = Console.ReadLine();
            Console.Clear();

            switch (option)
            {
                case "1":
                // Helicopter
                    {
                        Console.WriteLine("You run after the helicopter and it starts shooting. You take cover but does not seem to be shooting at you.");
                        Console.WriteLine("You follow the helicopter, and it comes upon a military compound.");
                        Console.WriteLine("The helicopter is quickly shot down by the military and you nervoulsy approach the area.");
                        Console.WriteLine("The crew surrounds you and asks for your information.");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        Console.Clear();
                        
                        second();
                        break;
                    }
                case "2":
                // Dog
                    {
                        Console.WriteLine("You find the dog and help it escape the helicopters attacks.");
                        Console.WriteLine("The helicopter is eventually shot down by the military and you nervoulsy approach the area with the dog.");
                        Console.WriteLine("The crew surrounds you and asks for your information.");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        Console.Clear();

                        second1();
                        break;
                    }
                case "3":
                // Compound
                    {
                        Console.WriteLine("You seek the protection of the military and approach the area with caution.");
                        Console.WriteLine("The crew surrounds you and asks for your information.");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        Console.Clear();

                        second();
                        break;
                    }
                case "4":
                // Run away
                    {
                        Console.WriteLine("You run away from everything.");
                        Console.WriteLine("In your haste you trip on a root and brake your leg.");
                        Console.WriteLine("Unable to move, you eventually die.");
                        Console.WriteLine("Press 'Enter' to continue");
                        Console.ReadLine();
                        Console.Clear();

                        gameOver();
                        break;
                    }
            }

        }

        public static void second()
        {
            Console.Write("Please enter your first name: ");
            string Firstname = Console.ReadLine();
            Console.Write("Please enter your last name: ");
            string Lastname = Console.ReadLine();

            Console.WriteLine("The crew trusts you and allows you into the compound.");

            third();
        }

        public static void second1()
        {
            Console.Write("Please enter your first name: ");
            string Firstname = Console.ReadLine();
            Console.Write("Please enter your last name: ");
            string Lastname = Console.ReadLine();

            Console.WriteLine("The crew trusts you and allows you and the dog into the compound.");
            Console.WriteLine("You join the crew and dog is sent to the kennel with the other animals.");

            third();
        }

        public static void third()
        {


            fourth();
        }

        public static void fourth()
        {


            last();
        }

        public static void last()
        {
            Random rnd = new Random();
            int[] prob = { 1, 2, 3, 4 };
            int randomNumber = rnd.Next(0, 4);
            int num = prob[randomNumber];
            if (num == 3)
            {
                Console.WriteLine("You were infected by the dog and died");
                gameOver();
            }
            else
            {
                youWin();
            }
        }

        public static void gameOver()
        {
            string choice;
            Console.WriteLine("Game Over.");
            Console.WriteLine("You Died");
            Console.WriteLine("Play again?");
            Console.WriteLine("yes or no.");
            choice = Console.ReadLine();
            
            if (choice == "yes") 
            {
                Console.Clear();
                titleScreen();
            }
            else
            {
                end();
            }
        }
        public static void end()
        {
            
        }

        public static void youWin()
        {
            string choice;
            Console.WriteLine("Congradulations on surviving The Thing!");
            Console.WriteLine("Play again?");
            Console.WriteLine("yes or no.");
            choice = Console.ReadLine();

            if (choice == "yes")
            {
                Console.Clear();
                titleScreen();
            }
            else
            {
                end();
            }
        }
    }
}
