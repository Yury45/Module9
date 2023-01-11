using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class DBLastnames
    {
        private List<string> lastnames;

        internal List<string> Lastnames
        {
            get
            {
                return lastnames;
            }
            private set
            {
                try
                {
                    if (value.Count == 0) throw new EmptyListException();
                    else lastnames = value;
                    Console.WriteLine("База данных фамилий установлена.");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ошибка при инициализации базы данных: ");
                    Console.WriteLine(e.Message);
                }
            }
        }

        internal void Add(List<string> list)
        {
            try
            {
                if (list.Count != 0)
                {
                    Lastnames.AddRange(list);
                }
            }
            catch (EmptyListException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        internal List<string> Set(List<string> list)
        {
            return Lastnames = list;
        }
    }
}
