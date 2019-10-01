using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace Stack_Tests
{   
    [TestFixture]
    public class StackTests
    {
        [Test]
        public void Creation()
        {
            Stack<int> s = new Stack<int>(3);
            Assert.AreEqual(0, s.Count);
        }

        [Test]
        public void Push_Pop()
        {
            Stack<int> s = new Stack<int>(3);
            s.Push(1);
            s.Push(2);
            s.Push(3);
            int value = s.Pop();

            Assert.AreEqual(3, value);
            Assert.AreEqual(2, s.Count);
        }
    }
}
