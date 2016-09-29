using SM.BusinessObjects;
using SM.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SM.BLL
{
  public  class GroupBLL
    {
       private GroupDAL _groupDAL;

        public GroupDAL groupDAL
        {
            get { return _groupDAL; }
            set { _groupDAL = value; }
        }

       public GroupBLL()
       {
           groupDAL=new GroupDAL();
       }

       public int AddGroup(Group  _group)
        {
            try
            {
                return _groupDAL.AddGroup(_group);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
       public int UpdateGroup(Group _group)
        {
            try
            {
                return _groupDAL.UpdateGroup(_group);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
       public List<Group> GetGroupList()
       {
           try
           {
               return _groupDAL.GetGroupList();
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
       public DataSet GetGroup()
       {
           try
           {
               return _groupDAL.GetGroupes();
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
    }
}
