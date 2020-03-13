using Emart.AccountService.Models;
using Emart.AccountService.Repository;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Emart.Test
{
    [TestFixture]
    class TestAccountService
    {
        AccountRepository _acrepo;
        [SetUp]
        public void SetUp()
        {
            _acrepo = new AccountRepository(new EmartDBContext());

        }


        [Test]
        [Description("TestBuyerLogin()")]
        public void TestBuyerLogin()
        {
            var result = _acrepo.BuyerLogin("Devika", "1234");
            Assert.IsNotNull(result);
        }


        [Test]
        [Description("TestSellerLogin()")]
        public void TestSellerLogin()
        {
            var result = _acrepo.SellerLogin("jaggu", "1234");
            Assert.IsNotNull(result);
        }


        [Test]
        [Description("TestBuyerRegister()")]
        public void TestBuyerRegister()
        {
            _acrepo.BuyerRegister(new Buyer()
            {

                BuyerId = "7",
                UserName = "Johny",
                EmailId = "Johny@14",
                Password = "Johny456",
                MobileNo = "9956844856",
                CreatedDateTime = DateTime.Now
            });
            var result = _acrepo.BuyerLogin("Johny", "Johny456");
            Assert.IsNotNull(result);

        }






        [Test]
        [Description("TestSellerRegister()")]
        public void TestSellerRegister()
        {
            _acrepo.SellerRegister(new Seller()
            {

                SellerId = "7",
                UserName = "Johny",
                EmailId = "Johny@14",
                Password = "Johny456",
                MobileNo = "9956987856",
                CompanyName = "tcs",
                Gstin = "3756",
                BriefDetails = "john",
                PostalAddress = "chennai",
                Website = "www.tcs.com"
            });
            var result = _acrepo.SellerLogin("John", "John456");
            Assert.IsNotNull(result);

        }
    }

}
