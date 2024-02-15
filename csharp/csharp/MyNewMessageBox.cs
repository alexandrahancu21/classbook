using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp
{
    public partial class MyNewMessageBox : Form
    {
        public MyNewMessageBox()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Catalog pag = new Catalog();
            this.Hide();
            pag.ShowDialog();
            this.Show();
        }

        private void MyNewMessageBox_Load(object sender, EventArgs e)
        {

        }
    }
}
