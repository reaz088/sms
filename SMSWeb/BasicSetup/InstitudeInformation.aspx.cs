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

public partial class BasicSetup_InstitudeInformation : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    [WebMethod]
    public static InstitudeInformation Save(InstitudeInformation _institudeInformation)
    {
        InstitudeInformationBLL institudeInformationBLL = new InstitudeInformationBLL();
        InstitudeInformation institudeInformation = new InstitudeInformation();


        institudeInformation.institude_name = _institudeInformation.institude_name;
        institudeInformation.institude_address = _institudeInformation.institude_address;
        institudeInformation.institude_email = _institudeInformation.institude_email;
        institudeInformation.institude_phone = _institudeInformation.institude_phone;
        institudeInformation.admin_contact_person = _institudeInformation.admin_contact_person;

        institudeInformationBLL.AddInstitudeInformation(institudeInformation);


        return institudeInformation;
    }

    [WebMethod]
    public static InstitudeInformation Put(InstitudeInformation _institudeInformation)
    {
        InstitudeInformationBLL institudeInformationBLL = new InstitudeInformationBLL();
        InstitudeInformation institudeInformation = new InstitudeInformation();
        institudeInformation.institude_name = _institudeInformation.institude_name;
        institudeInformation.institude_address = _institudeInformation.institude_address;
        institudeInformation.institude_email = _institudeInformation.institude_email;
        institudeInformation.institude_phone = _institudeInformation.institude_phone;
        institudeInformation.admin_contact_person = _institudeInformation.admin_contact_person;
        institudeInformation.institude_information_id = _institudeInformation.institude_information_id;

        institudeInformationBLL.UpdateInstitudeInformation(institudeInformation);


        return institudeInformation;
    }

    [WebMethod]
    public static string Get()
    {

        InstitudeInformationBLL institudeInformationBLL = new InstitudeInformationBLL();
        DataSet ds = new DataSet();
        ds = institudeInformationBLL.GetInstitudeInformation();

        object o = new
        {
            totla = 5000,
            InstitudeInformationList = institudeInformationBLL.GetInstitudeInformationList()
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