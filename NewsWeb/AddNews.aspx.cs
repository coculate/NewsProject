using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using MODELS;
public partial class AddNews : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DDLBind();
        }
    }
    /// <summary>
    /// 绑定新闻列表
    /// </summary>
    public void DDLBind()
    {
        DDL_Type.DataSource = BLL.NewsManager.DDLBindManager();
        DDL_Type.DataTextField = "TypeName";
        DDL_Type.DataValueField = "TypeId";
        DDL_Type.DataBind();
    }
    /// <summary>
    /// 添加新闻
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void BTN_Add_Click(object sender, EventArgs e)
    {
        NewsInfo ni = new NewsInfo();
        ni.Title = TXT_Title.Text;
        ni.Author = TXT_Author.Text;
        ni.Content = TXT_Con.Text;
        ni.PubTime = DateTime.Now;
        ni.TypeId = Convert.ToInt32(DDL_Type.SelectedValue);
        if (BLL.NewsManager.AddNewsManager(ni))
        {
            Response.Write("<script>alert('添加成功');location = 'NewsTitle.aspx';</script>");
        }
        else
        {
            Response.Write("<script>alert('添加失败');</script>");
        }
    }
}