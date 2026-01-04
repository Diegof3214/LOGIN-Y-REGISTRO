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
    public partial class AJUSTEFORM : Form
    {
        MySqlConnection con = new MySqlConnection("server=sql10.freemysqlhosting.net;user id=sql10594764;password = isd8CniEEM; database=sql10594764");
        MySqlCommand cmd;
        DataTable dt = new DataTable();

        private DataTable GetData(string sql)
        {
            string constr = @"server=sql10.freemysqlhosting.net;user id=sql10594764;password = isd8CniEEM; database=sql10594764";
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                using (MySqlDataAdapter sda = new MySqlDataAdapter(sql, con))
                {
                    DataTable dt1 = new DataTable();
                    sda.Fill(dt1);
                    DataRow row = dt1.NewRow();
                    row[0] = 0;
                    row[1] = "Por Favor Seleccione";
                    dt1.Rows.InsertAt(row, 0);
                    return dt1;

                }
            }

        }
        public AJUSTEFORM()
        {
            InitializeComponent();

            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "AREA";
            dataGridView1.Columns[2].Name = "NOMBRE";
            this.dataGridView1.Columns["ID"].Visible = false;
            this.dataGridView1.Columns["NOMBRE"].Visible = false;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            

            dataGridView2.ColumnCount = 2;
            dataGridView2.Columns[0].Name = "ID";
            dataGridView2.Columns[1].Name = "TURNO";
            this.dataGridView2.Columns["ID"].Visible = false;

            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.MultiSelect = false;

            dataGridView3.ColumnCount = 3;
            dataGridView3.Columns[0].Name = "ID";
            dataGridView3.Columns[1].Name = "PROFESOR";
            dataGridView3.Columns[2].Name = "AREA";
            this.dataGridView3.Columns["ID"].Visible = false;

            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.MultiSelect = false;

            dataGridView4.ColumnCount = 5;
            dataGridView4.Columns[0].Name = "ID";
            dataGridView4.Columns[1].Name = "NOMBRE";
            dataGridView4.Columns[2].Name = "APELLIDO";
            dataGridView4.Columns[3].Name = "CORREO";
            dataGridView4.Columns[4].Name = "USUARIO";
            this.dataGridView4.Columns["ID"].Visible = false;

            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView4.MultiSelect = false;

            dataGridView5.ColumnCount = 5;
            dataGridView5.Columns[0].Name = "ID";
            dataGridView5.Columns[1].Name = "NOMBRE";
            dataGridView5.Columns[2].Name = "APELLIDO";
            dataGridView5.Columns[3].Name = "CORREO";
            dataGridView5.Columns[4].Name = "USUARIO";
            this.dataGridView5.Columns["ID"].Visible = false;

            dataGridView5.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView5.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView5.MultiSelect = false;

            dataGridView6.ColumnCount = 2;
            dataGridView6.Columns[0].Name = "ID";
            dataGridView6.Columns[1].Name = "SOFTWARE";
            this.dataGridView6.Columns["ID"].Visible = false;

            dataGridView6.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView6.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView6.MultiSelect = false;
        }


        private void add(string num, string area)
        {
            string sql = "INSERT INTO `area`(`IDAREA`, `AREA`, `NOMBRE`) VALUES (@ID,'" + num + "' '. ' '" + area + "',@NOMBRE)";
            cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@ID", num);
            cmd.Parameters.AddWithValue("@NOMBRE", area);

            try
            {
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("INSERTADO EXITOSAMENTE.");

                }
                con.Close();
                retrieve();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
        private void add1(string turno)
        {
            string sql = "INSERT INTO `turno`(`Turno`) VALUES (@TURNO)";
            cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@TURNO", turno);

            try
            {
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("INSERTADO EXITOSAMENTE.");
                }
                con.Close();
                retrieve1();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void add2(string profe, string area)
        {
            string sql = "INSERT INTO `docente`(`Docente`, `AREA`) VALUES (@PROFE, @AREA)";
            cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@PROFE", profe);
            cmd.Parameters.AddWithValue("@AREA", area);

            try
            {
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("INSERTADO EXITOSAMENTE.");

                }
                con.Close();
                retrieve2();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
        private void add3(string soft)
        {
            string sql = "INSERT INTO `software`(`SOFTWARE`) VALUES (@SOFTWARE)";
            cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@SOFTWARE", soft);

            try
            {
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("INSERTADO EXITOSAMENTE.");
                }
                con.Close();
                retrieve5();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void populate(string id, string area, string num)
         {
         dataGridView1.Rows.Add(id, area, num);
         }
        private void populate1(string id, string turno)
        {
         dataGridView2.Rows.Add(id, turno);
        }
        private void populate2(string id, string profe, string area)
        {
            dataGridView3.Rows.Add(id, profe, area);
        }
        private void populate3(string id, string nombre, string apellido, string correo, string user)
        {
            dataGridView4.Rows.Add(id, nombre, apellido,correo,user);
        }
        private void populate4(string id, string nombre, string apellido, string correo, string user)
        {
            dataGridView5.Rows.Add(id, nombre, apellido, correo, user);
        }
        private void populate5(string id, string soft)
        {
            dataGridView6.Rows.Add(id, soft);
        }
        private void retrieve()
        {
            MySqlConnection con = new MySqlConnection("server=sql10.freemysqlhosting.net;user id=sql10594764;password = isd8CniEEM; database=sql10594764");
            MySqlCommand cmd;
            MySqlDataAdapter adapter;
            DataTable dt = new DataTable();

            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            dataGridView3.Rows.Clear();
            dataGridView4.Rows.Clear();
            dataGridView5.Rows.Clear();
            dataGridView6.Rows.Clear();


            string sql = "SELECT `IDAREA`, `AREA`, `NOMBRE` FROM `area`";
            cmd = new MySqlCommand(sql, con);
            try
            {
                con.Open();

                adapter = new MySqlDataAdapter(cmd);

                adapter.Fill(dt);

                //LOOP THRU DT
                foreach (DataRow row in dt.Rows)
                {
                    populate(row[0].ToString(), row[1].ToString(), row[2].ToString());
                }

                con.Close();

                //CLEAR DT
                dt.Rows.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }

        }
        private void retrieve1()
        {
            MySqlConnection con = new MySqlConnection("server=sql10.freemysqlhosting.net;user id=sql10594764;password = isd8CniEEM; database=sql10594764");
            MySqlCommand cmd;
            MySqlDataAdapter adapter;
            DataTable dt = new DataTable();

            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            dataGridView3.Rows.Clear();
            dataGridView4.Rows.Clear();
            dataGridView5.Rows.Clear();
            dataGridView6.Rows.Clear();


            string sql = "SELECT `Id`, `Turno` FROM `turno`";
            cmd = new MySqlCommand(sql, con);
            try
            {
                con.Open();

                adapter = new MySqlDataAdapter(cmd);

                adapter.Fill(dt);

                //LOOP THRU DT
                foreach (DataRow row in dt.Rows)
                {
                    populate1(row[0].ToString(), row[1].ToString());
                }

                con.Close();

                //CLEAR DT
                dt.Rows.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }

        }
        private void retrieve2()
        {
            MySqlConnection con = new MySqlConnection("server=sql10.freemysqlhosting.net;user id=sql10594764;password = isd8CniEEM; database=sql10594764");
            MySqlCommand cmd;
            MySqlDataAdapter adapter;
            DataTable dt = new DataTable();

            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            dataGridView3.Rows.Clear();
            dataGridView4.Rows.Clear();
            dataGridView5.Rows.Clear();
            dataGridView6.Rows.Clear();


            if (comboBox1.SelectedValue.ToString().Equals("0"))
            {
                string sql = "SELECT `IdDocente`, `Docente`, `AREA` FROM `docente`";
                cmd = new MySqlCommand(sql, con);
                try
                {
                    con.Open();

                    adapter = new MySqlDataAdapter(cmd);

                    adapter.Fill(dt);

                    //LOOP THRU DT
                    foreach (DataRow row in dt.Rows)
                    {
                        populate2(row[0].ToString(), row[1].ToString(), row[2].ToString());
                    }

                    con.Close();

                    //CLEAR DT
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
                string sql = "SELECT `IdDocente`, `Docente`, `AREA` FROM `docente` WHERE `AREA` = @AREA ";
                sql += "OR IFNULL(@AREA, '') = ''";
                cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@AREA", comboBox1.SelectedValue);

                try
                {
                    con.Open();

                    adapter = new MySqlDataAdapter(cmd);

                    adapter.Fill(dt);

                    //LOOP THRU DT
                    foreach (DataRow row in dt.Rows)
                    {
                        populate2(row[0].ToString(), row[1].ToString(), row[2].ToString());
                    }

                    con.Close();

                    //CLEAR DT
                    dt.Rows.Clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }

            }
        
        }

        private void retrieve3()
        {
            MySqlConnection con = new MySqlConnection("server=sql10.freemysqlhosting.net;user id=sql10594764;password = isd8CniEEM; database=sql10594764");
            MySqlCommand cmd;
            MySqlDataAdapter adapter;
            DataTable dt = new DataTable();

            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            dataGridView3.Rows.Clear();
            dataGridView4.Rows.Clear();
            dataGridView5.Rows.Clear();
            dataGridView6.Rows.Clear();


            string sql = "SELECT `Id`,`Nombres`, `Apellidos`, `Correo`, `Usuario` FROM `usuarios`";
            cmd = new MySqlCommand(sql, con);
            try
            {
                con.Open();

                adapter = new MySqlDataAdapter(cmd);

                adapter.Fill(dt);

                //LOOP THRU DT
                foreach (DataRow row in dt.Rows)
                {
                    populate3(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString());
                }

                con.Close();

                //CLEAR DT
                dt.Rows.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }

        }

        private void retrieve4()
        {
            MySqlConnection con = new MySqlConnection("server=sql10.freemysqlhosting.net;user id=sql10594764;password = isd8CniEEM; database=sql10594764");
            MySqlCommand cmd;
            MySqlDataAdapter adapter;
            DataTable dt = new DataTable();

            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            dataGridView3.Rows.Clear();
            dataGridView4.Rows.Clear();
            dataGridView5.Rows.Clear();
            dataGridView6.Rows.Clear();


            string sql = "SELECT `Id`,`Nombres`, `Apellidos`, `Correo`, `Usuario` FROM `usuarios`";
            cmd = new MySqlCommand(sql, con);
            try
            {
                con.Open();

                adapter = new MySqlDataAdapter(cmd);

                adapter.Fill(dt);

                //LOOP THRU DT
                foreach (DataRow row in dt.Rows)
                {
                    populate4(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString());
                }

                con.Close();

                //CLEAR DT
                dt.Rows.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }

        }
        private void retrieve5()
        {
            MySqlConnection con = new MySqlConnection("server=sql10.freemysqlhosting.net;user id=sql10594764;password = isd8CniEEM; database=sql10594764");
            MySqlCommand cmd;
            MySqlDataAdapter adapter;
            DataTable dt = new DataTable();

            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            dataGridView3.Rows.Clear();
            dataGridView4.Rows.Clear();
            dataGridView5.Rows.Clear();
            dataGridView6.Rows.Clear();



            string sql = "SELECT `Idsoft`, `SOFTWARE` FROM `software`";
            cmd = new MySqlCommand(sql, con);
            try
            {
                con.Open();

                adapter = new MySqlDataAdapter(cmd);

                adapter.Fill(dt);

                //LOOP THRU DT
                foreach (DataRow row in dt.Rows)
                {
                    populate5(row[0].ToString(), row[1].ToString());
                }

                con.Close();

                //CLEAR DT
                dt.Rows.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }

        }
        private void update(int id, string nombre,string num, string area)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            string sql = "UPDATE `area` SET `IDAREA`='"+ num + "',`NOMBRE`='" + nombre + "',`AREA`= '" + num + "' '. ' '" + nombre +"' WHERE `IDAREA`=" + id + " AND `AREA`='" + area + "'";
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
                retrieve();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
        private void update1(int id, string turno)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            string sql = "UPDATE `turno` SET `Turno`='" + turno + "' WHERE `Id`=" + id + "";
            cmd = new MySqlCommand(sql, con);
            try
            {
                con.Open();
                adapter.UpdateCommand = con.CreateCommand();
                adapter.UpdateCommand.CommandText = sql;


                if (adapter.UpdateCommand.ExecuteNonQuery() > 0)
                {
                    cleartxts1();
                    MessageBox.Show("ACTUALIZADO EXITOSAMENTE.");
                }
                con.Close();
                retrieve1();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
        private void update2(int id, string profe, string area)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            string sql = "UPDATE `docente` SET `Docente`='" + profe + "',`AREA` ='"+ area + "' WHERE `IdDocente`=" + id + "";
            cmd = new MySqlCommand(sql, con);
            try
            {
                con.Open();
                adapter.UpdateCommand = con.CreateCommand();
                adapter.UpdateCommand.CommandText = sql;


                if (adapter.UpdateCommand.ExecuteNonQuery() > 0)
                {
                    cleartxts2();
                    MessageBox.Show("ACTUALIZADO EXITOSAMENTE.");
                }
                con.Close();
                retrieve2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
        private void update3(int id, string nombre, string apellido, string correo, string user)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            string sql = "UPDATE `usuarios` SET `Nombres`='" + nombre + "',`Apellidos` ='" + apellido + "',`Correo` ='" + correo + "',`Usuario` ='" + user + "' WHERE `Id`=" + id + "";
            cmd = new MySqlCommand(sql, con);
            try
            {
                con.Open();
                adapter.UpdateCommand = con.CreateCommand();
                adapter.UpdateCommand.CommandText = sql;


                if (adapter.UpdateCommand.ExecuteNonQuery() > 0)
                {
                    cleartxts3();
                    MessageBox.Show("ACTUALIZADO EXITOSAMENTE.");
                }
                con.Close();
                retrieve3();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void update4(int id, string contra)
        {
            

            if (textBox8.Text.Equals(textBox9.Text))
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                string sql = "UPDATE `usuarios` SET `Password`='" + contra + "' WHERE `Id`=" + id + "";
                cmd = new MySqlCommand(sql, con);
                try
                {
                    con.Open();
                    adapter.UpdateCommand = con.CreateCommand();
                    adapter.UpdateCommand.CommandText = sql;


                    if (adapter.UpdateCommand.ExecuteNonQuery() > 0)
                    {
                        cleartxts4();
                        MessageBox.Show("ACTUALIZADO EXITOSAMENTE.");
                    }
                    con.Close();
                    retrieve4();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("LAS CONTRASEÑAS NO COINCIDEN.", "ERROR DE CONTRASEÑA", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        private void update5(int id, string software)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            string sql = "UPDATE `software` SET `SOFTWARE`='" + software + "' WHERE `Idsoft`=" + id + "";
            cmd = new MySqlCommand(sql, con);
            try
            {
                con.Open();
                adapter.UpdateCommand = con.CreateCommand();
                adapter.UpdateCommand.CommandText = sql;


                if (adapter.UpdateCommand.ExecuteNonQuery() > 0)
                {
                    cleartxts5();
                    MessageBox.Show("ACTUALIZADO EXITOSAMENTE.");
                }
                con.Close();
                retrieve5();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
        private void delete(int id)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            string sql = "DELETE FROM `area` WHERE `IDAREA`=" + id + "";
            cmd = new MySqlCommand(sql, con);

            try
            {
                con.Open();
                adapter = new MySqlDataAdapter(cmd);
                adapter.DeleteCommand = con.CreateCommand();
                adapter.DeleteCommand.CommandText = sql;

                if (MessageBox.Show("Seguro?", "BORRAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        cleartxts();
                        MessageBox.Show("BORRADO EXITOSAMENTE.");
                    }
                }
                con.Close();
                retrieve();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
        private void delete1(int id)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            string sql = "DELETE FROM `turno` WHERE `Id`=" + id + "";
            cmd = new MySqlCommand(sql, con);

            try
            {
                con.Open();
                adapter = new MySqlDataAdapter(cmd);
                adapter.DeleteCommand = con.CreateCommand();
                adapter.DeleteCommand.CommandText = sql;

                if (MessageBox.Show("Seguro?", "BORRAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        cleartxts1();
                        MessageBox.Show("BORRADO EXITOSAMENTE.");
                    }
                }
                con.Close();
                retrieve1();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void delete2(int id)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            string sql = "DELETE FROM `docente` WHERE `IdDocente`=" + id + "";
            cmd = new MySqlCommand(sql, con);

            try
            {
                con.Open();
                adapter = new MySqlDataAdapter(cmd);
                adapter.DeleteCommand = con.CreateCommand();
                adapter.DeleteCommand.CommandText = sql;

                if (MessageBox.Show("Seguro?", "BORRAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        cleartxts2();
                        MessageBox.Show("BORRADO EXITOSAMENTE.");
                    }
                }
                con.Close();
                retrieve2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
        private void delete3(int id)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            string sql = "DELETE FROM `usuarios` WHERE `Id`=" + id + "";
            cmd = new MySqlCommand(sql, con);

            try
            {
                con.Open();
                adapter = new MySqlDataAdapter(cmd);
                adapter.DeleteCommand = con.CreateCommand();
                adapter.DeleteCommand.CommandText = sql;

                if (MessageBox.Show("Seguro?", "BORRAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        cleartxts3();
                        MessageBox.Show("BORRADO EXITOSAMENTE.");
                    }
                }
                con.Close();
                retrieve3();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
        private void delete4(int id)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            string sql = "DELETE FROM `software` WHERE `Idsoft`=" + id + "";
            cmd = new MySqlCommand(sql, con);

            try
            {
                con.Open();
                adapter = new MySqlDataAdapter(cmd);
                adapter.DeleteCommand = con.CreateCommand();
                adapter.DeleteCommand.CommandText = sql;

                if (MessageBox.Show("Seguro?", "BORRAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        cleartxts5();
                        MessageBox.Show("BORRADO EXITOSAMENTE.");
                    }
                }
                con.Close();
                retrieve5();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void cleartxts()
        {
            textBox1.Text = "";
        }
        private void cleartxts1()
        {
            textBox2.Text = "";
        }
        private void cleartxts2()
        {
            textBox3.Text = "";
        }
        private void cleartxts3()
        {
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }
        private void cleartxts4()
        {
            textBox8.Text = "";
            textBox9.Text = "";
        }
        private void cleartxts5()
        {
            textBox10.Text = "";
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void PopulateComboBox()
        {
            comboBox1.DataSource = this.GetData("SELECT `IDAREA`, `AREA` FROM `area`");
            comboBox1.DisplayMember = "AREA";
            comboBox1.ValueMember = "IDAREA";
        }
        

            private void AJUSTEFORM_Load(object sender, EventArgs e)
        {
            this.PopulateComboBox();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

       private void button1_Click(object sender, EventArgs e)
        {
            add(textBox11.Text, textBox1.Text);
            this.PopulateComboBox();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String selected = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            int id = Convert.ToInt32(selected);

            string selec = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

            update(id, textBox1.Text,textBox11.Text,selec);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            retrieve();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            cleartxts();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            String selected = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            int id = Convert.ToInt32(selected);

            delete(id);

            this.PopulateComboBox();
    
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            add1(textBox2.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            retrieve1();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            String selected = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            int id = Convert.ToInt32(selected);

            update1(id, textBox2.Text);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            String selected = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            int id = Convert.ToInt32(selected);

            delete1(id);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            cleartxts1();

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox11.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            textBox1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void dataGridView2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void dataGridView3_MouseClick(object sender, MouseEventArgs e)
        {
            textBox3.Text = dataGridView3.SelectedRows[0].Cells[1].Value.ToString();
            comboBox1.SelectedValue = dataGridView3.SelectedRows[0].Cells[2].Value.ToString();

        }

        private void button10_Click(object sender, EventArgs e)
        {
         retrieve2();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            String selected = dataGridView3.SelectedRows[0].Cells[0].Value.ToString();
            int id = Convert.ToInt32(selected);

            update2(id, textBox3.Text,this.comboBox1.SelectedValue.ToString());
        }

        private void button12_Click(object sender, EventArgs e)
        {
            add2(textBox3.Text,this.comboBox1.SelectedValue.ToString());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView3.Rows.Clear();
            cleartxts2();

        }

        private void button15_Click(object sender, EventArgs e)
        {
            String selected = dataGridView3.SelectedRows[0].Cells[0].Value.ToString();
            int id = Convert.ToInt32(selected);

            delete2(id);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            retrieve3();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            String selected = dataGridView4.SelectedRows[0].Cells[0].Value.ToString();
            int id = Convert.ToInt32(selected);

            update3(id, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            String selected = dataGridView4.SelectedRows[0].Cells[0].Value.ToString();
            int id = Convert.ToInt32(selected);

            delete3(id);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            dataGridView4.Rows.Clear();
            cleartxts3();

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            retrieve4();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            dataGridView5.Rows.Clear();
            cleartxts4();

        }

        private void button23_Click(object sender, EventArgs e)
        {
            String selected = dataGridView5.SelectedRows[0].Cells[0].Value.ToString();
            int id = Convert.ToInt32(selected);

            update4(id, textBox8.Text);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            this.Hide();
            Recursosform recursosform = new Recursosform();
            recursosform.Show();
        }

        private void BTMONITOREO_Click(object sender, EventArgs e)
        {
            this.Hide();
            Monitorform monitorform = new Monitorform();
            monitorform.Show();
        }

        private void BTPRESENTACION_Click(object sender, EventArgs e)
        {
            this.Hide();
            Asignacionform asignacionform = new Asignacionform();
            asignacionform.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox10.Text = dataGridView6.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            retrieve5();

        }

        private void button26_Click(object sender, EventArgs e)
        {
            String selected = dataGridView6.SelectedRows[0].Cells[0].Value.ToString();
            int id = Convert.ToInt32(selected);

            update5(id, textBox10.Text);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            add3(textBox10.Text);

        }

        private void button20_Click(object sender, EventArgs e)
        {
            String selected = dataGridView6.SelectedRows[0].Cells[0].Value.ToString();
            int id = Convert.ToInt32(selected);

            delete4(id);
        }

        private void button24_Click_1(object sender, EventArgs e)
        {
            dataGridView6.Rows.Clear();
            cleartxts5();
        }

        private void dataGridView6_MouseClick(object sender, MouseEventArgs e)
        {
            textBox10.Text = dataGridView6.SelectedRows[0].Cells[1].Value.ToString();

        }

        private void dataGridView4_MouseClick(object sender, MouseEventArgs e)
        {
            textBox4.Text = dataGridView4.SelectedRows[0].Cells[1].Value.ToString();
            textBox5.Text = dataGridView4.SelectedRows[0].Cells[2].Value.ToString();
            textBox6.Text = dataGridView4.SelectedRows[0].Cells[3].Value.ToString();
            textBox7.Text = dataGridView4.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void textBox11_Enter(object sender, EventArgs e)
        {
            string fname = textBox11.Text;
            if (fname.ToUpper().Trim().Equals("NUMERO"))
            {
                textBox11.Text = "";
                textBox11.ForeColor = Color.Black;
            }
        }

        private void textBox11_Leave(object sender, EventArgs e)
        {
            string fname = textBox11.Text;

            if (fname.ToUpper().Trim().Equals("NUMERO") || fname.Trim().Equals(""))
            {
                textBox11.Text = "NUMERO";
                textBox11.ForeColor = Color.Gray;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            string fname = textBox1.Text;
            if (fname.ToUpper().Trim().Equals("NOMBRE"))
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            string fname = textBox1.Text;

            if (fname.ToUpper().Trim().Equals("NOMBRE") || fname.Trim().Equals(""))
            {
                textBox1.Text = "NOMBRE";
                textBox1.ForeColor = Color.Gray;
            }
        }
    }
}
