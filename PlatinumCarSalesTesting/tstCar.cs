using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;

namespace PlatinumCarSalesTesting
{
    [TestClass]
    public class tstCar
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create instance of the class we want to create
            clsCar ACar = new clsCar();

            //test to see it exists
            Assert.IsNotNull(ACar);
        }

        [TestMethod]
        public void CarSoldOK()
        {
            //create instance of the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assign property
            Boolean TestData = true;
            //assign data to property
            ACar.Sold = TestData;
            //test to see two values same
            Assert.AreEqual(ACar.Sold, TestData);

        }



        [TestMethod]
        public void Car_NoOK()
        {
            //create instance of the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assign property
            Int32 TestData = 1;
            //assign data to property
            ACar.Car_No = TestData;
            //test to see two values same
            Assert.AreEqual(ACar.Car_No, TestData);

        }

        [TestMethod]
        public void Car_RegOK()
        {
            //create instance of the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assign property
            string TestData = "AB58ABC";
            //assign data to property
            ACar.Car_Reg = TestData;
            //test to see two values same
            Assert.AreEqual(ACar.Car_Reg, TestData);

        }


        [TestMethod]
        public void ColourOK()
        {
            //create instance of the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assign property
            string TestData = "Blue";
            //assign data to property
            ACar.Colour = TestData;
            //test to see two values same
            Assert.AreEqual(ACar.Colour, TestData);

        }


        [TestMethod]
        public void ConditionOK()
        {
            //create instance of the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assign property
            string TestData = "VG";
            //assign data to property
            ACar.Condition = TestData;
            //test to see two values same
            Assert.AreEqual(ACar.Condition, TestData);

        }

        [TestMethod]
        public void DateBoughtOK()
        {
            //create instance of the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assign property
            DateTime TestData = DateTime.Now.Date;
            //assign data to property
            ACar.DateBought = TestData;
            //test to see two values same
            Assert.AreEqual(ACar.DateBought, TestData);

        }

        [TestMethod]
        public void MakeOK()
        {
            //create instance of the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assign property
            string TestData = "Mercedes";
            //assign data to property
            ACar.Make = TestData;
            //test to see two values same
            Assert.AreEqual(ACar.Make, TestData);

        }

        [TestMethod]
        public void ModelOK()
        {
            //create instance of the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assign property
            string TestData = "AClass";
            //assign data to property
            ACar.Model = TestData;
            //test to see two values same
            Assert.AreEqual(ACar.Model, TestData);

        }

        [TestMethod]
        public void NoOfSeatsOK()
        {
            //create instance of the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assign property
            string TestData = "5";
            //assign data to property
            ACar.NoOfSeats = TestData;
            //test to see two values same
            Assert.AreEqual(ACar.NoOfSeats, TestData);

        }

        [TestMethod]
        public void RatingOK()
        {
            //create instance of the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assign property
            string TestData = "3";
            //assign data to property
            ACar.Rating = TestData;
            //test to see two values same
            Assert.AreEqual(ACar.Rating, TestData);

        }

        [TestMethod]
        public void YearOK()
        {
            //create instance of the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assign property
            string TestData = "2007";
            //assign data to property
            ACar.Year = TestData;
            //test to see two values same
            Assert.AreEqual(ACar.Year, TestData);

        }

        [TestMethod]
        public void SafetyFeaturesOK()/// needs to be changed
        {
            //create instance of the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assign property
            string TestData = "";
            //assign data to property
            ACar.SafetyFeatures = TestData;
            //test to see two values same
            Assert.AreEqual(ACar.SafetyFeatures, TestData);

        }

        ///// methods

        [TestMethod]
        public void ValidMethodOK()/// not finished
        {
            //create instance of the class we want to create
            clsCar ACar = new clsCar();
            
        }

    }

}

