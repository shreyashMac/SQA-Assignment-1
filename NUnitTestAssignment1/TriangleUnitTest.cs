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

            Assert.AreEqual("Triangle Formed and Triangle is Scalene", TriangleSolver.analyze(7,10,5));
        }

        [Test]
        public void Test2()
        {

            Assert.AreEqual("Triangle Formed and Triangle is Isosceles", TriangleSolver.analyze(7, 10, 10));
        }

        [Test]
        public void Test3()
        {
            
            Assert.AreEqual("Triangle Formed and Triangle is Equilateral", TriangleSolver.analyze(30, 30, 30));
        }

        [Test]
        public void Test4()
        {

            Assert.AreEqual("Triangle Formed and Triangle is Scalene", TriangleSolver.analyze(5, 8, 3));
        }

        [Test]

        public void Test5()
        {

            Assert.AreEqual("Triangle Formed and Triangle is Equilateral", TriangleSolver.analyze(1, 1, 1));
        }

        [Test]

        public void Test6()
        {

            Assert.AreEqual("Triangle Formed and Triangle is Isosceles", TriangleSolver.analyze(15, 15, 10));
        }

        [Test]
        public void Test7()
        {

            Assert.AreEqual("Triangle Formed and Triangle is Scalene", TriangleSolver.analyze(65, 43, 33));
        }

        [Test]
        public void Test8()
        {

            Assert.AreEqual("Triangle Formed and Triangle is Isosceles", TriangleSolver.analyze(100,100,65));
        }
    }
}