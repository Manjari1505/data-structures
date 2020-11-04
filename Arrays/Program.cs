using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static List<int> RotateArray(List<int> array, int rot)
        {
            List<int> temp = new List<int>();
            int i = 0;

            if(rot>array.Count)
            {
                rot = rot - array.Count;
            }

            for (int j = 0; j < rot; j++)
            {
                temp.Add(array[j]);
            }

            for (i = 0; i < array.Count - rot; i++)
            {
                array[i] = array[i + rot];
            }

            for (int k = i; k < array.Count; k++)
            {
                array[k] = temp[k - i];
            }

            return array;
        }
        static int ShowMenu()
        {
            var choiceInt = 0;
            Console.WriteLine("Array Operations available:\n");
            Console.WriteLine("1. Rotate array");
            Console.WriteLine("Press -1 to exit");

            var userChoice = Console.ReadLine();
            if (userChoice != null && userChoice != "")
            {
                choiceInt = Int32.Parse(userChoice);
            }

            return choiceInt;
        }
        static void Main(string[] args)
        {
            var array = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9};
            var result = new List<int>();
            var choice = 0;

            while (choice != -1)
            {
                choice = ShowMenu();

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter number of rotations: ");
                        int rot = Int32.Parse(Console.ReadLine());
                        result = RotateArray(array, rot);
                        Console.WriteLine();
                        result.ForEach(x=> Console.Write(x + " "));
                        Console.WriteLine();
                        array = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                        break;

                    case -1:
                        Console.WriteLine("Bye");
                        Console.ReadLine();
                        break;
                    default:
                        Console.ReadLine();
                        array = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                        break;
                }
            }

        }
    }
}
