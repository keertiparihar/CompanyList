using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompanyList.Models
{
    public class CompanyModel
    {
        public int Cid { get; set; }
        public string Cname { get; set; }
        public string Clocation { get; set; }
        public List<CompanyModel> CompanyLists { get; set; }


    }
}