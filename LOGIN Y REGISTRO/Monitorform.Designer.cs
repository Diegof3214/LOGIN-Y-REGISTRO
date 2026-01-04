namespace LOGIN_Y_REGISTRO
{
    partial class Monitorform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Monitorform));
            this.TXTNOMPRO = new System.Windows.Forms.Label();
            this.COMBOASIS = new System.Windows.Forms.ComboBox();
            this.TXTINAS = new System.Windows.Forms.Label();
            this.ENTRADA = new System.Windows.Forms.Label();
            this.TXTTURNO = new System.Windows.Forms.Label();
            this.COMBOTURNO = new System.Windows.Forms.ComboBox();
            this.NUMALUMNOS = new System.Windows.Forms.Label();
            this.TXALUM = new System.Windows.Forms.TextBox();
            this.TEMA = new System.Windows.Forms.Label();
            this.SALIDA = new System.Windows.Forms.Label();
            this.TXTEMA = new System.Windows.Forms.TextBox();
            this.BTPROFESOR = new System.Windows.Forms.Button();
            this.AULA = new System.Windows.Forms.Label();
            this.TXGRADO = new System.Windows.Forms.TextBox();
            this.Area = new System.Windows.Forms.Label();
            this.COMBOAREA = new System.Windows.Forms.ComboBox();
            this.FECHA = new System.Windows.Forms.Label();
            this.TXDATE = new System.Windows.Forms.DateTimePicker();
            this.comboProfe = new System.Windows.Forms.ComboBox();
            this.BT_RECURSOS = new System.Windows.Forms.Button();
            this.BT_ASIGNACION = new System.Windows.Forms.Button();
            this.TXTENTRADA = new System.Windows.Forms.DateTimePicker();
            this.TXTSALIDA = new System.Windows.Forms.DateTimePicker();
            this.MONITOREO = new System.Windows.Forms.Label();
            this.TXSECCION = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTAJUSTES = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TXTNOMPRO
            // 
            resources.ApplyResources(this.TXTNOMPRO, "TXTNOMPRO");
            this.TXTNOMPRO.Name = "TXTNOMPRO";
            this.TXTNOMPRO.Click += new System.EventHandler(this.label1_Click);
            // 
            // COMBOASIS
            // 
            resources.ApplyResources(this.COMBOASIS, "COMBOASIS");
            this.COMBOASIS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMBOASIS.FormattingEnabled = true;
            this.COMBOASIS.Name = "COMBOASIS";
            this.COMBOASIS.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // TXTINAS
            // 
            resources.ApplyResources(this.TXTINAS, "TXTINAS");
            this.TXTINAS.Name = "TXTINAS";
            // 
            // ENTRADA
            // 
            resources.ApplyResources(this.ENTRADA, "ENTRADA");
            this.ENTRADA.Name = "ENTRADA";
            // 
            // TXTTURNO
            // 
            resources.ApplyResources(this.TXTTURNO, "TXTTURNO");
            this.TXTTURNO.Name = "TXTTURNO";
            // 
            // COMBOTURNO
            // 
            resources.ApplyResources(this.COMBOTURNO, "COMBOTURNO");
            this.COMBOTURNO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMBOTURNO.FormattingEnabled = true;
            this.COMBOTURNO.Name = "COMBOTURNO";
            this.COMBOTURNO.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // NUMALUMNOS
            // 
            resources.ApplyResources(this.NUMALUMNOS, "NUMALUMNOS");
            this.NUMALUMNOS.Name = "NUMALUMNOS";
            // 
            // TXALUM
            // 
            resources.ApplyResources(this.TXALUM, "TXALUM");
            this.TXALUM.Name = "TXALUM";
            this.TXALUM.TextChanged += new System.EventHandler(this.TXALUM_TextChanged);
            this.TXALUM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXALUM_KeyPress);
            // 
            // TEMA
            // 
            resources.ApplyResources(this.TEMA, "TEMA");
            this.TEMA.Name = "TEMA";
            // 
            // SALIDA
            // 
            resources.ApplyResources(this.SALIDA, "SALIDA");
            this.SALIDA.Name = "SALIDA";
            // 
            // TXTEMA
            // 
            resources.ApplyResources(this.TXTEMA, "TXTEMA");
            this.TXTEMA.Name = "TXTEMA";
            // 
            // BTPROFESOR
            // 
            resources.ApplyResources(this.BTPROFESOR, "BTPROFESOR");
            this.BTPROFESOR.Name = "BTPROFESOR";
            this.BTPROFESOR.UseVisualStyleBackColor = true;
            this.BTPROFESOR.Click += new System.EventHandler(this.BTPROFESOR_Click);
            // 
            // AULA
            // 
            resources.ApplyResources(this.AULA, "AULA");
            this.AULA.Name = "AULA";
            // 
            // TXGRADO
            // 
            resources.ApplyResources(this.TXGRADO, "TXGRADO");
            this.TXGRADO.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TXGRADO.Name = "TXGRADO";
            this.TXGRADO.TextChanged += new System.EventHandler(this.TXAULA_TextChanged);
            this.TXGRADO.Enter += new System.EventHandler(this.TXGRADO_Enter);
            this.TXGRADO.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXGRADO_KeyDown);
            this.TXGRADO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXGRADO_KeyPress);
            this.TXGRADO.Leave += new System.EventHandler(this.TXGRADO_Leave);
            this.TXGRADO.Validated += new System.EventHandler(this.TXGRADO_Validated);
            // 
            // Area
            // 
            resources.ApplyResources(this.Area, "Area");
            this.Area.Name = "Area";
            // 
            // COMBOAREA
            // 
            resources.ApplyResources(this.COMBOAREA, "COMBOAREA");
            this.COMBOAREA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMBOAREA.FormattingEnabled = true;
            this.COMBOAREA.Name = "COMBOAREA";
            this.COMBOAREA.SelectedIndexChanged += new System.EventHandler(this.COMBOAREA_SelectedIndexChanged);
            this.COMBOAREA.SelectionChangeCommitted += new System.EventHandler(this.COMBOAREA_SelectionChangeCommitted);
            // 
            // FECHA
            // 
            resources.ApplyResources(this.FECHA, "FECHA");
            this.FECHA.Name = "FECHA";
            // 
            // TXDATE
            // 
            resources.ApplyResources(this.TXDATE, "TXDATE");
            this.TXDATE.Cursor = System.Windows.Forms.Cursors.Default;
            this.TXDATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TXDATE.Name = "TXDATE";
            this.TXDATE.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // comboProfe
            // 
            resources.ApplyResources(this.comboProfe, "comboProfe");
            this.comboProfe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProfe.FormattingEnabled = true;
            this.comboProfe.Name = "comboProfe";
            this.comboProfe.SelectedIndexChanged += new System.EventHandler(this.comboProfe_SelectedIndexChanged);
            // 
            // BT_RECURSOS
            // 
            resources.ApplyResources(this.BT_RECURSOS, "BT_RECURSOS");
            this.BT_RECURSOS.Name = "BT_RECURSOS";
            this.BT_RECURSOS.UseVisualStyleBackColor = true;
            this.BT_RECURSOS.Click += new System.EventHandler(this.BT_RECURSOS_Click);
            // 
            // BT_ASIGNACION
            // 
            resources.ApplyResources(this.BT_ASIGNACION, "BT_ASIGNACION");
            this.BT_ASIGNACION.Name = "BT_ASIGNACION";
            this.BT_ASIGNACION.UseVisualStyleBackColor = true;
            this.BT_ASIGNACION.Click += new System.EventHandler(this.BT_ASIGNACION_Click);
            // 
            // TXTENTRADA
            // 
            resources.ApplyResources(this.TXTENTRADA, "TXTENTRADA");
            this.TXTENTRADA.Cursor = System.Windows.Forms.Cursors.Default;
            this.TXTENTRADA.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TXTENTRADA.Name = "TXTENTRADA";
            this.TXTENTRADA.ShowUpDown = true;
            // 
            // TXTSALIDA
            // 
            resources.ApplyResources(this.TXTSALIDA, "TXTSALIDA");
            this.TXTSALIDA.Cursor = System.Windows.Forms.Cursors.Default;
            this.TXTSALIDA.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TXTSALIDA.Name = "TXTSALIDA";
            this.TXTSALIDA.ShowUpDown = true;
            // 
            // MONITOREO
            // 
            resources.ApplyResources(this.MONITOREO, "MONITOREO");
            this.MONITOREO.Name = "MONITOREO";
            // 
            // TXSECCION
            // 
            resources.ApplyResources(this.TXSECCION, "TXSECCION");
            this.TXSECCION.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXSECCION.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TXSECCION.Name = "TXSECCION";
            this.TXSECCION.Enter += new System.EventHandler(this.TXSECCION_Enter);
            this.TXSECCION.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXSECCION_KeyPress);
            this.TXSECCION.Leave += new System.EventHandler(this.TXSECCION_Leave);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // BTAJUSTES
            // 
            resources.ApplyResources(this.BTAJUSTES, "BTAJUSTES");
            this.BTAJUSTES.Name = "BTAJUSTES";
            this.BTAJUSTES.UseVisualStyleBackColor = true;
            this.BTAJUSTES.Click += new System.EventHandler(this.BTAJUSTES_Click);
            // 
            // Monitorform
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BTAJUSTES);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXSECCION);
            this.Controls.Add(this.BTPROFESOR);
            this.Controls.Add(this.TXTSALIDA);
            this.Controls.Add(this.TXTENTRADA);
            this.Controls.Add(this.BT_RECURSOS);
            this.Controls.Add(this.BT_ASIGNACION);
            this.Controls.Add(this.comboProfe);
            this.Controls.Add(this.TXDATE);
            this.Controls.Add(this.FECHA);
            this.Controls.Add(this.COMBOAREA);
            this.Controls.Add(this.Area);
            this.Controls.Add(this.TXGRADO);
            this.Controls.Add(this.AULA);
            this.Controls.Add(this.TXTEMA);
            this.Controls.Add(this.SALIDA);
            this.Controls.Add(this.TEMA);
            this.Controls.Add(this.TXALUM);
            this.Controls.Add(this.NUMALUMNOS);
            this.Controls.Add(this.COMBOTURNO);
            this.Controls.Add(this.TXTTURNO);
            this.Controls.Add(this.ENTRADA);
            this.Controls.Add(this.TXTINAS);
            this.Controls.Add(this.COMBOASIS);
            this.Controls.Add(this.TXTNOMPRO);
            this.Controls.Add(this.MONITOREO);
            this.Name = "Monitorform";
            this.Load += new System.EventHandler(this.Monitorform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TXTNOMPRO;
        private System.Windows.Forms.ComboBox COMBOASIS;
        private System.Windows.Forms.Label TXTINAS;
        private System.Windows.Forms.Label ENTRADA;
        private System.Windows.Forms.Label TXTTURNO;
        private System.Windows.Forms.ComboBox COMBOTURNO;
        private System.Windows.Forms.Label NUMALUMNOS;
        private System.Windows.Forms.TextBox TXALUM;
        private System.Windows.Forms.Label TEMA;
        private System.Windows.Forms.Label SALIDA;
        private System.Windows.Forms.TextBox TXTEMA;
        private System.Windows.Forms.Button BTPROFESOR;
        private System.Windows.Forms.Label AULA;
        private System.Windows.Forms.TextBox TXGRADO;
        private System.Windows.Forms.Label Area;
        private System.Windows.Forms.ComboBox COMBOAREA;
        private System.Windows.Forms.Label FECHA;
        private System.Windows.Forms.DateTimePicker TXDATE;
        private System.Windows.Forms.ComboBox comboProfe;
        private System.Windows.Forms.Button BT_RECURSOS;
        private System.Windows.Forms.Button BT_ASIGNACION;
        private System.Windows.Forms.DateTimePicker TXTENTRADA;
        private System.Windows.Forms.DateTimePicker TXTSALIDA;
        private System.Windows.Forms.Label MONITOREO;
        private System.Windows.Forms.TextBox TXSECCION;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTAJUSTES;
    }
}