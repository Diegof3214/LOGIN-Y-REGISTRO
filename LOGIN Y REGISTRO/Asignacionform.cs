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
    public partial class Asignacionform : Form
    {
        MySqlConnection con = new MySqlConnection("server=sql10.freemysqlhosting.net;user id=sql10594764;password = isd8CniEEM; database=sql10594764");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table;

        public Asignacionform()
        {
            InitializeComponent();

        }
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
        private void Asignacionform_Load(object sender, EventArgs e)
        {

            comboarea.DataSource = this.GetData1("SELECT `IDAREA`, `AREA` FROM `area`");
            comboarea.DisplayMember = "AREA";
            comboarea.ValueMember = "IDAREA";
            comboBox2.Enabled = false;


            this.BindGrid();

        }
        private void BindGrid()
        {
            string conString = @"server=sql10.freemysqlhosting.net;user id=sql10594764;password = isd8CniEEM; database=sql10594764";
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT `AREA`, `NOMBRE DEL PROFESOR`, `INASISTENCIA`, `AULA`, `FECHA`, `HORA DE ENTRADA`, `HORA DE SALIDA`, `TURNO`, `NUMERO DE ALUMNOS`, `TEMA`, `NUMERO DE COMPUTADORAS USADAS`, `SOFTWARE` FROM `monitoreo`", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            datagrid.DataSource = dt;
                        }
                    }
                }
            }
        }


        private void Populatedatagridview()
        {
            
            
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
                
        }

        public void fillcombo(ComboBox combo, string query1, string displayMember, string valueMember)
        {
            command = new MySqlCommand(query1, con);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            combo.DataSource = table;
            combo.DisplayMember = displayMember;
            combo.ValueMember = valueMember;

        }

        private void BT_MONITOR_Click(object sender, EventArgs e)
        {
            this.Hide();
            Monitorform monitorform = new Monitorform();
            monitorform.Show();
        }

        private void BT_ASIGNACION_Click(object sender, EventArgs e)
        {
            this.Hide();
            Recursosform recursosform = new Recursosform();
            recursosform.Show();
        }

        

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void FECHAINICIO_Click(object sender, EventArgs e)
        {

        }

        private void btbuscar_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedValue == null)
            {
                DateTime dtFrom = Convert.ToDateTime(DATEINICIO.Value); //some DateTime value, e.g. DatePicker1.Text;
                DateTime dtTo = Convert.ToDateTime(DATEFIN.Value); //some DateTime value, e.g. 
                MySqlConnection mcon = new MySqlConnection("server=sql10.freemysqlhosting.net;user id=sql10594764;password = isd8CniEEM; database=sql10594764");
                MySqlDataAdapter mda = new MySqlDataAdapter("select `AREA`, `NOMBRE DEL PROFESOR`, `INASISTENCIA`, `AULA`, `FECHA`, `HORA DE ENTRADA`, `HORA DE SALIDA`, `TURNO`, `NUMERO DE ALUMNOS`, `TEMA`, `NUMERO DE COMPUTADORAS USADAS`, `SOFTWARE` from `monitoreo` WHERE `FECHA` between '" + dtFrom.ToString("MM/dd/yyyy") + "' and '" + dtTo.ToString("MM/dd/yyyy") + "' ", mcon);

                System.Data.DataSet ds = new System.Data.DataSet();
                mcon.Open();
                mda.Fill(ds, "root");
                datagrid.DataSource = ds.Tables["root"];
                datagrid.Refresh();
                mcon.Close();
            }
            else
            {
                if (comboBox2.SelectedValue.ToString().Equals("Por Favor Seleccione"))
                {
                    string query = "SELECT `AREA`, `NOMBRE DEL PROFESOR`, `INASISTENCIA`, `AULA`, `FECHA`, `HORA DE ENTRADA`, `HORA DE SALIDA`, `TURNO`, `NUMERO DE ALUMNOS`, `TEMA`, `NUMERO DE COMPUTADORAS USADAS`, `SOFTWARE` FROM monitoreo";
                    query += " WHERE AREA = @AREA AND `FECHA` between '" + DATEINICIO.Value.Date.ToString("MM/dd/yyyy") + "' and '" + DATEFIN.Value.Date.ToString("MM/dd/yyyy") + "'";
                    query += " OR IFNULL(@AREA, '') = ''";
                    string constr = @"server=sql10.freemysqlhosting.net;user id=sql10594764;password = isd8CniEEM; database=sql10594764";
                    using (MySqlConnection con = new MySqlConnection(constr))
                    {
                        using (MySqlCommand cmd = new MySqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@AREA", comboarea.SelectedValue);
                            using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                            {
                                DataTable dt = new DataTable();
                                sda.Fill(dt);
                                datagrid.DataSource = dt;
                            }
                        }
                    }
                }
                else
                {
                    string query = "SELECT `AREA`, `NOMBRE DEL PROFESOR`, `INASISTENCIA`, `AULA`, `FECHA`, `HORA DE ENTRADA`, `HORA DE SALIDA`, `TURNO`, `NUMERO DE ALUMNOS`, `TEMA`, `NUMERO DE COMPUTADORAS USADAS`, `SOFTWARE` FROM monitoreo";
                    query += " WHERE `NOMBRE DEL PROFESOR` = @PROFE AND `FECHA` between '" + DATEINICIO.Value.Date.ToString("MM/dd/yyyy") + "' and '" + DATEFIN.Value.Date.ToString("MM/dd/yyyy") + "'";
                    query += " OR IFNULL(@PROFE, '') = ''";
                    string constr = @"server=sql10.freemysqlhosting.net;user id=sql10594764;password = isd8CniEEM; database=sql10594764";
                    using (MySqlConnection con = new MySqlConnection(constr))
                    {
                        using (MySqlCommand cmd = new MySqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@PROFE", comboBox2.SelectedValue);
                            using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                            {
                                DataTable dt = new DataTable();
                                sda.Fill(dt);
                                datagrid.DataSource = dt;
                            }
                        }
                    }
                }
            }
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.Populatedatagridview();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox2.DataSource = null;
            comboBox2.Enabled = false;
            if (comboarea.SelectedValue.ToString() != "0")
            {
                string sql = string.Format("SELECT `IdDocente`, `Docente` FROM `docente` WHERE `AREA` = {0}", comboarea.SelectedValue);
                comboBox2.DataSource = this.GetData1(sql);
                comboBox2.DisplayMember = "Docente";
                comboBox2.ValueMember = "Docente";
                comboBox2.Enabled = true;
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
