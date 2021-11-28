using System;
using System.IO;
namespace Task_Reading_data_from_a_file
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A: Create a text file and add a few lines of text to it.");
            string pathString = @"C:\Users\Patryk\Desktop";
            System.IO.Directory.CreateDirectory(pathString);
            string fileName = "My text file.txt";
            pathString = System.IO.Path.Combine(pathString, fileName);
            Console.WriteLine("Path to my file: {0}\n", pathString);
            if (!System.IO.File.Exists(pathString))
            {
                using (StreamWriter sw = File.CreateText(pathString))
                {

                    sw.WriteLine("Create a text file");
                    sw.WriteLine("Write a few lines in it");
                    sw.WriteLine("Read the contents of the file");

                }
            }

            Console.WriteLine("B: Using the File.ReadAllText () method, read the contents of the file.");
            string text = System.IO.File.ReadAllText(pathString);
            Console.WriteLine(text);

            Console.WriteLine("C: Display the length of the read text using the string.Length property.");
            string str = System.IO.File.ReadAllText(pathString);
            Console.WriteLine("The length of the text is " + str.Length);
            Console.WriteLine();


            Console.WriteLine("D: Using the File.ReadAllLines () method, read the contents of the file.");
            int counter = 0;
            string line;

            System.IO.StreamReader file =
                new System.IO.StreamReader(@"C:\Users\Patryk\Desktop\My text file.txt");
            while ((line = file.ReadLine()) != null)
            {
                System.Console.WriteLine(line);
                counter++;
            }

            Console.WriteLine();
            Console.WriteLine("E: Display the number of lines of the read text.");
            file.Close();
            System.Console.WriteLine("The number of lines of the read text is {0} lines.", counter);
            System.Console.ReadLine();
        }
    }
}
