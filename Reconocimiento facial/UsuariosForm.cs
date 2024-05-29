using CBA.FlowV2.Caja.Notificaciones;
using CBA.FlowV2.Caja.PantallaInicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reconocimiento_facial
{
    public partial class UsuariosForm : Form
    {
        public UsuariosForm()
        {
            InitializeComponent();
        }

        private void personasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.reconocimientoDataSet);

        }

        private void UsuariosForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'reconocimientoDataSet.Roles' Puede moverla o quitarla según sea necesario.
            this.rolesTableAdapter.Fill(this.reconocimientoDataSet.Roles);
            // TODO: esta línea de código carga datos en la tabla 'reconocimientoDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.reconocimientoDataSet.Usuarios);
            // TODO: esta línea de código carga datos en la tabla 'reconocimientoDataSet.Personas' Puede moverla o quitarla según sea necesario.
            this.personasTableAdapter.Fill(this.reconocimientoDataSet.Personas);

        }

        private void idTextBox1_TextChanged(object sender, EventArgs e)
        {
            actualizarPersonas();
        }

        private void personaIDTextBox_TextChanged(object sender, EventArgs e)
        {
            actualizarPersonas();
        }
        void actualizarPersonas() 
        {
            try
            {
                if (!string.IsNullOrEmpty(personaIDTextBox.Text))
                {
                    // Obtén el filtro que deseas aplicar
                    string filtro = string.Format("id = '{0}' ", personaIDTextBox.Text);

                    // Aplica el filtro al origen de datos
                    personasBindingSource.Filter = filtro;
                    int id;
                    if (int.TryParse(personaIDTextBox.Text, out id))
                    {
                        refrescarcboPersonas(null, id);
                    }
                   

                }
                else
                {
                    // Si el cuadro de búsqueda está vacío, elimina cualquier filtro aplicado
                    personasBindingSource.RemoveFilter();
                    
                }
            }
            catch (System.Exception ex)
            {
                Alert.Show(ex.Message, Form_Alert.enmType.Error);
            }
           
        }
        void refrescarcboPersonas(string textoBusqueda, int? id) 
        {
            try
            {
                if (id == null)
                {
                    using (ReconocimientoDb db = new ReconocimientoDb())
                    {
                        var personasFiltradas = db.Personas
                                                  .Where(p => (p.Nombre + " " + p.Apellido).Contains(textoBusqueda))
                                                  .Select(p => new { NombreCompleto = p.Nombre + " " + p.Apellido, Id = p.id })
                                                  .ToList();

                        cboPersonas.DataSource = personasFiltradas;
                        cboPersonas.DisplayMember = "NombreCompleto";
                        cboPersonas.ValueMember = "Id";
                    }
                    if (!string.IsNullOrEmpty(textoBusqueda))
                    {
                        personaIDTextBox.Text = cboPersonas.SelectedValue.ToString();
                    }
                }
                else
                {
                    using (ReconocimientoDb db = new ReconocimientoDb())
                    {
                        var persona = db.Personas.FirstOrDefault(p => p.id == id);

                        if (persona != null)
                        {
                            var personasList = new BindingList<Reconocimiento_facial.Personas>();
                            personasList.Add(persona);

                            cboPersonas.DataSource = personasList;
                            cboPersonas.DisplayMember = "Nombre";
                            cboPersonas.ValueMember = "id";
                        }
                    }
                    if (string.IsNullOrEmpty(textoBusqueda))
                    {
                        personaIDTextBox.Text = cboPersonas.SelectedValue.ToString();
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
            
            
        }

        private void txtBuscarPersona_TextChanged(object sender, EventArgs e)
        {
            refrescarcboPersonas (txtBuscarPersona.Text, null);
        }

        private void cboPersonas_SelectedValueChanged(object sender, EventArgs e)
        {
            actualizarPersonas();
        }

        private void btnActualizarContraseña_Click(object sender, EventArgs e)
        {
            try
            {
               
                //verificacion
                if (txtConActual.Texts != contrasenhaTextBox.Text)
                    throw new Exception("la contraseña actual es incorrecta");
                if (txtConNueva.Texts != txtConRepetir.Texts)
                    throw new Exception("la contraseña Nueva no coinside");
                using (ReconocimientoDb db = new ReconocimientoDb()) 
                {
                    var usuario = db.Usuarios.Find(int.Parse(idTextBox1.Text));
                    if (usuario != null) 
                    {
                        usuario.Contrasenha = txtConNueva.Texts;
                        db.SaveChanges();
                        this.usuariosTableAdapter.Fill(this.reconocimientoDataSet.Usuarios);
                        Alert.Show("Se cambio la contraseña", Form_Alert.enmType.Success);
                    }
                }

            }
            catch (Exception ex)
            {

                Alert.Show(ex.Message, Form_Alert.enmType.Error);
            }
            finally 
            {
                txtConActual.Texts = string.Empty;
                txtConNueva.Texts = string.Empty;
                txtConRepetir.Texts = string.Empty;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.usuariosTableAdapter.Update(this.reconocimientoDataSet.Usuarios);
                this.usuariosBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.reconocimientoDataSet);
                this.usuariosTableAdapter.Fill(this.reconocimientoDataSet.Usuarios);
                Alert.Show("Guardado con exito!", Form_Alert.enmType.Success);
            }
            catch (Exception ex)
            {
                Alert.Show(ex.Message, Form_Alert.enmType.Error);
            }
        }
    }
}
