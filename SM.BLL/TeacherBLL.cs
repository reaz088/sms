using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SM.DAL;
using SM.BusinessObjects;
using System.Data;

namespace SM.BLL
{
    public class TeacherBLL
    {
        private TeacherDAL _teacherDAL;

        public TeacherDAL teacherDAL
        {
            get { return _teacherDAL; }
            set { _teacherDAL = value; }
        }

        public TeacherBLL()
        {
            teacherDAL=new TeacherDAL();
        }

        public int AddTeacher(Teacher  teacher)
        {
            try
            {
                return teacherDAL.AddTeacher(teacher);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int UpdateTeacher(Teacher  teacher)
        {
            try
            {
                return teacherDAL.UpdateTeacher(teacher);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Teacher> GetTeacherList()
        {
            try
            {
                return teacherDAL.GetTeacherList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet GetTeacher()
        {
            try
            {
                return teacherDAL.GeTeachers();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
    }
}
