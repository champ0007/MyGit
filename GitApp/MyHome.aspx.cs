﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GitApp
{
    public partial class MyHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //This is PageLoad
            var x = 30;
            Response.Write("This is not Awesome");
            //Wow this is Awesome
        }
    }
}
