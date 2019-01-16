namespace File_O_Name
{
    partial class FormFileOName
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
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.cmdCopyToClipboard = new System.Windows.Forms.Button();
            this.lstFileStatus = new System.Windows.Forms.ListBox();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.lstAuthor = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabWords = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmdClear = new System.Windows.Forms.Button();
            this.lstDocType = new System.Windows.Forms.ListBox();
            this.lstProjekt = new System.Windows.Forms.ListBox();
            this.tabWords.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFilename
            // 
            this.txtFilename.Location = new System.Drawing.Point(12, 11);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.Size = new System.Drawing.Size(309, 20);
            this.txtFilename.TabIndex = 0;
            // 
            // cmdCopyToClipboard
            // 
            this.cmdCopyToClipboard.Location = new System.Drawing.Point(356, 9);
            this.cmdCopyToClipboard.Name = "cmdCopyToClipboard";
            this.cmdCopyToClipboard.Size = new System.Drawing.Size(75, 23);
            this.cmdCopyToClipboard.TabIndex = 1;
            this.cmdCopyToClipboard.Text = "Copy";
            this.cmdCopyToClipboard.UseVisualStyleBackColor = true;
            // 
            // lstFileStatus
            // 
            this.lstFileStatus.FormattingEnabled = true;
            this.lstFileStatus.Items.AddRange(new object[] {
            "Entwurf",
            "Final"});
            this.lstFileStatus.Location = new System.Drawing.Point(325, 116);
            this.lstFileStatus.Name = "lstFileStatus";
            this.lstFileStatus.Size = new System.Drawing.Size(106, 82);
            this.lstFileStatus.TabIndex = 3;
            this.lstFileStatus.SelectedIndexChanged += new System.EventHandler(this.lstFileStatus_SelectedIndexChanged);
            // 
            // monthCalendar
            // 
            this.monthCalendar.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendar.Location = new System.Drawing.Point(12, 37);
            this.monthCalendar.MaxSelectionCount = 1;
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.ShowWeekNumbers = true;
            this.monthCalendar.TabIndex = 4;
            // 
            // lstAuthor
            // 
            this.lstAuthor.FormattingEnabled = true;
            this.lstAuthor.Location = new System.Drawing.Point(326, 38);
            this.lstAuthor.Name = "lstAuthor";
            this.lstAuthor.Size = new System.Drawing.Size(105, 69);
            this.lstAuthor.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 9);
            this.label1.TabIndex = 6;
            this.label1.Text = "© Mirko Beyer, EFS4, 2019";
            // 
            // tabWords
            // 
            this.tabWords.Controls.Add(this.tabPage1);
            this.tabWords.Controls.Add(this.tabPage2);
            this.tabWords.Location = new System.Drawing.Point(12, 204);
            this.tabWords.Name = "tabWords";
            this.tabWords.SelectedIndex = 0;
            this.tabWords.Size = new System.Drawing.Size(418, 221);
            this.tabWords.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(410, 195);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "WordCloud";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(410, 195);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "WordList";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmdClear
            // 
            this.cmdClear.BackColor = System.Drawing.Color.Red;
            this.cmdClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdClear.Location = new System.Drawing.Point(325, 9);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(25, 23);
            this.cmdClear.TabIndex = 9;
            this.cmdClear.Text = "X";
            this.cmdClear.UseVisualStyleBackColor = false;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // lstDocType
            // 
            this.lstDocType.FormattingEnabled = true;
            this.lstDocType.Items.AddRange(new object[] {
            "Agenda",
            "Dokumentation",
            "Kurzbericht",
            "Protokoll"});
            this.lstDocType.Location = new System.Drawing.Point(214, 116);
            this.lstDocType.Name = "lstDocType";
            this.lstDocType.Size = new System.Drawing.Size(105, 82);
            this.lstDocType.Sorted = true;
            this.lstDocType.TabIndex = 10;
            // 
            // lstProjekt
            // 
            this.lstProjekt.FormattingEnabled = true;
            this.lstProjekt.Location = new System.Drawing.Point(214, 38);
            this.lstProjekt.Name = "lstProjekt";
            this.lstProjekt.Size = new System.Drawing.Size(107, 69);
            this.lstProjekt.TabIndex = 11;
            this.lstProjekt.TabStop = false;
            // 
            // FormFileOName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 446);
            this.Controls.Add(this.lstProjekt);
            this.Controls.Add(this.lstDocType);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.tabWords);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstAuthor);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.lstFileStatus);
            this.Controls.Add(this.cmdCopyToClipboard);
            this.Controls.Add(this.txtFilename);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(1000, 700);
            this.MinimumSize = new System.Drawing.Size(450, 350);
            this.Name = "FormFileOName";
            this.Text = "File-O-Name";
            this.Load += new System.EventHandler(this.FormFileOName_Load);
            this.tabWords.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.Button cmdCopyToClipboard;
        private System.Windows.Forms.ListBox lstFileStatus;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.ListBox lstAuthor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabWords;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.ListBox lstDocType;
        private System.Windows.Forms.ListBox lstProjekt;
    }
}

