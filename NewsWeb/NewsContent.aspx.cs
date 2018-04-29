using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BLL;

public partial class NewsContent : System.Web.UI.Page
{
    string id;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["ID"]!=null)
            {
                id = Request.QueryString["ID"];
                Bind();
            }
            else
            {
                Response.Redirect("NewsTitle.aspx");
            }
        }
    }

    public void Bind()
    {
        DataTable dt = BLL.NewsManager.ContentManager(id);
        Label1.Text = dt.Rows[0]["Title"].ToString();
        Label2.Text = Convert.ToDateTime(dt.Rows[0]["PubTime"]).ToString("yyyy年MM月dd日 hh:mm:ss");
        Label3.Text = dt.Rows[0]["Content"].ToString();
    }
}