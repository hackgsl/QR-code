namespace 二维码生成解析工具
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
            this.btnToQR = new System.Windows.Forms.Button();
            this.txtString = new System.Windows.Forms.TextBox();
            this.btnSaveQR = new System.Windows.Forms.Button();
            this.btnCodeQR = new System.Windows.Forms.Button();
            this.btnPasteQR = new System.Windows.Forms.Button();
            this.pictureBoxQR = new System.Windows.Forms.PictureBox();
            this.ccbBatch = new System.Windows.Forms.CheckBox();
            this.ccbCopy = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQR)).BeginInit();
            this.SuspendLayout();
            // 
            // btnToQR
            // 
            this.btnToQR.Location = new System.Drawing.Point(135, 121);
            this.btnToQR.Name = "btnToQR";
            this.btnToQR.Size = new System.Drawing.Size(75, 23);
            this.btnToQR.TabIndex = 0;
            this.btnToQR.Text = "生成二维码";
            this.btnToQR.UseVisualStyleBackColor = true;
            this.btnToQR.Click += new System.EventHandler(this.btnToQR_Click);
            // 
            // txtString
            // 
            this.txtString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtString.Location = new System.Drawing.Point(8, 4);
            this.txtString.Multiline = true;
            this.txtString.Name = "txtString";
            this.txtString.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtString.Size = new System.Drawing.Size(346, 111);
            this.txtString.TabIndex = 1;
            this.txtString.Text = "52破解\r\nby hackgsl";
            // 
            // btnSaveQR
            // 
            this.btnSaveQR.Location = new System.Drawing.Point(216, 121);
            this.btnSaveQR.Name = "btnSaveQR";
            this.btnSaveQR.Size = new System.Drawing.Size(75, 23);
            this.btnSaveQR.TabIndex = 2;
            this.btnSaveQR.Text = "保存二维码";
            this.btnSaveQR.UseVisualStyleBackColor = true;
            this.btnSaveQR.Click += new System.EventHandler(this.btnSaveQR_Click);
            // 
            // btnCodeQR
            // 
            this.btnCodeQR.Location = new System.Drawing.Point(135, 150);
            this.btnCodeQR.Name = "btnCodeQR";
            this.btnCodeQR.Size = new System.Drawing.Size(75, 23);
            this.btnCodeQR.TabIndex = 3;
            this.btnCodeQR.Text = "解析二维码";
            this.btnCodeQR.UseVisualStyleBackColor = true;
            this.btnCodeQR.Click += new System.EventHandler(this.btnCodeQR_Click);
            // 
            // btnPasteQR
            // 
            this.btnPasteQR.Location = new System.Drawing.Point(216, 150);
            this.btnPasteQR.Name = "btnPasteQR";
            this.btnPasteQR.Size = new System.Drawing.Size(75, 23);
            this.btnPasteQR.TabIndex = 4;
            this.btnPasteQR.Text = "粘贴二维码";
            this.btnPasteQR.UseVisualStyleBackColor = true;
            this.btnPasteQR.Click += new System.EventHandler(this.btnPasteQR_Click);
            // 
            // pictureBoxQR
            // 
            this.pictureBoxQR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxQR.Location = new System.Drawing.Point(2, 180);
            this.pictureBoxQR.Name = "pictureBoxQR";
            this.pictureBoxQR.Size = new System.Drawing.Size(361, 359);
            this.pictureBoxQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxQR.TabIndex = 5;
            this.pictureBoxQR.TabStop = false;
            // 
            // ccbBatch
            // 
            this.ccbBatch.AutoSize = true;
            this.ccbBatch.Location = new System.Drawing.Point(45, 125);
            this.ccbBatch.Name = "ccbBatch";
            this.ccbBatch.Size = new System.Drawing.Size(72, 16);
            this.ccbBatch.TabIndex = 6;
            this.ccbBatch.Text = "批量生成";
            this.ccbBatch.UseVisualStyleBackColor = true;
            // 
            // ccbCopy
            // 
            this.ccbCopy.AutoSize = true;
            this.ccbCopy.Location = new System.Drawing.Point(45, 154);
            this.ccbCopy.Name = "ccbCopy";
            this.ccbCopy.Size = new System.Drawing.Size(84, 16);
            this.ccbCopy.TabIndex = 7;
            this.ccbCopy.Text = "生成时复制";
            this.ccbCopy.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 541);
            this.Controls.Add(this.ccbCopy);
            this.Controls.Add(this.ccbBatch);
            this.Controls.Add(this.pictureBoxQR);
            this.Controls.Add(this.btnPasteQR);
            this.Controls.Add(this.btnCodeQR);
            this.Controls.Add(this.btnSaveQR);
            this.Controls.Add(this.txtString);
            this.Controls.Add(this.btnToQR);
            this.MinimumSize = new System.Drawing.Size(380, 580);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "二维码生成解析工具 by hackgsl 52pojie.cn";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnToQR;
        private System.Windows.Forms.TextBox txtString;
        private System.Windows.Forms.Button btnSaveQR;
        private System.Windows.Forms.Button btnCodeQR;
        private System.Windows.Forms.Button btnPasteQR;
        private System.Windows.Forms.PictureBox pictureBoxQR;
        private System.Windows.Forms.CheckBox ccbBatch;
        private System.Windows.Forms.CheckBox ccbCopy;
    }
}

