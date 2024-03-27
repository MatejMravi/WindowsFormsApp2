namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtdisplay = new System.Windows.Forms.TextBox();
            this.bt_tlacitko_seven = new System.Windows.Forms.Button();
            this.bt_tlacitko_zero = new System.Windows.Forms.Button();
            this.bt_tlacitko_three = new System.Windows.Forms.Button();
            this.bt_tlacitko_two = new System.Windows.Forms.Button();
            this.bt_tlacitko_one = new System.Windows.Forms.Button();
            this.bt_tlacitko_six = new System.Windows.Forms.Button();
            this.bt_tlacitko_five = new System.Windows.Forms.Button();
            this.bt_tlacitko_four = new System.Windows.Forms.Button();
            this.bt_tlacitko_nine = new System.Windows.Forms.Button();
            this.bt_tlacitko_eight = new System.Windows.Forms.Button();
            this.bt_tlacitko_point = new System.Windows.Forms.Button();
            this.bt_smazat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtdisplay
            // 
            this.txtdisplay.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtdisplay.Location = new System.Drawing.Point(38, 13);
            this.txtdisplay.Name = "txtdisplay";
            this.txtdisplay.Size = new System.Drawing.Size(308, 33);
            this.txtdisplay.TabIndex = 0;
            this.txtdisplay.Text = "0";
            this.txtdisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bt_tlacitko_seven
            // 
            this.bt_tlacitko_seven.Location = new System.Drawing.Point(38, 52);
            this.bt_tlacitko_seven.Name = "bt_tlacitko_seven";
            this.bt_tlacitko_seven.Size = new System.Drawing.Size(61, 49);
            this.bt_tlacitko_seven.TabIndex = 1;
            this.bt_tlacitko_seven.Text = "7";
            this.bt_tlacitko_seven.UseVisualStyleBackColor = true;
            this.bt_tlacitko_seven.Click += new System.EventHandler(this.bt_tlacitko_zero_Click);
            // 
            // bt_tlacitko_zero
            // 
            this.bt_tlacitko_zero.Location = new System.Drawing.Point(38, 217);
            this.bt_tlacitko_zero.Name = "bt_tlacitko_zero";
            this.bt_tlacitko_zero.Size = new System.Drawing.Size(61, 49);
            this.bt_tlacitko_zero.TabIndex = 2;
            this.bt_tlacitko_zero.Text = "0";
            this.bt_tlacitko_zero.UseVisualStyleBackColor = true;
            this.bt_tlacitko_zero.Click += new System.EventHandler(this.bt_tlacitko_zero_Click);
            // 
            // bt_tlacitko_three
            // 
            this.bt_tlacitko_three.Location = new System.Drawing.Point(172, 162);
            this.bt_tlacitko_three.Name = "bt_tlacitko_three";
            this.bt_tlacitko_three.Size = new System.Drawing.Size(61, 49);
            this.bt_tlacitko_three.TabIndex = 3;
            this.bt_tlacitko_three.Text = "3";
            this.bt_tlacitko_three.UseVisualStyleBackColor = true;
            this.bt_tlacitko_three.Click += new System.EventHandler(this.bt_tlacitko_zero_Click);
            // 
            // bt_tlacitko_two
            // 
            this.bt_tlacitko_two.Location = new System.Drawing.Point(105, 162);
            this.bt_tlacitko_two.Name = "bt_tlacitko_two";
            this.bt_tlacitko_two.Size = new System.Drawing.Size(61, 49);
            this.bt_tlacitko_two.TabIndex = 4;
            this.bt_tlacitko_two.Text = "2";
            this.bt_tlacitko_two.UseVisualStyleBackColor = true;
            this.bt_tlacitko_two.Click += new System.EventHandler(this.bt_tlacitko_zero_Click);
            // 
            // bt_tlacitko_one
            // 
            this.bt_tlacitko_one.Location = new System.Drawing.Point(38, 162);
            this.bt_tlacitko_one.Name = "bt_tlacitko_one";
            this.bt_tlacitko_one.Size = new System.Drawing.Size(61, 49);
            this.bt_tlacitko_one.TabIndex = 5;
            this.bt_tlacitko_one.Text = "1";
            this.bt_tlacitko_one.UseVisualStyleBackColor = true;
            this.bt_tlacitko_one.Click += new System.EventHandler(this.bt_tlacitko_zero_Click);
            // 
            // bt_tlacitko_six
            // 
            this.bt_tlacitko_six.Location = new System.Drawing.Point(172, 107);
            this.bt_tlacitko_six.Name = "bt_tlacitko_six";
            this.bt_tlacitko_six.Size = new System.Drawing.Size(61, 49);
            this.bt_tlacitko_six.TabIndex = 6;
            this.bt_tlacitko_six.Text = "6";
            this.bt_tlacitko_six.UseVisualStyleBackColor = true;
            this.bt_tlacitko_six.Click += new System.EventHandler(this.bt_tlacitko_zero_Click);
            // 
            // bt_tlacitko_five
            // 
            this.bt_tlacitko_five.Location = new System.Drawing.Point(105, 107);
            this.bt_tlacitko_five.Name = "bt_tlacitko_five";
            this.bt_tlacitko_five.Size = new System.Drawing.Size(61, 49);
            this.bt_tlacitko_five.TabIndex = 7;
            this.bt_tlacitko_five.Text = "5";
            this.bt_tlacitko_five.UseVisualStyleBackColor = true;
            this.bt_tlacitko_five.Click += new System.EventHandler(this.bt_tlacitko_zero_Click);
            // 
            // bt_tlacitko_four
            // 
            this.bt_tlacitko_four.Location = new System.Drawing.Point(38, 107);
            this.bt_tlacitko_four.Name = "bt_tlacitko_four";
            this.bt_tlacitko_four.Size = new System.Drawing.Size(61, 49);
            this.bt_tlacitko_four.TabIndex = 8;
            this.bt_tlacitko_four.Text = "4";
            this.bt_tlacitko_four.UseVisualStyleBackColor = true;
            this.bt_tlacitko_four.Click += new System.EventHandler(this.bt_tlacitko_zero_Click);
            // 
            // bt_tlacitko_nine
            // 
            this.bt_tlacitko_nine.Location = new System.Drawing.Point(172, 52);
            this.bt_tlacitko_nine.Name = "bt_tlacitko_nine";
            this.bt_tlacitko_nine.Size = new System.Drawing.Size(61, 49);
            this.bt_tlacitko_nine.TabIndex = 9;
            this.bt_tlacitko_nine.Text = "9";
            this.bt_tlacitko_nine.UseVisualStyleBackColor = true;
            this.bt_tlacitko_nine.Click += new System.EventHandler(this.bt_tlacitko_zero_Click);
            // 
            // bt_tlacitko_eight
            // 
            this.bt_tlacitko_eight.Location = new System.Drawing.Point(105, 52);
            this.bt_tlacitko_eight.Name = "bt_tlacitko_eight";
            this.bt_tlacitko_eight.Size = new System.Drawing.Size(61, 49);
            this.bt_tlacitko_eight.TabIndex = 10;
            this.bt_tlacitko_eight.Text = "8";
            this.bt_tlacitko_eight.UseVisualStyleBackColor = true;
            this.bt_tlacitko_eight.Click += new System.EventHandler(this.bt_tlacitko_zero_Click);
            // 
            // bt_tlacitko_point
            // 
            this.bt_tlacitko_point.Location = new System.Drawing.Point(105, 217);
            this.bt_tlacitko_point.Name = "bt_tlacitko_point";
            this.bt_tlacitko_point.Size = new System.Drawing.Size(61, 49);
            this.bt_tlacitko_point.TabIndex = 11;
            this.bt_tlacitko_point.Text = ".";
            this.bt_tlacitko_point.UseVisualStyleBackColor = true;
            // 
            // bt_smazat
            // 
            this.bt_smazat.Location = new System.Drawing.Point(172, 217);
            this.bt_smazat.Name = "bt_smazat";
            this.bt_smazat.Size = new System.Drawing.Size(61, 49);
            this.bt_smazat.TabIndex = 12;
            this.bt_smazat.Text = "C";
            this.bt_smazat.UseVisualStyleBackColor = true;
            this.bt_smazat.Click += new System.EventHandler(this.bt_smazat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 294);
            this.Controls.Add(this.bt_smazat);
            this.Controls.Add(this.bt_tlacitko_point);
            this.Controls.Add(this.bt_tlacitko_eight);
            this.Controls.Add(this.bt_tlacitko_nine);
            this.Controls.Add(this.bt_tlacitko_four);
            this.Controls.Add(this.bt_tlacitko_five);
            this.Controls.Add(this.bt_tlacitko_six);
            this.Controls.Add(this.bt_tlacitko_one);
            this.Controls.Add(this.bt_tlacitko_two);
            this.Controls.Add(this.bt_tlacitko_three);
            this.Controls.Add(this.bt_tlacitko_zero);
            this.Controls.Add(this.bt_tlacitko_seven);
            this.Controls.Add(this.txtdisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Kalkulačka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdisplay;
        private System.Windows.Forms.Button bt_tlacitko_seven;
        private System.Windows.Forms.Button bt_tlacitko_zero;
        private System.Windows.Forms.Button bt_tlacitko_three;
        private System.Windows.Forms.Button bt_tlacitko_two;
        private System.Windows.Forms.Button bt_tlacitko_one;
        private System.Windows.Forms.Button bt_tlacitko_six;
        private System.Windows.Forms.Button bt_tlacitko_five;
        private System.Windows.Forms.Button bt_tlacitko_four;
        private System.Windows.Forms.Button bt_tlacitko_nine;
        private System.Windows.Forms.Button bt_tlacitko_eight;
        private System.Windows.Forms.Button bt_tlacitko_point;
        private System.Windows.Forms.Button bt_smazat;
    }
}

