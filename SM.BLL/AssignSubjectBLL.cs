using SM.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM.BLL
{
    public class AssignSubjectBLL
    {
        private AssignSubjectDAL _assignSubjectDAL;

        public AssignSubjectDAL assignSubjectDAL
        {
            get { return _assignSubjectDAL; }
            set { _assignSubjectDAL = value; }
        }

        public AssignSubjectBLL()
        {

        }
    }
}
