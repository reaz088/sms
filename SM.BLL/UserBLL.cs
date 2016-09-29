using System;
using System.Data;
using SM.BusinessObjects;
using SM.DAL;

namespace SM.BLL
{
	public class UserBLL
	{
		private UserDAL _userDAL;

		public UserDAL userDAL
		{
            get { return _userDAL; }
            set { _userDAL = value; }
		}

        public UserBLL()
		{
			userDAL = new UserDAL();
		}
		
		public DataSet GetUsers()
		{
			try
			{
				return userDAL.GetUsers();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public DataSet UserPemissionGetByUserName(string userName)
		{
			try
			{
				return userDAL.UserPemissionGetByUserName( userName);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public DataSet UserIDGet(string userName)
        {
            try
            {
                return userDAL.UserIDGet(userName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public User GetUser(int userID)
		{
			try
			{
                return userDAL.GetUser(userID);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}


        public Boolean  Login(string user_name,string user_password)
        {
            try
            {
                return userDAL.Login(user_name, user_password);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }





        public int AddUser(User user)
		{
			try
			{
                return userDAL.AddUser(user);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int UpdateUser(User user)
		{
			try
			{
                return userDAL.UpdateUser(user);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

        public int UserPasswordUpdate(User user)
        {
            try
            {
                return userDAL.UserPasswordUpdate(user);
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
                return userDAL.RemoveUser(user);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int RemoveUser(int user_id)
		{
			try
			{
                return userDAL.RemoveUser(user_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		
	}
}
