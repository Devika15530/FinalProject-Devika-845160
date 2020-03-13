using Emart.SellerService.Repository;
using Emart.SellerService.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Emart.Test
{
    [TestFixture]
    class TestSellerService
    {


        SellerRepository _srepo;
        ItemRepository _irepo;
        [SetUp]
        public void SetUp()
        {
            _srepo = new SellerRepository(new EmartDBContext());
            _irepo = new ItemRepository(new EmartDBContext());
        }


        [Test]
        [Description("Test EditProfile()")]
        public void TestEditProfile()
        {
            _srepo.EditProfile(new Seller()
            {
                SellerId = "5",
                UserName = "Navi",
                EmailId = "nav@14",
                Password = "123456",
                MobileNo = "9912897856",
                CompanyName = "Cts",
                Gstin = "abckd",
                BriefDetails = "ntng",
                PostalAddress = "chennai",
                Website = "cts.com"
            }


           );
            var result = _srepo.GetProfile("5");

            Assert.IsNotNull(result);
        }

        [Test]
        [Description("Test AddItem()")]
        public void TestAddItem()
        {
            _irepo.AddItem(new Items()
            {
                SellerId = "1",
                ItemId = "I6618",
                CategoryId = "6",
                SubcategoryId = "1",
                Price = "9000",
                ItemName = "Camera",
                Image = "electronic5",
                Description = "HD Quality",
                StockNumber = "600",
                Remarks = "Good"
            }
           );
            var result = _irepo.GetItem("I6618");

            Assert.IsNotNull(result);
        }

        [Test]
        [Description("Test ViewItems()")]
        public void TestViewItems()
        {

            var result = _irepo.ViewItems();

            Assert.IsNotNull(result);
        }


        [Test]
        [Description("Test DeleteItem()")]
        public void TestDeleteItem()
        {

            _irepo.DeleteItem("I6611");
            var result = _irepo.GetItem("I6611");
            Assert.IsNull(result);
        }


        [Test]
        [Description("Test UpdateItem()")]
        public void TestUpdateItem()
        {
            _irepo.UpdateItem(new Items()
            {
                SellerId = "2",
                ItemId = "I611",
                CategoryId = "c14",
                SubcategoryId = "SC64",
                Price = "8000",
                ItemName = "Camera",
                Image = "electronic88",
                Description = "HD Quality",
                StockNumber = "700",
                Remarks = "Good"
            }
           );
            var result = _irepo.GetItem("I611");

            Assert.IsNotNull(result);
        }

        [Test]
        [Description("Test GetCategories()")]
        public void TestGetCategories()
        {
            var result = _irepo.GetCategories();
            Assert.IsNotNull(result);
        }


        [Test]
        [Description("Test GetSubCategories()")]
        public void TestGetSubCategories()
        {
            var result = _irepo.GetSubCategories("SC38");
            Assert.IsNotNull(result);
        }


    }
}
