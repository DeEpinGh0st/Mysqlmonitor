using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace MysqlMonitor
{
    public partial class Mysql_Monitor : Form
    {
        public Mysql_Monitor()
        {
            InitializeComponent();
        }

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

        public int func_getmysqlcom(string M_str_sqlstr)
        {
            MySqlConnection mySqlConnection = this.func_getmysqlcon();
            mySqlConnection.Open();
            MySqlCommand mySqlCommand = new MySqlCommand(M_str_sqlstr, mySqlConnection);
            int result = mySqlCommand.ExecuteNonQuery();
            mySqlCommand.Dispose();
            mySqlConnection.Close();
            mySqlConnection.Dispose();
            return result;
        }

        public DataSet func_getmysqlread(string M_str_sqlstr)
        {
            MySqlConnection mySqlConnection = this.func_getmysqlcon();
            mySqlConnection.Open();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(M_str_sqlstr, mySqlConnection);
            DataSet dataSet = new DataSet();
            mySqlDataAdapter.Fill(dataSet);
            return dataSet;
        }

        private void Btn_start_Click(object sender, EventArgs e)
        {
            string Str_Datetime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            //try
            //{
            this.func_getmysqlcom("set global general_log=on;SET GLOBAL log_output='table';");
            string m_str_sqlstr = "select event_time,argument from mysql.general_log where command_type='Query' and argument not like 'set global general_log=on;SET GLOBAL log_output%' and argument not like 'select event_time,argument from%' and event_time > '" + Str_Datetime + "'";
            DataSet dataSet = this.func_getmysqlread(m_str_sqlstr);
            DataTableCollection tables = dataSet.Tables;
            DataView dataSource = new DataView(tables[0]);
            this.Bs = new BindingSource();
            this.Bs.DataSource = dataSource;
            this.dataGridView1.DataSource = this.Bs;
            this.dataGridView1.Columns[0].HeaderText = "查询时间";
            this.dataGridView1.Columns[1].HeaderText = "查询语句";
            this.dataGridView1.Columns[0].Width = 150;
            this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    //MessageBox.Show("数据库出错，请检查连接信息以及确认mysql版本在5.1.6以上", "提示");
            //}
        }

        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                Clipboard.SetDataObject(this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
            }
        }
    }
}
