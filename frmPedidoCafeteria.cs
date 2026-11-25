/*
 * Autor: Pablo Cuasapaz
 * Asignatura: ITID 543 - Diseño y Programación de Software
 * Docente: Jose Naranjo
 * Examen Práctico Primer Parcial: Cafetería
 * Fecha: 24/11/2026
 */
using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;

namespace Prueba_B1_Diseño
{
    public partial class frmPedidoCafeteria : Form
    {
        public frmPedidoCafeteria()
        {

            InitializeComponent();
        }
        private void frmPedidoCafeteria_Load(object sender, EventArgs e)
        {
            lvCatalogo.View = View.Details; //Muestra el ListView en modo tabla con columnas 
            lvCatalogo.FullRowSelect = true; //Permite que al hacer clic en una fila se resalte toda la fila completa
            lvCatalogo.MultiSelect = false;  //Restringe la seleccion a una sola fila a la vez
            lvCatalogo.Columns.Add("Producto", 180); //Crea la primera columna Producto con un ancho de 180 pixels
            lvCatalogo.Columns.Add("Precio", 70, HorizontalAlignment.Right); //Crea la segunda tabla con un ancho de 70 esta alineado a la derecha

            lvPedido.View = View.Details;
            lvPedido.FullRowSelect = true;
            lvPedido.Columns.Add("Producto", 150);
            lvPedido.Columns.Add("Cant.", 50, HorizontalAlignment.Right);
            lvPedido.Columns.Add("Subtotal", 75, HorizontalAlignment.Right);


            //Aqui se agregan las filas para completar la tabla de catalogo
 
            lvCatalogo.Items.Add(new ListViewItem(new[] { "Empanada de queso", "$1.25" }));
            lvCatalogo.Items.Add(new ListViewItem(new[] { "Sánduche de pollo", "$2.50" }));
            lvCatalogo.Items.Add(new ListViewItem(new[] { "Bolón de verde mixto", "$2.25" }));
            lvCatalogo.Items.Add(new ListViewItem(new[] { "Humita tradicional", "$1.50" }));
            lvCatalogo.Items.Add(new ListViewItem(new[] { "Tostada con queso", "$1.00" }));
            lvCatalogo.Items.Add(new ListViewItem(new[] { "Café pasado", "$0.85" }));
            lvCatalogo.Items.Add(new ListViewItem(new[] { "Chocolate caliente", "$1.35" }));
            lvCatalogo.Items.Add(new ListViewItem(new[] { "Jugo natural (naranja/mora)", "$1.50" }));
            lvCatalogo.Items.Add(new ListViewItem(new[] { "Batido de fruta", "$2.00" }));
            lvCatalogo.Items.Add(new ListViewItem(new[] { "Botella de agua", "$0.75" }));


            //Condiciones iniciales asi se vera primero al inciar el programa
            rbtnMostrador.Checked = true;  //marca por defecto la opcion de retiro en mostrador
            chkPostre.Checked = false;     //deja desmarcado el postre
            chkServilletas.Checked = false;  //deja desmarcado las servilletas
            btnAgregar.Enabled = false;      //Desabilita el boton agregar hasta que se cumplan unas condiciones
            btnQuitar.Enabled = false;       //Desabilita el boton quitar porque el pedido esta vacio
            txtCantidad.Text = "1";         //tiene como cantidad 1 por defecto
            
            lblEstado.Text = "Estado: Seleccione un producto.";   //Mensaje incial para guiar al usuario
            ActualizarTotal();   //calcula y muestra el total inicial
        }

        private void txtCantidad_Validating(object sender, CancelEventArgs e)
        {

        }

        private void ActualizarEstadoAgregar()
        {
            bool productoValido = !string.IsNullOrWhiteSpace(txtProducto.Text);  //evalúa si txtProducto tiene algún texto
            //limpia los espacios de txtCantidad con .Trim(), se convierte a entero, y comprueba que sea 1 o mayor
            bool cantidadValida = int.TryParse(txtCantidad.Text.Trim(), out int cantidad) && cantidad >= 1;
            //habilita btnAgregar únicamente cuando se cumplen las condiciones 
            btnAgregar.Enabled = productoValido && cantidadValida;
        }


        private void ActualizarTotal()
        {
            decimal sumaSubtotales = 0m;  //Inicio un acumulador decimal

            foreach (ListViewItem item in lvPedido.Items)  //Recorre cada fila agregada al ListView del pedido
            {
                //Toma el texto de la tercera columna, se comienza desde 0 por eso es [2] se quita el signo $ y espacios
                string textoSubtotal = item.SubItems[2].Text.Replace("$", "").Trim();

                //convierte el texto a decimal usando CultureInfo.InvariantCulture ya que el punto se puede interpretar diferente en otras maquinas
                //Si es valido lo suma a sumaSubtotales
                if (decimal.TryParse(textoSubtotal, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal sub))
                {
                    sumaSubtotales += sub;
                }
            }


            
            decimal recargoEntrega = rbtnEntrega.Checked ? 0.50m : 0.00m;   //Suma 0.5 si esta marcado
            decimal extraPostre = chkPostre.Checked ? 1.00m : 0.00m;        //Suma 1.00 si esta marcado

            decimal total = sumaSubtotales + recargoEntrega + extraPostre;    //Total final
            lblTotal.Text = "Total: $" + total.ToString("0.00", CultureInfo.InvariantCulture); //formatea el total con dos decimales
        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            ActualizarEstadoAgregar();
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            ActualizarEstadoAgregar();
        }

        private void rbtnMostrador_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarTotal();
            if (rbtnMostrador.Checked)   //confirma si el radio button esta marcado.Para entregar en caja
            {
                lblEstado.Text = "Opción aplicada: Retiro en mostrador ($0.00).";  //Actualiza estado
            }
        }

        private void rbtnEntrega_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarTotal();
            if (rbtnEntrega.Checked) //verifica si la opción de entrega en aula esta seleccionada.
            {
                lblEstado.Text = "Opción aplicada: Entrega en aula (+$0.50).";  //Actualiza el estado 
            }
            else
            {
                lblEstado.Text = "Opción quitada: Entrega en aula (-$0.50).";  
            }
        }

        private void chkPostre_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarTotal();
            if (chkPostre.Checked) //Verifica si la opcion de postre esta habilitada
            {
                lblEstado.Text = "Opción aplicada: Extra postre (+$1.00).";  //Actualiza el estado
            }
            else
            {
                lblEstado.Text = "Opción quitada: Extra postre (-$1.00).";
            }
        }

        private void chkServilletas_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarTotal();
            if (chkServilletas.Checked)    //Verifica si la opcion de servilletas esta habilitada
            {
                lblEstado.Text = "Opción aplicada: Servilletas ($0.00).";   //Actualiza el estado
            }
            else
            {
                lblEstado.Text = "Opción quitada: Servilletas ($0.00).";
            }
        }

     
        private void lvCatalogo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCatalogo.SelectedItems.Count > 0)  //comprueba si hay al menos una fila seleccionada en lvCatalogo
            {
                ListViewItem fila = lvCatalogo.SelectedItems[0]; //obtiene la primera fila seleccionada.
                string producto = fila.SubItems[0].Text;   // leen el nombre del producto, columna 0
                string precio = fila.SubItems[1].Text;     //leen el precio del catalgo, columna 1

                txtProducto.Text = producto;   //copia el nombre del producto seleccionado al cuadro de texto txtProducto
                lblEstado.Text = $"Estado: Seleccionado {producto} - {precio}";  //muestra en lblEstado cuál producto y precio quedaron seleccionados.
            }
            else
            {
                txtProducto.Clear(); //limpia el cuadro de texto
                lblEstado.Text = "Estado: Seleccione un producto."; //Indica que no hay prodcuto seleccionado
            }

            ActualizarEstadoAgregar();
        }

        private void lvPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnQuitar.Enabled = lvPedido.SelectedItems.Count > 0; //condicional que verifica si lvPedido.SelectedItems.Count es mayor que 0
        }                                                         //Si hay almenos una selecciona habilita el boton de quitar

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCliente.Text))  //Verifica que txtCliente no este vacio
            {
                lblEstado.Text = "Error: Ingrese el nombre del cliente.";
                return;
            }

            if (lvCatalogo.SelectedItems.Count == 0) //comprueba que haya al menos un producto seleccionado
            {
                lblEstado.Text = "Error: Seleccione un producto del catálogo.";
                return;
            }
            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad < 1) //valida que txtCantidad sea un número entero mayor o igual a 1
            { 
                lblEstado.Text = "Error: La cantidad debe ser un entero mayor o igual a 1.";
                return;
            }

            ListViewItem item = lvCatalogo.SelectedItems[0]; //obtiene la fila seleccionada del catálogo.

            //toma el precio de la columna 1 le quita el signo $ y lo convierte a decimal
            decimal precio = decimal.Parse(item.SubItems[1].Text.Replace("$", ""), CultureInfo.InvariantCulture);
            //multiplica cantidad *precio y pone el resultado con dos decimales y signo $
            string subtotal = "$" + (cantidad * precio).ToString("0.00", CultureInfo.InvariantCulture);
            //agrega una nueva fila al pedido con el nombre del producto y , la cantidad y el subtotal calculado.
            lvPedido.Items.Add(new ListViewItem(new[] { item.SubItems[0].Text, cantidad.ToString(), subtotal }));

            ActualizarTotal();
            txtCantidad.Text = "1"; //reinicia la cantidad por defecto
            //muestra un mensaje de confirmación en Estado
            lblEstado.Text = $"Estado: '{item.SubItems[0].Text}' agregado (Cant: {cantidad}, Subtotal: {subtotal}).";
        }


        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (lvPedido.SelectedItems.Count == 0) //comprueba si no hay ningún producto seleccionado
            {
                lblEstado.Text = "Estado: Seleccione un producto del pedido para quitar.";
                return;
            }

            ListViewItem item = lvPedido.SelectedItems[0];
            string productoQuitado = item.SubItems[0].Text;  //guarda el nombre del producto que se va a eliminar
            lvPedido.Items.Remove(item); //elimina esa fila de la lista del pedido.

            btnQuitar.Enabled = lvPedido.SelectedItems.Count > 0;  //actualiza si el botón Quitar sigue habilitado o se deshabilita
            ActualizarTotal();
            //informa en Estado cuál producto fue retirado del pedido.
            lblEstado.Text = $"Estado: '{productoQuitado}' quitado del pedido.";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //Se resetea todo o lo pone como antes desde el incio al cargar el programa 
            lvPedido.Items.Clear();
            txtCliente.Clear();
            txtProducto.Clear();
            lvCatalogo.SelectedItems.Clear();
            txtCantidad.Text = "1";
            rbtnMostrador.Checked = true;
            chkPostre.Checked = false;
            chkServilletas.Checked = false;
            btnQuitar.Enabled = false;
            
            lblEstado.Text = "Estado: Pedido reiniciado.";

            ActualizarEstadoAgregar();
            ActualizarTotal();
        }
    }
    
    }