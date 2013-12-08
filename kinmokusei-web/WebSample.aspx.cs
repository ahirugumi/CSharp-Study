
namespace kinmokuseiweb
{
	using System;
	using System.Web;
	using System.Web.UI;

	public partial class WebSample : System.Web.UI.Page
	{
		protected void submit_click(object sender, EventArgs e)
		{
			label.Text = textbox.Text;
		}
	}
}

