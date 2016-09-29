using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM.BusinessObjects
{
    [Serializable()]
    public class StudentGuardianDetails
    {
        private int _student_guardian_details_id;
        public int student_guardian_details_id
        {
            get { return _student_guardian_details_id; }
            set { _student_guardian_details_id = value; }
        }
        private Nullable<int> _student_admission_id;
        public Nullable<int> student_admission_id
        {
            get { return _student_admission_id; }
            set { _student_admission_id = value; }
        }
        private string _fathers_name;
        public string fathers_name
        {
            get { return _fathers_name; }
            set { _fathers_name = value; }
        }
        private string _fathers_education;
        public string fathers_education
        {
            get { return _fathers_education; }
            set { _fathers_education = value; }
        }
        private string _fathers_cell_no;
        public string fathers_cell_no
        {
            get { return _fathers_cell_no; }
            set { _fathers_cell_no = value; }
        }
        private Nullable<int> _father_occupation_id;
        public Nullable<int> father_occupation_id
        {
            get { return _father_occupation_id; }
            set { _father_occupation_id = value; }
        }
        private string _mothers_name;
        public string mothers_name
        {
            get { return _mothers_name; }
            set { _mothers_name = value; }
        }
        private string _mothers_cell_no;
        public string mothers_cell_no
        {
            get { return _mothers_cell_no; }
            set { _mothers_cell_no = value; }
        }
        private decimal _income_yearly;
        public decimal income_yearly
        {
            get { return _income_yearly; }
            set { _income_yearly = value; }
        }
        private int _is_local_guardian;
        public int is_local_guardian
        {
            get { return _is_local_guardian; }
            set { _is_local_guardian = value; }
        }
        private string _local_guardian_name;
        public string local_guardian_name
        {
            get { return _local_guardian_name; }
            set { _local_guardian_name = value; }
        }
        private string _local_guardian_address;
        public string local_guardian_address
        {
            get { return _local_guardian_address; }
            set { _local_guardian_address = value; }
        }
        private string _local_guardian_cell_no;
        public string local_guardian_cell_no
        {
            get { return _local_guardian_cell_no; }
            set { _local_guardian_cell_no = value; }
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
        public StudentGuardianDetails()
        { }
        public StudentGuardianDetails(int student_guardian_details_id, Nullable<int> student_admission_id, string fathers_name, string fathers_education, string fathers_cell_no, Nullable<int> father_occupation_id, string mothers_name, string mothers_cell_no, decimal income_yearly, int is_local_guardian, string local_guardian_name, string local_guardian_address, string local_guardian_cell_no, Nullable<int> record_created_by, Nullable<DateTime> record_created_date, Nullable<int> record_modified_by, Nullable<DateTime> record_modified_date)
        {
            this.student_guardian_details_id = student_guardian_details_id;
            this.student_admission_id = student_admission_id;
            this.fathers_name = fathers_name;
            this.fathers_education = fathers_education;
            this.fathers_cell_no = fathers_cell_no;
            this.father_occupation_id = father_occupation_id;
            this.mothers_name = mothers_name;
            this.mothers_cell_no = mothers_cell_no;
            this.income_yearly = income_yearly;
            this.is_local_guardian = is_local_guardian;
            this.local_guardian_name = local_guardian_name;
            this.local_guardian_address = local_guardian_address;
            this.local_guardian_cell_no = local_guardian_cell_no;
            this.record_created_by = record_created_by;
            this.record_created_date = record_created_date;
            this.record_modified_by = record_modified_by;
            this.record_modified_date = record_modified_date;
        }
        public override string ToString()
        {
            return "student_guardian_details_id = " + student_guardian_details_id.ToString() + "student_admission_id = " + student_admission_id.ToString() + "fathers_name = " + fathers_name.ToString() + "fathers_education = " + fathers_education.ToString() + "fathers_cell_no = " + fathers_cell_no.ToString() + "father_occupation_id = " + father_occupation_id.ToString() + "mothers_name = " + mothers_name.ToString() + "mothers_cell_no = " + mothers_cell_no.ToString() + "income_yearly = " + income_yearly.ToString() + "is_local_guardian = " + is_local_guardian.ToString() + "local_guardian_name = " + local_guardian_name.ToString() + "local_guardian_address = " + local_guardian_address.ToString() + "local_guardian_cell_no = " + local_guardian_cell_no.ToString() + "record_created_by = " + record_created_by.ToString() + "record_created_date = " + record_created_date.ToString() + "record_modified_by = " + record_modified_by.ToString() + "record_modified_date = " + record_modified_date.ToString();
        }
        public class student_guardian_details_idComparer : System.Collections.Generic.IComparer<StudentGuardianDetails>
        {
            public SorterMode SorterMode;
            public student_guardian_details_idComparer()
            { }
            public student_guardian_details_idComparer(SorterMode SorterMode)
            {
                this.SorterMode = SorterMode;
            }
            #region IComparer<StudentGuardianDetails> Membres
            int System.Collections.Generic.IComparer<StudentGuardianDetails>.Compare(StudentGuardianDetails x, StudentGuardianDetails y)
            {
                if (SorterMode == SorterMode.Ascending)
                {
                    return y.student_guardian_details_id.CompareTo(x.student_guardian_details_id);
                }
                else
                {
                    return x.student_guardian_details_id.CompareTo(y.student_guardian_details_id);
                }
            }
            #endregion
        }
        public class income_yearlyComparer : System.Collections.Generic.IComparer<StudentGuardianDetails>
        {
            public SorterMode SorterMode;
            public income_yearlyComparer()
            { }
            public income_yearlyComparer(SorterMode SorterMode)
            {
                this.SorterMode = SorterMode;
            }
            #region IComparer<StudentGuardianDetails> Membres
            int System.Collections.Generic.IComparer<StudentGuardianDetails>.Compare(StudentGuardianDetails x, StudentGuardianDetails y)
            {
                if (SorterMode == SorterMode.Ascending)
                {
                    return y.income_yearly.CompareTo(x.income_yearly);
                }
                else
                {
                    return x.income_yearly.CompareTo(y.income_yearly);
                }
            }
            #endregion
        }
        public class is_local_guardianComparer : System.Collections.Generic.IComparer<StudentGuardianDetails>
        {
            public SorterMode SorterMode;
            public is_local_guardianComparer()
            { }
            public is_local_guardianComparer(SorterMode SorterMode)
            {
                this.SorterMode = SorterMode;
            }
            #region IComparer<StudentGuardianDetails> Membres
            int System.Collections.Generic.IComparer<StudentGuardianDetails>.Compare(StudentGuardianDetails x, StudentGuardianDetails y)
            {
                if (SorterMode == SorterMode.Ascending)
                {
                    return y.is_local_guardian.CompareTo(x.is_local_guardian);
                }
                else
                {
                    return x.is_local_guardian.CompareTo(y.is_local_guardian);
                }
            }
            #endregion
        }
    }
}

