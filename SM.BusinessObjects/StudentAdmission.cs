using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM.BusinessObjects
{
    [Serializable()]
    public class StudentAdmission
    {
        private int _student_admission_id;
        public int student_admission_id
        {
            get { return _student_admission_id; }
            set { _student_admission_id = value; }
        }
        private string _registration_no;
        public string registration_no
        {
            get { return _registration_no; }
            set { _registration_no = value; }
        }
        private string _full_name;
        public string full_name
        {
            get { return _full_name; }
            set { _full_name = value; }
        }
        private Nullable<DateTime> _admission_date;
        public Nullable<DateTime> admission_date
        {
            get { return _admission_date; }
            set { _admission_date = value; }
        }
        private Nullable<int> _class_id;
        public Nullable<int> class_id
        {
            get { return _class_id; }
            set { _class_id = value; }
        }
        private Nullable<int> _gender_id;
        public Nullable<int> gender_id
        {
            get { return _gender_id; }
            set { _gender_id = value; }
        }
        private Nullable<DateTime> _date_of_birth;
        public Nullable<DateTime> date_of_birth
        {
            get { return _date_of_birth; }
            set { _date_of_birth = value; }
        }
        private Nullable<int> _academic_year_id;
        public Nullable<int> academic_year_id
        {
            get { return _academic_year_id; }
            set { _academic_year_id = value; }
        }
        private Nullable<int> _district_id;
        public Nullable<int> district_id
        {
            get { return _district_id; }
            set { _district_id = value; }
        }
        private string _present_address;
        public string present_address
        {
            get { return _present_address; }
            set { _present_address = value; }
        }
        private string _parmanent_address;
        public string parmanent_address
        {
            get { return _parmanent_address; }
            set { _parmanent_address = value; }
        }
        private string _first_contact_no;
        public string first_contact_no
        {
            get { return _first_contact_no; }
            set { _first_contact_no = value; }
        }
        private string _second_contact_no;
        public string second_contact_no
        {
            get { return _second_contact_no; }
            set { _second_contact_no = value; }
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
        public StudentAdmission()
        { }
        public StudentAdmission(int student_admission_id, string registration_no, string full_name, Nullable<DateTime> admission_date, Nullable<int> class_id, Nullable<int> gender_id, Nullable<DateTime> date_of_birth, Nullable<int> academic_year_id, Nullable<int> district_id, string present_address, string parmanent_address, string first_contact_no, string second_contact_no, Nullable<int> record_created_by, Nullable<DateTime> record_created_date, Nullable<int> record_modified_by, Nullable<DateTime> record_modified_date)
        {
            this.student_admission_id = student_admission_id;
            this.registration_no = registration_no;
            this.full_name = full_name;
            this.admission_date = admission_date;
            this.class_id = class_id;
            this.gender_id = gender_id;
            this.date_of_birth = date_of_birth;
            this.academic_year_id = academic_year_id;
            this.district_id = district_id;
            this.present_address = present_address;
            this.parmanent_address = parmanent_address;
            this.first_contact_no = first_contact_no;
            this.second_contact_no = second_contact_no;
            this.record_created_by = record_created_by;
            this.record_created_date = record_created_date;
            this.record_modified_by = record_modified_by;
            this.record_modified_date = record_modified_date;
        }
        public override string ToString()
        {
            return "student_admission_id = " + student_admission_id.ToString() + "registration_no = " + registration_no.ToString() + "full_name = " + full_name.ToString() + "admission_date = " + admission_date.ToString() + "class_id = " + class_id.ToString() + "gender_id = " + gender_id.ToString() + "date_of_birth = " + date_of_birth.ToString() + "academic_year_id = " + academic_year_id.ToString() + "district_id = " + district_id.ToString() + "present_address = " + present_address.ToString() + "parmanent_address = " + parmanent_address.ToString() + "first_contact_no = " + first_contact_no.ToString() + "second_contact_no = " + second_contact_no.ToString() + "record_created_by = " + record_created_by.ToString() + "record_created_date = " + record_created_date.ToString() + "record_modified_by = " + record_modified_by.ToString() + "record_modified_date = " + record_modified_date.ToString();
        }
        public class student_admission_idComparer : System.Collections.Generic.IComparer<StudentAdmission>
        {
            public SorterMode SorterMode;
            public student_admission_idComparer()
            { }
            public student_admission_idComparer(SorterMode SorterMode)
            {
                this.SorterMode = SorterMode;
            }
            #region IComparer<StudentAdmission> Membres
            int System.Collections.Generic.IComparer<StudentAdmission>.Compare(StudentAdmission x, StudentAdmission y)
            {
                if (SorterMode == SorterMode.Ascending)
                {
                    return y.student_admission_id.CompareTo(x.student_admission_id);
                }
                else
                {
                    return x.student_admission_id.CompareTo(y.student_admission_id);
                }
            }
            #endregion
        }
    }
}
