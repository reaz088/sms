using SM.BusinessObjects;
using SM.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SM.BLL
{
   public class ClassBLL
    {
        private ClassDAL _classDAL;

        public ClassDAL classDAL
        {
            get { return _classDAL; }
            set { _classDAL = value; }
        }

       public ClassBLL()
       {
           classDAL=new ClassDAL();
       }

       public int AddClass(Class  _class)
        {
            try
            {
                return _classDAL.AddClass(_class);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
       public int UpdateClass(Class _class)
        {
            try
            {
                return _classDAL.UpdateClass(_class);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
       public List<Class> GetClassList()
       {
           try
           {
               return _classDAL.GetClassList();
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
       public DataSet GetClass()
       {
           try
           {
               return _classDAL.GetClasses();
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
    }

}
