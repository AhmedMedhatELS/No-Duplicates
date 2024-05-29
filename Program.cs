namespace NoDuplicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a list of integers seperated by spaces :");
            string[] s = Console.ReadLine().Split(" ");
            List<int> ints = new List<int>();
            try
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (ints.Contains(int.Parse(s[i])))
                        throw new Exception($"{s[i]} is aready in List\t No Duplicates Allowed");
                    ints.Add(int.Parse(s[i]));
                }
            }
            catch(Exception e) 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.ToString());
                Console.ForegroundColor= ConsoleColor.White;
            }
            Console.WriteLine("No Duplicates Found");
        }
    }
}
