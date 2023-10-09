namespace Day9_PracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please Choose any Program");
            Console.WriteLine("1.Duplicate number\n" +
                "2.Swap compitetion");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    PriceList priceList = new PriceList();
                    priceList.PriceListForSoldItem();
                    break;

                    

                   
                    
            }
            Console.ReadLine();


        }
    }
}