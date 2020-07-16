using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace ArteEmpresarialPROY
{
    public partial class frmLogin : Form
    {
        ArteEmpresarialBD entityArteE = new ArteEmpresarialBD();

   
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

          string usuariologin = txtusuariologin.Text;
          string contrasenalogin = txtlogincontra.Text;
            string clave =variablesG.Encriptar(contrasenalogin);

            

            if(validarusaurio(usuariologin, clave))
            {
                variablesG.usuario = usuariologin;
                this.Dispose();
                

            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrectos");
            }
          
             


        }


        public bool validarusaurio(string usuario, string contra)

        {

            int validar = (from u in entityArteE.Usuarios
                           where (u.Usuario == usuario  && (u.Contrasena == contra))
                           select u).Count();
            return validar == 0 ? false : true;
           


        }

        private void btncerrarform_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
