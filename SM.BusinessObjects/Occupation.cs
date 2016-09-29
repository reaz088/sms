using System;
using System.Text;

namespace SM.BusinessObjects
{
    //[Serializable()]
    public class Occupation
    {
        private int _occupation_id;
        public int occupation_id
        {
            get { return _occupation_id; }
            set { _occupation_id = value; }
        }
        private string _occupation_name;
        public string occupation_name
        {
            get { return _occupation_name; }
            set { _occupation_name = value; }
        }
        public Occupation()
        { }
        public Occupation(int occupation_id, string occupation_name)
        {
            this.occupation_id = occupation_id;
            this.occupation_name = occupation_name;
        }
        public override string ToString()
        {
            return "occupation_id = " + occupation_id.ToString() + "occupation_name = " + occupation_name.ToString();
        }
        public class occupation_idComparer : System.Collections.Generic.IComparer<Occupation>
        {
            public SorterMode SorterMode;
            public occupation_idComparer()
            { }
            public occupation_idComparer(SorterMode SorterMode)
            {
                this.SorterMode = SorterMode;
            }
            #region IComparer<Occupation> Membres
            int System.Collections.Generic.IComparer<Occupation>.Compare(Occupation x, Occupation y)
            {
                if (SorterMode == SorterMode.Ascending)
                {
                    return y.occupation_id.CompareTo(x.occupation_id);
                }
                else
                {
                    return x.occupation_id.CompareTo(y.occupation_id);
                }
            }
            #endregion
        }
    }
}

