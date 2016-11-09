namespace WinGenerRandomString
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chkLowerChar = new System.Windows.Forms.CheckBox();
            this.chkUpperChar = new System.Windows.Forms.CheckBox();
            this.chkNumber = new System.Windows.Forms.CheckBox();
            this.chkSpecialChar = new System.Windows.Forms.CheckBox();
            this.chkChineseChar = new System.Windows.Forms.CheckBox();
            this.chkHasNotSameChar = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAmout = new System.Windows.Forms.TextBox();
            this.btnBuild = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblElapsed = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkLowerChar
            // 
            this.chkLowerChar.AutoSize = true;
            this.chkLowerChar.Checked = true;
            this.chkLowerChar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLowerChar.Location = new System.Drawing.Point(23, 29);
            this.chkLowerChar.Name = "chkLowerChar";
            this.chkLowerChar.Size = new System.Drawing.Size(72, 16);
            this.chkLowerChar.TabIndex = 0;
            this.chkLowerChar.Text = "小写字母";
            this.chkLowerChar.UseVisualStyleBackColor = true;
            // 
            // chkUpperChar
            // 
            this.chkUpperChar.AutoSize = true;
            this.chkUpperChar.Checked = true;
            this.chkUpperChar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUpperChar.Location = new System.Drawing.Point(107, 29);
            this.chkUpperChar.Name = "chkUpperChar";
            this.chkUpperChar.Size = new System.Drawing.Size(72, 16);
            this.chkUpperChar.TabIndex = 0;
            this.chkUpperChar.Text = "大写字母";
            this.chkUpperChar.UseVisualStyleBackColor = true;
            // 
            // chkNumber
            // 
            this.chkNumber.AutoSize = true;
            this.chkNumber.Checked = true;
            this.chkNumber.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNumber.Location = new System.Drawing.Point(191, 29);
            this.chkNumber.Name = "chkNumber";
            this.chkNumber.Size = new System.Drawing.Size(48, 16);
            this.chkNumber.TabIndex = 0;
            this.chkNumber.Text = "数字";
            this.chkNumber.UseVisualStyleBackColor = true;
            // 
            // chkSpecialChar
            // 
            this.chkSpecialChar.AutoSize = true;
            this.chkSpecialChar.Location = new System.Drawing.Point(23, 60);
            this.chkSpecialChar.Name = "chkSpecialChar";
            this.chkSpecialChar.Size = new System.Drawing.Size(72, 16);
            this.chkSpecialChar.TabIndex = 0;
            this.chkSpecialChar.Text = "特殊字符";
            this.chkSpecialChar.UseVisualStyleBackColor = true;
            // 
            // chkChineseChar
            // 
            this.chkChineseChar.AutoSize = true;
            this.chkChineseChar.Location = new System.Drawing.Point(107, 60);
            this.chkChineseChar.Name = "chkChineseChar";
            this.chkChineseChar.Size = new System.Drawing.Size(48, 16);
            this.chkChineseChar.TabIndex = 0;
            this.chkChineseChar.Text = "中文";
            this.chkChineseChar.UseVisualStyleBackColor = true;
            // 
            // chkHasNotSameChar
            // 
            this.chkHasNotSameChar.AutoSize = true;
            this.chkHasNotSameChar.Checked = true;
            this.chkHasNotSameChar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHasNotSameChar.Location = new System.Drawing.Point(308, 29);
            this.chkHasNotSameChar.Name = "chkHasNotSameChar";
            this.chkHasNotSameChar.Size = new System.Drawing.Size(120, 16);
            this.chkHasNotSameChar.TabIndex = 0;
            this.chkHasNotSameChar.Text = "不允许有重复字符";
            this.chkHasNotSameChar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkUpperChar);
            this.groupBox1.Controls.Add(this.chkLowerChar);
            this.groupBox1.Controls.Add(this.chkChineseChar);
            this.groupBox1.Controls.Add(this.chkNumber);
            this.groupBox1.Controls.Add(this.chkSpecialChar);
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "包含的内容";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "字符串的长度";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(395, 60);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 21);
            this.txtLength.TabIndex = 3;
            this.txtLength.Text = "6";
            this.txtLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "字符串的数量";
            // 
            // txtAmout
            // 
            this.txtAmout.Location = new System.Drawing.Point(395, 87);
            this.txtAmout.Name = "txtAmout";
            this.txtAmout.Size = new System.Drawing.Size(100, 21);
            this.txtAmout.TabIndex = 3;
            this.txtAmout.Text = "1000000";
            this.txtAmout.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBuild
            // 
            this.btnBuild.Location = new System.Drawing.Point(308, 140);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(75, 23);
            this.btnBuild.TabIndex = 4;
            this.btnBuild.Text = "生成";
            this.btnBuild.UseVisualStyleBackColor = true;
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "用时：";
            // 
            // lblElapsed
            // 
            this.lblElapsed.AutoSize = true;
            this.lblElapsed.Location = new System.Drawing.Point(126, 145);
            this.lblElapsed.Name = "lblElapsed";
            this.lblElapsed.Size = new System.Drawing.Size(89, 12);
            this.lblElapsed.TabIndex = 2;
            this.lblElapsed.Text = "00000000000000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "秒";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "老申的工具";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnBuild;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 224);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBuild);
            this.Controls.Add(this.txtAmout);
            this.Controls.Add(this.lblElapsed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkHasNotSameChar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "生成随机字符串";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkLowerChar;
        private System.Windows.Forms.CheckBox chkUpperChar;
        private System.Windows.Forms.CheckBox chkNumber;
        private System.Windows.Forms.CheckBox chkSpecialChar;
        private System.Windows.Forms.CheckBox chkChineseChar;
        private System.Windows.Forms.CheckBox chkHasNotSameChar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAmout;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblElapsed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;

    }
}

