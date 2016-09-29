using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SM.DAL;
using SM.BusinessObjects;
using System.Data;

namespace SM.BLL
{
    
     
   public class DesignationBLL
    {

        private DesignationDAL _designationDAL;

        public DesignationDAL designationDAL
        {
            get { return _designationDAL; }
            set { _designationDAL = value; }
        }

       public DesignationBLL()
       {
            designationDAL=new DesignationDAL();
           
       }

       public int AddDesignation(Designation  designation)
        {
            try
            {
                return designationDAL.AddDesignation(designation);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       public int UpdateDesignation(Designation  designation)
        {
            try
            {
                return designationDAL.UpdateDesignation(designation);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       public List<Designation> GetDesignationList()
       {
           try
           {
               return designationDAL.GetDesignationList();
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
       public DataSet GetDesignation()
       {
           try
           {
               return designationDAL.GeDesignations();
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }

       
    }
}
