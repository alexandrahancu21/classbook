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
    public partial class MyNewMessageBox3 : Form
    {
        public MyNewMessageBox3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Catalog f = new Catalog();
            f.ShowDialog();

        }
    }
}
