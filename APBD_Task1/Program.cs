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

        public static double Average(List<int> values)
        {
            var sum = 0.0;
            foreach (int i in values) sum += i;
            var avg = sum / values.Count;
            return avg;
        }

        public static int CalculateMax(List<int> values)
        {
            var max = values[0];
            foreach (int i in values)
            {
                if (i > max) max = i;
            }
            return max;
        }

        public static int CalculateMin(List<int> values)
        {
            var min = values[0];
            foreach (int i in values)
            {
                if (i < min) min = i;
            }
            return min;
        }
    }
}