using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskManager.Controllers;
using TaskManager.Infos;

namespace TaskManager.Models
{
    /// <summary>
    /// タスクモデル
    /// </summary>
    public class TaskModel
    {
        /// <summary>
        /// データベースIF
        /// </summary>
        private DatabaseIf datavaseIf; 

        /// <summary>
        /// 削除
        /// </summary>
        /// <param name="taskKey"></param>
        public void delete(int taskKey)
        {
            StringBuilder sql = new StringBuilder();

            sql.AppendLine("DELETE");
            sql.AppendLine("FROM");
            sql.AppendLine("TASK");
            sql.AppendLine("WHERE");
            sql.AppendFormat("TASK.TASK_KEY = {0}", taskKey);

            datavaseIf.ExecuteSqlNonQuery(sql.ToString());
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="datavaseIf"></param>
        public TaskModel(DatabaseIf datavaseIf)
        {
            this.datavaseIf = datavaseIf;
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="info"></param>
        public void update(TaskInfo info)
        {
            StringBuilder sql = new StringBuilder();

            sql.AppendLine("UPDATE");
            sql.AppendLine("TASK");
            sql.AppendLine("SET");
            sql.AppendLine("UPDATED_AT = GETDATE()");
            sql.AppendFormat(",TITLE = '{0}'", info.Title);
            sql.AppendFormat(",TASK_DATE = '{0}'", info.TaskDate);
            sql.AppendFormat(",TASK_STATUS = {0}", info.TaskStatus);
            sql.AppendFormat(",TASK_DETAIL = '{0}' ", info.TaskDetail);
            sql.AppendLine("WHERE");
            sql.AppendFormat("TASK.TASK_KEY = {0} ", info.TaskKey);

            datavaseIf.ExecuteSqlNonQuery(sql.ToString());
        }

        /// <summary>
        /// 追加
        /// </summary>
        /// <param name="info"></param>
        public void insert(TaskInfo info)
        {
            StringBuilder sql = new StringBuilder();

            sql.AppendLine("INSERT");
            sql.AppendLine("INTO");
            sql.AppendLine("TASK");
            sql.AppendLine("(UPDATED_AT");
            sql.AppendLine(",TITLE");
            sql.AppendLine(",TASK_DATE");
            sql.AppendLine(",TASK_STATUS");
            sql.AppendLine(",TASK_DETAIL)");
            sql.AppendLine("VALUES(");
            sql.AppendLine("GETDATE()");
            sql.AppendFormat(",'{0}'", info.Title);
            sql.AppendFormat(",'{0}'", info.TaskDate);
            sql.AppendFormat(",{0}", info.TaskStatus);
            sql.AppendFormat(",'{0}')", info.TaskDetail);

            datavaseIf.ExecuteSqlNonQuery(sql.ToString());

        }

        /// <summary>
        /// 検索
        /// </summary>
        /// <param name="word"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        public object select(string word, DateTime? startDate, DateTime? endDate, int status)
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("SELECT");
            sql.AppendLine("*");
            sql.AppendLine("FROM");
            sql.AppendLine("TASK");
            sql.AppendLine("WHERE");
            sql.AppendLine("1=1");
            if (startDate.HasValue)
            {
                sql.AppendFormat(" AND TASK_DATE >= '{0} 00:00'", startDate.Value.ToShortDateString());
            }
            if (endDate.HasValue)
            {
                sql.AppendFormat(" AND TASK_DATE <= '{0} 23:59'", endDate.Value.ToShortDateString());
            }
            if (!string.IsNullOrEmpty(word))
            {
                sql.AppendFormat(" AND (TITLE LIKE '%{0}%' OR TASK_DETAIL LIKE '%{0}%') ", word);
            }
            if (status > 0)
            {
                sql.AppendFormat(" AND TASK_STATUS = {0} ", status);
            }
            sql.AppendLine("ORDER BY");
            sql.AppendLine("TASK_DATE");
            return datavaseIf.ExecuteSql(sql.ToString());
        }
    
    }
}
