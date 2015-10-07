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

        public static int oferta(Dictionary<int, string> boxes)
        {
            average = 0;

            foreach (var item in boxes)
            {
                average += int.Parse(item.Value);
            }

            average /= boxes.Count();
            Console.WriteLine("The bank offer is: {0}", average);
            return average;
        }
        public static void Printboxes(string[] boxarray)
        {



            foreach (var item in boxarray)
            {
                Console.Write("[{0}]", item);
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("{0,10}{1,10}{2,10}{3,10}{4,10}", valuesarray[0], valuesarray[5], valuesarray[10], valuesarray[15], valuesarray[20]);
            Console.WriteLine("{0,10}{1,10}{2,10}{3,10}", valuesarray[1], valuesarray[6], valuesarray[11], valuesarray[16]);
            Console.WriteLine("{0,10}{1,10}{2,10}{3,10}", valuesarray[2], valuesarray[7], valuesarray[12], valuesarray[17]);
            Console.WriteLine("{0,10}{1,10}{2,10}{3,10}", valuesarray[3], valuesarray[8], valuesarray[13], valuesarray[18]);
            Console.WriteLine("{0,10}{1,10}{2,10}{3,10}", valuesarray[4], valuesarray[9], valuesarray[14], valuesarray[19]);

        }
        public static int Getbox(int index3)
        {

            Console.WriteLine();
            Console.Write("Choose box from 1 to 21: ");

            while (true)
            {


                try
                {
                    index3 = int.Parse(Console.ReadLine());
                    break;

                }
                catch (FormatException)
                {

                    index3 = 100;
                    Console.WriteLine("Invalid input! ");
                    Console.WriteLine("Enter box number again!");
                }

            }
           
            index3--;

            int proverka = index3;
            while ((proverka < 0) || (proverka > 20))
            {
                Console.WriteLine("Invalid input! ");
                Console.WriteLine("Enter box number again!");

                index3 = int.Parse(Console.ReadLine());
                index3--;
                proverka = index3;
            }
            return index3;
        }
        

        public static void Openbox(int index3, Dictionary<int, string> boxes, string[] boxarray)
        {
            int box1 = 0;



            try
            {

                box1 = Getbox(index3);
                boxarray[box1] = "x";
                Console.WriteLine("You opened box {0} : {1}", box1 + 1, boxes[box1]);
                removevalue = boxes[box1];

                for (int i = 0; i < valuesarray.Length; i++)
                {
                    if (removevalue == valuesarray[i])
                    {
                        valuesarray[i] = "XXX";
                    }
                }

                boxes.Remove(box1);
                catch (KeyNotFoundException)
            {

                Console.WriteLine();
                Console.WriteLine("{0,53}", "Box already opened! ");
                Console.WriteLine("{0,48}", "Try Again!");
                Console.WriteLine();
                Openbox(index3, boxes, boxarray);

            }



        }
    }


        public static int Getbox(int index3)
        {

            Console.WriteLine();
            Console.Write("{0,53}", "Choose box from 1 to 21: ");

            while (true)
            {


                try
                {
                    index3 = int.Parse(Console.ReadLine());
                    break;

                }
                catch (FormatException)
                {

                    index3 = 100;
                    Console.WriteLine("{0,50}", "Invalid input! ");
                    Console.WriteLine("{0,53}", "Enter box number again!");
                }

            }

            index3--;

            int proverka = index3;
            while ((proverka< 0) || (proverka > 20))
            {
                Console.WriteLine("Invalid input! ");
                Console.WriteLine("Enter box number again!");

                index3 = int.Parse(Console.ReadLine());
                index3--;
                proverka = index3;
            }
            return index3;
        }



        static void Main()
        {
            int index3 = 0;



            List<int> boxesList = new List<int>
            {
                1,5,10,20,50,100,200,300,500,750,1000,2500,5000,7500,10000,12500,15000,25000,50000,75000,100000
            };
            Random random = new Random();
            for (int i = 0; i < boxesList.Count; i++)
            {
                int index = random.Next(0, boxesList.Count);
                int index2 = random.Next(0, boxesList.Count);
                int temp = boxesList[index2];
                boxesList[index2] = boxesList[index];
                boxesList[index] = temp;
            }
        Dictionary<int, string> boxes = new Dictionary<int, string>();

        for (int i = 0; i < boxesList.Count; i++)
        {
            boxes[i] = boxesList[i].ToString();
        }

        Printboxes(boxarray);

        Console.WriteLine();
        Console.WriteLine("{0,48}", "Choose your box :");

        try
        {

            guz = Getbox(index3);
            boxarray[guz] = "Your Box";
            Console.WriteLine("{0,48} {1}", "You choose box: ", guz + 1);



        }

        catch (KeyNotFoundException)
        {
            Console.WriteLine();
            Console.WriteLine("Box already opened! ");
            Console.WriteLine("Try Again!");
            Console.WriteLine();
            Openbox(index3, boxes, boxarray);

        }

        game(index3, boxes);
        Console.Clear();
        game(index3, boxes);
        Console.Clear();
        game(index3, boxes);
        Console.Clear();
        game(index3, boxes);
        Console.Clear();
        game(index3, boxes);
        Console.Clear();

        game1(index3, boxes);
        Console.WriteLine("The game continues!");
        game1(index3, boxes);
        Console.WriteLine("The game continues!");

        Printboxes(boxarray);

        Openbox(index3, boxes, boxarray);
        Printboxes(boxarray);

        Console.WriteLine();


        Console.WriteLine("Game over");
        Console.WriteLine("The remaining box is your price");
        Console.Write("You win {0}$ !!!!!!", string.Join(" ", boxes.Values));





    }
}




    
    

