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
            var result = _acrepo.SellerLogin("jaggu", "jaga");
            Assert.IsNotNull(result);
        }


        //[Test]
        //[Description("TestBuyerRegister()")]
        //public void TestBuyerRegister()
        //{
        //    _acrepo.BuyerRegister(new Buyer()
        //    {

        //        BuyerId = "4",
        //        UserName = "Navya",
        //        EmailId = "nav@14",
        //        Password = "123456",
        //        MobileNo = "9912897856",
        //        CreatedDateTime = DateTime.Now
        //    });
        //    var result = _acrepo.BuyerLogin("Navya", "123456");
        //    Assert.IsNotNull(result);

        //}






        //[Test]
        //[Description("TestSellerRegister()")]
        //public void TestSellerRegister()
        //{
        //    _acrepo.SellerRegister(new Seller()
        //    {

        //        SellerId = "5",
        //        UserName = "Navya",
        //        EmailId = "nav@14",
        //        Password = "123456",
        //        MobileNo = "9912897856",
        //       CompanyName="Ctso",
        //       Gstin="abckd",
        //       BriefDetails="ntng",
        //       PostalAddress="chennai",
        //       Website="cts.com"
        //    });
        //    var result = _acrepo.SellerLogin("Navya", "123456");
        //    Assert.IsNotNull(result);

        //}
    }

}
