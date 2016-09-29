using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM.BusinessObjects
{
    [Serializable()]
    public class InstitudeInformation
    {
        private int _institude_information_id;
        public int institude_information_id
        {
            get { return _institude_information_id; }
            set { _institude_information_id = value; }
        }

        private string _institude_name;

        public string institude_name
        {
            get { return _institude_name; }
            set { _institude_name = value; }
        }


        private string _institude_address;
        public string institude_address
        {
            get { return _institude_address; }
            set { _institude_address = value; }
        }
        private string _institude_email;
        public string institude_email
        {
            get { return _institude_email; }
            set { _institude_email = value; }
        }
        private string _institude_phone;
        public string institude_phone
        {
            get { return _institude_phone; }
            set { _institude_phone = value; }
        }
        private string _admin_contact_person;
        public string admin_contact_person
        {
            get { return _admin_contact_person; }
            set { _admin_contact_person = value; }
        }
        public InstitudeInformation()
        { }
        public InstitudeInformation(int institude_information_id,string institude_name, string institude_address, string institude_email, string institude_phone, string admin_contact_person)
        {
            this.institude_information_id = institude_information_id;
            this.institude_name = institude_name;
            this.institude_address = institude_address;
            this.institude_email = institude_email;
            this.institude_phone = institude_phone;
            this.admin_contact_person = admin_contact_person;
        }
        public override string ToString()
        {
            return "institude_information_id = " + institude_information_id.ToString() +"institude_name ="+institude_name.ToString()+ "institude_address = " + institude_address.ToString() + "institude_email = " + institude_email.ToString() + "institude_phone = " + institude_phone.ToString() + "admin_contact_person = " + admin_contact_person.ToString();
        }
        public class institude_information_idComparer : System.Collections.Generic.IComparer<InstitudeInformation>
        {
            public SorterMode SorterMode;
            public institude_information_idComparer()
            { }
            public institude_information_idComparer(SorterMode SorterMode)
            {
                this.SorterMode = SorterMode;
            }
            #region IComparer<InstitudeInformation> Membres
            int System.Collections.Generic.IComparer<InstitudeInformation>.Compare(InstitudeInformation x, InstitudeInformation y)
            {
                if (SorterMode == SorterMode.Ascending)
                {
                    return y.institude_information_id.CompareTo(x.institude_information_id);
                }
                else
                {
                    return x.institude_information_id.CompareTo(y.institude_information_id);
                }
            }
            #endregion
        }
    }
}

