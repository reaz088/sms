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
	public class PermittedFormDAL
	{
        public PermittedFormDAL()
		{
		}


        public DataSet GetPermittedForm(int userGroupID)
		{
			try
			{
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@user_group_id", userGroupID);

                return DbHelper.GetDataSet(CommandType.StoredProcedure, "Getpermitted_form", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}



        public int AddUserPermittedForm(PermittedForm permittedForm)
        {
            SqlParameter[] arParams = new SqlParameter[6];
            try
            {
                arParams[0] = new SqlParameter("@user_group_id", permittedForm.user_group_id);
                arParams[1] = new SqlParameter("@form_id", permittedForm.form_id);
                arParams[2] = new SqlParameter("@insert_permission", permittedForm.insert_permission);
                arParams[3] = new SqlParameter("@edit_permission", permittedForm.edit_permission);
                arParams[4] = new SqlParameter("@delete_permission", permittedForm.delete_permission);
                arParams[5] = new SqlParameter("@view_permission", permittedForm.view_permission);

                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "UserPermittedFormAdd", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet GetFormPermission(string form, string user_name)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[2];
                arParams[0] = new SqlParameter("@form", form);
                arParams[1] = new SqlParameter("@user_name", user_name);

                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetFormPermission", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }

        }


        public int RemovePermittedForm(PermittedForm permittedForm)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@user_group_id", permittedForm.user_group_id);
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "PermittedFormDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int RemovePermittedForm(int userGroupID)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@user_group_id", userGroupID);
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "PermittedFormDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
