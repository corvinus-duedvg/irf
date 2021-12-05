
namespace Mikroszim
{
    partial class Form1
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
            this.but_sim = new System.Windows.Forms.Button();
            this.lbl_endyear = new System.Windows.Forms.Label();
            this.nup_endyear = new System.Windows.Forms.NumericUpDown();
            this.lbl_path = new System.Windows.Forms.Label();
            this.tbox_path = new System.Windows.Forms.TextBox();
            this.but_path = new System.Windows.Forms.Button();
            this.rtb_sim = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nup_endyear)).BeginInit();
            this.SuspendLayout();
            // 
            // but_sim
            // 
            this.but_sim.Location = new System.Drawing.Point(697, 13);
            this.but_sim.Name = "but_sim";
            this.but_sim.Size = new System.Drawing.Size(75, 23);
            this.but_sim.TabIndex = 0;
            this.but_sim.Text = "Start";
            this.but_sim.UseVisualStyleBackColor = true;
            this.but_sim.Click += new System.EventHandler(this.but_sim_Click);
            // 
            // lbl_endyear
            // 
            this.lbl_endyear.AutoSize = true;
            this.lbl_endyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_endyear.Location = new System.Drawing.Point(14, 18);
            this.lbl_endyear.Name = "lbl_endyear";
            this.lbl_endyear.Size = new System.Drawing.Size(51, 13);
            this.lbl_endyear.TabIndex = 1;
            this.lbl_endyear.Text = "Záróév:";
            // 
            // nup_endyear
            // 
            this.nup_endyear.Location = new System.Drawing.Point(71, 16);
            this.nup_endyear.Maximum = new decimal(new int[] {
            2104,
            0,
            0,
            0});
            this.nup_endyear.Minimum = new decimal(new int[] {
            2004,
            0,
            0,
            0});
            this.nup_endyear.Name = "nup_endyear";
            this.nup_endyear.Size = new System.Drawing.Size(70, 20);
            this.nup_endyear.TabIndex = 2;
            this.nup_endyear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nup_endyear.Value = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            // 
            // lbl_path
            // 
            this.lbl_path.AutoSize = true;
            this.lbl_path.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_path.Location = new System.Drawing.Point(147, 18);
            this.lbl_path.Name = "lbl_path";
            this.lbl_path.Size = new System.Drawing.Size(64, 13);
            this.lbl_path.TabIndex = 3;
            this.lbl_path.Text = "Elérési út:";
            // 
            // tbox_path
            // 
            this.tbox_path.Location = new System.Drawing.Point(217, 15);
            this.tbox_path.Name = "tbox_path";
            this.tbox_path.Size = new System.Drawing.Size(393, 20);
            this.tbox_path.TabIndex = 4;
            this.tbox_path.Text = "C:\\Temp\\nép.csv";
            // 
            // but_path
            // 
            this.but_path.Location = new System.Drawing.Point(616, 13);
            this.but_path.Name = "but_path";
            this.but_path.Size = new System.Drawing.Size(75, 23);
            this.but_path.TabIndex = 5;
            this.but_path.Text = "Browse";
            this.but_path.UseVisualStyleBackColor = true;
            this.but_path.Click += new System.EventHandler(this.but_path_Click);
            // 
            // rtb_sim
            // 
            this.rtb_sim.Location = new System.Drawing.Point(12, 42);
            this.rtb_sim.Name = "rtb_sim";
            this.rtb_sim.Size = new System.Drawing.Size(760, 357);
            this.rtb_sim.TabIndex = 6;
            this.rtb_sim.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.rtb_sim);
            this.Controls.Add(this.but_path);
            this.Controls.Add(this.tbox_path);
            this.Controls.Add(this.lbl_path);
            this.Controls.Add(this.nup_endyear);
            this.Controls.Add(this.lbl_endyear);
            this.Controls.Add(this.but_sim);
            this.Name = "Form1";
            this.Text = "Népességszimuláció";
            ((System.ComponentModel.ISupportInitialize)(this.nup_endyear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_sim;
        private System.Windows.Forms.Label lbl_endyear;
        private System.Windows.Forms.NumericUpDown nup_endyear;
        private System.Windows.Forms.Label lbl_path;
        private System.Windows.Forms.TextBox tbox_path;
        private System.Windows.Forms.Button but_path;
        private System.Windows.Forms.RichTextBox rtb_sim;
    }
}

