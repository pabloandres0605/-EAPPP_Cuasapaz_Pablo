namespace Prueba_B1_Diseño
{
    partial class Form1
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
            SuspendLayout();
            // 
            // lvCatalogo
            // 
            lvCatalogo.Location = new Point(27, 35);
            lvCatalogo.Name = "lvCatalogo";
            lvCatalogo.Size = new Size(363, 298);
            lvCatalogo.TabIndex = 0;
            lvCatalogo.UseCompatibleStateImageBehavior = false;
            lvCatalogo.SelectedIndexChanged += lvCatalogo_SelectedIndexChanged;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(409, 25);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(267, 23);
            txtCliente.TabIndex = 1;
            txtCliente.TextChanged += txtCliente_TextChanged;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(409, 68);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(159, 23);
            txtProducto.TabIndex = 2;
            txtProducto.TextChanged += txtProducto_TextChanged;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(409, 109);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 3;
            txtCantidad.TextChanged += txtCantidad_TextChanged;
            // 
            // rbtnMostrador
            // 
            rbtnMostrador.AutoSize = true;
            rbtnMostrador.Location = new Point(409, 151);
            rbtnMostrador.Name = "rbtnMostrador";
            rbtnMostrador.Size = new Size(130, 19);
            rbtnMostrador.TabIndex = 4;
            rbtnMostrador.TabStop = true;
            rbtnMostrador.Text = "Retiro en Mostrador";
            rbtnMostrador.UseVisualStyleBackColor = true;
            rbtnMostrador.CheckedChanged += rbtnMostrador_CheckedChanged;
            // 
            // rbtnEntrega
            // 
            rbtnEntrega.AutoSize = true;
            rbtnEntrega.Location = new Point(409, 176);
            rbtnEntrega.Name = "rbtnEntrega";
            rbtnEntrega.Size = new Size(106, 19);
            rbtnEntrega.TabIndex = 5;
            rbtnEntrega.TabStop = true;
            rbtnEntrega.Text = "Entrega en aula";
            rbtnEntrega.UseVisualStyleBackColor = true;
            rbtnEntrega.CheckedChanged += rbtnEntrega_CheckedChanged;
            // 
            // chkPostre
            // 
            chkPostre.AutoSize = true;
            chkPostre.Location = new Point(27, 356);
            chkPostre.Name = "chkPostre";
            chkPostre.Size = new Size(97, 19);
            chkPostre.TabIndex = 6;
            chkPostre.Text = "Postre del dia";
            chkPostre.UseVisualStyleBackColor = true;
            chkPostre.CheckedChanged += chkPostre_CheckedChanged;
            // 
            // chkServilletas
            // 
            chkServilletas.AutoSize = true;
            chkServilletas.Location = new Point(27, 393);
            chkServilletas.Name = "chkServilletas";
            chkServilletas.Size = new Size(134, 19);
            chkServilletas.TabIndex = 7;
            chkServilletas.Text = "Servilletas/Cubiertos";
            chkServilletas.UseVisualStyleBackColor = true;
            chkServilletas.CheckedChanged += chkServilletas_CheckedChanged;
            // 
            // lvPedido
            // 
            lvPedido.Location = new Point(698, 25);
            lvPedido.Name = "lvPedido";
            lvPedido.Size = new Size(374, 229);
            lvPedido.TabIndex = 8;
            lvPedido.UseCompatibleStateImageBehavior = false;
            lvPedido.SelectedIndexChanged += lvPedido_SelectedIndexChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(409, 231);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(116, 23);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar item";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnQuitar
            // 
            btnQuitar.Location = new Point(409, 273);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(128, 23);
            btnQuitar.TabIndex = 10;
            btnQuitar.Text = "Quitar Seleccionado";
            btnQuitar.UseVisualStyleBackColor = true;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(409, 310);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(110, 23);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar Pedido";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(712, 277);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(48, 15);
            lblEstado.TabIndex = 12;
            lblEstado.Text = "Estado: ";
            lblEstado.Click += lblEstado_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(712, 301);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(39, 15);
            lblTotal.TabIndex = 13;
            lblTotal.Text = "Total: ";
            lblTotal.Click += lblTotal_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1101, 450);
            Controls.Add(lblTotal);
            Controls.Add(lblEstado);
            Controls.Add(btnLimpiar);
            Controls.Add(btnQuitar);
            Controls.Add(btnAgregar);
            Controls.Add(lvPedido);
            Controls.Add(chkServilletas);
            Controls.Add(chkPostre);
            Controls.Add(rbtnEntrega);
            Controls.Add(rbtnMostrador);
            Controls.Add(txtCantidad);
            Controls.Add(txtProducto);
            Controls.Add(txtCliente);
            Controls.Add(lvCatalogo);
            Name = "Form1";
            Text = "Form1";
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
    }
}
