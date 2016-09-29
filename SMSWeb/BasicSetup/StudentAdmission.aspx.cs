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

public partial class BasicSetup_StudentAdmission : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    [WebMethod]
    public static StudentAdmission Save(StudentAdmission _studentAdmission)
    {
        StudentAdmissionBLL studentAdmissionBLL = new StudentAdmissionBLL();
        StudentAdmission studentAdmission = new StudentAdmission();
        studentAdmission.full_name = _studentAdmission.full_name;
        studentAdmission.admission_date = _studentAdmission.admission_date;
        studentAdmission.class_id = _studentAdmission.class_id;
        studentAdmission.gender_id = _studentAdmission.gender_id;
        studentAdmission.date_of_birth = _studentAdmission.date_of_birth;
        studentAdmission.academic_year_id = _studentAdmission.academic_year_id;
        studentAdmission.district_id = _studentAdmission.district_id;
        studentAdmission.present_address = _studentAdmission.present_address;
        studentAdmission.parmanent_address = _studentAdmission.parmanent_address;
        studentAdmission.first_contact_no = _studentAdmission.first_contact_no;
        studentAdmission.second_contact_no = _studentAdmission.second_contact_no;
        studentAdmission.record_created_by = 1;
        studentAdmissionBLL.AddStudentAdmission(_studentAdmission);


        return studentAdmission;
    }

    [WebMethod]
    public static StudentAdmission Put(StudentAdmission _studentAdmission)
    {
        StudentAdmissionBLL studentAdmissionBLL = new StudentAdmissionBLL();
        StudentAdmission studentAdmission = new StudentAdmission();
        studentAdmission.student_admission_id = _studentAdmission.student_admission_id;
        studentAdmission.full_name = _studentAdmission.full_name;
        studentAdmission.admission_date = _studentAdmission.admission_date;
        studentAdmission.class_id = _studentAdmission.class_id;
        studentAdmission.gender_id = _studentAdmission.gender_id;
        studentAdmission.date_of_birth = _studentAdmission.date_of_birth;
        studentAdmission.academic_year_id = _studentAdmission.academic_year_id;
        studentAdmission.district_id = _studentAdmission.district_id;
        studentAdmission.present_address = _studentAdmission.present_address;
        studentAdmission.parmanent_address = _studentAdmission.parmanent_address;
        studentAdmission.first_contact_no = _studentAdmission.first_contact_no;
        studentAdmission.second_contact_no = _studentAdmission.second_contact_no;
        studentAdmissionBLL.UpdateStudentAdmission(studentAdmission);


        return studentAdmission;
    }

    [WebMethod]
    public static string Get()
    {
        DistrictBLL districtBll=new DistrictBLL();
        SessionYearBLL sessionYearBll=new SessionYearBLL();
        ClassBLL classBll=new ClassBLL();

        StudentAdmissionBLL studentAdmissionBLL = new StudentAdmissionBLL();
        DataSet ds = new DataSet();
        ds = studentAdmissionBLL.GetStudentAdmission();

        var studentAdmissionList = from S in ds.Tables[0].Select()
            select new
            {
                student_admission_id = S["student_admission_id"],
                registration_no = S["registration_no"],
                full_name = S["full_name"],
                admission_date =Convert.ToDateTime(S["admission_date"]).ToLongDateString() ,
                class_id = S["class_id"],
                class_name = S["class_name"],
                gender_id = S["gender_id"],
                gender_name = S["gender_name"],
                date_of_birth = Convert.ToDateTime(S["date_of_birth"]).ToLongDateString(),
                academic_year_id = S["academic_year_id"],
                academic_year = S["academic_year"],
                district_id = S["district_id"],
                district_name = S["district_name"],
                present_address = S["present_address"],
                parmanent_address = S["parmanent_address"],
                first_contact_no = S["first_contact_no"],
                second_contact_no = S["second_contact_no"]

            };

        object o = new
        {
            ClasseList=classBll.GetClassList(),
            SessionYearList=sessionYearBll.GetSessionYearList(),
            DistrictList = districtBll.GetDistrictList(),
            StudentAdmissionList = studentAdmissionList
        };

        return new JavaScriptSerializer().Serialize(o);

        // List<Object> especialidades = new List<Object>();

        // especialidades.Add(new
        // {
        //     text = "Dermatología",
        //     id = "1"
        // });

        // especialidades.Add(new
        // {
        //     text = "Medicina General",
        //     id = "2"
        // });

        // Object o = new
        // {
        //     total = especialidades.Count,
        //     especialidades = especialidades
        // };

        // var oSerializer = new System.Web.Script.Serialization.JavaScriptSerializer();
        //// Context.Response.Write(oSerializer.Serialize(o));
    }
}