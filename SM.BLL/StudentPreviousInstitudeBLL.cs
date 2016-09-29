using SM.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM.BLL
{
   public class StudentPreviousInstitudeBLL
    {
        private StudentPreviousInstitudeDAL _studentPreviousInstitudeDAL;

        public StudentPreviousInstitudeDAL studentPreviousInstitudeDAL
        {
            get { return _studentPreviousInstitudeDAL; }
            set { _studentPreviousInstitudeDAL = value; }
        }

        public StudentPreviousInstitudeBLL()
        {

        }
    }
}
