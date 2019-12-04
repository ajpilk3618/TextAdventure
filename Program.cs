using System;
using System.Threading;

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
            Thread.Sleep(3000);
            Console.WriteLine("Press 'Enter' to begin");
            Console.ReadLine();
            Console.Clear();
            first();
        }

        public static void first()
        {
            string option;
            Console.WriteLine("You wake up in the middle of the jungle in the drivers seat of a crashed SUV.");
            Thread.Sleep(3000);
            Console.WriteLine("Overhead, you see a helicopter and a dog barks nearby.");
            Thread.Sleep(3000);
            Console.WriteLine("You also see a military compound in the distance.");
            Thread.Sleep(3000);
            Console.WriteLine();
            Console.WriteLine("What do you investigate?");
            Console.WriteLine("1: The helicopter");
            Console.WriteLine("2: The dog");
            Console.WriteLine("3: The compound");
            Console.WriteLine("4: You run away");
            Thread.Sleep(2000);
            Console.WriteLine();
            Console.Write("Option # ");
            option = Console.ReadLine();
            Console.Clear();

            switch (option)
            {
                case "1":
                // Helicopter
                    {
                        Console.WriteLine("You run after the helicopter and it starts shooting. You take cover but does not seem to be shooting at you.");
                        Thread.Sleep(3000);
                        Console.WriteLine("You follow the helicopter, and it comes upon a military compound.");
                        Thread.Sleep(3000);
                        Console.WriteLine("The helicopter is quickly shot down by the military and you nervoulsy approach the area where a member of the crew has already taken in the dog.");
                        Thread.Sleep(3000);
                        Console.WriteLine("The crew surrounds you and asks for your information.");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        Console.Clear();
                        
                        getInfo();
                        break;
                    }
                case "2":
                // Dog
                    {
                        Console.WriteLine("You find the dog and help it escape the helicopters attacks.");
                        Thread.Sleep(3000);
                        Console.WriteLine("The helicopter is eventually shot down by the military and you nervoulsy approach the area with the dog.");
                        Thread.Sleep(3000);
                        Console.WriteLine("The crew surrounds you and asks for your information.");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        Console.Clear();

                        veryDead();
                        break;
                    }
                case "3":
                // Compound
                    {
                        Console.WriteLine("You seek the protection of the military and approach the area with caution where a member of the crew has already taken in the dog.");
                        Thread.Sleep(3000);
                        Console.WriteLine("The crew surrounds you and asks for your information.");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        Console.Clear();

                        getInfo();
                        break;
                    }
                case "4":
                // Run away
                    {
                        Console.WriteLine("You run away from everything.");
                        Thread.Sleep(3000);
                        Console.WriteLine("In your haste to escape the danger you trip on a root and brake your leg.");
                        Thread.Sleep(3000);
                        Console.WriteLine("Unable to move, you eventually die.");
                        Console.WriteLine("Press 'Enter' to continue");
                        Console.ReadLine();
                        Console.Clear();

                        gameOver();
                        break;
                    }
            }
        }

        public static void getInfo()
        {
            Console.WriteLine("'Give us your name and we might let you live' The leader shouts.");
            Thread.Sleep(3000);
            Console.WriteLine();

            Console.Write("Please enter your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Please enter your last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Please enter your profession: ");
            string job = Console.ReadLine(); 

            Random rnd = new Random();
            int[] prob = { 1, 2, 3, 4, 5 };
            int randomNumber = rnd.Next(0, 5);
            int num = prob[randomNumber];
            if (num == 2)
            {
                Console.WriteLine("The crew does not trust you, and assumes you are a spy.");
                Thread.Sleep(3000);
                Console.WriteLine("You are then killed by the crew.");
                Console.WriteLine("Press 'Enter' to continue");
                Console.ReadLine();
                Console.Clear();
                gameOver();
            }
            else
            {
                Console.WriteLine($"'Oh! I didn't know you were a {job}.' says the leader.");
                Console.WriteLine("'Hopefully your skills will be of use to us here.'");
                Console.WriteLine($"'Will you help us {firstName} {lastName}?' he asks.");

                string choice; ;
                Console.WriteLine("yes or no");
                choice = Console.ReadLine();

                while (choice == "no")
                {
                    Console.WriteLine("'Please take your time and think it over.' the leader says firmly.");
                    Console.WriteLine("yes or no");
                    choice = Console.ReadLine();
                }

                Console.WriteLine("The crew trusts you and allows you into the compound.");
                Console.Clear();
                storyTime();
            }
        }

        public static void veryDead()
        // CHOICE WITH THE DOG YOU DIE NO MATTER WHAT
        {
            Console.WriteLine("'Give us your name and we might let you live' The leader shouts.");
            Thread.Sleep(3000);
            Console.WriteLine();

            Console.Write("Please enter your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Please enter your last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Please enter your profession: ");
            string job = Console.ReadLine();

            Random rnd = new Random();
            int[] prob = { 1, 2, 3, 4, 5 };
            int randomNumber = rnd.Next(0, 5);
            int num = prob[randomNumber];
            if (num == 2)
            {
                Console.WriteLine("The crew does not trust you, and assumes you are a spy.");
                Thread.Sleep(3000);
                Console.WriteLine("You and the dog are then killed by the crew.");
                Console.WriteLine("Press 'Enter' to continue");
                Console.ReadLine();
                Console.Clear();
                gameOver();
            }
            else
            {
                Console.WriteLine($"'Oh! I didn't know you were a {job}.' says the leader.");
                Console.WriteLine("'Hopefully your skills will be of use to us here.'");
                Console.WriteLine($"'Will you help us {firstName} {lastName}?' he asks.");

                string choice;
                Console.WriteLine("yes or no");
                choice = Console.ReadLine();

                while (choice == "no")
                {
                    Console.WriteLine("'Please take your time and think it over.' the leader says firmly.");
                    Console.WriteLine("yes or no");
                    choice = Console.ReadLine();
                }

                Console.WriteLine("The crew trusts you and allows you and the dog into the compound.");
                Console.Clear();
                deathTime();
            }
        }

        public static void deathTime()
        {
            Console.WriteLine("A few days go by and you are now a member of the crew.");
            Thread.Sleep(3000);
            Console.WriteLine("A small group set out to discover where the mysterious helicopter came from.");
            Thread.Sleep(3000);
            Console.WriteLine("While they are away the dog you saved suddendly bursts apart killing the other dogs in the kennel.");
            Thread.Sleep(3000);
            Console.WriteLine("A grotesque creature emerges that seems to be using the bodies of other dead animals for its form.");
            Thread.Sleep(3000);
            Console.WriteLine("You and the captain are successful in securing the area so no one gets injured.");
            Thread.Sleep(3000);
            Console.WriteLine("One of the crew uses a flamethrower to kill the creature after it begins to break down the doors.");
            Thread.Sleep(3000);
            Console.WriteLine("The crew doctor examines the body later and discovers human bones and tissue are integrated into the creature.");
            Thread.Sleep(3000);
            Console.WriteLine("'It's definitely not from earth' the doc says nervously.");
            Thread.Sleep(3000);
            Console.WriteLine("'All of this started with that one' the captain points at you and the rest of the crew looks on nervously.");
            Thread.Sleep(3000);
            Console.WriteLine();
            Thread.Sleep(3000);
            Console.WriteLine("At that moment your body rips apart and begins consuming the burnt carcass of the creature as well as other members of the crew.");
            Thread.Sleep(2000);
            Console.WriteLine("Press'Enter' to continue");
            Console.ReadLine();

            Console.Clear();
            gameOver();
        }

        public static void storyTime()
            // THIS METHOD IS JUST FOR EXPOSITION ON THE STORY NO CHOICES TO BE MADE BY THE PLAYER
        {
            Console.WriteLine("A few days go by and you are now a member of the crew.");
            Thread.Sleep(3000);
            Console.WriteLine("A small group set out to discover where the mysterious helicopter came from.");
            Thread.Sleep(3000);
            Console.WriteLine("The leader assures you that it was a misunderstanding, and that we are not under attack from another nation.");
            Thread.Sleep(3000);
            Console.WriteLine("The rest of the crew is back and has made a disturbing discovery.");
            Thread.Sleep(3000);
            Console.WriteLine("They tell of the monster they found at a German military base a few miles away.");
            Thread.Sleep(3000);
            Console.WriteLine("They also confirmed that the helicopter was sent from the German base.");
            Thread.Sleep(3000);
            Console.WriteLine("But no one knows why it seemed to be chasing the dog.");
            Thread.Sleep(3000);

            fourth();
        }

        public static void fourth()
        {


            last();
        }

        public static void last()
        {
            Random rnd = new Random();
            int[] prob = { 1, 2, 3, 4, 5, 6 };
            int randomNumber = rnd.Next(0, 6);
            int num = prob[randomNumber];
            if (num == 2)
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
