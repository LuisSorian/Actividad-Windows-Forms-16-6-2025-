namespace Actividad_Clase
{
    partial class APDescuento
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
            this.GBCantidad = new System.Windows.Forms.GroupBox();
            this.GBDescuento = new System.Windows.Forms.GroupBox();
            this.GBTotal = new System.Windows.Forms.GroupBox();
            this.LBLPrecio = new System.Windows.Forms.Label();
            this.TXTBPrecio = new System.Windows.Forms.TextBox();
            this.RB5 = new System.Windows.Forms.RadioButton();
            this.RB15 = new System.Windows.Forms.RadioButton();
            this.RB20 = new System.Windows.Forms.RadioButton();
            this.TXTBTotal = new System.Windows.Forms.TextBox();
            this.LBLError = new System.Windows.Forms.Label();
            this.BTNCalcular = new System.Windows.Forms.Button();
            this.GBCantidad.SuspendLayout();
            this.GBDescuento.SuspendLayout();
            this.GBTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBCantidad
            // 
            this.GBCantidad.Controls.Add(this.BTNCalcular);
            this.GBCantidad.Controls.Add(this.TXTBPrecio);
            this.GBCantidad.Controls.Add(this.LBLPrecio);
            this.GBCantidad.Font = new System.Drawing.Font("Papyrus", 11.25F, System.Drawing.FontStyle.Bold);
            this.GBCantidad.Location = new System.Drawing.Point(18, 16);
            this.GBCantidad.Name = "GBCantidad";
            this.GBCantidad.Size = new System.Drawing.Size(466, 172);
            this.GBCantidad.TabIndex = 0;
            this.GBCantidad.TabStop = false;
            this.GBCantidad.Text = "Cantidad";
            // 
            // GBDescuento
            // 
            this.GBDescuento.Controls.Add(this.RB20);
            this.GBDescuento.Controls.Add(this.RB15);
            this.GBDescuento.Controls.Add(this.RB5);
            this.GBDescuento.Font = new System.Drawing.Font("Papyrus", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBDescuento.Location = new System.Drawing.Point(502, 16);
            this.GBDescuento.Name = "GBDescuento";
            this.GBDescuento.Size = new System.Drawing.Size(274, 171);
            this.GBDescuento.TabIndex = 1;
            this.GBDescuento.TabStop = false;
            this.GBDescuento.Text = "Descuento %";
            // 
            // GBTotal
            // 
            this.GBTotal.Controls.Add(this.LBLError);
            this.GBTotal.Controls.Add(this.TXTBTotal);
            this.GBTotal.Font = new System.Drawing.Font("Papyrus", 11.25F, System.Drawing.FontStyle.Bold);
            this.GBTotal.Location = new System.Drawing.Point(18, 221);
            this.GBTotal.Name = "GBTotal";
            this.GBTotal.Size = new System.Drawing.Size(758, 171);
            this.GBTotal.TabIndex = 2;
            this.GBTotal.TabStop = false;
            this.GBTotal.Text = "Total";
            // 
            // LBLPrecio
            // 
            this.LBLPrecio.AutoSize = true;
            this.LBLPrecio.Location = new System.Drawing.Point(26, 82);
            this.LBLPrecio.Name = "LBLPrecio";
            this.LBLPrecio.Size = new System.Drawing.Size(58, 24);
            this.LBLPrecio.TabIndex = 0;
            this.LBLPrecio.Text = "Precio";
            this.LBLPrecio.Click += new System.EventHandler(this.LBLPrecio_Click);
            // 
            // TXTBPrecio
            // 
            this.TXTBPrecio.Location = new System.Drawing.Point(90, 79);
            this.TXTBPrecio.Name = "TXTBPrecio";
            this.TXTBPrecio.Size = new System.Drawing.Size(252, 31);
            this.TXTBPrecio.TabIndex = 1;
            this.TXTBPrecio.TextChanged += new System.EventHandler(this.TXTBPrecio_TextChanged);
            // 
            // RB5
            // 
            this.RB5.AutoSize = true;
            this.RB5.Location = new System.Drawing.Point(35, 36);
            this.RB5.Name = "RB5";
            this.RB5.Size = new System.Drawing.Size(49, 28);
            this.RB5.TabIndex = 0;
            this.RB5.TabStop = true;
            this.RB5.Text = "5%";
            this.RB5.UseVisualStyleBackColor = true;
            // 
            // RB15
            // 
            this.RB15.AutoSize = true;
            this.RB15.Location = new System.Drawing.Point(35, 70);
            this.RB15.Name = "RB15";
            this.RB15.Size = new System.Drawing.Size(59, 28);
            this.RB15.TabIndex = 1;
            this.RB15.TabStop = true;
            this.RB15.Text = "15%";
            this.RB15.UseVisualStyleBackColor = true;
            // 
            // RB20
            // 
            this.RB20.AutoSize = true;
            this.RB20.Location = new System.Drawing.Point(35, 104);
            this.RB20.Name = "RB20";
            this.RB20.Size = new System.Drawing.Size(59, 28);
            this.RB20.TabIndex = 2;
            this.RB20.TabStop = true;
            this.RB20.Text = "20%";
            this.RB20.UseVisualStyleBackColor = true;
            // 
            // TXTBTotal
            // 
            this.TXTBTotal.Location = new System.Drawing.Point(48, 78);
            this.TXTBTotal.Name = "TXTBTotal";
            this.TXTBTotal.Size = new System.Drawing.Size(350, 31);
            this.TXTBTotal.TabIndex = 2;
            // 
            // LBLError
            // 
            this.LBLError.AutoSize = true;
            this.LBLError.Location = new System.Drawing.Point(416, 81);
            this.LBLError.Name = "LBLError";
            this.LBLError.Size = new System.Drawing.Size(106, 24);
            this.LBLError.TabIndex = 2;
            this.LBLError.Text = "No se aplico";
            // 
            // BTNCalcular
            // 
            this.BTNCalcular.Location = new System.Drawing.Point(355, 79);
            this.BTNCalcular.Name = "BTNCalcular";
            this.BTNCalcular.Size = new System.Drawing.Size(96, 30);
            this.BTNCalcular.TabIndex = 2;
            this.BTNCalcular.Text = "Calcular";
            this.BTNCalcular.UseVisualStyleBackColor = true;
            this.BTNCalcular.Click += new System.EventHandler(this.BTNCalcular_Click);
            // 
            // APDescuento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 421);
            this.Controls.Add(this.GBTotal);
            this.Controls.Add(this.GBDescuento);
            this.Controls.Add(this.GBCantidad);
            this.Name = "APDescuento";
            this.Text = "Calculadora de Descuento";
            this.Load += new System.EventHandler(this.APDescuento_Load);
            this.GBCantidad.ResumeLayout(false);
            this.GBCantidad.PerformLayout();
            this.GBDescuento.ResumeLayout(false);
            this.GBDescuento.PerformLayout();
            this.GBTotal.ResumeLayout(false);
            this.GBTotal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBCantidad;
        private System.Windows.Forms.TextBox TXTBPrecio;
        private System.Windows.Forms.Label LBLPrecio;
        private System.Windows.Forms.GroupBox GBDescuento;
        private System.Windows.Forms.GroupBox GBTotal;
        private System.Windows.Forms.RadioButton RB20;
        private System.Windows.Forms.RadioButton RB15;
        private System.Windows.Forms.RadioButton RB5;
        private System.Windows.Forms.Label LBLError;
        private System.Windows.Forms.TextBox TXTBTotal;
        private System.Windows.Forms.Button BTNCalcular;
    }
}

