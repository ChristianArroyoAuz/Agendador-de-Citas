namespace Cliente
{
    partial class Cliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente));
            this.groupBox_Planificar = new System.Windows.Forms.GroupBox();
            this.boton_enviarCorreo = new System.Windows.Forms.Button();
            this.boton_vistaPrevia = new System.Windows.Forms.Button();
            this.txt_Tema = new System.Windows.Forms.TextBox();
            this.etiqueta_Tema = new System.Windows.Forms.Label();
            this.comboBox_Comision = new System.Windows.Forms.ComboBox();
            this.etiquetaComision = new System.Windows.Forms.Label();
            this.Tiempo_Reunion = new System.Windows.Forms.DateTimePicker();
            this.etiquetaReunion = new System.Windows.Forms.Label();
            this.groupBox_Generar = new System.Windows.Forms.GroupBox();
            this.txt_Acta = new System.Windows.Forms.TextBox();
            this.etiqueta_nombreActa = new System.Windows.Forms.Label();
            this.boton_vistaPrevia_Acta = new System.Windows.Forms.Button();
            this.botonGenerar = new System.Windows.Forms.Button();
            this.txt_Acuerdo_Tres = new System.Windows.Forms.TextBox();
            this.txt_Acuerdo_Dos = new System.Windows.Forms.TextBox();
            this.etiquetaAcuerdo_Tres = new System.Windows.Forms.Label();
            this.txt_Acuerdo_Uno = new System.Windows.Forms.TextBox();
            this.txt_Punto_Tres = new System.Windows.Forms.TextBox();
            this.txt_Punto_Dos = new System.Windows.Forms.TextBox();
            this.etiquetaAcuerdo_Dos = new System.Windows.Forms.Label();
            this.etiquetaAcuerdo_Uno = new System.Windows.Forms.Label();
            this.txt_Punto_Uno = new System.Windows.Forms.TextBox();
            this.etiquetaPunto_Tres = new System.Windows.Forms.Label();
            this.etiquetaPunto_Uno = new System.Windows.Forms.Label();
            this.etiquetaPunto_Dos = new System.Windows.Forms.Label();
            this.groupBox_Comisiones = new System.Windows.Forms.GroupBox();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.txt_Correo = new System.Windows.Forms.TextBox();
            this.etiquetaCorreo = new System.Windows.Forms.Label();
            this.boton_Agregar = new System.Windows.Forms.Button();
            this.etiqueta_puntos = new System.Windows.Forms.Label();
            this.etiqueta_Numero = new System.Windows.Forms.Label();
            this.comboBox_Cargo = new System.Windows.Forms.ComboBox();
            this.etiqueta_Cargo = new System.Windows.Forms.Label();
            this.txt_nombreMiembros = new System.Windows.Forms.TextBox();
            this.etiqueta_nombreMiembros = new System.Windows.Forms.Label();
            this.txt_nombreComision = new System.Windows.Forms.TextBox();
            this.etiqueta_Comision = new System.Windows.Forms.Label();
            this.txt_numeroMiembros = new System.Windows.Forms.TextBox();
            this.etiqueta_numeroMiembros = new System.Windows.Forms.Label();
            this.listBox_vistaPrevia = new System.Windows.Forms.ListBox();
            this.dataGridView_Comision = new System.Windows.Forms.DataGridView();
            this.listBox_Acta = new System.Windows.Forms.ListBox();
            this.imprimirDocumento = new System.Drawing.Printing.PrintDocument();
            this.dialogoImprimir = new System.Windows.Forms.PrintPreviewDialog();
            this.groupBox_Planificar.SuspendLayout();
            this.groupBox_Generar.SuspendLayout();
            this.groupBox_Comisiones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Comision)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Planificar
            // 
            this.groupBox_Planificar.Controls.Add(this.boton_enviarCorreo);
            this.groupBox_Planificar.Controls.Add(this.boton_vistaPrevia);
            this.groupBox_Planificar.Controls.Add(this.txt_Tema);
            this.groupBox_Planificar.Controls.Add(this.etiqueta_Tema);
            this.groupBox_Planificar.Controls.Add(this.comboBox_Comision);
            this.groupBox_Planificar.Controls.Add(this.etiquetaComision);
            this.groupBox_Planificar.Controls.Add(this.Tiempo_Reunion);
            this.groupBox_Planificar.Controls.Add(this.etiquetaReunion);
            this.groupBox_Planificar.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Planificar.Name = "groupBox_Planificar";
            this.groupBox_Planificar.Size = new System.Drawing.Size(330, 133);
            this.groupBox_Planificar.TabIndex = 0;
            this.groupBox_Planificar.TabStop = false;
            this.groupBox_Planificar.Text = "Planificar Reunion.";
            // 
            // boton_enviarCorreo
            // 
            this.boton_enviarCorreo.Location = new System.Drawing.Point(176, 98);
            this.boton_enviarCorreo.Name = "boton_enviarCorreo";
            this.boton_enviarCorreo.Size = new System.Drawing.Size(142, 23);
            this.boton_enviarCorreo.TabIndex = 7;
            this.boton_enviarCorreo.Text = "Enviar Correo";
            this.boton_enviarCorreo.UseVisualStyleBackColor = true;
            this.boton_enviarCorreo.Click += new System.EventHandler(this.boton_enviarCorreo_Click);
            // 
            // boton_vistaPrevia
            // 
            this.boton_vistaPrevia.Location = new System.Drawing.Point(9, 98);
            this.boton_vistaPrevia.Name = "boton_vistaPrevia";
            this.boton_vistaPrevia.Size = new System.Drawing.Size(142, 23);
            this.boton_vistaPrevia.TabIndex = 6;
            this.boton_vistaPrevia.Text = "Vista Previa";
            this.boton_vistaPrevia.UseVisualStyleBackColor = true;
            this.boton_vistaPrevia.Click += new System.EventHandler(this.boton_vistaPrevia_Click);
            // 
            // txt_Tema
            // 
            this.txt_Tema.Location = new System.Drawing.Point(118, 72);
            this.txt_Tema.Name = "txt_Tema";
            this.txt_Tema.Size = new System.Drawing.Size(200, 20);
            this.txt_Tema.TabIndex = 5;
            this.txt_Tema.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Tema_KeyPress);
            // 
            // etiqueta_Tema
            // 
            this.etiqueta_Tema.AutoSize = true;
            this.etiqueta_Tema.Location = new System.Drawing.Point(6, 79);
            this.etiqueta_Tema.Name = "etiqueta_Tema";
            this.etiqueta_Tema.Size = new System.Drawing.Size(80, 13);
            this.etiqueta_Tema.TabIndex = 2;
            this.etiqueta_Tema.Text = "Tema a Tratar: ";
            // 
            // comboBox_Comision
            // 
            this.comboBox_Comision.FormattingEnabled = true;
            this.comboBox_Comision.Location = new System.Drawing.Point(118, 45);
            this.comboBox_Comision.Name = "comboBox_Comision";
            this.comboBox_Comision.Size = new System.Drawing.Size(200, 21);
            this.comboBox_Comision.TabIndex = 4;
            this.comboBox_Comision.Click += new System.EventHandler(this.comboBox_Comision_Click);
            this.comboBox_Comision.Leave += new System.EventHandler(this.comboBox_Comision_Leave);
            // 
            // etiquetaComision
            // 
            this.etiquetaComision.AutoSize = true;
            this.etiquetaComision.Location = new System.Drawing.Point(6, 53);
            this.etiquetaComision.Name = "etiquetaComision";
            this.etiquetaComision.Size = new System.Drawing.Size(95, 13);
            this.etiquetaComision.TabIndex = 1;
            this.etiquetaComision.Text = "Nombre Comision: ";
            // 
            // Tiempo_Reunion
            // 
            this.Tiempo_Reunion.Location = new System.Drawing.Point(118, 19);
            this.Tiempo_Reunion.Name = "Tiempo_Reunion";
            this.Tiempo_Reunion.Size = new System.Drawing.Size(200, 20);
            this.Tiempo_Reunion.TabIndex = 3;
            // 
            // etiquetaReunion
            // 
            this.etiquetaReunion.AutoSize = true;
            this.etiquetaReunion.Location = new System.Drawing.Point(6, 26);
            this.etiquetaReunion.Name = "etiquetaReunion";
            this.etiquetaReunion.Size = new System.Drawing.Size(86, 13);
            this.etiquetaReunion.TabIndex = 0;
            this.etiquetaReunion.Text = "Fecha Reunion: ";
            // 
            // groupBox_Generar
            // 
            this.groupBox_Generar.Controls.Add(this.txt_Acta);
            this.groupBox_Generar.Controls.Add(this.etiqueta_nombreActa);
            this.groupBox_Generar.Controls.Add(this.boton_vistaPrevia_Acta);
            this.groupBox_Generar.Controls.Add(this.botonGenerar);
            this.groupBox_Generar.Controls.Add(this.txt_Acuerdo_Tres);
            this.groupBox_Generar.Controls.Add(this.txt_Acuerdo_Dos);
            this.groupBox_Generar.Controls.Add(this.etiquetaAcuerdo_Tres);
            this.groupBox_Generar.Controls.Add(this.txt_Acuerdo_Uno);
            this.groupBox_Generar.Controls.Add(this.txt_Punto_Tres);
            this.groupBox_Generar.Controls.Add(this.txt_Punto_Dos);
            this.groupBox_Generar.Controls.Add(this.etiquetaAcuerdo_Dos);
            this.groupBox_Generar.Controls.Add(this.etiquetaAcuerdo_Uno);
            this.groupBox_Generar.Controls.Add(this.txt_Punto_Uno);
            this.groupBox_Generar.Controls.Add(this.etiquetaPunto_Tres);
            this.groupBox_Generar.Controls.Add(this.etiquetaPunto_Uno);
            this.groupBox_Generar.Controls.Add(this.etiquetaPunto_Dos);
            this.groupBox_Generar.Location = new System.Drawing.Point(12, 340);
            this.groupBox_Generar.Name = "groupBox_Generar";
            this.groupBox_Generar.Size = new System.Drawing.Size(330, 238);
            this.groupBox_Generar.TabIndex = 2;
            this.groupBox_Generar.TabStop = false;
            this.groupBox_Generar.Text = "Generar Actas.";
            // 
            // txt_Acta
            // 
            this.txt_Acta.Location = new System.Drawing.Point(124, 175);
            this.txt_Acta.Name = "txt_Acta";
            this.txt_Acta.Size = new System.Drawing.Size(200, 20);
            this.txt_Acta.TabIndex = 13;
            // 
            // etiqueta_nombreActa
            // 
            this.etiqueta_nombreActa.AutoSize = true;
            this.etiqueta_nombreActa.Location = new System.Drawing.Point(6, 182);
            this.etiqueta_nombreActa.Name = "etiqueta_nombreActa";
            this.etiqueta_nombreActa.Size = new System.Drawing.Size(89, 13);
            this.etiqueta_nombreActa.TabIndex = 6;
            this.etiqueta_nombreActa.Text = "Nombre del Acta:";
            // 
            // boton_vistaPrevia_Acta
            // 
            this.boton_vistaPrevia_Acta.Location = new System.Drawing.Point(9, 201);
            this.boton_vistaPrevia_Acta.Name = "boton_vistaPrevia_Acta";
            this.boton_vistaPrevia_Acta.Size = new System.Drawing.Size(142, 23);
            this.boton_vistaPrevia_Acta.TabIndex = 14;
            this.boton_vistaPrevia_Acta.Text = "Vista Previa Acta";
            this.boton_vistaPrevia_Acta.UseVisualStyleBackColor = true;
            this.boton_vistaPrevia_Acta.Click += new System.EventHandler(this.boton_vistaPrevia_Acta_Click);
            // 
            // botonGenerar
            // 
            this.botonGenerar.Location = new System.Drawing.Point(182, 201);
            this.botonGenerar.Name = "botonGenerar";
            this.botonGenerar.Size = new System.Drawing.Size(142, 23);
            this.botonGenerar.TabIndex = 15;
            this.botonGenerar.Text = "Imprimir Acta";
            this.botonGenerar.UseVisualStyleBackColor = true;
            this.botonGenerar.Click += new System.EventHandler(this.botonGenerar_Click);
            // 
            // txt_Acuerdo_Tres
            // 
            this.txt_Acuerdo_Tres.Location = new System.Drawing.Point(124, 149);
            this.txt_Acuerdo_Tres.Name = "txt_Acuerdo_Tres";
            this.txt_Acuerdo_Tres.Size = new System.Drawing.Size(200, 20);
            this.txt_Acuerdo_Tres.TabIndex = 12;
            // 
            // txt_Acuerdo_Dos
            // 
            this.txt_Acuerdo_Dos.Location = new System.Drawing.Point(124, 123);
            this.txt_Acuerdo_Dos.Name = "txt_Acuerdo_Dos";
            this.txt_Acuerdo_Dos.Size = new System.Drawing.Size(200, 20);
            this.txt_Acuerdo_Dos.TabIndex = 11;
            // 
            // etiquetaAcuerdo_Tres
            // 
            this.etiquetaAcuerdo_Tres.AutoSize = true;
            this.etiquetaAcuerdo_Tres.Location = new System.Drawing.Point(6, 156);
            this.etiquetaAcuerdo_Tres.Name = "etiquetaAcuerdo_Tres";
            this.etiquetaAcuerdo_Tres.Size = new System.Drawing.Size(59, 13);
            this.etiquetaAcuerdo_Tres.TabIndex = 5;
            this.etiquetaAcuerdo_Tres.Text = "Acuerdo 3:";
            // 
            // txt_Acuerdo_Uno
            // 
            this.txt_Acuerdo_Uno.Location = new System.Drawing.Point(124, 97);
            this.txt_Acuerdo_Uno.Name = "txt_Acuerdo_Uno";
            this.txt_Acuerdo_Uno.Size = new System.Drawing.Size(200, 20);
            this.txt_Acuerdo_Uno.TabIndex = 10;
            // 
            // txt_Punto_Tres
            // 
            this.txt_Punto_Tres.Location = new System.Drawing.Point(124, 71);
            this.txt_Punto_Tres.Name = "txt_Punto_Tres";
            this.txt_Punto_Tres.Size = new System.Drawing.Size(200, 20);
            this.txt_Punto_Tres.TabIndex = 9;
            // 
            // txt_Punto_Dos
            // 
            this.txt_Punto_Dos.Location = new System.Drawing.Point(124, 45);
            this.txt_Punto_Dos.Name = "txt_Punto_Dos";
            this.txt_Punto_Dos.Size = new System.Drawing.Size(200, 20);
            this.txt_Punto_Dos.TabIndex = 8;
            // 
            // etiquetaAcuerdo_Dos
            // 
            this.etiquetaAcuerdo_Dos.AutoSize = true;
            this.etiquetaAcuerdo_Dos.Location = new System.Drawing.Point(6, 130);
            this.etiquetaAcuerdo_Dos.Name = "etiquetaAcuerdo_Dos";
            this.etiquetaAcuerdo_Dos.Size = new System.Drawing.Size(59, 13);
            this.etiquetaAcuerdo_Dos.TabIndex = 4;
            this.etiquetaAcuerdo_Dos.Text = "Acuerdo 2:";
            // 
            // etiquetaAcuerdo_Uno
            // 
            this.etiquetaAcuerdo_Uno.AutoSize = true;
            this.etiquetaAcuerdo_Uno.Location = new System.Drawing.Point(6, 104);
            this.etiquetaAcuerdo_Uno.Name = "etiquetaAcuerdo_Uno";
            this.etiquetaAcuerdo_Uno.Size = new System.Drawing.Size(59, 13);
            this.etiquetaAcuerdo_Uno.TabIndex = 3;
            this.etiquetaAcuerdo_Uno.Text = "Acuerdo 1:";
            // 
            // txt_Punto_Uno
            // 
            this.txt_Punto_Uno.Location = new System.Drawing.Point(124, 19);
            this.txt_Punto_Uno.Name = "txt_Punto_Uno";
            this.txt_Punto_Uno.Size = new System.Drawing.Size(200, 20);
            this.txt_Punto_Uno.TabIndex = 7;
            // 
            // etiquetaPunto_Tres
            // 
            this.etiquetaPunto_Tres.AutoSize = true;
            this.etiquetaPunto_Tres.Location = new System.Drawing.Point(6, 78);
            this.etiquetaPunto_Tres.Name = "etiquetaPunto_Tres";
            this.etiquetaPunto_Tres.Size = new System.Drawing.Size(47, 13);
            this.etiquetaPunto_Tres.TabIndex = 2;
            this.etiquetaPunto_Tres.Text = "Punto 3:";
            // 
            // etiquetaPunto_Uno
            // 
            this.etiquetaPunto_Uno.AutoSize = true;
            this.etiquetaPunto_Uno.Location = new System.Drawing.Point(6, 26);
            this.etiquetaPunto_Uno.Name = "etiquetaPunto_Uno";
            this.etiquetaPunto_Uno.Size = new System.Drawing.Size(47, 13);
            this.etiquetaPunto_Uno.TabIndex = 0;
            this.etiquetaPunto_Uno.Text = "Punto 1:";
            // 
            // etiquetaPunto_Dos
            // 
            this.etiquetaPunto_Dos.AutoSize = true;
            this.etiquetaPunto_Dos.Location = new System.Drawing.Point(6, 52);
            this.etiquetaPunto_Dos.Name = "etiquetaPunto_Dos";
            this.etiquetaPunto_Dos.Size = new System.Drawing.Size(47, 13);
            this.etiquetaPunto_Dos.TabIndex = 1;
            this.etiquetaPunto_Dos.Text = "Punto 2:";
            // 
            // groupBox_Comisiones
            // 
            this.groupBox_Comisiones.Controls.Add(this.botonLimpiar);
            this.groupBox_Comisiones.Controls.Add(this.txt_Correo);
            this.groupBox_Comisiones.Controls.Add(this.etiquetaCorreo);
            this.groupBox_Comisiones.Controls.Add(this.boton_Agregar);
            this.groupBox_Comisiones.Controls.Add(this.etiqueta_puntos);
            this.groupBox_Comisiones.Controls.Add(this.etiqueta_Numero);
            this.groupBox_Comisiones.Controls.Add(this.comboBox_Cargo);
            this.groupBox_Comisiones.Controls.Add(this.etiqueta_Cargo);
            this.groupBox_Comisiones.Controls.Add(this.txt_nombreMiembros);
            this.groupBox_Comisiones.Controls.Add(this.etiqueta_nombreMiembros);
            this.groupBox_Comisiones.Controls.Add(this.txt_nombreComision);
            this.groupBox_Comisiones.Controls.Add(this.etiqueta_Comision);
            this.groupBox_Comisiones.Controls.Add(this.txt_numeroMiembros);
            this.groupBox_Comisiones.Controls.Add(this.etiqueta_numeroMiembros);
            this.groupBox_Comisiones.Location = new System.Drawing.Point(12, 151);
            this.groupBox_Comisiones.Name = "groupBox_Comisiones";
            this.groupBox_Comisiones.Size = new System.Drawing.Size(330, 183);
            this.groupBox_Comisiones.TabIndex = 1;
            this.groupBox_Comisiones.TabStop = false;
            this.groupBox_Comisiones.Text = "Crear Comision.";
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Location = new System.Drawing.Point(9, 154);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(142, 23);
            this.botonLimpiar.TabIndex = 12;
            this.botonLimpiar.Text = "Limpiar DataGridView";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // txt_Correo
            // 
            this.txt_Correo.Location = new System.Drawing.Point(124, 124);
            this.txt_Correo.Name = "txt_Correo";
            this.txt_Correo.Size = new System.Drawing.Size(200, 20);
            this.txt_Correo.TabIndex = 11;
            this.txt_Correo.Leave += new System.EventHandler(this.txt_Correo_Leave);
            // 
            // etiquetaCorreo
            // 
            this.etiquetaCorreo.AutoSize = true;
            this.etiquetaCorreo.Location = new System.Drawing.Point(6, 131);
            this.etiquetaCorreo.Name = "etiquetaCorreo";
            this.etiquetaCorreo.Size = new System.Drawing.Size(100, 13);
            this.etiquetaCorreo.TabIndex = 6;
            this.etiquetaCorreo.Text = "Correo Electronico: ";
            // 
            // boton_Agregar
            // 
            this.boton_Agregar.Location = new System.Drawing.Point(182, 150);
            this.boton_Agregar.Name = "boton_Agregar";
            this.boton_Agregar.Size = new System.Drawing.Size(142, 23);
            this.boton_Agregar.TabIndex = 13;
            this.boton_Agregar.Text = "Agregar";
            this.boton_Agregar.UseVisualStyleBackColor = true;
            this.boton_Agregar.Click += new System.EventHandler(this.boton_Agregar_Click);
            // 
            // etiqueta_puntos
            // 
            this.etiqueta_puntos.AutoSize = true;
            this.etiqueta_puntos.Location = new System.Drawing.Point(99, 78);
            this.etiqueta_puntos.Name = "etiqueta_puntos";
            this.etiqueta_puntos.Size = new System.Drawing.Size(10, 13);
            this.etiqueta_puntos.TabIndex = 4;
            this.etiqueta_puntos.Text = ":";
            // 
            // etiqueta_Numero
            // 
            this.etiqueta_Numero.AutoSize = true;
            this.etiqueta_Numero.Location = new System.Drawing.Point(90, 78);
            this.etiqueta_Numero.Name = "etiqueta_Numero";
            this.etiqueta_Numero.Size = new System.Drawing.Size(13, 13);
            this.etiqueta_Numero.TabIndex = 3;
            this.etiqueta_Numero.Text = "1";
            // 
            // comboBox_Cargo
            // 
            this.comboBox_Cargo.FormattingEnabled = true;
            this.comboBox_Cargo.Items.AddRange(new object[] {
            "Presidente",
            "Secretario",
            "Miembro"});
            this.comboBox_Cargo.Location = new System.Drawing.Point(124, 97);
            this.comboBox_Cargo.Name = "comboBox_Cargo";
            this.comboBox_Cargo.Size = new System.Drawing.Size(200, 21);
            this.comboBox_Cargo.TabIndex = 10;
            this.comboBox_Cargo.Leave += new System.EventHandler(this.comboBox_Cargo_Leave);
            // 
            // etiqueta_Cargo
            // 
            this.etiqueta_Cargo.AutoSize = true;
            this.etiqueta_Cargo.Location = new System.Drawing.Point(6, 105);
            this.etiqueta_Cargo.Name = "etiqueta_Cargo";
            this.etiqueta_Cargo.Size = new System.Drawing.Size(84, 13);
            this.etiqueta_Cargo.TabIndex = 5;
            this.etiqueta_Cargo.Text = "Cargo Miembro: ";
            // 
            // txt_nombreMiembros
            // 
            this.txt_nombreMiembros.Location = new System.Drawing.Point(124, 71);
            this.txt_nombreMiembros.Name = "txt_nombreMiembros";
            this.txt_nombreMiembros.Size = new System.Drawing.Size(200, 20);
            this.txt_nombreMiembros.TabIndex = 9;
            this.txt_nombreMiembros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombreMiembros_KeyPress);
            // 
            // etiqueta_nombreMiembros
            // 
            this.etiqueta_nombreMiembros.AutoSize = true;
            this.etiqueta_nombreMiembros.Location = new System.Drawing.Point(6, 78);
            this.etiqueta_nombreMiembros.Name = "etiqueta_nombreMiembros";
            this.etiqueta_nombreMiembros.Size = new System.Drawing.Size(87, 13);
            this.etiqueta_nombreMiembros.TabIndex = 2;
            this.etiqueta_nombreMiembros.Text = "Nombre Miembro";
            // 
            // txt_nombreComision
            // 
            this.txt_nombreComision.Location = new System.Drawing.Point(124, 19);
            this.txt_nombreComision.Name = "txt_nombreComision";
            this.txt_nombreComision.Size = new System.Drawing.Size(200, 20);
            this.txt_nombreComision.TabIndex = 7;
            this.txt_nombreComision.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombreComision_KeyPress);
            // 
            // etiqueta_Comision
            // 
            this.etiqueta_Comision.AutoSize = true;
            this.etiqueta_Comision.Location = new System.Drawing.Point(6, 26);
            this.etiqueta_Comision.Name = "etiqueta_Comision";
            this.etiqueta_Comision.Size = new System.Drawing.Size(95, 13);
            this.etiqueta_Comision.TabIndex = 0;
            this.etiqueta_Comision.Text = "Nombre Comision: ";
            // 
            // txt_numeroMiembros
            // 
            this.txt_numeroMiembros.Location = new System.Drawing.Point(124, 45);
            this.txt_numeroMiembros.Name = "txt_numeroMiembros";
            this.txt_numeroMiembros.Size = new System.Drawing.Size(200, 20);
            this.txt_numeroMiembros.TabIndex = 8;
            this.txt_numeroMiembros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_numeroMiembros_KeyPress);
            this.txt_numeroMiembros.Leave += new System.EventHandler(this.txt_numeroMiembros_Leave);
            // 
            // etiqueta_numeroMiembros
            // 
            this.etiqueta_numeroMiembros.AutoSize = true;
            this.etiqueta_numeroMiembros.Location = new System.Drawing.Point(6, 52);
            this.etiqueta_numeroMiembros.Name = "etiqueta_numeroMiembros";
            this.etiqueta_numeroMiembros.Size = new System.Drawing.Size(113, 13);
            this.etiqueta_numeroMiembros.TabIndex = 1;
            this.etiqueta_numeroMiembros.Text = "Numero de Miembros: ";
            // 
            // listBox_vistaPrevia
            // 
            this.listBox_vistaPrevia.FormattingEnabled = true;
            this.listBox_vistaPrevia.HorizontalScrollbar = true;
            this.listBox_vistaPrevia.Location = new System.Drawing.Point(348, 12);
            this.listBox_vistaPrevia.Name = "listBox_vistaPrevia";
            this.listBox_vistaPrevia.Size = new System.Drawing.Size(470, 134);
            this.listBox_vistaPrevia.TabIndex = 3;
            // 
            // dataGridView_Comision
            // 
            this.dataGridView_Comision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Comision.Location = new System.Drawing.Point(348, 151);
            this.dataGridView_Comision.Name = "dataGridView_Comision";
            this.dataGridView_Comision.Size = new System.Drawing.Size(470, 183);
            this.dataGridView_Comision.TabIndex = 4;
            // 
            // listBox_Acta
            // 
            this.listBox_Acta.FormattingEnabled = true;
            this.listBox_Acta.Location = new System.Drawing.Point(348, 340);
            this.listBox_Acta.Name = "listBox_Acta";
            this.listBox_Acta.Size = new System.Drawing.Size(470, 238);
            this.listBox_Acta.TabIndex = 5;
            // 
            // imprimirDocumento
            // 
            this.imprimirDocumento.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.imprimirDocumento_PrintPage);
            // 
            // dialogoImprimir
            // 
            this.dialogoImprimir.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.dialogoImprimir.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.dialogoImprimir.ClientSize = new System.Drawing.Size(400, 300);
            this.dialogoImprimir.Document = this.imprimirDocumento;
            this.dialogoImprimir.Enabled = true;
            this.dialogoImprimir.Icon = ((System.Drawing.Icon)(resources.GetObject("dialogoImprimir.Icon")));
            this.dialogoImprimir.Name = "dialogoImprimir";
            this.dialogoImprimir.Visible = false;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 588);
            this.Controls.Add(this.listBox_Acta);
            this.Controls.Add(this.dataGridView_Comision);
            this.Controls.Add(this.listBox_vistaPrevia);
            this.Controls.Add(this.groupBox_Comisiones);
            this.Controls.Add(this.groupBox_Generar);
            this.Controls.Add(this.groupBox_Planificar);
            this.Name = "Cliente";
            this.Text = "Cliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cliente_FormClosing);
            this.Load += new System.EventHandler(this.Cliente_Load);
            this.groupBox_Planificar.ResumeLayout(false);
            this.groupBox_Planificar.PerformLayout();
            this.groupBox_Generar.ResumeLayout(false);
            this.groupBox_Generar.PerformLayout();
            this.groupBox_Comisiones.ResumeLayout(false);
            this.groupBox_Comisiones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Comision)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Planificar;
        private System.Windows.Forms.ComboBox comboBox_Comision;
        private System.Windows.Forms.Label etiquetaComision;
        private System.Windows.Forms.DateTimePicker Tiempo_Reunion;
        private System.Windows.Forms.Label etiquetaReunion;
        private System.Windows.Forms.GroupBox groupBox_Generar;
        private System.Windows.Forms.GroupBox groupBox_Comisiones;
        private System.Windows.Forms.Button boton_enviarCorreo;
        private System.Windows.Forms.Button boton_vistaPrevia;
        private System.Windows.Forms.TextBox txt_Tema;
        private System.Windows.Forms.Label etiqueta_Tema;
        private System.Windows.Forms.TextBox txt_numeroMiembros;
        private System.Windows.Forms.Label etiqueta_numeroMiembros;
        private System.Windows.Forms.TextBox txt_nombreComision;
        private System.Windows.Forms.Label etiqueta_Comision;
        private System.Windows.Forms.Label etiqueta_puntos;
        private System.Windows.Forms.Label etiqueta_Numero;
        private System.Windows.Forms.ComboBox comboBox_Cargo;
        private System.Windows.Forms.Label etiqueta_Cargo;
        private System.Windows.Forms.TextBox txt_nombreMiembros;
        private System.Windows.Forms.Label etiqueta_nombreMiembros;
        private System.Windows.Forms.Button boton_Agregar;
        private System.Windows.Forms.TextBox txt_Correo;
        private System.Windows.Forms.Label etiquetaCorreo;
        private System.Windows.Forms.ListBox listBox_vistaPrevia;
        private System.Windows.Forms.DataGridView dataGridView_Comision;
        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.Label etiquetaPunto_Tres;
        private System.Windows.Forms.Label etiquetaPunto_Dos;
        private System.Windows.Forms.Label etiquetaPunto_Uno;
        private System.Windows.Forms.TextBox txt_Punto_Tres;
        private System.Windows.Forms.TextBox txt_Punto_Dos;
        private System.Windows.Forms.TextBox txt_Punto_Uno;
        private System.Windows.Forms.TextBox txt_Acuerdo_Tres;
        private System.Windows.Forms.TextBox txt_Acuerdo_Dos;
        private System.Windows.Forms.Label etiquetaAcuerdo_Tres;
        private System.Windows.Forms.TextBox txt_Acuerdo_Uno;
        private System.Windows.Forms.Label etiquetaAcuerdo_Uno;
        private System.Windows.Forms.Label etiquetaAcuerdo_Dos;
        private System.Windows.Forms.Button boton_vistaPrevia_Acta;
        private System.Windows.Forms.Button botonGenerar;
        private System.Windows.Forms.ListBox listBox_Acta;
        private System.Windows.Forms.TextBox txt_Acta;
        private System.Windows.Forms.Label etiqueta_nombreActa;
        private System.Drawing.Printing.PrintDocument imprimirDocumento;
        private System.Windows.Forms.PrintPreviewDialog dialogoImprimir;
    }
}

