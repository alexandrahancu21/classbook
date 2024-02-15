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
    public partial class MyNewMessageBox1 : Form
    {
        public MyNewMessageBox1()
        {
            InitializeComponent();
        }

        private void buttonok1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
