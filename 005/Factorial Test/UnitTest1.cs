using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _005;

namespace Factorial_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestThatFactorialOf5Is120()
        {
            long result = _005.Program.CalculateFacorial(5);
            Assert.AreEqual(120, result);
        }

        [TestMethod]
        public void DrillA8()
        {
            string result = Program.DrillA(8);
            string expected =
                "#               \n" +
                "# #             \n" +
                "# # #           \n" +
                "# # # #         \n" +
                "# # # # #       \n" +
                "# # # # # #     \n" +
                "# # # # # # #   \n" +
                "# # # # # # # # \n";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void DrillB8()
        {
            string result = Program.DrillB(8);
            string expected =
                "# # # # # # # # \n" +
                "# # # # # # #   \n" +
                "# # # # # #     \n" +
                "# # # # #       \n" +
                "# # # #         \n" +
                "# # #           \n" +
                "# #             \n" +
                "#               \n";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void DrillC8()
        {
            string result = Program.DrillC(8);
            string expected =
                "# # # # # # # # \n" +
                "  # # # # # # # \n" +
                "    # # # # # # \n" +
                "      # # # # # \n" +
                "        # # # # \n" +
                "          # # # \n" +
                "            # # \n" +
                "              # \n";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void DrillD8()
        {
            string result = Program.DrillD(8);
            string expected =
                "              # \n" +
                "            # # \n" +
                "          # # # \n" +
                "        # # # # \n" +
                "      # # # # # \n" +
                "    # # # # # # \n" +
                "  # # # # # # # \n" +
                "# # # # # # # # \n";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void DrillE8()
        {
            string result = Program.DrillE(8);
            string expected =
                "# # # # # # # # \n" +
                "#             # \n" +
                "#             # \n" +
                "#             # \n" +
                "#             # \n" +
                "#             # \n" +
                "#             # \n" +
                "# # # # # # # # \n";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void DrillF8()
        {
            string result = Program.DrillF(8);
            string expected =
                "# # # # # # # # \n" +
                "  #             \n" +
                "    #           \n" +
                "      #         \n" +
                "        #       \n" +
                "          #     \n" +
                "            #   \n" +
                "# # # # # # # # \n";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void DrillG8()
        {
            string result = Program.DrillG(8);
            string expected =
                "# # # # # # # # \n" +
                "            #   \n" +
                "          #     \n" +
                "        #       \n" +
                "      #         \n" +
                "    #           \n" +
                "  #             \n" +
                "# # # # # # # # \n";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void DrillH7()
        {
            string result = Program.DrillH(7);
            string expected =
                "# # # # # # # \n" +
                "  #       #   \n" +
                "    #   #     \n" +
                "      #       \n" +
                "    #   #     \n" +
                "  #       #   \n" +
                "# # # # # # # \n";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void DrillI7()
        {
            string result = Program.DrillI(7);
            string expected =
                "# # # # # # # \n" +
                "# #       # # \n" +
                "#   #   #   # \n" +
                "#     #     # \n" +
                "#   #   #   # \n" +
                "# #       # # \n" +
                "# # # # # # # \n";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void DrillJ7()
        {
            string result = Program.DrillJ(7);
            string expected =
                "#      \n" +
                "##     \n" +
                "###    \n" +
                "####   \n" +
                "###    \n" +
                "##     \n" +
                "#      \n";
            Assert.AreEqual(expected, result);
        }
    }
}
