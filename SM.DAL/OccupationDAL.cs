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
   public class OccupationDAL
    {
       public OccupationDAL()
       {

       }

       public int AddOccupation(Occupation occupation)
       {
           SqlParameter[] arParams = new SqlParameter[2];
           SqlConnection conn = DbHelper.GetOpenConnection();
           int result = 0;
           try
           {
               arParams[0] = new SqlParameter("@occupation_name", occupation.occupation_name);
               arParams[1] = new SqlParameter("@occupation_id", SqlDbType.Int, 4);
               arParams[1].Direction = ParameterDirection.Output;
               SqlHelper.ExecuteNonQuery(conn, CommandType.StoredProcedure, "AddOccupation", arParams);
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

       public int UpdateOccupation(Occupation occupation)
       {
           SqlParameter[] arParams = new SqlParameter[2];
           try
           {
               arParams[0] = new SqlParameter("@occupation_name", occupation.occupation_name);
               arParams[1] = new SqlParameter("@occupation_id", occupation.occupation_id);
               return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "UpdateOccupation", arParams);
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }

       public List<Occupation> GetOccupationList()
       {
           try
           {

               return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetOccupation").Tables[0].DataTableToList<Occupation>();
           }
           catch (Exception ex)
           {
               throw ex;
           }
           finally
           {
           }
       }
       public DataSet GeOccupations()
       {
           try
           {
               return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetOccupation");
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
