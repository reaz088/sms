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
   public class StudentAdmissionDAL
    {
       public StudentAdmissionDAL()
       {

       }

       public int AddStudentAdmission(StudentAdmission student_admission)
       {
           SqlParameter[] arParams = new SqlParameter[14];
           SqlConnection conn = DbHelper.GetOpenConnection();
           int result = 0;
           try
           {
               arParams[0] = new SqlParameter("@registration_no", student_admission.registration_no);
               arParams[1] = new SqlParameter("@full_name", student_admission.full_name);
               arParams[2] = new SqlParameter("@admission_date", student_admission.admission_date);
               arParams[3] = new SqlParameter("@class_id", student_admission.class_id);
               arParams[4] = new SqlParameter("@gender_id", student_admission.gender_id);
               arParams[5] = new SqlParameter("@date_of_birth", student_admission.date_of_birth);
               arParams[6] = new SqlParameter("@academic_year_id", student_admission.academic_year_id);
               arParams[7] = new SqlParameter("@district_id", student_admission.district_id);
               arParams[8] = new SqlParameter("@present_address", student_admission.present_address);
               arParams[9] = new SqlParameter("@parmanent_address", student_admission.parmanent_address);
               arParams[10] = new SqlParameter("@first_contact_no", student_admission.first_contact_no);
               arParams[11] = new SqlParameter("@second_contact_no", student_admission.second_contact_no);
               arParams[12] = new SqlParameter("@record_created_by", student_admission.record_created_by);
               arParams[13] = new SqlParameter("@student_admission_id", SqlDbType.Int, 4);
               arParams[13].Direction = ParameterDirection.Output;
               SqlHelper.ExecuteNonQuery(conn, CommandType.StoredProcedure, "AddStudentAdmission", arParams);
               result = Convert.ToInt32(arParams[13].Value.ToString());
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


       public int UpdateStudentAdmission(StudentAdmission student_admission)
       {
           SqlParameter[] arParams = new SqlParameter[14];
           try
           {
               arParams[0] = new SqlParameter("@registration_no", student_admission.registration_no);
               arParams[1] = new SqlParameter("@full_name", student_admission.full_name);
               arParams[2] = new SqlParameter("@admission_date", student_admission.admission_date);
               arParams[3] = new SqlParameter("@class_id", student_admission.class_id);
               arParams[4] = new SqlParameter("@gender_id", student_admission.gender_id);
               arParams[5] = new SqlParameter("@date_of_birth", student_admission.date_of_birth);
               arParams[6] = new SqlParameter("@academic_year_id", student_admission.academic_year_id);
               arParams[7] = new SqlParameter("@district_id", student_admission.district_id);
               arParams[8] = new SqlParameter("@present_address", student_admission.present_address);
               arParams[9] = new SqlParameter("@parmanent_address", student_admission.parmanent_address);
               arParams[10] = new SqlParameter("@first_contact_no", student_admission.first_contact_no);
               arParams[11] = new SqlParameter("@second_contact_no", student_admission.second_contact_no);
               arParams[12] = new SqlParameter("@student_admission_id", student_admission.student_admission_id);
               arParams[13] = new SqlParameter("@record_modified_by", student_admission.record_modified_by);
               return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "UpdateStudentAdmission", arParams);
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }


       public List<StudentAdmission> GetStudentAdmissionList()
       {
           try
           {

               return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetStudentAdmission").Tables[0].DataTableToList<StudentAdmission>();
           }
           catch (Exception ex)
           {
               throw ex;
           }
           finally
           {
           }
       }
       public DataSet GeStudentAdmissions()
       {
           try
           {
               return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetStudentAdmission");
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
