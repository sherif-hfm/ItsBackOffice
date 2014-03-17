using BackOfficeBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using BackOfficeUI.Controls;
using System.Windows.Forms;
using System.Reflection;
namespace BackOfficeUI
{
    public partial class frmMenu : System.Windows.Forms.Form
    {

        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            lblUser.Text = "User : " + AppInfo.CurrentUser.Name;
            ViewUserMenu();
        }

        private void ViewUserMenu()
        {
            foreach (var userMenuItem in AppInfo.CurrentUser.UserMenuItems.OrderBy(m => m.MenuID))
            {
                Controls.ToolStripMenuItem menuItem = new Controls.ToolStripMenuItem();
                menuItem.Text = userMenuItem.Text;
                menuItem.Name = userMenuItem.MenuID;
                menuItem.MenuID = userMenuItem.MenuID;
                menuItem.FormName = userMenuItem.FormName;
                menuItem.FormOption = userMenuItem.FormOption;
                if (userMenuItem.ParentMenuID != null)
                {
                    var existMenuItems = menuBar.Items.Find(userMenuItem.ParentMenuID, true);
                    if (existMenuItems.Length > 0)
                    {
                        var existMenuItem = (Controls.ToolStripMenuItem)existMenuItems.First();
                        if (userMenuItem.SplitBefore == true)
                            existMenuItem.DropDownItems.Add(new Controls.ToolStripSeparator());
                        if (userMenuItem.ShowInMenuBar == true)
                            existMenuItem.DropDownItems.Add(menuItem);
                    }
                }
                else
                {
                    if (userMenuItem.ShowInMenuBar == true)
                        menuBar.Items.Add(menuItem);
                }
                if (userMenuItem.ShowInToolBar == true)
                {
                    Controls.ToolStripButton btn = new Controls.ToolStripButton();
                    btn.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                    btn.Text = userMenuItem.TooBarText;
                    btn.AutoSize = false;
                    btn.TextImageRelation = TextImageRelation.ImageAboveText;
                    btn.ImageScaling = ToolStripItemImageScaling.None;
                    if (string.IsNullOrEmpty(userMenuItem.ToolBarImage) == true)
                        btn.Image = Resource.Database;
                    btn.Width = 60;
                    btn.Height = 60;
                    toolBar.Items.Add(btn);
                }
                menuItem.Click += menuItem_Click;
            }
        }

        void menuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Controls.ToolStripMenuItem menuItem = (Controls.ToolStripMenuItem)sender;
                if (string.IsNullOrEmpty(menuItem.FormName) == false)
                {
                    if (menuItem.FormName != "Code")
                    {
                        string frmName = AppInfo.ApplicationUINamespace + "." + menuItem.FormName;
                        var frm = (Controls.frmBase)Assembly.GetExecutingAssembly().CreateInstance(frmName);
                        frm.FormID = menuItem.MenuID;
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else 
                    {
                        switch (menuItem.FormOption)
                        { 
                            case "Exit":
                                Environment.Exit(0);
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }
    }
}
