using Microsoft.ApplicationBlocks.Data;
using SM.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SM.DAL
{
    public class GroupDAL
    {
        public GroupDAL()
        {

        }

        public int AddGroup(Group _group)
        {
            SqlParameter[] arParams = new SqlParameter[2];
            SqlConnection conn = DbHelper.GetOpenConnection();
            int result = 0;
            try
            {
                arParams[0] = new SqlParameter("@group_name", _group.group_name);
                arParams[1] = new SqlParameter("@group_id", SqlDbType.Int, 4);
                arParams[1].Direction = ParameterDirection.Output;
                SqlHelper.ExecuteNonQuery(conn, CommandType.StoredProcedure, "AddGroup", arParams);
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


        public int UpdateGroup(Group _group)
        {
            SqlParameter[] arParams = new SqlParameter[2];
            try
            {
                arParams[0] = new SqlParameter("@group_name", _group.group_name);
                arParams[1] = new SqlParameter("@group_id", _group.group_id);

                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "UpdateGroup", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Group> GetGroupList()
        {
            try
            {

                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetGroup").Tables[0].DataTableToList<Group>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public DataSet GetGroupes()
        {
            try
            {
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetGroup");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
    }
}
