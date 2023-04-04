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
                case 2:
                    Task2.Run();
                    break;
                case 3:
                    Task3.Run();
                    break;
                case 4:
                    Task4.Run();
                    break;
            }
        }
    }
}