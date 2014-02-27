﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TaskManager
{
    public partial class SiteMaster : MasterPage
    {
        protected int PersonId
        {
            get
            {
                if (Session["PersonID"] == null)
                {
                    Session["PersonID"] = 4;
                }
                return (int)Session["PersonID"];
            }
        }
        protected int ProjectId
        {
            get
            {
                if (Session["ProjectID"] == null)
                {
                    Session["ProjectID"] = 4;
                }
                return (int)Session["ProjectID"];
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}