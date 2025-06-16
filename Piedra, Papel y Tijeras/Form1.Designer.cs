namespace Piedra__Papel_y_Tijeras
{
    partial class PPT
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PPT));
            this.GBJugador = new System.Windows.Forms.GroupBox();
            this.GBMaquina = new System.Windows.Forms.GroupBox();
            this.RBPiedraJG = new System.Windows.Forms.RadioButton();
            this.RBPapelJG = new System.Windows.Forms.RadioButton();
            this.RBTijerasJG = new System.Windows.Forms.RadioButton();
            this.RBTijerasAI = new System.Windows.Forms.RadioButton();
            this.RBPapelAI = new System.Windows.Forms.RadioButton();
            this.RBPiedraAI = new System.Windows.Forms.RadioButton();
            this.LBLPuntajeJG = new System.Windows.Forms.Label();
            this.LBLPuntajeAI = new System.Windows.Forms.Label();
            this.TXTJG = new System.Windows.Forms.TextBox();
            this.TXTAI = new System.Windows.Forms.TextBox();
            this.IMGEspada = new System.Windows.Forms.PictureBox();
            this.BTNJugar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.LBLResultado = new System.Windows.Forms.Label();
            this.GBJugador.SuspendLayout();
            this.GBMaquina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMGEspada)).BeginInit();
            this.SuspendLayout();
            // 
            // GBJugador
            // 
            this.GBJugador.Controls.Add(this.RBTijerasJG);
            this.GBJugador.Controls.Add(this.RBPapelJG);
            this.GBJugador.Controls.Add(this.RBPiedraJG);
            this.GBJugador.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBJugador.Location = new System.Drawing.Point(29, 66);
            this.GBJugador.Name = "GBJugador";
            this.GBJugador.Size = new System.Drawing.Size(240, 354);
            this.GBJugador.TabIndex = 0;
            this.GBJugador.TabStop = false;
            this.GBJugador.Text = "Jugador";
            // 
            // GBMaquina
            // 
            this.GBMaquina.Controls.Add(this.RBTijerasAI);
            this.GBMaquina.Controls.Add(this.RBPiedraAI);
            this.GBMaquina.Controls.Add(this.RBPapelAI);
            this.GBMaquina.Enabled = false;
            this.GBMaquina.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBMaquina.Location = new System.Drawing.Point(532, 66);
            this.GBMaquina.Name = "GBMaquina";
            this.GBMaquina.Size = new System.Drawing.Size(240, 354);
            this.GBMaquina.TabIndex = 1;
            this.GBMaquina.TabStop = false;
            this.GBMaquina.Text = "Maquina";
            // 
            // RBPiedraJG
            // 
            this.RBPiedraJG.AutoSize = true;
            this.RBPiedraJG.Location = new System.Drawing.Point(36, 65);
            this.RBPiedraJG.Name = "RBPiedraJG";
            this.RBPiedraJG.Size = new System.Drawing.Size(67, 19);
            this.RBPiedraJG.TabIndex = 0;
            this.RBPiedraJG.TabStop = true;
            this.RBPiedraJG.Text = "Piedra";
            this.RBPiedraJG.UseVisualStyleBackColor = true;
            // 
            // RBPapelJG
            // 
            this.RBPapelJG.AutoSize = true;
            this.RBPapelJG.Location = new System.Drawing.Point(36, 120);
            this.RBPapelJG.Name = "RBPapelJG";
            this.RBPapelJG.Size = new System.Drawing.Size(61, 19);
            this.RBPapelJG.TabIndex = 1;
            this.RBPapelJG.TabStop = true;
            this.RBPapelJG.Text = "Papel";
            this.RBPapelJG.UseVisualStyleBackColor = true;
            // 
            // RBTijerasJG
            // 
            this.RBTijerasJG.AutoSize = true;
            this.RBTijerasJG.Location = new System.Drawing.Point(36, 174);
            this.RBTijerasJG.Name = "RBTijerasJG";
            this.RBTijerasJG.Size = new System.Drawing.Size(70, 19);
            this.RBTijerasJG.TabIndex = 2;
            this.RBTijerasJG.TabStop = true;
            this.RBTijerasJG.Text = "Tijeras";
            this.RBTijerasJG.UseVisualStyleBackColor = true;
            // 
            // RBTijerasAI
            // 
            this.RBTijerasAI.AutoSize = true;
            this.RBTijerasAI.Location = new System.Drawing.Point(42, 174);
            this.RBTijerasAI.Name = "RBTijerasAI";
            this.RBTijerasAI.Size = new System.Drawing.Size(70, 19);
            this.RBTijerasAI.TabIndex = 5;
            this.RBTijerasAI.TabStop = true;
            this.RBTijerasAI.Text = "Tijeras";
            this.RBTijerasAI.UseVisualStyleBackColor = true;
            // 
            // RBPapelAI
            // 
            this.RBPapelAI.AutoSize = true;
            this.RBPapelAI.Location = new System.Drawing.Point(42, 120);
            this.RBPapelAI.Name = "RBPapelAI";
            this.RBPapelAI.Size = new System.Drawing.Size(61, 19);
            this.RBPapelAI.TabIndex = 4;
            this.RBPapelAI.TabStop = true;
            this.RBPapelAI.Text = "Papel";
            this.RBPapelAI.UseVisualStyleBackColor = true;
            // 
            // RBPiedraAI
            // 
            this.RBPiedraAI.AutoSize = true;
            this.RBPiedraAI.Location = new System.Drawing.Point(42, 65);
            this.RBPiedraAI.Name = "RBPiedraAI";
            this.RBPiedraAI.Size = new System.Drawing.Size(67, 19);
            this.RBPiedraAI.TabIndex = 3;
            this.RBPiedraAI.TabStop = true;
            this.RBPiedraAI.Text = "Piedra";
            this.RBPiedraAI.UseVisualStyleBackColor = true;
            // 
            // LBLPuntajeJG
            // 
            this.LBLPuntajeJG.AutoSize = true;
            this.LBLPuntajeJG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLPuntajeJG.Location = new System.Drawing.Point(26, 25);
            this.LBLPuntajeJG.Name = "LBLPuntajeJG";
            this.LBLPuntajeJG.Size = new System.Drawing.Size(71, 13);
            this.LBLPuntajeJG.TabIndex = 2;
            this.LBLPuntajeJG.Text = "PUNTAJE :";
            // 
            // LBLPuntajeAI
            // 
            this.LBLPuntajeAI.AutoSize = true;
            this.LBLPuntajeAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLPuntajeAI.Location = new System.Drawing.Point(529, 25);
            this.LBLPuntajeAI.Name = "LBLPuntajeAI";
            this.LBLPuntajeAI.Size = new System.Drawing.Size(71, 13);
            this.LBLPuntajeAI.TabIndex = 3;
            this.LBLPuntajeAI.Text = "PUNTAJE :";
            // 
            // TXTJG
            // 
            this.TXTJG.Location = new System.Drawing.Point(108, 22);
            this.TXTJG.Name = "TXTJG";
            this.TXTJG.Size = new System.Drawing.Size(161, 20);
            this.TXTJG.TabIndex = 4;
            // 
            // TXTAI
            // 
            this.TXTAI.Location = new System.Drawing.Point(611, 22);
            this.TXTAI.Name = "TXTAI";
            this.TXTAI.Size = new System.Drawing.Size(161, 20);
            this.TXTAI.TabIndex = 5;
            // 
            // IMGEspada
            // 
            this.IMGEspada.Image = global::Piedra__Papel_y_Tijeras.Properties.Resources.Diamond_Sword_25716;
            this.IMGEspada.Location = new System.Drawing.Point(313, 66);
            this.IMGEspada.Name = "IMGEspada";
            this.IMGEspada.Size = new System.Drawing.Size(174, 168);
            this.IMGEspada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IMGEspada.TabIndex = 6;
            this.IMGEspada.TabStop = false;
            // 
            // BTNJugar
            // 
            this.BTNJugar.BackColor = System.Drawing.SystemColors.Highlight;
            this.BTNJugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNJugar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNJugar.Location = new System.Drawing.Point(313, 369);
            this.BTNJugar.Name = "BTNJugar";
            this.BTNJugar.Size = new System.Drawing.Size(174, 51);
            this.BTNJugar.TabIndex = 7;
            this.BTNJugar.Text = "Batallar!";
            this.BTNJugar.UseVisualStyleBackColor = false;
            this.BTNJugar.Click += new System.EventHandler(this.BTNJugar_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // LBLResultado
            // 
            this.LBLResultado.AutoSize = true;
            this.LBLResultado.Location = new System.Drawing.Point(369, 284);
            this.LBLResultado.Name = "LBLResultado";
            this.LBLResultado.Size = new System.Drawing.Size(60, 13);
            this.LBLResultado.TabIndex = 8;
            this.LBLResultado.Text = "Resultados";
            // 
            // PPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LBLResultado);
            this.Controls.Add(this.BTNJugar);
            this.Controls.Add(this.IMGEspada);
            this.Controls.Add(this.TXTAI);
            this.Controls.Add(this.TXTJG);
            this.Controls.Add(this.LBLPuntajeAI);
            this.Controls.Add(this.LBLPuntajeJG);
            this.Controls.Add(this.GBMaquina);
            this.Controls.Add(this.GBJugador);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PPT";
            this.Text = "Piedra, Papel y Tijeras";
            this.GBJugador.ResumeLayout(false);
            this.GBJugador.PerformLayout();
            this.GBMaquina.ResumeLayout(false);
            this.GBMaquina.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMGEspada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GBJugador;
        private System.Windows.Forms.RadioButton RBTijerasJG;
        private System.Windows.Forms.RadioButton RBPapelJG;
        private System.Windows.Forms.RadioButton RBPiedraJG;
        private System.Windows.Forms.GroupBox GBMaquina;
        private System.Windows.Forms.RadioButton RBTijerasAI;
        private System.Windows.Forms.RadioButton RBPiedraAI;
        private System.Windows.Forms.RadioButton RBPapelAI;
        private System.Windows.Forms.Label LBLPuntajeJG;
        private System.Windows.Forms.Label LBLPuntajeAI;
        private System.Windows.Forms.TextBox TXTJG;
        private System.Windows.Forms.TextBox TXTAI;
        private System.Windows.Forms.PictureBox IMGEspada;
        private System.Windows.Forms.Button BTNJugar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label LBLResultado;
    }
}

