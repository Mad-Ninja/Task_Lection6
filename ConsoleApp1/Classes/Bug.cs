using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1

{
    public class Bug : Isue
    {
        

        public int TestCaseId  { get; set; }

        public int StepNumber { get; set; }

        public string ActualResult { get; set; }

        public string ExpectedResult { get; set; }





        public Bug() : base()
        {
            
        }



        public override string Get()
        {
            return string.Concat(base.Get(), $"\nTest Case Id: {TestCaseId}", $"\nStep Number: {StepNumber}", $"\nActual Result: {ActualResult}", $"\nExpected Result: {ExpectedResult}\n");
        }



        public override void Set()
        {
            base.Set();
            Console.Clear();
            while (true)
            {
                Console.WriteLine("Enter Step number :");
                if (int.TryParse(Console.ReadLine(), out var tempStNum))
                {
                    StepNumber = tempStNum;
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Incorrect Step number\n");
                }
            }
            Console.Clear();
            while (true)
            {
                Console.WriteLine("Enter Actual Result:");
                string tempAcRes = Console.ReadLine();
                if (tempAcRes != "")
                {
                    ActualResult = tempAcRes;
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Incorrect Actual Result\n");
                }
            }
            Console.Clear();
            while (true)
            {
                Console.WriteLine("Enter Expected Result:");
                string tempExRes = Console.ReadLine();
                if (tempExRes != "")
                {
                    ExpectedResult = tempExRes;
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Incorrect Expected Result\n");
                }
            }
            Console.Clear();
        }






        











    }
}
