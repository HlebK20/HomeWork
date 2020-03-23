using Microsoft.VisualStudio.TestTools.UnitTesting;
using task_DEV_3;
using System;
using System.Collections.Generic;
using System.Text;

namespace task_DEV_3.AutoparkTests
{
    [TestClass()]
    public class EngineTests
    {
        [ExpectedException(typeof(FormatException))]
        [DataRow(5, 5, "Some Type", "ENG001")]
        [DataRow(5, 5, "SomeType", "ENG 001")]
        [TestMethod()]
        public void EngineWrongStringFormatTest(double power, double volume, string typeOfEngine, string serialNumber)
        {
            Engine engine = new Engine(power, volume, typeOfEngine, serialNumber);
        }
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [DataRow(-1, 0, "SomeType", "ENG001")]
        [DataRow(0, -1, "SomeType", "ENG001")]
        [TestMethod()]
        public void EngineArgumentOutOfRangeTest(double power, double volume, string typeOfEngine, string serialNumber)
        {
            Engine engine = new Engine(power, volume, typeOfEngine, serialNumber);
        }
        [ExpectedException(typeof(ArgumentNullException))]
        [DataRow(5, 5, null, "ENG001")]
        [DataRow(5, 5, "SomeType", null)]
        [TestMethod()]
        public void EngineNullArgumentTest(double power, double volume, string typeOfEngine, string serialNumber)
        {
            Engine engine = new Engine(power, volume, typeOfEngine, serialNumber);
        }
    }
    [TestClass()]
    public class ChassisTests
    {
        [ExpectedException(typeof(FormatException))]
        [DataRow(1, "Some Type", 50)]
        [TestMethod()]
        public void ChassisWrongStringFormatTest(int numberOfWheels, string serialNumber, double permissibleLoad)
        {
            Chassis chassis = new Chassis(numberOfWheels ,serialNumber, permissibleLoad);
        }
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [DataRow(0, "SomeType", 50)]
        [DataRow(1, "SomeType", -1)]
        [TestMethod()]
        public void ChassisArgumentOutOfRangeTest(int numberOfWheels, string serialNumber, double permissibleLoad)
        {
            Chassis chassis = new Chassis(numberOfWheels, serialNumber, permissibleLoad);
        }
        [ExpectedException(typeof(ArgumentNullException))]
        [DataRow(1, null, 50)]
        [TestMethod()]
        public void ChassisArgumentNullTest(int numberOfWheels, string serialNumber, double permissibleLoad)
        {
            Chassis chassis = new Chassis(numberOfWheels, serialNumber, permissibleLoad);
        }
    }
    [TestClass()]
    public class TransmissionTests
    {
        [ExpectedException(typeof(FormatException))]
        [DataRow("Some Type", "SomeVendor", 5)]
        [DataRow("SomeType", "Some Vendor", 5)]
        [TestMethod()]
        public void TransmissionWrongStringFormatTest(string typeOfTransmission, string vendor, int numberOfGears)
        {
            Transmission transmission = new Transmission(typeOfTransmission, vendor, numberOfGears);
        }
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [DataRow("SomeType", "SomeVendor", 0)]
        [TestMethod()]
        public void TransmissionArgumentOutOfRangeTest(string typeOfTransmission, string vendor, int numberOfGears)
        {
            Transmission transmission = new Transmission(typeOfTransmission, vendor, numberOfGears);
        }
        [ExpectedException(typeof(ArgumentNullException))]
        [DataRow(null, "SomeVendor",5)]
        [DataRow("SomeType", null , 5)]
        [TestMethod()]
        public void TransmissionNullArgumentTest(string typeOfTransmission, string vendor, int numberOfGears)
        {
            Transmission transmission = new Transmission(typeOfTransmission, vendor, numberOfGears);
        }
    }
    [TestClass()]
    public class BusTest
    {

    }
    [TestClass()]
    public class CarTest
    {

    }
    [TestClass()]
    public class ScooterTest
    {

    }
    [TestClass()]
    public class TruckTest
    {

    }
}