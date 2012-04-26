using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using km.client;

namespace km
{
    public partial class Mainmenu : Form
    {
        KmConnection con = new KmConnection("http://korhelf59.fiftynine.axc.nl/stenden/kennismanagement/service/");
        public Mainmenu()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            KmDocumentList documenten = new KmDocumentList(con);
            listBox1.DataSource = documenten.list;
        }
    }
}
