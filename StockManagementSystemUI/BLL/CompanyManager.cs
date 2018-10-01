using StockManagementSystemUI.Company.DAL;
using StockManagementSystemUI.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystemUI.Company.BLL
{
    public class CompanyManager
    {
        CompanyRepository _companyRepository = new CompanyRepository();

        public bool Add(Model.Company company)
        {
            bool isAdded = _companyRepository.Add(company);
            return isAdded;

        }

        public DataTable CategoryLode(CompanyManager companyManager)
        {
            return _companyRepository.CategoryLode(companyManager);
        }


        //internal bool Add(Model.Company company)
        //{
        //    throw new NotImplementedException();
        //}

        //public DataTable CategoryLode(CompanyManager companyManager)
        //{
        //    return _companyRepository.CategoryLode(companyManager);
        //}
    }
}
