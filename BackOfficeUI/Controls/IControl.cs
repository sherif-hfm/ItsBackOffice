using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackOfficeUI.Controls
{
    public interface IControl
    {
        int LockedInModes { get; set; }
        bool IsRequired { get; set; }
        bool Clearable { get; set; }


        void Lock();
        void UnLock();
        bool IsEmpty();
        void ClearData();

    }
}
