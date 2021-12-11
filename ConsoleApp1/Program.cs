using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Bug> bugs = new List<Bug>();
           
            List<TestCase> testCases = new List<TestCase>();


            while (true)
            {
                Console.WriteLine("\n\nCHOOSE AN ACTION:\n");
                var choice = Actions.Choose(
                        "Add element",
                        "Show element by ID",
                        "Show all elements",
                        "Remove element"
                        
                        );





               switch (choice)
                {
                    case 0:
                        Console.Clear();
                        var choice2 = Actions.Choose("Add bug", "Add Test Case");
                        if(choice2 == 0)
                        {
                            Console.Clear();
                            bugs.AddElement();
                        }
                        else if(choice2 == 1)
                        {
                            Console.Clear();
                            testCases.AddElement();
                        }
                        break;
                    case 1:
                        Console.Clear();
                        var choice3 = Actions.Choose("Show bug", "Show Test Case");
                        if(choice3 == 0)
                        {
                            Console.Clear();
                            bugs.ShowElement("Bug");
                        }
                        else if(choice3 == 1)
                        {
                            Console.Clear();
                            testCases.ShowElement("Test Case");
                        }
                        break;
                    case 2:

                        Console.Clear();
                        bugs.ShowAll("Bug");
                        testCases.ShowAll("Test Case");
                        while (bugs.Count !=0 || testCases.Count != 0)
                        {
                      
                            
                            
                            var choice5 = Actions.Choose("Sort elements",  "Exit");
                            if(choice5 == 0)
                            {
                                Console.Clear();
                                var choice6 = Actions.Choose("Sort by ID", "Sort by Date");
                                if(choice6 == 0)
                                {
                                    Console.Clear();
                                    bugs.SortById("Bug");
                                    testCases.SortById("Test Case");
                                }
                                else if(choice6 == 1) 
                                {
                                    Console.Clear();
                                    bugs.SortByDate("Bug");
                                    testCases.SortByDate("Test Case");
                                }

                            }
                           
                            else if(choice5 == 1)
                            {
                                Console.Clear();
                                break;
                            }

                        }
                        

                        break;

                    case 3:
                        Console.Clear();
                        var choice4 = Actions.Choose("Remove bug", "Remove Test Case");
                        if (choice4 == 0)
                        {
                            bugs.RemoveElement("Bug");
                        }
                        else if (choice4 == 1)
                        {
                            testCases.RemoveElement("Test Case");
                        }
                        break;
                }
            }




            

        }
    }
}
