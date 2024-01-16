using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_based_project
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void addBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void completeBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Complete_Books_Details cbd = new Complete_Books_Details();
            cbd.Show();
        }

        private void issueBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Issue_Books ib = new Issue_Books();
            ib.Show();
        }

        private void returnBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Return_Books rb = new Return_Books();
            rb.Show();
        }

        private void addBooksToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Add_Books ast = new Add_Books();
            ast.Show();
        }

        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View_Books vb = new View_Books();
            vb.Show();
        }

        private void addStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_students ast = new Add_students();
            ast.Show();
        }

        private void viewStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View_students vs = new View_students();
            vs.Show();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void returnBooksDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Return_Books_Details rbr = new Return_Books_Details();
            rbr.Show();
        }
    }
}
