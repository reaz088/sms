using SM.BusinessObjects;
using SM.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SM.BLL
{
    public  class SectionBLL
    {
        private SectionDAL _sectionDAL;

        public SectionDAL sectionDAL
        {
            get { return _sectionDAL; }
            set { _sectionDAL = value; }
        }

        public SectionBLL()
        {
            sectionDAL=new SectionDAL();
        }

        public int AddSection(Section section)
        {
            try
            {
                return sectionDAL.AddSection(section);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int UpdateSection(Section section)
        {
            try
            {
                return sectionDAL.UpdateSection(section);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Section> GetSectionList()
        {
            try
            {
                return sectionDAL.GetSectionList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet GetSection()
        {
            try
            {
                return sectionDAL.GeSections();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
