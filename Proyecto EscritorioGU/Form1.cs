using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EscritorioGU
{
    public partial class Form1 : Form
    {
        // Variables globales con los id tomados de las grillas (Objetivo 3)
        public int idAlumnoSeleccionado = 0;
        public int idMateriaSeleccionada = 0;

        public Form1()
        {
            InitializeComponent();
        }

        // Objetivo 2: listar alumno, materia y alumno_materia al cargar el formulario
        private void Form1_Load(object sender, EventArgs e)
        {
            listarEstudiantes();
            listarMaterias();
            listarAlumnosPorMateria();

            lblDiaHoy.Text = DateTime.Now.ToString("dd/MM/yyyy");

            cboEstado.SelectedItem = "Regular";
        }

        // Funciones para listar las grillas

        private void listarEstudiantes()
        {
            SqlConnection conn = null;
            try
            {
                conn = Conexion.abrirConn();
                SqlCommand cmd = new SqlCommand("SELECT * FROM alumno", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvAlumnos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (conn != null) Conexion.cerrarConn(conn);
            }
        }

        private void listarMaterias()
        {
            SqlConnection conn = null;
            try
            {
                conn = Conexion.abrirConn();
                SqlCommand cmd = new SqlCommand("SELECT * FROM materia", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvMaterias.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (conn != null) Conexion.cerrarConn(conn);
            }
        }

        private void listarAlumnosPorMateria()
        {
            SqlConnection conn = null;
            try
            {
                conn = Conexion.abrirConn();

                string query = @"
                    SELECT
                        am.fecha_inscripcion AS FECHA,
                        concat(a.apellido,' - ',a.nombre) AS Alumno,
                        m.nombre_materia,
                        CASE am.id_estado
                            WHEN 1 THEN 'APR'
                            WHEN 2 THEN 'REG'
                            WHEN 3 THEN 'DES'
                        END AS Estado,
                        CASE m.id_carrera
                            WHEN 1 THEN 'PROG'
                            WHEN 2 THEN 'MANTIND'
                            WHEN 3 THEN 'LOGIST'
                            WHEN 4 THEN 'ELECT'
                        END AS Tecnicatura
                    FROM alumno_materia AS am
                    INNER JOIN alumno AS a ON a.id_alumno = am.id_alumno
                    INNER JOIN materia AS m ON m.id_materia = am.id_materia
                    INNER JOIN carrera AS c ON c.id_carrera = m.id_carrera
                    ORDER BY am.fecha_inscripcion DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvAlumnosPorMateria.DataSource = dt;

                // La columna es DATE en SQL Server: se muestra solo día/mes/año
                dgvAlumnosPorMateria.Columns["FECHA"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (conn != null) Conexion.cerrarConn(conn);
            }
        }

        // Objetivo 3: doble clic en las grillas 

        private void dgvAlumnos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Este evento no trae la fila, se obtiene con HitTest según donde se hizo clic
            DataGridView.HitTestInfo hit = dgvAlumnos.HitTest(e.X, e.Y);
            if (hit.Type != DataGridViewHitTestType.Cell || hit.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow fila = dgvAlumnos.Rows[hit.RowIndex];
            idAlumnoSeleccionado = Convert.ToInt32(fila.Cells["id_alumno"].Value);
            txtAlumno.Text = idAlumnoSeleccionado + " - " +
                             fila.Cells["apellido"].Value + ", " +
                             fila.Cells["nombre"].Value;
        }

        private void dgvMaterias_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return; // doble clic en el encabezado
            }

            DataGridViewRow fila = dgvMaterias.Rows[e.RowIndex];
            idMateriaSeleccionada = Convert.ToInt32(fila.Cells["id_materia"].Value);
            txtMateria.Text = idMateriaSeleccionada + " - " + fila.Cells["nombre_materia"].Value;
        }

        // Objetivo 4: Registrar

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtAlumno.Text == "" || txtMateria.Text == "")
            {
                MessageBox.Show("No pueden estar cajas vacias doble click en las grillas para traer datos");
                return;
            }

            if (registrarAlumnoMateria())
            {
                listarAlumnosPorMateria();
            }
        }

        // Devuelve true si el INSERT se realizó correctamente
        private bool registrarAlumnoMateria()
        {
            // id_estado: 1 = Aprobado, 2 = Regular, 3 = Desaprobado
            int estado = 0;
            if (cboEstado.Text == "Aprobado")
            {
                estado = 1;
            }
            else if (cboEstado.Text == "Regular")
            {
                estado = 2;
            }
            else if (cboEstado.Text == "Desaprobado")
            {
                estado = 3;
            }
            else
            {
                MessageBox.Show("Seleccione un estado.");
                return false;
            }

            // Se guarda como DateTime (sin ToString) en una columna DATE
            DateTime fechaHoy = DateTime.Now;

            SqlConnection conn = null;
            string query = "INSERT INTO alumno_materia (id_alumno, id_materia, fecha_inscripcion, id_estado) " +
                           "VALUES (@id_alumno, @id_materia, @fecha, @estado)";

            try
            {
                conn = Conexion.abrirConn();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@id_alumno", SqlDbType.Int).Value = idAlumnoSeleccionado;
                cmd.Parameters.Add("@id_materia", SqlDbType.Int).Value = idMateriaSeleccionada;
                cmd.Parameters.Add("@fecha", SqlDbType.Date).Value = fechaHoy.Date;
                cmd.Parameters.Add("@estado", SqlDbType.Int).Value = estado;
                cmd.ExecuteNonQuery();

                MessageBox.Show("Alumno registrado en la materia.");
                return true;
            }
            catch (SqlException ex) when (ex.Number == 2627)
            {
                // Violación de la PRIMARY KEY (id_alumno, id_materia)
                MessageBox.Show("Ese alumno ya está inscripto en esa materia.");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            finally
            {
                if (conn != null) Conexion.cerrarConn(conn);
            }
        }
    }
}
