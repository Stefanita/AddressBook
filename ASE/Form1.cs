using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.People' table. You can move, or remove it, as needed.
            this.peopleTableAdapter.Fill(this.database1DataSet.People);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AddressBook v1.0\nAuthor:<Toro>", "About");
        }

        private void peopleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.peopleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }
    }
}
