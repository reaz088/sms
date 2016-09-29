using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;
using SM.BusinessObjects;

namespace SM.DAL
{
	public class FloorDAL
	{
		public FloorDAL()
		{
		}
		public List<Floor> GetfloorsList()
		{
			SqlConnection conn = null;
			List<Floor> lstfloors = new List<Floor>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "floorGetAll", null, ref conn);
				while (dataReader.Read())
				{
					Floor ofloor = new Floor();
					ofloor.floor_id = Convert.ToInt32(dataReader["floor_id"]);

					if(dataReader["floor"] != DBNull.Value)
						ofloor.floor = Convert.ToString(dataReader["floor"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						ofloor.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						ofloor.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						ofloor.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						ofloor.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstfloors.Add(ofloor);
				}
				dataReader.Close();
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				DbHelper.CloseConnection(conn);
			}
			return lstfloors;
		}
		public DataSet Getfloors()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "floorGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
		public Floor Getfloor(int floor_id)
		{
			SqlConnection conn = null;
			Floor ofloor = new Floor();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@floor_id", floor_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "floorGet", arParams, ref conn);
				while (dataReader.Read())
				{
					ofloor.floor_id = Convert.ToInt32(dataReader["floor_id"]);

					if(dataReader["floor"] != DBNull.Value)
						ofloor.floor = Convert.ToString(dataReader["floor"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						ofloor.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						ofloor.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						ofloor.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						ofloor.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
				}
				dataReader.Close();
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				DbHelper.CloseConnection(conn);
			}
			return ofloor;
		}
		public int Addfloor(Floor ofloor)
		{
			SqlParameter[] arParams = new SqlParameter[3];
			try
			{
				arParams[0] = new SqlParameter("@floor", ofloor.floor);
				arParams[1] = new SqlParameter("@record_created_by", ofloor.record_created_by);
				arParams[2] = new SqlParameter("@record_modified_by", ofloor.record_modified_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "floorAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updatefloor(Floor ofloor)
		{

			SqlParameter[] arParams = new SqlParameter[4];
			try
			{
				arParams[0] = new SqlParameter("@floor", ofloor.floor);
				arParams[1] = new SqlParameter("@record_created_by", ofloor.record_created_by);
				arParams[2] = new SqlParameter("@record_modified_by", ofloor.record_modified_by);
				arParams[3] = new SqlParameter("@floor_id", ofloor.floor_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "floorUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removefloor(Floor ofloor)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@floor_id", ofloor.floor_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "floorDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removefloor(int floor_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@floor_id", floor_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "floorDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
