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
    public partial class Form1 : Form
    {
        KmConnection con = new KmConnection("http://korhelf59.fiftynine.axc.nl/stenden/kennismanagement/service/");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (con.auth(textBox1.Text, textBox2.Text))
            {
                MessageBox.Show("gelukt");
                KmUser user = new KmUser(con, 1);
                textBox3.Text = user.email;
                textBox4.Text = user.fullName;
            }
            else {
                MessageBox.Show("mislukt");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KmUser user = new KmUser(con, 1);
            user.email = textBox3.Text;
            user.fullName = textBox4.Text;
            user.save();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KmDocumentList documenten = new KmDocumentList(con);
            listBox1.DataSource = documenten.list;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            KmDocument document = new KmDocument(con);
            document.description = textBox5.Text;
            document.title = textBox6.Text;
            document.tags = textBox7.Text;
            document.file = textBox8.Text;
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK) {
                document.loadFile(dialog.FileName);
                document.save();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            KmDocument document = (KmDocument)listBox1.SelectedItem;
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK) {
                document.download(save.FileName);
                
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
