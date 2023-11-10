using app1.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        
        ConnectorDB connector = new ConnectorDB();

        private void connectdatabase_Click(object sender, EventArgs e)
        {
            if(!connector.connected)
            {
                if (connector.Connect())
                {
                    label1.Text = "Conectado";
                }
                else
                {
                    MessageBox.Show("No se pudo conectar a la base de datos");
                }   
            }
            else
            {
                MessageBox.Show("Ya está conectado");
            }
            
        }

        private void saveuser_Click(object sender, EventArgs e)
        {
            connector.AddUser(InputUsername.Text, InputPassword.Text, InputEmail.Text);
            List<string> users = connector.GetUsers();
            foreach(string user in users)
            {
                listausuarios.Items.Add(user);
            }
        }
    }
}
