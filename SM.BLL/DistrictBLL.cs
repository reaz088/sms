using SM.BusinessObjects;
using SM.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SM.BLL
{
    public class DistrictBLL
    {
        private DistrictDAL _districtDAL;

        public DistrictDAL districtDAL
        {
            get { return _districtDAL; }
            set { _districtDAL = value; }
        }

       public DistrictBLL()
       {
            districtDAL=new DistrictDAL();
           
       }

       public int AddDistrict(District  district)
        {
            try
            {
                return districtDAL.AddDistrict(district);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       public int UpdateDistrict(District  district)
        {
            try
            {
                return districtDAL.UpdateDistrict(district);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       public List<District> GetDistrictList()
       {
           try
           {
               return districtDAL.GetDistrictList();
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
       public DataSet GetDistrict()
       {
           try
           {
               return districtDAL.GeDistricts();
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }

    }
}
