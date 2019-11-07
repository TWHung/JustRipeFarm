using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace JustRipe_Farm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button6.Text = "Shop / " + Environment.NewLine + "Wholesale";

            panel1.Hide();
            panel2.Hide();
            panel3.Show();
            panel16.Hide();
            panel17.Hide();
            panel18.Hide();

            panel1.Width = 852;
            panel1.Height = 386;
            panel1.Location = new Point(2, 134);
            panel2.Width = 852;
            panel2.Height = 386;
            panel2.Location = new Point(2, 134);
            panel3.Width = 852;
            panel3.Height = 386;
            panel3.Location = new Point(2, 134);
            panel16.Width = 852;
            panel16.Height = 386;
            panel16.Location = new Point(2, 134);
            panel17.Width = 852;
            panel17.Height = 386;
            panel17.Location = new Point(2, 134);
            panel18.Width = 852;
            panel18.Height = 386;
            panel18.Location = new Point(2, 134);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel3.Show();
            panel1.Hide();
            panel2.Hide();
            panel16.Hide();
            panel17.Hide();
            panel18.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panel1.Show();
            panel2.Hide();
            panel3.Hide();
            panel16.Hide();
            panel17.Hide();
            panel18.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
            panel1.Hide();
            panel2.Show();
            panel3.Hide();
            panel16.Hide();
            panel17.Hide();
            panel18.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            panel16.Show();
            panel17.Hide();
            panel18.Hide();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            panel16.Hide();
            panel17.Show();
            panel18.Hide();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            panel16.Hide();
            panel17.Hide();
            panel18.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DBConnector dbConn = new DBConnector();
            dbConn.connect();

            Labourer labr = new Labourer();
            labr.Name = textBox6.Text;
            labr.Age = int.Parse(textBox7.Text);
            labr.Gender = textBox8.Text;

            LabourerHandler labHnd = new LabourerHandler();
            int recordCnt = labHnd.addNewLabourer(dbConn.getConn(), labr);
            MessageBox.Show(recordCnt + " record has been inserted !!");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {

            DBConnector dbConn = new DBConnector();
            dbConn.connect();

            LabourerHandler labHnd = new LabourerHandler();
            List<Labourer> theList = labHnd.getAllLabourer(dbConn.getConn());

            // for all
            dataGridView1.DataSource = theList;
        }
    }
}
