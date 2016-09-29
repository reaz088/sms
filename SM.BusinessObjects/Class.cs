using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM.BusinessObjects
{
   [Serializable()]
public class Class
{
	private int  _class_id;
	public int class_id
	{
		get { return _class_id; }
		set { _class_id = value; }
	}
	private string  _class;
	public string class_name
	{
		get { return _class; }
		set { _class = value; }
	}
    private string _short_name;
    public string short_name
	{
        get { return _short_name; }
        set { _short_name = value; }
	}

    private Nullable<int> _teacher_id;
    public Nullable<int> teacher_id
	{
        get { return _teacher_id; }
        set { _teacher_id = value; }
	}
	public Class()
	{ }
	public Class(int  class_id,string  class_name,string short_name,Nullable<int> teacher_id)
	{
		this.class_id=  class_id;
        this.class_name = class_name;
        this.short_name = short_name;
        this.teacher_id = teacher_id;

	}
	public override string ToString()
	{
        return "class_id = " + class_id.ToString() + "class = " + class_name.ToString() + "class = " + short_name.ToString() + "class = " + teacher_id.ToString();
	}
	public class class_idComparer : System.Collections.Generic.IComparer<Class>
	{
		public SorterMode SorterMode;
		public class_idComparer()
		{ }
		public class_idComparer(SorterMode SorterMode)
		{
			this.SorterMode = SorterMode;
		}
		#region IComparer<Class> Membres
		int System.Collections.Generic.IComparer<Class>.Compare(Class x, Class y)
		{
			if (SorterMode == SorterMode.Ascending)
			{
				return y.class_id.CompareTo(x.class_id);
			}
			else
			{
				return x.class_id.CompareTo(y.class_id);
			}
		}
		#endregion
	}
}
}
