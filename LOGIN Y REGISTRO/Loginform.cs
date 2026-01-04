using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOGIN_Y_REGISTRO
{
    public partial class Loginform : Form
    {
        public Loginform()
        {
            InitializeComponent();
        }

        private void Loginform_Load(object sender, EventArgs e)
        {

        }

        private void BTIniciar_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            string Usuario = Txtusuario.Text;
            string Password = Txtcontraseña.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `usuarios` WHERE `Usuario` = @usn AND `Password` =@pass", db.GetConnection());
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = Usuario;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = Password;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count > 0)
            {
                this.Hide();
                Monitorform monitorform = new Monitorform();
                monitorform.Show();
            }
            else
            {
                if (Usuario.Trim().Equals(""))
                {
                    MessageBox.Show("INGRESE SU USUARIO PARA PODER INGRESAR.","USUARIO VACIO",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

                else if (Password.Trim().Equals(""))
                {
                    MessageBox.Show("INGRESE SU CONTRASEÑA PARA PODER INGRESAR.", "CONTRASEÑA VACIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("USUARIO O CONTRASEÑA INCORRECTA.", "DATOS INCORRECTOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }   
        }

        private void Btcancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mainform mainform = new Mainform();
            mainform.Show();
        }

        private void Txtusuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
