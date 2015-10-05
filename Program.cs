using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealOrNoDeal
{


    class Program
    {
        static string removevalue = "";
        static string[] valuesarray = new string[] { "1", "5", "10", "20", "50", "100", "200", "300", "500", "750", "1000", "2500", "5000", "7500", "10000", "12500", "15000", "25000", "50000", "75000", "100000" };
        static string[] boxarray = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21" };
        static int average = 0;

        public static void game1(int index3, Dictionary<int, string> boxes)
        {
            Printboxes(boxarray);



            Openbox(index3, boxes, boxarray);
            Printboxes(boxarray);


            Openbox(index3, boxes, boxarray);
            Printboxes(boxarray);


            average = oferta(boxes);
            Console.WriteLine("Deal or No Deal?");
            Console.WriteLine("Press 1 for Deal :  Press 0 for No Deal");
            
            ConsoleKeyInfo decision = Console.ReadKey();


            if (decision.KeyChar == '1')
            {
                Console.WriteLine();
                Console.WriteLine("Congratulations!!!");
                Console.WriteLine("You won {0}$", average);
                Environment.Exit(0);

            }


    Console.WriteLine();
            Console.WriteLine("You refused the offer!");
            
            Console.WriteLine();
        }
        



        public static void game(int index3, Dictionary<int, string> boxes)
        {
            Printboxes(boxarray);



            Openbox(index3, boxes, boxarray);
            Printboxes(boxarray);


            Openbox(index3, boxes, boxarray);
            Printboxes(boxarray);


            Openbox(index3, boxes, boxarray);
            Printboxes(boxarray);

            average = oferta(boxes);
            Console.WriteLine("Deal or No Deal?");
            Console.WriteLine("Press 1 for Deal :  Press 0 for No Deal");

            ConsoleKeyInfo decision = Console.ReadKey();


            if (decision.KeyChar == '1')
            {
                Console.WriteLine();
                Console.WriteLine("Congratulations!!!");
                Console.WriteLine("You won {0}$", average);
                Environment.Exit(0);

            }


            Console.WriteLine();
            Console.WriteLine("You refused the offer!");
            Console.WriteLine("The game continues!");
            Console.WriteLine();
        }



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
