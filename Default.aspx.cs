using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebMatrix.Data;
 

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            doload();
        }
    }

    private void doload()
    {
        string URL = "eb_GxIrpl45";
        //URL = RandomURL.GetURL();
        var db = Database.Open("StarterSite");
        if (db.Query("SELECT * FROM RandomUrls WHERE ShortUrl = @0", URL).Count() > 0)
        {
            // Generate a new URL because the previous one had a match.
            URL = RandomURL.GetURL();
        }

        foreach (var row in Database.Open("StarterSite").Query("SELECT * FROM RandomUrls"))
        {
            string rownam = @row.ShortUrl;
            string rownam1 = @row.UrlString;
            //< li >< a href = "~/redirect/@row.ShortUrl" > https://slgl.in/@row.ShortUrl</a></li>
        }
    }
}