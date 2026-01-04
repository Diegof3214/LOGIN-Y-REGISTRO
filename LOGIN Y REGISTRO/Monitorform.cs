using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LOGIN_Y_REGISTRO
{
    public partial class Monitorform : Form
    {
        MySqlConnection con = new MySqlConnection("server=sql10.freemysqlhosting.net;user id=sql10594764;password = isd8CniEEM; database=sql10594764");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table;
        public Monitorform()
        {
            InitializeComponent();
        }

        private DataTable GetData(string sql)
        {
            string constr = @"server=sql10.freemysqlhosting.net;user id=sql10594764;password = isd8CniEEM; database=sql10594764";
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                using (MySqlDataAdapter sda = new MySqlDataAdapter(sql, con))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    DataRow row = dt.NewRow();
                    row[0] = 0;
                    row[1] = "Por Favor Seleccione";
                    dt.Rows.InsertAt(row, 0);
                    return dt;

                }
            }

        }

        private void Monitorform_Load(object sender, EventArgs e)
        {
            COMBOAREA.DataSource = this.GetData("SELECT `IDAREA`, `AREA` FROM `area`");
            COMBOAREA.DisplayMember = "AREA";
            COMBOAREA.ValueMember = "IDAREA";
            comboProfe.Enabled = false;

            COMBOTURNO.DataSource = this.GetData("SELECT `Id`, `Turno` FROM `turno`");
            COMBOTURNO.DisplayMember = "Turno";
            COMBOTURNO.ValueMember = "Turno";

            COMBOASIS.DataSource = this.GetData("SELECT `IDASIS`, `INASISTENCIA` FROM `asistencia`");
            COMBOASIS.DisplayMember = "INASISTENCIA";
            COMBOASIS.ValueMember = "INASISTENCIA";
          
        }

        public void fillcombo(ComboBox combo, string query, string displayMember, string valueMember)
        {
            command = new MySqlCommand(query, con);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            combo.DataSource = table;
            combo.DisplayMember = displayMember;
            combo.ValueMember = valueMember;
            
            

        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TXTPROF_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BTPROFESOR_Click(object sender, EventArgs e)
        {
            if (comboProfe.SelectedValue == null)
            {
                MessageBox.Show("EL ÁREA NO HA SIDO COMPLETADA.", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            else
            {


                DB db = new DB();
                MySqlCommand command = new MySqlCommand("INSERT INTO `monitoreo`(`AREA`,`NOMBRE DEL PROFESOR`, `INASISTENCIA`, `AULA`, `Fecha`, `HORA DE ENTRADA`, `HORA DE SALIDA`, `Turno`, `Numero de Alumnos`, `TEMA`) VALUES (@area,@profe,@asis,'" + TXGRADO.Text + "' ' - ' '" + TXSECCION.Text + "',@date,@entrada,@salida,@turno,@alumnos,@TEMA)", db.GetConnection());

                command.Parameters.Add("@area", MySqlDbType.VarChar).Value = COMBOAREA.SelectedValue.ToString();
                command.Parameters.Add("@profe", MySqlDbType.VarChar).Value = comboProfe.SelectedValue.ToString();
                command.Parameters.Add("@asis", MySqlDbType.VarChar).Value = COMBOASIS.SelectedValue.ToString();
                command.Parameters.Add("@date", MySqlDbType.VarChar).Value = this.TXDATE.Text;
                command.Parameters.Add("@entrada", MySqlDbType.VarChar).Value = this.TXTENTRADA.Text;
                command.Parameters.Add("@salida", MySqlDbType.VarChar).Value = this.TXTSALIDA.Text;
                command.Parameters.Add("@turno", MySqlDbType.VarChar).Value = COMBOTURNO.SelectedValue.ToString();
                command.Parameters.Add("@alumnos", MySqlDbType.VarChar).Value = TXALUM.Text;
                command.Parameters.Add("@tema", MySqlDbType.VarChar).Value = TXTEMA.Text;

                db.OpenConnnection();



                if (!checkTextBoxesValues())
                {
                    if (checkusername())
                    {
                        MessageBox.Show("EL PROFESOR YA INGRESO", "PROFESOR DUPLICADO", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (COMBOASIS.SelectedValue.ToString().Equals("Por Favor Seleccione"))
                        {
                            MessageBox.Show("LA INASISTENCIA NO HA SIDO COMPLETADA.", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (TXGRADO.Text.Equals("GRADO"))
                            {
                                MessageBox.Show("EL GRADO NO HA SIDO COMPLETADO.", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                            }
                            else
                            {
                                int testValue;
                                if (int.TryParse(TXGRADO.Text, out testValue))
                                {
                                    if (testValue > 5 || testValue == 0)
                                    {
                                        MessageBox.Show("Por favor ingrese un grado valido.", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        if (TXSECCION.Text.Equals("SECCION"))
                                        {
                                            MessageBox.Show("LA SECCIÓN NO HA SIDO COMPLETADA.", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                                        }
                                        else
                                        {

                                            if (TXDATE.Value.Date < DateTime.Now.Date)
                                            {
                                                MessageBox.Show("LA FECHA NO PUEDE SER ANTERIOR AL DÍA DE HOY.", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                                            }
                                            else
                                            {
                                                if (TXTENTRADA.Text.Equals(TXTSALIDA.Text))
                                                {
                                                    MessageBox.Show("LA HORA DE ENTRADA Y LA HORA DE SALIDA NO PUEDEN SER IGUALES.", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                                                }
                                                else
                                                {
                                                    if (TXTENTRADA.Value > TXTSALIDA.Value)
                                                    {
                                                        MessageBox.Show("LA HORA DE ENTRADA NO PUEDE SER POSTERIOR A LA HORA DE SALIDA.", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                                                    }
                                                    else
                                                    {
                                                        if (COMBOTURNO.SelectedValue.ToString().Equals("Por Favor Seleccione"))
                                                        {
                                                            MessageBox.Show("EL TURNO NO HA SIDO COMPLETADO.", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                                                        }

                                                        else
                                                        {
                                                            if (TXALUM.Text.Equals(""))
                                                            {
                                                                MessageBox.Show("EL NÚMERO DE ALUMNOS NO HA SIDO COMPLETADO.", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                                                            }
                                                            else
                                                            {
                                                                if (TXTEMA.Text.Equals(""))
                                                                {
                                                                    MessageBox.Show("EL TEMA NO HA SIDO COMPLETADO.", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                                                                }
                                                                else
                                                                {

                                                                    if (command.ExecuteNonQuery() > 0)
                                                                    {
                                                                        MessageBox.Show("SE REGISTRÓ LA ASISTENCIA DEL DOCENTE.", "CUENTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                    }
                                                                    else
                                                                    {
                                                                        MessageBox.Show("ERROR");
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }


                else
                {
                    MessageBox.Show("EL NOMBRE DEL PROFESOR NO HA SIDO COMPLETADO.", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

                db.CloseConnnection();

            }
        }
        public Boolean checkusername()
        {
            DB db = new DB();

            string fecha = TXDATE.Text;
            string profe = comboProfe.SelectedItem.ToString();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `monitoreo` WHERE `FECHA` = @date AND `NOMBRE DEL PROFESOR` = @profe", db.GetConnection());
            command.Parameters.Add("@date", MySqlDbType.VarChar).Value = fecha;
            command.Parameters.Add("@profe", MySqlDbType.VarChar).Value = profe;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public Boolean checkTextBoxesValues()
        {
            string fprofe = comboProfe.SelectedValue.ToString();

            if (fprofe.Equals("Por Favor Seleccione") || fprofe.Equals(null))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void TXAULA_TextChanged(object sender, EventArgs e)
        {
        }

        private void TXALUM_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXALUM_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!char.IsDigit(chr)&&chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Por favor ingrese un valor valido.");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BT_ASIGNACION_Click(object sender, EventArgs e)
        {
            this.Hide();
            Asignacionform asignacionform = new Asignacionform();
            asignacionform.Show();
        }

        private void BT_RECURSOS_Click(object sender, EventArgs e)
        {
            this.Hide();
            Recursosform recursosform = new Recursosform();
            recursosform.Show();
        }

        private void comboProfe_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void COMBOAREA_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void COMBOAREA_SelectionChangeCommitted(object sender, EventArgs e)
        {

            comboProfe.DataSource = null;
            comboProfe.Enabled = false;
            if (COMBOAREA.SelectedValue.ToString() != "0")
            {
                string sql = string.Format("SELECT `IdDocente`, `Docente` FROM `docente` WHERE `AREA` = {0}", COMBOAREA.SelectedValue);
                comboProfe.DataSource = this.GetData(sql);
                comboProfe.DisplayMember = "Docente";
                comboProfe.ValueMember = "Docente";
                comboProfe.Enabled = true;
            }
                       
        }

        private void TXGRADO_Enter(object sender, EventArgs e)
        {
            string fname = TXGRADO.Text;
            if (fname.ToUpper().Trim().Equals("GRADO"))
            {
                TXGRADO.Text = "";
                TXGRADO.ForeColor = Color.Black;
            }


        }

        private void TXGRADO_Leave(object sender, EventArgs e)
        {
            string fname = TXGRADO.Text;

            if (fname.ToUpper().Trim().Equals("GRADO") || fname.Trim().Equals(""))
            {
                TXGRADO.Text = "GRADO";
                TXGRADO.ForeColor = Color.Gray;
            }
        }

        private void TXSECCION_Enter(object sender, EventArgs e)
        {
            string fname = TXSECCION.Text;
            if (fname.ToUpper().Trim().Equals("SECCION"))
            {
                TXSECCION.Text = "";
                TXSECCION.ForeColor = Color.Black;
            }
        }

        private void TXSECCION_Leave(object sender, EventArgs e)
        {
            string fname = TXSECCION.Text;

            if (fname.ToUpper().Trim().Equals("SECCION") || fname.Trim().Equals(""))
            {
                TXSECCION.Text = "SECCION";
                TXSECCION.ForeColor = Color.Gray;
            }
        }

        private void TXGRADO_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Por favor ingrese un valor valido.");
            }

        }

        private void TXSECCION_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!char.IsLetter(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Por favor ingrese un valor valido.");
            }
        }

        private void TXGRADO_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void TXGRADO_Validated(object sender, EventArgs e)
        {

        }

        private void BTAJUSTES_Click(object sender, EventArgs e)
        {
            this.Hide();
            AJUSTEFORM ajusteform = new AJUSTEFORM();
            ajusteform.Show();
        }
    }
}
