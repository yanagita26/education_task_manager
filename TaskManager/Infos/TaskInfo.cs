using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace TaskManager.Infos
{
    /// <summary>
    /// タスクINFO
    /// </summary>
    public class TaskInfo
    {
        /// <summary>
        /// タスクキー
        /// </summary>
        public int TaskKey { get; set; }

        /// <summary>
        /// タイトル
        /// </summary>
        public String Title { get; set; }

        /// <summary>
        /// 日時
        /// </summary>
        public DateTime TaskDate { get; set; }

        /// <summary>
        /// ステータス
        /// </summary>
        public int TaskStatus{ get; set; }

        /// <summary>
        /// 詳細
        /// </summary>
        public String TaskDetail{ get; set; }

        /// <summary>
        /// 更新日時
        /// </summary>
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 変換
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public static TaskInfo Convert(DataRow row){
            TaskInfo info = new TaskInfo();
            info.TaskKey = (int)row["TASK_KEY"];
            info.UpdatedAt = (DateTime)row["UPDATED_AT"];
            info.Title = row["TITLE"].ToString();
            info.TaskDate = (DateTime)row["TASK_DATE"];
            info.TaskStatus = (int)row["TASK_STATUS"];
            info.TaskDetail = row["TASK_DETAIL"].ToString();
            return info;
        }
    }
}
