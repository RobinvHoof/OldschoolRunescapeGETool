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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void GEInfoButton_Click(object sender, EventArgs e)
        {
            GEInfo FormGEInfo = new GEInfo();
            FormGEInfo.Show();
        }

        private void ProcessingProfitsButton_Click(object sender, EventArgs e)
        {
            ProcessingProfits FormProcessingProfits = new ProcessingProfits();
            FormProcessingProfits.Show();
        }
    }
}
