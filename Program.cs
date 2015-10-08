using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;

namespace DealOrNoDeal
{
    class DealOrNoDeal
    {
        static SoundPlayer Theme = new SoundPlayer("../../Theme.wav");
        static SoundPlayer phoneRing = new SoundPlayer("../../Ring.wav");
        static SoundPlayer thinking = new SoundPlayer("../../Thinking.wav");
        static SoundPlayer deal = new SoundPlayer("../../Deal.wav");
        static int tempProverka = 0;
        public static int box1;
        static int boxChoice = 0;
        static string removeValue = "";
        static string[] valuesArray = new string[] { "1", "5", "10", "20", "50", "100", "200", "300", "500", "750", "1000", "2500", "5000", "7500", "10000", "12500", "15000", "25000", "50000", "75000", "100000" };
        static string[] boxArray = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21" };
        static int average = 0;
        static int control = 0;
        static ConsoleKeyInfo exitChar = new ConsoleKeyInfo();

        public static void Game1(int index3, Dictionary<int, string> boxes)
        {
            if (tempProverka == 0)
            {

                Printboxes(boxArray);

                Console.WriteLine("{0,52}", "- Now you must open 2 boxes! -");
                Console.WriteLine();

                OpenBox(index3, boxes, boxArray);
                Printboxes(boxArray);

                OpenBox(index3, boxes, boxArray);
                Printboxes(boxArray);

                average = Offer(boxes);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("{0,55}", "DEAL             or             NO DEAL?");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("{0,63}", "Press [1] for Deal         :         Press [0] for No Deal");
                Console.Write("{0,33}", " ");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("{0,63}", "Press [1] for Deal         :         Press [0] for No Deal");
                Console.Write("{0,33}", " ");
                tempProverka = 0;
            }


            ConsoleKeyInfo decision = Console.ReadKey();

      
            if (decision.KeyChar == '1')
            {

                Console.Clear();
                deal.Play();

                Console.WriteLine("\n\n");
                Console.WriteLine("{0,47}", "You have taken the Deal!");
                Console.WriteLine("\n\n\n\n\n");
                Console.WriteLine("{0,36}{1}$  **", "**   You WON ", average);
                Console.WriteLine("\n\n\n\n\n");
                Console.WriteLine("{0,48}", "   * Congratulations!!! *   ");
                Console.Write("\n\n\n\n\n\n\n                         ");
                exitChar = Console.ReadKey();
                Environment.Exit(0);

            }

            else if (decision.KeyChar == '0')
            {
                Console.Clear();
                Console.WriteLine("\r___________________________________________________________________");
                Console.WriteLine("\n{0,34}\n", "*");
                Console.WriteLine("{0,45}", "-You refused the offer!-");
        
            }


            else
            {

                Console.WriteLine("\n\n");
                Console.WriteLine("{0,48}", "Incorrect Input!");
                Console.WriteLine("\n\n");
                tempProverka = 1;
                Game(index3, boxes);
            }
        }
        public static void Game(int index3, Dictionary<int, string> boxes)
        {
            

            if (tempProverka == 0)
            {

                Printboxes(boxArray);

                Console.WriteLine("{0,49}", "- Now you must open 3 boxes! -");
                Console.WriteLine();

                OpenBox(index3, boxes, boxArray);
                Printboxes(boxArray);


                OpenBox(index3, boxes, boxArray);
                Printboxes(boxArray);


                OpenBox(index3, boxes, boxArray);
                Printboxes(boxArray);

                average = Offer(boxes);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("{0,55}", "DEAL             or             NO DEAL?");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("{0,63}", "Press [1] for Deal         :         Press [0] for No Deal");
                Console.Write("{0,33}", " ");
  
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("{0,63}", "Press [1] for Deal         :         Press [0] for No Deal");
                Console.Write("{0,33}", " ");
                tempProverka = 0;
            }


            ConsoleKeyInfo decision = Console.ReadKey();


            if (decision.KeyChar == '1')
            {
                Console.Clear();

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                deal.Play();

                Console.WriteLine("\n\n");
                Console.WriteLine("{0,47}", "You have taken the Deal!");
                Console.WriteLine("\n\n\n\n\n");
                Console.WriteLine("{0,36}{1}$  **", "**   You WON ", average);
                Console.WriteLine("\n\n\n\n\n");
                Console.WriteLine("{0,48}", "   * Congratulations!!! *   ");
                Console.Write("\n\n\n\n\n\n\n                         ");
                exitChar = Console.ReadKey();
                Environment.Exit(0);

            }

            else if (decision.KeyChar == '0')
            {
                phoneRing.Stop();
                Console.Clear();

                Console.WriteLine("\r___________________________________________________________________");               
                Console.WriteLine("\n{0,34}\n", "*");
                Console.WriteLine("{0,47}", "-You refused the offer!-");
                Console.WriteLine();
                Console.WriteLine("{0,46}", "-The game continues!-");
                Console.WriteLine("\n{0,34}\n", "*");
            }


            else
            {
                
                Console.WriteLine("\n\n");
                Console.WriteLine("{0,48}","Incorrect Input!");
                Console.WriteLine("\n\n");
                tempProverka = 1;
                Game(index3, boxes);

            }
        }

        public static int Offer(Dictionary<int,string> boxes)
        {
            average = 0;

            foreach (var item in boxes)
            {
                average += int.Parse(item.Value);
            }

            average /= boxes.Count();
            phoneRing.Play();
            Console.WriteLine("{0,48}", "*--Time to call the banker!--*");
            Console.WriteLine("\n{0,33}\n{0,33}\n{0,33}\n", "*" );
            Console.WriteLine("{0,42}{1}$", "The bankers' offer is: ", average);
            return average;
        }

        public static void Printboxes(string[] boxarray)
        {
            
            Console.WriteLine("___________________________________________________________________");
            Console.WriteLine();
            Console.WriteLine("{0,-10}{1,25}{2,32}","[" + boxarray[0] + "]", "[" + boxarray[20] + "]", "[" + boxarray[10] + "]");
            Console.WriteLine("{0,-10}{1,57}", "[" + boxarray[1] + "]", "[" + boxarray[11] + "]");
            Console.WriteLine("{0,-10}{1,57}", "[" + boxarray[2] + "]", "[" + boxarray[12] + "]");
            Console.WriteLine("{0,-10}{1,10}{2,10}{3,10}{4,10}{5,17}", "[" + boxarray[3] + "]", valuesArray[0], valuesArray[5], valuesArray[10], valuesArray[15], "[" + boxarray[13] + "]");
            Console.WriteLine("{0,-10}{1,10}{2,10}{3,10}{4,10}{5,17}", "[" + boxarray[4] + "]", valuesArray[1], valuesArray[6], valuesArray[11], valuesArray[16], "[" + boxarray[14] + "]");
            Console.WriteLine("{0,-10}{1,10}{2,10}{3,10}{4,10}{5,17}", "[" + boxarray[5] + "]", valuesArray[2], valuesArray[7], valuesArray[12], valuesArray[17], "[" + boxarray[15] + "]");
            Console.WriteLine("{0,-10}{1,10}{2,10}{3,10}{4,10}{5,17}", "[" + boxarray[6] + "]", valuesArray[3], valuesArray[8], valuesArray[13], valuesArray[18], "[" + boxarray[16] + "]");
            Console.WriteLine("{0,-10}{1,10}{2,10}{3,10}{4,10}{5,17}", "[" + boxarray[7] + "]", valuesArray[4], valuesArray[9], valuesArray[14], valuesArray[19], "[" + boxarray[17] + "]");
            Console.WriteLine("{0,-10}{1,57}", "[" + boxarray[8] + "]", "[" + boxarray[18] + "]");
            Console.WriteLine("{0,-10}{1,26}{2,31}", "[" + boxarray[9] + "]", valuesArray[20], "[" + boxarray[19] + "]");
            Console.WriteLine();
            Console.WriteLine("___________________________________________________________________");
        }


        public static int GetBox(int index3)
           {
            if (control == 0)
            {

                Console.WriteLine("\n{0,56}\n", "* * * * * * * * * * * * * * * * * * * * * * *");
                Console.Write("{0,46}", "Pick a box from 1 to 21: ");
                control++;
            }
            else
            {
                Console.WriteLine();
                Console.Write("{0,47}", "Choose a box to open:  ");
            }

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
                    Console.WriteLine("{0,42}", "Invalid input! ");
                    Console.WriteLine("{0,45}", "Enter box number again!");
                    Console.Write("{0,33}", " ");
                }

            }
            index3--;

            int proverka = index3;
            while ((proverka < 0) || (proverka > 20))
            {
                Console.WriteLine("{0,42}", "Invalid input! ");
                Console.WriteLine("{0,45}", "Enter box number again!");
                Console.Write("{0,33}", " ");

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
                        Console.WriteLine("{0,42}", "Invalid input! ");
                        Console.WriteLine("{0,45}", "Enter box number again!");
                        Console.Write("{0,33}", " ");

                    }
                }
                index3--;
                proverka = index3;
            }
            return index3;
        }
        public static void OpenBox(int index3,Dictionary<int,string>boxes, string[] boxarray)
        {
           int box1 = 0;
            
            

            try
            {
                
                box1 = GetBox(index3);
                if (boxChoice == box1)
                {
                    Console.WriteLine("\n{0,34}\n", "*");
                    Console.WriteLine("{0,46}", "You cannot open your box!");
                    Console.WriteLine("\n{0,34}\n", "*");
                    OpenBox(index3, boxes, boxarray);
                }

                if (boxChoice != box1)
                {
                    boxarray[box1] = "x";
                    Console.WriteLine();
                    Console.WriteLine("{0,37}{1} :   {2}$", "You opened box ", box1 + 1, boxes[box1]);
                    removeValue = boxes[box1];
                }


                for (int i = 0; i < valuesArray.Length; i++)
                {
                   
                    if (removeValue == valuesArray[i])
                    {
                        valuesArray[i] = "";
                        //valuesArray[i] = "[XXX]";
                    }
                }

                boxes.Remove(box1);
                
            }

            catch (KeyNotFoundException)
            {

                Console.WriteLine("\n{0,34}\n", "*");
                Console.WriteLine("{0,43}", "Box already opened! ");
                Console.WriteLine("{0,38}", "Try Again!");
                Console.WriteLine("\n{0,34}\n", "*");
                OpenBox(index3,boxes,boxarray);

            }

            catch (FormatException)
            {

                Console.WriteLine("{0,46}", "Invalid input! ");
                Console.WriteLine("{0,49}", "Enter box number again!");
                
                Console.WriteLine();
            }

        }

        static void Main()
        {
           Console.WindowHeight = 56;
           Console.BufferWidth = Console.WindowWidth = 67;
           Console.BufferHeight = 100;

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
            Dictionary < int,string>boxes= new Dictionary<int, string>();

            for (int i = 0; i < boxesList.Count; i++)
            {
                boxes[i] = boxesList[i].ToString();
            }

            Printboxes(boxArray);

            Console.WriteLine();
            Console.WriteLine("{0,47}", "- Time to choose Your Box! -");

            int finalBoxValue = 0;

            try
            {

                boxChoice = GetBox(index3);
                finalBoxValue = int.Parse(boxes[boxChoice]);
                boxArray[boxChoice] = "Your Box";
                Console.WriteLine();
                Console.WriteLine("{0,41} {1}", "You choose box: ", boxChoice + 1);
                Console.WriteLine("\n{0,34}\n", "*");
                Console.WriteLine("{0,43}", "This is YOUR box.");
                Console.WriteLine("{0,64}", "The value inside will be your final prize if no Deal is made!");
                Console.WriteLine("\n\n{0,34}\n", "*");
                Console.WriteLine();

            }

            catch (KeyNotFoundException)
            {
                Console.WriteLine();
                Console.WriteLine("Box already opened! ");
                Console.WriteLine("Try Again!");
                Console.WriteLine();
                OpenBox(index3, boxes, boxArray);

            }

            Game(index3, boxes);
            Console.Clear();
            Game(index3, boxes);
            Console.Clear();
            Game(index3, boxes);
            Console.Clear();
            Game(index3, boxes);
            Console.Clear();
            Game(index3, boxes);
            Console.Clear();

            Game1(index3, boxes);
            Console.WriteLine();
            Console.WriteLine("{0,50}", "-The game continues!-");
            Console.WriteLine("\n{0,40}\n", "*");
            Console.Clear();

            Game1(index3, boxes);

            thinking.Play();
            Console.WriteLine();
            Console.WriteLine("{0,37}", "Game Over");
            Console.WriteLine();
            Console.WriteLine("{0,46}", "That was the final offer");
            Console.WriteLine();
            Console.WriteLine("{0,51}", "Now let's see what is in your box!");
            Console.WriteLine("\n{0,34}\n{0,34}\n{0,34}\n", "*");

            Console.WriteLine("{0,45}", "Press any key to open!");
            Console.Write("{0,39}", " ");

            ConsoleKeyInfo finalChar = Console.ReadKey();

            Console.Clear();
            deal.Play();
            Console.WriteLine("\n\n\n\n\n\n");
            Console.WriteLine("{0,43}", "Your box contains:");

            Console.WriteLine("\n\n\n");

            Console.WriteLine("\n{0,35}\n{0,35}\n{0,35}\n", ".");
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("{0,36} $", finalBoxValue);
           
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("\n\n\n\n\n\n\n                                     ");
            exitChar = Console.ReadKey();

        }
    }
}
