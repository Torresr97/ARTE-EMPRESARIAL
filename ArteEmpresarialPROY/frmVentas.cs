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
    public partial class frmVentas : Form
    {
        
           ArteEmpresarialBD entityArteE = new ArteEmpresarialBD();
        decimal precio;
        int cantidad;
        decimal preciounitario;
        decimal subtotal;
        decimal totalimpuesto;
        decimal total;
        bool editar = false;
        long idcliente = 0;
        long idarticulo = 0;
        
        
        public frmVentas()
        {
            InitializeComponent();
        }



        private void btnNuevo_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            var buscar = from c in entityArteE.Clientes
                         join v in entityArteE.Ventas
                         on c.idCliente equals v.idCliente
                         join vd in entityArteE.Venta_de_Detalle
                             on v.idVenta equals vd.idVenta
                         join a in entityArteE.Articulos
                         on vd.idArticulo equals a.idArticulo
                         join tipoa in entityArteE.Tipo_de_Articulo
                         on a.idtipoarticulo equals tipoa.idtipoarticulo
                         where c.Nombre .StartsWith (txtbuscar .Text )
                         select new
                         {
 
                             c.Nombre,
                             tipoa.DescripcionTipoArticulo,
                             a.DescripcionArticulo,
                             vd.Cantidad,
                             v.Subtotal,
                             v.Totalimpuesto,
                             v.Total
                         };
            dgconsultaventas.DataSource = buscar.CopyAnonymusToDataTable();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            limpiarcontroles();
          
            editar = false;
            idcliente = 0;
            idarticulo = 0;

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(cmbarticulo.SelectedValue.ToString());
            try
            {
                
                if (editar)
                {
                    
                    var tcliente = entityArteE.Ventas.FirstOrDefault(x => x.idCliente == idcliente);

                  //  tcliente.idCliente = cmbcliente.DisplayMember  ;
                    tcliente.IdUsuario = variablesG.idusuario;
                    tcliente.Fecha = dtpfechaglobal.Value;
                    tcliente.Subtotal = Convert.ToDecimal(txtsubtotal.Text);
                    tcliente.Totalimpuesto = Convert.ToDecimal(txttotalimpuesto.Text);
                    tcliente.Total = Convert.ToDecimal(txttotal.Text);

                    var tarticulo = entityArteE.Venta_de_Detalle .FirstOrDefault(x => x.idArticulo  == idarticulo );
       
                    tarticulo.idArticulo = Convert.ToInt32(cmbdescArticulo .SelectedValue);
                    tarticulo.Precio = Convert.ToDecimal(txtprecio.Text);
                    tarticulo.Cantidad = Convert.ToInt16(txtcantidad.Text);
                    tarticulo.PrecioUnitario = Convert.ToDecimal(txtcantidad.Text);
                    tarticulo.Impuesto = Convert.ToDecimal(txttotalimpuesto.Text);



                   
                    entityArteE.SaveChanges();
                    MessageBox.Show("Datos Guardados");

                    refil();
                    limpiarcontroles();
              
                    editar = false;
                    idcliente = 0;
                    idarticulo = 0;

                }
                else
                {
                    Ventas tbventas = new Ventas();
                    tbventas.idCliente = Convert.ToInt64(cmbcliente.SelectedValue);
                    tbventas.IdUsuario = variablesG.idusuario;
                    tbventas.Fecha = dtpfechaglobal.Value;
                    tbventas.Subtotal = Convert.ToDecimal(txtsubtotal.Text);
                    tbventas.Totalimpuesto = Convert.ToDecimal(txttotalimpuesto.Text);
                    tbventas.Total = Convert.ToDecimal(txttotal.Text);

                    Venta_de_Detalle tbventasdetalle = new Venta_de_Detalle();
                    tbventasdetalle.idArticulo = Convert.ToInt32(cmbarticulo.SelectedValue);
                    
                    tbventasdetalle.Precio = Convert.ToDecimal(txtprecio.Text);
                    tbventasdetalle.Cantidad = Convert.ToInt16(txtcantidad.Text);
                    tbventasdetalle.PrecioUnitario = Convert.ToDecimal(txtcantidad.Text);
                    tbventasdetalle.Impuesto = Convert.ToDecimal(txttotalimpuesto.Text);


                    entityArteE.Ventas.Add(tbventas);
                    entityArteE.Venta_de_Detalle.Add(tbventasdetalle);
                    entityArteE.SaveChanges();
                    MessageBox.Show("Datos Guardados");
                    limpiarcontroles();
                    refil();
                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }



     
       




        private void chkimpuestos_CheckedChanged(object sender, EventArgs e)
        {

            if (chkimpuestos.Checked == true)
            {
                totalimpuesto = (subtotal * Convert.ToDecimal(0.15));
                txttotalimpuesto.Text = totalimpuesto.ToString("N2");

                total = subtotal + totalimpuesto;
                txttotal.Text = total.ToString("N2");
            }
            else
            {
                txttotalimpuesto.Text = "0";
                txttotal .Text = txtsubtotal.Text;

            }
        }





        private void txtprecio_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
               if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }


            if (e.KeyChar == (char)(Keys.Enter))
            {

                e.Handled = true;
                SendKeys.Send("{TAB}");

                precio = Convert.ToDecimal(txtprecio.Text);
                cantidad = Convert.ToInt16(txtcantidad.Text);
                preciounitario = (precio / cantidad);
                txtpreciounitario.Text = preciounitario.ToString("N2");



                subtotal = (preciounitario  * cantidad);
                txtsubtotal.Text = subtotal.ToString("N2");



            }

        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            var tventasload = from c in entityArteE.Clientes
                              join v in entityArteE.Ventas
                              on c.idCliente equals v.idCliente
                              join vd in entityArteE.Venta_de_Detalle
                                  on v.idVenta equals vd.idVenta
                              join a in entityArteE.Articulos
                              on vd.idArticulo equals a.idArticulo
                              join tipoa in entityArteE.Tipo_de_Articulo
                              on a.idtipoarticulo equals tipoa.idtipoarticulo
                              select new
                              {


                                  c.idCliente,
                                  c.Nombre ,
                                  vd.idArticulo,
                                  tipoa.idtipoarticulo ,
                                  tipoa.DescripcionTipoArticulo,
                                  a.DescripcionArticulo,
                                  vd.Cantidad,
                                  vd.PrecioUnitario,
                                  vd.Precio,
                                  v.Subtotal,
                                  v.Totalimpuesto,
                                  v.Total
                              };

            
            gdmantventas.DataSource = tventasload.CopyAnonymusToDataTable();
            gdmantventas.Columns["idCliente"].Visible = false;
            gdmantventas.Columns["idArticulo"].Visible = false;
            gdmantventas.Columns["idtipoarticulo"].Visible = false;


            var consulta = from c in entityArteE.Clientes
                           join v in entityArteE.Ventas
                           on c.idCliente equals v.idCliente
                           join vd in entityArteE.Venta_de_Detalle
                               on v.idVenta equals vd.idVenta
                           join a in entityArteE.Articulos
                           on vd.idArticulo equals a.idArticulo
                           join tipoa in entityArteE.Tipo_de_Articulo
                           on a.idtipoarticulo equals tipoa.idtipoarticulo
                           select new
                           {


                               c.idCliente,
                               c.Nombre,
                               vd.idArticulo,
                               tipoa.idtipoarticulo,
                               tipoa.DescripcionTipoArticulo,
                               a.DescripcionArticulo,
                               vd.Cantidad,
                               vd.PrecioUnitario,
                               vd.Precio,
                               v.Subtotal,
                               v.Totalimpuesto,
                               v.Total
                           };


            dgconsultaventas.DataSource = consulta.CopyAnonymusToDataTable();
            dgconsultaventas.Columns["idCliente"].Visible = false;
            dgconsultaventas.Columns["idArticulo"].Visible = false;
            dgconsultaventas.Columns["idtipoarticulo"].Visible = false;


            var tclietne = from c in entityArteE.Clientes
                           select new
                           {
                               c.idCliente,
                               c.Nombre,
                           };



            DataTable dtcliente = tclietne.CopyAnonymusToDataTable();
            cmbcliente.DataSource = dtcliente;
            cmbcliente.ValueMember = dtcliente.Columns[0].ColumnName;
            cmbcliente.DisplayMember = dtcliente.Columns[1].ColumnName;
            cmbcliente.SelectedIndex = -1;

            var tipoarticulo = from tc in entityArteE.Tipo_de_Articulo 
                            select new
                            {
                                tc.idtipoarticulo ,
                                tc.DescripcionTipoArticulo 
                            };


            DataTable dtarticulo = tipoarticulo.CopyAnonymusToDataTable();
            cmbarticulo.DataSource = dtarticulo;
            cmbarticulo.ValueMember = dtarticulo.Columns[0].ColumnName;
            cmbarticulo.DisplayMember = dtarticulo.Columns[1].ColumnName;
            cmbarticulo.SelectedIndex = -1;
            //cmbdescArticulo.DataSource = dtarticulo;
            //cmbdescArticulo.ValueMember = dtarticulo.Columns[0].ColumnName;
            //cmbdescArticulo.DisplayMember = dtarticulo.Columns[2].ColumnName;

        }

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }


            if (e.KeyChar == (char)(Keys.Enter))
            {
                cantidad = Convert.ToInt16(txtcantidad.Text);
                txtpreciounitario .Focus();
            }
        }

       

        private void txtpreciounitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }


            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

                preciounitario = Convert.ToDecimal(txtpreciounitario.Text);
                precio = (preciounitario * cantidad);
                txtprecio.Text = precio .ToString("N2");



                subtotal = (preciounitario  * cantidad);
                txtsubtotal.Text = subtotal.ToString("N2");



            }
        }

        public void refil()
        {
            var consulta = from c in entityArteE.Clientes
                           join v in entityArteE.Ventas
                           on c.idCliente equals v.idCliente
                           join vd in entityArteE.Venta_de_Detalle
                               on v.idVenta equals vd.idVenta
                           join a in entityArteE.Articulos
                           on vd.idArticulo equals a.idArticulo
                           join tipoa in entityArteE.Tipo_de_Articulo
                           on a.idtipoarticulo equals tipoa.idtipoarticulo

                           select new
                           {

                               c.Nombre,
                               tipoa.DescripcionTipoArticulo,
                               a.DescripcionArticulo,
                               vd.Cantidad,
                               vd.PrecioUnitario,
                               vd.Precio,
                               v.Subtotal,
                               v.Totalimpuesto,
                               v.Total
                           };

            dgconsultaventas.DataSource = consulta.CopyAnonymusToDataTable();

            var tventasload = from c in entityArteE.Clientes
                              join v in entityArteE.Ventas
                              on c.idCliente equals v.idCliente
                              join vd in entityArteE.Venta_de_Detalle
                                  on v.idVenta equals vd.idVenta
                              join a in entityArteE.Articulos
                              on vd.idArticulo equals a.idArticulo
                              join tipoa in entityArteE.Tipo_de_Articulo
                              on a.idtipoarticulo equals tipoa.idtipoarticulo
                              select new
                              {


                                  c.idCliente,
                                  c.Nombre,
                                  vd.idArticulo,
                                  tipoa.idtipoarticulo,
                                  tipoa.DescripcionTipoArticulo,
                                  a.DescripcionArticulo,
                                  vd.Cantidad,
                                  v.Subtotal,
                                  v.Totalimpuesto,
                                  v.Total
                              };


            gdmantventas.DataSource = tventasload.CopyAnonymusToDataTable();
            gdmantventas.Columns["idCliente"].Visible = false;
            gdmantventas.Columns["idArticulo"].Visible = false;
            gdmantventas.Columns["idtipoarticulo"].Visible = false;






            var tclietne = from c in entityArteE.Clientes
                           select new
                           {
                               c.idCliente,
                               c.Nombre,
                           };



            DataTable dtcliente = tclietne.CopyAnonymusToDataTable();
            cmbcliente.DataSource = dtcliente;
            cmbcliente.ValueMember = dtcliente.Columns[0].ColumnName;
            cmbcliente.DisplayMember = dtcliente.Columns[1].ColumnName;

            var tarticulo = from tc in entityArteE.Articulos
                            join tipoA in entityArteE.Tipo_de_Articulo
                             on tc.idtipoarticulo equals tipoA.idtipoarticulo
                            select new
                            {
                                tc.idArticulo,
                                tipoA.DescripcionTipoArticulo,
                                tc.DescripcionArticulo
                            };


            DataTable dtarticulo = tarticulo.CopyAnonymusToDataTable();
            cmbarticulo.DataSource = dtarticulo;
            cmbarticulo.ValueMember = dtarticulo.Columns[0].ColumnName;
            cmbarticulo.DisplayMember = dtarticulo.Columns[1].ColumnName;

            cmbdescArticulo.DataSource = dtarticulo;
            cmbdescArticulo.ValueMember = dtarticulo.Columns[0].ColumnName;
            cmbdescArticulo.DisplayMember = dtarticulo.Columns[2].ColumnName;

           
        }

        public void limpiarcontroles()
        {

            cmbcliente.SelectedIndex = -1;
            cmbarticulo.SelectedIndex = -1;
            
            cmbdescArticulo.SelectedIndex = -1;
            txtcantidad.Text = "0";
            txtprecio.Text = "0";
            txtpreciounitario.Text = "0";
            txtsubtotal.Text = "0";
            txttotalimpuesto.Text = "0";
            txttotal.Text = "0";
            chkimpuestos.Checked = false;


        }

        private void gdmantventas_SelectionChanged(object sender, EventArgs e)
        {
            

            if (gdmantventas .RowCount > 0)
            {

                try
                {
                   
                    idcliente = Convert.ToInt64(gdmantventas.CurrentRow.Cells["idCliente"].Value);
                    idarticulo = Convert.ToInt64(gdmantventas.CurrentRow.Cells["idArticulo"].Value);
                   
                    editar = true;
                    var tcliente = entityArteE.Ventas.FirstOrDefault(x => x.idCliente == idcliente);
                   cmbcliente.SelectedValue = tcliente.idCliente;

                    dtpfechaglobal.Text = tcliente.Fecha.ToString();
                    txtsubtotal.Text = tcliente.Subtotal.ToString();
                    txttotalimpuesto.Text = tcliente.Totalimpuesto.ToString();
                    txttotal.Text = tcliente.Total.ToString();


                    var tarticulo = entityArteE.Venta_de_Detalle.FirstOrDefault(x => x.idArticulo == idarticulo);
                    
                    cmbarticulo.SelectedValue = Convert.ToInt64(gdmantventas.CurrentRow.Cells["idtipoarticulo"].Value);
                    txtprecio.Text = tarticulo.Precio.ToString();
                    txtcantidad.Text = tarticulo.Cantidad.ToString();
                    txtpreciounitario.Text = tarticulo.PrecioUnitario.ToString();
                    txttotalimpuesto.Text = tarticulo.Impuesto.ToString();
                
                }
                catch (Exception)
                {

                   
                }

               



            }
      
           
           
        }

        private void cmbarticulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbarticulo.SelectedIndex > -1){
                try
                {
                    int valors = Convert.ToInt32(cmbarticulo.SelectedValue);

                    var tarticulo = from tc in entityArteE.Articulos
                                    where tc.idtipoarticulo == valors
                                    select new
                                    {
                                        tc.idArticulo,
                                        tc.DescripcionArticulo
                                    };
                    DataTable tablaarticulo = tarticulo.CopyAnonymusToDataTable();

                    cmbdescArticulo.DataSource = tarticulo.CopyAnonymusToDataTable();
                    cmbdescArticulo.ValueMember = tablaarticulo.Columns[0].ColumnName;
                    cmbdescArticulo.DisplayMember = tablaarticulo.Columns[1].ColumnName;
                }
                catch (Exception )
                {

                    
                }

            }
        }

       
    }

       
}

