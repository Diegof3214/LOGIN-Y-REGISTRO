namespace LOGIN_Y_REGISTRO
{
    partial class Asignacionform
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
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.BT_MONITOR = new System.Windows.Forms.Button();
            this.BT_RECURSOS = new System.Windows.Forms.Button();
            this.DATEINICIO = new System.Windows.Forms.DateTimePicker();
            this.DATEFIN = new System.Windows.Forms.DateTimePicker();
            this.FECHAINICIO = new System.Windows.Forms.Label();
            this.FECHAFIN = new System.Windows.Forms.Label();
            this.btbuscar = new System.Windows.Forms.Button();
            this.comboarea = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.BTAJUSTES = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid
            // 
            this.datagrid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Location = new System.Drawing.Point(12, 135);
            this.datagrid.Name = "datagrid";
            this.datagrid.ReadOnly = true;
            this.datagrid.Size = new System.Drawing.Size(807, 274);
            this.datagrid.TabIndex = 1;
            this.datagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BT_MONITOR
            // 
            this.BT_MONITOR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BT_MONITOR.Location = new System.Drawing.Point(11, 418);
            this.BT_MONITOR.Name = "BT_MONITOR";
            this.BT_MONITOR.Size = new System.Drawing.Size(108, 23);
            this.BT_MONITOR.TabIndex = 5;
            this.BT_MONITOR.Text = "MONITOREO";
            this.BT_MONITOR.UseVisualStyleBackColor = true;
            this.BT_MONITOR.Click += new System.EventHandler(this.BT_MONITOR_Click);
            // 
            // BT_RECURSOS
            // 
            this.BT_RECURSOS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BT_RECURSOS.Location = new System.Drawing.Point(363, 418);
            this.BT_RECURSOS.Name = "BT_RECURSOS";
            this.BT_RECURSOS.Size = new System.Drawing.Size(106, 23);
            this.BT_RECURSOS.TabIndex = 4;
            this.BT_RECURSOS.Text = "RECURSOS";
            this.BT_RECURSOS.UseVisualStyleBackColor = true;
            this.BT_RECURSOS.Click += new System.EventHandler(this.BT_ASIGNACION_Click);
            // 
            // DATEINICIO
            // 
            this.DATEINICIO.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DATEINICIO.CustomFormat = "MM/dd/yyyy";
            this.DATEINICIO.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DATEINICIO.Location = new System.Drawing.Point(128, 40);
            this.DATEINICIO.Name = "DATEINICIO";
            this.DATEINICIO.Size = new System.Drawing.Size(90, 20);
            this.DATEINICIO.TabIndex = 6;
            this.DATEINICIO.Value = new System.DateTime(2020, 3, 1, 17, 16, 0, 0);
            // 
            // DATEFIN
            // 
            this.DATEFIN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DATEFIN.CustomFormat = "MM/dd/yyyy";
            this.DATEFIN.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DATEFIN.Location = new System.Drawing.Point(524, 40);
            this.DATEFIN.Name = "DATEFIN";
            this.DATEFIN.Size = new System.Drawing.Size(80, 20);
            this.DATEFIN.TabIndex = 7;
            // 
            // FECHAINICIO
            // 
            this.FECHAINICIO.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FECHAINICIO.AutoSize = true;
            this.FECHAINICIO.Location = new System.Drawing.Point(9, 40);
            this.FECHAINICIO.Name = "FECHAINICIO";
            this.FECHAINICIO.Size = new System.Drawing.Size(82, 13);
            this.FECHAINICIO.TabIndex = 8;
            this.FECHAINICIO.Text = "FECHA INICIAL";
            this.FECHAINICIO.Click += new System.EventHandler(this.FECHAINICIO_Click);
            // 
            // FECHAFIN
            // 
            this.FECHAFIN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FECHAFIN.AutoSize = true;
            this.FECHAFIN.Location = new System.Drawing.Point(401, 40);
            this.FECHAFIN.Name = "FECHAFIN";
            this.FECHAFIN.Size = new System.Drawing.Size(75, 13);
            this.FECHAFIN.TabIndex = 9;
            this.FECHAFIN.Text = "FECHA FINAL";
            // 
            // btbuscar
            // 
            this.btbuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btbuscar.Location = new System.Drawing.Point(736, 35);
            this.btbuscar.Name = "btbuscar";
            this.btbuscar.Size = new System.Drawing.Size(83, 25);
            this.btbuscar.TabIndex = 10;
            this.btbuscar.Text = "BUSCAR";
            this.btbuscar.UseVisualStyleBackColor = true;
            this.btbuscar.Click += new System.EventHandler(this.btbuscar_Click);
            // 
            // comboarea
            // 
            this.comboarea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboarea.FormattingEnabled = true;
            this.comboarea.Location = new System.Drawing.Point(12, 90);
            this.comboarea.Name = "comboarea";
            this.comboarea.Size = new System.Drawing.Size(206, 21);
            this.comboarea.TabIndex = 0;
            this.comboarea.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboarea.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(608, 90);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(211, 21);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.comboBox2.SelectionChangeCommitted += new System.EventHandler(this.comboBox2_SelectionChangeCommitted);
            // 
            // BTAJUSTES
            // 
            this.BTAJUSTES.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTAJUSTES.Location = new System.Drawing.Point(714, 418);
            this.BTAJUSTES.Name = "BTAJUSTES";
            this.BTAJUSTES.Size = new System.Drawing.Size(106, 23);
            this.BTAJUSTES.TabIndex = 26;
            this.BTAJUSTES.Text = "AJUSTES";
            this.BTAJUSTES.UseVisualStyleBackColor = true;
            this.BTAJUSTES.Click += new System.EventHandler(this.BTAJUSTES_Click);
            // 
            // Asignacionform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 450);
            this.Controls.Add(this.BTAJUSTES);
            this.Controls.Add(this.btbuscar);
            this.Controls.Add(this.FECHAFIN);
            this.Controls.Add(this.FECHAINICIO);
            this.Controls.Add(this.DATEFIN);
            this.Controls.Add(this.DATEINICIO);
            this.Controls.Add(this.BT_MONITOR);
            this.Controls.Add(this.BT_RECURSOS);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.datagrid);
            this.Controls.Add(this.comboarea);
            this.Name = "Asignacionform";
            this.Text = "PRESENTACION";
            this.Load += new System.EventHandler(this.Asignacionform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.Button BT_MONITOR;
        private System.Windows.Forms.Button BT_RECURSOS;
        private System.Windows.Forms.DateTimePicker DATEINICIO;
        private System.Windows.Forms.DateTimePicker DATEFIN;
        private System.Windows.Forms.Label FECHAINICIO;
        private System.Windows.Forms.Label FECHAFIN;
        private System.Windows.Forms.Button btbuscar;
        private System.Windows.Forms.ComboBox comboarea;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button BTAJUSTES;
    }
}