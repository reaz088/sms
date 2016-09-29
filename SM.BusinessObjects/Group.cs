using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM.BusinessObjects
{
    [Serializable()]
    public class Group
    {
        private int _group_id;
        public int group_id
        {
            get { return _group_id; }
            set { _group_id = value; }
        }
        private string _group_name;
        public string group_name
        {
            get { return _group_name; }
            set { _group_name = value; }
        }
        public Group()
        { }
        public Group(int group_id, string group_name)
        {
            this.group_id = group_id;
            this.group_name = group_name;
        }
        public override string ToString()
        {
            return "group_id = " + group_id.ToString() + "group_name = " + group_name.ToString();
        }
        public class group_idComparer : System.Collections.Generic.IComparer<Group>
        {
            public SorterMode SorterMode;
            public group_idComparer()
            { }
            public group_idComparer(SorterMode SorterMode)
            {
                this.SorterMode = SorterMode;
            }
            #region IComparer<Group1> Membres
            int System.Collections.Generic.IComparer<Group>.Compare(Group x, Group y)
            {
                if (SorterMode == SorterMode.Ascending)
                {
                    return y.group_id.CompareTo(x.group_id);
                }
                else
                {
                    return x.group_id.CompareTo(y.group_id);
                }
            }
            #endregion
        }
    }
}

