using System.Diagnostics;

namespace Menú_comida_1
{
    public partial class Cafeteria : Form
    {
        public Cafeteria()
        {
            InitializeComponent();
        }

        //var
        const double precio_pandedulce = 30;
        const double precio_panini = 100;
        const double precio_ensalada = 120;
        const double precio_sandwich = 85;
        const double precio_alfajor = 35;
        const double precio_pastel = 55;
        const double precio_americano = 30;
        const double precio_latte = 45;
        const double precio_expreso = 30;
        const double precio_chocolate = 50;
        const double precio_te = 30;
        const double precio_irlandes = 70;
        const double precio_malteada = 75;
        const double precio_frappe = 65;
        const double precio_tehelado = 35;
        const double precio_smoothie = 45;
        const double precio_sodaitaliana = 40;
        const double precio_coldblew = 40;
        const double iva = 16;
        double total;

        private void bebidasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        private void LimpiarTextBox()
        {
            Action<Control.ControlCollection> funcion = null;
            funcion = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is TextBox)
                    {
                        (control as TextBox).Text = "0";
                    }
                    else
                    {
                        funcion(control.Controls);
                    }


                }
            };
            funcion(Controls);
        }

        private void LimpiarCheckBox()
        {
            Action<Control.ControlCollection> funcion = null;
            funcion = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is CheckBox)
                    {
                        (control as CheckBox).Checked = false;
                    }
                    else
                    {
                        funcion(control.Controls);
                    }


                }
            };
            funcion(Controls);
        }

        private void DeshabilitarTextBox()
        {
            Action<Control.ControlCollection> funcion = null;
            funcion = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is TextBox)
                    {
                        (control as TextBox).Enabled = false;
                    }
                    else
                    {
                        funcion(control.Controls);
                    }


                }
            };
            funcion(Controls);
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTextBox();
            LimpiarCheckBox();
            DeshabilitarTextBox();
        }

        private void Cafeteria_Load(object sender, EventArgs e)
        {
            DeshabilitarTextBox();
        }

        private void chkpandulce_CheckedChanged(object sender, EventArgs e)
        {
            if (chkpandulce.Checked == true)
            {
                textpandulce.Enabled = true;
                textpandulce.Text = "";
                textpandulce.Focus();
            }
            else
            {
                textpandulce.Enabled = false;
                textpandulce.Text = "0";
            }
        }

        private void chkpanini_CheckedChanged(object sender, EventArgs e)
        {
            if (chkpanini.Checked == true)
            {
                textpanini.Enabled = true;
                textpanini.Text = "";
                textpanini.Focus();
            }
            else
            {
                textpanini.Enabled = false;
                textpanini.Text = "0";
            }
        }

        private void chlensalada_CheckedChanged(object sender, EventArgs e)
        {
            if (chkensalada.Checked == true)
            {
                textensalada.Enabled = true;
                textensalada.Text = "";
                textensalada.Focus();
            }
            else
            {
                textensalada.Enabled = false;
                textensalada.Text = "0";
            }
        }

        private void chksandwich_CheckedChanged(object sender, EventArgs e)
        {
            if (chksandwich.Checked == true)
            {
                textsandwich.Enabled = true;
                textsandwich.Text = "";
                textsandwich.Focus();
            }
            else
            {
                textsandwich.Enabled = false;
                textsandwich.Text = "0";
            }
        }

        private void chkalfajor_CheckedChanged(object sender, EventArgs e)
        {
            if (chkalfajor.Checked == true)
            {
                textalfajor.Enabled = true;
                textalfajor.Text = "";
                textalfajor.Focus();
            }
            else
            {
                textalfajor.Enabled = false;
                textalfajor.Text = "0";
            }
        }

        private void chkpastel_CheckedChanged(object sender, EventArgs e)
        {
            if (chkpastel.Checked == true)
            {
                textpastel.Enabled = true;
                textpastel.Text = "";
                textpastel.Focus();
            }
            else
            {
                textpastel.Enabled = false;
                textpastel.Text = "0";
            }
        }

        private void chkamericano_CheckedChanged(object sender, EventArgs e)
        {
            if (chkamericano.Checked == true)
            {
                textamericano.Enabled = true;
                textamericano.Text = "";
                textamericano.Focus();
            }
            else
            {
                textamericano.Enabled = false;
                textamericano.Text = "0";
            }
        }

        private void chklatte_CheckedChanged(object sender, EventArgs e)
        {
            if (chklatte.Checked == true)
            {
                textlatte.Enabled = true;
                textlatte.Text = "";
                textlatte.Focus();
            }
            else
            {
                textlatte.Enabled = false;
                textlatte.Text = "0";
            }
        }

        private void chkexpreso_CheckedChanged(object sender, EventArgs e)
        {
            if (chkexpreso.Checked == true)
            {
                textexpreso.Enabled = true;
                textexpreso.Text = "";
                textexpreso.Focus();
            }
            else
            {
                textexpreso.Enabled = false;
                textexpreso.Text = "0";
            }
        }

        private void chkchocolate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkchocolate.Checked == true)
            {
                textchocolate.Enabled = true;
                textchocolate.Text = "";
                textchocolate.Focus();
            }
            else
            {
                textchocolate.Enabled = false;
                textchocolate.Text = "0";
            }
        }

        private void chkte_CheckedChanged(object sender, EventArgs e)
        {
            if (chkte.Checked == true)
            {
                textte.Enabled = true;
                textte.Text = "";
                textte.Focus();
            }
            else
            {
                textte.Enabled = false;
                textte.Text = "0";
            }
        }

        private void chkirlandes_CheckedChanged(object sender, EventArgs e)
        {
            if (chkirlandes.Checked == true)
            {
                textirlandes.Enabled = true;
                textirlandes.Text = "";
                textirlandes.Focus();
            }
            else
            {
                textirlandes.Enabled = false;
                textirlandes.Text = "0";
            }
        }

        private void chkmalteada_CheckedChanged(object sender, EventArgs e)
        {

            if (chkmalteada.Checked == true)
            {
                textmalteada.Enabled = true;
                textmalteada.Text = "";
                textmalteada.Focus();
            }
            else
            {
                textmalteada.Enabled = false;
                textmalteada.Text = "0";
            }
        }

        private void chkfrappe_CheckedChanged(object sender, EventArgs e)
        {
            if (chkfrappe.Checked == true)
            {
                textfrappe.Enabled = true;
                textfrappe.Text = "";
                textfrappe.Focus();
            }
            else
            {
                textfrappe.Enabled = false;
                textfrappe.Text = "0";
            }
        }

        private void chktehelado_CheckedChanged(object sender, EventArgs e)
        {
            if (chktehelado.Checked == true)
            {
                texttehelado.Enabled = true;
                texttehelado.Text = "";
                texttehelado.Focus();
            }
            else
            {
                texttehelado.Enabled = false;
                texttehelado.Text = "0";
            }
        }

        private void chksmoothie_CheckedChanged(object sender, EventArgs e)
        {
            if (chksmoothie.Checked == true)
            {
                textsmoothie.Enabled = true;
                textsmoothie.Text = "";
                textsmoothie.Focus();
            }
            else
            {
                textsmoothie.Enabled = false;
                textsmoothie.Text = "0";
            }
        }

        private void chksodaitaliana_CheckedChanged(object sender, EventArgs e)
        {
            if (chksodaitaliana.Checked == true)
            {
                textsodaitaliana.Enabled = true;
                textsodaitaliana.Text = "";
                textsodaitaliana.Focus();
            }
            else
            {
                textsodaitaliana.Enabled = false;
                textsodaitaliana.Text = "0";
            }
        }

        private void chkcoldblew_CheckedChanged(object sender, EventArgs e)
        {
            if (chkcoldblew.Checked == true)
            {
                textcoldblew.Enabled = true;
                textcoldblew.Text = "";
                textcoldblew.Focus();
            }
            else
            {
                textcoldblew.Enabled = false;
                textcoldblew.Text = "0";
            }
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double[] costoElemento=new double[18];
            costoElemento[0] = Convert.ToDouble(textpandulce.Text) * precio_pandedulce;
            costoElemento[1] = Convert.ToDouble(textpanini.Text) * precio_panini;
            costoElemento[2] = Convert.ToDouble(textensalada.Text) * precio_ensalada;
            costoElemento[3] = Convert.ToDouble(textsandwich.Text) * precio_sandwich;
            costoElemento[4] = Convert.ToDouble(textalfajor.Text) * precio_alfajor;
            costoElemento[5] = Convert.ToDouble(textpastel.Text) * precio_pastel;
            costoElemento[6] = Convert.ToDouble(textamericano.Text) * precio_americano;
            costoElemento[7] = Convert.ToDouble(textlatte.Text) * precio_latte;
            costoElemento[8] = Convert.ToDouble(textexpreso.Text) * precio_expreso;
            costoElemento[9] = Convert.ToDouble(textchocolate.Text) * precio_chocolate;
            costoElemento[10] = Convert.ToDouble(textte.Text) * precio_te;
            costoElemento[11] = Convert.ToDouble(textirlandes.Text) * precio_irlandes;
            costoElemento[12] = Convert.ToDouble(textmalteada.Text) * precio_malteada;
            costoElemento[13] = Convert.ToDouble(textfrappe.Text) * precio_frappe;
            costoElemento[14] = Convert.ToDouble(texttehelado.Text) * precio_tehelado;
            costoElemento[15] = Convert.ToDouble(textsmoothie.Text) * precio_smoothie;
            costoElemento[16] = Convert.ToDouble(textsodaitaliana.Text) * precio_sodaitaliana;
            costoElemento[17] = Convert.ToDouble(textcoldblew.Text) * precio_coldblew;

            if (comboBox1.Text == "Efectivo")
            {
                total = costoElemento[0] + costoElemento[1] + costoElemento[2] + costoElemento[3] + costoElemento[4] + costoElemento[5] + costoElemento[6] + costoElemento[7] + costoElemento[8] + costoElemento[9] + costoElemento[10] + costoElemento[11] + costoElemento[12] + costoElemento[13] + costoElemento[14] + costoElemento[15] + costoElemento[16] + costoElemento[17];
                texttotal.Text = Convert.ToString(total);
            }
            else 
            {
                total = (costoElemento[0] + costoElemento[1] + costoElemento[2] + costoElemento[3] + costoElemento[4] + costoElemento[5] + costoElemento[6] + costoElemento[7] + costoElemento[8] + costoElemento[9] + costoElemento[10] + costoElemento[11] + costoElemento[12] + costoElemento[13] + costoElemento[14] + costoElemento[15] + costoElemento[16] + costoElemento[17]) * 1.16;
                texttotal.Text = Convert.ToString(total);
            }


        }
    }
}

 