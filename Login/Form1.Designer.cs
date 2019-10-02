namespace UserTodos
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
            this.BtnLogin = new System.Windows.Forms.Button();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.LblPass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(62, 185);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(156, 37);
            this.BtnLogin.TabIndex = 2;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(62, 66);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(156, 20);
            this.TxtName.TabIndex = 3;
            // 
            // TxtPass
            // 
            this.TxtPass.Location = new System.Drawing.Point(62, 133);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.Size = new System.Drawing.Size(156, 20);
            this.TxtPass.TabIndex = 4;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(59, 35);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(55, 20);
            this.LblName.TabIndex = 5;
            this.LblName.Text = "Name";
            // 
            // LblPass
            // 
            this.LblPass.AutoSize = true;
            this.LblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPass.Location = new System.Drawing.Point(59, 101);
            this.LblPass.Name = "LblPass";
            this.LblPass.Size = new System.Drawing.Size(86, 20);
            this.LblPass.TabIndex = 6;
            this.LblPass.Text = "Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 304);
            this.Controls.Add(this.LblPass);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.TxtPass);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.BtnLogin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.TextBox TxtPass;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblPass;
        public System.Windows.Forms.TextBox TxtName;
    }
}

