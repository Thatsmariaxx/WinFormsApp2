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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LoginSystem
{
    public partial class Form1 : Form

    {

        public Form1()
        {
            InitializeComponent();
            //pass the database you want to connect to
            db.Connect("userdata");
        }
    }

        private void Form1_Load(object sender, EventArgs e)
        {
        string mysqlCon = "server=127.0.0.1; user=root; database=sampleconnecrtion; password=";
        MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);

    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ilogin_Click(object sender, EventArgs e)
        {
        // query MySQL database for the data passed from text boxes
        db.ExecuteSelect("SELECT * FROM `Register` where username='" + iusername.Text + "' and password ='" + ipassword.Text + "'");
        if (db.Count() == 1)
        {
            MessageBox.Show("Success You will Login as" + db.Results(0, "names"));
        }
        else
        {
            MessageBox.Show("Wrong username and password combination");
        }

    }
}