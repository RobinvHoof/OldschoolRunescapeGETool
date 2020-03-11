using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OldschoolRunescapeGETool
{
    public partial class Form1 : Form
    {
        APIGet api = new APIGet("http://services.runescape.com/m=itemdb_oldschool");
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await api.getItemInfo(4151);
        }

    }
}
