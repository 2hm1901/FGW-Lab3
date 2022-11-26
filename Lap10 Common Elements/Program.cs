namespace Lap10_Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array1: ");
            var arr1 = Console.ReadLine().Split().ToArray();

            Console.Write("Enter array2: ");
            var arr2 = Console.ReadLine().Split().ToArray();

            for (int i = 0; i< arr2.Length; i++)
            {
                for (int j = 0; j< arr1.Length; j++)
                {
                    if (arr2[i] == arr1[j])
                    {
                        Console.Write(arr2[i]+" ");
                    }
                }
            }
        }
    }
}