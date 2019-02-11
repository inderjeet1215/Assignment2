using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;
using NUnit.Framework;

namespace Assignment2_Test
{

    public class Assignment2_Test
    {
        [TestFixture]
        public class Prog8170_Assignment2_Tests
        {
            [Test]
            //TestCase 1
            ///first test case i am inputting sideA=2,sideB=3 and sideC=700.
            ///so this is not a triangle because side3 has value 600 so a triangle does not have too high value on one side only.
            public void Analyze_Triangle_Input_2_3_700_ExpectedOutput_NotTriangle()
            {
                // Arrange
                int a = 2;
                int b = 3;
                int c = 700;

                // Act
                string result = Trianglesolver.Analyze(a, b, c);

                //Assert
                Assert.AreEqual("This is not a Triangle", result);
            }
            [Test]
            //TestCase 2
            ///sideA=3,sideB=3,sideC=3 so it is equilateral triangle.
            public void Analyze_Triangle_Input_3_3_3_ExpectedOutput_Equilateral()
            {
                // Arrange
                int a = 3;
                int b = 3;
                int c = 3;

                // Act
                string result = Trianglesolver.Analyze(a, b, c);

                //Assert
                Assert.AreEqual("Triangle is Equilateral", result);
            }
            [Test]
            //TestCase3
            ///sideA=2,sideB=2 and sideC=4 it so, this is Isosceles triangle.
            public void Analyze_Triangle_Input_4_4_4_ExpectedOutput_Isosceles()
            {
                // Arrange
                int a = 4;
                int b = 4;
                int c = 4;

                // Act
                string result = Trianglesolver.Analyze(a, b, c);

                //Assert
                Assert.AreEqual("Triangle is Equilateral", result);
            }
            [Test]
            //TestCase4
            ///all the values are different from each other so it is under scalene triangle.
            public void Analyze_Triangle_Input_2_6_5_ExpectedOutput_Scalene()
            {
                // Arrange
                int a = 2;
                int b = 6;
                int c = 5;

                // Act
                string result = Trianglesolver.Analyze(a, b, c);

                //Assert
                Assert.AreEqual("Triangle is Scalene", result);
            }
            [Test]
            //TestCase5
            ///all the values are different and this is also scalene triangle.
            public void Analyze_Triangle_Input_5_7_3_ExpectedOutput_Scalene()
            {
                // Arrange
                int a = 5;
                int b = 7;
                int c = 3;

                // Act
                string result = Trianglesolver.Analyze(a, b, c);

                //Assert
                Assert.AreEqual("Triangle is Scalene", result);
            }
            [Test]
            //TestCase6
            ///all values are zero this will not form an triangle.
            public void Analyze_Triangle_Input_0_0_0_ExpectedOutput_NotTriangle()
            {
                // Arrange
                int a = 0;
                int b = 0;
                int c = 0;

                // Act
                string result = Trianglesolver.Analyze(a, b, c);

                //Assert
                Assert.AreEqual("This is not a Triangle", result);
            }
            [Test]
            //TestCase7

            ///This is not a triangle because two sides are zero.
            public void Analyze_Triangle_Input_0_7_0_ExpectedOutput_NotTriangle()
            {
                // Arrange
                int a = 0;
                int b = 7;
                int c = 0;

                // Act
                string result = Trianglesolver.Analyze(a, b, c);

                //Assert
                Assert.AreEqual("This is not a Triangle", result);
            }
            [Test]
            //TestCase8
            ///This is equailateral triangle all the values are same.
            public void Analyze_Triangle_Input_6_6_6_ExpectedOutput_Equilateral()
            {
                // Arrange
                int a = 6;
                int b = 6;
                int c = 6;

                // Act
                string result = Trianglesolver.Analyze(a, b, c);

                //Assert
                Assert.AreEqual("Triangle is Equilateral", result);
            }

        }
    }



}

