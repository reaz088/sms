using SM.BusinessObjects;
using SM.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SM.BLL
{
   public class GenderBLL
    {
        private GenderDAL _genderDAL;

        public GenderDAL genderDAL
        {
            get { return _genderDAL; }
            set { _genderDAL = value; }
        }

       public GenderBLL()
       {
            genderDAL=new GenderDAL();
           
       }

       public int AddGender(Gender  gender)
        {
            try
            {
                return genderDAL.AddGender(gender);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       public int UpdateGender(Gender  gender)
        {
            try
            {
                return genderDAL.UpdateGender(gender);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       public List<Gender> GetGenderList()
       {
           try
           {
               return genderDAL.GetGenderList();
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
       public DataSet GetGender()
       {
           try
           {
               return genderDAL.GeGenders();
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
    }
}
