using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kolos_41K8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolos_41K8.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void RozwiazanieTest()
        {
            int[] tab = { -3, 1, 2, -2, 5, 6 };
            int test = Program.Rozwiazanie(tab);
            int poprawne = 60;
            Assert.AreEqual(test, poprawne);
        }
    }
}