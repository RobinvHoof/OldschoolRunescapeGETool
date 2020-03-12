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
        ProcessingAdministrator ProcessingAdmin = new ProcessingAdministrator();

        List<ProcessAction> processList = new List<ProcessAction>();
        long milliseconds = 0;

        public ProcessingProfits()
        {
            InitializeComponent();
        }

        private void ProcessingProfits_Load(object sender, EventArgs e)
        {
            List<string> containList = ProcessingAdmin.LookForNameMatch(SearchBar.Text);
            ProcessView.DataSource = containList;

        }

        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            List<string> containList = ProcessingAdmin.LookForNameMatch(SearchBar.Text);
            ProcessView.DataSource = containList;
        }

        private void ProcessView_MouseClick(object sender, MouseEventArgs e)
        {
            string processName = ProcessView.SelectedItem.ToString();
            string[] itemNames = processName.Split('>');

            itemNames[0] = itemNames[0].Remove(itemNames[0].Length - 1);
            itemNames[1] = itemNames[1].Remove(0, 1);

            int baseItemId = GEAdmin.GetIdFromName(itemNames[0]);
            int targetItemId = GEAdmin.GetIdFromName(itemNames[1]);

            ProcessAction process = ProcessingAdmin.GetProcess(baseItemId, targetItemId).Result;

            BaseItemNameLabel.Text = process.BaseItem.name;
            ProductItemNameLabel.Text = process.TargetItem.name;

            BaseItemIcon.Image = process.BaseItem.image;
            ProductItemIcon.Image = process.TargetItem.image;

            BaseItemPriceLabel.Text = process.BaseItem.current.price;
            ProductItemPriceLabel.Text = process.TargetItem.current.price;

            ProcessingCostLabel.Text = process.ProcessingCost.ToString();
            ProfitPerItemLabel.Text = process.GetProcessProfit().ToString();
            ProfitPerInvLabel.Text = (process.GetProcessProfit() * 27).ToString();

            int baseItemCost;
            switch (process.BaseItem.current.price[process.BaseItem.current.price.Length - 1])
            {
                case 'k':
                    baseItemCost = Convert.ToInt32(String.Join("", process.BaseItem.current.price.Split(',', '.')).Remove(process.BaseItem.current.price.Length - 1));
                    baseItemCost *= 1000;
                    break;

                case 'm':
                    baseItemCost = Convert.ToInt32(String.Join("", process.BaseItem.current.price.Split(',', '.')).Remove(process.BaseItem.current.price.Length - 1));
                    baseItemCost *= 1000000;
                    break;

                default:
                    baseItemCost = Convert.ToInt32(String.Join("", process.BaseItem.current.price.Split(',', '.')));
                    break;
            }

            InvestmentCostLabel.Text = (baseItemCost + process.ProcessingCost).ToString();

        }

        private void ResetProcessesButton_Click(object sender, EventArgs e)
        {
            ProcessingAdmin.ResetProcesses();
        }
    }
}
