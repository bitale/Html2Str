namespace Html2Str
{
    partial class Form1
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
            this.InputFileLabel = new System.Windows.Forms.Label();
            this.InputFileTextBox = new System.Windows.Forms.TextBox();
            this.InputFileEncodingLabel = new System.Windows.Forms.Label();
            this.InputFileEncodingComboBox = new System.Windows.Forms.ComboBox();
            this.OutputFileEncodingComboBox = new System.Windows.Forms.ComboBox();
            this.OutputFileEncodingLabel = new System.Windows.Forms.Label();
            this.OutputFileTextBox = new System.Windows.Forms.TextBox();
            this.OutputFileLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputFileLabel
            // 
            this.InputFileLabel.AutoSize = true;
            this.InputFileLabel.Location = new System.Drawing.Point(25, 17);
            this.InputFileLabel.Name = "InputFileLabel";
            this.InputFileLabel.Size = new System.Drawing.Size(53, 12);
            this.InputFileLabel.TabIndex = 0;
            this.InputFileLabel.Text = "입력파일";
            // 
            // InputFileTextBox
            // 
            this.InputFileTextBox.Location = new System.Drawing.Point(101, 14);
            this.InputFileTextBox.Name = "InputFileTextBox";
            this.InputFileTextBox.Size = new System.Drawing.Size(211, 21);
            this.InputFileTextBox.TabIndex = 1;
            // 
            // InputFileEncodingLabel
            // 
            this.InputFileEncodingLabel.AutoSize = true;
            this.InputFileEncodingLabel.Location = new System.Drawing.Point(323, 18);
            this.InputFileEncodingLabel.Name = "InputFileEncodingLabel";
            this.InputFileEncodingLabel.Size = new System.Drawing.Size(93, 12);
            this.InputFileEncodingLabel.TabIndex = 2;
            this.InputFileEncodingLabel.Text = "입력파일 인코딩";
            // 
            // InputFileEncodingComboBox
            // 
            this.InputFileEncodingComboBox.FormattingEnabled = true;
            this.InputFileEncodingComboBox.Items.AddRange(new object[] {
            "ASCII",
            "UTF-8",
            "UTF-16"});
            this.InputFileEncodingComboBox.Location = new System.Drawing.Point(422, 14);
            this.InputFileEncodingComboBox.Name = "InputFileEncodingComboBox";
            this.InputFileEncodingComboBox.Size = new System.Drawing.Size(121, 20);
            this.InputFileEncodingComboBox.TabIndex = 3;
            // 
            // OutputFileEncodingComboBox
            // 
            this.OutputFileEncodingComboBox.FormattingEnabled = true;
            this.OutputFileEncodingComboBox.Items.AddRange(new object[] {
            "ASCII",
            "UTF-8",
            "UTF-16"});
            this.OutputFileEncodingComboBox.Location = new System.Drawing.Point(422, 45);
            this.OutputFileEncodingComboBox.Name = "OutputFileEncodingComboBox";
            this.OutputFileEncodingComboBox.Size = new System.Drawing.Size(121, 20);
            this.OutputFileEncodingComboBox.TabIndex = 7;
            // 
            // OutputFileEncodingLabel
            // 
            this.OutputFileEncodingLabel.AutoSize = true;
            this.OutputFileEncodingLabel.Location = new System.Drawing.Point(323, 49);
            this.OutputFileEncodingLabel.Name = "OutputFileEncodingLabel";
            this.OutputFileEncodingLabel.Size = new System.Drawing.Size(93, 12);
            this.OutputFileEncodingLabel.TabIndex = 6;
            this.OutputFileEncodingLabel.Text = "출력파일 인코딩";
            // 
            // OutputFileTextBox
            // 
            this.OutputFileTextBox.Location = new System.Drawing.Point(101, 45);
            this.OutputFileTextBox.Name = "OutputFileTextBox";
            this.OutputFileTextBox.Size = new System.Drawing.Size(211, 21);
            this.OutputFileTextBox.TabIndex = 5;
            // 
            // OutputFileLabel
            // 
            this.OutputFileLabel.AutoSize = true;
            this.OutputFileLabel.Location = new System.Drawing.Point(25, 48);
            this.OutputFileLabel.Name = "OutputFileLabel";
            this.OutputFileLabel.Size = new System.Drawing.Size(53, 12);
            this.OutputFileLabel.TabIndex = 4;
            this.OutputFileLabel.Text = "출력파일";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(255, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "변환";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 126);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OutputFileEncodingComboBox);
            this.Controls.Add(this.OutputFileEncodingLabel);
            this.Controls.Add(this.OutputFileTextBox);
            this.Controls.Add(this.OutputFileLabel);
            this.Controls.Add(this.InputFileEncodingComboBox);
            this.Controls.Add(this.InputFileEncodingLabel);
            this.Controls.Add(this.InputFileTextBox);
            this.Controls.Add(this.InputFileLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InputFileLabel;
        private System.Windows.Forms.TextBox InputFileTextBox;
        private System.Windows.Forms.Label InputFileEncodingLabel;
        private System.Windows.Forms.ComboBox InputFileEncodingComboBox;
        private System.Windows.Forms.ComboBox OutputFileEncodingComboBox;
        private System.Windows.Forms.Label OutputFileEncodingLabel;
        private System.Windows.Forms.TextBox OutputFileTextBox;
        private System.Windows.Forms.Label OutputFileLabel;
        private System.Windows.Forms.Button button1;
    }
}

