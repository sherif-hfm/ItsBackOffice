using BackOfficeDAL;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace BackOfficeBL.Security
{
    public class MenuItem
    {
        public string MenuID { get; set; }
        public string Text { get { return GetMenuItemText(); } }
        public string Text_Ara { get; set; }
        public string Text_Eng { get; set; }
        public string ParentMenuID { get; set; }
        public string FormName { get; set; }
        public string FormOption { get; set; }
        public int FormAllowedFunctions { get; set; }
        public Nullable<bool> SplitBefore { get; set; }
        public Nullable<bool> ShowInMenuBar { get; set; }
        public Nullable<bool> ShowInToolBar { get; set; }
        public string ToolBarImage { get; set; }
        public Nullable<int> ToolBarIndex { get; set; }
        public string TooBarText { get { return GetToolBarText(); } }
        public string TooBarText_Ara { get; set; }
        public string TooBarText_Eng { get; set; }

        public static List<MenuItem> LoadAllForms()
        {
            List<MenuItem> result = new List<MenuItem>();
            NewAppsCnn newAppsCnn = new NewAppsCnn(AppSettings.CrAppSettings.NewAppsConnectionString);
            var dbForms = from f in newAppsCnn.Sec_MainMenu orderby f.MenuID ascending select f;
            foreach (var dbForm in dbForms)
            {
                MenuItem menuItem = new MenuItem();
                menuItem.FromDbMenuItem(dbForm);
                result.Add(menuItem);
            }
            return result;
        }

        public MenuItem()
        { 
        }

        public void FromDbMenuItem(Sec_MainMenu _menuItem)
        {
            this.MenuID = _menuItem.MenuID;
            this.Text_Ara = _menuItem.Text_Ara;
            this.Text_Eng = _menuItem.Text_Eng;
            this.ParentMenuID = _menuItem.ParentMenuID;
            this.FormName = _menuItem.FormName;
            this.FormOption = _menuItem.FormOption;
            this.FormAllowedFunctions = _menuItem.FormAllowedFunctions;
            this.SplitBefore = _menuItem.SplitBefore;
            this.ShowInMenuBar = _menuItem.ShowInMenuBar;
            this.ShowInToolBar = _menuItem.ShowInToolBar;
            this.ToolBarImage = _menuItem.ToolBarImage;
            this.ToolBarIndex = _menuItem.ToolBarIndex;
            this.TooBarText_Ara = _menuItem.TooBarText_Ara;
            this.TooBarText_Eng = _menuItem.TooBarText_Eng;
        }

        public string GetMenuItemText()
        {
            CultureInfo cultureinfo = CultureInfo.CurrentUICulture;
            switch (cultureinfo.Name)
            {
                case "en-US":
                    return this.Text_Eng;
                case "ar-KW":
                    return this.Text_Ara;
                default:
                    return this.Text_Eng;
            }
        }

        public string GetToolBarText()
        {
            CultureInfo cultureinfo = CultureInfo.CurrentUICulture;
            switch (cultureinfo.Name)
            {
                case "en-US":
                    return this.TooBarText_Eng;
                case "ar-KW":
                    return this.TooBarText_Ara;
                default:
                    return this.TooBarText_Eng;
            }
        }


    }
}
