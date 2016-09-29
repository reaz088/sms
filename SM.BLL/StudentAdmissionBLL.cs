using SM.BusinessObjects;
using SM.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SM.BLL
{
    public class StudentAdmissionBLL
    {
        private StudentAdmissionDAL _studentAdmissionDAL;

        public StudentAdmissionDAL studentAdmissionDAL
        {
            get { return _studentAdmissionDAL; }
            set { _studentAdmissionDAL = value; }
        }

        public StudentAdmissionBLL()
        {
            studentAdmissionDAL=new StudentAdmissionDAL();
            
        }

        public int AddStudentAdmission(StudentAdmission studentAdmission)
        {
            try
            {
                return studentAdmissionDAL.AddStudentAdmission(studentAdmission);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int UpdateStudentAdmission(StudentAdmission studentAdmission)
        {
            try
            {
                return studentAdmissionDAL.UpdateStudentAdmission(studentAdmission);
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
                return studentAdmissionDAL.GetStudentAdmissionList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet GetStudentAdmission()
        {
            try
            {
                return studentAdmissionDAL.GeStudentAdmissions();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
