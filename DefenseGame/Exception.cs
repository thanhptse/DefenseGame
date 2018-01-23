using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefenseGame
{
    class DefenseGameException : Exception
    {
        public DefenseGameException()
        {

        }

        public DefenseGameException(string message) : base(message)
        {

        }
    }

    class OutOfBoundException : DefenseGameException
    {
        public OutOfBoundException()
        {

        }

        public OutOfBoundException(string message) : base(message)
        {

        }
    }
}
