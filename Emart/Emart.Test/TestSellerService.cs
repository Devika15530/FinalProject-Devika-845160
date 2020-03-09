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


        //[Test]
        //[Description("Test EditProfile()")]
        //public void TestEditProfile()
        //{
        //    _srepo.EditProfile(new Seller()
        //    {
        //        SellerId = "5",
        //        UserName = "Navya",
        //        EmailId = "nav@14",
        //        Password = "123456",
        //        MobileNo = "9912897856",
        //        CompanyName = "Cts",
        //        Gstin = "abckd",
        //        BriefDetails = "ntng",
        //        PostalAddress = "chennai",
        //        Website = "cts.com"
        //    }


        //   );
        //    var result = _srepo.GetProfile("5");

        //    Assert.IsNotNull(result);
        //}

        [Test]
        [Description("Test AddItem()")]
        public void TestAddItem()
        {
            _irepo.AddItem(new Items()
            {
                SellerId = "1",
                ItemId = "I6611",
                CategoryId = "6",
                SubcategoryId = "1",
                Price = "9000",
                ItemName = "Cameras",
                Image = "electronic7",
                Description = "HD Quality",
                StockNumber = "60",
                Remarks = "Good"
            }
           );
            var result = _irepo.GetItem("I074");

            Assert.IsNotNull(result);
        }

        //[Test]
        //[Description("Test ViewItems()")]
        //public void TestViewItems()
        //{

        //    var result = _irepo.ViewItems();

        //    Assert.IsNotNull(result);
        //}


        //[Test]
        //[Description("Test DeleteItem()")]
        //public void TestDeleteItem()
        //{

        //    _irepo.DeleteItem("I853");
        //    var result = _irepo.GetItem("I853");
        //    Assert.IsNull(result);
        //}


        //[Test]
        //[Description("Test UpdateItem()")]
        //public void TestUpdateItem()
        //{
        //    _irepo.UpdateItem(new Items()
        //    {
        //        SellerId = "1",
        //        ItemId = "I074",
        //        CategoryId = "1",
        //        SubcategoryId = "SC38",
        //        Price = "800",
        //        ItemName = "Camera",
        //        Image = "electronic7",
        //        Description = "HD Quality",
        //        StockNumber = "70",
        //        Remarks = "Good"
        //    }
        //   );
        //    var result = _irepo.GetItem("I074");

        //    Assert.IsNotNull(result);
        //}

        //[Test]
        //[Description("Test GetCategories()")]
        //public void TestGetCategories()
        //{
        //    var result = _irepo.GetCategories();
        //    Assert.IsNotNull(result);
        //}


        //[Test]
        //[Description("Test GetSubCategories()")]
        //public void TestGetSubCategories()
        //{
        //    var result = _irepo.GetSubCategories("SC38");
        //    Assert.IsNotNull(result);
        //}


    }
}
