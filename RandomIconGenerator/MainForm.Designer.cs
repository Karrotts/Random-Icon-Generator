namespace RandomIconGenerator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button = new System.Windows.Forms.Button();
            this.pb = new System.Windows.Forms.PictureBox();
            this.b_block_size = new System.Windows.Forms.NumericUpDown();
            this.b_color_variance = new System.Windows.Forms.NumericUpDown();
            this.b_place_chance = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.c_randomize = new System.Windows.Forms.CheckBox();
            this.save_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_block_size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_color_variance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_place_chance)).BeginInit();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button.Location = new System.Drawing.Point(69, 295);
            this.button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(251, 62);
            this.button.TabIndex = 0;
            this.button.Text = "Generate!";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.clickButton_Click);
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(69, 30);
            this.pb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(251, 250);
            this.pb.TabIndex = 1;
            this.pb.TabStop = false;
            // 
            // b_block_size
            // 
            this.b_block_size.Location = new System.Drawing.Point(359, 50);
            this.b_block_size.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b_block_size.Name = "b_block_size";
            this.b_block_size.Size = new System.Drawing.Size(77, 22);
            this.b_block_size.TabIndex = 2;
            this.b_block_size.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // b_color_variance
            // 
            this.b_color_variance.Location = new System.Drawing.Point(359, 176);
            this.b_color_variance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b_color_variance.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.b_color_variance.Name = "b_color_variance";
            this.b_color_variance.Size = new System.Drawing.Size(77, 22);
            this.b_color_variance.TabIndex = 3;
            this.b_color_variance.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // b_place_chance
            // 
            this.b_place_chance.Location = new System.Drawing.Point(359, 110);
            this.b_place_chance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b_place_chance.Name = "b_place_chance";
            this.b_place_chance.Size = new System.Drawing.Size(77, 22);
            this.b_place_chance.TabIndex = 4;
            this.b_place_chance.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Place Chance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Color Variance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Block Size";
            // 
            // c_randomize
            // 
            this.c_randomize.AutoSize = true;
            this.c_randomize.Location = new System.Drawing.Point(359, 224);
            this.c_randomize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c_randomize.Name = "c_randomize";
            this.c_randomize.Size = new System.Drawing.Size(101, 21);
            this.c_randomize.TabIndex = 8;
            this.c_randomize.Text = "Randomize";
            this.c_randomize.UseVisualStyleBackColor = true;
            this.c_randomize.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(359, 295);
            this.save_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(100, 28);
            this.save_button.TabIndex = 9;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(359, 329);
            this.clear_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(100, 28);
            this.clear_button.TabIndex = 10;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(483, 379);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.c_randomize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_place_chance);
            this.Controls.Add(this.b_color_variance);
            this.Controls.Add(this.b_block_size);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.button);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Random Icon Generator";
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_block_size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_color_variance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_place_chance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.NumericUpDown b_block_size;
        private System.Windows.Forms.NumericUpDown b_color_variance;
        private System.Windows.Forms.NumericUpDown b_place_chance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox c_randomize;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button clear_button;
    }
}

