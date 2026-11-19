namespace EscritorioGU
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblAlumnos = new System.Windows.Forms.Label();
            this.lblMaterias = new System.Windows.Forms.Label();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.dgvMaterias = new System.Windows.Forms.DataGridView();
            this.lblAlumno = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.txtAlumno = new System.Windows.Forms.TextBox();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblDiaHoy = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblInscripciones = new System.Windows.Forms.Label();
            this.dgvAlumnosPorMateria = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnosPorMateria)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAlumnos
            // 
            this.lblAlumnos.AutoSize = true;
            this.lblAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblAlumnos.Location = new System.Drawing.Point(16, 9);
            this.lblAlumnos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlumnos.Name = "lblAlumnos";
            this.lblAlumnos.Size = new System.Drawing.Size(334, 20);
            this.lblAlumnos.TabIndex = 14;
            this.lblAlumnos.Text = "Alumnos (doble clic para seleccionar):";
            // 
            // lblMaterias
            // 
            this.lblMaterias.AutoSize = true;
            this.lblMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblMaterias.Location = new System.Drawing.Point(668, 9);
            this.lblMaterias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaterias.Name = "lblMaterias";
            this.lblMaterias.Size = new System.Drawing.Size(335, 20);
            this.lblMaterias.TabIndex = 13;
            this.lblMaterias.Text = "Materias (doble clic para seleccionar):";
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.AllowUserToAddRows = false;
            this.dgvAlumnos.AllowUserToDeleteRows = false;
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Location = new System.Drawing.Point(16, 33);
            this.dgvAlumnos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvAlumnos.MultiSelect = false;
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.ReadOnly = true;
            this.dgvAlumnos.RowHeadersWidth = 51;
            this.dgvAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlumnos.Size = new System.Drawing.Size(640, 271);
            this.dgvAlumnos.TabIndex = 0;
            this.dgvAlumnos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvAlumnos_MouseDoubleClick);
            // 
            // dgvMaterias
            // 
            this.dgvMaterias.AllowUserToAddRows = false;
            this.dgvMaterias.AllowUserToDeleteRows = false;
            this.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterias.Location = new System.Drawing.Point(669, 33);
            this.dgvMaterias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMaterias.MultiSelect = false;
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.ReadOnly = true;
            this.dgvMaterias.RowHeadersWidth = 51;
            this.dgvMaterias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterias.Size = new System.Drawing.Size(627, 271);
            this.dgvMaterias.TabIndex = 1;
            this.dgvMaterias.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMaterias_CellMouseDoubleClick);
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Location = new System.Drawing.Point(16, 322);
            this.lblAlumno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(55, 16);
            this.lblAlumno.TabIndex = 12;
            this.lblAlumno.Text = "Alumno:";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(669, 322);
            this.lblMateria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(55, 16);
            this.lblMateria.TabIndex = 11;
            this.lblMateria.Text = "Materia:";
            // 
            // txtAlumno
            // 
            this.txtAlumno.Location = new System.Drawing.Point(16, 345);
            this.txtAlumno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAlumno.Name = "txtAlumno";
            this.txtAlumno.ReadOnly = true;
            this.txtAlumno.Size = new System.Drawing.Size(639, 22);
            this.txtAlumno.TabIndex = 2;
            // 
            // txtMateria
            // 
            this.txtMateria.Location = new System.Drawing.Point(669, 345);
            this.txtMateria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.ReadOnly = true;
            this.txtMateria.Size = new System.Drawing.Size(625, 22);
            this.txtMateria.TabIndex = 3;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(16, 388);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(53, 16);
            this.lblEstado.TabIndex = 10;
            this.lblEstado.Text = "Estado:";
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "Aprobado",
            "Regular",
            "Desaprobado"});
            this.cboEstado.Location = new System.Drawing.Point(16, 410);
            this.cboEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(199, 24);
            this.cboEstado.TabIndex = 4;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(253, 388);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(134, 16);
            this.lblFecha.TabIndex = 9;
            this.lblFecha.Text = "Fecha de inscripción:";
            // 
            // lblDiaHoy
            // 
            this.lblDiaHoy.AutoSize = true;
            this.lblDiaHoy.Location = new System.Drawing.Point(253, 415);
            this.lblDiaHoy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiaHoy.Name = "lblDiaHoy";
            this.lblDiaHoy.Size = new System.Drawing.Size(81, 16);
            this.lblDiaHoy.TabIndex = 8;
            this.lblDiaHoy.Text = "dd/MM/yyyy";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(16, 450);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(200, 49);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "Registrar Alumno";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblInscripciones
            // 
            this.lblInscripciones.AutoSize = true;
            this.lblInscripciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblInscripciones.Location = new System.Drawing.Point(16, 515);
            this.lblInscripciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInscripciones.Name = "lblInscripciones";
            this.lblInscripciones.Size = new System.Drawing.Size(273, 20);
            this.lblInscripciones.TabIndex = 7;
            this.lblInscripciones.Text = "Alumnos Anotados por Materia:";
            // 
            // dgvAlumnosPorMateria
            // 
            this.dgvAlumnosPorMateria.AllowUserToAddRows = false;
            this.dgvAlumnosPorMateria.AllowUserToDeleteRows = false;
            this.dgvAlumnosPorMateria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlumnosPorMateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnosPorMateria.Location = new System.Drawing.Point(16, 539);
            this.dgvAlumnosPorMateria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvAlumnosPorMateria.Name = "dgvAlumnosPorMateria";
            this.dgvAlumnosPorMateria.ReadOnly = true;
            this.dgvAlumnosPorMateria.RowHeadersWidth = 51;
            this.dgvAlumnosPorMateria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlumnosPorMateria.Size = new System.Drawing.Size(1280, 246);
            this.dgvAlumnosPorMateria.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 801);
            this.Controls.Add(this.dgvAlumnosPorMateria);
            this.Controls.Add(this.lblInscripciones);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lblDiaHoy);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtMateria);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.txtAlumno);
            this.Controls.Add(this.lblAlumno);
            this.Controls.Add(this.dgvMaterias);
            this.Controls.Add(this.dgvAlumnos);
            this.Controls.Add(this.lblMaterias);
            this.Controls.Add(this.lblAlumnos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TP 2 - Listar y agregar alumnos a materias";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnosPorMateria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAlumnos;
        private System.Windows.Forms.Label lblMaterias;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.DataGridView dgvMaterias;
        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.TextBox txtAlumno;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblDiaHoy;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblInscripciones;
        private System.Windows.Forms.DataGridView dgvAlumnosPorMateria;
    }
}
