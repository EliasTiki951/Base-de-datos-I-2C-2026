namespace masControles
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
            this.rdbUser = new System.Windows.Forms.RadioButton();
            this.rdbFeliz = new System.Windows.Forms.RadioButton();
            this.rdbPensativo = new System.Windows.Forms.RadioButton();
            this.rdbTriste = new System.Windows.Forms.RadioButton();
            this.cboEstadoAnimico = new System.Windows.Forms.ComboBox();
            this.pbxEstado = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEstado)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbUser
            // 
            this.rdbUser.AutoSize = true;
            this.rdbUser.Location = new System.Drawing.Point(36, 52);
            this.rdbUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbUser.Name = "rdbUser";
            this.rdbUser.Size = new System.Drawing.Size(45, 17);
            this.rdbUser.TabIndex = 0;
            this.rdbUser.TabStop = true;
            this.rdbUser.Text = "user";
            this.rdbUser.UseVisualStyleBackColor = true;
            this.rdbUser.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdbFeliz
            // 
            this.rdbFeliz.AutoSize = true;
            this.rdbFeliz.Location = new System.Drawing.Point(36, 81);
            this.rdbFeliz.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbFeliz.Name = "rdbFeliz";
            this.rdbFeliz.Size = new System.Drawing.Size(43, 17);
            this.rdbFeliz.TabIndex = 1;
            this.rdbFeliz.TabStop = true;
            this.rdbFeliz.Text = "feliz";
            this.rdbFeliz.UseVisualStyleBackColor = true;
            // 
            // rdbPensativo
            // 
            this.rdbPensativo.AutoSize = true;
            this.rdbPensativo.Location = new System.Drawing.Point(36, 110);
            this.rdbPensativo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbPensativo.Name = "rdbPensativo";
            this.rdbPensativo.Size = new System.Drawing.Size(71, 17);
            this.rdbPensativo.TabIndex = 2;
            this.rdbPensativo.TabStop = true;
            this.rdbPensativo.Text = "pensativo";
            this.rdbPensativo.UseVisualStyleBackColor = true;
            // 
            // rdbTriste
            // 
            this.rdbTriste.AutoSize = true;
            this.rdbTriste.Location = new System.Drawing.Point(36, 141);
            this.rdbTriste.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbTriste.Name = "rdbTriste";
            this.rdbTriste.Size = new System.Drawing.Size(47, 17);
            this.rdbTriste.TabIndex = 3;
            this.rdbTriste.TabStop = true;
            this.rdbTriste.Text = "triste";
            this.rdbTriste.UseVisualStyleBackColor = true;
            // 
            // cboEstadoAnimico
            // 
            this.cboEstadoAnimico.FormattingEnabled = true;
            this.cboEstadoAnimico.Items.AddRange(new object[] {
            "user",
            "feliz",
            "pensativo",
            "triste"});
            this.cboEstadoAnimico.Location = new System.Drawing.Point(353, 42);
            this.cboEstadoAnimico.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboEstadoAnimico.Name = "cboEstadoAnimico";
            this.cboEstadoAnimico.Size = new System.Drawing.Size(199, 21);
            this.cboEstadoAnimico.TabIndex = 4;
            this.cboEstadoAnimico.SelectedIndexChanged += new System.EventHandler(this.cboEstadoAnimico_SelectedIndexChanged);
            // 
            // pbxEstado
            // 
            this.pbxEstado.Location = new System.Drawing.Point(132, 42);
            this.pbxEstado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbxEstado.Name = "pbxEstado";
            this.pbxEstado.Size = new System.Drawing.Size(187, 194);
            this.pbxEstado.TabIndex = 5;
            this.pbxEstado.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.pbxEstado);
            this.Controls.Add(this.cboEstadoAnimico);
            this.Controls.Add(this.rdbTriste);
            this.Controls.Add(this.rdbPensativo);
            this.Controls.Add(this.rdbFeliz);
            this.Controls.Add(this.rdbUser);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbxEstado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbUser;
        private System.Windows.Forms.RadioButton rdbFeliz;
        private System.Windows.Forms.RadioButton rdbPensativo;
        private System.Windows.Forms.RadioButton rdbTriste;
        private System.Windows.Forms.ComboBox cboEstadoAnimico;
        private System.Windows.Forms.PictureBox pbxEstado;
    }
}

