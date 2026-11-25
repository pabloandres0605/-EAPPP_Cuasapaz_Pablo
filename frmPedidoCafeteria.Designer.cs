using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Prueba_B1_Diseño
{
    partial class frmPedidoCafeteria
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lvCatalogo = new ListView();
            txtCliente = new TextBox();
            txtProducto = new TextBox();
            txtCantidad = new TextBox();
            rbtnMostrador = new RadioButton();
            rbtnEntrega = new RadioButton();
            chkPostre = new CheckBox();
            chkServilletas = new CheckBox();
            lvPedido = new ListView();
            btnAgregar = new Button();
            btnQuitar = new Button();
            btnLimpiar = new Button();
            lblEstado = new Label();
            lblTotal = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label5 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lvCatalogo
            // 
            lvCatalogo.BackColor = Color.FromArgb(192, 255, 255);
            lvCatalogo.FullRowSelect = true;
            lvCatalogo.Location = new Point(21, 72);
            lvCatalogo.Margin = new Padding(3, 4, 3, 4);
            lvCatalogo.MultiSelect = false;
            lvCatalogo.Name = "lvCatalogo";
            lvCatalogo.Size = new Size(281, 396);
            lvCatalogo.TabIndex = 0;
            lvCatalogo.UseCompatibleStateImageBehavior = false;
            lvCatalogo.View = View.Details;
            lvCatalogo.SelectedIndexChanged += lvCatalogo_SelectedIndexChanged;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(415, 34);
            txtCliente.Margin = new Padding(3, 4, 3, 4);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(305, 27);
            txtCliente.TabIndex = 1;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(415, 92);
            txtProducto.Margin = new Padding(3, 4, 3, 4);
            txtProducto.Name = "txtProducto";
            txtProducto.ReadOnly = true;
            txtProducto.Size = new Size(181, 27);
            txtProducto.TabIndex = 2;
            txtProducto.TextChanged += txtProducto_TextChanged;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(679, 92);
            txtCantidad.Margin = new Padding(3, 4, 3, 4);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(41, 27);
            txtCantidad.TabIndex = 3;
            txtCantidad.Text = "1";
            txtCantidad.TextChanged += txtCantidad_TextChanged;
            txtCantidad.Validating += txtCantidad_Validating;
            // 
            // rbtnMostrador
            // 
            rbtnMostrador.AutoSize = true;
            rbtnMostrador.Checked = true;
            rbtnMostrador.Location = new Point(15, 27);
            rbtnMostrador.Margin = new Padding(3, 4, 3, 4);
            rbtnMostrador.Name = "rbtnMostrador";
            rbtnMostrador.Size = new Size(163, 24);
            rbtnMostrador.TabIndex = 4;
            rbtnMostrador.TabStop = true;
            rbtnMostrador.Text = "Retiro en Mostrador";
            rbtnMostrador.UseVisualStyleBackColor = true;
            rbtnMostrador.CheckedChanged += rbtnMostrador_CheckedChanged;
            // 
            // rbtnEntrega
            // 
            rbtnEntrega.AutoSize = true;
            rbtnEntrega.Location = new Point(15, 72);
            rbtnEntrega.Margin = new Padding(3, 4, 3, 4);
            rbtnEntrega.Name = "rbtnEntrega";
            rbtnEntrega.Size = new Size(184, 24);
            rbtnEntrega.TabIndex = 5;
            rbtnEntrega.Text = "Entrega en aula (+$0.5)";
            rbtnEntrega.UseVisualStyleBackColor = true;
            rbtnEntrega.CheckedChanged += rbtnEntrega_CheckedChanged;
            // 
            // chkPostre
            // 
            chkPostre.AutoSize = true;
            chkPostre.Location = new Point(6, 27);
            chkPostre.Margin = new Padding(3, 4, 3, 4);
            chkPostre.Name = "chkPostre";
            chkPostre.Size = new Size(180, 24);
            chkPostre.TabIndex = 6;
            chkPostre.Text = "Postre del dia (+$1.00)";
            chkPostre.UseVisualStyleBackColor = true;
            chkPostre.CheckedChanged += chkPostre_CheckedChanged;
            // 
            // chkServilletas
            // 
            chkServilletas.AutoSize = true;
            chkServilletas.Location = new Point(6, 76);
            chkServilletas.Margin = new Padding(3, 4, 3, 4);
            chkServilletas.Name = "chkServilletas";
            chkServilletas.Size = new Size(167, 24);
            chkServilletas.TabIndex = 7;
            chkServilletas.Text = "Servilletas/Cubiertos";
            chkServilletas.UseVisualStyleBackColor = true;
            chkServilletas.CheckedChanged += chkServilletas_CheckedChanged;
            // 
            // lvPedido
            // 
            lvPedido.BackColor = Color.FromArgb(192, 192, 255);
            lvPedido.FullRowSelect = true;
            lvPedido.Location = new Point(792, 72);
            lvPedido.Margin = new Padding(3, 4, 3, 4);
            lvPedido.Name = "lvPedido";
            lvPedido.Size = new Size(332, 304);
            lvPedido.TabIndex = 8;
            lvPedido.UseCompatibleStateImageBehavior = false;
            lvPedido.View = View.Details;
            lvPedido.SelectedIndexChanged += lvPedido_SelectedIndexChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(128, 255, 128);
            btnAgregar.Enabled = false;
            btnAgregar.Location = new Point(328, 293);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(133, 53);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar item";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnQuitar
            // 
            btnQuitar.BackColor = Color.FromArgb(255, 255, 128);
            btnQuitar.Enabled = false;
            btnQuitar.Location = new Point(467, 293);
            btnQuitar.Margin = new Padding(3, 4, 3, 4);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(146, 53);
            btnQuitar.TabIndex = 10;
            btnQuitar.Text = "Quitar Seleccionado";
            btnQuitar.UseVisualStyleBackColor = false;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(255, 128, 128);
            btnLimpiar.CausesValidation = false;
            btnLimpiar.Location = new Point(630, 293);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(133, 54);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar Pedido";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new System.Drawing.Font("Segoe UI", 12F, FontStyle.Bold);
            lblEstado.Location = new Point(328, 440);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(314, 28);
            lblEstado.TabIndex = 12;
            lblEstado.Text = "Estado:  Seleccione un producto";

            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new System.Drawing.Font("Segoe UI", 15F, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(0, 192, 0);
            lblTotal.Location = new Point(974, 392);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(150, 35);
            lblTotal.TabIndex = 13;
            lblTotal.Text = "Total: $0.00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(21, 33);
            label1.Name = "label1";
            label1.Size = new Size(231, 28);
            label1.TabIndex = 14;
            label1.Text = "Cátalogo de Productos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(332, 34);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 15;
            label2.Text = "Cliente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(332, 95);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 16;
            label3.Text = "Producto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(628, 95);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 17;
            label4.Text = "Cant:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtnMostrador);
            groupBox1.Controls.Add(rbtnEntrega);
            groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            groupBox1.Location = new Point(328, 141);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 125);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Modalidad de Atención";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chkPostre);
            groupBox2.Controls.Add(chkServilletas);
            groupBox2.Location = new Point(21, 488);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 125);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Extras del Pedido";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(792, 40);
            label5.Name = "label5";
            label5.Size = new Size(185, 28);
            label5.TabIndex = 20;
            label5.Text = "Detalle del Pedido";
            // 
            // frmPedidoCafeteria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1174, 631);
            Controls.Add(label5);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTotal);
            Controls.Add(lblEstado);
            Controls.Add(btnLimpiar);
            Controls.Add(btnQuitar);
            Controls.Add(btnAgregar);
            Controls.Add(lvPedido);
            Controls.Add(txtCantidad);
            Controls.Add(txtProducto);
            Controls.Add(txtCliente);
            Controls.Add(lvCatalogo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmPedidoCafeteria";
            Text = "Cafetería";
            Load += frmPedidoCafeteria_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvCatalogo;
        private TextBox txtCliente;
        private TextBox txtProducto;
        private TextBox txtCantidad;
        private RadioButton rbtnMostrador;
        private RadioButton rbtnEntrega;
        private CheckBox chkPostre;
        private CheckBox chkServilletas;
        private ListView lvPedido;
        private Button btnAgregar;
        private Button btnQuitar;
        private Button btnLimpiar;
        private Label lblEstado;
        private Label lblTotal;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label5;
    }
}
