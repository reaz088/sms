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
    public class ExamDAL
    {
        public ExamDAL()
        {

        }
        public int AddExam(Exam _exam)
        {
            SqlParameter[] arParams = new SqlParameter[2];
            SqlConnection conn = DbHelper.GetOpenConnection();
            int result = 0;
            try
            {
                arParams[0] = new SqlParameter("@exam_name", _exam.exam_name);
                arParams[1] = new SqlParameter("@exam_id", SqlDbType.Int, 4);
                arParams[1].Direction = ParameterDirection.Output;
                SqlHelper.ExecuteNonQuery(conn, CommandType.StoredProcedure, "AddExam", arParams);
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
        public int UpdateExam(Exam _exam)
        {
            SqlParameter[] arParams = new SqlParameter[2];
            try
            {
                arParams[0] = new SqlParameter("@exam_name", _exam.exam_name);
                arParams[1] = new SqlParameter("@exam_id", _exam.exam_id);

                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "UpdateExam", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Exam> GetExamList()
        {
            try
            {

                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetExam").Tables[0].DataTableToList<Exam>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public DataSet GetExams()
        {
            try
            {
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetExam");
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
