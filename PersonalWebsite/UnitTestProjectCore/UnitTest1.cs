using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParcelModel;
using ParcelModel.Parcel;

namespace UnitTestProjectCore
{
    [TestClass]
    public class UnitTest1
    {
        private IParcelService _parcelService;

        [TestInitialize]
        public void Init()
        {
            _parcelService = new ParcelService();

        }

        [TestMethod]
        public void MoreThan25Kg_WontFindParcel()
        {
            var input = new InputParcel()
            {
                Length = 1,
                Breadth = 1,
                Height = 1,
                Weight = 26
            };

            var packageType = _parcelService.Identify(input);

            Assert.IsNull(packageType);

        }


        [TestMethod]
        public void LessThan25kgAndCorrectValues_WillFindPackage()
        {
            var input = new InputParcel()
            {
                Length = 1,
                Breadth = 1,
                Height = 1,
                Weight = 1
            };

            var packageType = _parcelService.Identify(input);

            Assert.IsNotNull(packageType);
        }

        [TestMethod]
        public void TooBigLength_WontFindPackage()
        {
            var input = new InputParcel()
            {
                Length = 900,
                Breadth = 1,
                Height = 1,
                Weight = 1
            };

            var packageType = _parcelService.Identify(input);

            Assert.IsNull(packageType);
        }

        [TestMethod]
        public void TooBigBreadth_WontFindPackage()
        {
            var input = new InputParcel()
            {
                Length = 1,
                Breadth = 900,
                Height = 1,
                Weight = 1
            };

            var packageType = _parcelService.Identify(input);

            Assert.IsNull(packageType);
        }

        [TestMethod]
        public void TooBigHeight_WontFindPackage()
        {
            var input = new InputParcel()
            {
                Length = 1,
                Breadth = 1,
                Height = 900,
                Weight = 1
            };

            var packageType = _parcelService.Identify(input);

            Assert.IsNull(packageType);
        }

        [TestMethod]
        public void FindSmallPackage()
        {
            var input = new InputParcel()
            {
                Length = 200,
                Breadth = 300,
                Height = 150,
                Weight = 25
            };

            var packageType = _parcelService.Identify(input);

            Assert.AreEqual<Enum>(packageType.Type,ParcelType.Small);
            Assert.AreEqual<decimal>(packageType.Cost, Constants.SMALL_COST);
        }

        [TestMethod]
        public void FindMediumPackage()
        {
            var input = new InputParcel()
            {
                Length = 300,
                Breadth = 400,
                Height = 200,
                Weight = 25
            };

            var packageType = _parcelService.Identify(input);

            Assert.AreEqual<Enum>(packageType.Type, ParcelType.Medium);
            Assert.AreEqual<decimal>(packageType.Cost, Constants.MEDIUM_COST);
        }


        [TestMethod]
        public void FindLargePackage()
        {
            var input = new InputParcel()
            {
                Length = 400,
                Breadth = 600,
                Height = 250,
                Weight = 25
            };

            var packageType = _parcelService.Identify(input);

            Assert.AreEqual<Enum>(packageType.Type, ParcelType.Large);
            Assert.AreEqual<decimal>(packageType.Cost, Constants.LARGE_COST);
        }

    }
}
