using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealOrNoDeal
{
    class DealOrNoDeal
    {
        private static object comments_title;

        static void Main()
        {
            int[] boxes =
            {
                1,5,10,20,50,100,200,300,500,750,1000,2500,5000,7500,10000,12500,15000,25000,50000,100000
            };
           
            Random random = new Random();
            for (int i = 0; i < boxes.Length; i++)
            {
                int index = random.Next(0, boxes.Length);
                int index2 = random.Next(0, boxes.Length);
                int temp = boxes[index2];
                boxes[index2] = boxes[index];
                boxes[index] = temp;
               
            }
            Console.WriteLine(String.Join(",",boxes));

            Console.WriteLine();
        }
    }
}
