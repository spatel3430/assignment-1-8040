using NUnit.Framework;
//add the namespace of program class to Nunit class for unit testing.
using assign_2;
using Microsoft.VisualBasic.CompilerServices;

namespace testanalyze
{
    public class testingtheanalyze
    {
        [TestFixture]
        public class testingtheanalyze1
        {


            [Test]
            public void testing_input_10_10_10()
            {
                //enter the value for the testing 
                int sidea = 10;
                int sideb = 10;
                int sidec = 10;
                //expected output.
                string expected= "This is an equilateral triangle.";
                //actual output
                string actual = TriangleSolver.Analyze(sidea, sideb, sidec);

                //assert for checking actual and expected are same or not.
                Assert.AreEqual(expected,actual);
            }

            [Test]

            public void testing_input_10_10_20()
            {
                //enter the value for the testing 

                int sidea = 10;
                int sideb = 10;
                int sidec = 20;
                //expected output.

                string expected = "This is an isosceles triangle.";
                //actual output

                string actual = TriangleSolver.Analyze(sidea, sideb, sidec);

                //assert for checking actual and expected are same or not.

                Assert.AreEqual(expected, actual);
            }
            [Test]
            public void testing_input_20_10_20()
            {
                //enter the value for the testing 

                int sidea = 20;
                int sideb = 10;
                int sidec = 20;
                //expected output.

                string expected = "This is an isosceles triangle.";
                //actual output

                string actual = TriangleSolver.Analyze(sidea, sideb, sidec);

                //assert for checking actual and expected are same or not.

                Assert.AreEqual(expected, actual);
            }
            [Test]
            public void testing_input_10_20_20()
            {
                //enter the value for the testing 

                int sidea = 10;
                int sideb = 20;
                int sidec = 20;
                //expected output.

                string expected = "This is an isosceles triangle.";
                //actual output

                string actual = TriangleSolver.Analyze(sidea, sideb, sidec);
                //assert for checking actual and expected are same or not.


                Assert.AreEqual(expected, actual);
            }
            [Test]
            public void testing_input_10_20_30()
            {
                //enter the value for the testing 

                int sidea = 10;
                int sideb = 20;
                int sidec = 30;
                //expected output.

                string expected = "This is a scalene triangle.";
                //actual output

                string actual = TriangleSolver.Analyze(sidea, sideb, sidec);

                //assert for checking actual and expected are same or not.

                Assert.AreEqual(expected, actual);
            }
            [Test]
            public void testing_input_30_60_90()
            {
                //enter the value for the testing 

                int sidea = 30;
                int sideb = 60;
                int sidec = 90;
                //expected output.

                string expected = "This is a scalene triangle.";
                //actual output

                string actual = TriangleSolver.Analyze(sidea, sideb, sidec);

                //assert for checking actual and expected are same or not.

                Assert.AreEqual(expected, actual);
            }
            [Test]
            public void testing_input_0_0_0()
            {
                //enter the value for the testing 

                int sidea = 0;
                int sideb = 0;
                int sidec = 0;
                //expected output.

                string expected = "This is an equilateral triangle.";
                //actual output

                string actual = TriangleSolver.Analyze(sidea, sideb, sidec);

                //assert for checking actual and expected are same or not.

                Assert.AreEqual(expected, actual);
            }
            [Test]
            public void testing_input_999_999_999()
            {
                //enter the value for the testing 

                int sidea = 999;
                int sideb = 999;
                int sidec = 999;
                //expected output.

                string expected = "This is an equilateral triangle.";
                //actual output

                string actual = TriangleSolver.Analyze(sidea, sideb, sidec);
                //assert for checking actual and expected are same or not.


                Assert.AreEqual(expected, actual);
            }

        }
    }
}