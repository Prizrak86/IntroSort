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
                Intro.Enabled = true;
                Binary.Enabled = true;
                Pyramidal.Enabled = true;
                UpData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpData()
        {
            table.Rows.Clear();
            foreach (ArrayM.History history in arrayC.ArrayM.history)
            {
                table.Rows.Add(history.commet, string.Join(" ", history.array));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                arrayC.IntroSorting();
                UpData();
                Intro.Enabled = false;
                Binary.Enabled = false;
                Pyramidal.Enabled = false;
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
                Intro.Enabled = false;
                Binary.Enabled = false;
                Pyramidal.Enabled = false;
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
                Intro.Enabled = false;
                Binary.Enabled = false;
                Pyramidal.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
