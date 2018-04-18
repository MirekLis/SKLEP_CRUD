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
    public partial class FormStart : Form
    {

        SKLEPEntities1 sklepEntities = new SKLEPEntities1();
        public FormStart()
        {
            InitializeComponent();
        }

        private void open_laptopy_Click(object sender, EventArgs e)
        {
            gridLaptopy laptopyLista = new gridLaptopy(sklepEntities);
            laptopyLista.Show();
        }
    }
}
