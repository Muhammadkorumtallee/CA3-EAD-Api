using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Basketball_CA3_EAD.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Xunit_testing.Test
{
    [TestClass()]
    public class Player
    {
        [TestMethod()]
        public void teamname()
        {
           
            Team t = new Team();
            t.full_name = "Los Angeles Lakers";

            string result = "Los Angeles Lakers";

            Assert.AreEqual(t.full_name, result);
        }

        [TestMethod()]
        public void teamcity()
        {

            Team t = new Team();
            t.city = "Los Angeles";

            string result = "Los Angeles";

            Assert.AreEqual(t.city, result);
        }

        [TestMethod()]
        public void teamdivison()
        {

            Team t = new Team();
            t.division = "Pacific";

            string result = "Pacific";

            Assert.AreEqual(t.division, result);
        }
    }
}
