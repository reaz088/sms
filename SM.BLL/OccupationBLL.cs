using SM.BusinessObjects;
using SM.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SM.BLL
{
    public class OccupationBLL
    {
       private OccupationDAL _occupationDAL;

        public OccupationDAL occupationDAL
        {
            get { return _occupationDAL; }
            set { _occupationDAL = value; }
        }

       public OccupationBLL()
       {
            occupationDAL=new OccupationDAL();
           
       }

       public int AddOccupation(Occupation  occupation)
        {
            try
            {
                return occupationDAL.AddOccupation(occupation);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       public int UpdateOccupation(Occupation  occupation)
        {
            try
            {
                return occupationDAL.UpdateOccupation(occupation);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       public List<Occupation> GetOccupationList()
       {
           try
           {
               return occupationDAL.GetOccupationList();
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
       public DataSet GetOccupation()
       {
           try
           {
               return occupationDAL.GeOccupations();
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
    }
}
