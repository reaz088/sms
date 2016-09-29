using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using SM.BusinessObjects;
using SM.BLL;
using SM.DAL;
using System.Data;
using System.Net;
using System.Runtime.Remoting.Contexts;
using System.Web.Script.Serialization;

public partial class BasicSetup_Class : System.Web.UI.Page
{
   
    protected void Page_Load(object sender, EventArgs e)
    {
         
    }

    [WebMethod]
    public static Class Save(Class _class)
    {
        ClassBLL classBll = new ClassBLL();
        Class classObj = new Class();
        classObj.class_name = _class.class_name;
        classObj.short_name = _class.short_name;
        classBll.AddClass(classObj);

        
        return classObj;
    }

    [WebMethod]
    public static Class Put(Class _class)
    {
        ClassBLL classBll = new ClassBLL();
        Class classObj = new Class();
        classObj.class_name = _class.class_name;
        classObj.short_name = _class.short_name;
        classObj.class_id = _class.class_id;
        classObj.teacher_id = _class.teacher_id;
        classBll.UpdateClass(classObj);

        
        return classObj;
    }

    [WebMethod]
    public static string Get()
    {
        TeacherBLL teacherBLL = new TeacherBLL();
        ClassBLL classBll = new ClassBLL();
        DataSet ds = new DataSet();
        ds = classBll.GetClass();

        var classList = from c in ds.Tables[0].Select()
            select new
            {
                class_id = c["class_id"],
                class_name = c["class_name"],
                short_name = c["short_name"],
                teacher_id = c["teacher_id"],
                teacher_name = c["teacher_name"]
            };

        object o = new
        {
            TeacherList = teacherBLL.GetTeacherList(),
            ClassList = classList
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