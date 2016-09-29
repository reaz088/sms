using SM.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM.BLL
{
   public class StudentGuardianDetailsBLL
    {
        private StudentGuardianDetailsDAL _studentGuardianDetailsDAL;

        public StudentGuardianDetailsDAL studentGuardianDetails
        {
            get { return _studentGuardianDetailsDAL; }
            set { _studentGuardianDetailsDAL = value; }
        }


        public StudentGuardianDetailsBLL()
        {
                
        }
    }
}
