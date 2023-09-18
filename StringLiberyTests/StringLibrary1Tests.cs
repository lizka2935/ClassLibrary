using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using StringLibrary1;

namespace StringLiberyTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckName_Pustota_ReturnedFalse()
        {
            //Arrange
            string Name = "";
            //Act
            StringLibery obj = new StringLibery();
            bool res = obj.CheckName(Name);
            //Assert
            Assert.IsFalse(res );
        }
        [TestMethod]
        public void CheckName_Norm_ReturnedTrue()
        {
            //Arrange
            string Name = "Зырянова";
            //Act
            StringLibery obj = new StringLibery();
            bool res = obj.CheckName(Name);
            //Assert
            Assert.IsTrue(res);
        }
        [TestMethod]
        public void CheckName_CherezTireSProbelom_ReturnedTrue()
        {
            //Arrange
            string Name = "Зыря-но ва";
            //Act
            StringLibery obj = new StringLibery();
            bool res = obj.CheckName(Name);
            //Assert
            Assert.IsTrue(res);
        }
        [TestMethod]
        public void CheckName_Bolishe50Znakov_ReturnedFalse()
        {
            //Arrange
            string Name = "орипмауоипоипокрапрпгкрапгуркапгркапгркагпркугарпкга";
            //Act
            StringLibery obj = new StringLibery();
            bool res = obj.CheckName(Name);
            //Assert
            Assert.IsFalse(res);
        }
        [TestMethod]
        public void CheckName_SimvolFu_ReturnedFalse()
        {
            //Arrange
            string Name = "Зырянова;";
            //Act
            StringLibery obj = new StringLibery();
            bool res = obj.CheckName(Name);
            //Assert
            Assert.IsFalse(res);
        }
        [TestMethod]
        public void CheckName_Probel_ReturnedFalse()
        {
            //Arrange
            string Name = " ";
            //Act
            StringLibery obj = new StringLibery();
            bool res = obj.CheckName(Name);
            //Assert
            Assert.IsFalse(res);
        }
        [TestMethod]
        public void CheckName_Tire_ReturnedFalse()
        {
            //Arrange
            string Name = "-";
            //Act
            StringLibery obj = new StringLibery();
            bool res = obj.CheckName(Name);
            //Assert
            Assert.IsFalse(res);
        }
        [TestMethod]
        public void CheckName_NormFIO_ReturnedTrue()
        {
            //Arrange
            string Name = "Зырянова Елизавета Яковлевна";
            //Act
            StringLibery obj = new StringLibery();
            bool res = obj.CheckName(Name);
            //Assert
            Assert.IsTrue(res);
        }
    }
}
