﻿using Common;
using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRM
{
    public partial class Index : System.Web.UI.Page
    {
        public string appName = CommonHelper.AppName;
        public User user;
        public List<MenuTree> menus;

        protected void Page_Load(object sender, EventArgs e)
        {
            user = CommonHelper.User;
            if (user == null)
                Response.Redirect("./Login.aspx");
            menus = new MenuDAL().getMenuTree(user.ID);

            //AuthorityDAL authority = new AuthorityDAL
            //foreach (var item in collection)
            //{

            //}
        }
    }
}