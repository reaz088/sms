using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM.BusinessObjects
{
    [Serializable()]
    public class StudentPreviousInstitude
    {
        private int _student_previous_institude_id;
        public int student_previous_institude_id
        {
            get { return _student_previous_institude_id; }
            set { _student_previous_institude_id = value; }
        }
        private Nullable<int> _student_admission_id;
        public Nullable<int> student_admission_id
        {
            get { return _student_admission_id; }
            set { _student_admission_id = value; }
        }
        private Nullable<int> _class_id;
        public Nullable<int> class_id
        {
            get { return _class_id; }
            set { _class_id = value; }
        }
        private Nullable<DateTime> _year;
        public Nullable<DateTime> year
        {
            get { return _year; }
            set { _year = value; }
        }
        private Nullable<decimal> _total_marks;
        public Nullable<decimal> total_marks
        {
            get { return _total_marks; }
            set { _total_marks = value; }
        }
        private string _obtained_marks;
        public string obtained_marks
        {
            get { return _obtained_marks; }
            set { _obtained_marks = value; }
        }
        private Nullable<int> _record_created_by;
        public Nullable<int> record_created_by
        {
            get { return _record_created_by; }
            set { _record_created_by = value; }
        }
        private Nullable<DateTime> _record_created_date;
        public Nullable<DateTime> record_created_date
        {
            get { return _record_created_date; }
            set { _record_created_date = value; }
        }
        private Nullable<int> _record_modified_by;
        public Nullable<int> record_modified_by
        {
            get { return _record_modified_by; }
            set { _record_modified_by = value; }
        }
        private Nullable<DateTime> _record_modified_date;
        public Nullable<DateTime> record_modified_date
        {
            get { return _record_modified_date; }
            set { _record_modified_date = value; }
        }
        public StudentPreviousInstitude()
        { }
        public StudentPreviousInstitude(int student_previous_institude_id, Nullable<int> student_admission_id, Nullable<int> class_id, Nullable<DateTime> year, Nullable<decimal> total_marks, string obtained_marks, Nullable<int> record_created_by, Nullable<DateTime> record_created_date, Nullable<int> record_modified_by, Nullable<DateTime> record_modified_date)
        {
            this.student_previous_institude_id = student_previous_institude_id;
            this.student_admission_id = student_admission_id;
            this.class_id = class_id;
            this.year = year;
            this.total_marks = total_marks;
            this.obtained_marks = obtained_marks;
            this.record_created_by = record_created_by;
            this.record_created_date = record_created_date;
            this.record_modified_by = record_modified_by;
            this.record_modified_date = record_modified_date;
        }
        public override string ToString()
        {
            return "student_previous_institude_id = " + student_previous_institude_id.ToString() + "student_admission_id = " + student_admission_id.ToString() + "class_id = " + class_id.ToString() + "year = " + year.ToString() + "total_marks = " + total_marks.ToString() + "obtained_marks = " + obtained_marks.ToString() + "record_created_by = " + record_created_by.ToString() + "record_created_date = " + record_created_date.ToString() + "record_modified_by = " + record_modified_by.ToString() + "record_modified_date = " + record_modified_date.ToString();
        }
        public class student_previous_institude_idComparer : System.Collections.Generic.IComparer<StudentPreviousInstitude>
        {
            public SorterMode SorterMode;
            public student_previous_institude_idComparer()
            { }
            public student_previous_institude_idComparer(SorterMode SorterMode)
            {
                this.SorterMode = SorterMode;
            }
            #region IComparer<StudentPreviousInstitude> Membres
            int System.Collections.Generic.IComparer<StudentPreviousInstitude>.Compare(StudentPreviousInstitude x, StudentPreviousInstitude y)
            {
                if (SorterMode == SorterMode.Ascending)
                {
                    return y.student_previous_institude_id.CompareTo(x.student_previous_institude_id);
                }
                else
                {
                    return x.student_previous_institude_id.CompareTo(y.student_previous_institude_id);
                }
            }
            #endregion
        }
    }
}
