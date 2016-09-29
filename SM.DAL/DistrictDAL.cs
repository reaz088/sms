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
  public  class DistrictDAL
    {
      public DistrictDAL()
      {

      }

      public int AddDistrict(District district)
      {
          SqlParameter[] arParams = new SqlParameter[2];
          SqlConnection conn = DbHelper.GetOpenConnection();
          int result = 0;
          try
          {
              arParams[0] = new SqlParameter("@district_name", district.district_name);
              arParams[1] = new SqlParameter("@district_id", SqlDbType.Int, 4);
              arParams[1].Direction = ParameterDirection.Output;
              SqlHelper.ExecuteNonQuery(conn, CommandType.StoredProcedure, "AddDistrict", arParams);
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

      public int UpdateDistrict(District district)
      {
          SqlParameter[] arParams = new SqlParameter[2];
          try
          {
              arParams[0] = new SqlParameter("@district_name", district.district_name);
              arParams[1] = new SqlParameter("@district_id", district.district_id);
              return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "UpdateDistrict", arParams);
          }
          catch (Exception ex)
          {
              throw ex;
          }
      }

      public List<District> GetDistrictList()
      {
          try
          {

              return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetDistrict").Tables[0].DataTableToList<District>();
          }
          catch (Exception ex)
          {
              throw ex;
          }
          finally
          {
          }
      }
      public DataSet GeDistricts()
      {
          try
          {
              return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetDistrict");
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
