using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services.Protocols;
using System.Data.SqlClient;


namespace WavecellTest
{
    public partial class SenderForm : System.Web.UI.Page
    {
        DBCon dbCon = new DBCon();

        protected void Page_Load(object sender, EventArgs e)
        {
          
            //using (SqlConnection conn = dbCon.GetConnection())
            //{
            //    conn.Open();

            //    using (SqlCommand cmd = conn.CreateCommand())
            //    {
            //        string query = "SELECT aspnet_Membership.Email FROM aspnet_Users INNER JOIN " +
            //             "aspnet_Membership ON aspnet_Users.UserId = aspnet_Membership.UserId " +
            //             "WHERE (aspnet_Users.UserName = 'jerson')";

            //        cmd.CommandText = query;

            //        using (SqlDataReader dtReader = cmd.ExecuteReader())
            //        {
            //            if (dtReader.HasRows)
            //            {
            //                dtReader.Read();

            //                ClientScript.RegisterStartupScript(this.GetType(), "Popup", "ShowPopup('" + dtReader["email"] + "');", true);
            //            }
            //        }
            //    }
            //}
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                string source = txtSource.Text;
                string destination = txtDes.Text.Replace(" ", string.Empty).Replace("+", string.Empty);
                string body = txtBody.Text;

                //Wavecell.SendSoapClient sm = new Wavecell.SendSoapClient("SendSoap");
                //string response = sm.SendMT("gmail_com96", "gmail_com96_hq", "wavecell123", "0", destination, "wavecellTest", body, "Unicode", "0");
                //////Console.WriteLine("Response:" + response);

                ClientScript.RegisterStartupScript(this.GetType(), "Popup", "ShowPopup('sdfdsf');", true);
            }
            catch (SoapException se)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Popup", "ShowPopup('" + se + "');", true);
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Popup", "ShowPopup('" + ex + "');", true);
            }

           
        }

    }
}