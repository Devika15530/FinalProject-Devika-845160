using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Emart.AdminService.Models;
using Emart.AdminService.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Emart.AdminService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IAdminRepository _iadrepo;
        public AdminController(IAdminRepository irepo)
        {
            _iadrepo = irepo;
        }
        [HttpPost]
        [Route("AddCategories")]
        public IActionResult AddCategories(Category cat)
        {
            try
            {
                _iadrepo.AddCategory(cat);
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound(e.InnerException.Message);
            }
        }
        [HttpPost]
        [Route("AddSubCategories")]
        public IActionResult AddSubCategories(SubCategory obj)
        {
            try
            {
                _iadrepo.AddSubCategories(obj);
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound(e.InnerException.Message);
            }
        }


        [HttpGet]
        [Route("GetCategories")]
        public IActionResult GetCategories()
        {
            try
            {
                return Ok(_iadrepo.GetCategories());
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }


        [HttpGet]
        [Route("ViewCategories")]
        public IActionResult ViewCategories()
        {
            try
            {

                return Ok(_iadrepo.ViewCategories());
            }
            catch (Exception ex)
            {
                return NotFound(ex.InnerException.Message);
            }
        }
        [HttpGet]
        [Route("ViewSubCategories")]
        public IActionResult ViewSubCategories()
        {
            try
            {

                return Ok(_iadrepo.ViewSubCategories());
            }
            catch (Exception ex)
            {
                return NotFound(ex.InnerException.Message);
            }
        }


        [HttpPut]
        [Route("EditCategories")]
        public IActionResult EditCategories(Category catobj)
        {
            try
            {
                _iadrepo.EditCategories(catobj);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.InnerException.Message);
            }
        }


        [HttpPut]
        [Route("EditSubCategories")]
        public IActionResult EditSubCategories(SubCategory subcatobj)
        {
            try
            {
                _iadrepo.EditSubCategories(subcatobj);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.InnerException.Message);
            }
        }
        [HttpDelete]
        [Route("DeleteCategories/{catid}")]
        public IActionResult DeleteCategories(string catid)
        {
            try
            {
                _iadrepo.DeleteCategories(catid);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.InnerException.Message);
            }
        }
        [HttpDelete]
        [Route("DeleteSubCategories/{subcatid}")]
        public IActionResult DeleteSubCategories(string subcatid)
        {
            try
            {
                _iadrepo.DeleteSubCategories(subcatid);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.InnerException.Message);
            }
        }

        [HttpGet]
        [Route("GetSubCatById/{subcatid}")]
        public IActionResult GetSubCatById(string subcatid)
        {
            try
            {

                return Ok(_iadrepo.GetSubCatById(subcatid));
            }
            catch (Exception ex)
            {
                return NotFound(ex.InnerException.Message);
            }
        }
        [HttpGet]
        [Route("GetCatById/{catid}")]
        public IActionResult GetCatById(string catid)
        {
            try
            {

                return Ok(_iadrepo.GetCatById(catid));
            }
            catch (Exception ex)
            {
                return NotFound(ex.InnerException.Message);
            }
        }

    }

}
