namespace Activity05
{
    partial class txtVowel
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
            this.lblSelect = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.lblLower = new System.Windows.Forms.Label();
            this.lblFirst = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.lblLast = new System.Windows.Forms.Label();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.lblLongest = new System.Windows.Forms.Label();
            this.txtLongest = new System.Windows.Forms.TextBox();
            this.lblVowel = new System.Windows.Forms.Label();
            this.txtBoxVowel = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(92, 80);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(112, 20);
            this.lblSelect.TabIndex = 0;
            this.lblSelect.Text = "Select a File: ";
            this.lblSelect.Click += new System.EventHandler(this.lblSelect_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSelect.Location = new System.Drawing.Point(230, 60);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(191, 60);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Choose a File";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtDisplay.Location = new System.Drawing.Point(230, 141);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(523, 251);
            this.txtDisplay.TabIndex = 2;
            this.txtDisplay.TextChanged += new System.EventHandler(this.txtDisplay_TextChanged);
            // 
            // lblLower
            // 
            this.lblLower.AutoSize = true;
            this.lblLower.Location = new System.Drawing.Point(96, 235);
            this.lblLower.Name = "lblLower";
            this.lblLower.Size = new System.Drawing.Size(99, 20);
            this.lblLower.TabIndex = 3;
            this.lblLower.Text = "Lower Case";
            this.lblLower.Click += new System.EventHandler(this.lblLower_Click);
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(65, 445);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(88, 20);
            this.lblFirst.TabIndex = 4;
            this.lblFirst.Text = "First Word";
            this.lblFirst.Click += new System.EventHandler(this.lblFirst_Click);
            // 
            // txtFirst
            // 
            this.txtFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtFirst.Location = new System.Drawing.Point(199, 442);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(188, 27);
            this.txtFirst.TabIndex = 5;
            this.txtFirst.TextChanged += new System.EventHandler(this.txtFirst_TextChanged);
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Location = new System.Drawing.Point(66, 505);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(87, 20);
            this.lblLast.TabIndex = 6;
            this.lblLast.Text = "Last Word";
            this.lblLast.Click += new System.EventHandler(this.lblLast_Click);
            // 
            // txtLast
            // 
            this.txtLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtLast.Location = new System.Drawing.Point(199, 502);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(188, 27);
            this.txtLast.TabIndex = 7;
            this.txtLast.TextChanged += new System.EventHandler(this.txtLast_TextChanged);
            // 
            // lblLongest
            // 
            this.lblLongest.AutoSize = true;
            this.lblLongest.Location = new System.Drawing.Point(521, 442);
            this.lblLongest.Name = "lblLongest";
            this.lblLongest.Size = new System.Drawing.Size(114, 20);
            this.lblLongest.TabIndex = 8;
            this.lblLongest.Text = "Longest Word";
            this.lblLongest.Click += new System.EventHandler(this.lblLongest_Click);
            // 
            // txtLongest
            // 
            this.txtLongest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtLongest.Location = new System.Drawing.Point(658, 435);
            this.txtLongest.Name = "txtLongest";
            this.txtLongest.Size = new System.Drawing.Size(188, 27);
            this.txtLongest.TabIndex = 9;
            this.txtLongest.TextChanged += new System.EventHandler(this.txtLongest_TextChanged);
            // 
            // lblVowel
            // 
            this.lblVowel.AutoSize = true;
            this.lblVowel.Location = new System.Drawing.Point(521, 509);
            this.lblVowel.Name = "lblVowel";
            this.lblVowel.Size = new System.Drawing.Size(119, 20);
            this.lblVowel.TabIndex = 10;
            this.lblVowel.Text = "Longest Vowel";
            this.lblVowel.Click += new System.EventHandler(this.lblVowel_Click);
            // 
            // txtBoxVowel
            // 
            this.txtBoxVowel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtBoxVowel.Location = new System.Drawing.Point(658, 506);
            this.txtBoxVowel.Name = "txtBoxVowel";
            this.txtBoxVowel.Size = new System.Drawing.Size(188, 27);
            this.txtBoxVowel.TabIndex = 11;
            this.txtBoxVowel.TextChanged += new System.EventHandler(this.txtBoxVowel_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // txtVowel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(953, 678);
            this.Controls.Add(this.txtBoxVowel);
            this.Controls.Add(this.lblVowel);
            this.Controls.Add(this.txtLongest);
            this.Controls.Add(this.lblLongest);
            this.Controls.Add(this.txtLast);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.lblFirst);
            this.Controls.Add(this.lblLower);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lblSelect);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "txtVowel";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.txtVowel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Label lblLower;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.Label lblLongest;
        private System.Windows.Forms.TextBox txtLongest;
        private System.Windows.Forms.Label lblVowel;
        private System.Windows.Forms.TextBox txtBoxVowel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

