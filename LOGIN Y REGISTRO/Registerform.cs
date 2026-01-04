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
    public partial class Registerform : Form
    {
        public Registerform()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Confirmacion_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void BTCrear_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `usuarios`(`Nombres`, `Apellidos`, `Correo`, `Usuario`, `Password`) VALUES (@fn,@ln,@email,@usn,@pass)", db.GetConnection());

            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = txtNombres.Text;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = txtApellidos.Text;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = txtcorreo.Text;
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = Txtusuario.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = Txtcontraseña.Text;

            db.OpenConnnection();

            if (!checkTextBoxesValues())
            {
                if (Txtcontraseña.Text.Equals(txtconfirmacion.Text))
                {
                    if (checkusername())
                    {
                        MessageBox.Show("ESTE USUARIO YA EXISTE, ELIJA OTRO.", "USUARIO DUPLICADO", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }

                    else
                    {
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("TU CUENTA HA SIDO CREADA.", "CUENTA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Hide();
                            Loginform Loginform = new Loginform();
                            Loginform.Show();
                        }
                        else
                        {
                            MessageBox.Show("ERROR");
                        }
                    }
                }

                else
                {
                    MessageBox.Show("LAS CONTRASEÑAS NO COINCIDEN.", "ERROR DE CONTRASEÑA", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("INGRESE SU INFORMACION.");
            }
       
            db.CloseConnnection();

        }

        public Boolean checkusername()
        {
            DB db = new DB();

            string Usuario = Txtusuario.Text;
            
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `usuarios` WHERE `Usuario` = @usn", db.GetConnection());
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = Usuario;

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
            string fname = txtNombres.Text;
            string lname = txtApellidos.Text;
            string email = txtcorreo.Text;
            string uname = Txtusuario.Text;
            string pass = Txtcontraseña.Text;

            if (fname.Equals("") || lname.Equals("") ||email.Equals("")||uname.Equals("")||pass.Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Registerform_Load(object sender, EventArgs e)
        {

        }

        private void Txtcontraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtconfirmacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btcancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mainform mainform = new Mainform();
            mainform.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
