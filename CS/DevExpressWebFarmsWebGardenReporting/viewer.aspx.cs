using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevExpressWebFarmsWebGardenReporting {
    public partial class viewer : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            ASPxWebDocumentViewer1.OpenReport("Invoice");
        }
    }
}