using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class SelectException : Exception
    {
        public override string Message
        {
            get
            {
                return $"Введенное значение отлично от 1 или 2";
            }
        }
        
    }
}
