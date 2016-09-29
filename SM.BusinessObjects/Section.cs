using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM.BusinessObjects
{
    [Serializable()]
    public class Section
    {
        private int _section_id;
        public int section_id
        {
            get { return _section_id; }
            set { _section_id = value; }
        }
        private string _section_name;
        public string section_name
        {
            get { return _section_name; }
            set { _section_name = value; }
        }

        private string _section_short_name;
        public string section_short_name
        {
            get { return _section_short_name; }
            set { _section_short_name = value; }
        }

        private int _class_id;

        public int class_id
        {
            get { return _class_id; }
            set { _class_id = value; }
        }

        private int _teacher_id;

        public int teacher_id
        {
            get { return _teacher_id; }
            set { _teacher_id = value; }
        }


        public Section()
        { }
        public Section(int section_id, string section, string section_short_name, int class_id, int teacher_id)
        {
            this.section_id = section_id;
            this.section_name = section_name;
            this.section_short_name = section_short_name;
            this.class_id = class_id;
            this.teacher_id = teacher_id;
        }
        public override string ToString()
        {
            return "section_id = " + section_id.ToString() + "section_name = " + section_name.ToString() + "section_short_name" + section_short_name.ToString() + "class_id" + class_id.ToString() + "teacher_id" + teacher_id.ToString();
        }
        public class section_idComparer : System.Collections.Generic.IComparer<Section>
        {
            public SorterMode SorterMode;
            public section_idComparer()
            { }
            public section_idComparer(SorterMode SorterMode)
            {
                this.SorterMode = SorterMode;
            }
            #region IComparer<Section> Membres
            int System.Collections.Generic.IComparer<Section>.Compare(Section x, Section y)
            {
                if (SorterMode == SorterMode.Ascending)
                {
                    return y.section_id.CompareTo(x.section_id);
                }
                else
                {
                    return x.section_id.CompareTo(y.section_id);
                }
            }
            #endregion
        }
    }
}
