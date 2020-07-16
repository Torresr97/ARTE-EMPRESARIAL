using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArteEmpresarialPROY
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
          Form frmLogin = new frmLogin();
          
          frmLogin.ShowDialog();
        }



        private void Abrirformpanel(object formhijo)
        {
            if (this.panelcontenedor .Controls.Count > 0)
                this.panelcontenedor .Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill ;
            this.panelcontenedor.Controls.Add(fh);
            this.panelcontenedor.Tag = fh;
            fh.Show();
        }
        private void btnusuarios_Click(object sender, EventArgs e)
        {
            Abrirformpanel(new frmUsuarios());
            label1.Text = "USUARIOS";
        }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            Abrirformpanel(new frmClientes ());
            label1.Text = "CLIENTES";
        }

        private void btnventas_Click(object sender, EventArgs e)
        {
            Abrirformpanel(new frmVentas ());
            label1.Text = "VENTAS";
        }

        private void btnarticulos_Click(object sender, EventArgs e)
        {
            Abrirformpanel(new frmArticulos  ());
            label1.Text = "ARTICULOS";
        }

        

        private void btncerrarform_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btncerrarform.Visible = true;
            btnmax .Visible = false;
            btnminimizar.Visible = true;
            label2.Dock = DockStyle.Bottom;
            label3.Location = new Point(85,878);
            this.panelcontenedor.Controls[0].Width += this.Width - this.panelcontenedor.Controls[0].Width;

        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized ;
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal ;
            btncerrarform.Visible = true;
            btnmax.Visible = true;
            btnminimizar.Visible = false;
            label3.Location = new Point(83, 555);
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            label3.Text = variablesG.usuario;
        }
    }
}
