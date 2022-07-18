using System;

namespace Arrayassignment

{
struct Student
    {
        public string name;
        public int mark;
        public char grade;
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the number of students");
            n = Int32.Parse(Console.ReadLine());
            Student[] array = new Student[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Please Student {0}", i + 1);
                array[i].name = Console.ReadLine();

                while (true)
                {
                    Console.WriteLine("Please student{0} Marks between [0-100]:");
                    string userInput = Console.ReadLine();

                    if (int.TryParse(userInput, out int mark))
                        array[i].mark = mark;
                    if ((array[i].mark > 0) && (array[i].mark < 100))
                    {
                        if (array[i].mark >= 60) array[i].mark = 'A';
                        if (array[i].mark >= 40) array[i].mark= 'B';
                        if (array[i].mark < 40) array[i].mark = 'C';
                        break;
                    }
                    Console.WriteLine("Invalide input=>{0} Please Try again", array[i].mark);
                }
            }
            Console.WriteLine($"Name|Mark|Grade");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{array[i].name}...\t{array[i].mark}...\t{array[i].grade}");
            }



        }


            }
            

        }
   