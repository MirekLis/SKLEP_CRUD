using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKLEPCRUD
{
    public partial class gridLaptopy : Form
    {

        SKLEPEntities1 db;
        public gridLaptopy(SKLEPEntities1 sklepEntities)
        {
            db = sklepEntities;
            InitializeComponent();
        }

        private void LaptopyLista_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = db.Laptop.ToList();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Laptop selectedLaptop = (Laptop)((DataGridView) sender).CurrentRow.DataBoundItem;
            LaptopDetails laptopDetail = new LaptopDetails(selectedLaptop, db);
            laptopDetail.Show();
        }
    }
}
