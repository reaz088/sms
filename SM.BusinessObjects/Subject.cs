using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM.BusinessObjects
{
    [Serializable()]
public class Subject
{
	private int  _subject_id;
	public int subject_id
	{
		get { return _subject_id; }
		set { _subject_id = value; }
	}
	private string  _subject_name;
	public string subject_name
	{
		get { return _subject_name; }
		set { _subject_name = value; }
	}
	private string  _subject_code;
	public string subject_code
	{
		get { return _subject_code; }
		set { _subject_code = value; }
	}
	public Subject()
	{ }
    public Subject(int subject_id, string subject_name, string subject_code)
	{
		this.subject_id=  subject_id;
		this.subject_name=  subject_name;
		this.subject_code=  subject_code;
	}
	public override string ToString()
	{
		return "subject_id = " +  subject_id.ToString() +"subject_name = " +  subject_name.ToString() +"subject_code = " +  subject_code.ToString();
	}
	public class subject_idComparer : System.Collections.Generic.IComparer<Subject>
	{
		public SorterMode SorterMode;
		public subject_idComparer()
		{ }
		public subject_idComparer(SorterMode SorterMode)
		{
			this.SorterMode = SorterMode;
		}
		#region IComparer<Subject> Membres
		int System.Collections.Generic.IComparer<Subject>.Compare(Subject x, Subject y)
		{
			if (SorterMode == SorterMode.Ascending)
			{
				return y.subject_id.CompareTo(x.subject_id);
			}
			else
			{
				return x.subject_id.CompareTo(y.subject_id);
			}
		}
		#endregion
	}
}
}

