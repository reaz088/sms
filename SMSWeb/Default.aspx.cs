using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SM.BusinessObjects;
using SM.BLL;
using System.Web.Services;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        UserGroup userGroup = new UserGroup();
        UserGroupBLL userGroupBLL=new UserGroupBLL();
        userGroup.user_group = TextBox1.Text;

        userGroupBLL.AddUserGroup(userGroup);
        
    }

    [WebMethod]
    public static Class Save(string ClassName)
    {
        Class classObj = new Class();
        classObj.class_name = ClassName;
        classObj.class_id = classObj.class_id + 1;


        return classObj;
    }


    [WebMethod]
    public static string GetEmployees()
    {
        return "Hello World";
    }  
}