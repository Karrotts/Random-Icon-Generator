using System;
using System.Windows.Forms;

namespace RandomIconGenerator
{
    public partial class MainForm : Form
    {
        private IconGenerator iconGenerator = new IconGenerator(250, 250);
        private SaveBitmap saveBitmap = new SaveBitmap();

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Generates next layer or randomizes the next layer(s)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickButton_Click(object sender, EventArgs e)
        {
            if (!c_randomize.Checked)
            {
                pb.Image = iconGenerator.Generate(b_block_size.Value, 
                                                  b_color_variance.Value,
                                                  b_place_chance.Value);
            }
            else
            {
                button.Enabled = false; //Disables generate button to wait for icon to be generated
                Random r = new Random();
                for (int i = 0; i < r.Next(1, 15); i++)
                    pb.Image = iconGenerator.Generate(r.Next(5, 50),
                                                      r.Next(0, 50),
                                                      r.Next(0, 100));
                button.Enabled = true; //Enables generate button after icon has been generated
            }
        }

        /// <summary>
        /// Toggles inputs when randomized checkbox is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            b_block_size.Enabled = !b_block_size.Enabled;
            b_color_variance.Enabled = !b_color_variance.Enabled;
            b_place_chance.Enabled = !b_place_chance.Enabled;
        }

        /// <summary>
        /// Opens SaveAs dialog to save bitmap
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Save_button_Click(object sender, EventArgs e)
        {
            saveBitmap.SaveAs(iconGenerator.Icon);
        }

        /// <summary>
        /// Clears the current bitmap
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Clear_button_Click(object sender, EventArgs e)
        {
            pb.Image = iconGenerator.Clear();
        }
    }
}
