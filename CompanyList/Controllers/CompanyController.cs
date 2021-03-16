
using CompanyList.Models;
using CompanyList.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CompanyList.Controllers
{
    public class CompanyController : Controller
    {
        // GET: Company
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetCompanyListResult(CompanyRepository oCompanyRepository)
        {
            //CompanyRepository oCompanyRepository = new CompanyRepository();
            CompanyModel oCompanyModel = new CompanyModel();
            oCompanyModel.CompanyLists = oCompanyRepository.GetCompanyList();

            return View("Index", oCompanyModel);
        }
    }
}