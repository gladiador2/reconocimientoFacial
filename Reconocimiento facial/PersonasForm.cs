using CBA.FlowV2.Caja.Notificaciones;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static Reconocimiento_facial.ReconocimientoDataSet;

namespace Reconocimiento_facial
{
    public partial class PersonasForm : Form
    {
        private string fileName = string.Empty;
        public int heigth, width;

        public string[] Labels;
        DBCon dbc = new DBCon();
        int con = 0, ini = 0, fin;
        //DECLARANDO TODAS LAS VARIABLES, vectores y  haarcascades
        Image<Bgr, Byte> currentFrame;
        Capture grabber;
        HaarCascade face;
        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d);
        Image<Gray, byte> result, TrainedFace = null;
        Image<Gray, byte> gray = null;
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        List<string> labels = new List<string>();
        List<string> labels1 = new List<string>();
        List<string> NamePersons = new List<string>();
        int ContTrain, NumLabels, t;
        string name;
        public PersonasForm()
        {
            InitializeComponent();
            heigth = this.Height; width = this.Width;
            //GARGAMOS LA DETECCION DE LAS CARAS POR  haarcascades 
            face = new HaarCascade("haarcascade_frontalface_default.xml");
            try
            {
                dbc.ObtenerBytesImagen();//carga de caras previus trainned y etiquetas para cada imagen                
                Labels = dbc.Name; //Labelsinfo.Split('%');//separo los nombres de los usuarios 
                NumLabels = dbc.TotalUser;// Convert.ToInt32(Labels[0]);//extraigo el total de usuarios registrados
                ContTrain = NumLabels;


                for (int tf = 0; tf < NumLabels; tf++)//recorro el numero de nombres registrados
                {
                    con = tf;
                    Bitmap bmp = new Bitmap(dbc.ConvertByteToImg(con));
                    //LoadFaces = "face" + tf + ".bmp";
                    trainingImages.Add(new Image<Gray, byte>(bmp));//cargo la foto con ese nombre
                    labels.Add(Labels[tf]);//cargo el nombre que se encuentre en la posicion del tf

                }
            }
            catch (Exception e)
            {//Si la variable NumLabels es 0 me presenta el msj
                MessageBox.Show(e + " No hay ningún rostro en la Base de Datos, por favor añadir por lo menos una cara", "Cragar caras en tu Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void personasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.reconocimientoDataSet);

        }

        private void PersonasForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'reconocimientoDataSet.Ciudad' Puede moverla o quitarla según sea necesario.
            this.ciudadTableAdapter.Fill(this.reconocimientoDataSet.Ciudad);
            // TODO: esta línea de código carga datos en la tabla 'reconocimientoDataSet.Departamento' Puede moverla o quitarla según sea necesario.
            this.departamentoTableAdapter.Fill(this.reconocimientoDataSet.Departamento);
            // TODO: esta línea de código carga datos en la tabla 'reconocimientoDataSet.Pais' Puede moverla o quitarla según sea necesario.
            this.paisTableAdapter.Fill(this.reconocimientoDataSet.Pais);
            // TODO: esta línea de código carga datos en la tabla 'reconocimientoDataSet.Fotos' Puede moverla o quitarla según sea necesario.
            this.fotosTableAdapter.Fill(this.reconocimientoDataSet.Fotos);
            // TODO: esta línea de código carga datos en la tabla 'reconocimientoDataSet.Antecedentes' Puede moverla o quitarla según sea necesario.
            this.antecedentesTableAdapter.Fill(this.reconocimientoDataSet.Antecedentes);
            // TODO: esta línea de código carga datos en la tabla 'reconocimientoDataSet.Personas' Puede moverla o quitarla según sea necesario.
            this.personasTableAdapter.Fill(this.reconocimientoDataSet.Personas);
            

            
        }

        private void rjButton4_Click(object sender, EventArgs e)
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (imageBoxFrameGrabber.Visible)
            {
                try
                {
                    #region guardar
                    //Trained face counter
                    ContTrain = ContTrain + 1;

                    //Get a gray frame from capture device
                    gray = grabber.QueryGrayFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

                    //Face Detector
                    MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(face, 1.2, 10, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(20, 20));

                    //Action for each element detected
                    foreach (MCvAvgComp f in facesDetected[0])
                    {
                        TrainedFace = currentFrame.Copy(f.rect).Convert<Gray, byte>();
                        break;
                    }

                    //resize face detected image for force to compare the same size with the 
                    //test image with cubic interpolation type method
                    TrainedFace = result.Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                    trainingImages.Add(TrainedFace);
                    using (ReconocimientoDb db = new ReconocimientoDb())
                    {


                        Fotos oFtos = new Fotos();
                        Bitmap bmp = new Bitmap(imageBoxFrameGrabber.Image.Bitmap);
                        MemoryStream MyStream = new MemoryStream();
                        bmp.Save(MyStream, System.Drawing.Imaging.ImageFormat.Bmp);

                        byte[] abImagen = MyStream.ToArray();

                        oFtos.Foto = abImagen;
                        oFtos.PersonaId = int.Parse(idTextBox.Text);
                        db.Fotos.Add(oFtos);
                        db.SaveChanges();
                        txtUbicacionImage.Texts = string.Empty;
                        imageBoxFrameGrabber.Visible = false;
                        FotoPictureBox.Visible = true;
                        Application.Idle -= new EventHandler(FrameGrabber);//Detenemos el evento de captura
                        grabber.Dispose();//Dejamos de usar la clase para capturar usar los dispositivos
                        imageBoxFrameGrabber.ImageLocation = "img/1.png";//reiniciamos la imagen del controlon = "img/1.png";
                        FotoPictureBox.Image = null;
                        lblNumeroDetect.Text = "0";
                    }

                    //Show face added in gray scale
                    #endregion
                    //}
                    //
                    this.fotosTableAdapter.Fill(this.reconocimientoDataSet.Fotos);
                    MessageBox.Show("Agregado correctamente", "Capturado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    using (ReconocimientoDb db = new ReconocimientoDb())
                    {


                        Fotos oFtos = new Fotos();
                        oFtos.Foto = utilidadesClass.Instance.ObtenerBytesDeImagen(fileName);
                        oFtos.PersonaId = int.Parse(idTextBox.Text);
                        db.Fotos.Add(oFtos);
                        db.SaveChanges();
                        txtUbicacionImage.Texts = string.Empty;
                        FotoPictureBox.Image = null;
                        this.fotosTableAdapter.Fill(this.reconocimientoDataSet.Fotos);
                    }
                }
                catch (Exception ex)
                {
                    Alert.Show(ex.Message, Form_Alert.enmType.Error);
                }

            }
            
            
        }

        private void personasDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (personasDataGridView.Rows.Count != 0)
            {
                if (e.ColumnIndex == personasDataGridView.Columns["btnModificar"].Index)
                {
                    var cell = personasDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    cell.ToolTipText = "Modificar registro"; //dgvDetalles.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    
                }
                if (e.ColumnIndex == personasDataGridView.Columns["btnEditar"].Index)
                {
                    var cell = personasDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];

                    cell.ToolTipText = "Asignar envases"; //dgvDetalles.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                }
            }

        }

        private void txtBuscar__TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtBuscar.Texts))
                {
                    // Obtén el filtro que deseas aplicar
                    string filtro = string.Format("Nombre LIKE '%{0}%' OR Apellido LIKE '%{0}%' OR CI LIKE '%{0}%'", txtBuscar.Texts);

                    // Aplica el filtro al origen de datos
                    personasBindingSource.Filter = filtro;
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
            try
            {
                this.personasTableAdapter.Update(this.reconocimientoDataSet.Personas);
                this.personasBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.reconocimientoDataSet);
                this.personasTableAdapter.Fill(this.reconocimientoDataSet.Personas);
                Alert.Show("Guardado con exito!", Form_Alert.enmType.Success);
            }
            catch (Exception ex)
            {
                Alert.Show(ex.Message, Form_Alert.enmType.Error);
            }
        }

        private void FotoPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void personasDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
              

                if (e.ColumnIndex == personasDataGridView.Columns["btnModificar"].Index && e.RowIndex >= 0)
                {
                    tabControl1.SelectedTab = tabPage2;
                }

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarDetalles_Click(object sender, EventArgs e)
        {
            try
            {
                this.personasTableAdapter.Update(this.reconocimientoDataSet.Personas);
                this.personasBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.reconocimientoDataSet);
                this.personasTableAdapter.Fill(this.reconocimientoDataSet.Personas);
                Alert.Show("Guardado con exito!", Form_Alert.enmType.Success);
            }
            catch (Exception ex)
            {
                Alert.Show(ex.Message, Form_Alert.enmType.Error);
            }
        }

        private void btnAntecedentesGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.antecedentesTableAdapter.Update(this.reconocimientoDataSet.Antecedentes);
                this.antecedentesBindingSource1.EndEdit();
                this.tableAdapterManager.UpdateAll(this.reconocimientoDataSet);
                this.antecedentesTableAdapter.Fill(this.reconocimientoDataSet.Antecedentes);
                Alert.Show("Guardado con exito!", Form_Alert.enmType.Success);
            }
            catch (Exception ex)
            {
                Alert.Show(ex.Message, Form_Alert.enmType.Error);
            }
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            try
            {
               // Iniciar el dispositivo de captura
                grabber = new Capture();
                grabber.QueryFrame();
                //Iniciar el evento FrameGraber
                Application.Idle += new EventHandler(FrameGrabber);
                imageBoxFrameGrabber.Visible = true;
                FotoPictureBox.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        void FrameGrabber(object sender, EventArgs e)
        {
            lblNumeroDetect.Text = "0";
            NamePersons.Add("");
            try
            {

                //Obtener la secuencia del dispositivo de captura
                try
                {
                    currentFrame = grabber.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                }
                catch (Exception)
                {
                    imageBoxFrameGrabber.Image = null;
                }

                //Convertir a escala de grises
                gray = currentFrame.Convert<Gray, Byte>();

                //Detector de Rostros
                MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(face, 1.2, 10, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(20, 20));

                //Accion para cada elemento detectado
                foreach (MCvAvgComp f in facesDetected[0])
                {
                    t = t + 1;
                    result = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(640, 480, INTER.CV_INTER_CUBIC);
                    //Dibujar el cuadro para el rostro
                    currentFrame.Draw(f.rect, new Bgr(Color.LightGreen), 1);

                    NamePersons[t - 1] = name;
                    NamePersons.Add("");
                    //Establecer el nùmero de rostros detectados
                    lblNumeroDetect.Text = facesDetected[0].Length.ToString();
                    //lblNadie.Text = name;

                }
                t = 0;

                //Mostrar los rostros procesados y reconocidos
                imageBoxFrameGrabber.Image = currentFrame;
                name = "";
                //Borrar la lista de nombres            
                NamePersons.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
