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
        }
    }
}