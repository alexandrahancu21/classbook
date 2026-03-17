using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace csharp
{
    public partial class LoginForm : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public static int id;
        public LoginForm()
        {
            InitializeComponent();
           
        }

        private void textBoxNumeInregistrare_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void buttonInregistrare_Click(object sender, EventArgs e)
        {

            string numeInregistrare = textBoxNumeInregistrare.Text;
            string parolaInregistrare = textBoxParolaInregistrare.Text;
            if (parolaInregistrare.Length <8)
            {
                ShortPassForm f1= new ShortPassForm();
                this.Hide();
                f1.ShowDialog();
                return;
            }
            con.Open();
            cmd = new SqlCommand("SELECT Id FROM Elevi WHERE Nume=@Nume", con);
            cmd.Parameters.AddWithValue("Nume", numeInregistrare);
            id = Convert.ToInt32(cmd.ExecuteScalar());
            if (id != 0)
            {
                AlreadyRegisteredForm f1 = new AlreadyRegisteredForm();
                this.Hide();
                f1.ShowDialog();
                textBoxNumeInregistrare.Clear();
                textBoxParolaInregistrare.Clear();
                con.Close();
                return;
            }
            cmd = new SqlCommand("INSERT INTO Elevi(Nume,Parola) VALUES (@Nume,@Parola)", con);
            cmd.Parameters.AddWithValue("Nume", numeInregistrare);
            cmd.Parameters.AddWithValue("Parola", parolaInregistrare);
            cmd.ExecuteNonQuery();
            SuccessRegisteredForm f = new SuccessRegisteredForm();
            this.Hide();
            f.ShowDialog();
            textBoxNumeInregistrare.Clear();
            textBoxParolaInregistrare.Clear();
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Proiecte\classbook-master\catalog.mdf;Integrated Security=True;Connect Timeout=30");

        }

        private void buttonConectare_Click(object sender, EventArgs e)
        {
            string numeConectare = textBoxNumeConectare.Text;
            string parolaConectare = textBoxParolaConectare.Text;
            con.Open();
            cmd = new SqlCommand("SELECT Id FROM Elevi WHERE Nume=@nume",con);
            cmd.Parameters.AddWithValue("Nume", numeConectare);
            id = Convert.ToInt32(cmd.ExecuteScalar());
            if (id == 0)
            {
                WrongUserForm f = new WrongUserForm();
                this.Hide();
                f.ShowDialog();
                textBoxNumeConectare.Clear();
                textBoxParolaConectare.Clear();
                con.Close();
                return;
            }
            cmd = new SqlCommand("SELECT Parola FROM Elevi WHERE Nume=@Nume", con);
            cmd.Parameters.AddWithValue("Nume", numeConectare);
            string parolaDB = Convert.ToString(cmd.ExecuteScalar());
            if (!parolaDB.Equals(parolaConectare))
            {
                WrongPassForm f = new WrongPassForm();
                this.Hide();
                f.ShowDialog();
                textBoxNumeConectare.Clear();
                textBoxParolaConectare.Clear();
                con.Close();
                return;
            }
            WelcomeForm mesaj = new WelcomeForm();
            this.Hide();
            mesaj.ShowDialog();
           // this.Show();
            con.Close();
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
