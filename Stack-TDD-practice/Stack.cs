using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_TDD_practice
{
    public class Stack<T>
    {
        #region Members
        private T[] stackArray;
        private int maxLength;
        #endregion

        #region Properties
        public int Size { get; private set; }
        #endregion

        #region Constructor
        public Stack(int length)
        {
            maxLength = length;
            stackArray = new T[length];
        }
        #endregion
    }
}
