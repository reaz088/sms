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
   public class InstitudeInformationDAL
    {
       public InstitudeInformationDAL()
       {

       }

       public int AddInstitudeInformation(InstitudeInformation institude_information)
       {
           SqlParameter[] arParams = new SqlParameter[6];
           SqlConnection conn = DbHelper.GetOpenConnection();
           int result = 0;
           try
           {
               arParams[0] = new SqlParameter("@institude_name", institude_information.institude_name);
               arParams[1] = new SqlParameter("@institude_address", institude_information.institude_address);
               arParams[2] = new SqlParameter("@institude_email", institude_information.institude_email);
               arParams[3] = new SqlParameter("@institude_phone", institude_information.institude_phone);
               arParams[4] = new SqlParameter("@admin_contact_person", institude_information.admin_contact_person);
               arParams[5] = new SqlParameter("@institude_information_id", SqlDbType.Int, 4);
               arParams[5].Direction = ParameterDirection.Output;
               SqlHelper.ExecuteNonQuery(conn, CommandType.StoredProcedure, "AddInstitudeInformation", arParams);
               result = Convert.ToInt32(arParams[5].Value.ToString());
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

       public int UpdateInstitudeInformation(InstitudeInformation institude_information)
       {
           SqlParameter[] arParams = new SqlParameter[6];
           try
           {
               arParams[0] = new SqlParameter("@institude_name", institude_information.institude_name);
               arParams[1] = new SqlParameter("@institude_address", institude_information.institude_address);
               arParams[2] = new SqlParameter("@institude_email", institude_information.institude_email);
               arParams[3] = new SqlParameter("@institude_phone", institude_information.institude_phone);
               arParams[4] = new SqlParameter("@admin_contact_person", institude_information.admin_contact_person);
               arParams[5] = new SqlParameter("@institude_information_id", institude_information.institude_information_id);
               return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "UpdateInstitudeInformation", arParams);
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }


       public List<InstitudeInformation> GetInstitudeInformationList()
       {
           try
           {

               return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetInstitudeInformation").Tables[0].DataTableToList<InstitudeInformation>();
           }
           catch (Exception ex)
           {
               throw ex;
           }
           finally
           {
           }
       }
       public DataSet GeInstitudeInformations()
       {
           try
           {
               return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetInstitudeInformation");
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
