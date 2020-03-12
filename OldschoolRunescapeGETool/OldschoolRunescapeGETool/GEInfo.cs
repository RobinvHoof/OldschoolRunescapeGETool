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
    public partial class GEInfo : Form
    {
        GEAdministrator GEAdmin = new GEAdministrator();
        APIGet Api = new APIGet("http://services.runescape.com/m=itemdb_oldschool");

        long milliseconds = 0;

        public GEInfo()
        {
            InitializeComponent();
        }

        private void GEInfo_Load(object sender, EventArgs e)
        {
            List<string> containList = GEAdmin.LookForNameMatch(SearchBar.Text);
            ItemView.DataSource = containList;
        }

        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            List<string> containList = GEAdmin.LookForNameMatch(SearchBar.Text);
            ItemView.DataSource = containList;
        }

        private async void ItemView_MouseClick(object sender, MouseEventArgs e)
        {
            long bufferMilliseconds = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            if (bufferMilliseconds > milliseconds + 500)
            {
                try
                {
                    Console.WriteLine(ItemView.SelectedItem.ToString() + " | " + GEAdmin.GetIdFromName(ItemView.SelectedItem.ToString()));
                    Item item = await Api.GetItemInfo(GEAdmin.GetIdFromName(ItemView.SelectedItem.ToString()));
                    ItemIcon.Image = item.image;
                    ItemNameLabel.Text = item.name;
                    ItemDescriptionLabel.Text = item.description;
                    PriceLabel.Text = item.current.price;

                    CurrentPriceLabel.Text = item.current.price;
                    CurrentTrendLabel.Text = item.current.trend;

                    TodayPriceLabel.Text = item.today.price;
                    TodayTrendLabel.Text = item.today.trend;

                    Day30ChangeLabel.Text = item.day30.change;
                    Day30TrendLabel.Text = item.day30.trend;

                    Day90ChangeLabel.Text = item.day90.change;
                    Day90TrendLabel.Text = item.day90.trend;

                    Day180ChangeLabel.Text = item.day180.change;
                    Day180TrendLabel.Text = item.day180.trend;
                }
                catch
                {
                    MessageBox.Show("Api-rate Exeeded!");
                }
            }
            milliseconds = bufferMilliseconds;
        }

        private void UpdateItemVieuw()
        {

        }
    }
}
