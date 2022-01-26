namespace FunnyNamesForYou
{
    partial class funnyNamesForYou
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
            this.label1 = new System.Windows.Forms.Label();
            this.name_button = new System.Windows.Forms.Button();
            this.male_button = new System.Windows.Forms.Button();
            this.female_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 107);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // name_button
            // 
            this.name_button.BackColor = System.Drawing.Color.PowderBlue;
            this.name_button.Location = new System.Drawing.Point(240, 315);
            this.name_button.Name = "name_button";
            this.name_button.Size = new System.Drawing.Size(225, 78);
            this.name_button.TabIndex = 1;
            this.name_button.Text = "CLICK FOR THE NAME";
            this.name_button.UseVisualStyleBackColor = false;
            this.name_button.Click += new System.EventHandler(this.name_button_Click);
            // 
            // male_button
            // 
            this.male_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.male_button.Location = new System.Drawing.Point(261, 257);
            this.male_button.Name = "male_button";
            this.male_button.Size = new System.Drawing.Size(84, 40);
            this.male_button.TabIndex = 2;
            this.male_button.Text = "MALE";
            this.male_button.UseVisualStyleBackColor = false;
            this.male_button.Click += new System.EventHandler(this.male_button_Click);
            // 
            // female_button
            // 
            this.female_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.female_button.Location = new System.Drawing.Point(351, 257);
            this.female_button.Name = "female_button";
            this.female_button.Size = new System.Drawing.Size(85, 40);
            this.female_button.TabIndex = 3;
            this.female_button.Text = "FEMALE";
            this.female_button.UseVisualStyleBackColor = false;
            this.female_button.Click += new System.EventHandler(this.female_button_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(709, 92);
            this.label2.TabIndex = 4;
            this.label2.Text = "Around 400 Funny names are ready for you. A gentle click on CLICK FOR THE NAME wi" +
    "ll shows you\r\na random name for you from our list. Don\'t forget to select MALE o" +
    "r FEMALE.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(189, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 29);
            this.label3.TabIndex = 5;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // funnyNamesForYou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(726, 488);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.female_button);
            this.Controls.Add(this.male_button);
            this.Controls.Add(this.name_button);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "funnyNamesForYou";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FUNNY NAMES FOR YOU";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button name_button;
        private System.Windows.Forms.Button male_button;
        private System.Windows.Forms.Button female_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

