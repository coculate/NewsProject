using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

public partial class NewsTitle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            RepBind();
        }
    }

    public void RepBind()
    {
        RPT_Title.DataSource = BLL.NewsManager.RepBindManager();
        RPT_Title.DataBind();
    }
}