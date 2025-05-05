namespace PryLopresti20250505
{
    partial class FrmIProyectoBase
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
            this.cmbHeroes = new System.Windows.Forms.ComboBox();
            this.imgHeroes = new System.Windows.Forms.PictureBox();
            this.mcrCrear = new System.Windows.Forms.GroupBox();
            this.numDestreza = new System.Windows.Forms.NumericUpDown();
            this.numFuerza = new System.Windows.Forms.NumericUpDown();
            this.lblDestreza = new System.Windows.Forms.Label();
            this.lblFuerza = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgHeroes)).BeginInit();
            this.mcrCrear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDestreza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFuerza)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbHeroes
            // 
            this.cmbHeroes.FormattingEnabled = true;
            this.cmbHeroes.Location = new System.Drawing.Point(12, 48);
            this.cmbHeroes.Name = "cmbHeroes";
            this.cmbHeroes.Size = new System.Drawing.Size(121, 21);
            this.cmbHeroes.TabIndex = 0;
            this.cmbHeroes.SelectedIndexChanged += new System.EventHandler(this.cmbHeroes_SelectedIndexChanged);
            // 
            // imgHeroes
            // 
            this.imgHeroes.Location = new System.Drawing.Point(12, 108);
            this.imgHeroes.Name = "imgHeroes";
            this.imgHeroes.Size = new System.Drawing.Size(248, 316);
            this.imgHeroes.TabIndex = 1;
            this.imgHeroes.TabStop = false;
            // 
            // mcrCrear
            // 
            this.mcrCrear.Controls.Add(this.numDestreza);
            this.mcrCrear.Controls.Add(this.numFuerza);
            this.mcrCrear.Controls.Add(this.lblDestreza);
            this.mcrCrear.Controls.Add(this.lblFuerza);
            this.mcrCrear.Location = new System.Drawing.Point(328, 12);
            this.mcrCrear.Name = "mcrCrear";
            this.mcrCrear.Size = new System.Drawing.Size(154, 90);
            this.mcrCrear.TabIndex = 2;
            this.mcrCrear.TabStop = false;
            this.mcrCrear.Text = "Crear Personaje";
            // 
            // numDestreza
            // 
            this.numDestreza.Location = new System.Drawing.Point(70, 54);
            this.numDestreza.Name = "numDestreza";
            this.numDestreza.Size = new System.Drawing.Size(69, 20);
            this.numDestreza.TabIndex = 3;
            // 
            // numFuerza
            // 
            this.numFuerza.Location = new System.Drawing.Point(70, 25);
            this.numFuerza.Name = "numFuerza";
            this.numFuerza.Size = new System.Drawing.Size(69, 20);
            this.numFuerza.TabIndex = 2;
            // 
            // lblDestreza
            // 
            this.lblDestreza.AutoSize = true;
            this.lblDestreza.Location = new System.Drawing.Point(7, 56);
            this.lblDestreza.Name = "lblDestreza";
            this.lblDestreza.Size = new System.Drawing.Size(49, 13);
            this.lblDestreza.TabIndex = 1;
            this.lblDestreza.Text = "Destreza";
            // 
            // lblFuerza
            // 
            this.lblFuerza.AutoSize = true;
            this.lblFuerza.Location = new System.Drawing.Point(7, 27);
            this.lblFuerza.Name = "lblFuerza";
            this.lblFuerza.Size = new System.Drawing.Size(39, 13);
            this.lblFuerza.TabIndex = 0;
            this.lblFuerza.Text = "Fuerza";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(407, 108);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 3;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // FrmIProyectoBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 450);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.mcrCrear);
            this.Controls.Add(this.imgHeroes);
            this.Controls.Add(this.cmbHeroes);
            this.Name = "FrmIProyectoBase";
            this.Text = "Proyecto Base";
            this.Load += new System.EventHandler(this.FrmIProyectoBase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgHeroes)).EndInit();
            this.mcrCrear.ResumeLayout(false);
            this.mcrCrear.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDestreza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFuerza)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbHeroes;
        private System.Windows.Forms.PictureBox imgHeroes;
        private System.Windows.Forms.GroupBox mcrCrear;
        private System.Windows.Forms.Label lblDestreza;
        private System.Windows.Forms.Label lblFuerza;
        private System.Windows.Forms.NumericUpDown numDestreza;
        private System.Windows.Forms.NumericUpDown numFuerza;
        private System.Windows.Forms.Button btnCrear;
    }
}

