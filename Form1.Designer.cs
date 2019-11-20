namespace FileWatcher
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnWatchStart = new System.Windows.Forms.Button();
            this.btnWatchStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWatchStart
            // 
            this.btnWatchStart.Location = new System.Drawing.Point(40, 339);
            this.btnWatchStart.Name = "btnWatchStart";
            this.btnWatchStart.Size = new System.Drawing.Size(115, 44);
            this.btnWatchStart.TabIndex = 0;
            this.btnWatchStart.Text = "Start";
            this.btnWatchStart.UseVisualStyleBackColor = true;
            this.btnWatchStart.Click += new System.EventHandler(this.btnWatchStart_Click);
            // 
            // btnWatchStop
            // 
            this.btnWatchStop.Location = new System.Drawing.Point(282, 339);
            this.btnWatchStop.Name = "btnWatchStop";
            this.btnWatchStop.Size = new System.Drawing.Size(115, 43);
            this.btnWatchStop.TabIndex = 1;
            this.btnWatchStop.Text = "Stop";
            this.btnWatchStop.UseVisualStyleBackColor = true;
            this.btnWatchStop.Click += new System.EventHandler(this.btnWatchStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnWatchStop);
            this.Controls.Add(this.btnWatchStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWatchStart;
        private System.Windows.Forms.Button btnWatchStop;
    }
}

