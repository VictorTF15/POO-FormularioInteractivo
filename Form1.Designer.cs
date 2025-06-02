namespace FormularioInteractivo
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.chkMayorEdad = new System.Windows.Forms.CheckBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(30, 30);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(30, 70);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 1;
            this.txtEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdad_KeyPress);
            // 
            // chkMayorEdad
            // 
            this.chkMayorEdad.AutoSize = true;
            this.chkMayorEdad.Location = new System.Drawing.Point(30, 110);
            this.chkMayorEdad.Name = "chkMayorEdad";
            this.chkMayorEdad.Size = new System.Drawing.Size(117, 17);
            this.chkMayorEdad.TabIndex = 2;
            this.chkMayorEdad.Text = "Soy mayor de edad";
            this.chkMayorEdad.UseVisualStyleBackColor = true;
            this.chkMayorEdad.CheckedChanged += new System.EventHandler(this.chkMayorEdad_CheckedChanged);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(30, 150);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(120, 30);
            this.btnRegistrar.TabIndex = 3;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            this.btnRegistrar.MouseEnter += new System.EventHandler(this.btnRegistrar_MouseEnter);
            this.btnRegistrar.MouseLeave += new System.EventHandler(this.btnRegistrar_MouseLeave);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(30, 200);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 13);
            this.lblMensaje.TabIndex = 4;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(300, 250);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.chkMayorEdad);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombre);
            this.Name = "Form1";
            this.Text = "Formulario Interactivo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.CheckBox chkMayorEdad;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
