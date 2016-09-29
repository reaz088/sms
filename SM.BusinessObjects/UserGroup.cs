using System;
using System.Text;

namespace SM.BusinessObjects
{
	[Serializable()]
	public class UserGroup
	{
		private int _user_group_id;

        public int user_group_id
		{
            get { return _user_group_id; }
            set { _user_group_id = value; }
		}

        private string _user_group;

        public string user_group
		{
            get { return _user_group; }
            set { _user_group = value; }
		}

		public UserGroup()
		{ }

        public UserGroup(int user_group_id, string user_group)
		{
            this.user_group_id = user_group_id;
            this.user_group = user_group;
            
		}

		

		public override string ToString()
		{
            return "user_group_id = " + user_group_id.ToString() + ",user_group = " + user_group.ToString();
		}

        public class user_group_idComparer : System.Collections.Generic.IComparer<UserGroup>
		{
			public SorterMode SorterMode;
			public user_group_idComparer()
			{ }
            public user_group_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
            }
            #region IComparer<UserGroup> Membres
            int System.Collections.Generic.IComparer<UserGroup>.Compare(UserGroup x, UserGroup y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
                    return y.user_group_id.CompareTo(x.user_group_id);
				}
				else
				{
                    return x.user_group_id.CompareTo(y.user_group_id);
				}
			}
			#endregion
		}
        public class user_groupComparer : System.Collections.Generic.IComparer<UserGroup>
		{
			public SorterMode SorterMode;
			public user_groupComparer()
			{ }
            public user_groupComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
            }
            #region IComparer<UserGroup> Membres
            int System.Collections.Generic.IComparer<UserGroup>.Compare(UserGroup x, UserGroup y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
                    return y.user_group.CompareTo(x.user_group);
				}
				else
				{
                    return x.user_group.CompareTo(y.user_group);
				}
			}
			#endregion
		}
        

	}
}
