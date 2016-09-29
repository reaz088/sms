using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using SM.BusinessObjects;
using SM.DAL;

namespace SM.BLL
{
	public class ModuleBLL
	{
		private ModuleDAL _moduleDAL;

		public ModuleDAL moduleDAL
		{
            get { return _moduleDAL; }
            set { _moduleDAL = value; }
		}

        public ModuleBLL()
		{
			moduleDAL = new ModuleDAL();
		}
		
		public DataSet GetModules()
		{
			try
			{
				return moduleDAL.GetModules();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public Module GetModule(int moduleID)
		{
			try
			{
                return moduleDAL.GetModule(moduleID);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}


        public DataSet PModuleGet(int usergroupID)
		{
			try
			{
                return moduleDAL.PModuleGet(usergroupID);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public int AddModule(Module module)
		{
			try
			{
                return moduleDAL.AddModule(module);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int UpdateModule(Module module)
		{
			try
			{
                return moduleDAL.UpdateModule(module);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int RemoveModule(Module module)
		{
			try
			{
                return moduleDAL.RemoveModule(module);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int RemoveModule(int moduleID)
		{
			try
			{
                return moduleDAL.RemoveModule(moduleID);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		
	}
}
