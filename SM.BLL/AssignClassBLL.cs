using SM.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM.BLL
{

   
   public class AssignClassBLL
    {
       private AssignClassDAL _assignClassDAL;

       public AssignClassDAL assignClassDAL
		{
            get { return _assignClassDAL; }
            set { _assignClassDAL = value; }
		}
       public AssignClassBLL()
       {

       }


    }
}
