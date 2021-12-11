using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class TestCase : Isue
    {

  

        private List<Step> Steps { get; set; } = new List<Step>();

        public TestCase() : base()
        {
                    
        }


        public override string Get()
        {
            var steps = "";

                 for (int i = 0; i < Steps.Count; i++)
            {

               steps += Steps[i].Show();

            }
            return string.Concat(base.Get(), $"\nSteps:\n{steps}\n");
        }



        public override void Set()
        {
            base.Set();


            Console.Clear();
            while (true)
            {
                Console.WriteLine("Add step?(1 - Yes, 2 - No):");
                if (int.TryParse(Console.ReadLine(), out var value))
                {
                    if (value == 1)
                    {
                        Step step = new Step();
                        step.Fill();
                        Steps.Add(step);

                    }
                    if (value == 2) { break; }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Incorrect input\n");
                }
            }
            Console.Clear();
        }






















        




    }
}
