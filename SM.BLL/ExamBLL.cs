using SM.BusinessObjects;
using SM.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SM.BLL
{
    public class ExamBLL
    {
        private ExamDAL _examDAL;

        public ExamDAL examDAL
        {
            get { return _examDAL; }
            set { _examDAL = value; }
        }
        public ExamBLL()
        {
            examDAL = new ExamDAL();

        }
        public int AddExam(Exam exam)
        {
            try
            {
                return _examDAL.AddExam(exam);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int UpdateExam(Exam exam)
        {
            try
            {
                return _examDAL.UpdateExam(exam);
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
                return _examDAL.GetExamList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public DataSet GetExam()
        {
            try
            {
                return _examDAL.GetExams();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
