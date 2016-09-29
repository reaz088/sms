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

public partial class BasicSetup_Section : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    [WebMethod]
    public static Section Save(Section _section)
    {
        SectionBLL sectionBLL = new SectionBLL();
        Section section = new Section();
        section.section_name = _section.section_name;
        section.section_short_name = _section.section_short_name;
        section.class_id = _section.class_id;
        section.teacher_id = _section.teacher_id;
        sectionBLL.AddSection(_section);


        return section;
    }

    [WebMethod]
    public static Section Put(Section _section)
    {
        SectionBLL sectionBLL = new SectionBLL();
        Section section = new Section();
        section.section_name = _section.section_name;
        section.section_short_name = _section.section_short_name;
        section.class_id = _section.class_id;
        section.teacher_id = _section.teacher_id;
        section.section_id = _section.section_id;
        sectionBLL.UpdateSection(section);


        return section;
    }

    [WebMethod]
    public static string Get()
    {
        TeacherBLL teacherBLL = new TeacherBLL();
        ClassBLL classBll = new ClassBLL();
        SectionBLL sectionBLL = new SectionBLL();
        DataSet ds = new DataSet();
        ds = sectionBLL.GetSection();
        var sectionList = from s in ds.Tables[0].Select()
            select new
            {
                section_id = s["section_id"],
                section_name = s["section_name"],
                section_short_name = s["section_short_name"],
                class_id = s["class_id"],
                teacher_id = s["teacher_id"],
                class_name = s["class_name"],
                teacher_name = s["teacher_name"]
            };
        object d = new
        {
            ClassList = classBll.GetClassList(),
            TeacherList = teacherBLL.GetTeacherList(),
            SectionList = sectionList
        };

        return new JavaScriptSerializer().Serialize(d);

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