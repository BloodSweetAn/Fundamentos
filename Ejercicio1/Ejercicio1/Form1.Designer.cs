namespace Ejercicio1
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
            textBoxBuscarDistrito = new TextBox();
            label11 = new Label();
            buttonBuscarDistrito = new Button();
            listViewProducto = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            listViewPDV = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            label1 = new Label();
            panel2 = new Panel();
            buttonLimpiarP = new Button();
            buttonRegistrarP = new Button();
            label13 = new Label();
            textBoxNombreProductos = new TextBox();
            comboBoxCategoriaProductos = new ComboBox();
            label8 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBoCodigoProductos = new TextBox();
            panel1 = new Panel();
            textBoxVentaPDV = new TextBox();
            buttonLimpiarPDV = new Button();
            buttonRegistrarPDV = new Button();
            label12 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBoxDistritoPDV = new TextBox();
            textBoxNombrePDV = new TextBox();
            textBoxCodigoPDV = new TextBox();
            label9 = new Label();
            textBoxNoVendeProducto = new TextBox();
            buttonBuscarPDVSinProducto = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxBuscarDistrito
            // 
            textBoxBuscarDistrito.Location = new Point(204, 656);
            textBoxBuscarDistrito.Name = "textBoxBuscarDistrito";
            textBoxBuscarDistrito.Size = new Size(288, 27);
            textBoxBuscarDistrito.TabIndex = 17;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(44, 659);
            label11.Name = "label11";
            label11.Size = new Size(140, 20);
            label11.TabIndex = 16;
            label11.Text = "Nombre del distrito";
            // 
            // buttonBuscarDistrito
            // 
            buttonBuscarDistrito.Location = new Point(517, 655);
            buttonBuscarDistrito.Name = "buttonBuscarDistrito";
            buttonBuscarDistrito.Size = new Size(383, 29);
            buttonBuscarDistrito.TabIndex = 15;
            buttonBuscarDistrito.Text = "Listar los PDV por distrito";
            buttonBuscarDistrito.UseVisualStyleBackColor = true;
            buttonBuscarDistrito.Click += buttonBuscarDistrito_Click;
            // 
            // listViewProducto
            // 
            listViewProducto.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6, columnHeader7 });
            listViewProducto.Location = new Point(544, 334);
            listViewProducto.Name = "listViewProducto";
            listViewProducto.Size = new Size(522, 304);
            listViewProducto.TabIndex = 14;
            listViewProducto.UseCompatibleStateImageBehavior = false;
            listViewProducto.View = View.Details;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Codigo";
            columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Nombre";
            columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Categoria";
            columnHeader7.Width = 120;
            // 
            // listViewPDV
            // 
            listViewPDV.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listViewPDV.Location = new Point(44, 334);
            listViewPDV.Name = "listViewPDV";
            listViewPDV.Size = new Size(490, 304);
            listViewPDV.TabIndex = 13;
            listViewPDV.UseCompatibleStateImageBehavior = false;
            listViewPDV.View = View.Details;
            listViewPDV.SelectedIndexChanged += listViewPDV_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Codigo";
            columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nombre";
            columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Distrito";
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Venta promedio mensual";
            columnHeader4.Width = 160;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(504, 9);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 12;
            label1.Text = "Titulo";
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonLimpiarP);
            panel2.Controls.Add(buttonRegistrarP);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(textBoxNombreProductos);
            panel2.Controls.Add(comboBoxCategoriaProductos);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(textBoCodigoProductos);
            panel2.Location = new Point(540, 37);
            panel2.Name = "panel2";
            panel2.Size = new Size(526, 291);
            panel2.TabIndex = 11;
            // 
            // buttonLimpiarP
            // 
            buttonLimpiarP.Location = new Point(301, 242);
            buttonLimpiarP.Name = "buttonLimpiarP";
            buttonLimpiarP.Size = new Size(94, 29);
            buttonLimpiarP.TabIndex = 19;
            buttonLimpiarP.Text = "Limpiar";
            buttonLimpiarP.UseVisualStyleBackColor = true;
            buttonLimpiarP.Click += buttonLimpiarP_Click;
            // 
            // buttonRegistrarP
            // 
            buttonRegistrarP.Location = new Point(129, 242);
            buttonRegistrarP.Name = "buttonRegistrarP";
            buttonRegistrarP.Size = new Size(94, 29);
            buttonRegistrarP.TabIndex = 18;
            buttonRegistrarP.Text = "Registrar";
            buttonRegistrarP.UseVisualStyleBackColor = true;
            buttonRegistrarP.Click += buttonRegistrarP_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(252, 11);
            label13.Name = "label13";
            label13.Size = new Size(75, 20);
            label13.TabIndex = 17;
            label13.Text = "Productos";
            // 
            // textBoxNombreProductos
            // 
            textBoxNombreProductos.Location = new Point(208, 115);
            textBoxNombreProductos.Name = "textBoxNombreProductos";
            textBoxNombreProductos.Size = new Size(240, 27);
            textBoxNombreProductos.TabIndex = 14;
            // 
            // comboBoxCategoriaProductos
            // 
            comboBoxCategoriaProductos.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategoriaProductos.FormattingEnabled = true;
            comboBoxCategoriaProductos.Location = new Point(208, 170);
            comboBoxCategoriaProductos.Name = "comboBoxCategoriaProductos";
            comboBoxCategoriaProductos.Size = new Size(240, 28);
            comboBoxCategoriaProductos.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(79, 173);
            label8.Name = "label8";
            label8.Size = new Size(74, 20);
            label8.TabIndex = 10;
            label8.Text = "Categoría";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(79, 118);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 9;
            label6.Text = "Nombre";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(79, 64);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 0;
            label7.Text = "Código";
            // 
            // textBoCodigoProductos
            // 
            textBoCodigoProductos.Location = new Point(208, 61);
            textBoCodigoProductos.Name = "textBoCodigoProductos";
            textBoCodigoProductos.Size = new Size(240, 27);
            textBoCodigoProductos.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBoxVentaPDV);
            panel1.Controls.Add(buttonLimpiarPDV);
            panel1.Controls.Add(buttonRegistrarPDV);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxDistritoPDV);
            panel1.Controls.Add(textBoxNombrePDV);
            panel1.Controls.Add(textBoxCodigoPDV);
            panel1.Location = new Point(44, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(490, 291);
            panel1.TabIndex = 10;
            // 
            // textBoxVentaPDV
            // 
            textBoxVentaPDV.Location = new Point(208, 187);
            textBoxVentaPDV.Name = "textBoxVentaPDV";
            textBoxVentaPDV.Size = new Size(240, 27);
            textBoxVentaPDV.TabIndex = 12;
            // 
            // buttonLimpiarPDV
            // 
            buttonLimpiarPDV.Location = new Point(288, 242);
            buttonLimpiarPDV.Name = "buttonLimpiarPDV";
            buttonLimpiarPDV.Size = new Size(94, 29);
            buttonLimpiarPDV.TabIndex = 11;
            buttonLimpiarPDV.Text = "Limpiar";
            buttonLimpiarPDV.UseVisualStyleBackColor = true;
            buttonLimpiarPDV.Click += buttonLimpiarPDV_Click;
            // 
            // buttonRegistrarPDV
            // 
            buttonRegistrarPDV.Location = new Point(106, 242);
            buttonRegistrarPDV.Name = "buttonRegistrarPDV";
            buttonRegistrarPDV.Size = new Size(94, 29);
            buttonRegistrarPDV.TabIndex = 10;
            buttonRegistrarPDV.Text = "Registrar";
            buttonRegistrarPDV.UseVisualStyleBackColor = true;
            buttonRegistrarPDV.Click += buttonRegistrarPDV_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(185, 17);
            label12.Name = "label12";
            label12.Size = new Size(109, 20);
            label12.TabIndex = 9;
            label12.Text = "Punto de Venta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 190);
            label5.Name = "label5";
            label5.Size = new Size(175, 20);
            label5.TabIndex = 8;
            label5.Text = "Venta promedio mensual";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 144);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 7;
            label4.Text = "Distrito";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 104);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 6;
            label3.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 66);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 5;
            label2.Text = "Código";
            // 
            // textBoxDistritoPDV
            // 
            textBoxDistritoPDV.Location = new Point(208, 144);
            textBoxDistritoPDV.Name = "textBoxDistritoPDV";
            textBoxDistritoPDV.Size = new Size(240, 27);
            textBoxDistritoPDV.TabIndex = 2;
            // 
            // textBoxNombrePDV
            // 
            textBoxNombrePDV.Location = new Point(208, 99);
            textBoxNombrePDV.Name = "textBoxNombrePDV";
            textBoxNombrePDV.Size = new Size(240, 27);
            textBoxNombrePDV.TabIndex = 1;
            // 
            // textBoxCodigoPDV
            // 
            textBoxCodigoPDV.Location = new Point(208, 60);
            textBoxCodigoPDV.Name = "textBoxCodigoPDV";
            textBoxCodigoPDV.Size = new Size(240, 27);
            textBoxCodigoPDV.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(46, 709);
            label9.Name = "label9";
            label9.Size = new Size(148, 20);
            label9.TabIndex = 19;
            label9.Text = "Codigo del producto";
            // 
            // textBoxNoVendeProducto
            // 
            textBoxNoVendeProducto.Location = new Point(204, 706);
            textBoxNoVendeProducto.Name = "textBoxNoVendeProducto";
            textBoxNoVendeProducto.Size = new Size(288, 27);
            textBoxNoVendeProducto.TabIndex = 20;
            // 
            // buttonBuscarPDVSinProducto
            // 
            buttonBuscarPDVSinProducto.Location = new Point(517, 706);
            buttonBuscarPDVSinProducto.Name = "buttonBuscarPDVSinProducto";
            buttonBuscarPDVSinProducto.Size = new Size(383, 29);
            buttonBuscarPDVSinProducto.TabIndex = 21;
            buttonBuscarPDVSinProducto.Text = "Listar PDV que NO venda un producto";
            buttonBuscarPDVSinProducto.UseVisualStyleBackColor = true;
            buttonBuscarPDVSinProducto.Click += buttonBuscarPDVSinProducto_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 763);
            Controls.Add(buttonBuscarPDVSinProducto);
            Controls.Add(textBoxNoVendeProducto);
            Controls.Add(label9);
            Controls.Add(textBoxBuscarDistrito);
            Controls.Add(label11);
            Controls.Add(buttonBuscarDistrito);
            Controls.Add(listViewProducto);
            Controls.Add(listViewPDV);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxBuscarDistrito;
        private Label label11;
        private Button buttonBuscarDistrito;
        private ListView listViewProducto;
        private ListView listViewPDV;
        private Label label1;
        private Panel panel2;
        private TextBox textBoxNombreProductos;
        private ComboBox comboBoxCategoriaProductos;
        private Label label8;
        private Label label6;
        private Label label7;
        private TextBox textBoCodigoProductos;
        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBoxDistritoPDV;
        private TextBox textBoxNombrePDV;
        private TextBox textBoxCodigoPDV;
        private Label label13;
        private Label label12;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button buttonLimpiarP;
        private Button buttonRegistrarP;
        private TextBox textBoxVentaPDV;
        private Button buttonLimpiarPDV;
        private Button buttonRegistrarPDV;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private Label label9;
        private TextBox textBoxNoVendeProducto;
        private Button buttonBuscarPDVSinProducto;
    }
}