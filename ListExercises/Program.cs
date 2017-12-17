using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Continuously ask for names until user types Enter with an empty string.
            //Depending on the number of names, show:
            //0: "No one likes your post"
            //1: "<name> likes your post!"
            //2: "<name> and <name2> likes your post!"
            //3: "<name>, <name2> and <count-2> others like your post!
            //var Names = new List<string>();
            //string input = "start";

            //while (!String.IsNullOrWhiteSpace(input))
            //{
            //    Console.WriteLine("Please enter a name");
            //    input = Console.ReadLine();
            //    if (String.IsNullOrWhiteSpace(input))
            //        break;
            //    Names.Add(input);
            //}

            //var number = Names.Count;
            //if(number == 0)
            //{
            //    Console.WriteLine("No one likes your post.");
            //}else if(number == 1)
            //{
            //    Console.WriteLine("{0} likes your post!", Names[0]);
            //}else if(number == 2)
            //{
            //    Console.WriteLine("{0} and {1} likes your post!", Names[0], Names[1]);
            //}
            //else
            //{
            //    Console.WriteLine("{0}, {1} and {2} others like your post!", Names[0], Names[1], (Names.Count - 2));
            //}

            //Console.ReadKey();


            //-------------------------------------------------------------
            //Ask user their name. Store in array, reverse, and output.
            //string name;

            //Console.WriteLine("Please enter your name");
            //name = Console.ReadLine();

            //var nameArray = new char[name.Length];

            //int i = 0;
            //foreach(var c in name)
            //{
            //    nameArray[i] = c;
            //    i++;
            //}

            //Array.Reverse(nameArray);

            //Console.WriteLine(nameArray);
            //Console.ReadKey();

            //----------------------------------------------------------------
            //Ask user to enter 5 numbers. 
            //If number has already been entered, display error and retry.
            //Once 5 numbers has been obtained. Sort them and display the result.
            //var numbers = new List<int>();
            //int currentNumber;

            //while(numbers.Count < 5)
            //{
            //    Console.WriteLine("Please enter a unique number");
            //    currentNumber = Convert.ToInt32(Console.ReadLine());

            //        if(numbers.Contains(currentNumber))
            //        {
            //            Console.WriteLine("That number is not unique, please retry");
            //            continue;
            //        }
            //    numbers.Add(currentNumber);
            //}
            //numbers.Sort();
            //foreach(var number in numbers)
            //    Console.WriteLine(number);

            //Console.ReadKey();

            //------------------------------------------------------------------
            //Ask the user for numbers until they type "Quit".
            //List may include duplicates.
            //Display the unique numbers entered.
            //var numbers = new List<int>();
            //string input;

            //while (true)
            //{
            //    Console.WriteLine("Enter a number, or type \"quit\" to exit");
            //    input = Console.ReadLine();
            //    if (input == "quit")
            //        break;

            //    numbers.Add(Convert.ToInt32(input));
            //}

            //var uniques = new List<int>();
            //foreach (var number in numbers)
            //{
            //    if (!uniques.Contains(number))
            //    {
            //        uniques.Add(number);
            //    }
            //}

            //foreach (var number in uniques)
            //    Console.WriteLine(number);
            //Console.ReadKey();

            //--------------------------------------------------------------------
            //Ask the user to provide a list of comma-separated numbers.
            //if the list is empty or less that 5 numbers, display "Invalid list" and retry.
            //Otherwise, display the 3 smallest numbers.

            string[] elements;
            string input;

            while (true)
            {
                Console.WriteLine("Please enter a list of comma-separated numbers");
                input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input))
                {
                    elements = input.Split(',');

                    if (elements.Length >= 5)
                    {
                        break;
                    }
                }
                Console.WriteLine("Invalid list, please retry");
            }

            Array.Sort(elements);
            for (var i = 0; i < 3; i++)
                Console.WriteLine(elements[i]);

            Console.ReadKey();




        }

    }
}
