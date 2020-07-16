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
    
    public partial class frmClientes : Form
    {
        ArteEmpresarialBD entityArteE = new ArteEmpresarialBD();
        bool editar = false;
        
        long idcliente = 0;
        public frmClientes()
        {
            InitializeComponent();
        }




        private void btnNuevo_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            var buscar = (from c in entityArteE.Clientes
                          where c.Nombre.StartsWith(txtbuscar.Text)
                          select new
                          {
                              
                              c.Nombre,
                              c.Celular1,
                              c.Celular2,
                              c.Correo,
                              c.Direccion,
                              c.NombreEmpresa,
                              c.RTN,
                          });

            dgconsultaclientes.DataSource = buscar.CopyAnonymusToDataTable();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (editar)
                {
                    var tcliente = entityArteE.Clientes .FirstOrDefault(x => x.idCliente  == idcliente);



                    tcliente.Nombre = txtnombre.Text;
                    tcliente.Celular1 = txtcelular1.Text;
                    tcliente.Celular2 = txtcelular2.Text;
                    tcliente.Correo = txtcorreo.Text;
                    tcliente.Direccion = txtdireccionm.Text;
                    tcliente.NombreEmpresa = txtnombreempresa.Text;
                    tcliente.RTN = txtRTNempresa.Text;

                    
                    entityArteE.SaveChanges();

                    MessageBox.Show("Datos Guardados");
                    limpiarcontroles();
                    refil();
                    editar = false;


                }
                else
                {
                    if (txtnombre.Text.Equals(""))
                    {
                        MessageBox.Show("Porfavor ingrese El nombre del Cliente");
                        return;
                    }
                    if (txtcelular1.Text.Equals(""))
                    {
                        MessageBox.Show("Porfavor ingrese #Celular");
                        return;
                    }
                    if (txtcorreo.Text.Equals(""))
                    {
                        MessageBox.Show("Porfavor Ingrese nueva Contraseña para el Usuario");
                        return;
                    }
                    if (txtdireccionm.Text.Equals(""))
                    {
                        MessageBox.Show("Porfavor Ingrese direccion");
                        return;
                    }


                    Clientes tbcliente = new Clientes();
                    // tbcliente.idCliente = variablesG.idusuario;
                    tbcliente.Nombre = txtnombre.Text;
                    tbcliente.Celular1 = txtcelular1.Text;
                    tbcliente.Celular2 = txtcelular2.Text;
                    tbcliente.Correo = txtcorreo.Text;
                    tbcliente.Direccion = txtdireccionm.Text;
                    tbcliente.NombreEmpresa = txtnombreempresa.Text;
                    tbcliente.RTN = txtRTNempresa.Text;

                    entityArteE.Clientes.Add(tbcliente);
                    entityArteE.SaveChanges();

                    MessageBox.Show("Datos Guardados");
                    limpiarcontroles();
                    refil();
                }


            }
            catch (Exception)
            {

                
            }
        }

        

        public void limpiarcontroles()
        {
            txtnombre.Text = txtcelular1.Text = txtcelular2.Text = txtcorreo.Text =
                 txtdireccionm.Text = txtnombreempresa.Text = txtRTNempresa.Text = "";

        }

        public void refil()
        {

            var tcliente = from c in entityArteE.Clientes
                           select new
                           {
                               c.idCliente ,
                               c.Nombre,
                               c.Celular1,
                               c.Celular2,
                               c.Correo,
                               c.Direccion,
                               c.NombreEmpresa,
                               c.RTN,
                           };
            dgmanclientes.DataSource = tcliente.CopyAnonymusToDataTable();
            dgmanclientes.Columns["idCliente"].Visible = false;


        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            var tcliente = from c in entityArteE.Clientes
                           select new
                           {
                               c.idCliente,
                               c.Nombre,
                               c.Celular1,
                               c.Celular2,
                               c.Correo,
                               c.Direccion,
                               c.NombreEmpresa,
                               c.RTN,
                           };
            dgconsultaclientes.DataSource = tcliente.CopyAnonymusToDataTable();
            dgmanclientes.DataSource = tcliente.CopyAnonymusToDataTable();
            dgmanclientes.Columns["idCliente"].Visible = false;
            dgconsultaclientes.Columns["idCliente"].Visible = false;


            


        }

        private void dgmanclientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgmanclientes.RowCount > 0) { }
            try
            {
                idcliente = Convert.ToInt64(dgmanclientes.CurrentRow.Cells["idCliente"].Value);



                editar = true;
                var tcliente = entityArteE.Clientes.FirstOrDefault(x => x.idCliente == idcliente);
                txtnombre.Text = tcliente.Nombre;
                txtcelular1.Text = tcliente.Celular1;
                txtcelular2.Text = tcliente.Celular2;
                txtcorreo.Text = tcliente.Correo;
                txtdireccionm.Text = tcliente.Direccion;
                txtnombreempresa.Text = tcliente.NombreEmpresa;
                txtRTNempresa.Text = tcliente.RTN;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnnuevoman_Click(object sender, EventArgs e)
        {
            limpiarcontroles();
            editar = false;
            idcliente= 0;
        }
    }
}
