namespace pratice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //11


            //Console.WriteLine("Write a number of stars");
            //int stars=Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < stars; i++)
            //{
            //    Console.WriteLine("*");
            //}


            //12


            //Console.WriteLine("Write the length");
            //int length = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Write the width");
            //int width = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < length; i++) {
            //    for (int j = 0; j < width; j++) {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //13

            //Console.WriteLine("Write the height and width of triangle");
            //int height = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < height; i++) {
            //    for (int j = 0; j < i+1; j++) {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            //for (int i = 0; i < height; i++)
            //{
            //    for (int j = 0; j < height-i; j++)
            //    {
            //        Console.Write(" ");
            //    }

            //    for(int k = 0; k < i + 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 0; i < height; i++)
            //{
            //    for (int j = 0; j < height - i; j++)
            //    {
            //        Console.Write(" ");
            //    }


            //        for (int k = 0; k < i; k++)
            //        {
            //            Console.Write("*");
            //            if (k < i)
            //            {
            //                Console.Write(" ");
            //            }
            //        }
            //    Console.WriteLine();
            //}


            //14
            //Console.WriteLine("Write the number");
            //int replace = Convert.ToInt32(Console.ReadLine());
            //int result = 0;
            //int multiplier = 1;
            //while (replace > 0) {
            //    int digit = replace % 10;
            //    if (digit == 0) {
            //        digit = 5;
            //    }
            //    result= result+( multiplier * digit);

            //    multiplier *= 10;

            //    replace = replace / 10;

            //}
            //Console.WriteLine("the number is "+result);



            //15
            Console.WriteLine("Write the string");
            string a = Console.ReadLine();

            for (int i = a.Length-1; i >= 0; i--)
            {
                Console.Write(a[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < a.Length; i++)
            {
                if ((i+1) % 2 == 0)
                {
                    Console.Write(a[i]);
                }
            }
            Console.WriteLine();
            for (int i = 0; i < a.Length; i++)
            {
                char charh=a[i];  

                if (charh=='a' ||charh  == 'e' || charh == 'i' || charh == 'o' || charh == 'u')
                {
                    
                }
                else
                {
                    Console.Write(a[i]);
                }
            }
        }
    }
}
