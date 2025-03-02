using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;

namespace _3ASP20118803
{
    public partial class form2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Retrieve the session variables.
            ddlCategory.SelectedValue = Session["ddlCategory"].ToString();
            ddlSupplier.SelectedValue = Session["ddlSupplier"].ToString();
            lblProduct.Text = Session["strProduct"].ToString();
            txtDescription.Text = Session["strDescription"].ToString();
            lblImage.Text = Session["strImage"].ToString();
            Decimal decPrice =
                Convert.ToDecimal(Session["decPrice"]);
            lblPrice.Text = decPrice.ToString("c");
            lblNumberInStock.Text = Session["bytNumberInStock"].ToString();
            lblNumberOnOrder.Text = Session["bytNumberOnOrder"].ToString();
            lblReorderLevel.Text = Session["bytReorderLevel"].ToString();
            Byte bytNumberInStock =
                Convert.ToByte(Session["bytNumberInStock"]);
            Byte bytNumberOnOrder =
                Convert.ToByte(Session["bytNumberOnOrder"]);

            Decimal deValueInStock = decPrice * bytNumberInStock;
            Decimal deValueOnOrder = decPrice * bytNumberOnOrder;
            lblNumberInStock.Text = deValueInStock.ToString("c");
            lblNumberOnOrder.Text = deValueOnOrder.ToString("c");


        }
    }
}