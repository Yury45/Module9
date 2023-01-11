namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Exception> exceptions = new List<Exception>();

            exceptions.Add(new ArgumentNullException());
            exceptions.Add(new ArgumentOutOfRangeException());
            exceptions.Add(new FormatException());
            exceptions.Add(new DirectoryNotFoundException());
            exceptions.Add(new SelectException());

            foreach (var exception in exceptions)
            {
                try
                {
                    throw exception;
                }
                catch (ArgumentNullException e)
                {
                    Console.WriteLine("Ошибка: " + e.Message);
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine("Ошибка: " + e.Message);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Ошибка: " + e.Message);
                }
                catch (DirectoryNotFoundException e)
                {
                    Console.WriteLine("Ошибка: " + e.Message);
                }
                catch (SelectException e)
                {
                    Console.WriteLine("Ошибка: " + e.Message);
                }
            }
        }
    }
}