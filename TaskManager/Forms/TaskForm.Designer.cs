namespace TaskManager.Forms
{
    partial class TaskForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.txtTaskDetail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTaskDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbStatusNew = new System.Windows.Forms.RadioButton();
            this.rbStatusComplete = new System.Windows.Forms.RadioButton();
            this.txtUpdatedAt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtTitle.Location = new System.Drawing.Point(126, 41);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(1);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(250, 19);
            this.txtTitle.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.YellowGreen;
            this.label1.Location = new System.Drawing.Point(24, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(15, 15, 1, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "タイトル";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSave,
            this.tsmiDelete});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(404, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiSave
            // 
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.Size = new System.Drawing.Size(62, 22);
            this.tsmiSave.Text = "保存(&S)";
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(63, 22);
            this.tsmiDelete.Text = "削除(&D)";
            this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // txtTaskDetail
            // 
            this.txtTaskDetail.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtTaskDetail.Location = new System.Drawing.Point(126, 104);
            this.txtTaskDetail.Margin = new System.Windows.Forms.Padding(1);
            this.txtTaskDetail.Multiline = true;
            this.txtTaskDetail.Name = "txtTaskDetail";
            this.txtTaskDetail.Size = new System.Drawing.Size(250, 300);
            this.txtTaskDetail.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.YellowGreen;
            this.label2.Location = new System.Drawing.Point(24, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(15, 1, 1, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 300);
            this.label2.TabIndex = 8;
            this.label2.Text = "詳細";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpTaskDate
            // 
            this.dtpTaskDate.CustomFormat = "yyyy年MM月dd日 HH:mm";
            this.dtpTaskDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTaskDate.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dtpTaskDate.Location = new System.Drawing.Point(126, 62);
            this.dtpTaskDate.Margin = new System.Windows.Forms.Padding(1);
            this.dtpTaskDate.Name = "dtpTaskDate";
            this.dtpTaskDate.Size = new System.Drawing.Size(160, 19);
            this.dtpTaskDate.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.YellowGreen;
            this.label5.Location = new System.Drawing.Point(24, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(15, 1, 1, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "日時";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.YellowGreen;
            this.label3.Location = new System.Drawing.Point(24, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(15, 1, 1, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "ステータス";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbStatusNew
            // 
            this.rbStatusNew.Location = new System.Drawing.Point(126, 83);
            this.rbStatusNew.Margin = new System.Windows.Forms.Padding(1);
            this.rbStatusNew.Name = "rbStatusNew";
            this.rbStatusNew.Size = new System.Drawing.Size(50, 19);
            this.rbStatusNew.TabIndex = 6;
            this.rbStatusNew.TabStop = true;
            this.rbStatusNew.Text = "新規";
            this.rbStatusNew.UseVisualStyleBackColor = true;
            // 
            // rbStatusComplete
            // 
            this.rbStatusComplete.Location = new System.Drawing.Point(178, 83);
            this.rbStatusComplete.Margin = new System.Windows.Forms.Padding(1);
            this.rbStatusComplete.Name = "rbStatusComplete";
            this.rbStatusComplete.Size = new System.Drawing.Size(50, 19);
            this.rbStatusComplete.TabIndex = 7;
            this.rbStatusComplete.TabStop = true;
            this.rbStatusComplete.Text = "完了";
            this.rbStatusComplete.UseVisualStyleBackColor = true;
            // 
            // txtUpdatedAt
            // 
            this.txtUpdatedAt.Location = new System.Drawing.Point(126, 406);
            this.txtUpdatedAt.Margin = new System.Windows.Forms.Padding(1);
            this.txtUpdatedAt.Name = "txtUpdatedAt";
            this.txtUpdatedAt.ReadOnly = true;
            this.txtUpdatedAt.Size = new System.Drawing.Size(250, 19);
            this.txtUpdatedAt.TabIndex = 11;
            this.txtUpdatedAt.TabStop = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.YellowGreen;
            this.label4.Location = new System.Drawing.Point(24, 406);
            this.label4.Margin = new System.Windows.Forms.Padding(15, 1, 1, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "更新日時";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 459);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUpdatedAt);
            this.Controls.Add(this.rbStatusComplete);
            this.Controls.Add(this.rbStatusNew);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpTaskDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTaskDetail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TaskForm";
            this.Text = "タスク";
            this.Load += new System.EventHandler(this.TaskForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.TextBox txtTaskDetail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTaskDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbStatusNew;
        private System.Windows.Forms.RadioButton rbStatusComplete;
        private System.Windows.Forms.TextBox txtUpdatedAt;
        private System.Windows.Forms.Label label4;
    }
}

