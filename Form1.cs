using System;
using System.Globalization;
using System.Windows.Forms;

namespace Prueba_B1_Diseño
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rbtnMostrador.Checked = true;
            chkPostre.Checked = false;
            chkServilletas.Checked = false;
            btnQuitar.Enabled = false;
            btnAgregar.Enabled = false;
            lblTotal.Text = "Total: 0.00";

            lvCatalogo.View = View.Details;
            lvCatalogo.FullRowSelect = true;
            lvCatalogo.MultiSelect = true;
            lvCatalogo.Columns.Add("N°", 40);
            lvCatalogo.Columns.Add("Producto", 180);
            lvCatalogo.Columns.Add("Precio", 70, HorizontalAlignment.Right);

            lvPedido.View = View.Details;
            lvPedido.FullRowSelect = true;
            lvPedido.Columns.Add("N°", 40);
            lvPedido.Columns.Add("Producto", 150);
            lvPedido.Columns.Add("Precio", 65, HorizontalAlignment.Right);
            lvPedido.Columns.Add("Subtotal", 75, HorizontalAlignment.Right);

            lvCatalogo.Items.Add(new ListViewItem(new[] { "1", "Empanada de queso", "1.25" }));
            lvCatalogo.Items.Add(new ListViewItem(new[] { "2", "Sanduche de pollo", "2.50" }));
            lvCatalogo.Items.Add(new ListViewItem(new[] { "3", "Bolon de verde mixto", "2.25" }));
            lvCatalogo.Items.Add(new ListViewItem(new[] { "4", "Humita tradicional", "1.55" }));
            lvCatalogo.Items.Add(new ListViewItem(new[] { "5", "Tostada con queso", "1.00" }));
            lvCatalogo.Items.Add(new ListViewItem(new[] { "6", "Cafe pasado", "0.85" }));
            lvCatalogo.Items.Add(new ListViewItem(new[] { "7", "Chocolate Caliente", "1.35" }));
            lvCatalogo.Items.Add(new ListViewItem(new[] { "8", "Jugo Natural", "1.50" }));
            lvCatalogo.Items.Add(new ListViewItem(new[] { "9", "Batido de fruta", "2.00" }));
            lvCatalogo.Items.Add(new ListViewItem(new[] { "10", "Botella de agua", "0.75" }));

            chkPostre.CheckedChanged += chkPostre_CheckedChanged;

            CalcularTotal();
        }

        private void CalcularTotal()
        {
            decimal sumaSubtotales = 0m;

            foreach (ListViewItem item in lvPedido.Items)
            {
                string textoSubtotal = item.SubItems[3].Text.Replace("$", "").Trim();
                if (decimal.TryParse(textoSubtotal, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal sub))
                {
                    sumaSubtotales += sub;
                }
            }

            decimal recargoEntrega = rbtnEntrega.Checked ? 0.50m : 0.00m;
            decimal extraPostre = chkPostre.Checked ? 1.50m : 0.00m;

            decimal total = sumaSubtotales + recargoEntrega + extraPostre;
            lblTotal.Text = "Total: $" + total.ToString("0.00", CultureInfo.InvariantCulture);
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbtnMostrador_CheckedChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void rbtnEntrega_CheckedChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void chkPostre_CheckedChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void chkServilletas_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lvCatalogo_SelectedIndexChanged(object sender, EventArgs e)
        {

            
           
        }

        private void lvPedido_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //lvPedido.Items.Clear();

            int cantidad = 1;
            int.TryParse(txtCantidad.Text, out cantidad);
            if (cantidad <= 0) cantidad = 1;
            
            

            foreach (ListViewItem item in lvCatalogo.SelectedItems)
            {
                decimal precioUnitario = decimal.Parse(item.SubItems[2].Text, CultureInfo.InvariantCulture);
                decimal subtotal = cantidad * precioUnitario;

                lvPedido.Items.Add(new ListViewItem(new[]
                {
                    item.SubItems[0].Text,
                    item.SubItems[1].Text,
                    item.SubItems[2].Text,
                    "$" + subtotal.ToString("0.00", CultureInfo.InvariantCulture)
                }));
            }

            CalcularTotal();

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (lvPedido.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecciona un producto del pedido para quitar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (ListViewItem item in lvPedido.SelectedItems)
            {
                lvPedido.Items.Remove(item);
            }

            CalcularTotal();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lvPedido.Items.Clear();
        
            lvCatalogo.SelectedItems.Clear();
            txtCliente.Clear();
            txtCantidad.Clear();
            txtProducto.Clear();
            chkPostre.Checked = false;
            chkServilletas.Checked = false;
            rbtnMostrador.Checked = true;
            
        }

        private void lblEstado_Click(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }
    }
}