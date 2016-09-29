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
  public class DesignationDAL
    {
      public DesignationDAL()
      {
            
      }

      public int AddDesignation(Designation designation)
      {
          SqlParameter[] arParams = new SqlParameter[3];
          SqlConnection conn = DbHelper.GetOpenConnection();
          int result = 0;
          try
          {
              arParams[0] = new SqlParameter("@designation_name", designation.designation_name);
              arParams[1] = new SqlParameter("@designation_short_name", designation.designation_short_name);
              arParams[2] = new SqlParameter("@designation_id", SqlDbType.Int, 4);
              arParams[2].Direction = ParameterDirection.Output;
              SqlHelper.ExecuteNonQuery(conn, CommandType.StoredProcedure, "AddDesignation", arParams);
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

      public int UpdateDesignation(Designation designation)
      {
          SqlParameter[] arParams = new SqlParameter[3];
          try
          {
              arParams[0] = new SqlParameter("@designation_name", designation.designation_name);
              arParams[1] = new SqlParameter("@designation_short_name", designation.designation_short_name);
              arParams[2] = new SqlParameter("@designation_id", designation.designation_id);
              return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "UpdateDesignation", arParams);
          }
          catch (Exception ex)
          {
              throw ex;
          }
      }

      public List<Designation> GetDesignationList()
      {
          try
          {

              return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetDesignation").Tables[0].DataTableToList<Designation>();
          }
          catch (Exception ex)
          {
              throw ex;
          }
          finally
          {
          }
      }
      public DataSet GeDesignations()
      {
          try
          {
              return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetDesignation");
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
