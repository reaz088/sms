using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM.BusinessObjects
{
    [Serializable()]
    public class District
    {
        private int _district_id;
        public int district_id
        {
            get { return _district_id; }
            set { _district_id = value; }
        }
        private string _district_name;
        public string district_name
        {
            get { return _district_name; }
            set { _district_name = value; }
        }
        public District()
        { }
        public District(int district_id, string district)
        {
            this.district_id = district_id;
            this.district_name = district;
        }
        public override string ToString()
        {
            return "district_id = " + district_id.ToString() + "district = " + district_name.ToString();
        }
        public class district_idComparer : System.Collections.Generic.IComparer<District>
        {
            public SorterMode SorterMode;
            public district_idComparer()
            { }
            public district_idComparer(SorterMode SorterMode)
            {
                this.SorterMode = SorterMode;
            }
            #region IComparer<District> Membres
            int System.Collections.Generic.IComparer<District>.Compare(District x, District y)
            {
                if (SorterMode == SorterMode.Ascending)
                {
                    return y.district_id.CompareTo(x.district_id);
                }
                else
                {
                    return x.district_id.CompareTo(y.district_id);
                }
            }
            #endregion
        }
    }
}

