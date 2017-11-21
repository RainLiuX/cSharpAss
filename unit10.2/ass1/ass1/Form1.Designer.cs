namespace ass1 {
    partial class Form1 {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.nameLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.ageText = new System.Windows.Forms.TextBox();
            this.feRadio = new System.Windows.Forms.RadioButton();
            this.maleRadio = new System.Windows.Forms.RadioButton();
            this.departLabel = new System.Windows.Forms.Label();
            this.degreeLabel = new System.Windows.Forms.Label();
            this.showList = new System.Windows.Forms.ListBox();
            this.departList = new System.Windows.Forms.ListBox();
            this.degreeCombo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(34, 22);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(52, 15);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "姓名：";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(34, 69);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(52, 15);
            this.ageLabel.TabIndex = 1;
            this.ageLabel.Text = "年龄：";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(34, 118);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(52, 15);
            this.genderLabel.TabIndex = 2;
            this.genderLabel.Text = "性别：";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(109, 12);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(115, 25);
            this.nameText.TabIndex = 3;
            // 
            // ageText
            // 
            this.ageText.Location = new System.Drawing.Point(109, 59);
            this.ageText.Name = "ageText";
            this.ageText.Size = new System.Drawing.Size(115, 25);
            this.ageText.TabIndex = 4;
            // 
            // feRadio
            // 
            this.feRadio.AutoSize = true;
            this.feRadio.Location = new System.Drawing.Point(181, 113);
            this.feRadio.Name = "feRadio";
            this.feRadio.Size = new System.Drawing.Size(43, 19);
            this.feRadio.TabIndex = 5;
            this.feRadio.TabStop = true;
            this.feRadio.Text = "女";
            this.feRadio.UseVisualStyleBackColor = true;
            // 
            // maleRadio
            // 
            this.maleRadio.AutoSize = true;
            this.maleRadio.Location = new System.Drawing.Point(109, 114);
            this.maleRadio.Name = "maleRadio";
            this.maleRadio.Size = new System.Drawing.Size(43, 19);
            this.maleRadio.TabIndex = 6;
            this.maleRadio.TabStop = true;
            this.maleRadio.Text = "男";
            this.maleRadio.UseVisualStyleBackColor = true;
            // 
            // departLabel
            // 
            this.departLabel.AutoSize = true;
            this.departLabel.Location = new System.Drawing.Point(248, 15);
            this.departLabel.Name = "departLabel";
            this.departLabel.Size = new System.Drawing.Size(82, 15);
            this.departLabel.TabIndex = 7;
            this.departLabel.Text = "工作部门：";
            // 
            // degreeLabel
            // 
            this.degreeLabel.AutoSize = true;
            this.degreeLabel.Location = new System.Drawing.Point(248, 113);
            this.degreeLabel.Name = "degreeLabel";
            this.degreeLabel.Size = new System.Drawing.Size(52, 15);
            this.degreeLabel.TabIndex = 8;
            this.degreeLabel.Text = "学历：";
            // 
            // showList
            // 
            this.showList.FormattingEnabled = true;
            this.showList.ItemHeight = 15;
            this.showList.Location = new System.Drawing.Point(37, 156);
            this.showList.Name = "showList";
            this.showList.Size = new System.Drawing.Size(449, 124);
            this.showList.TabIndex = 9;
            // 
            // departList
            // 
            this.departList.FormattingEnabled = true;
            this.departList.ItemHeight = 15;
            this.departList.Items.AddRange(new object[] {
            "研发部",
            "销售部",
            "财务部"});
            this.departList.Location = new System.Drawing.Point(336, 12);
            this.departList.Name = "departList";
            this.departList.Size = new System.Drawing.Size(150, 79);
            this.departList.TabIndex = 10;
            // 
            // degreeCombo
            // 
            this.degreeCombo.FormattingEnabled = true;
            this.degreeCombo.Items.AddRange(new object[] {
            "小学",
            "初中",
            "高中",
            "专科",
            "本科",
            "研究生及以上"});
            this.degreeCombo.Location = new System.Drawing.Point(336, 110);
            this.degreeCombo.Name = "degreeCombo";
            this.degreeCombo.Size = new System.Drawing.Size(150, 23);
            this.degreeCombo.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "录入";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(345, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "删除";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 346);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.degreeCombo);
            this.Controls.Add(this.departList);
            this.Controls.Add(this.showList);
            this.Controls.Add(this.degreeLabel);
            this.Controls.Add(this.departLabel);
            this.Controls.Add(this.maleRadio);
            this.Controls.Add(this.feRadio);
            this.Controls.Add(this.ageText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox ageText;
        private System.Windows.Forms.RadioButton feRadio;
        private System.Windows.Forms.RadioButton maleRadio;
        private System.Windows.Forms.Label departLabel;
        private System.Windows.Forms.Label degreeLabel;
        private System.Windows.Forms.ListBox showList;
        private System.Windows.Forms.ListBox departList;
        private System.Windows.Forms.ComboBox degreeCombo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

