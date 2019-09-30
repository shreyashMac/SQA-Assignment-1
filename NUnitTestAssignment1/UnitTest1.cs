using Assignment_1SQA;
using NUnit.Framework;



namespace NUnitTestAssignment1
{
    public class Tests
    {
       

        [SetUp]
        public void Setup()
        {
        }

        

        [Test]
        public void Test1()
        {

            Assert.AreEqual("These Sides can form triangle ", TriangleSolver.analyze(7,10,5));
        }

        public void Test2()
        {

            Assert.AreEqual("kk", TriangleSolver.analyze(7, 10, 10));
        }

        public void Test3()
        {

            Assert.AreEqual("These Sides can form triangle", TriangleSolver.analyze(7, 10, 5));
        }

        public void Test4()
        {

            Assert.AreEqual("These Sides can form triangle", TriangleSolver.analyze(7, 10, 5));
        }

        public void Test5()
        {

            Assert.AreEqual("These Sides can form triangle", TriangleSolver.analyze(7, 10, 5));
        }

        public void Test6()
        {

            Assert.AreEqual("These Sides can form triangle", TriangleSolver.analyze(7, 10, 5));
        }

        public void Test7()
        {

            Assert.AreEqual("These Sides can form triangle", TriangleSolver.analyze(7, 10, 5));
        }

        public void Test8()
        {

            Assert.AreEqual("These Sides can form triangle", TriangleSolver.analyze(7, 10, 5));
        }
    }
}