using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssuranceQualiteFibonacci
{
    public partial class FibonacciForm : Form
    {
        public FibonacciForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            //Add column header
            listView1.Columns.Add("n", 50);
            listView1.Columns.Add("f", 70);
            //vide la liste
            listView1.Items.Clear();
  
        }

        private void btnCalculer_Click(object sender, EventArgs e)

        {
            //vide la liste
            listView1.Items.Clear();
            //calculaer la liste
            List<Int32> flist = Fibonacci.getFlist((Int32)numericUpDown1.Value);
            //ajouter la liste dans le listView
            for (int i =0; i<flist.Count; i++)
            {
                ListViewItem item = new ListViewItem( new String[] { i.ToString(), flist[i].ToString()});
                listView1.Items.Add(item);
            }
        }
    }
}
