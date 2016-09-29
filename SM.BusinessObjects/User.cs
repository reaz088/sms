using System;
using System.Text;

namespace SM.BusinessObjects
{
	[Serializable()]
	public class User
	{
        private int _user_id;

        public int user_id
		{
            get { return _user_id; }
            set { _user_id = value; }
		}

        private string _user_name;

        public string user_name
		{
            get { return _user_name; }
            set { _user_name = value; }
		}
        private string _user_password;
        

        public string user_password
        {
            get { return _user_password; }
            set { _user_password = value; }
        }
        private string _user_New_password;
        public string user_New_password
        {
            get { return _user_New_password; }
            set { _user_New_password = value; }
        }

        private Nullable<int> _user_group_id;

        public Nullable<int> user_group_id
        {
            get { return _user_group_id; }
            set { _user_group_id = value; }
        }
        private Nullable<int> _floor_id;

        public Nullable<int> floor_id
        {
            get { return _floor_id; }
            set { _floor_id = value; }
        }

        private string _user_surname;

        public string user_surname
        {
            get { return _user_surname; }
            set { _user_surname = value; }
        }
     
        
        public User()
		{ }

        public User(int user_id, string user_name, string user_password, Nullable<int> user_group_id)
		{
            this.user_id = user_id;
            this.user_name = user_name;
            this.user_password = user_password;
            this.user_group_id = user_group_id;
            this.floor_id = floor_id;

        }
		
		public override string ToString()
		{
            return "user_id = " + user_id.ToString() + "user_name = " + user_name.ToString() + " user_password = " + user_password.ToString() + "user_group_id = " + user_group_id.ToString() + "floor_id=" + floor_id.ToString() + "user_surname=" + user_surname;
		}

        public class user_idComparer : System.Collections.Generic.IComparer<User>
		{
			public SorterMode SorterMode;
			public user_idComparer()
			{ }
            public user_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
            }
            #region IComparer<User> Membres
            int System.Collections.Generic.IComparer<User>.Compare(User x, User y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
                    return y.user_id.CompareTo(x.user_id);
				}
				else
				{
                    return x.user_id.CompareTo(y.user_id);
				}
			}
			#endregion
		}
        public class user_nameComparer : System.Collections.Generic.IComparer<User>
		{
			public SorterMode SorterMode;
			public user_nameComparer()
			{ }
            public user_nameComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
            }
            #region IComparer<User> Membres
            int System.Collections.Generic.IComparer<User>.Compare(User x, User y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
                    return y.user_name.CompareTo(x.user_name);
				}
				else
				{
                    return x.user_name.CompareTo(y.user_name);
				}
			}
			#endregion
		}
        public class user_passwordComparer : System.Collections.Generic.IComparer<User>
        {
            public SorterMode SorterMode;
            public user_passwordComparer()
            { }
            public user_passwordComparer(SorterMode SorterMode)
            {
                this.SorterMode = SorterMode;
            }
            #region IComparer<User> Membres
            int System.Collections.Generic.IComparer<User>.Compare(User x, User y)
            {
                if (SorterMode == SorterMode.Ascending)
                {
                    return y.user_password.CompareTo(x.user_password);
                }
                else
                {
                    return x.user_password.CompareTo(y.user_password);
                }
            }
            #endregion
        }

       

	}
}
