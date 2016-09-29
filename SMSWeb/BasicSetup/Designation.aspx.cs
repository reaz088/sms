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

public partial class BasicSetup_Designation : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    [WebMethod]
    public static Designation Save(Designation _designation)
    {
        DesignationBLL designationBLL = new DesignationBLL();
        Designation designation = new Designation();
        designation.designation_name = _designation.designation_name;
        designation.designation_short_name = _designation.designation_short_name;
        designationBLL.AddDesignation(_designation);


        return designation;
    }

    [WebMethod]
    public static Designation Put(Designation _designation)
    {
        DesignationBLL designationBLL = new DesignationBLL();
        Designation designation = new Designation();
        designation.designation_name = _designation.designation_name;
        designation.designation_short_name = _designation.designation_short_name;
        designation.designation_id = _designation.designation_id;
        designationBLL.UpdateDesignation(designation);


        return designation;
    }

    [WebMethod]
    public static string Get()
    {

        DesignationBLL designationBLL = new DesignationBLL();
        DataSet ds = new DataSet();
        ds = designationBLL.GetDesignation();

        object o = new
        {
            totla = 5000,
            DesignationList = designationBLL.GetDesignationList()
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