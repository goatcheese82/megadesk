using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Smith
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
            materialSelect.DataSource = Enum.GetValues(typeof(Material));
            rushSelect.DataSource = Enum.GetValues(typeof(Rush));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu viewForm1 = (MainMenu)Tag;
            viewForm1.Show();
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void create_quote_Click(object sender, EventArgs e)
        {
            DeskQuote quote = new DeskQuote();
            quote.Order = new Desk();
            quote.Name = custName.Text;
            quote.Time = (Rush) Enum.Parse(typeof(Rush), rushSelect.Text, true);
            quote.Order.Width = Convert.ToInt32(widthSelect.Value);
            quote.Order.Height = Convert.ToInt32(heightSelect.Value);
            quote.Order.Drawers = Convert.ToInt32(drawersSelect.Value);
            quote.Order.Material = (Material)Enum.Parse(typeof(Material), materialSelect.Text, true);

            DisplayQuote viewQuote = new DisplayQuote();
            viewQuote.Show();
        }
    }
}
