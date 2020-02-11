using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;
using System.ServiceModel;
using System.Collections;
using System.Threading;
using System.Net.Mail;
using System.Drawing;
using ObjetoRemoto;
using System.Data;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System;

namespace Cliente
{
    public partial class Cliente : Form
    {
        Thread servidor = new Thread(ObjetoRemoto.Servidor.Main);
        ChannelFactory<ObjetoRemoto.IObjetorRemoto> canal = new ChannelFactory<ObjetoRemoto.IObjetorRemoto>(new NetTcpBinding(), "net.tcp://localhost:8080");
        ObjetoRemoto.IObjetorRemoto interfaz;
        ObjetoRemoto.ObjetoRemoto objetoremotoUsuario = new ObjetoRemoto.ObjetoRemoto();
        List<Planificar> recibirPlanificacion = new List<Planificar>();
        List<Comision> recibir = new List<Comision>();
        int cantidadMiembros, contador = 1;
        string datos;

        public Cliente()
        {
            InitializeComponent();
            servidor.IsBackground = true;
            servidor.Start();
            Thread.Sleep(1000);
            interfaz = canal.CreateChannel();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            cargarComisiones();
            groupBox_Generar.Enabled = false;
        }

        public void cargarComisiones()
        {
            foreach (Comision item in interfaz.selecionarComision(recibir))
            {
                comboBox_Comision.Items.Add(item.Nombre_Comision);
            }
            recibir.Clear();
        }

        public void buscarCorreos()
        {
            (objetoremotoUsuario as IObjetorRemoto).selecionarCorreos(recibir);
            if (recibir.Count() > 0)
            {
                listBox_vistaPrevia.Items.Clear();
                listBox_vistaPrevia.Items.Add("De: Gerente General <MARIA_CHUN_CHUN@gmail.com>");
                listBox_vistaPrevia.Items.Add("Para: ");
                foreach (Comision item in recibir)
                {
                    listBox_vistaPrevia.Items.Add(item.Nombre_Miembros + "  " + "<" + item.Correos_Comision + ">");
                }
                listBox_vistaPrevia.Items.Add("Asunto: " + txt_Tema.Text);
                listBox_vistaPrevia.Items.Add("Se ha establecido una reunion para el dia: " + Tiempo_Reunion.Text + " en el cual la Comision: " + comboBox_Comision.SelectedItem.ToString() + " debera asistir con puntualidad.");
                recibir.Clear();
            }
            else
            {
                MessageBox.Show("No hubo resultados en la busqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void guardarPlanificacion()
        {
            objetoremotoUsuario.busquedaCorreo = comboBox_Comision.SelectedItem.ToString();
            (objetoremotoUsuario as IObjetorRemoto).selecionarCorreos(recibir);
            foreach (Comision item in recibir)
            {
                objetoremotoUsuario.identificadorPlanificacion = interfaz.obtenerID_Planificacion(0);
                objetoremotoUsuario.fechaPlanificacion = Tiempo_Reunion.Text;
                objetoremotoUsuario.nombreComision = comboBox_Comision.SelectedItem.ToString();
                objetoremotoUsuario.temaTratar = txt_Tema.Text;
                objetoremotoUsuario.correosComision = item.Correos_Comision;
                (objetoremotoUsuario as IObjetorRemoto).guardarPlanificacion(recibirPlanificacion);
            }
        }

        public void guardarComision()
        {
            (objetoremotoUsuario as IObjetorRemoto).crearComision(recibir);
            foreach (Comision item in recibir)
            {
                dataGridView_Comision.DataSource = objetoremotoUsuario.mostrarComisiones.Select(x => x).Select(y => new
                {
                    ID = y.Id_Comision,
                    NOMBRE_COMISION = y.Nombre_Comision,
                    NUMERO_DE_MIEMBROS = y.Numero_Miembros,
                    NOMBRE_MIEMBRO = y.Nombre_Miembros,
                    CARGO_MIEMBRO = y.Cargo_Miembros,
                    COREO_MIEMBRO = y.Correos_Comision
                }).ToList();
            }
            dataGridView_Comision.SelectionMode = DataGridViewSelectionMode.CellSelect;
            recibir.Clear();
        }

        public static bool ComprobarFormatoEmail(string correoComprobar)
        {
            String formatoCorreo;
            formatoCorreo = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(correoComprobar, formatoCorreo))
            {
                if (Regex.Replace(correoComprobar, formatoCorreo, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void boton_vistaPrevia_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox_Comision.Text == "" || txt_Tema.Text == "")
                {
                    MessageBox.Show("Debe ingresar todos los datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    objetoremotoUsuario.busquedaCorreo = comboBox_Comision.SelectedItem.ToString();
                    datos = comboBox_Comision.SelectedItem.ToString();
                    buscarCorreos();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo buscar los datos debido a un error.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void boton_enviarCorreo_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox_Comision.Text == "" || txt_Tema.Text == "")
                {
                    MessageBox.Show("Debe ingresar todos los datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    objetoremotoUsuario.consultaActa = comboBox_Comision.SelectedItem.ToString();
                    datos = comboBox_Comision.SelectedItem.ToString();
                    objetoremotoUsuario.busquedaCorreo = comboBox_Comision.SelectedItem.ToString();
                    (objetoremotoUsuario as IObjetorRemoto).selecionarCorreos(recibir);
                    foreach (Comision item in recibir)
                    {
                        MailMessage correo = new MailMessage();
                        SmtpClient Smtp_Servidor = new SmtpClient("smtp.gmail.com");
                        correo.From = new MailAddress("MARIA_CHUN_CHUN@gmail.com");
                        correo.To.Add(item.Correos_Comision);
                        correo.Subject = txt_Tema.Text;
                        correo.Body = "Se ha establecido una reunion para el dia: " + Tiempo_Reunion.Text + " en el cual la Comision: " + comboBox_Comision.SelectedItem.ToString() + " debera asistir con puntualidad";
                        Smtp_Servidor.EnableSsl = true;
                        Smtp_Servidor.UseDefaultCredentials = false;
                        Smtp_Servidor.Port = 587;
                        Smtp_Servidor.Credentials = new NetworkCredential("MARIA_CHUN_CHUN@gmail.com", "MARIA_CHUN_CHUN_123");
                        Smtp_Servidor.DeliveryMethod = SmtpDeliveryMethod.Network;
                        Smtp_Servidor.Send(correo);
                    }
                    MessageBox.Show("Coreo Enviado...");
                    recibir.Clear();
                    guardarPlanificacion();
                    comboBox_Comision.Text = "";
                    txt_Tema.Clear();
                    listBox_vistaPrevia.Items.Clear();
                    Tiempo_Reunion.Focus();
                    groupBox_Generar.Enabled = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo enviar el correo debido a un error...");
            }
        }

        private void boton_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_nombreComision.Text == "" || txt_numeroMiembros.Text == "" || txt_nombreMiembros.Text == "" || comboBox_Cargo.Text == "" || txt_Correo.Text == "")
                {
                    MessageBox.Show("Debe ingresar todos los datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (contador > 0 && txt_nombreComision.Text != "" && txt_numeroMiembros.Text != "")
                    {
                        txt_nombreComision.Enabled = false;
                        txt_numeroMiembros.Enabled = false;
                    }
                    if (cantidadMiembros == contador)
                    {
                        etiqueta_Numero.Text = contador.ToString();
                        objetoremotoUsuario.identificadorComision_Agregar = interfaz.obtenerID_Comision(0);
                        objetoremotoUsuario.nombreComision = txt_nombreComision.Text;
                        objetoremotoUsuario.numeroMiembros = Convert.ToInt32(txt_numeroMiembros.Text);
                        objetoremotoUsuario.nombreMiembros = txt_nombreMiembros.Text;
                        objetoremotoUsuario.cargoMiembros = comboBox_Cargo.SelectedItem.ToString();
                        objetoremotoUsuario.correosComision = txt_Correo.Text;
                        guardarComision();
                        dataGridView_Comision.ClearSelection();
                        MessageBox.Show("Se han agregado los " + cantidadMiembros + " miembros corectamente a la comision.");
                        txt_nombreComision.Enabled = true;
                        txt_numeroMiembros.Enabled = true;
                        contador = 1;
                        txt_nombreComision.Clear();
                        txt_numeroMiembros.Clear();
                        txt_nombreMiembros.Clear();
                        etiqueta_Numero.Text = "0";
                        comboBox_Cargo.Text = "";
                        txt_Correo.Clear();
                        txt_nombreComision.Focus();
                    }
                    else
                    {
                        contador = contador + 1;
                        etiqueta_Numero.Text = contador.ToString();
                        objetoremotoUsuario.identificadorComision_Agregar = interfaz.obtenerID_Comision(0);
                        objetoremotoUsuario.nombreComision = txt_nombreComision.Text;
                        objetoremotoUsuario.numeroMiembros = Convert.ToInt32(txt_numeroMiembros.Text);
                        objetoremotoUsuario.nombreMiembros = txt_nombreMiembros.Text;
                        objetoremotoUsuario.cargoMiembros = comboBox_Cargo.SelectedItem.ToString();
                        objetoremotoUsuario.correosComision = txt_Correo.Text;
                        guardarComision();
                        dataGridView_Comision.ClearSelection();
                        txt_nombreMiembros.Clear();
                        comboBox_Cargo.Text = "";
                        txt_Correo.Clear();
                        txt_nombreMiembros.Focus();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo guardar los datos debido a un error.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            dataGridView_Comision.ClearSelection();
            dataGridView_Comision.ClearSelection();
            dataGridView_Comision.DataSource = null;
        }

        private void boton_vistaPrevia_Acta_Click(object sender, EventArgs e)
        {
            listBox_Acta.Items.Clear();
            listBox_Acta.Items.Add("\t\t\tESCUELA POLITÉCNICA NACIONAL.");
            listBox_Acta.Items.Add("\n");
            listBox_Acta.Items.Add("\n");
            listBox_Acta.Items.Add("\n");
            objetoremotoUsuario.consultaDatosPlanificar = (interfaz.obtenerID_Planificacion(0) - 1);
            (objetoremotoUsuario as IObjetorRemoto).datosPlanificacion(recibirPlanificacion);
            foreach (Planificar item in recibirPlanificacion)
            {
                listBox_Acta.Items.Add("En Quito el día " + item.Fecha_Reunion + ".");
            }
            recibirPlanificacion.Clear();
            listBox_Acta.Items.Add("\n");
            listBox_Acta.Items.Add("\n");
            (objetoremotoUsuario as IObjetorRemoto).consultarPlanificacion(recibir);
            foreach (Comision item in recibir)
            {
                listBox_Acta.Items.Add("Se reunio la comision: " + item.Nombre_Comision + ".");
            }
            recibir.Clear();
            listBox_Acta.Items.Add("\n");
            listBox_Acta.Items.Add("\n");
            listBox_Acta.Items.Add("Cuyos Miembros son: ");
            objetoremotoUsuario.busquedaCorreo = datos;
            (objetoremotoUsuario as IObjetorRemoto).selecionarCorreos(recibir);
            foreach (Comision item in recibir)
            {
                listBox_Acta.Items.Add("\t" + item.Nombre_Miembros + "  " + item.Cargo_Miembros + " de la comision");
            }
            recibir.Clear();
            listBox_Acta.Items.Add("\n");
            listBox_Acta.Items.Add("\n");
            objetoremotoUsuario.consultaDatosPlanificar = (interfaz.obtenerID_Planificacion(0) - 1);
            (objetoremotoUsuario as IObjetorRemoto).consultaTema(recibirPlanificacion);
            foreach (Planificar item in recibirPlanificacion)
            {
                listBox_Acta.Items.Add("Para Tratar el Tema: " + item.Tema_Tratar + ".");
            }
            recibirPlanificacion.Clear();
            listBox_Acta.Items.Add("\n");
            listBox_Acta.Items.Add("\n");
            listBox_Acta.Items.Add("En el Cual se trataron los siguientes puntos y acuerdos:");
            if (txt_Punto_Uno.Text == "")
            {
                listBox_Acta.Items.Add("\t PUNTO 1: -----");
            }
            else
            {
                listBox_Acta.Items.Add("\t PUNTO 1: " + txt_Punto_Uno.Text);
            }
            if (txt_Punto_Dos.Text == "")
            {
                listBox_Acta.Items.Add("\t PUNTO 2: -----");
            }
            else
            {
                listBox_Acta.Items.Add("\t PUNTO 2: " + txt_Punto_Dos.Text);
            }
            if (txt_Punto_Tres.Text == "")
            {
                listBox_Acta.Items.Add("\t PUNTO 3: -----");
            }
            else
            {
                listBox_Acta.Items.Add("\t PUNTO 3: " + txt_Punto_Tres.Text);
            }
            if (txt_Acuerdo_Uno.Text == "")
            {
                listBox_Acta.Items.Add("\t ACUERDO 1: -----");
            }
            else
            {
                listBox_Acta.Items.Add("\t ACUERDO 1: " + txt_Acuerdo_Uno.Text);
            }
            if (txt_Acuerdo_Dos.Text == "")
            {
                listBox_Acta.Items.Add("\t ACUERDO 2: -----");
            }
            else
            {
                listBox_Acta.Items.Add("\t ACUERDO 2: " + txt_Acuerdo_Dos.Text);
            }
            if (txt_Acuerdo_Tres.Text == "")
            {
                listBox_Acta.Items.Add("\t ACUERDO 3: -----");
            }
            else
            {
                listBox_Acta.Items.Add("\t ACUERDO 3: " + txt_Acuerdo_Tres.Text);
            }
            listBox_Acta.Items.Add("\n");
            listBox_Acta.Items.Add("\n");
            listBox_Acta.Items.Add("\t\t __________________             __________________");
            listBox_Acta.Items.Add("\t\t FIRMA PRESIDENTE              FIRMA SECRETARIO");
        }

        private void botonGenerar_Click(object sender, EventArgs e)
        {
            if (txt_Acta.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre al acta...");
            }
            else
            {
                try
                {
                    using (FileStream archivo = File.Open(txt_Acta.Text + ".txt", FileMode.CreateNew))
                    {
                        using (StreamWriter guardar = new StreamWriter(archivo))
                        {
                            foreach (var item in listBox_Acta.Items)
                            {
                                guardar.WriteLine(item.ToString());
                            }
                        }
                    }
                    dialogoImprimir.ShowDialog();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ya existe una Acta con ese nombre...");
                }
            }
        }

        private void comboBox_Comision_Click(object sender, EventArgs e)
        {
            comboBox_Comision.Items.Clear();
            cargarComisiones();
        }

        private void Cliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                DialogResult salir = MessageBox.Show("Seguro desea Salir?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (salir == DialogResult.OK)
                {
                    Application.Exit();
                    (interfaz as ICommunicationObject).Close();
                    ObjetoRemoto.Servidor.StopServer();
                }
                else
                {
                    return;
                }
            }
            catch (Exception)
            {
                System.Environment.Exit(0);
                (interfaz as ICommunicationObject).Close();
                ObjetoRemoto.Servidor.StopServer();
            }
        }

        private void imprimirDocumento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int altura = 50;
            for (int i = 0; i < listBox_Acta.Items.Count; i++)
            {
                listBox_Acta.SelectedIndex = i;
                e.Graphics.DrawString(listBox_Acta.Text, listBox_Acta.Font, new SolidBrush(listBox_Acta.ForeColor), 50, altura, StringFormat.GenericDefault);
                altura += listBox_Acta.ItemHeight;
            }
        }
        
        private void txt_nombreComision_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_numeroMiembros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_nombreMiembros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_Tema_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_numeroMiembros_Leave(object sender, EventArgs e)
        {
            cantidadMiembros = Convert.ToInt32(txt_numeroMiembros.Text);
        }

        private void comboBox_Comision_Leave(object sender, EventArgs e)
        {
            if (comboBox_Comision.SelectedItem == null)
            {
                MessageBox.Show("Debe escoger una comision...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                comboBox_Comision.Focus();
            }
        }
       
        private void comboBox_Cargo_Leave(object sender, EventArgs e)
        {
            if (comboBox_Cargo.SelectedItem == null)
            {
                MessageBox.Show("Debe escoger un cargo para el miembro...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                comboBox_Cargo.Text = "";
                comboBox_Cargo.Focus();
            }
        }

        private void txt_Correo_Leave(object sender, EventArgs e)
        {
            if (ComprobarFormatoEmail(txt_Correo.Text) == false)
            {
                MessageBox.Show("La direccion de correo no es valida...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Correo.Clear();
                txt_Correo.Focus();
            }
            else
            {
                boton_Agregar.Focus();
            }
        }
    }
}