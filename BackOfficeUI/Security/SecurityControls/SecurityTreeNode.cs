using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackOfficeUI.Security.SecurityControls
{
    class SecurityTreeNode : System.Windows.Forms.TreeNode
    {
        public BackOfficeBL.Security.MenuItem MenuItem { get; set; }
        public int GroupAllowedFunctions { get; set; }

        public SecurityTreeNode()
        { 
            
        }
    }
}
