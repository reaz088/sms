using SM.BusinessObjects;
using SM.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SM.BLL
{
   public class SessionYearBLL
    {
        private SessionYearDAL _sessionYearDAL;

        public SessionYearDAL sessionYearDAL
        {
            get { return _sessionYearDAL; }
            set { _sessionYearDAL = value; }
        }

        public SessionYearBLL()
        {
            sessionYearDAL=new SessionYearDAL();
        }

       public int AddSessionYear(SessionYear  session_year)
        {
            try
            {
                return sessionYearDAL.AddSessionYear(session_year);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       public int UpdateSessionYear(SessionYear  session_year)
        {
            try
            {
                return sessionYearDAL.UpdateSessionYear(session_year);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
       public List<SessionYear> GetSessionYearList()
       {
           try
           {
               return sessionYearDAL.GetSessionYearList();
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
       public DataSet GetSessionYear()
       {
           try
           {
               return sessionYearDAL.GeSessionYears();
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }

    }
}
