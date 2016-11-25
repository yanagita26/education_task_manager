using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using TaskManager.Controllers;
using TaskManager.Infos;
using TaskManager.Models;

namespace TaskManager.Forms
{
	/// <summary>
	/// タスク
	/// </summary>
	public partial class TaskIchiranForm : BaseForm
    {
        #region 変数

        /// <summary>
        /// タスクモデル
        /// </summary>
        private TaskModel taskModel;

        #endregion

        #region イベント

        #region フォーム

        /// <summary>
        /// 初期化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TaskIchiranForm_Load(object sender, EventArgs e)
        {
            init();
            serach();
        }

        #endregion

        #region メニュー

        /// <summary>
        /// 検索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiSearch_Click(object sender, EventArgs e)
        {
            serach();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiNew_Click(object sender, EventArgs e)
        {
            TaskForm form = new TaskForm();

            if (form.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                serach();
            }
        }

        /// <summary>
        /// 選択
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiSelect_Click(object sender, EventArgs e)
        {
            TaskInfo info = TaskInfo.Convert(((DataRowView)dgvIchiran.CurrentRow.DataBoundItem).Row);

            TaskForm form = new TaskForm();

            form.SelectedTaskInfo = info;

            if (form.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                serach();
            }
        }

        #endregion

        #region テキストボックス

        /// <summary>
        /// 検索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtWord_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) tsmiSearch.PerformClick();
        }
        
        #endregion

        #region データグリッドビュー

        /// <summary>
        /// 選択
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvIchiran_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tsmiSelect.PerformClick();
        }

        private void dgvIchiran_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvIchiran.Columns[e.ColumnIndex].DataPropertyName == "TASK_STATUS")
            {
                if ((long)e.Value == 1)
                {
                    e.Value = "新規";
                }
                else
                {
                    e.Value = "完了";
                }
            }
        }
        
        #endregion

        #endregion

        #region メソッド

        #region コンストラクタ

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public TaskIchiranForm()
        {
            InitializeComponent();
        }
        
        #endregion

        #region 初期化

        /// <summary>
        /// 初期化
        /// </summary>
        private void init()
        {
            taskModel = new TaskModel(DatabaseIf.Instance);
            dtpStartDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpEndDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month));

            initDataGridView();
        }

        /// <summary>
        /// データグリッドビューの初期化
        /// </summary>
        private void initDataGridView()
        {
            dgvIchiran.AllowUserToAddRows = false;
            dgvIchiran.RowHeadersVisible = false;
            dgvIchiran.AutoGenerateColumns = false;
            dgvIchiran.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvIchiran.MultiSelect = false;
            dgvIchiran.EnableHeadersVisualStyles = false;
            dgvIchiran.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvIchiran.ColumnHeadersDefaultCellStyle.BackColor = Color.YellowGreen;
            dgvIchiran.AlternatingRowsDefaultCellStyle.BackColor = Color.LightYellow;
            dgvIchiran.AllowUserToResizeColumns = false;
            dgvIchiran.AllowUserToResizeRows = false;

            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.HeaderText = "タイトル";
            col.DataPropertyName = "TITLE";
            col.ReadOnly = true;
            col.Width = 200;
            dgvIchiran.Columns.Add(col);

            col = new DataGridViewTextBoxColumn();
            col.HeaderText = "日時";
            col.DataPropertyName = "TASK_DATE";
            col.ReadOnly = true;
            col.Width = 150;
            dgvIchiran.Columns.Add(col);

            col = new DataGridViewTextBoxColumn();
            col.HeaderText = "ステータス";
            col.DataPropertyName = "TASK_STATUS";
            col.ReadOnly = true;
            col.Width = 100;
            dgvIchiran.Columns.Add(col);

            col = new DataGridViewTextBoxColumn();
            col.HeaderText = "詳細";
            col.DataPropertyName = "TASK_DETAIL";
            col.ReadOnly = true;
            col.Width = 500;
            dgvIchiran.Columns.Add(col);
        }

        #endregion

        #region データベースアクセス

        /// <summary>
        /// 検索
        /// </summary>
        /// <param name="word"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        private DataTable selectTask(string word, DateTime? startDate, DateTime? endDate, int status)
        {
            return (DataTable)taskModel.select(word, startDate, endDate, status);
        }

        #endregion

        #region 検索

        /// <summary>
        /// 
        /// </summary>
        private void serach()
        {
            int status = 0;
            if (rbStatusNew.Checked) status = 1;
            if (rbStatusComplete.Checked) status = 2;
            DateTime? startDate = null;
            DateTime? endDate = null;
            if(dtpStartDate.Checked) startDate = dtpStartDate.Value;
            if (dtpEndDate.Checked) endDate = dtpEndDate.Value;
            dgvIchiran.DataSource = selectTask(txtWord.Text, startDate, endDate, status);
        }

        #endregion

        #endregion
    }
}
