using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM.BusinessObjects
{
    [Serializable()]
    public class DailyAttendance
    {
        private int _daily_attendance_id;
        public int daily_attendance_id
        {
            get { return _daily_attendance_id; }
            set { _daily_attendance_id = value; }
        }
        private Nullable<DateTime> _attendance_date;
        public Nullable<DateTime> attendance_date
        {
            get { return _attendance_date; }
            set { _attendance_date = value; }
        }
        private Nullable<int> _class_id;
        public Nullable<int> class_id
        {
            get { return _class_id; }
            set { _class_id = value; }
        }
        private Nullable<int> _session_id;
        public Nullable<int> session_id
        {
            get { return _session_id; }
            set { _session_id = value; }
        }
        public DailyAttendance()
        { }
        public DailyAttendance(int daily_attendance_id, Nullable<DateTime> attendance_date, Nullable<int> class_id, Nullable<int> session_id)
        {
            this.daily_attendance_id = daily_attendance_id;
            this.attendance_date = attendance_date;
            this.class_id = class_id;
            this.session_id = session_id;
        }
        public override string ToString()
        {
            return "daily_attendance_id = " + daily_attendance_id.ToString() + "attendance_date = " + attendance_date.ToString() + "class_id = " + class_id.ToString() + "session_id = " + session_id.ToString();
        }
        public class daily_attendance_idComparer : System.Collections.Generic.IComparer<DailyAttendance>
        {
            public SorterMode SorterMode;
            public daily_attendance_idComparer()
            { }
            public daily_attendance_idComparer(SorterMode SorterMode)
            {
                this.SorterMode = SorterMode;
            }
            #region IComparer<DailyAttendance> Membres
            int System.Collections.Generic.IComparer<DailyAttendance>.Compare(DailyAttendance x, DailyAttendance y)
            {
                if (SorterMode == SorterMode.Ascending)
                {
                    return y.daily_attendance_id.CompareTo(x.daily_attendance_id);
                }
                else
                {
                    return x.daily_attendance_id.CompareTo(y.daily_attendance_id);
                }
            }
            #endregion
        }
    }
}

