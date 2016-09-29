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

public partial class BasicSetup_District : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    [WebMethod]
    public static District Save(District _district)
    {
        DistrictBLL districtBLL = new DistrictBLL();
        District district = new District();
        district.district_name = _district.district_name;
        districtBLL.AddDistrict(_district);


        return district;
    }

    [WebMethod]
    public static District Put(District _district)
    {
        DistrictBLL districtBLL = new DistrictBLL();
        District district = new District();
        district.district_name = _district.district_name;
        district.district_id = _district.district_id;
        districtBLL.UpdateDistrict(district);


        return district;
    }

    [WebMethod]
    public static string Get()
    {

        DistrictBLL districtBLL = new DistrictBLL();
        DataSet ds = new DataSet();
        ds = districtBLL.GetDistrict();

        object o = new
        {
            totla = 5000,
            DistrictList = districtBLL.GetDistrictList()
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