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
    public class SectionDAL
    {
        public SectionDAL()
        {

        }

        public int AddSection(Section section)
        {
            SqlParameter[] arParams = new SqlParameter[5];
            SqlConnection conn = DbHelper.GetOpenConnection();
            int result = 0;
            try
            {
                arParams[0] = new SqlParameter("@section_name", section.section_name);
                arParams[1] = new SqlParameter("@section_short_name", section.section_short_name);
                arParams[2] = new SqlParameter("@class_id", section.class_id);
                arParams[3] = new SqlParameter("@teacher_id", section.teacher_id);
                arParams[4] = new SqlParameter("@section_id", SqlDbType.Int, 4);
                arParams[4].Direction = ParameterDirection.Output;
                SqlHelper.ExecuteNonQuery(conn, CommandType.StoredProcedure, "AddSection", arParams);
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


        public int UpdateSection(Section section)
        {
            SqlParameter[] arParams = new SqlParameter[5];
            try
            {
                arParams[0] = new SqlParameter("@section_name", section.section_name);
                arParams[1] = new SqlParameter("@section_short_name", section.section_short_name);
                arParams[2] = new SqlParameter("@class_id", section.class_id);
                arParams[3] = new SqlParameter("@teacher_id", section.teacher_id);
                arParams[4] = new SqlParameter("@section_id", section.section_id);
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "UpdateSection", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<Section> GetSectionList()
        {
            try
            {

                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetSection").Tables[0].DataTableToList<Section>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public DataSet GeSections()
        {
            try
            {
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetSection");
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
