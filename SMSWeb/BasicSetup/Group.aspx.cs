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

public partial class BasicSetup_Group : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    [WebMethod]
    public static Group Save(Group _group)
    {
        GroupBLL groupBll = new GroupBLL();
        Group groupObj = new Group();
        groupObj.group_name = _group.group_name;
        
        groupBll.AddGroup(groupObj);


        return groupObj;
    }

    [WebMethod]
    public static Group Put(Group _group)
    {
        GroupBLL groupBll = new GroupBLL();
        Group groupObj = new Group();
        groupObj.group_name = _group.group_name;
       
        groupObj.group_id = _group.group_id;
       
        groupBll.UpdateGroup(groupObj);


        return groupObj;
    }

    [WebMethod]
    public static string Get()
    {

        GroupBLL groupBll = new GroupBLL();
        DataSet ds = new DataSet();
        ds = groupBll.GetGroup();

        object o = new
        {
            totla = 5000,
            GroupList = groupBll.GetGroupList()
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