using MySql.Data.MySqlClient;
using System;
using System.Data.Common;
using System.Text;
using System.Windows.Forms;
namespace MysqlMonitor
{
    public partial class Mysql_Monitor : Form
    {
        public Mysql_Monitor()
        {
            InitializeComponent();
        }

        public string Str_Datetime = string.Empty;
        public MySqlConnection func_getmysqlcon()
        {
            string connStr = string.Concat(new string[]
            {
                "server=",
                this.txt_host.Text,
                ";user=",
                this.txt_user.Text,
                ";password=",
                this.txt_pass.Text,
                ";database=mysql"
            });
            return new MySqlConnection(connStr);
        }

        public DbDataReader func_getmysqlcom(string M_str_sqlstr)
        {
            MySqlConnection mySqlConnection = this.func_getmysqlcon();
            mySqlConnection.Open();
            MySqlCommand mySqlCommand = new MySqlCommand(M_str_sqlstr, mySqlConnection);
            return mySqlCommand.ExecuteReader();
        }

        private void Btn_start_Click(object sender, EventArgs e)
        {
            try
            {
                if (Str_Datetime == string.Empty)
                {
                    Str_Datetime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    BreakTime_toolStripStatusLabel.Text = "下断时间: " + Str_Datetime;
                }
                string m_str_sqlstr = "select event_time,argument from mysql.general_log where command_type='Query' and argument not like 'set global general_log=on;SET GLOBAL log_output%' and argument not like 'select event_time,argument from%' and event_time > '"+Str_Datetime+"' order by event_time desc";
                byte[] buffer = null;
                DbDataReader reader = func_getmysqlcom(m_str_sqlstr);
                this.dataGridView1.Rows.Clear();
                while (reader.Read())
                {
                    reader.Read();
                    long len = reader.GetBytes(1, 0, null, 0, 0);
                    buffer = new byte[len];
                    len = reader.GetBytes(1, 0, buffer, 0, (int)len);
                    string sql = Encoding.Default.GetString(buffer);
                    string[] array = { reader.GetString(0), sql };
                    this.dataGridView1.Rows.Add(array);
                }
                Counts_toolStripStatusLabel.Text = "行数: " + dataGridView1.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                Clipboard.SetDataObject(this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
            }
        }

        private void Breakpoint_btn_Click(object sender, EventArgs e)
        {
            try
            {
                this.func_getmysqlcom("set global general_log=on;SET GLOBAL log_output='table';");
                Str_Datetime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                BreakTime_toolStripStatusLabel.Text = "下断时间: " + Str_Datetime;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void 清空ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Clear();
        }
    }
}
