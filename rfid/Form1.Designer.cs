namespace rfid
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox36 = new System.Windows.Forms.GroupBox();
            this.label62 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.button26 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox36.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.listView1.AutoArrange = false;
            this.listView1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(613, 442);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tag ID";
            this.columnHeader2.Width = 153;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date";
            this.columnHeader3.Width = 166;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Destination";
            this.columnHeader4.Width = 174;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Status";
            // 
            // groupBox36
            // 
            this.groupBox36.Controls.Add(this.label62);
            this.groupBox36.Controls.Add(this.label61);
            this.groupBox36.Controls.Add(this.label60);
            this.groupBox36.Controls.Add(this.label59);
            this.groupBox36.Controls.Add(this.label58);
            this.groupBox36.Location = new System.Drawing.Point(12, 460);
            this.groupBox36.Name = "groupBox36";
            this.groupBox36.Size = new System.Drawing.Size(804, 183);
            this.groupBox36.TabIndex = 10;
            this.groupBox36.TabStop = false;
            this.groupBox36.Text = "Message Log";
            this.groupBox36.Enter += new System.EventHandler(this.groupBox36_Enter);
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(22, 146);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(177, 13);
            this.label62.TabIndex = 4;
            this.label62.Text = "Read History: Consult the database ";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(22, 114);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(577, 13);
            this.label61.TabIndex = 3;
            this.label61.Text = "Add destination to Selected : allows you to write on database the physical adress" +
    " of destination and a logical ID in the tag";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(22, 82);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(411, 13);
            this.label60.TabIndex = 2;
            this.label60.Text = "Remove Selected: allow you to delet a specific item from the table (not from data" +
    "base)";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(22, 53);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(342, 13);
            this.label59.TabIndex = 1;
            this.label59.Text = "Add Selected to database: allow you to add a specific item to database";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(22, 25);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(289, 13);
            this.label58.TabIndex = 0;
            this.label58.Text = "Sumbit to database : Allow you to send all data to database.";
            this.label58.Click += new System.EventHandler(this.label58_Click);
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(646, 362);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(153, 30);
            this.button26.TabIndex = 16;
            this.button26.Text = "Clear all";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(646, 198);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(153, 30);
            this.button25.TabIndex = 15;
            this.button25.Text = "Add destination to selected";
            this.button25.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(646, 141);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(153, 30);
            this.button24.TabIndex = 14;
            this.button24.Text = "remove Selected";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(646, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 30);
            this.button1.TabIndex = 13;
            this.button1.Text = "Add selected to database";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(646, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 30);
            this.button2.TabIndex = 12;
            this.button2.Text = "Sumbit to database";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(646, 259);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 30);
            this.button3.TabIndex = 17;
            this.button3.Text = "Read History";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(832, 651);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox36);
            this.ForeColor = System.Drawing.SystemColors.GrayText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RFID Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox36.ResumeLayout(false);
            this.groupBox36.PerformLayout();
            this.ResumeLayout(false);

        }

        
        #endregion
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.GroupBox groupBox36;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button button3;
    }
}

