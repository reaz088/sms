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
   public  class SubjectDAL
    {
       public SubjectDAL()
       {

       }

       public int AddSubject(Subject subject)
       {
           SqlParameter[] arParams = new SqlParameter[3];
           SqlConnection conn = DbHelper.GetOpenConnection();
           int result = 0;
           try
           {
               arParams[0] = new SqlParameter("@subject_name", subject.subject_name);
               arParams[1] = new SqlParameter("@subject_code", subject.subject_code);
               arParams[2] = new SqlParameter("@subject_id", SqlDbType.Int, 4);
               arParams[2].Direction = ParameterDirection.Output;
               SqlHelper.ExecuteNonQuery(conn, CommandType.StoredProcedure, "AddSubject", arParams);
               result = Convert.ToInt32(arParams[2].Value.ToString());
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

       public int UpdateSubject(Subject subject)
       {
           SqlParameter[] arParams = new SqlParameter[3];
           try
           {
               arParams[0] = new SqlParameter("@subject_name", subject.subject_name);
               arParams[1] = new SqlParameter("@subject_code", subject.subject_code);
               arParams[2] = new SqlParameter("@subject_id", subject.subject_id);
               return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "UpdateSubject", arParams);
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }

       public List<Subject> GetSubjectList()
       {
           try
           {

               return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetSubject").Tables[0].DataTableToList<Subject>();
           }
           catch (Exception ex)
           {
               throw ex;
           }
           finally
           {
           }
       }
       public DataSet GeSubjects()
       {
           try
           {
               return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetSubject");
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
