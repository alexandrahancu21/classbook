using System;
using System.Windows.Forms;

namespace csharp
{
    public partial class IntroduceOneGradeForm : Form
    {
        public IntroduceOneGradeForm()
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
