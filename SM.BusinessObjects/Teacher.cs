using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM.BusinessObjects
{
   [Serializable()]
public class Teacher
{
	private int  _teacher_id;
	public int teacher_id
	{
		get { return _teacher_id; }
		set { _teacher_id = value; }
	}
	private string  _teacher_name;
	public string teacher_name
	{
		get { return _teacher_name; }
		set { _teacher_name = value; }
	}
	private string  _teacher_short_name;
	public string teacher_short_name
	{
		get { return _teacher_short_name; }
		set { _teacher_short_name = value; }
	}
	private string  _teacher_address;
	public string teacher_address
	{
		get { return _teacher_address; }
		set { _teacher_address = value; }
	}
	private int  _designation_id;
	public int designation_id
	{
		get { return _designation_id; }
		set { _designation_id = value; }
	}
	private int  _gender_id;
	public int gender_id
	{
		get { return _gender_id; }
		set { _gender_id = value; }
	}
	private string  _contact_number;
	public string contact_number
	{
		get { return _contact_number; }
		set { _contact_number = value; }
	}
	private string  _official_number;
	public string official_number
	{
		get { return _official_number; }
		set { _official_number = value; }
	}
	private string  _email;
	public string email
	{
		get { return _email; }
		set { _email = value; }
	}
	public Teacher()
	{ }
	public Teacher(int  teacher_id,string  teacher_name,string  teacher_short_name,string  teacher_address,int   designation_id,int   gender_id,string  contact_number,string  official_number,string  email)
	{
		this.teacher_id=  teacher_id;
		this.teacher_name=  teacher_name;
		this.teacher_short_name=  teacher_short_name;
		this.teacher_address=  teacher_address;
		this.designation_id=  designation_id;
		this.gender_id=  gender_id;
		this.contact_number=  contact_number;
		this.official_number=  official_number;
		this.email=  email;
	}
	public override string ToString()
	{
		return "teacher_id = " +  teacher_id.ToString() +"teacher_name = " +  teacher_name.ToString() +"teacher_short_name = " +  teacher_short_name.ToString() +"teacher_address = " +  teacher_address.ToString() +"designation_id = " +  designation_id.ToString() +"gender_id = " +  gender_id.ToString() +"contact_number = " +  contact_number.ToString() +"official_number = " +  official_number.ToString() +"email = " +  email.ToString();
	}
	public class teacher_idComparer : System.Collections.Generic.IComparer<Teacher>
	{
		public SorterMode SorterMode;
		public teacher_idComparer()
		{ }
		public teacher_idComparer(SorterMode SorterMode)
		{
			this.SorterMode = SorterMode;
		}
		#region IComparer<Teacher> Membres
		int System.Collections.Generic.IComparer<Teacher>.Compare(Teacher x, Teacher y)
		{
			if (SorterMode == SorterMode.Ascending)
			{
				return y.teacher_id.CompareTo(x.teacher_id);
			}
			else
			{
				return x.teacher_id.CompareTo(y.teacher_id);
			}
		}
		#endregion
	}
}
}