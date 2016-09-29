using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM.BusinessObjects
{
    [Serializable()]
    public class AssignSubject
    {
        private int _assign_subject_id;
        public int assign_subject_id
        {
            get { return _assign_subject_id; }
            set { _assign_subject_id = value; }
        }
        private Nullable<int> _class_id;
        public Nullable<int> class_id
        {
            get { return _class_id; }
            set { _class_id = value; }
        }
        private Nullable<int> _subject_id;
        public Nullable<int> subject_id
        {
            get { return _subject_id; }
            set { _subject_id = value; }
        }
        private Nullable<int> _group_id;
        public Nullable<int> group_id
        {
            get { return _group_id; }
            set { _group_id = value; }
        }
        public AssignSubject()
        { }
        public AssignSubject(int assign_subject_id, Nullable<int> class_id, Nullable<int> subject_id, Nullable<int> group_id)
        {
            this.assign_subject_id = assign_subject_id;
            this.class_id = class_id;
            this.subject_id = subject_id;
            this.group_id = group_id;
        }
        public override string ToString()
        {
            return "assign_subject_id = " + assign_subject_id.ToString() + "class_id = " + class_id.ToString() + "subject_id = " + subject_id.ToString() + "group_id = " + group_id.ToString();
        }
        public class assign_subject_idComparer : System.Collections.Generic.IComparer<AssignSubject>
        {
            public SorterMode SorterMode;
            public assign_subject_idComparer()
            { }
            public assign_subject_idComparer(SorterMode SorterMode)
            {
                this.SorterMode = SorterMode;
            }
            #region IComparer<AssignSubject> Membres
            int System.Collections.Generic.IComparer<AssignSubject>.Compare(AssignSubject x, AssignSubject y)
            {
                if (SorterMode == SorterMode.Ascending)
                {
                    return y.assign_subject_id.CompareTo(x.assign_subject_id);
                }
                else
                {
                    return x.assign_subject_id.CompareTo(y.assign_subject_id);
                }
            }
            #endregion
        }
    }
}

