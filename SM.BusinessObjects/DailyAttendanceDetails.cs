using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM.BusinessObjects
{
    [Serializable()]
    public class DailyAttendanceDetails
    {
        private int _daily_attendance_details_id;
        public int daily_attendance_details_id
        {
            get { return _daily_attendance_details_id; }
            set { _daily_attendance_details_id = value; }
        }
        private Nullable<int> _daily_attendance_id;
        public Nullable<int> daily_attendance_id
        {
            get { return _daily_attendance_id; }
            set { _daily_attendance_id = value; }
        }
        private Nullable<int> _assign_student_id;
        public Nullable<int> assign_student_id
        {
            get { return _assign_student_id; }
            set { _assign_student_id = value; }
        }
        private string _remarks;
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; }
        }
        public DailyAttendanceDetails()
        { }
        public DailyAttendanceDetails(int daily_attendance_details_id, Nullable<int> daily_attendance_id, Nullable<int> assign_student_id, string remarks)
        {
            this.daily_attendance_details_id = daily_attendance_details_id;
            this.daily_attendance_id = daily_attendance_id;
            this.assign_student_id = assign_student_id;
            this.remarks = remarks;
        }
        public override string ToString()
        {
            return "daily_attendance_details_id = " + daily_attendance_details_id.ToString() + "daily_attendance_id = " + daily_attendance_id.ToString() + "assign_student_id = " + assign_student_id.ToString() + "remarks = " + remarks.ToString();
        }
        public class daily_attendance_details_idComparer : System.Collections.Generic.IComparer<DailyAttendanceDetails>
        {
            public SorterMode SorterMode;
            public daily_attendance_details_idComparer()
            { }
            public daily_attendance_details_idComparer(SorterMode SorterMode)
            {
                this.SorterMode = SorterMode;
            }
            #region IComparer<DailyAttendanceDetails> Membres
            int System.Collections.Generic.IComparer<DailyAttendanceDetails>.Compare(DailyAttendanceDetails x, DailyAttendanceDetails y)
            {
                if (SorterMode == SorterMode.Ascending)
                {
                    return y.daily_attendance_details_id.CompareTo(x.daily_attendance_details_id);
                }
                else
                {
                    return x.daily_attendance_details_id.CompareTo(y.daily_attendance_details_id);
                }
            }
            #endregion
        }
    }
}

