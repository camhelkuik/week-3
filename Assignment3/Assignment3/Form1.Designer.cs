namespace Assignment3
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
            this.lblDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHotKeyNotice = new System.Windows.Forms.Label();
            this.txtMiles = new System.Windows.Forms.TextBox();
            this.txtGallons = new System.Windows.Forms.TextBox();
            this.lblMPG = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(61, 54);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(79, 25);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "lblDate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Miles Driven";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gallon Used";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Miles Per Gallon";
            // 
            // lblHotKeyNotice
            // 
            this.lblHotKeyNotice.AutoSize = true;
            this.lblHotKeyNotice.Location = new System.Drawing.Point(61, 416);
            this.lblHotKeyNotice.Name = "lblHotKeyNotice";
            this.lblHotKeyNotice.Size = new System.Drawing.Size(165, 25);
            this.lblHotKeyNotice.TabIndex = 4;
            this.lblHotKeyNotice.Text = "lblHotKeyNotice";
            // 
            // txtMiles
            // 
            this.txtMiles.Location = new System.Drawing.Point(431, 101);
            this.txtMiles.Name = "txtMiles";
            this.txtMiles.Size = new System.Drawing.Size(132, 31);
            this.txtMiles.TabIndex = 5;
            this.txtMiles.Text = "txtMiles";
            this.txtMiles.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtGallons
            // 
            this.txtGallons.Location = new System.Drawing.Point(431, 156);
            this.txtGallons.Name = "txtGallons";
            this.txtGallons.Size = new System.Drawing.Size(132, 31);
            this.txtGallons.TabIndex = 6;
            this.txtGallons.Text = "txtGallons";
            this.txtGallons.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMPG
            // 
            this.lblMPG.Location = new System.Drawing.Point(439, 218);
            this.lblMPG.Name = "lblMPG";
            this.lblMPG.Size = new System.Drawing.Size(132, 25);
            this.lblMPG.TabIndex = 7;
            this.lblMPG.Text = "lblMPG";
            this.lblMPG.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(66, 330);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(160, 40);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(259, 330);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(141, 40);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clea&r";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(431, 330);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(132, 40);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 473);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblMPG);
            this.Controls.Add(this.txtGallons);
            this.Controls.Add(this.txtMiles);
            this.Controls.Add(this.lblHotKeyNotice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDate);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHotKeyNotice;
        private System.Windows.Forms.TextBox txtMiles;
        private System.Windows.Forms.TextBox txtGallons;
        private System.Windows.Forms.Label lblMPG;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

