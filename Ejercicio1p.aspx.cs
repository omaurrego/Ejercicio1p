using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicio1p
{
    public partial class Ejercicio1p : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void btncalcular_Click(object sender, EventArgs e)
        {
            //Variables
            double cantp, unidc, dol;
            //Datos de entrada
            cantp = Convert.ToDouble(txtpesos.Text);
            unidc = Convert.ToDouble(txtunidadc.Text);
            //Datos de proceso
            dol = cantp / unidc;
            //Datos de salida
            lblrespuesta.Text = System.Convert.ToString(dol);
        }
    }
}