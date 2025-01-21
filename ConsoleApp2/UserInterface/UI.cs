using ConsoleApp2.Entities;
using ConsoleApp2.Services;
using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2.UserInterface
{
    public static class UI
    {
        public static void Run()
        {
            WriteLine(" ___________________________________________________________");
            WriteLine("|                                                           |");
            WriteLine("|        Grade Point Average (GPA) calculator               |");
            WriteLine("|___________________________________________________________|");
            WriteLine();
            WriteLine("Welcome!!!!!\n To calculate your GPA, enter your course details");
            WriteLine("Enter student name");


            string[] name = Console.ReadLine().Trim().Split(" ");
            string names = string.Join(" ", name);

            WriteLine("Enter student Id");
            int id = int.Parse(Console.ReadLine());

            var student = new Student(name, id);
            var studentService = new StudentService();

            bool invalid = true;
            bool checking = true;

            while (checking)
            {
            start:
                while (invalid)
                {
                    Console.Write("Press Enter to input details");
                    string[] input = ReadLine().Split(", ");

                    try
                    {
                        studentService.AddCourses(student, input);
                        invalid = false;
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine($"\n{e.Message}");
                        student = new Student(name, id);
                        goto start;
                    }

                }


                WriteLine("\nCalculating your GPA. Please wait ...\n");
                Thread.Sleep(3000);
                Console.WriteLine($"Student ID {id}  Name : {names}.");

                GradeService.Calculate(student);

                Write("\nCheck again? (Y/N): ");
                string answer = ReadLine().ToUpper();

                if (answer == "Y")
                {
                    student = new Student(name, id);
                    invalid = true;
                    goto start;
                }
                else
                {
                    checking = false;
                }
          
            
            }
            Console.WriteLine("\nThank you for using the GPA calculator!");
        }
   
    }
}
