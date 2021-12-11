using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace ConsoleApp1
{
    public abstract class Isue : IIsue
    {
        private static int idCounter;

        public int Id { get; set; }

        public DateTime CreationDate { get; set; }

        public Priority Priority { get; set; }

        public string Summary { get; set; }

        public string Precondition { get; set; }

        public Status Status { get; set; }



        public Isue()
        {
            Id = idCounter++;
            CreationDate = DateTime.Now;

        }

        public virtual string Get()
        {
            return string.Concat($"Id: {Id}", $"\nCreation date: {CreationDate}", $"\nPriority: {Priority}", $"\nSummarry: {Summary}", $"\nPrecondition: {Precondition}", $"\nStatus: {Status}");
        }



        public virtual void Set()
        {
            CreationDate = DateTime.Now;

            Console.WriteLine("Enter priority( 1 - Low, 2 - Medium, 3 - High):");

            this.Priority = (Priority)Actions.ChooseEnumOptions<Priority>();

            Console.Clear();
            while (true)
            {
                Console.WriteLine("Enter summary:");
                string tempSum = Console.ReadLine();
                if (tempSum != "")
                {
                    Summary = tempSum;
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Incorrect summary\n");
                }
            }
            Console.Clear();
            while (true)
            {

                Console.WriteLine("Enter precondition:");
                string tempPrec = Console.ReadLine();
                if (tempPrec != "")
                {
                    Precondition = tempPrec;
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Incorrect precondition\n");
                }
            }

            Console.Clear();
            Console.WriteLine("Enter status( 1 - New, 2 - In Progress, 3 - Failed, 4 - Done):");

            this.Status = (Status)Actions.ChooseEnumOptions<Status>();

        }
    }
}
