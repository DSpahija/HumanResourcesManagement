namespace MenaxhimiIBurimeveNjerezore
{
    partial class LogIn
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
            this.Textbox_FjalekalimiLogin = new System.Windows.Forms.TextBox();
            this.Label_LogIn = new System.Windows.Forms.Label();
            this.Button_KycuLogIn = new System.Windows.Forms.Button();
            this.Textbox_IDLogin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Textbox_FjalekalimiLogin
            // 
            this.Textbox_FjalekalimiLogin.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_FjalekalimiLogin.Location = new System.Drawing.Point(46, 156);
            this.Textbox_FjalekalimiLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Textbox_FjalekalimiLogin.Name = "Textbox_FjalekalimiLogin";
            this.Textbox_FjalekalimiLogin.PasswordChar = '*';
            this.Textbox_FjalekalimiLogin.Size = new System.Drawing.Size(219, 28);
            this.Textbox_FjalekalimiLogin.TabIndex = 2;
            this.Textbox_FjalekalimiLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label_LogIn
            // 
            this.Label_LogIn.AutoSize = true;
            this.Label_LogIn.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_LogIn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Label_LogIn.Location = new System.Drawing.Point(117, 62);
            this.Label_LogIn.Name = "Label_LogIn";
            this.Label_LogIn.Size = new System.Drawing.Size(81, 29);
            this.Label_LogIn.TabIndex = 0;
            this.Label_LogIn.Text = "Login";
            // 
            // Button_KycuLogIn
            // 
            this.Button_KycuLogIn.BackColor = System.Drawing.Color.Teal;
            this.Button_KycuLogIn.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_KycuLogIn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Button_KycuLogIn.Location = new System.Drawing.Point(46, 192);
            this.Button_KycuLogIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_KycuLogIn.Name = "Button_KycuLogIn";
            this.Button_KycuLogIn.Size = new System.Drawing.Size(219, 47);
            this.Button_KycuLogIn.TabIndex = 3;
            this.Button_KycuLogIn.Text = "Kyçu";
            this.Button_KycuLogIn.UseVisualStyleBackColor = false;
            this.Button_KycuLogIn.Click += new System.EventHandler(this.Button_KycuLogIn_Click);
            // 
            // Textbox_IDLogin
            // 
            this.Textbox_IDLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Textbox_IDLogin.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_IDLogin.Location = new System.Drawing.Point(46, 122);
            this.Textbox_IDLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Textbox_IDLogin.MinimumSize = new System.Drawing.Size(100, 40);
            this.Textbox_IDLogin.Name = "Textbox_IDLogin";
            this.Textbox_IDLogin.Size = new System.Drawing.Size(219, 28);
            this.Textbox_IDLogin.TabIndex = 1;
            this.Textbox_IDLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LogIn
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(313, 277);
            this.Controls.Add(this.Textbox_IDLogin);
            this.Controls.Add(this.Button_KycuLogIn);
            this.Controls.Add(this.Label_LogIn);
            this.Controls.Add(this.Textbox_FjalekalimiLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.LogIn_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Textbox_FjalekalimiLogin;
        private System.Windows.Forms.Label Label_LogIn;
        private System.Windows.Forms.Button Button_KycuLogIn;
        private System.Windows.Forms.TextBox Textbox_IDLogin;
    }
}

