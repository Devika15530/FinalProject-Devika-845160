using Emart.AdminService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Emart.AdminService.Repository
{
   public  interface IAdminRepository
    {

        void AddCategory(Category obj);

        void AddSubCategories(SubCategory obj);

        List<Category> GetCategories();

        List<Category> ViewCategories();
        List<SubCategory> ViewSubCategories();
        public void EditCategories(Category catobj);
        public void EditSubCategories(SubCategory subcatobj);
        public void DeleteCategories(string catid);

        public void DeleteSubCategories(string subcatid);
        public Category GetCatById(string catid);
        public SubCategory GetSubCatById(string subcatid);

    }
}
