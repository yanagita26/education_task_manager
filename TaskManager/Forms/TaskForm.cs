using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TaskManager.Infos;
using TaskManager.Models;

namespace TaskManager.Forms
{
    /// <summary>
    /// タスク
    /// </summary>
    public partial class TaskForm : BaseForm
    {
        #region 変数

        /// <summary>
        /// タスクモデル
        /// </summary>
        private TaskModel taskModel;

        #endregion

        #region プロパティ

        /// <summary>
        /// タスクINFO
        /// </summary>
        public TaskInfo SelectedTaskInfo{ get; set; }

        #endregion

        #region イベント

        #region フォーム

        /// <summary>
        /// 初期化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TaskForm_Load(object sender, EventArgs e)
        {
            init();
            if (SelectedTaskInfo != null)
            {
                read(SelectedTaskInfo);
            }
        }
        
        #endregion

        #region メニュー

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiSave_Click(object sender, EventArgs e)
        {
            save();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        /// <summary>
        /// 削除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            if (SelectedTaskInfo != null)
            {
                if (MessageBox.Show(this, "タスクを削除しますか？", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    delete();
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    Close();
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
        public TaskForm()
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
            taskModel = new TaskModel(Program.databaseIf);
            rbStatusNew.Checked = true;
            dtpTaskDate.Value = DateTime.Now;
        }

        #endregion

        #region データベースアクセス

        /// <summary>
        /// 削除
        /// </summary>
        /// <param name="taskKey"></param>
        private void deleteTask(int taskKey)
        {
            taskModel.delete(taskKey);
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="info"></param>
        private void updateTask(TaskInfo info)
        {
            taskModel.update(info);
        }

        /// <summary>
        /// 追加
        /// </summary>
        /// <param name="info"></param>
        private void insertTask(TaskInfo info)
        {
            taskModel.insert(info);
        }

        #endregion

        #region 読込

        /// <summary>
        /// 読込
        /// </summary>
        /// <param name="info"></param>
        private void read(TaskInfo info)
        {
            txtTitle.Text = info.Title;

            dtpTaskDate.Value = info.TaskDate;

            if (info.TaskStatus == 1)
            {
                rbStatusNew.Checked = true;
            }
            else
            {
                rbStatusComplete.Checked = true;
            }

            txtTaskDetail.Text = info.TaskDetail;

            txtUpdatedAt.Text = info.UpdatedAt.ToShortDateString();
        }

        #endregion

        #region 保存

        /// <summary>
        /// 保存
        /// </summary>
        private void save()
        {
            TaskInfo info = SelectedTaskInfo ?? new TaskInfo();
            info.Title = txtTitle.Text;
            info.TaskDate = dtpTaskDate.Value;
            info.TaskStatus = rbStatusNew.Checked ? 1 : 2;
            info.TaskDetail = txtTaskDetail.Text;

            if (SelectedTaskInfo != null)
            {
                updateTask(info);
            }
            else
            {
                insertTask(info);
            }
        }

        #endregion

        #region 削除

        /// <summary>
        /// 削除
        /// </summary>
        private void delete()
        {
            deleteTask(SelectedTaskInfo.TaskKey);
        }

        #endregion



        #endregion

    }
}
