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
    public  class GenderDAL
    {
         public GenderDAL()
         {

         }

         public int AddGender(Gender gender)
         {
             SqlParameter[] arParams = new SqlParameter[2];
             SqlConnection conn = DbHelper.GetOpenConnection();
             int result = 0;
             try
             {
                 arParams[0] = new SqlParameter("@gender_name", gender.gender_name);
                 arParams[1] = new SqlParameter("@gender_id", SqlDbType.Int, 4);
                 arParams[1].Direction = ParameterDirection.Output;
                 SqlHelper.ExecuteNonQuery(conn, CommandType.StoredProcedure, "AddGender", arParams);
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

         public int UpdateGender(Gender gender)
         {
             SqlParameter[] arParams = new SqlParameter[2];
             try
             {
                 arParams[0] = new SqlParameter("@gender_name", gender.gender_name);
                 arParams[1] = new SqlParameter("@gender_id", gender.gender_id);
                 return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "UpdateGender", arParams);
             }
             catch (Exception ex)
             {
                 throw ex;
             }
         }

         public List<Gender> GetGenderList()
         {
             try
             {

                 return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetGender").Tables[0].DataTableToList<Gender>();
             }
             catch (Exception ex)
             {
                 throw ex;
             }
             finally
             {
             }
         }
         public DataSet GeGenders()
         {
             try
             {
                 return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetGender");
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
