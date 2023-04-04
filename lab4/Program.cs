namespace lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Console.Write("Enter task to run: ");
            try
            {
                choice = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error collapsed: {ex.Message}");
                return;
            }
            switch(choice)
            {
                case 1:
                    Task1.Run();
                    break;
            }
        }
    }
}