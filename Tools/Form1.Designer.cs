namespace Tools
{
    partial class Form1
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
            this.ServicePathTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnInstall = new System.Windows.Forms.Button();
            this.BtnUnInstall = new System.Windows.Forms.Button();
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ServicePathTxt
            // 
            this.ServicePathTxt.Location = new System.Drawing.Point(210, 23);
            this.ServicePathTxt.Name = "ServicePathTxt";
            this.ServicePathTxt.Size = new System.Drawing.Size(503, 21);
            this.ServicePathTxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(83, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "安装服务路径：";
            // 
            // BtnInstall
            // 
            this.BtnInstall.Location = new System.Drawing.Point(86, 61);
            this.BtnInstall.Name = "BtnInstall";
            this.BtnInstall.Size = new System.Drawing.Size(75, 23);
            this.BtnInstall.TabIndex = 2;
            this.BtnInstall.Text = "Install";
            this.BtnInstall.UseVisualStyleBackColor = true;
            this.BtnInstall.Click += new System.EventHandler(this.BtnInstall_Click);
            // 
            // BtnUnInstall
            // 
            this.BtnUnInstall.Location = new System.Drawing.Point(210, 61);
            this.BtnUnInstall.Name = "BtnUnInstall";
            this.BtnUnInstall.Size = new System.Drawing.Size(75, 23);
            this.BtnUnInstall.TabIndex = 3;
            this.BtnUnInstall.Text = "UnStall";
            this.BtnUnInstall.UseVisualStyleBackColor = true;
            this.BtnUnInstall.Click += new System.EventHandler(this.BtnUnInstall_Click);
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(340, 61);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(75, 23);
            this.BtnStart.TabIndex = 4;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.Location = new System.Drawing.Point(474, 61);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(75, 23);
            this.BtnStop.TabIndex = 5;
            this.BtnStop.Text = "Stop";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 127);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.BtnUnInstall);
            this.Controls.Add(this.BtnInstall);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ServicePathTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ServicePathTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnInstall;
        private System.Windows.Forms.Button BtnUnInstall;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button BtnStop;
    }
}

