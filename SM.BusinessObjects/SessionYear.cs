using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM.BusinessObjects
{
    [Serializable()]
    public class SessionYear
    {
        private int _session_id;
        public int session_id
        {
            get { return _session_id; }
            set { _session_id = value; }
        }
        private DateTime _start_on;
        public DateTime start_on
        {
            get { return _start_on; }
            set { _start_on = value; }
        }
        private DateTime _ends_on;
        public DateTime ends_on
        {
            get { return _ends_on; }
            set { _ends_on = value; }
        }
        private string _description;
        public string description
        {
            get { return _description; }
            set { _description = value; }
        }
        private Nullable<int> _status;
        public Nullable<int> status
        {
            get { return _status; }
            set { _status = value; }
        }
        public SessionYear()
        { }
        public SessionYear(int session_id, DateTime start_on, DateTime ends_on, string description, Nullable<int> status)
        {
            this.session_id = session_id;
            this.start_on = start_on;
            this.ends_on = ends_on;
            this.description = description;
            this.status = status;
        }
        public override string ToString()
        {
            return "session_id = " + session_id.ToString() + "start_on = " + start_on.ToString() + "ends_on = " + ends_on.ToString() + "description = " + description.ToString() + "status = " + status.ToString();
        }
        public class session_idComparer : System.Collections.Generic.IComparer<SessionYear>
        {
            public SorterMode SorterMode;
            public session_idComparer()
            { }
            public session_idComparer(SorterMode SorterMode)
            {
                this.SorterMode = SorterMode;
            }
            #region IComparer<SessionYear> Membres
            int System.Collections.Generic.IComparer<SessionYear>.Compare(SessionYear x, SessionYear y)
            {
                if (SorterMode == SorterMode.Ascending)
                {
                    return y.session_id.CompareTo(x.session_id);
                }
                else
                {
                    return x.session_id.CompareTo(y.session_id);
                }
            }
            #endregion
        }
    }
}

