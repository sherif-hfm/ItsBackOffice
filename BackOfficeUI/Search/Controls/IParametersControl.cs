using BackOfficeBL.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackOfficeUI.Search.Controls
{
    public interface IParametersControl
    {
        SearchParameterProperties SearchParameter { get; set; }
        System.Windows.Forms.ComboBox CompareOrderControl { get; set; }

        string GetCondition();

        void UpdateDataParameters();
    }
}
