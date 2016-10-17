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

public partial class BasicSetup_ExamEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    [WebMethod]
    public static Exam Save(Exam _exam)
    {
        ExamBLL examBLL = new ExamBLL();
        Exam exam = new Exam();
        exam.exam_name = _exam.exam_name;
        examBLL.AddExam(exam);


        return exam;
    }

    [WebMethod]
    public static Exam Put(Exam _exam)
    {
        ExamBLL examBLL = new ExamBLL();
        Exam exam = new Exam();
        exam.exam_name = _exam.exam_name;
        exam.exam_id = _exam.exam_id;
        examBLL.UpdateExam(exam);


        return exam;
    }

    [WebMethod]
    public static string Get()
    {

        ExamBLL examBLL = new ExamBLL();

        object o = new
        {
            ExamList = examBLL.GetExamList()
        };

        return new JavaScriptSerializer().Serialize(o);
    }
}