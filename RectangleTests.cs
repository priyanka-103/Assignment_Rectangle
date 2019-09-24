using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Assignment1;

namespace RectangleTests
{
    [TestFixture]
    public class RectangleTests
    {
        //Adition
        [Test]
        public void GetLength26()
        {

            //Arrange
            int length = 26;
            Rectangle rt = new Rectangle(length, 1);
            int expectedResult = length;

            //Act
            int actualResult = rt.GetLength();

            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void SetLength89()
        {

            //Arrange
            int length = 89;
            Rectangle rt = new Rectangle();
            int expectedResult = length;

            //Act
            int actualResult = rt.SetLength(length);

            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetWidth53()
        {

            //Arrange
            int width = 53;
            Rectangle rt = new Rectangle(1, width);
            int expectedResult = width;

            //Act
            int actualResult = rt.GetWidth();

            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void SetWidth44()
        {

            //Arrange
            int width = 44;
            Rectangle rt = new Rectangle();
            int expectedResult = width;

            //Act
            int actualResult = rt.SetWidth(width);

            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetPerimeter_Length13_Width40()
        {

            //Arrange
            int length = 13;
            int width = 40;
            Rectangle rt = new Rectangle(length, width);
            int expectedResult =2*(13+40);

            //Act
            int actualResult = rt.GetPerimeter();

            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetArea_Length17_Width20()
        {

            //Arrange
            int length = 17;
            int width = 20;
            Rectangle rt = new Rectangle(length, width);
            int expectedResult = (17*20);

            //Act
            int actualResult = rt.GetArea();

            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}
