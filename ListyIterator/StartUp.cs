using System;
using System.Collections.Generic;
using System.Linq;

namespace ListyIterator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<string> customList = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Skip(1)
                .ToList();
            
            CustomListyIterator<string> customListyOperator = new CustomListyIterator<string>(customList);
            
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "END")
            {
                if (command == "Move")
                {
                    Console.WriteLine(customListyOperator.Move());
                }
                else if (command == "Print")
                {
                    try
                    {
                        customListyOperator.Print();
                    }
                    catch (Exception exception)
                    {

                        Console.WriteLine(exception.Message);
                    }
                    
                }
                else if (command == "HasNext")
                {
                    Console.WriteLine(customListyOperator.HasNext());
                }
            }
        }
    }
}
