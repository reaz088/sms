using SM.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM.BLL
{
  public class DailyAttendanceDetailsBLL
    {
        private DailyAttendanceDetailsDAL _dailyAttendanceDetailsDAL;

        public DailyAttendanceDetailsDAL dailyAttendanceDetailsDAL
        {
            get { return _dailyAttendanceDetailsDAL; }
            set { _dailyAttendanceDetailsDAL = value; }
        }

        public DailyAttendanceDetailsBLL()
        {

        }

    }
}
