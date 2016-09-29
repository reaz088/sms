using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using SM.BusinessObjects;
using SM.DAL;

namespace SM.BLL
{
	public class PermittedFormBLL
	{
        private PermittedFormDAL _permittedFormDAL;

        public PermittedFormDAL permittedFormDAL
		{
            get { return _permittedFormDAL; }
            set { _permittedFormDAL = value; }
		}

        public PermittedFormBLL()
		{
            permittedFormDAL = new PermittedFormDAL();
		}



        public DataSet GetPermittedForm(int userGroupID)
		{
			try
			{
                return permittedFormDAL.GetPermittedForm(userGroupID);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public DataSet GetFormPermission(string form, string user_name)
        {
            try
            {
                return permittedFormDAL.GetFormPermission(form, user_name);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public int AddUserPermittedForm(PermittedForm permittedForm)
        {
            try
            {
                return permittedFormDAL.AddUserPermittedForm(permittedForm);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public int RemoveUserPermittedForm(int userGroupID)
        {
            try
            {
                return permittedFormDAL.RemovePermittedForm(userGroupID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       
      
		
	}
}
