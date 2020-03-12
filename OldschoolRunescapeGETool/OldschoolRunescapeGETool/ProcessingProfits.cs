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
    public partial class ProcessingProfits : Form
    {
        APIGet Api = new APIGet("http://services.runescape.com/m=itemdb_oldschool");
        GEAdministrator GEAdmin = new GEAdministrator();

        List<ProcessAction> processList = new List<ProcessAction>();

        public ProcessingProfits()
        {
            InitializeComponent();
        }

        private void ProcessingProfits_Load(object sender, EventArgs e)
        {

        }

        private void AddProcess(Item baseItem, Item targetItem, int processingCost)
        {
            processList.Add(new ProcessAction(baseItem, targetItem, processingCost));
        }
    }
}
