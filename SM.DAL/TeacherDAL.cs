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
  public  class TeacherDAL
    {

      public TeacherDAL()
      {
            
      }

      public int AddTeacher(Teacher teacher)
      {
          SqlParameter[] arParams = new SqlParameter[9];
          SqlConnection conn = DbHelper.GetOpenConnection();
          int result = 0;
          try
          {
              arParams[0] = new SqlParameter("@teacher_name", teacher.teacher_name);
              arParams[1] = new SqlParameter("@teacher_short_name", teacher.teacher_short_name);
              arParams[2] = new SqlParameter("@teacher_address", teacher.teacher_address);
              arParams[3] = new SqlParameter("@designation_id", teacher.designation_id);
              arParams[4] = new SqlParameter("@gender_id", teacher.gender_id);
              arParams[5] = new SqlParameter("@contact_number", teacher.contact_number);
              arParams[6] = new SqlParameter("@official_number", teacher.official_number);
              arParams[7] = new SqlParameter("@email", teacher.email);
              arParams[8] = new SqlParameter("@teacher_id", SqlDbType.Int, 4);
              arParams[8].Direction = ParameterDirection.Output;
              SqlHelper.ExecuteNonQuery(conn, CommandType.StoredProcedure, "AddTeacher", arParams);
              result = Convert.ToInt32(arParams[8].Value.ToString());
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

      public int UpdateTeacher(Teacher teacher)
      {
          SqlParameter[] arParams = new SqlParameter[9];
          try
          {
              arParams[0] = new SqlParameter("@teacher_name", teacher.teacher_name);
              arParams[1] = new SqlParameter("@teacher_short_name", teacher.teacher_short_name);
              arParams[2] = new SqlParameter("@teacher_address", teacher.teacher_address);
              arParams[3] = new SqlParameter("@designation_id", teacher.designation_id);
              arParams[4] = new SqlParameter("@gender_id", teacher.gender_id);
              arParams[5] = new SqlParameter("@contact_number", teacher.contact_number);
              arParams[6] = new SqlParameter("@official_number", teacher.official_number);
              arParams[7] = new SqlParameter("@email", teacher.email);
              arParams[8] = new SqlParameter("@teacher_id", teacher.teacher_id);
              return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "UpdateTeacher", arParams);
          }
          catch (Exception ex)
          {
              throw ex;
          }
      }
      public List<Teacher> GetTeacherList()
      {
          try
          {

              return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetTeacher").Tables[0].DataTableToList<Teacher>();
          }
          catch (Exception ex)
          {
              throw ex;
          }
          finally
          {
          }
      }
      public DataSet GeTeachers()
      {
          try
          {
              return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetTeacher");
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
