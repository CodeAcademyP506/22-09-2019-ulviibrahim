namespace UserTodos
{
    partial class Main_Window
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
            this.DgvList = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeadLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblTitle = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DtP = new System.Windows.Forms.DateTimePicker();
            this.LBLID = new System.Windows.Forms.Label();
            this.LblT = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.BtnRef = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvList
            // 
            this.DgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.DgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Title,
            this.DeadLine});
            this.DgvList.Location = new System.Drawing.Point(357, 93);
            this.DgvList.Name = "DgvList";
            this.DgvList.Size = new System.Drawing.Size(292, 214);
            this.DgvList.TabIndex = 6;
            this.DgvList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvList_CellClick);
            this.DgvList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvList_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            // 
            // DeadLine
            // 
            this.DeadLine.HeaderText = "DeadLine";
            this.DeadLine.Name = "DeadLine";
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LblTitle.Location = new System.Drawing.Point(264, 22);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(292, 39);
            this.LblTitle.TabIndex = 5;
            this.LblTitle.Text = "Ibrahimovun Listi";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(52, 107);
            this.txtid.Multiline = true;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(39, 25);
            this.txtid.TabIndex = 7;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(52, 158);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(123, 25);
            this.txtTitle.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(52, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 39);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DtP
            // 
            this.DtP.Location = new System.Drawing.Point(52, 215);
            this.DtP.Name = "DtP";
            this.DtP.Size = new System.Drawing.Size(123, 20);
            this.DtP.TabIndex = 11;
            // 
            // LBLID
            // 
            this.LBLID.AutoSize = true;
            this.LBLID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLID.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LBLID.Location = new System.Drawing.Point(49, 76);
            this.LBLID.Name = "LBLID";
            this.LBLID.Size = new System.Drawing.Size(25, 20);
            this.LBLID.TabIndex = 12;
            this.LBLID.Text = "Id";
            // 
            // LblT
            // 
            this.LblT.AutoSize = true;
            this.LblT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblT.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblT.Location = new System.Drawing.Point(49, 135);
            this.LblT.Name = "LblT";
            this.LblT.Size = new System.Drawing.Size(43, 20);
            this.LblT.TabIndex = 13;
            this.LblT.Text = "Title";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDate.Location = new System.Drawing.Point(49, 192);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(48, 20);
            this.lblDate.TabIndex = 14;
            this.lblDate.Text = "Date";
            // 
            // BtnRef
            // 
            this.BtnRef.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRef.ForeColor = System.Drawing.Color.Green;
            this.BtnRef.Location = new System.Drawing.Point(113, 268);
            this.BtnRef.Name = "BtnRef";
            this.BtnRef.Size = new System.Drawing.Size(62, 39);
            this.BtnRef.TabIndex = 15;
            this.BtnRef.Text = "Refresh";
            this.BtnRef.UseVisualStyleBackColor = false;
            this.BtnRef.Click += new System.EventHandler(this.BtnRef_Click);
            // 
            // Main_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnRef);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.LblT);
            this.Controls.Add(this.LBLID);
            this.Controls.Add(this.DtP);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.DgvList);
            this.Controls.Add(this.LblTitle);
            this.Name = "Main_Window";
            this.Text = "Main_Window";
            this.Shown += new System.EventHandler(this.Main_Window_Shown_1);
            ((System.ComponentModel.ISupportInitialize)(this.DgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeadLine;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker DtP;
        private System.Windows.Forms.Label LBLID;
        private System.Windows.Forms.Label LblT;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button BtnRef;
    }
}