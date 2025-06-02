using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioInteractivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            toolTip1.SetToolTip(txtNombre, "Escribe tu nombre completo.");
            toolTip1.SetToolTip(txtEdad, "Solo números.");
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            lblMensaje.Text = $"Hola {txtNombre.Text}";
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void chkMayorEdad_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMayorEdad.Checked)
            {
                lblMensaje.Text = "Confirmaste ser mayor de edad.";
            }
            else
            {
                lblMensaje.Text = "No confirmaste tu mayoría de edad.";
            }
        }

        private void btnRegistrar_MouseEnter(object sender, EventArgs e)
        {
            btnRegistrar.BackColor = Color.LightGreen;
        }

        private void btnRegistrar_MouseLeave(object sender, EventArgs e)
        {
            btnRegistrar.BackColor = SystemColors.Control;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtEdad.Text == "")
            {
                MessageBox.Show("Completa todos los campos.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Usuario registrado exitosamente.", "Registro",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
