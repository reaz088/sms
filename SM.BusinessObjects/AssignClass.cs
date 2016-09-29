using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM.BusinessObjects
{
    [Serializable()]
    public class AssignClass
    {
        private int _assign_class_id;
        public int assign_class_id
        {
            get { return _assign_class_id; }
            set { _assign_class_id = value; }
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
        public AssignClass()
        { }
        public AssignClass(int assign_class_id, Nullable<int> class_id, Nullable<int> section_id)
        {
            this.assign_class_id = assign_class_id;
            this.class_id = class_id;
            this.section_id = section_id;
        }
        public override string ToString()
        {
            return "assign_class_id = " + assign_class_id.ToString() + "class_id = " + class_id.ToString() + "section_id = " + section_id.ToString();
        }
        public class assign_class_idComparer : System.Collections.Generic.IComparer<AssignClass>
        {
            public SorterMode SorterMode;
            public assign_class_idComparer()
            { }
            public assign_class_idComparer(SorterMode SorterMode)
            {
                this.SorterMode = SorterMode;
            }
            #region IComparer<AssignClass> Membres
            int System.Collections.Generic.IComparer<AssignClass>.Compare(AssignClass x, AssignClass y)
            {
                if (SorterMode == SorterMode.Ascending)
                {
                    return y.assign_class_id.CompareTo(x.assign_class_id);
                }
                else
                {
                    return x.assign_class_id.CompareTo(y.assign_class_id);
                }
            }
            #endregion
        }
    }
}
