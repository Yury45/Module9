using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal delegate void Notify();
    internal class DataHandler
    {
        public event Notify? OnProcessGoodEnd;
        public event Notify? OnProcessBadEnd;

        public void StartProcessSorting(bool flag, List<string> list)
        {
            Console.WriteLine("Начат процесс сортировки...");
            ToSort(flag, list);
        }

        private void ToSort(bool flag, List<string> list)
        {
            try
            {
                if (list == null) throw new EmptyListException();
                else
                {
                    Console.WriteLine("\nСписок до сортировки:");
                    foreach (var item in list)
                    {
                        Console.WriteLine(item);
                    }

                    list.Sort();
                    if (flag) list.Reverse();

                    Console.WriteLine("\nСписок после сортироки:");
                    foreach (var item in list)
                    {
                        Console.WriteLine(item);
                    }

                    OnProcessSortingGoodEnd();
                }
            }
            catch(EmptyListException e)
            {
                OnProcessSortingBadEnd();
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                OnProcessSortingBadEnd();
                Console.WriteLine(e.Message);
            }
        }

        private void OnProcessSortingGoodEnd()
        {
            OnProcessGoodEnd?.Invoke();
        }

        private void OnProcessSortingBadEnd()
        {
            OnProcessBadEnd?.Invoke();
        }
    }
}
