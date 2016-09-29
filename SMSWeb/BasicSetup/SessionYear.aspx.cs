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

public partial class BasicSetup_SessionYear : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    [WebMethod]
    public static SessionYear Save(SessionYear _sessionYear)
    {
        SessionYearBLL sessionYearBLL = new SessionYearBLL();
        SessionYear sessionYear = new SessionYear();
        sessionYear.start_on = _sessionYear.start_on;
        sessionYear.ends_on = _sessionYear.ends_on;
        sessionYear.description = _sessionYear.description;
        sessionYear.status = _sessionYear.status;
        sessionYearBLL.AddSessionYear(_sessionYear);


        return sessionYear;
    }

    [WebMethod]
    public static SessionYear Put(SessionYear _sessionYear)
    {
        SessionYearBLL sessionYearBLL = new SessionYearBLL();
        SessionYear sessionYear = new SessionYear();
        sessionYear.session_id = _sessionYear.session_id;
        sessionYear.start_on = _sessionYear.start_on;
        sessionYear.ends_on = _sessionYear.ends_on;
        sessionYear.description = _sessionYear.description;
        sessionYear.status = _sessionYear.status;

        sessionYearBLL.UpdateSessionYear(sessionYear);


        return sessionYear;
    }

    [WebMethod]
    public static List<object> Get()
    {

        SessionYearBLL sessionYearBLL = new SessionYearBLL();
        DataSet ds=new DataSet();
        ds = sessionYearBLL.GetSessionYear();
        List<object> rtn = new List<object>();

        var xy = from vals in ds.Tables[0].Select()
                select new
                {
                    session_id = vals["session_id"],
                    start_on =Convert.ToDateTime(vals["start_on"]).ToShortDateString(),
                    ends_on =Convert.ToDateTime(vals["ends_on"]).ToShortDateString(),
                    description = vals["description"],
                    status = vals["status"]
                };
        rtn.AddRange(xy);

        return  rtn;
        //List<DataRow> drlist = new List<DataRow>();

        //foreach (DataRow row in ds.Tables[0].Rows)
        //{
        //    drlist.Add((DataRow)row);
        //}
                //////var x = sessionYearBLL.GetSessionYearList();

                //////var y = from a in x
                //////        select new
                //////        {
                //////            a.session_id,
                //////            start_on = a.start_on.ToLongDateString(),
                //////            ends_on = a.ends_on.ToLongDateString(),
                //////            a.description,
                //////            a.status

                //////        };
                //////return new JavaScriptSerializer().Serialize(xy);

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