
namespace Login_Info
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
            this.Id_txt = new System.Windows.Forms.TextBox();
            this.Pw_txt = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Id_txt
            // 
            this.Id_txt.Location = new System.Drawing.Point(247, 173);
            this.Id_txt.Name = "Id_txt";
            this.Id_txt.Size = new System.Drawing.Size(123, 21);
            this.Id_txt.TabIndex = 0;
            // 
            // Pw_txt
            // 
            this.Pw_txt.Location = new System.Drawing.Point(247, 200);
            this.Pw_txt.Name = "Pw_txt";
            this.Pw_txt.PasswordChar = '●';
            this.Pw_txt.Size = new System.Drawing.Size(123, 21);
            this.Pw_txt.TabIndex = 1;
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(376, 173);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(75, 50);
            this.login_btn.TabIndex = 2;
            this.login_btn.Text = "Log in";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "PW";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gulim", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(52, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(581, 64);
            this.label3.TabIndex = 5;
            this.label3.Text = "This is Login Form";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 279);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.Pw_txt);
            this.Controls.Add(this.Id_txt);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Login Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Id_txt;
        private System.Windows.Forms.TextBox Pw_txt;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

