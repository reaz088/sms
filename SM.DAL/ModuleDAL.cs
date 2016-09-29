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
	public class ModuleDAL
	{
		public ModuleDAL()
		{
		}

		public DataSet GetModules()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "ModuleGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
		public Module GetModule(int moduleID)
		{
			SqlConnection conn = null;
			Module module = new Module();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@moduleID", moduleID);
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "ModuleGet", arParams, ref conn);
				while (dataReader.Read())
				{
					module.module_id = Convert.ToInt32(dataReader["module_id"]);

					if(dataReader["module"] != DBNull.Value)
						module.module = Convert.ToString(dataReader["module"]);

					if(dataReader["user_group_id"] != DBNull.Value)
						module.user_group_id = Convert.ToInt32(dataReader["user_group_id"]);

					
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
			return module;
		}



		  public DataSet PModuleGet(int usergroupID)

		{
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@user_group_id", usergroupID);
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "PModuleGet", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
		public int AddModule(Module module)
		{
			SqlParameter[] arParams = new SqlParameter[2];
			try
			{
				arParams[0] = new SqlParameter("@module", module.module);
				arParams[1] = new SqlParameter("@user_group_id", module.user_group_id);
				
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "ModuleAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int UpdateModule(Module module)
		{

			SqlParameter[] arParams = new SqlParameter[2];
			try
			{
				arParams[0] = new SqlParameter("@module", module.module);
				arParams[1] = new SqlParameter("@user_group_id", module.user_group_id);
				
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "ModuleUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int RemoveModule(Module module)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@module_id", module.user_group_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "ModuleDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int RemoveModule(int moduleID)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@module_id", moduleID);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "ModuleDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
