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
    public partial class Recursosform : Form
    {
        MySqlConnection con = new MySqlConnection("server=sql10.freemysqlhosting.net;user id=sql10594764;password = isd8CniEEM; database=sql10594764");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table;

        static string coString = "server=sql10.freemysqlhosting.net;user id=sql10594764;password = isd8CniEEM; database=sql10594764";
        MySqlConnection conn = new MySqlConnection(coString);
        MySqlCommand cmd;
        DataTable dt = new DataTable();

        private DataTable GetData1(string sql)
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
        public Recursosform()
        {
            InitializeComponent();

            dataGridView1.ColumnCount = 8;

            dataGridView1.Columns[0].Name = "IDMONITOREO";
            dataGridView1.Columns[1].Name = "AREA";
            dataGridView1.Columns[2].Name = "NOMBRE DEL PROFESOR";
            dataGridView1.Columns[3].Name = "FECHA";
            dataGridView1.Columns[4].Name = "TEMA";
            dataGridView1.Columns[5].Name = "NUMERO DE ALUMNOS";
            dataGridView1.Columns[6].Name = "NUMERO DE COMPUTADORAS USADAS";
            dataGridView1.Columns[7].Name = "SOFTWARE";

            this.dataGridView1.Columns["IDMONITOREO"].Visible = false;


            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
                       
        }



        private void add(string numerocomp, string software)
        {
            string selected = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            int id = Convert.ToInt32(selected);
            string sql = "INSERT INTO `monitoreo` (`NUMERO DE COMPUTADORAS USADAS`, `SOFTWARE`) VALUES (@COMPU,@SOFT) WHERE `IDMONITOREO`= '" + id + "'" ;
            cmd = new MySqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@COMPU", numerocomp);
            cmd.Parameters.AddWithValue("@SOFT", software);

            try
            {
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    cleartxts();
                    MessageBox.Show("INSERTADO EXITOSAMENTE.");
                }

                con.Close();
                Retrieve();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
         }

        private void populate(string id, string area ,string docente, string fecha , string TEMA , string alumnos , string numerocomp , string software )
        {
            dataGridView1.Rows.Add(id,area, docente, fecha, TEMA, alumnos, numerocomp, software);
        }

        private void Retrieve()
        {
            dataGridView1.Rows.Clear();

            if (combodocente.SelectedValue == null)
            {
                string sql = "SELECT `IDMONITOREO`, `AREA`, `NOMBRE DEL PROFESOR`, `FECHA`, `TEMA`, `NUMERO DE ALUMNOS`, `NUMERO DE COMPUTADORAS USADAS`, `SOFTWARE` FROM `monitoreo` WHERE FECHA between '" + DATEINICIO.Value.Date.ToString("MM/dd/yyyy") + "' and '" + DATEFIN.Value.Date.ToString("MM/dd/yyyy") + "'";
                cmd = new MySqlCommand(sql, con);

                try
                {
                    con.Open();
                    adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString());
                    }
                    con.Close();

                    dt.Rows.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }
            else
            {
                if (combodocente.SelectedValue.ToString().Equals("Por Favor Seleccione"))
                {
                    string sql = "SELECT `IDMONITOREO`, `AREA`, `NOMBRE DEL PROFESOR`, `FECHA`, `TEMA`, `NUMERO DE ALUMNOS`, `NUMERO DE COMPUTADORAS USADAS`, `SOFTWARE` FROM `monitoreo` WHERE `AREA` = @AREA AND `FECHA` between '" + DATEINICIO.Value.Date.ToString("MM/dd/yyyy") + "' and '" + DATEFIN.Value.Date.ToString("MM/dd/yyyy") + "'";
                    sql += "OR IFNULL(@AREA, '') = ''";
                    cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@AREA", comboarea.SelectedValue);

                    try
                    {
                        con.Open();
                        adapter = new MySqlDataAdapter(cmd);
                        adapter.Fill(dt);
                        foreach (DataRow row in dt.Rows)
                        {
                            populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString());
                        }
                        con.Close();

                        dt.Rows.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        con.Close();
                    }
                }
                else
                {
                    string sql = "SELECT `IDMONITOREO`, `AREA`, `NOMBRE DEL PROFESOR`, `FECHA`, `TEMA`, `NUMERO DE ALUMNOS`, `NUMERO DE COMPUTADORAS USADAS`, `SOFTWARE` FROM `monitoreo` WHERE `NOMBRE DEL PROFESOR` = @PROFE AND `FECHA` between '" + DATEINICIO.Value.Date.ToString("MM/dd/yyyy") + "' and '" + DATEFIN.Value.Date.ToString("MM/dd/yyyy") + "'";
                    sql += "OR IFNULL(@PROFE, '') = ''";
                    cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@PROFE", combodocente.SelectedValue);

                    try
                    {
                        con.Open();
                        adapter = new MySqlDataAdapter(cmd);
                        adapter.Fill(dt);
                        foreach (DataRow row in dt.Rows)
                        {
                            populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString());
                        }
                        con.Close();

                        dt.Rows.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        con.Close();
                    }
                }
            }
         }



        private void update(int id, string numerocomp, string software, string alumnos)
        {
            string sql = "UPDATE `monitoreo` SET `NUMERO DE COMPUTADORAS USADAS`='" + numerocomp + "',`SOFTWARE`='" + software + "',`NUMERO DE ALUMNOS`='" + alumnos + "' WHERE `IDMONITOREO`=" + id + "";
            cmd = new MySqlCommand(sql, con);
            try
            {
                con.Open();
                adapter.UpdateCommand = con.CreateCommand();
                adapter.UpdateCommand.CommandText = sql;


                if (adapter.UpdateCommand.ExecuteNonQuery() > 0)
                {
                    cleartxts();
                    MessageBox.Show("ACTUALIZADO EXITOSAMENTE.");
                }
                con.Close();
                Retrieve();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();


            }

        }

        private void delete(int id)
        {
            string sql = "DELETE FROM `monitoreo` WHERE `IDMONITOREO`=" + id + "";
            cmd = new MySqlCommand(sql, con);

            try
            {
                con.Open();
                adapter = new MySqlDataAdapter(cmd);
                adapter.DeleteCommand = con.CreateCommand();
                adapter.DeleteCommand.CommandText = sql;

                if(MessageBox.Show("Seguro?", "BORRAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        cleartxts();
                        MessageBox.Show("BORRADO EXITOSAMENTE.");
                    }
                }
                con.Close();
                Retrieve();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void cleartxts()
        {
            txcompu.Text = "";
        }
        

        private void Recursosform_Load(object sender, EventArgs e)
        {

            comboarea.DataSource = this.GetData1("SELECT `IDAREA`, `AREA` FROM `area`");
            comboarea.DisplayMember = "AREA";
            comboarea.ValueMember = "IDAREA";
            combodocente.Enabled = false;

            combosoft.DataSource = this.GetData1("SELECT * FROM software");
            combosoft.DisplayMember = "SOFTWARE";
            combosoft.ValueMember = "SOFTWARE";

        }

        public void fillcombo(ComboBox combo, string query, string displayMember, string valueMember)
        {
            command = new MySqlCommand(query, con);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();            
            adapter.Fill(table);
            combo.DisplayMember = displayMember;
            combo.ValueMember = valueMember;            
        }

        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void BT_ASIGNACION_Click(object sender, EventArgs e)
        {
            this.Hide();
            Asignacionform asignacionform = new Asignacionform();
            asignacionform.Show();
        }

        private void BT_MONITOR_Click(object sender, EventArgs e)
        {
            this.Hide();
            Monitorform monitorform = new Monitorform();
            monitorform.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            txcompu.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            TXTALUMNOS.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            combosoft.SelectedValue = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            if (combosoft.SelectedValue == null)
            {

                combosoft.SelectedValue = ("Por Favor Seleccione");
            }
        }

        private void BTAÑADIR_Click(object sender, EventArgs e)
        {
            add(txcompu.Text, combosoft.SelectedValue.ToString());
        }

        private void BTRecuperar_Click(object sender, EventArgs e)
        {
            Retrieve();
        }

        private void BTACTUALIZAR_Click(object sender, EventArgs e)

        {
            if (txcompu.Text.Equals(""))
            {
                MessageBox.Show("EL NÚMERO DE COMPUTADORAS UTILIZADAS NO HA SIDO COMPLETADO.", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                if (TXTALUMNOS.Text.Equals(""))
                {
                    MessageBox.Show("EL NÚMERO DE ALUMNOS NO HA SIDO COMPLETADO.", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {

                    if (combosoft.SelectedValue.ToString().Equals("Por Favor Seleccione"))
                    {
                        MessageBox.Show("EL SOFTWARE NO HA SIDO COMPLETADO.", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string selected = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                        int id = Convert.ToInt32(selected);

                        update(id, txcompu.Text, this.combosoft.SelectedValue.ToString(), TXTALUMNOS.Text);
                    }
                }
            }
        }

        private void BTBORRAR_Click(object sender, EventArgs e)
        {
            string selected = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            int id = Convert.ToInt32(selected);

            delete(id);
        }

        private void BTLIMPIAR_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void combosoft_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void combodocente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TEMA_Click(object sender, EventArgs e)
        {

        }

        private void COMBOTEMA_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txcompu_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Por favor ingrese un valor valido.");
            }
        }

        private void ALUMNOS_Click(object sender, EventArgs e)
        {

        }

        private void TXTALUMNOS_TextChanged(object sender, EventArgs e)
        {

        }

        private void txcompu_TextChanged(object sender, EventArgs e)
        {

        }

        private void combodocente_SelectionChangeCommitted(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            combodocente.DataSource = null;
            combodocente.Enabled = false;
            if (comboarea.SelectedValue.ToString() != "0")
            {
                string sql = string.Format("SELECT `IdDocente`, `Docente` FROM `docente` WHERE `AREA` = {0}", comboarea.SelectedValue);
                combodocente.DataSource = this.GetData1(sql);
                combodocente.DisplayMember = "Docente";
                combodocente.ValueMember = "Docente";
                combodocente.Enabled = true;
            }
        }

        private void SOFTWARE_Click(object sender, EventArgs e)
        {

        }

        private void TXTALUMNOS_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Por favor ingrese un valor valido.");
            }
        }

        private void BTAJUSTES_Click(object sender, EventArgs e)
        {
            this.Hide();
            AJUSTEFORM ajusteform = new AJUSTEFORM();
            ajusteform.Show();
        }
    }
}
