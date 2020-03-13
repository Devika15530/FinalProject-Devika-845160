using Emart.BuyerService.Models;
using Emart.BuyerService.repositories;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Emart.Test
{
    [TestFixture]
    class TestBuyerService
    {
        BuyerRepository _buyrepo;
        [SetUp]
        public void SetUp()
        {
            _buyrepo = new BuyerRepository(new EmartDBContext());

        }



        [Test]
        [Description("TestSearchItem()")]
        public void TestSearchItem()
        {

            var result = _buyrepo.SearchItems("samsungnasbvrg");

            Assert.IsNotNull(result);

        }



        [Test]
        [Description("TestBuyItem()")]

        public void TestBuyItem()
        {
            _buyrepo.BuyItem(new Transactionhistory()
            {
           
                BuyerId = "1",
                SellerId = "1",
                TransactionId = "456",
                ItemId = "I660",
                NumberOfItems = "2",
                DateTime = DateTime.Now,
              
                TransactionType = "Credit Card"
            }
         );
            var result = _buyrepo.TransactionHistory("1");

            Assert.IsNotNull(result);
        }

        [Test]
        [Description("TestEditProfile")]

        public void TestEditProfile()

        {
            _buyrepo.EditProfile(new Buyer()
            {

                BuyerId = "4",
                UserName = "Navya",
                EmailId = "navya@1441",
                Password = "123456",
                MobileNo = "9912897856",
                CreatedDateTime = DateTime.Now

            });

            var result = _buyrepo.GetProfile("4");

            Assert.IsNotNull(result);
        }



        [Test]
        [Description("Test GetCategories()")]
        public void TestGetCategories()
        {
            var result = _buyrepo.GetCategory();
            Assert.IsNotNull(result);
        }




        [Test]
        [Description("Test GetSubCategories()")]
        public void TestGetSubCategories()
        {
            var result = _buyrepo.SubCategory("1");
            Assert.IsNotNull(result);
        }


        [Test]
        [Description("Test AddtoCart()")]
        public void TestAddtoCart()
        {
            _buyrepo.Addtocart(new Cart()
            {
                CartId = "CT2",
                CategoryId = "6",
                SubcategoryId = "1",
                SellerId = "1",
                ItemId = "I660",
                Itemname = "samsung",
                Price = "11",
                Description = "good",
              
                Image = "samsung a30.jpg"
            });

            var result = _buyrepo.ViewCart("1");
            Assert.IsNotNull(result);
        }
        [Test]
        [Description("Test Deletefromcart()")]
        public void TestDeletefromcart()
        {
            _buyrepo.Deletefromcart("CT2");
            var result = _buyrepo.ViewCart("1");

            Assert.IsNotNull(result);
        }

    }
}

