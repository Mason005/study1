
namespace WindowsFormsApp2
{
    partial class MdiMain
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
            this.btnFormShow = new System.Windows.Forms.Button();
            this.btnFormOutShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFormShow
            // 
            this.btnFormShow.Location = new System.Drawing.Point(675, 46);
            this.btnFormShow.Name = "btnFormShow";
            this.btnFormShow.Size = new System.Drawing.Size(113, 96);
            this.btnFormShow.TabIndex = 1;
            this.btnFormShow.Text = "Form1 열기";
            this.btnFormShow.UseVisualStyleBackColor = true;
            // 
            // btnFormOutShow
            // 
            this.btnFormOutShow.Location = new System.Drawing.Point(675, 148);
            this.btnFormOutShow.Name = "btnFormOutShow";
            this.btnFormOutShow.Size = new System.Drawing.Size(113, 96);
            this.btnFormOutShow.TabIndex = 2;
            this.btnFormOutShow.Text = "Form1 독립 열기";
            this.btnFormOutShow.UseVisualStyleBackColor = true;
            // 
            // MdiMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFormOutShow);
            this.Controls.Add(this.btnFormShow);
            this.IsMdiContainer = true;
            this.Name = "MdiMain";
            this.Text = "메인창";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFormShow;
        private System.Windows.Forms.Button btnFormOutShow;
    }
}

