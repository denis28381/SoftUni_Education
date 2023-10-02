namespace _4._Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] array = input.Split();

            int rotations = int.Parse(Console.ReadLine());

            int n = array.Length;
            rotations = rotations % n;

            for (int i = 0; i < rotations; i++)
            {
                string temp = array[0];
                for (int j = 0; j < n - 1; j++)
                {
                    array[j] = array[j + 1];
                }
                array[n - 1] = temp;
            }

            foreach (string element in array)
            {
                Console.Write(element + " ");
            }
        }
    }
}