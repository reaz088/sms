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

public partial class BasicSetup_Occupation : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    [WebMethod]
    public static Occupation Save(Occupation _occupation)
    {
        OccupationBLL occupationBLL = new OccupationBLL();
        Occupation occupation = new Occupation();
        occupation.occupation_name = _occupation.occupation_name;
        occupationBLL.AddOccupation(_occupation);


        return occupation;
    }

    [WebMethod]
    public static Occupation Put(Occupation _occupation)
    {
        OccupationBLL occupationBLL = new OccupationBLL();
        Occupation occupation = new Occupation();
        occupation.occupation_name = _occupation.occupation_name;
        occupation.occupation_id = _occupation.occupation_id;
        occupationBLL.UpdateOccupation(occupation);


        return occupation;
    }

    [WebMethod]
    public static string Get()
    {

        OccupationBLL occupationBLL = new OccupationBLL();
        DataSet ds = new DataSet();
        ds = occupationBLL.GetOccupation();

        object o = new
        {
            totla = 5000,
            OccupationList = occupationBLL.GetOccupationList()
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