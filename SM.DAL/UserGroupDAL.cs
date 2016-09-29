using System;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;
using SM.BusinessObjects;

namespace SM.DAL
{
	public class UserGroupDAL
	{
		public UserGroupDAL()
		{
		}

        public DataSet GetUserGroups()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "UserGroupGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}

        public DataSet GetModuleByUserGroupID(int userGroupID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@user_group_id", userGroupID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetModuleByUserGroupID", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public UserGroup GetUserGroup(int userGroupID)
		{
			SqlConnection conn = null;
            UserGroup userGroup = new UserGroup();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@user_group_id", userGroupID);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "UserGroupGet", arParams, ref conn);
				while (dataReader.Read())
				{
                    userGroup.user_group_id = Convert.ToInt32(dataReader["user_group_id"]);

                    if (dataReader["user_group"] != DBNull.Value)
                        userGroup.user_group = Convert.ToString(dataReader["user_group"]);

					
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
            return userGroup;
		}
        public int AddUserGroup(UserGroup userGroup)
		{
			SqlParameter[] arParams = new SqlParameter[2];
            SqlConnection conn = DbHelper.GetOpenConnection();
            int result = 0;
			try
			{
                arParams[0] = new SqlParameter("@user_group", userGroup.user_group);
                arParams[1] = new SqlParameter("@user_group_id", SqlDbType.Int, 4);
                arParams[1].Direction = ParameterDirection.Output;
               
                SqlHelper.ExecuteNonQuery(conn, CommandType.StoredProcedure, "UserGroupAdd", arParams);
                result = Convert.ToInt32(arParams[1].Value.ToString());

			}
            catch (Exception ex)
            {
                result = -2;
                throw ex;
            }
            finally
            {
                DbHelper.CloseConnection(conn);
            }
            return result;
		}

        public int AddUserGroupModule(UserGroup userGroup,Module module)
        {
            SqlParameter[] arParams = new SqlParameter[2];
            SqlConnection conn = DbHelper.GetOpenConnection();
            int result = 0;

            try
            {
                arParams[0] = new SqlParameter("@user_group", userGroup.user_group);
                arParams[1] = new SqlParameter("@module", module.module);
                SqlHelper.ExecuteNonQuery(conn, CommandType.StoredProcedure, "userGroupModuleAdd", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                DbHelper.CloseConnection(conn);
            }
            return result;
        }

       public int UpdateUserGroup(UserGroup userGroup)
		{

			SqlParameter[] arParams = new SqlParameter[2];
			try
			{
                arParams[0] = new SqlParameter("@user_group_id", userGroup.user_group_id);
                arParams[1] = new SqlParameter("@user_group", userGroup.user_group);
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "UserGroupUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int RemoveUserGroup(UserGroup userGroup)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@user_group_id", userGroup.user_group_id);
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "UserGroupDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int RemoveUserGroup(int userGroupID)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@user_group_id", userGroupID);
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "UserGroupDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
