using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM.BusinessObjects
{
    [Serializable()]
    public class Exam
    {
        private int _exam_id;
        public int exam_id
        {
            get { return _exam_id; }
            set { _exam_id = value; }
        }
        private string _exam_name;
        public string exam_name
        {
            get { return _exam_name; }
            set { _exam_name = value; }
        }
        public Exam()
        { }
        public Exam(int exam_id, string exam_name)
        {
            this.exam_id = exam_id;
            this.exam_name = exam_name;
        }
        //public override string ToString()
        //{
        //    return "exam_id = " + exam_id.ToString() + "exam_name = " + exam_name.ToString();
        //}
    }
}

