using System;
using System.Data;
using SM.BusinessObjects;
using SM.DAL;

namespace SM.BLL
{
	public class UserGroupBLL
	{
        private UserGroupDAL _userGroupDAL;

        public UserGroupDAL userGroupDAL
		{
            get { return _userGroupDAL; }
            set { _userGroupDAL = value; }
		}

        public UserGroupBLL()
		{
            userGroupDAL = new UserGroupDAL();
		}

        public DataSet GetUserGroups()
		{
			try
			{
                return userGroupDAL.GetUserGroups();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public DataSet GetModuleByUserGroupID(int userGroupID)
		{
			try
			{
                return userGroupDAL.GetModuleByUserGroupID(userGroupID);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public UserGroup GetUserGroup(int userGroupID)
		{
			try
			{
                return userGroupDAL.GetUserGroup(userGroupID);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public int AddUserGroup(UserGroup userGroup)
		{
			try
			{
                return userGroupDAL.AddUserGroup(userGroup);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}


        public int AddUserGroupModule(UserGroup userGroup, Module module)
		{
			try
			{
                return userGroupDAL.AddUserGroupModule(userGroup,module);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int UpdateUserGroup(UserGroup userGroup)
		{
			try
			{
                return userGroupDAL.UpdateUserGroup(userGroup);
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
                return userGroupDAL.RemoveUserGroup(userGroup.user_group_id);
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
                return userGroupDAL.RemoveUserGroup(userGroupID);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		
	}
}
