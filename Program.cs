namespace Lab7_h_ListT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> computers = new List<string> { "Dell", "Gateway", "Apple", "HP", "Acer" };
            string[] compArr = new string[] { "Asus", "Sony", "Android" };
            computers.AddRange(compArr);


            computers.Sort();
            Console.WriteLine("--------Ascending---------");
            foreach (string c in computers)
            {
                Console.WriteLine(c);
            }

            computers.Remove("Android");

            computers.Reverse();
            Console.WriteLine("--------Descending---------");
            foreach (string c in computers)
            {
                Console.WriteLine(c);
            }

        }
    }
}
