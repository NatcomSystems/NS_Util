using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NS.TraceWrapper;

namespace WebTest
{
    public partial class FrmTest : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                throw new Exception("Excepcion Test");
            }
            catch (Exception ex)
            {
                ExceptionTrace.Write(ex);
                // Incluir manejo de excepcion
            }
        }
    }
}