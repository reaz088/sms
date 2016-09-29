using SM.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM.BLL
{
    public class AssignStudentBLL
    {
        

        private AssignStudentDAL _assignStudent;

        public AssignStudentDAL assignStudentDAL
        {
            get { return _assignStudent; }
            set { _assignStudent = value; }
        }

        public AssignStudentBLL()
        {
                
        }       
        
    }
}
