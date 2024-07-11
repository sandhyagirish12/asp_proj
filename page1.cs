using System;

public partial class DisplaySessionVariable : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Session["MyVariable"] = "Hello, Session!";
            lblSessionVariable.Text = Session["MyVariable"].ToString();
        }
    }
}