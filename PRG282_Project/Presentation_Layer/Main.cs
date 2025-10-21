using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Project
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Update update = new Update();
                update.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening update form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Delete delete = new Delete();
                delete.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening delete form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                addHero addHero = new addHero();
                addHero.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening add hero form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Summary summary = new Summary();
                summary.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening summary form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Superheros superheros = new Superheros();
                superheros.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening superheros form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
