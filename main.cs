using System;
class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a Color");
            string color = Console.ReadLine();

            switch (color)
            {
                case "red":
                    Console.WriteLine("The color red is warm");
                    break;
                case "orange":
                    Console.WriteLine("The color orange is warm");
                    break;
                case "yellow":
                    Console.WriteLine("The color yellow is warm");
                    break;
                case "gold":
                    Console.WriteLine("The color gold is warm");
                    break;
                case "pink":
                    Console.WriteLine("The color pink is warm");
                    break;

                case "blue":
                    Console.WriteLine("The color blue is cold");
                    break;
                case "purple":
                    Console.WriteLine("The color purple is cold");
                    break;
                case "magenta":
                    Console.WriteLine("The color magenta is cold");
                    break;
                case "green":
                    Console.WriteLine("The color green is cold");
                    break;

                case "brown":
                    Console.WriteLine("The color blue is neutral");
                    break;
                case "ivory":
                    Console.WriteLine("The color purple is neutral");
                    break;
                case "white":
                    Console.WriteLine("The color magenta is neutral");
                    break;
                case "black":
                    Console.WriteLine("The color green is neutral");
                    break;
                case "beige":
                    Console.WriteLine("The color beige is neutral");
                    break;

                default:
                Console.WriteLine("Unable to determine the temperature for the color " + color);
                    break;

            }




        }
 
    

    }