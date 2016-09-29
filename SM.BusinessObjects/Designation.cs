using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM.BusinessObjects
{
    [Serializable()]
public class Designation
{
	private int  _designation_id;
	public int designation_id
	{
		get { return _designation_id; }
		set { _designation_id = value; }
	}
	private string  _designation_name;
	public string designation_name
	{
		get { return _designation_name; }
		set { _designation_name = value; }
	}
	private string  _designation_short_name;
	public string designation_short_name
	{
		get { return _designation_short_name; }
		set { _designation_short_name = value; }
	}
	public Designation()
	{ }
	public Designation(int  designation_id,string  designation_name,string  designation_short_name)
	{
		this.designation_id=  designation_id;
		this.designation_name=  designation_name;
		this.designation_short_name=  designation_short_name;
	}
	public override string ToString()
	{
		return "designation_id = " +  designation_id.ToString() +"designation_name = " +  designation_name.ToString() +"designation_short_name = " +  designation_short_name.ToString();
	}
	public class designation_idComparer : System.Collections.Generic.IComparer<Designation>
	{
		public SorterMode SorterMode;
		public designation_idComparer()
		{ }
		public designation_idComparer(SorterMode SorterMode)
		{
			this.SorterMode = SorterMode;
		}
		#region IComparer<Designation> Membres
		int System.Collections.Generic.IComparer<Designation>.Compare(Designation x, Designation y)
		{
			if (SorterMode == SorterMode.Ascending)
			{
				return y.designation_id.CompareTo(x.designation_id);
			}
			else
			{
				return x.designation_id.CompareTo(y.designation_id);
			}
		}
		#endregion
	}
}
}
