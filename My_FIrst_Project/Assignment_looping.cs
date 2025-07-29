namespace My_FIrst_Project
{
    internal class Assignment_looping
    {
        static void Main(string[] args)
        {
            //  A program that displays the menu for food items and price
            int price = 0;
            string food_item = " ";
            Console.Write("Choose the food item\n" +
                "1.for Burger\n" +
                "2.for Pizza\n" +
                "3.for Maggie\n" +
                "4.for Fried Rice\n");
            
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    price = 100;
                    food_item = "Burger.";
                    Console.WriteLine(food_item + " RS- " + price);
                    break;
                case 2:
                    price = 120;
                    food_item = "Pizza";
                    Console.WriteLine(food_item + " RS- " + price); break;
                case 3:
                    price = 60;
                    food_item = "Maggie";
                    Console.WriteLine(food_item + " RS- " + price);
                    break;
                case 4:
                    price = 110;
                    food_item = "Fried rice";
                    Console.WriteLine(food_item + " RS- " + price);
                    break;
                default:
                    Console.WriteLine("Try Again.");
                    break;
            }




            // loop to check Students upto 10 and display message in console

            // for loop
             
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Student {i} is Present");
               
            }
            // while loop
            int j = 1;
            while (j <= 10) {
                Console.WriteLine($" Student {j} is Present.");
                j++;
            }
            // Do-While loop

            int k = 1;
            do
            {
                Console.WriteLine($"Student {k} is Present.");
                k++;
            }while (k <= 10);

            // Foreach loop

            string[] Mobiles = { "Samsung", "Apple", "Redmi", "Motorola", "Realme", "Oppo", "Blackberry", "Google Pixel", "Vivo", "Poco" };

            foreach (string mobile in Mobiles)
            {
                Console.WriteLine(mobile);
            }



        }
    }
}

