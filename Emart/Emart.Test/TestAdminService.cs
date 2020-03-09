using Emart.AdminService.Models;
using Emart.AdminService.Repository;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Emart.Test
{
    [TestFixture]
    class TestAdminService
    {
        AdminRepository _amrepo;
        [SetUp]
        public void SetUp()
        {
            _amrepo = new AdminRepository(new EmartDBContext());

        }
        //[Test]
        //[Description("TestAddCategory()")]
        //public void TestAddCategory()
        //{
        //    _amrepo.AddCategory(new Category()
        //    {
        //        CategoryId = "c123",
        //        CategoryName = "Bottle",
        //        BriefDetails = "U can drink"

        //    }
        //        );


        //    var result = _amrepo.GetCatById("c123");
        //    Assert.IsNotNull(result);
        //}


        //[Test]
        //[Description("TestAddSubCategory()")]
        //public void TestAddSubCategory()
        //{
        //    _amrepo.AddSubCategories(new SubCategory()
        //    {

        //        SubcategoryId = "Sc123",
        //        SubcategoryName = "Lepakshi",
        //        CategoryId = "c123",
        //        BriefDetails = "Books",
        //        Gst = "abcde"
        //    }
        //        );


        //    var result = _amrepo.GetSubCatById("Sc123");
        //    Assert.IsNotNull(result);
        //}




        //[Test]
        //[Description("TestEditCategory")]
        //public void TestEditCategory()
        //{
        //    _amrepo.EditCategories(new Category()
        //    {

        //        CategoryId = "c123",
        //        CategoryName = "Bottles",
        //        BriefDetails = "U can drink"

        //    });

        //    var result = _amrepo.GetCatById("c123");
        //    Assert.IsNotNull(result);
        //}






        //[Test]
        //[Description("TestEditSubCategory")]
        //public void TestEditSubCategory()
        //{
        //    _amrepo.EditSubCategories(new SubCategory()
        //    {
        //        SubcategoryId = "Sc123",
        //        SubcategoryName = "Kinely",
        //        CategoryId = "c123",
        //        BriefDetails = "water",
        //        Gst = "abcde"

        //    });

        //    var result = _amrepo.GetSubCatById("Sc123");
        //    Assert.IsNotNull(result);
        //}







        //[Test]
        //[Description("TestGetAllCategories()")]
        //public void TestGetAllCategories()
        //{
        //    var result = _amrepo.GetCategories();
        //    Assert.IsNotNull(result);
        //    Assert.Greater(result.Count, 2);

        //}



        //[Test]
        //[Description("TestGetAllSubCategories()")]
        //public void TestGetAllSubCategories()
        //{
        //    var result = _amrepo.ViewSubCategories();
        //    Assert.IsNotNull(result);
        //    Assert.Greater(result.Count, 2);

        //}





        //[Test]
        //[Description("TestDeleteSubCategory()")]
        //public void TestDeleteSubCategory()
        //{
        //    _amrepo.DeleteSubCategories("Sc123");
        //    var result = _amrepo.GetSubCatById("Sc123");
        //    Assert.IsNull(result);

        //}

        //[Test]
        //[Description("TestDeleteCategory()")]
        //public void TestDeleteCategory()
        //{
        //    _amrepo.DeleteCategories("c123");
        //    var result = _amrepo.GetCatById("c123");
        //    Assert.IsNull(result);

        //}





    }


    }

