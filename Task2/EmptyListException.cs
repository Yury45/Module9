using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class EmptyListException : NullReferenceException
    {
        public override string Message
        {
            get
            {
                return $"Указанный список не содержит элементов!";
            }
        }
    }
}
