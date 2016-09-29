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
    public class SessionYearDAL
    {
        public SessionYearDAL()
        {

        }

        public int AddSessionYear(SessionYear session_year)
        {
            SqlParameter[] arParams = new SqlParameter[5];
            SqlConnection conn = DbHelper.GetOpenConnection();
            int result = 0;
            try
            {
                arParams[0] = new SqlParameter("@start_on", session_year.start_on);
                arParams[1] = new SqlParameter("@ends_on", session_year.ends_on);
                arParams[2] = new SqlParameter("@description", session_year.description);
                arParams[3] = new SqlParameter("@status", session_year.status);
                arParams[4] = new SqlParameter("@session_id", SqlDbType.Int, 4);
                arParams[4].Direction = ParameterDirection.Output;
                SqlHelper.ExecuteNonQuery(conn, CommandType.StoredProcedure, "AddSessionYear", arParams);
                result = Convert.ToInt32(arParams[4].Value.ToString());
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

        public int UpdateSessionYear(SessionYear session_year)
        {
            SqlParameter[] arParams = new SqlParameter[5];
            try
            {
                arParams[0] = new SqlParameter("@start_on", session_year.start_on);
                arParams[1] = new SqlParameter("@ends_on", session_year.ends_on);
                arParams[2] = new SqlParameter("@description", session_year.description);
                arParams[3] = new SqlParameter("@status", session_year.status);
                arParams[4] = new SqlParameter("@session_id", session_year.session_id);
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "UpdateSessionYear", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<SessionYear> GetSessionYearList()
        {
            try
            {

                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetSessionYear").Tables[0].DataTableToList<SessionYear>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public DataSet GeSessionYears()
        {
            try
            {
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetSessionYear");
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
