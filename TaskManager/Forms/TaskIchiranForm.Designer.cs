namespace TaskManager.Forms
{
    partial class TaskIchiranForm
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
            this.dgvIchiran = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rbStatusComplete = new System.Windows.Forms.RadioButton();
            this.rbStatusNew = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIchiran)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvIchiran
            // 
            this.dgvIchiran.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvIchiran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIchiran.Location = new System.Drawing.Point(12, 125);
            this.dgvIchiran.Name = "dgvIchiran";
            this.dgvIchiran.RowTemplate.Height = 21;
            this.dgvIchiran.Size = new System.Drawing.Size(960, 425);
            this.dgvIchiran.TabIndex = 2;
            this.dgvIchiran.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvIchiran_CellFormatting);
            this.dgvIchiran.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvIchiran_CellMouseDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNew,
            this.tsmiSearch,
            this.tsmiSelect});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiNew
            // 
            this.tsmiNew.Name = "tsmiNew";
            this.tsmiNew.Size = new System.Drawing.Size(87, 22);
            this.tsmiNew.Text = "新規作成(&N)";
            this.tsmiNew.Click += new System.EventHandler(this.tsmiNew_Click);
            // 
            // tsmiSearch
            // 
            this.tsmiSearch.Name = "tsmiSearch";
            this.tsmiSearch.Size = new System.Drawing.Size(61, 22);
            this.tsmiSearch.Text = "検索(&F)";
            this.tsmiSearch.Click += new System.EventHandler(this.tsmiSearch_Click);
            // 
            // tsmiSelect
            // 
            this.tsmiSelect.Name = "tsmiSelect";
            this.tsmiSelect.Size = new System.Drawing.Size(61, 22);
            this.tsmiSelect.Text = "選択(&E)";
            this.tsmiSelect.Click += new System.EventHandler(this.tsmiSelect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.rbStatusComplete);
            this.groupBox1.Controls.Add(this.rbStatusNew);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpEndDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpStartDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtWord);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(960, 90);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "検索条件";
            // 
            // radioButton1
            // 
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(224, 58);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(1);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(50, 19);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "全て";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rbStatusComplete
            // 
            this.rbStatusComplete.Location = new System.Drawing.Point(172, 58);
            this.rbStatusComplete.Margin = new System.Windows.Forms.Padding(1);
            this.rbStatusComplete.Name = "rbStatusComplete";
            this.rbStatusComplete.Size = new System.Drawing.Size(50, 19);
            this.rbStatusComplete.TabIndex = 8;
            this.rbStatusComplete.Text = "完了";
            this.rbStatusComplete.UseVisualStyleBackColor = true;
            // 
            // rbStatusNew
            // 
            this.rbStatusNew.Location = new System.Drawing.Point(120, 58);
            this.rbStatusNew.Margin = new System.Windows.Forms.Padding(1);
            this.rbStatusNew.Name = "rbStatusNew";
            this.rbStatusNew.Size = new System.Drawing.Size(50, 19);
            this.rbStatusNew.TabIndex = 7;
            this.rbStatusNew.Text = "新規";
            this.rbStatusNew.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.YellowGreen;
            this.label4.Location = new System.Drawing.Point(18, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(15, 1, 1, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "ステータス";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dtpEndDate.Location = new System.Drawing.Point(283, 37);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(1);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.ShowCheckBox = true;
            this.dtpEndDate.Size = new System.Drawing.Size(140, 19);
            this.dtpEndDate.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(262, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "～";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dtpStartDate.Location = new System.Drawing.Point(120, 37);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(1);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.ShowCheckBox = true;
            this.dtpStartDate.Size = new System.Drawing.Size(140, 19);
            this.dtpStartDate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.YellowGreen;
            this.label2.Location = new System.Drawing.Point(18, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(15, 1, 1, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "日付";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtWord
            // 
            this.txtWord.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtWord.Location = new System.Drawing.Point(120, 16);
            this.txtWord.Margin = new System.Windows.Forms.Padding(1);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(243, 19);
            this.txtWord.TabIndex = 1;
            this.txtWord.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtWord_PreviewKeyDown);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.YellowGreen;
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(15, 1, 1, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "検索キーワード";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TaskIchiranForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvIchiran);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TaskIchiranForm";
            this.Text = "タスク一覧";
            this.Load += new System.EventHandler(this.TaskIchiranForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIchiran)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIchiran;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiNew;
        private System.Windows.Forms.ToolStripMenuItem tsmiSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbStatusComplete;
        private System.Windows.Forms.RadioButton rbStatusNew;
        private System.Windows.Forms.ToolStripMenuItem tsmiSelect;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}