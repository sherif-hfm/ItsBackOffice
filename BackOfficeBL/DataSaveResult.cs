using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackOfficeBL
{
    public  class DataSaveResult
    {
        public bool SaveStatus { get; set; }
        public string ErrorMessage { get; set; }
        public object Data  { get; set; }
    }

    public class DataDeleteResult
    {
        public bool DeleteStatus { get; set; }
        public string ErrorMessage { get; set; }
    }
}
