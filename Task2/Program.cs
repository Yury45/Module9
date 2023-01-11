using Task1;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DBLastnames DBLastnames = new DBLastnames();
            DataHandler dh = new DataHandler();
            dh.OnProcessBadEnd += OnBadEnd;
            dh.OnProcessGoodEnd += OnGoodEnd;   //Для плохой концовки достаточно закомментировать список фамилий

            DBLastnames.Set(new List<string>()
            {
                "Титова",
                "Буковски",
                "Бродский",
                "Арбенин",
                "Уэлш"
            });

            dh.StartProcessSorting(IsRevese(), DBLastnames.Lastnames);

            bool IsRevese()
            {
                Console.WriteLine("Введите параметр сортировки:\n1 - А-Я\n2 - Я-А");
                string? flag =  Console.ReadLine();

                if (flag == "1") return false;
                else if(flag == "2") return true;
                else
                {
                    try
                    {
                        throw new SelectException();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine("Введите значение параметра повторно!");

                    }
                    return IsRevese();
                }
            }

            void OnGoodEnd()
            {
                Console.WriteLine("Успех!");
            }

            void OnBadEnd()
            {
                Console.WriteLine("Неудача!");
            }
        }
    }
}