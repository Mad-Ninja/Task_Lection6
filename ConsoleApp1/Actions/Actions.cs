using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Actions
    {
        public static int Choose(params string[] menuList)
        {
            int choice;
            while (true)
            {
                
                ShowOptions(menuList);

                try
                {
                    if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > menuList.Length)
                    {
                        throw new InvalidInputExceptions();
                    }
                    return choice - 1;
                }
                catch (InvalidInputExceptions ex)
                {
                    ex.ShowMessage();
                }
            }




           






            
        }

        public static int ChooseEnumOptions<T>()
           where T : Enum
        {
            var str = new List<string>();
            foreach (var option in Enum.GetValues(typeof(T)))
            {
                str.Add(option.ToString());
            }

            return Choose(str.ToArray());
        }

        public static void ShowOptions(params string[] menuList)
        {
            for (int i = 0; i < menuList.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {menuList[i]}");
            }
        }

    }
}
