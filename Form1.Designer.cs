namespace MysqlMonitor
{
    partial class Mysql_Monitor
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Breakpoint_btn = new System.Windows.Forms.Button();
            this.txt_searchkey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_start = new System.Windows.Forms.Button();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_host = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Querytime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Queryvalue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.BreakTime_toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Counts_toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.清空ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Breakpoint_btn);
            this.groupBox1.Controls.Add(this.txt_searchkey);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Btn_start);
            this.groupBox1.Controls.Add(this.txt_pass);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_user);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_host);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(867, 52);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "配置";
            // 
            // Breakpoint_btn
            // 
            this.Breakpoint_btn.Location = new System.Drawing.Point(473, 19);
            this.Breakpoint_btn.Name = "Breakpoint_btn";
            this.Breakpoint_btn.Size = new System.Drawing.Size(75, 23);
            this.Breakpoint_btn.TabIndex = 9;
            this.Breakpoint_btn.Text = "下断";
            this.Breakpoint_btn.UseVisualStyleBackColor = true;
            this.Breakpoint_btn.Click += new System.EventHandler(this.Breakpoint_btn_Click);
            // 
            // txt_searchkey
            // 
            this.txt_searchkey.Location = new System.Drawing.Point(672, 20);
            this.txt_searchkey.Name = "txt_searchkey";
            this.txt_searchkey.Size = new System.Drawing.Size(180, 21);
            this.txt_searchkey.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(638, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "搜索";
            // 
            // Btn_start
            // 
            this.Btn_start.Location = new System.Drawing.Point(557, 19);
            this.Btn_start.Name = "Btn_start";
            this.Btn_start.Size = new System.Drawing.Size(75, 23);
            this.Btn_start.TabIndex = 6;
            this.Btn_start.Text = "更新";
            this.Btn_start.UseVisualStyleBackColor = true;
            this.Btn_start.Click += new System.EventHandler(this.Btn_start_Click);
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(375, 20);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(91, 21);
            this.txt_pass.TabIndex = 5;
            this.txt_pass.Text = "root";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "密码";
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(238, 20);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(94, 21);
            this.txt_user.TabIndex = 3;
            this.txt_user.Text = "root";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "用户名";
            // 
            // txt_host
            // 
            this.txt_host.Location = new System.Drawing.Point(45, 20);
            this.txt_host.Name = "txt_host";
            this.txt_host.Size = new System.Drawing.Size(140, 21);
            this.txt_host.TabIndex = 1;
            this.txt_host.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "主机";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Querytime,
            this.Queryvalue});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(867, 381);
            this.dataGridView1.TabIndex = 1;
            // 
            // Querytime
            // 
            this.Querytime.HeaderText = "查询时间";
            this.Querytime.Name = "Querytime";
            this.Querytime.ReadOnly = true;
            this.Querytime.Width = 150;
            // 
            // Queryvalue
            // 
            this.Queryvalue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Queryvalue.HeaderText = "查询语句";
            this.Queryvalue.Name = "Queryvalue";
            this.Queryvalue.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.复制ToolStripMenuItem,
            this.清空ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 48);
            // 
            // 复制ToolStripMenuItem
            // 
            this.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem";
            this.复制ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.复制ToolStripMenuItem.Text = "复制查询语句";
            this.复制ToolStripMenuItem.Click += new System.EventHandler(this.复制ToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BreakTime_toolStripStatusLabel,
            this.Counts_toolStripStatusLabel,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 455);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(892, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // BreakTime_toolStripStatusLabel
            // 
            this.BreakTime_toolStripStatusLabel.Name = "BreakTime_toolStripStatusLabel";
            this.BreakTime_toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // Counts_toolStripStatusLabel
            // 
            this.Counts_toolStripStatusLabel.Name = "Counts_toolStripStatusLabel";
            this.Counts_toolStripStatusLabel.Size = new System.Drawing.Size(683, 17);
            this.Counts_toolStripStatusLabel.Spring = true;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(194, 17);
            this.toolStripStatusLabel3.Text = "代码参考自：Seay Mysql监控插件";
            // 
            // 清空ToolStripMenuItem
            // 
            this.清空ToolStripMenuItem.Name = "清空ToolStripMenuItem";
            this.清空ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.清空ToolStripMenuItem.Text = "清空";
            this.清空ToolStripMenuItem.Click += new System.EventHandler(this.清空ToolStripMenuItem_Click);
            // 
            // Mysql_Monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 477);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Mysql_Monitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mysql Monitor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_searchkey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_start;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_host;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 复制ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Querytime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Queryvalue;
        private System.Windows.Forms.Button Breakpoint_btn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel BreakTime_toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel Counts_toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripMenuItem 清空ToolStripMenuItem;
    }
}

