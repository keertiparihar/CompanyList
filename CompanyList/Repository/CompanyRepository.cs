using CompanyList.Models;

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CompanyList.Repository
{
    public class CompanyRepository
    {
        public List<CompanyModel> GetCompanyList()
        {
            List<CompanyModel> companyList = new List<CompanyModel>();
            string myConnection = "Data Source=DESKTOP-JVJFROS;Integrated Security=true;Database=CompanyDB";
            SqlConnection con = new SqlConnection(myConnection);
            SqlCommand cmd = new SqlCommand("CampanyListDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            try
            {
                while (dr.Read())
                {
                    CompanyModel oCompanyListModel = new CompanyModel()
                    {
                        Cname = dr["Cname"].ToString(),
                        Clocation = dr["Clocation"].ToString(),
                       
                    };
                    companyList.Add(oCompanyListModel);

                }
            }
            catch (Exception ex)
            {

            }

            return companyList;
        }
    }
}