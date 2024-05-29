
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reconocimiento_facial
{
    
    public partial class Ubicaciones : Form
    {
        private string fileName = string.Empty;
        private int vIDpais = 0;
        private int vIDepartamento = 0;
        public Ubicaciones()
        {
            InitializeComponent();
        }

        private void btnBuscarImage_Click(object sender, EventArgs e)
        {

            try
            {
            openFileDialog1.ShowDialog();
            txtUbicacionImage.Texts = openFileDialog1.SafeFileName; 
            fileName = openFileDialog1.FileName;
            FotoPictureBox.Image = utilidadesClass.Instance.CargarImagenDesdeArchivo(fileName);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void Ubicaciones_Load(object sender, EventArgs e)
        {
            try
            {
                setDataSourse();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        public void setDataSourse()
        {
            try
            {
                using (ReconocimientoDb db = new ReconocimientoDb())
                {
                    var query = from pais in db.Pais
                                select new
                                {
                                    id = pais.id,
                                    Nombre = pais.Pais1,
                                    Bandera = pais.bandera
                                };
                    dgvPais.DataSource = query.ToList();
                    dgvPais.Columns["id"].Visible = false;
                    dgvPais.Columns["bandera"].FillWeight = 50;
                   
                }
            }
            catch (Exception)
            {

                throw;
            }
           

        }

        private void btnGuardarPais_Click(object sender, EventArgs e)
        {
            using (ReconocimientoDb db = new ReconocimientoDb())
            {
               Pais oPais = new Pais();
               oPais.bandera = utilidadesClass.Instance.ObtenerBytesDeImagen(fileName);
               oPais.Pais1 = txtPais.Texts;
               db.Pais.Add(oPais);
               db.SaveChanges();
               setDataSourse();
                txtPais.Texts = string.Empty;
            }
        }

        private void dgvPais_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvPais.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvPais.SelectedRows[0];

                    // Accede al valor de la columna "ID"
                    this.vIDpais = Convert.ToInt32(selectedRow.Cells["id"].Value);
                    FotoPictureBox.Image = utilidadesClass.Instance.ObtenerImagenDesdeBytes((byte[])selectedRow.Cells["bandera"].Value);
                    CargarDepartamento(this.vIDpais);
                }
            }
            catch (Exception)
            {

                throw;
            }
           
        }
        private  void CargarDepartamento(int idPais)
        {
            using (ReconocimientoDb db = new ReconocimientoDb())
            {
                

                // Filtrar los registros de la tabla Departamento por el valor de vID en la columna PaisId
                var departamentos = db.Departamento.Where(d => d.paisId == idPais).ToList();
                var query = from departamento in departamentos
                            select new
                            {
                                id = departamento.id,
                                Departamento = departamento.Departamento1
                                
                            };
                dgvDepartamento.DataSource = query.ToList();
                dgvDepartamento.Columns["id"].Visible = false;
                dgvDepartamento.Columns["Departamento"].FillWeight = 150;
                // Agregar columna "Eliminar"
                DataGridViewButtonColumn eliminarColumna = new DataGridViewButtonColumn();
                eliminarColumna.HeaderText = "Eliminar";
                eliminarColumna.Text = "Eliminar";
                eliminarColumna.UseColumnTextForButtonValue = true;
                dgvDepartamento.Columns.Add(eliminarColumna);

                // Agregar columna "Editar"
                DataGridViewButtonColumn editarColumna = new DataGridViewButtonColumn();
                editarColumna.HeaderText = "Editar";
                editarColumna.Text = "Editar";
                editarColumna.UseColumnTextForButtonValue = true;
                dgvDepartamento.Columns.Add(editarColumna);


            }
        }
        private void CargarCiudad(int idDepartamento)
        {
            using (ReconocimientoDb db = new ReconocimientoDb())
            {
                // Filtrar los registros de la tabla Departamento por el valor de vID en la columna PaisId
                var Ciudades = db.Ciudad.Where(d => d.DepartamentoId == idDepartamento).ToList();
                var query = from Ciudad in Ciudades
                            select new
                            {
                                id = Ciudad.id,
                                Ciudad = Ciudad.Ciudad1

                            };
                dgvCiudad.DataSource = query.ToList();
                dgvCiudad.Columns["id"].Visible = false;
                dgvCiudad.Columns["Ciudad"].FillWeight = 150;


            }
        }

        private void dgvPais_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               if (dgvPais.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvPais.SelectedRows[0];

                    // Accede al valor de la columna "ID"
                    this.vIDpais = Convert.ToInt32(selectedRow.Cells["id"].Value);
                    FotoPictureBox.Image = utilidadesClass.Instance.ObtenerImagenDesdeBytes((byte[])selectedRow.Cells["bandera"].Value);
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btnGuardarDepartaento_Click(object sender, EventArgs e)
        {
            using (ReconocimientoDb db = new ReconocimientoDb())
            {
                Departamento odepartamento = new Departamento();
                odepartamento.Departamento1 = txtDepartamento.Texts;
                odepartamento.paisId = this.vIDpais;
                db.Departamento.Add(odepartamento);
                db.SaveChanges();
                txtDepartamento.Texts = string.Empty;
                CargarDepartamento(this.vIDpais);
            }
        }

        private void dgvCiudad_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void btnGuardarCiudad_Click(object sender, EventArgs e)
        {
            using (ReconocimientoDb db = new ReconocimientoDb())
            {
                Ciudad oCiudd = new Ciudad();
                oCiudd.Ciudad1 = txtCiudad.Texts;
                oCiudd.DepartamentoId = this.vIDepartamento;
                db.Ciudad.Add(oCiudd);
                
                db.SaveChanges();
                txtCiudad.Texts = string.Empty;
                CargarCiudad(this.vIDepartamento);
            }
        }

        private void dgvDepartamento_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvDepartamento.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvDepartamento.SelectedRows[0];

                    // Accede al valor de la columna "ID"
                    this.vIDepartamento = Convert.ToInt32(selectedRow.Cells["id"].Value);

                    CargarCiudad(this.vIDepartamento);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
