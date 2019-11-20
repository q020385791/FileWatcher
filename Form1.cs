using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileWatcher
{
    public partial class Form1 : Form
    {
        FileSystemWatcher fsw;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //要監控的資料夾
            fsw = new FileSystemWatcher(@"D:\Test");
            btnWatchStart.Enabled = true;
            btnWatchStop.Enabled = false;
        }
        private void btnWatchStart_Click(object sender, EventArgs e)
        {
            //是否監控子目錄
            fsw.IncludeSubdirectories = true;

            //設定所要監控的變更類型
            //不註明就是全部都監控
            fsw.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName;

            //設定所要監控的檔案,ex:*.txt
            fsw.Filter = "*.txt";

            //Created, Changed, Deleted, Renamed....更多可上msdn查詢
            fsw.Created += new FileSystemEventHandler(fsw_Created);


            fsw.Renamed+= new RenamedEventHandler(fsw_ReName);
            fsw.Changed += new FileSystemEventHandler(fsw_Change);
            //允許觸發事件
            fsw.EnableRaisingEvents = true;

            btnWatchStart.Enabled = false;
            btnWatchStop.Enabled = true;
        }
        private void btnWatchStop_Click(object sender, EventArgs e)
        {
            fsw.EnableRaisingEvents = false;
            fsw.Created -= new FileSystemEventHandler(fsw_Created);
            fsw.Renamed -= new RenamedEventHandler(fsw_ReName);
            fsw.Changed -= new FileSystemEventHandler(fsw_Change);
            fsw.Dispose();
            btnWatchStop.Enabled = false;
            btnWatchStart.Enabled = true;
        }
        private void fsw_Created(object sender, FileSystemEventArgs e)
        {
            MessageBox.Show(e.Name + "  " + e.ChangeType + "  " + e.FullPath);
        }

        private void fsw_ReName(object sender, FileSystemEventArgs e)
        {
            MessageBox.Show(e.Name + "  " + e.ChangeType + "  " + e.FullPath);
        }
        private void fsw_Change(object sender, FileSystemEventArgs e)
        {
            MessageBox.Show(e.Name + "  " + e.ChangeType + "  " + e.FullPath);
        }
    }
}
