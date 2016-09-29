using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM.BusinessObjects
{
    [Serializable()]
    public class Gender
    {
        private int _gender_id;
        public int gender_id
        {
            get { return _gender_id; }
            set { _gender_id = value; }
        }
        private string _gender_name;
        public string gender_name
        {
            get { return _gender_name; }
            set { _gender_name = value; }
        }
        public Gender()
        { }
        public Gender(int gender_id, string gender)
        {
            this.gender_id = gender_id;
            this.gender_name = gender_name;
        }
        public override string ToString()
        {
            return "gender_id = " + gender_id.ToString() + "gender_name = " + gender_name.ToString();
        }
        public class gender_idComparer : System.Collections.Generic.IComparer<Gender>
        {
            public SorterMode SorterMode;
            public gender_idComparer()
            { }
            public gender_idComparer(SorterMode SorterMode)
            {
                this.SorterMode = SorterMode;
            }
            #region IComparer<Gender> Membres
            int System.Collections.Generic.IComparer<Gender>.Compare(Gender x, Gender y)
            {
                if (SorterMode == SorterMode.Ascending)
                {
                    return y.gender_id.CompareTo(x.gender_id);
                }
                else
                {
                    return x.gender_id.CompareTo(y.gender_id);
                }
            }
            #endregion
        }
    }
}

