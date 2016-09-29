using SM.BusinessObjects;
using SM.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SM.BLL
{
   public class SubjectBLL
    {
       private SubjectDAL _subjectDAL;

        public SubjectDAL subjectDAL
        {
            get { return _subjectDAL; }
            set { _subjectDAL = value; }
        }

       public SubjectBLL()
       {
            subjectDAL=new SubjectDAL();
           
       }

       public int AddSubject(Subject  subject)
        {
            try
            {
                return subjectDAL.AddSubject(subject);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       public int UpdateSubject(Subject  subject)
        {
            try
            {
                return subjectDAL.UpdateSubject(subject);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       public List<Subject> GetSubjectList()
       {
           try
           {
               return subjectDAL.GetSubjectList();
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
       public DataSet GetSubject()
       {
           try
           {
               return subjectDAL.GeSubjects();
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }

    }
}
