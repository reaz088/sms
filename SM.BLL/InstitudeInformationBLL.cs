using SM.BusinessObjects;
using SM.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SM.BLL
{
    public class InstitudeInformationBLL
    {
        private InstitudeInformationDAL _institudeInformationDAL;

        public InstitudeInformationDAL institudeInformationDAL
        {
            get { return _institudeInformationDAL; }
            set { _institudeInformationDAL = value; }
        }

        public InstitudeInformationBLL()
        {
            institudeInformationDAL=new InstitudeInformationDAL();
        }

        public int AddInstitudeInformation(InstitudeInformation  institude_information)
        {
            try
            {
                return institudeInformationDAL.AddInstitudeInformation(institude_information);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int UpdateInstitudeInformation(InstitudeInformation  institude_information)
        {
            try
            {
                return institudeInformationDAL.UpdateInstitudeInformation(institude_information);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<InstitudeInformation> GetInstitudeInformationList()
        {
            try
            {
                return institudeInformationDAL.GetInstitudeInformationList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet GetInstitudeInformation()
        {
            try
            {
                return institudeInformationDAL.GeInstitudeInformations();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
