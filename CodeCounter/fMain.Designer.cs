namespace CodeCounter
{
    partial class fMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbRule = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lvResults = new System.Windows.Forms.ListView();
            this.cbSub = new System.Windows.Forms.CheckBox();
            this.tbDirectory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbTotal = new System.Windows.Forms.Label();
            this.cbShowdirectory = new System.Windows.Forms.CheckBox();
            this.cbRules = new System.Windows.Forms.ComboBox();
            this.lbRule = new System.Windows.Forms.Label();
            this.fbdDirectory = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // tbRule
            // 
            this.tbRule.Location = new System.Drawing.Point(12, 96);
            this.tbRule.Multiline = true;
            this.tbRule.Name = "tbRule";
            this.tbRule.Size = new System.Drawing.Size(311, 187);
            this.tbRule.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(311, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "탐색";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lvResults
            // 
            this.lvResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvResults.FullRowSelect = true;
            this.lvResults.GridLines = true;
            this.lvResults.Location = new System.Drawing.Point(329, 42);
            this.lvResults.Name = "lvResults";
            this.lvResults.Size = new System.Drawing.Size(351, 241);
            this.lvResults.TabIndex = 2;
            this.lvResults.UseCompatibleStateImageBehavior = false;
            this.lvResults.View = System.Windows.Forms.View.Details;
            // 
            // cbSub
            // 
            this.cbSub.AutoSize = true;
            this.cbSub.Checked = true;
            this.cbSub.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSub.Location = new System.Drawing.Point(12, 42);
            this.cbSub.Name = "cbSub";
            this.cbSub.Size = new System.Drawing.Size(130, 19);
            this.cbSub.TabIndex = 3;
            this.cbSub.Text = "하위 폴더까지 검사";
            this.cbSub.UseVisualStyleBackColor = true;
            // 
            // tbDirectory
            // 
            this.tbDirectory.Location = new System.Drawing.Point(57, 13);
            this.tbDirectory.Name = "tbDirectory";
            this.tbDirectory.Size = new System.Drawing.Size(185, 23);
            this.tbDirectory.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "경로 : ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(248, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "찾기";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "경로";
            this.columnHeader1.Width = 215;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "줄";
            this.columnHeader2.Width = 103;
            // 
            // lbTotal
            // 
            this.lbTotal.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.lbTotal.Location = new System.Drawing.Point(329, 289);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(351, 27);
            this.lbTotal.TabIndex = 7;
            this.lbTotal.Text = "검색 결과 없음";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbShowdirectory
            // 
            this.cbShowdirectory.AutoSize = true;
            this.cbShowdirectory.Checked = true;
            this.cbShowdirectory.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowdirectory.Location = new System.Drawing.Point(332, 15);
            this.cbShowdirectory.Name = "cbShowdirectory";
            this.cbShowdirectory.Size = new System.Drawing.Size(102, 19);
            this.cbShowdirectory.TabIndex = 8;
            this.cbShowdirectory.Text = "경로까지 표시";
            this.cbShowdirectory.UseVisualStyleBackColor = true;
            this.cbShowdirectory.CheckedChanged += new System.EventHandler(this.cbShowdirectory_CheckedChanged);
            // 
            // cbRules
            // 
            this.cbRules.FormattingEnabled = true;
            this.cbRules.Items.AddRange(new object[] {
            "커스텀",
            "C",
            "C++",
            "C#",
            "Haskell"});
            this.cbRules.Location = new System.Drawing.Point(57, 67);
            this.cbRules.Name = "cbRules";
            this.cbRules.Size = new System.Drawing.Size(266, 23);
            this.cbRules.TabIndex = 9;
            this.cbRules.Text = "커스텀";
            this.cbRules.SelectedIndexChanged += new System.EventHandler(this.cbRules_SelectedIndexChanged);
            // 
            // lbRule
            // 
            this.lbRule.AutoSize = true;
            this.lbRule.Location = new System.Drawing.Point(9, 70);
            this.lbRule.Name = "lbRule";
            this.lbRule.Size = new System.Drawing.Size(42, 15);
            this.lbRule.TabIndex = 10;
            this.lbRule.Text = "규칙 : ";
            // 
            // fbdDirectory
            // 
            this.fbdDirectory.HelpRequest += new System.EventHandler(this.fbdDirectory_HelpRequest);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 328);
            this.Controls.Add(this.lbRule);
            this.Controls.Add(this.cbRules);
            this.Controls.Add(this.cbShowdirectory);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDirectory);
            this.Controls.Add(this.cbSub);
            this.Controls.Add(this.lvResults);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbRule);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fMain";
            this.Text = "코드 카운터";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRule;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView lvResults;
        private System.Windows.Forms.CheckBox cbSub;
        private System.Windows.Forms.TextBox tbDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.CheckBox cbShowdirectory;
        private System.Windows.Forms.ComboBox cbRules;
        private System.Windows.Forms.Label lbRule;
        private System.Windows.Forms.FolderBrowserDialog fbdDirectory;
    }
}

