using System;
using System.Text;

namespace SM.BusinessObjects
{
	[Serializable()]
	public class Module
	{
		private int _module_id;

        public int module_id
		{
            get { return _module_id; }
            set { _module_id = value; }
		}

        private string _module;

        public string module
		{
            get { return _module; }
            set { _module = value; }
		}

		private Nullable<int> _user_group_id;

        public Nullable<int> user_group_id
		{
            get { return _user_group_id; }
            set { _user_group_id = value; }
		}
        
		public Module()
		{ }

        public Module(int module_id, string module, Nullable<int> user_group_id)
		{
            this.module_id = module_id;
            this.module = module;
            this.user_group_id = user_group_id;
            
			
		}

		public override string ToString()
		{
            return "module_id = " + module_id.ToString() + ",module =" + module.ToString() + ",user_group_id = " + user_group_id.ToString();
		}

        public class module_idComparer : System.Collections.Generic.IComparer<Module>
		{
			public SorterMode SorterMode;
			public module_idComparer()
			{ }
            public module_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
            }
            #region IComparer<Module> Membres
            int System.Collections.Generic.IComparer<Module>.Compare(Module x, Module y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
                    return y.module_id.CompareTo(x.module_id);
				}
				else
				{
                    return x.module_id.CompareTo(y.module_id);
				}
			}
			#endregion
		}
        public class moduleComparer : System.Collections.Generic.IComparer<Module>
		{
			public SorterMode SorterMode;
			public moduleComparer()
			{ }
            public moduleComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<Module> Membres
            int System.Collections.Generic.IComparer<Module>.Compare(Module x, Module y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
                    return y.module.CompareTo(x.module);
				}
				else
				{
                    return x.module.CompareTo(y.module);
				}
			}
			#endregion
		}
        

	}
}
