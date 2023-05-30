using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovoy_OOP
{
    public partial class AuthorInfo : Form
    {
        public AuthorInfo()
        {
            InitializeComponent();
        }
        protected override bool ProcessCmdKey(ref Message message, Keys keys) =>
            (DialogResult = DialogResult.OK) == DialogResult.OK;

        private void AuthorInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
