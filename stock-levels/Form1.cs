using System.Net;
using System.Text;
using static stock_levels.Grabber;

namespace stock_levels
{
    public partial class Form1 : Form
    {
        List<Stocks> stocks;
        private const string BaseUrl = "http://127.0.0.1:8000"; // Adres Twojego API

        string serial_nr;
        string quantity;
        string row;
        int column;
        string search_serial_nr;
        string search_row;
        int search_column;


        

        public Form1()
        {
            InitializeComponent();
            stocks = new List<Stocks>();
            stocks  = Stocks.GetDataFromURL(BaseUrl+ "/stocks");
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = stocks;
            serial_nr = textBox_serial_nr.Text;
            quantity = textBox_quantity.Text;
            row = textBox_row.Text;
            //column = int.Parse(textBox_column.Text);            
            
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            if (!stocks.Any()) { return; }
            search_serial_nr = textBox_serial_nr_search.Text;
            search_row = textBox_row_search.Text;
            search_column = int.Parse(textBox_column_search.Text);

            List<Stocks> filteredList = new List<Stocks>();

            if (!string.IsNullOrEmpty(search_serial_nr))
            {
                filteredList = stocks.Where(s => s.serial_number == search_serial_nr).ToList();
            }

            if (!string.IsNullOrEmpty(search_row))
            {
                filteredList = stocks.Where(s => s.row.Contains(search_row)).ToList();
            }

            if (search_column != null)
            {
                filteredList = stocks.Where(s => s.column == search_column).ToList();
            }

            List<Stocks> results = filteredList.ToList();
            dataGridView1 = null;
            dataGridView1.DataSource = results;
        }
    }
}