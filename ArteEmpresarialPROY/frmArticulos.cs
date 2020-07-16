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
    public partial class frmArticulos : Form
    {
        ArteEmpresarialBD entityArteE = new ArteEmpresarialBD();
        bool editar = false;
        bool editartipo = false;
        long idarticulo = 0;
        long idtipoarticulo = 0;
        public frmArticulos()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtdescptipoarticulo  .Text = "";
            editartipo = false;
            idtipoarticulo = 0;
        }

        
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {

            var tconsultaarticulo = from tc in entityArteE.Articulos join tipoA in entityArteE.Tipo_de_Articulo
                                      on tc.idtipoarticulo equals tipoA.idtipoarticulo
                                    where tipoA .DescripcionTipoArticulo  .StartsWith(txtbuscar.Text)
                                    select new
                                    {
                                        tipoA.DescripcionTipoArticulo ,
                                        tc.DescripcionArticulo,


                                    };
            dgconsultaarticulos.DataSource = tconsultaarticulo.CopyAnonymusToDataTable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            txtdescriparticulo.Text = "";
            
            idarticulo  = 0;
            editar = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (editar)
                {
                    idarticulo = Convert.ToInt64(dgmanarticulos.CurrentRow.Cells["idArticulo"].Value);
                    var tarticulo = entityArteE.Articulos .FirstOrDefault(x => x.idArticulo  == idarticulo );

                    tarticulo.idtipoarticulo = Convert.ToInt32(comboBox1.SelectedValue);
                    tarticulo.DescripcionArticulo = txtdescriparticulo.Text;

                 
                    entityArteE.SaveChanges();

                    MessageBox.Show("Datos Guardados");
                    comboBox1.Text = "";
                    txtdescriparticulo.Text = "";
                    refil();
                    editar = false;
                    
                    idarticulo  = 0;
                }
                else
                {
                    if (comboBox1.Text.Equals(""))
                    {
                        MessageBox.Show("Porfavor Seleccione un Articulo");
                        return;
                    }




                    Articulos tbarticulos = new Articulos();
                    tbarticulos.idtipoarticulo = Convert.ToInt32(comboBox1.SelectedValue);
                    tbarticulos.DescripcionArticulo = txtdescriparticulo.Text;

                    entityArteE.Articulos.Add(tbarticulos);
                    entityArteE.SaveChanges();

                    MessageBox.Show("Datos Guardados");
                    comboBox1.Text = "";
                    txtdescriparticulo.Text = "";
                    refil();
                }

            }
            catch (Exception)
            {

               
            }
            
        }







        public void refil()
        {


            var tmanarticulo = from tc in entityArteE.Articulos join tipoA in entityArteE.Tipo_de_Articulo
                                on tc.idtipoarticulo equals tipoA.idtipoarticulo
                               select new
                               {
                                   tc.idArticulo ,
                                   tipoA .idtipoarticulo ,
                                   tipoA.DescripcionTipoArticulo ,
                                   tc.DescripcionArticulo,


                               };
            dgmanarticulos.DataSource = tmanarticulo.CopyAnonymusToDataTable();
            dgmanarticulos.Columns["idArticulo"].Visible = false;
            dgmanarticulos.Columns["idtipoarticulo"].Visible = false;
            


            var tipoarticulo = from ta in entityArteE.Tipo_de_Articulo
                               select new
                               {
                                   ta.idtipoarticulo,
                                   ta.DescripcionTipoArticulo ,


                               };
            dgtipoarticulo.DataSource = tipoarticulo.CopyAnonymusToDataTable();
            dgtipoarticulo.Columns["idtipoarticulo"].Visible = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                if (editar)
                {
                    idtipoarticulo = Convert.ToInt64(dgtipoarticulo.CurrentRow.Cells["idtipoarticulo"].Value);

                    var tiposarticulos = entityArteE.Tipo_de_Articulo.FirstOrDefault(x => x.idtipoarticulo == idtipoarticulo);

                    tiposarticulos .DescripcionTipoArticulo = txtdescptipoarticulo.Text;

                   
                    entityArteE.SaveChanges();

                    MessageBox.Show("Datos Guardados");
                    txtdescptipoarticulo.Text = "";
                    refil();
                    editartipo = false;
                    idtipoarticulo = 0;






                }
                else
                {
                    if (txtdescptipoarticulo.Text.Equals(""))
                    {
                        MessageBox.Show("Porfavor Ingrese una Descripcion del nuevo Articulo");
                        return;
                    }


                    Tipo_de_Articulo tablatipoarticulos = new Tipo_de_Articulo();
                    tablatipoarticulos.DescripcionTipoArticulo = txtdescptipoarticulo.Text;

                    entityArteE.Tipo_de_Articulo.Add(tablatipoarticulos);
                    entityArteE.SaveChanges();

                    MessageBox.Show("Datos Guardados");
                    txtdescptipoarticulo.Text = "";
                    refil();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void frmArticulos_Load(object sender, EventArgs e)
        {
            var tconsultaarticulo = from tc in entityArteE.Articulos
                                    join tipoA in entityArteE.Tipo_de_Articulo
  on tc.idtipoarticulo equals tipoA.idtipoarticulo
                                    select new
                                    {
                                        tc.idArticulo,
                                        tipoA.idtipoarticulo,
                                        tipoA.DescripcionTipoArticulo,
                                        tc.DescripcionArticulo,


                                    };
            dgconsultaarticulos.DataSource = tconsultaarticulo.CopyAnonymusToDataTable();
            dgmanarticulos.DataSource = tconsultaarticulo.CopyAnonymusToDataTable();
            dgmanarticulos.Columns["idArticulo"].Visible = false;
            dgconsultaarticulos.Columns["idArticulo"].Visible = false;
            dgmanarticulos.Columns["idtipoarticulo"].Visible = false;
            dgconsultaarticulos.Columns["idtipoarticulo"].Visible = false;






            var tipoarticulo = from ta in entityArteE.Tipo_de_Articulo
                               select new
                               {
                                   ta.idtipoarticulo,
                                   ta.DescripcionTipoArticulo,


                               };
            dgtipoarticulo.DataSource = tipoarticulo.CopyAnonymusToDataTable();
            dgtipoarticulo.Columns["idtipoarticulo"].Visible = false;


            var tarti = from p in entityArteE.Tipo_de_Articulo
                        select p;

            DataTable dtarticulos = tarti.CopyAnonymusToDataTable();
            comboBox1.DataSource = dtarticulos;
            comboBox1.ValueMember = dtarticulos.Columns[0].ColumnName;
            comboBox1.DisplayMember = dtarticulos.Columns[1].ColumnName;

        }

        private void dgmanarticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgmanarticulos.RowCount > 0) { }
            try
            {
                idarticulo  = Convert.ToInt64(dgmanarticulos.CurrentRow.Cells["idArticulo"].Value);



                
                var tarticulos = entityArteE.Articulos .FirstOrDefault(x => x.idArticulo  == idarticulo);
                comboBox1.SelectedValue = Convert.ToInt64(dgmanarticulos.CurrentRow.Cells["idtipoarticulo"].Value);
                txtdescriparticulo.Text = tarticulos.DescripcionArticulo;
                editar = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void dgtipoarticulo_SelectionChanged(object sender, EventArgs e)
        {
            if (dgtipoarticulo.RowCount > 0) { }
            try
            {
                idtipoarticulo  = Convert.ToInt64(dgtipoarticulo .CurrentRow.Cells["idtipoarticulo"].Value);




                var tiposarticulos = entityArteE.Tipo_de_Articulo .FirstOrDefault(x => x.idtipoarticulo   == idtipoarticulo );
                txtdescptipoarticulo.Text = tiposarticulos.DescripcionTipoArticulo;
                editar = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
