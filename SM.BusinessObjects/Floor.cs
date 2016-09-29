using System;
using System.Text;

namespace SM.BusinessObjects
{
	[Serializable()]
	public class Floor
	{
		private int _floor_id;

		public int floor_id
		{
			get { return _floor_id; }
			set { _floor_id = value; }
		}

		private string _floor;

		public string floor
		{
			get { return _floor; }
			set { _floor = value; }
		}

		private Nullable<DateTime> _record_created_date;

		public Nullable<DateTime> record_created_date
		{
			get { return _record_created_date; }
			set { _record_created_date = value; }
		}

		private Nullable<int> _record_created_by;

		public Nullable<int> record_created_by
		{
			get { return _record_created_by; }
			set { _record_created_by = value; }
		}

		private Nullable<DateTime> _record_modified_date;

		public Nullable<DateTime> record_modified_date
		{
			get { return _record_modified_date; }
			set { _record_modified_date = value; }
		}

		private Nullable<int> _record_modified_by;

		public Nullable<int> record_modified_by
		{
			get { return _record_modified_by; }
			set { _record_modified_by = value; }
		}

		public Floor()
		{ }

		public Floor(int floor_id,string floor,Nullable<DateTime> record_created_date,Nullable<int> record_created_by,Nullable<DateTime> record_modified_date,Nullable<int> record_modified_by)
		{
			this.floor_id = floor_id;
			this.floor = floor;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
			return "floor_id = " + floor_id.ToString() + ",floor = " + floor + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class floor_idComparer : System.Collections.Generic.IComparer<Floor>
		{
			public SorterMode SorterMode;
			public floor_idComparer()
			{ }
			public floor_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<Floor> Membres
			int System.Collections.Generic.IComparer<Floor>.Compare(Floor x, Floor y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.floor_id.CompareTo(x.floor_id);
				}
				else
				{
					return x.floor_id.CompareTo(y.floor_id);
				}
			}
			#endregion
		}
		public class floorComparer : System.Collections.Generic.IComparer<Floor>
		{
			public SorterMode SorterMode;
			public floorComparer()
			{ }
			public floorComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<Floor> Membres
			int System.Collections.Generic.IComparer<Floor>.Compare(Floor x, Floor y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
                    return y.floor.CompareTo(x.floor);
				}
				else
				{
                    return x.floor.CompareTo(y.floor);
				}
			}
			#endregion
		}
	}
}
