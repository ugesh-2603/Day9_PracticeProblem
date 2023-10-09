namespace Swap_Competition_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please Choose any Program");
            Console.WriteLine("1.Swap compitetion");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
              
                case 1:
                    Console.WriteLine("Enter the words separated by a space:");
                    string[] words = Console.ReadLine().Split(' ');

                    if (words.Length != 2)
                    {
                        Console.WriteLine("Invalid input. Please enter two words separated by a space.");
                        return;
                    }
                    SwapCompetetion swapCompetetion = new SwapCompetetion();
                    bool canRearrange = swapCompetetion.CanRearrange(words[0], words[1]);

                    Console.WriteLine(canRearrange ? "YES" : "NO");
                    break;
            }
            Console.ReadLine();
        }
    }
}