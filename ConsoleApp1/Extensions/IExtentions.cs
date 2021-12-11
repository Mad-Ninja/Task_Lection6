using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
    public static class IExtentions
    {

        

        public static void AddElement<T>(this IList<T> elementList)
            where T : IIsue, new()
        {
            var element = new T();

            element.Set();
            elementList.Add(element);
        }





        public static void ShowElement<T>(this IList<T> elementList, string nameElement)
            where T : Isue
        {
            while (true)
            {
                if (elementList.Count == 0)
                {
                    Console.Clear();
                    Console.WriteLine($"No {nameElement}s\n");
                    break;
                }
                Console.WriteLine($"Enter {nameElement} ID");
                if (int.TryParse(Console.ReadLine(), out var elemId))
                {
                    List<int> listOfId = new List<int>();
                    foreach (var elem in elementList)
                    {
                        listOfId.Add(elem.Id);

                    }

                    if (elemId >= 0 && elemId <= listOfId[listOfId.Count - 1])
                    {
                        Console.Clear();
                        Console.WriteLine(elementList[listOfId.IndexOf(elemId)].Get());

                        break;
                    }
                }
                Console.Clear();
                Console.WriteLine("Incorrect element ID\n");
                break;
            }
        }


        public static void ShowAll<T>(this IList<T> elementList, string nameElement)
            where T : IIsue
        {
            if (elementList.Count == 0)
            {
                
                Console.WriteLine($"No {nameElement}s\n");

            }
            else
            {
                Console.WriteLine($"\t{nameElement.ToUpper()}S:\n");
                foreach (var elem in elementList)
                {

                    Console.WriteLine(elem.Get());
                }
            }         
        }

        public static void SortById<T>(this IList<T> elementList, string nameElement)
            where T : Isue
        {
            var result = elementList.OrderBy(t => t.Id);
            Console.WriteLine($"\t{nameElement.ToUpper()}S:\n");
            foreach (var elem in result)
            {
                Console.WriteLine(elem.Get());
            }
        }
        public static void SortByDate<T>(this IList<T> elementList, string nameElement)
            where T : Isue
        {
            var result = elementList.OrderByDescending(t => t.CreationDate);
            Console.WriteLine($"\t{nameElement.ToUpper()}S:\n");
            foreach (var elem in result)
            {
                Console.WriteLine(elem.Get());
            }
        }


        public static void RemoveElement<T>(this IList<T> elementList, string nameElement)
            where T : Isue
        {
            while (true)
            {
                if (elementList.Count == 0)
                {
                    Console.Clear();
                    Console.WriteLine($"No {nameElement}s\n");
                    break;
                }
                Console.WriteLine($"Enter {nameElement} ID");

                if (int.TryParse(Console.ReadLine(), out var elemId))
                {
                    List<int> listOfId = new List<int>();
                    foreach (var elem in elementList)
                    {
                        listOfId.Add(elem.Id);

                    }

                    if (elemId >= 0 && elemId <= listOfId[listOfId.Count - 1] )
                    {
                        Console.Clear();
                        elementList.RemoveAt(listOfId.IndexOf(elemId));
                        Console.Clear();
                        Console.WriteLine($"{nameElement} removed successfully\n");                 
                        break;
                    }
                }
                Console.Clear();
                Console.WriteLine("Incorrect element ID\n");
                break;
            }
        }


        
    }
}
