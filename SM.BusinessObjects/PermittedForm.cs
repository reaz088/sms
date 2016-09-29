using System;
using System.Text;

namespace SM.BusinessObjects
{
	[Serializable()]
	public class PermittedForm
	{
		private int _user_group_form_id;

        public int user_group_form_id
		{
            get { return _user_group_form_id; }
            set { _user_group_form_id = value; }
		}

        private Nullable<int> _user_group_id;

        public Nullable<int> user_group_id
		{
            get { return _user_group_id; }
            set { _user_group_id = value; }
		}

		private Nullable<int> _form_id;

        public Nullable<int> form_id
		{
            get { return _form_id; }
            set { _form_id = value; }
		}

        private Nullable<int> _insert_permission;

        public Nullable<int> insert_permission
        {
            get { return _insert_permission; }
            set { _insert_permission = value; }
        }

        private Nullable<int> _edit_permission;

        public Nullable<int> edit_permission
        {
            get { return _edit_permission; }
            set { _edit_permission = value; }
        }
        private Nullable<int> _delete_permission;

        public Nullable<int> delete_permission
        {
            get { return _delete_permission; }
            set { _delete_permission = value; }
        }
        private Nullable<int> _view_permission;

        public Nullable<int> view_permission
        {
            get { return _view_permission; }
            set { _view_permission = value; }
        }





		public PermittedForm()
		{ }

        public PermittedForm(int user_group_form_id, Nullable<int> user_group_id, Nullable<int> form_id, Nullable<int> insert_permission, Nullable<int> edit_permission, Nullable<int> delete_permission, Nullable<int> view_permission)
		{
            this.user_group_form_id = user_group_form_id;
            this.user_group_id = user_group_id;
            this.form_id = form_id;
            this.insert_permission = insert_permission;
            this.edit_permission = edit_permission;
            this.delete_permission = delete_permission;
            this.view_permission = view_permission;
            
			
		}

		public override string ToString()
		{
            return "user_group_form_id = " + user_group_form_id.ToString() + ",user_group_id =" + user_group_id.ToString() + ",form_id = " + form_id.ToString() + " insert_permission = " + insert_permission.ToString() + " edit_permission = " + edit_permission.ToString() + "delete_permission = " + delete_permission.ToString() + " view_permission = " + view_permission.ToString();
		}

        public class user_group_form_idComparer : System.Collections.Generic.IComparer<PermittedForm>
		{
			public SorterMode SorterMode;
			public user_group_form_idComparer()
			{ }
            public user_group_form_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
            }
            #region IComparer<PermittedForm> Membres
            int System.Collections.Generic.IComparer<PermittedForm>.Compare(PermittedForm x, PermittedForm y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
                    return y.user_group_form_id.CompareTo(x.user_group_form_id);
				}
				else
				{
                    return x.user_group_form_id.CompareTo(y.user_group_form_id);
				}
			}
			#endregion
		}
        

	}
}
