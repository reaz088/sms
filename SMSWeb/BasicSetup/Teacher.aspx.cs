using SM.BLL;
using SM.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BasicSetup_Teacher : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    [WebMethod]
    public static Teacher Save(Teacher _teacher)
    {
        TeacherBLL teacherBLL = new TeacherBLL();
        Teacher teacher = new Teacher();
        teacher.teacher_name = _teacher.teacher_name;
        teacher.teacher_short_name = _teacher.teacher_short_name;
        teacher.teacher_address = _teacher.teacher_address;
        teacher.designation_id = _teacher.designation_id;
        teacher.gender_id = _teacher.gender_id;
        teacher.contact_number = _teacher.contact_number;
        teacher.official_number = _teacher.official_number;
        teacher.email = _teacher.email;


        teacherBLL.AddTeacher(_teacher);


        return teacher;
    }

    [WebMethod]
    public static Teacher Put(Teacher _teacher)
    {
        TeacherBLL teacherBLL = new TeacherBLL();
        Teacher teacher = new Teacher();
        teacher.teacher_name = _teacher.teacher_name;
        teacher.teacher_short_name = _teacher.teacher_short_name;
        teacher.teacher_address = _teacher.teacher_address;
        teacher.designation_id = _teacher.designation_id;
        teacher.gender_id = _teacher.gender_id;
        teacher.contact_number = _teacher.contact_number;
        teacher.official_number = _teacher.official_number;
        teacher.teacher_id = _teacher.teacher_id;
        teacher.email = _teacher.email;
        teacherBLL.UpdateTeacher(teacher);


        return teacher;
    }

    [WebMethod]
    public static string Get()
    {

        TeacherBLL teacherBLL = new TeacherBLL();
        DesignationBLL designationBLL=new DesignationBLL();

        DataSet ds = new DataSet();
        ds = teacherBLL.GetTeacher();

        var t = from tt in ds.Tables[0].Select()
            select new
            {
                teacher_name = tt["teacher_name"],
                teacher_short_name = tt["teacher_short_name"],
                teacher_address = tt["teacher_address"],
                designation_id = tt["designation_id"],
                gender_id = tt["gender_id"],
                contact_number = tt["contact_number"],
                official_number = tt["official_number"],
                email = tt["email"],
                teacher_id = tt["teacher_id"],
                designation_name = tt["designation_name"],
                gender_name = tt["gender_name"]
            };

        object o = new
        {
            DesignationList = designationBLL.GetDesignationList(),
            TeacherList = t
        };

        return new JavaScriptSerializer().Serialize(o);

       
    }
}