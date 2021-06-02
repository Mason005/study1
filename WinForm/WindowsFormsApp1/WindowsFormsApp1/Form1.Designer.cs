
namespace WindowsFormsApp1
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
            this.BtnWinform = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnWinform
            // 
            this.BtnWinform.Location = new System.Drawing.Point(15, 13);
            this.BtnWinform.Margin = new System.Windows.Forms.Padding(0);
            this.BtnWinform.Name = "BtnWinform";
            this.BtnWinform.Size = new System.Drawing.Size(200, 100);
            this.BtnWinform.TabIndex = 0;
            this.BtnWinform.Text = "WinformButton";
            this.BtnWinform.UseVisualStyleBackColor = true;
            this.BtnWinform.Click += new System.EventHandler(this.BtnWinform_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnWinform);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(30);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnWinform;
    }
}

