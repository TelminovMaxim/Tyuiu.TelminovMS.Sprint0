using Tyuiu.TelminovMS.Sprint0.Task6.V0.Lib;

namespace Tyuiu.TelminovMS.Sprint0.Task6.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 1, 2, 3, 4, 5, 6 };

            Console.WriteLine("Сумма элементов масива равна: " + DataService.AdditionArray(numbers));
            Console.WriteLine("Разность элементов масива равна: " + DataService.SubstracyionArray(numbers));
            Console.WriteLine("Произведение элементов масива равна: " + DataService.MultiplicationArray(numbers));
            Console.ReadKey();
        }
    }
}
