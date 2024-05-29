namespace ct_back
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? input = Console.ReadLine();
            int index = input.IndexOf(" ");

            int.TryParse(input.Substring(0, index), out int a);
            int.TryParse(input.Substring(index, input.Length - 1), out int b);

            Console.WriteLine(a + b);
        }
    }
}
