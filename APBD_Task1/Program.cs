namespace Task1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello");

            List<int> list = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("adedd " + i);
                list.Add(i);
            }

            var length = list.Count;

            Console.WriteLine("Length of the list: " + length);

            Console.WriteLine("List: " + list.ToString());
        }

        public static double Average(List<int> list)
        {
            var sum = 0.0;
            foreach (int i in list) sum += i;
            var avg = sum / list.Count;
            return avg;
        }

        public static int CalculateMax(List<int> list)
        {
            var max = list[0];
            foreach (int i in list)
            {
                if (i > max) max = i;
            }
            return max;
        }
    }
}