using CBA.FlowV2.Caja.PantallaInicio;
using Reconocimiento_facial.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Reconocimiento_facial
{
    public partial class FormPrincipal : Form
    {
        // Almacena la información de los botones antes de borrar los textos
        private List<Tuple<string, string>> infoBotones = new List<Tuple<string, string>>();
        Inicio_Form inicioForm;
        public FormPrincipal(Inicio_Form formInicio)
        {
            inicioForm = formInicio;
            InitializeComponent();
        }
        public FormPrincipal()
        {
                InitializeComponent();
        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = 160;
            // 'sender' es el objeto que desencadenó el evento, en este caso, el botón
          
            // AbrirFormulario<Reconocimiento_facial.Frm_Reconocimiento>();
            AbrirFormulario<Reconocimiento_facial.Frm_panel>();

        }
        private void rjCircularPictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelformularios.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
            //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelformularios.Controls.Add(formulario);
                panelformularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }
        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["Form1"] == null)
                return;
        }
        private void rjButton1_Click(object sender, EventArgs e)
        {
            // 'sender' es el objeto que desencadenó el evento, en este caso, el botón
            Button botonClickeado = sender as Button;
            string nombreBoton = botonClickeado.Name;
            CambiarButonPanelLateral(nombreBoton);
            // AbrirFormulario<Reconocimiento_facial.Frm_Reconocimiento>();
            AbrirFormulario<Reconocimiento_facial.Frm_panel>();
        }

        private void rjButton8_Click(object sender, EventArgs e)
        {
            if (splitContainer1.SplitterDistance == 45)
            {
                splitContainer1.SplitterDistance = 160;
                
            }
            else
            {
                splitContainer1.SplitterDistance = 45;
               



            }
        }

        private void BorrarTextosDeBotones(Control control)
        {
            // Itera a través de los controles en el formulario
            foreach (Control c in control.Controls)
            {
                // Verifica si el control es un botón
                if (c is Button)
                {
                    // Almacena el nombre y el texto del botón antes de borrar el texto
                    infoBotones.Add(new Tuple<string, string>(c.Name, ((Button)c).Text));

                    // Borra el texto del botón
                    ((Button)c).Text = string.Empty;
                    if (((Button)c).Name != "BtnOcultarMenu")
                    {
                        ((Button)c).Size = new System.Drawing.Size(40, 40);
                    }
                    
                }

                // Si el control tiene controles secundarios, realiza una llamada recursiva
                if (c.HasChildren)
                {
                    BorrarTextosDeBotones(c);
                }
            }
        }
        private void CambiarButonPanelLateral(string ButonNombre)
        {
            // Itera a través de los controles en el formulario
            foreach (Control c in flowLayoutPanel1.Controls)
            {
                // Verifica si el control es un botón
                if (c is Button)
                {
                    
                    if (((Button)c).Name == ButonNombre)
                    {
                        ((Button)c).BackColor = Color.Transparent;
                        ((Button)c).ForeColor = Color.Black;

                    }
                    else
                    {
                        ((Button)c).BackColor = SystemColors.Highlight;
                        ((Button)c).ForeColor = Color.White;
                    }
                        
                }

                
            }
        }

        private void RestaurarTextosDeBotones()
        {
            // Itera a través de la información almacenada y restaura los textos de los botones
            foreach (var info in infoBotones)
            {
                Control[] controles = this.Controls.Find(info.Item1, true);
                if (controles.Length > 0 && controles[0] is Button)
                {
                    ((Button)controles[0]).Text = info.Item2;
                    if (((Button)controles[0]).Name != "BtnOcultarMenu")
                    {
                        ((Button)controles[0]).Size = new System.Drawing.Size(138, 40);
                    }
                   
                }
            }

            // Limpia la lista después de restaurar los textos
            infoBotones.Clear();
        }
        private void rjButton6_Click(object sender, EventArgs e)
        {
            // 'sender' es el objeto que desencadenó el evento, en este caso, el botón
            Button botonClickeado = sender as Button;
            string nombreBoton = botonClickeado.Name;
            CambiarButonPanelLateral(nombreBoton);
            AbrirFormulario<UsuariosForm>();
        }

        private void splitContainer1_SplitterMoved_1(object sender, SplitterEventArgs e)
        {
            // Obtener el ancho del panel izquierdo del SplitContainer
            int TamanhoPanel = splitContainer1.Panel1.Width;
            splitContainer1.IsSplitterFixed = TamanhoPanel <= 45;
            if (splitContainer1.SplitterDistance == 45)
            {

                lblUsuario.Visible = false;
                PerfilPicture.Visible = false;
                onlinePicture.Visible = false;
                // Llama a la función para borrar textos de botones
                BorrarTextosDeBotones(this);
            }
            else
            {

                lblUsuario.Visible = true;
                PerfilPicture.Visible = true;
                // Llama a la función para restaurar textos de botones
                RestaurarTextosDeBotones();
                onlinePicture.Visible = true;


            }
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            // 'sender' es el objeto que desencadenó el evento, en este caso, el botón
            Button botonClickeado = sender as Button;
            string nombreBoton = botonClickeado.Name;
            CambiarButonPanelLateral(nombreBoton);
            AbrirFormulario<Reconocimiento_facial.Frm_Reconocimiento>();
            // AbrirFormulario<Frm_Registrar>();
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            // 'sender' es el objeto que desencadenó el evento, en este caso, el botón
            Button botonClickeado = sender as Button;
            string nombreBoton = botonClickeado.Name;
            CambiarButonPanelLateral(nombreBoton);
            // 'sender' es el objeto que desencadenó el evento, en este caso, el botón
            
            AbrirFormulario<PersonasForm>();
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            // 'sender' es el objeto que desencadenó el evento, en este caso, el botón
            Button botonClickeado = sender as Button;
            string nombreBoton = botonClickeado.Name;
            CambiarButonPanelLateral(nombreBoton);
        }

        private void rjButton5_Click(object sender, EventArgs e)
        {
            // 'sender' es el objeto que desencadenó el evento, en este caso, el botón
            Button botonClickeado = sender as Button;
            string nombreBoton = botonClickeado.Name;
            CambiarButonPanelLateral(nombreBoton);
            AbrirFormulario<Ubicaciones>();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Loguin form = new Loguin(inicioForm);
            form.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            inicioForm.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
