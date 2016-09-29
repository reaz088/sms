using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM.BusinessObjects
{
    [Serializable()]
    public class AssignStudent
    {
        private int _assign_student_id;
        public int assign_student_id
        {
            get { return _assign_student_id; }
            set { _assign_student_id = value; }
        }
        private Nullable<int> _class_id;
        public Nullable<int> class_id
        {
            get { return _class_id; }
            set { _class_id = value; }
        }
        private Nullable<int> _section_id;
        public Nullable<int> section_id
        {
            get { return _section_id; }
            set { _section_id = value; }
        }
        private Nullable<int> _student_id;
        public Nullable<int> student_id
        {
            get { return _student_id; }
            set { _student_id = value; }
        }
        private Nullable<int> _roll_no;
        public Nullable<int> roll_no
        {
            get { return _roll_no; }
            set { _roll_no = value; }
        }
        private Nullable<int> _session_id;
        public Nullable<int> session_id
        {
            get { return _session_id; }
            set { _session_id = value; }
        }
        public AssignStudent()
        { }
        public AssignStudent(int assign_student_id, Nullable<int> class_id, Nullable<int> section_id, Nullable<int> student_id, Nullable<int> roll_no, Nullable<int> session_id)
        {
            this.assign_student_id = assign_student_id;
            this.class_id = class_id;
            this.section_id = section_id;
            this.student_id = student_id;
            this.roll_no = roll_no;
            this.session_id = session_id;
        }
        public override string ToString()
        {
            return "assign_student_id = " + assign_student_id.ToString() + "class_id = " + class_id.ToString() + "section_id = " + section_id.ToString() + "student_id = " + student_id.ToString() + "roll_no = " + roll_no.ToString() + "session_id = " + session_id.ToString();
        }
        public class assign_student_idComparer : System.Collections.Generic.IComparer<AssignStudent>
        {
            public SorterMode SorterMode;
            public assign_student_idComparer()
            { }
            public assign_student_idComparer(SorterMode SorterMode)
            {
                this.SorterMode = SorterMode;
            }
            #region IComparer<AssignStudent> Membres
            int System.Collections.Generic.IComparer<AssignStudent>.Compare(AssignStudent x, AssignStudent y)
            {
                if (SorterMode == SorterMode.Ascending)
                {
                    return y.assign_student_id.CompareTo(x.assign_student_id);
                }
                else
                {
                    return x.assign_student_id.CompareTo(y.assign_student_id);
                }
            }
            #endregion
        }
    }
}
