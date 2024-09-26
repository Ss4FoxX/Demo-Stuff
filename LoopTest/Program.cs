namespace LoopTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Stopper = 0;
            int rowSize = 3;
            int colSize = 4;

            /*while (Stopper < 10)
            {
                int row = Stopper / colSize;
                int col = Stopper / rowSize;

                Console.WriteLine($"While Loop is on, {Stopper} loops until loop end");
                Console.WriteLine($"The row number is {row}");
                Console.WriteLine($"The col number is {col}");
                
                Stopper++;
            } */

            for (Stopper = 0; Stopper <= 12; Stopper++)
            {

                int row = Stopper / colSize;
                int col = Stopper / rowSize;
                Console.WriteLine($"The number is {Stopper} -> [{row},{col}] ");
            }
             
            Console.WriteLine("Stopper as activated");
        }
    }
}
