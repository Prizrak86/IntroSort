using IntroSortLib;
using System;
using System.Windows.Forms;

namespace ItroSort
{
    public partial class Start : Form
    {
        ArrayC arrayC;
        public Start()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                arrayC = new ArrayC((int)numericUpDown1.Value);
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpData()
        {
            listBox1.Items.Clear();
            foreach (int[] item in arrayC.ArrayM.History)
            {
                listBox1.Items.Add(string.Join(" ", item));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                arrayC.IntroSorting();
                UpData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                arrayC.BinarySorting();
                UpData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                arrayC.PyramidalSorting();
                UpData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
