
namespace Cotizaciones
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.nombreVendedor = new System.Windows.Forms.Label();
            this.idVendedor = new System.Windows.Forms.Label();
            this.direccionTienda = new System.Windows.Forms.Label();
            this.nombreTienda = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pantalon = new System.Windows.Forms.RadioButton();
            this.camisa = new System.Windows.Forms.RadioButton();
            this.mangaCorta = new System.Windows.Forms.CheckBox();
            this.cuelloMao = new System.Windows.Forms.CheckBox();
            this.chupin = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.stock = new System.Windows.Forms.Label();
            this.standard = new System.Windows.Forms.RadioButton();
            this.premium = new System.Windows.Forms.RadioButton();
            this.precio = new System.Windows.Forms.TextBox();
            this.cantidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.Label();
            this.calidad = new System.Windows.Forms.GroupBox();
            this.prenda = new System.Windows.Forms.GroupBox();
            this.calidad.SuspendLayout();
            this.prenda.SuspendLayout();
            this.SuspendLayout();
            // 
            // nombreVendedor
            // 
            this.nombreVendedor.AutoSize = true;
            this.nombreVendedor.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreVendedor.Location = new System.Drawing.Point(12, 90);
            this.nombreVendedor.Name = "nombreVendedor";
            this.nombreVendedor.Size = new System.Drawing.Size(199, 27);
            this.nombreVendedor.TabIndex = 0;
            this.nombreVendedor.Text = "Nombre Vendedor";
            // 
            // idVendedor
            // 
            this.idVendedor.AutoSize = true;
            this.idVendedor.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idVendedor.Location = new System.Drawing.Point(266, 90);
            this.idVendedor.Name = "idVendedor";
            this.idVendedor.Size = new System.Drawing.Size(139, 27);
            this.idVendedor.TabIndex = 1;
            this.idVendedor.Text = "ID Vendedor";
            // 
            // direccionTienda
            // 
            this.direccionTienda.AutoSize = true;
            this.direccionTienda.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccionTienda.Location = new System.Drawing.Point(201, 9);
            this.direccionTienda.Name = "direccionTienda";
            this.direccionTienda.Size = new System.Drawing.Size(181, 27);
            this.direccionTienda.TabIndex = 2;
            this.direccionTienda.Text = "Direccion Tienda";
            // 
            // nombreTienda
            // 
            this.nombreTienda.AutoSize = true;
            this.nombreTienda.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTienda.Location = new System.Drawing.Point(12, 9);
            this.nombreTienda.Name = "nombreTienda";
            this.nombreTienda.Size = new System.Drawing.Size(170, 27);
            this.nombreTienda.TabIndex = 3;
            this.nombreTienda.Text = "Nombre Tienda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Historial Cotizaciones";
            // 
            // pantalon
            // 
            this.pantalon.AutoSize = true;
            this.pantalon.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pantalon.Location = new System.Drawing.Point(23, 77);
            this.pantalon.Name = "pantalon";
            this.pantalon.Size = new System.Drawing.Size(120, 31);
            this.pantalon.TabIndex = 7;
            this.pantalon.Text = "Pantalon";
            this.pantalon.UseVisualStyleBackColor = true;
            // 
            // camisa
            // 
            this.camisa.AutoSize = true;
            this.camisa.Checked = true;
            this.camisa.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.camisa.Location = new System.Drawing.Point(23, 26);
            this.camisa.Name = "camisa";
            this.camisa.Size = new System.Drawing.Size(103, 31);
            this.camisa.TabIndex = 8;
            this.camisa.TabStop = true;
            this.camisa.Text = "Camisa";
            this.camisa.UseVisualStyleBackColor = true;
            // 
            // mangaCorta
            // 
            this.mangaCorta.AutoSize = true;
            this.mangaCorta.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mangaCorta.Location = new System.Drawing.Point(161, 31);
            this.mangaCorta.Name = "mangaCorta";
            this.mangaCorta.Size = new System.Drawing.Size(134, 26);
            this.mangaCorta.TabIndex = 9;
            this.mangaCorta.Text = "Manga Corta";
            this.mangaCorta.UseVisualStyleBackColor = true;
            // 
            // cuelloMao
            // 
            this.cuelloMao.AutoSize = true;
            this.cuelloMao.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuelloMao.Location = new System.Drawing.Point(298, 31);
            this.cuelloMao.Name = "cuelloMao";
            this.cuelloMao.Size = new System.Drawing.Size(121, 26);
            this.cuelloMao.TabIndex = 10;
            this.cuelloMao.Text = "Cuello Mao";
            this.cuelloMao.UseVisualStyleBackColor = true;
            // 
            // chupin
            // 
            this.chupin.AutoSize = true;
            this.chupin.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chupin.Location = new System.Drawing.Point(161, 82);
            this.chupin.Name = "chupin";
            this.chupin.Size = new System.Drawing.Size(86, 26);
            this.chupin.TabIndex = 11;
            this.chupin.Text = "Chupín";
            this.chupin.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(330, 27);
            this.label4.TabIndex = 12;
            this.label4.Text = "Unidades de stock disponibles: ";
            // 
            // stock
            // 
            this.stock.AutoSize = true;
            this.stock.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock.Location = new System.Drawing.Point(330, 311);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(36, 27);
            this.stock.TabIndex = 13;
            this.stock.Text = "00";
            // 
            // standard
            // 
            this.standard.AutoSize = true;
            this.standard.Checked = true;
            this.standard.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standard.Location = new System.Drawing.Point(62, 19);
            this.standard.Name = "standard";
            this.standard.Size = new System.Drawing.Size(121, 31);
            this.standard.TabIndex = 14;
            this.standard.TabStop = true;
            this.standard.Text = "Standard";
            this.standard.UseVisualStyleBackColor = true;
            // 
            // premium
            // 
            this.premium.AutoSize = true;
            this.premium.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.premium.Location = new System.Drawing.Point(230, 19);
            this.premium.Name = "premium";
            this.premium.Size = new System.Drawing.Size(122, 31);
            this.premium.TabIndex = 15;
            this.premium.Text = "Premium";
            this.premium.UseVisualStyleBackColor = true;
            // 
            // precio
            // 
            this.precio.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precio.Location = new System.Drawing.Point(104, 441);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(72, 33);
            this.precio.TabIndex = 16;
            // 
            // cantidad
            // 
            this.cantidad.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidad.Location = new System.Drawing.Point(303, 441);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(54, 33);
            this.cantidad.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(74, 444);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 27);
            this.label6.TabIndex = 18;
            this.label6.Text = "$";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(195, 444);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 27);
            this.label7.TabIndex = 19;
            this.label7.Text = "Cantidad";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(35, 524);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 52);
            this.button1.TabIndex = 20;
            this.button1.Text = "Cotizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(200, 532);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 36);
            this.label8.TabIndex = 21;
            this.label8.Text = "$";
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.Location = new System.Drawing.Point(223, 532);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(49, 36);
            this.resultado.TabIndex = 22;
            this.resultado.Text = "00";
            // 
            // calidad
            // 
            this.calidad.Controls.Add(this.premium);
            this.calidad.Controls.Add(this.standard);
            this.calidad.Location = new System.Drawing.Point(17, 350);
            this.calidad.Name = "calidad";
            this.calidad.Size = new System.Drawing.Size(441, 76);
            this.calidad.TabIndex = 23;
            this.calidad.TabStop = false;
            this.calidad.Text = "Calidad de Prenda";
            // 
            // prenda
            // 
            this.prenda.Controls.Add(this.camisa);
            this.prenda.Controls.Add(this.pantalon);
            this.prenda.Controls.Add(this.mangaCorta);
            this.prenda.Controls.Add(this.cuelloMao);
            this.prenda.Controls.Add(this.chupin);
            this.prenda.Location = new System.Drawing.Point(12, 172);
            this.prenda.Name = "prenda";
            this.prenda.Size = new System.Drawing.Size(446, 125);
            this.prenda.TabIndex = 24;
            this.prenda.TabStop = false;
            this.prenda.Text = "Prenda";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 624);
            this.Controls.Add(this.prenda);
            this.Controls.Add(this.calidad);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.idVendedor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.stock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nombreTienda);
            this.Controls.Add(this.direccionTienda);
            this.Controls.Add(this.nombreVendedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.calidad.ResumeLayout(false);
            this.calidad.PerformLayout();
            this.prenda.ResumeLayout(false);
            this.prenda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nombreVendedor;
        private System.Windows.Forms.Label idVendedor;
        private System.Windows.Forms.Label direccionTienda;
        private System.Windows.Forms.Label nombreTienda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton pantalon;
        private System.Windows.Forms.RadioButton camisa;
        private System.Windows.Forms.CheckBox mangaCorta;
        private System.Windows.Forms.CheckBox cuelloMao;
        private System.Windows.Forms.CheckBox chupin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label stock;
        private System.Windows.Forms.RadioButton standard;
        private System.Windows.Forms.RadioButton premium;
        private System.Windows.Forms.TextBox precio;
        private System.Windows.Forms.TextBox cantidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.GroupBox calidad;
        private System.Windows.Forms.GroupBox prenda;
    }
}

