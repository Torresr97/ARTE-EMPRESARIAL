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
    public partial class frmUsuarios : Form
    {
        ArteEmpresarialBD entityArteE = new ArteEmpresarialBD();
        bool editar = false;
        bool editarperfiles = false;
        long idusuario = 0;
        long idperfil = 0;
        public frmUsuarios()
        {
            InitializeComponent();
        }





        ////////////////// pagian de consulta////////////////////


        private void btnNuevoconsulta_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            var buscar = (from p in entityArteE.Usuarios
                          where p.Usuario.StartsWith(txtbuscar.Text)
                          select new
                          {
                              p.Usuario,
                              p.NombreUsuario,
                              p.FKidperfil,
                          });

            dgconsultausuarios.DataSource = buscar.CopyAnonymusToDataTable();

        }







        ////////////////// pagian de mantenimienmto////////////////////
        private void btnnuevoman_Click(object sender, EventArgs e)
        {
            editar = false;
            idusuario = 0;
            limpiarcontroles();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (editar)
                {
                    var tusuario = entityArteE.Usuarios.FirstOrDefault(x => x.IdUsuario == idusuario);
                    string clave = txtcontrasena.Text;
                   // variablesG.Encriptar(clave);

                    tusuario.Usuario = txtusuario.Text;
                    tusuario.NombreUsuario = txtnombreusuario.Text;
                    tusuario.Contrasena = variablesG.Encriptar(clave);
                    entityArteE.SaveChanges();
                    MessageBox.Show("Datos Guardados");
                    limpiarcontroles();
                    refil();
                    editar = false;
                    idusuario = 0;

                }
                else
                {
                    if (txtusuario.Text.Equals(""))
                    {
                        MessageBox.Show("Porfavor ingrese El usuario");
                        return;
                    }
                    if (txtnombreusuario.Text.Equals(""))
                    {
                        MessageBox.Show("Porfavor ingrese Nombre del usuario");
                        return;
                    }
                    if (txtcontrasena.Text.Equals(""))
                    {
                        MessageBox.Show("Porfavor Ingrese nueva Contraseña para el Usuario");
                        return;
                    }

                    string clave = txtcontrasena.Text;
                    //variablesG.Encriptar(clave);

                    //MessageBox.Show(claveEncriptada);


                    Usuarios tbusuario = new Usuarios();
                    tbusuario.Usuario = txtusuario.Text;
                    tbusuario.NombreUsuario = txtnombreusuario.Text;
                    tbusuario.Contrasena = variablesG.Encriptar(clave);



                    tbusuario.FKidperfil = Convert.ToInt64(cmbperfil.SelectedValue);

                    entityArteE.Usuarios.Add(tbusuario);
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
            txtusuario.Text = txtnombreusuario.Text = txtcontrasena.Text = "";
            cmbperfil.SelectedIndex = -1;

        }

        public void refil()
        {
            var tusuarios = from u in entityArteE.Usuarios
                            join p in entityArteE.Perfiles
                            on u.FKidperfil equals p.idPerfil
                            select new
                            {
                                u.IdUsuario,
                                u.Usuario,
                                u.NombreUsuario,
                                p.DescripcionPerfil,
                            };
            
            dgUsuarioman.DataSource = tusuarios.CopyAnonymusToDataTable();
            dgconsultausuarios.Columns["IdUsuario"].Visible = false;



            var perfiles = from p in entityArteE.Perfiles
                           select new
                           {
                               p.idPerfil ,
                               p.DescripcionPerfil,
                               p.PerfilEstado,
                           };
            dgperfiles.DataSource = perfiles.CopyAnonymusToDataTable();
            dgperfiles.Columns["idPerfil"].Visible = false;

        }

        private void btnperfiles_Click(object sender, EventArgs e)
        {
            txtdescpPerfil.Text = "";
            checkBox1.Checked = false;
            editarperfiles = false;

        }

        private void btnguardarperfiles_Click(object sender, EventArgs e)
        {

            try
            {
                if (editar)
                {
                    var tperfiles = entityArteE.Perfiles.FirstOrDefault(x => x.idPerfil == idperfil);
                    tperfiles.DescripcionPerfil = txtdescpPerfil.Text;
                    tperfiles.PerfilEstado = checkBox1.Checked;

                    entityArteE.SaveChanges();
                    MessageBox.Show("Datos Guardados");
                    txtdescpPerfil.Text = "";
                    checkBox1.Checked = false;
                    refil();
                    editarperfiles = false;
                    idperfil = 0;
                }
                else
                {
                    if (txtdescpPerfil.Text.Equals(""))
                    {
                        MessageBox.Show("Porfavor ingrese Descripcion del Perfil");
                        return;
                    }
                    Perfiles tbperfiles = new Perfiles();
                    tbperfiles.DescripcionPerfil = txtdescpPerfil.Text;
                    tbperfiles.PerfilEstado = checkBox1.Checked;
                    entityArteE.Perfiles.Add(tbperfiles);
                    entityArteE.SaveChanges();
                    MessageBox.Show("Datos Guardados");
                    txtdescpPerfil.Text = "";
                    checkBox1.Checked = false;
                    refil();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            var tusuarios = from u in entityArteE.Usuarios
                            join p in entityArteE.Perfiles
                            on u.FKidperfil equals p.idPerfil
                            select new
                            {
                                u.IdUsuario,
                                u.Usuario,
                                u.NombreUsuario,
                                p.DescripcionPerfil,
                            };
            dgconsultausuarios.DataSource = tusuarios.CopyAnonymusToDataTable();
            dgUsuarioman.DataSource = tusuarios.CopyAnonymusToDataTable();
            dgconsultausuarios.Columns["IdUsuario"].Visible = false;
            dgUsuarioman.Columns["IdUsuario"].Visible = false;



            var perfiles = from p in entityArteE.Perfiles
                           select new
                           {
                               p.idPerfil ,
                               p.DescripcionPerfil,
                               p.PerfilEstado,
                           };
            dgperfiles.DataSource = perfiles.CopyAnonymusToDataTable();
            dgperfiles.Columns["idPerfil"].Visible = false;




            var tperfiles = from p in entityArteE.Perfiles
                            select p;

            DataTable dtperfiles = tperfiles.CopyAnonymusToDataTable();
            cmbperfil.DataSource = dtperfiles;
            cmbperfil.ValueMember = dtperfiles.Columns[0].ColumnName;
            cmbperfil.DisplayMember = dtperfiles.Columns[1].ColumnName;
        }

        private void dgUsuarioman_SelectionChanged(object sender, EventArgs e)
        {
            if (dgUsuarioman.RowCount > 0) { }
            try
            {
                idusuario = Convert.ToInt64(dgUsuarioman.CurrentRow.Cells["idUsuario"].Value);
                


                editar = true;
                var tusuario = entityArteE.Usuarios.FirstOrDefault(x => x.IdUsuario == idusuario);
                txtusuario.Text = tusuario.Usuario;
                txtnombreusuario.Text = tusuario.NombreUsuario;

                string clavedesc = tusuario.Contrasena;
                
                cmbperfil.SelectedValue = tusuario.FKidperfil;


                txtcontrasena.Text= variablesG.DesEncriptar(clavedesc);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void dgperfiles_SelectionChanged(object sender, EventArgs e)
        {
            if (dgperfiles.RowCount > 0)
            {

                try
                {
                    idperfil = Convert.ToInt64(dgUsuarioman.CurrentRow.Cells["idPerfil"].Value);
                     

                    editarperfiles = true;
                    var tperfiles = entityArteE.Perfiles.FirstOrDefault(x => x.idPerfil == idperfil);
                    txtdescpPerfil.Text = tperfiles.DescripcionPerfil;
                    checkBox1.Checked = tperfiles.PerfilEstado;


                }
                catch (Exception)
                {

                    
                }



            }
        }
    }
}

