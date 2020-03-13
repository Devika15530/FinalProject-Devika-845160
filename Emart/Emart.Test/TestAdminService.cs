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
        [Test]
        [Description("TestAddCategory()")]
        public void TestAddCategory()
        {
            _amrepo.AddCategory(new Category()
            {
                CategoryId = "c1443",
                CategoryName = "Boat",
                BriefDetails = "U"

            }
                );


            var result = _amrepo.GetCatById("c1243");
            Assert.IsNotNull(result);
        }


        [Test]
        [Description("TestAddSubCategory()")]
        public void TestAddSubCategory()
        {
            _amrepo.AddSubCategories(new SubCategory()
            {

                SubcategoryId = "Sc18",
                SubcategoryName = "manuuuu",
                CategoryId = "7",
                BriefDetails = "Bosse",
                Gst = "acbq"
            }
                );


            var result = _amrepo.GetSubCatById("Sc16");
            Assert.IsNotNull(result);
        }




        [Test]
        [Description("TestEditCategory")]
        public void TestEditCategory()
        {
            _amrepo.EditCategories(new Category()
            {

                CategoryId = "c1443",
                CategoryName = "Boats",
                BriefDetails = "U can drink"

            });

            var result = _amrepo.GetCatById("c1443");
            Assert.IsNotNull(result);
        }






        [Test]
        [Description("TestEditSubCategory")]
        public void TestEditSubCategory()
        {
            _amrepo.EditSubCategories(new SubCategory()
            {
                SubcategoryId = "Sc16",
                SubcategoryName = "carona",
                CategoryId = "7",
                BriefDetails = "drinkwater",
                Gst = "abcde"

            });

            var result = _amrepo.GetSubCatById("Sc16");
            Assert.IsNotNull(result);
        }







        [Test]
        [Description("TestGetAllCategories()")]
        public void TestGetAllCategories()
        {
            var result = _amrepo.GetCategories();
            Assert.IsNotNull(result);
            Assert.Greater(result.Count, 2);

        }



        [Test]
        [Description("TestGetAllSubCategories()")]
        public void TestGetAllSubCategories()
        {
            var result = _amrepo.ViewSubCategories();
            Assert.IsNotNull(result);
            Assert.Greater(result.Count, 2);

        }





        [Test]
        [Description("TestDeleteSubCategory()")]
        public void TestDeleteSubCategory()
        {
            _amrepo.DeleteSubCategories("Sc63");
            var result = _amrepo.GetSubCatById("Sc63");
            Assert.IsNull(result);

        }

        [Test]
        [Description("TestDeleteCategory()")]
        public void TestDeleteCategory()
        {
            _amrepo.DeleteCategories("c49");
            var result = _amrepo.GetCatById("c49");
            Assert.IsNull(result);

        }





    }


}

