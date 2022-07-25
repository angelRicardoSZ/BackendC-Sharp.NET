using System;

namespace restaurante10ReservationSystems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] userNames = new string[10]{"","","","","","","","","", ""};
            int currentIndex = 0;
            bool userAnswer;

            Console.WriteLine("Welcome to the restaurant");
            while (currentIndex < 10)
            {

                Console.WriteLine("\n \n Are you a registered user? write true, or write false to register");
                userAnswer = Convert.ToBoolean(Console.ReadLine());
                if (userAnswer == true)
                {
                    Console.WriteLine("Hello, you are a registered user, please enter your exact user name");
                    string userToSearch = Console.ReadLine();
                    Console.WriteLine("The user you searched is {0}", userToSearch);
                    int index = Array.IndexOf(userNames, userToSearch);
                    if (index == -1)
                    { 
                        Console.WriteLine("User not found, try again or register");
                    }
                    else
                    {
                        Console.WriteLine("Welcome {0} it´s a pleasure to give your food", userNames[index]);
                    }
                }
                else if (userAnswer == false)
                {
                    Console.WriteLine("Please write and remember your username ");
                    userNames[currentIndex] = Console.ReadLine();
                    Console.WriteLine("Your User has been saved succesfully \n" +"Your User Name is {0}", userNames[currentIndex]);
                    currentIndex++;
                }
            }

            Console.WriteLine("The restaurant is full, try again next year \n These are the guests to the dinner");
            int auxIndex = 0;
            foreach (string name in userNames)
            {
                Console.WriteLine("User number {0} and user namne: {1}", auxIndex, userNames[auxIndex]);
                auxIndex++;
            }
            Environment.Exit(0);
        }
    }
}
