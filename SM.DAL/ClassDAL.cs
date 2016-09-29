using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SM.BusinessObjects;
using System.Data.SqlClient;
using System.Data;
using Microsoft.ApplicationBlocks.Data;

namespace SM.DAL
{
    public class ClassDAL
    {
        public ClassDAL()
        {

        }

        public int AddClass(Class  _class)
        {
            SqlParameter[] arParams = new SqlParameter[4];
            SqlConnection conn = DbHelper.GetOpenConnection();
            int result = 0;
        try
        {
            arParams[0] = new SqlParameter("@class_name",_class.class_name);
            arParams[1] = new SqlParameter("@short_name",_class.short_name);
            arParams[2] = new SqlParameter("@teacher_id",_class.teacher_id);
            arParams[3] = new SqlParameter("@class_id", SqlDbType.Int, 4);
            arParams[3].Direction = ParameterDirection.Output;
            SqlHelper.ExecuteNonQuery(conn, CommandType.StoredProcedure, "AddClass", arParams);
            result = Convert.ToInt32(arParams[3].Value.ToString());
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


        public int UpdateClass(Class _class)
        {
            SqlParameter[] arParams = new SqlParameter[4];
            try
            {
                arParams[0] = new SqlParameter("@class_name", _class.class_name);
                arParams[1] = new SqlParameter("@short_name", _class.short_name);
                arParams[2] = new SqlParameter("@teacher_id", _class.teacher_id);
                arParams[3] = new SqlParameter("@class_id", _class.class_id);

                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "UpdateClass", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Class> GetClassList()
        {
            try
            {
               
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetClass").Tables[0].DataTableToList<Class>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public DataSet GetClasses()
        {
            try
            {
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetClass");
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
