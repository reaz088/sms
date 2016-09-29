using SM.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM.BLL
{
   public class DailyAttendanceBLL
    {
        private DailyAttendanceDAL _dailyAttendanceDAL;

        public DailyAttendanceDAL dailyAttendanceDAL
        {
            get { return _dailyAttendanceDAL; }
            set { _dailyAttendanceDAL = value; }
        }

        public DailyAttendanceBLL()
        {

        }

    }
}
