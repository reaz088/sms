using System;
using System.Data;
using System.Data.SqlClient;
using SM.BusinessObjects;

namespace SM.DAL
{
	public class UserDAL
	{
        public UserDAL()
		{
		}
       
		public DataSet GetUsers()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "UserGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}


        public DataSet UserPemissionGetByUserName(string userName)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@user_name", userName);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "UserPemissionGetByUserName", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public DataSet UserIDGet(string userName)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@user_name", userName);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "UserIDGet", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
		public User GetUser(int userID)
		{
			SqlConnection conn = null;
            User user = new User();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@user_id", userID);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "UserGet", arParams, ref conn);
				while (dataReader.Read())
				{
                    user.user_id = Convert.ToInt32(dataReader["user_id"]);

                    if (dataReader["user_name"] != DBNull.Value)
                        user.user_name = Convert.ToString(dataReader["user_name"]);

                    if (dataReader["user_password"] != DBNull.Value)
                        user.user_password = Convert.ToString(dataReader["user_password"]);

                    if (dataReader["user_group_id"] != DBNull.Value)
                        user.user_group_id = Convert.ToInt32(dataReader["user_group_id"]);
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
			return user;
		}
		public int AddUser(User user)
		{
			SqlParameter[] arParams = new SqlParameter[4];
			try
			{
                arParams[0] = new SqlParameter("@user_name", user.user_name);
                arParams[1] = new SqlParameter("@user_password", user.user_password);
                arParams[2] = new SqlParameter("@user_group_id", user.user_group_id);
                arParams[3] = new SqlParameter("@floor_id", user.floor_id);
            
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "UserAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int UpdateUser(User user)
		{

			SqlParameter[] arParams = new SqlParameter[3];
			try
			{
                arParams[0] = new SqlParameter("@user_name", user.user_name);
                arParams[1] = new SqlParameter("@user_group_id", user.user_group_id);
                arParams[2] = new SqlParameter("@floor_id", user.floor_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "UserUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int UserPasswordUpdate(User  user)
		{

			SqlParameter[] arParams = new SqlParameter[3];
			try
			{
                arParams[0] = new SqlParameter("@user_name", user.user_name);
                arParams[1] = new SqlParameter("@user_password", user.user_password);
                arParams[2] = new SqlParameter("@user_New_password", user.user_New_password);
               
			
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "UserPasswordUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}


   
        public int RemoveUser(User user)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@user_id", user.user_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "UserDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int RemoveUser(int userID)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@user_id", userID);
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "UserDelete", arParams);
            }
			catch (Exception ex)
			{
				throw ex;
			}


		}

        public Boolean Login(string user_name, string user_password)
        {
            SqlConnection conn = null;
            User user = new User();
            Boolean result = false;
            try
            {
                SqlParameter[] arParams = new SqlParameter[2];
                arParams[0] = new SqlParameter("@user_name", user_name);
                arParams[1] = new SqlParameter("@user_password", user_password);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "Login", arParams, ref conn);
                while (dataReader.Read())
                {
                   // user.user_id = Convert.ToInt32(dataReader["user_id"]);

                    if (dataReader["user_name"] != DBNull.Value && dataReader["user_password"] != DBNull.Value)
                        result= true;
                    else
                        result = false;

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
            return result;
        }


	}
}
