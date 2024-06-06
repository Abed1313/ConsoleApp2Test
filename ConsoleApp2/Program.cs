namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            reverceA();

        }

        static void reverceA()
        {
            int[] arr = [1, 2, 3, 4, 5];
            int[] arr2 = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                arr2[i] = arr[arr.Length - 1 ];
            }
            foreach (int i in arr2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
