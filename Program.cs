namespace hw12
{
    internal class Program
    {
        static void Main(string[] args)
        //{
        //    Print("bruh");
        //    Print(96);
        //    Print(true);


        //}

        //static void Print<T>(T value)
        //{
        //    Console.WriteLine(value);
        //}
        {
            int value1 = 2;
            int value2 = 3;
            Swap(ref value1,ref value2);
            Console.WriteLine($"value 2 is now: {value2} and value 2: {value1}");

        }
        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}