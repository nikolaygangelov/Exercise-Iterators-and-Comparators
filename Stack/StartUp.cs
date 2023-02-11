using System;
using System.Linq;

namespace Stack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            CustomStack<int> customStack = new CustomStack<int>();
            string command = Console.ReadLine();

            if (command == "Pop")
            {
                try
                {
                    customStack.Pop();
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
            else
            {
                while (command != "END")
                {
                    if (command != "Pop")
                    {
                        int[] commandIntegers = command
                            .Split(new string[] {" ", ", " }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .Skip(1)
                            .ToArray();

                        for (int i = 0; i < commandIntegers.Length; i++)
                        {
                            customStack.Push(commandIntegers[i]);
                        }
                    }
                    else if (command == "Pop")
                    {
                        try
                        {
                            customStack.Pop();
                        }
                        catch (Exception exception)
                        {
                            Console.WriteLine(exception.Message);
                        }
                        
                    }

                    command = Console.ReadLine();
                }
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(string.Join(Environment.NewLine, customStack));
            }
        }
    }
}
