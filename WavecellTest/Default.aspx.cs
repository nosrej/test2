using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services.Protocols;

namespace WavecellTest
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                string source = txtSource.Text;
                string destination = txtDes.Text.Replace(" ", string.Empty).Replace("+", string.Empty);
                string body = txtBody.Text;

                Wavecell.SendSoapClient sm = new Wavecell.SendSoapClient("SendSoap");
                string response = sm.SendMT("gmail_com96", "gmail_com96_hq", "wavecell123", "0", destination, "wavecellTest", body, "Unicode", "0");
                //Console.WriteLine("Response:" + response);

                if (response.Contains("RECEIVED"))
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "Popup", "ShowPopup('Message successully sent.');", true);
                    ClearFields();
                }
                else
                    ClientScript.RegisterStartupScript(this.GetType(), "Popup", "ShowPopup('" + response + "');", true);
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

        private void ClearFields()
        {
            txtSource.Text = string.Empty;
            txtDes.Text = string.Empty;
            txtBody.Text = string.Empty;
            txtDate.Text = string.Empty;
         
        }
    }
}
