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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.InputFileLabel = new System.Windows.Forms.Label();
            this.InputFileTextBox = new System.Windows.Forms.TextBox();
            this.InputFileEncodingLabel = new System.Windows.Forms.Label();
            this.InputFileEncodingComboBox = new System.Windows.Forms.ComboBox();
            this.OutputFileEncodingComboBox = new System.Windows.Forms.ComboBox();
            this.OutputFileEncodingLabel = new System.Windows.Forms.Label();
            this.OutputFileTextBox = new System.Windows.Forms.TextBox();
            this.OutputFileLabel = new System.Windows.Forms.Label();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.InputFileButton = new System.Windows.Forms.Button();
            this.OutputFileButton = new System.Windows.Forms.Button();
            this.ClipBoardCopy = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.LineEndComboBox = new System.Windows.Forms.ComboBox();
            this.LineEnd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputFileLabel
            // 
            this.InputFileLabel.AutoSize = true;
            this.InputFileLabel.Location = new System.Drawing.Point(12, 17);
            this.InputFileLabel.Name = "InputFileLabel";
            this.InputFileLabel.Size = new System.Drawing.Size(53, 12);
            this.InputFileLabel.TabIndex = 0;
            this.InputFileLabel.Text = "입력파일";
            // 
            // InputFileTextBox
            // 
            this.InputFileTextBox.Location = new System.Drawing.Point(75, 14);
            this.InputFileTextBox.Name = "InputFileTextBox";
            this.InputFileTextBox.Size = new System.Drawing.Size(224, 21);
            this.InputFileTextBox.TabIndex = 1;
            // 
            // InputFileEncodingLabel
            // 
            this.InputFileEncodingLabel.AutoSize = true;
            this.InputFileEncodingLabel.Location = new System.Drawing.Point(12, 81);
            this.InputFileEncodingLabel.Name = "InputFileEncodingLabel";
            this.InputFileEncodingLabel.Size = new System.Drawing.Size(93, 12);
            this.InputFileEncodingLabel.TabIndex = 2;
            this.InputFileEncodingLabel.Text = "입력파일 인코딩";
            // 
            // InputFileEncodingComboBox
            // 
            this.InputFileEncodingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InputFileEncodingComboBox.FormattingEnabled = true;
            this.InputFileEncodingComboBox.Location = new System.Drawing.Point(111, 77);
            this.InputFileEncodingComboBox.Name = "InputFileEncodingComboBox";
            this.InputFileEncodingComboBox.Size = new System.Drawing.Size(121, 20);
            this.InputFileEncodingComboBox.TabIndex = 3;
            // 
            // OutputFileEncodingComboBox
            // 
            this.OutputFileEncodingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OutputFileEncodingComboBox.FormattingEnabled = true;
            this.OutputFileEncodingComboBox.Location = new System.Drawing.Point(111, 108);
            this.OutputFileEncodingComboBox.Name = "OutputFileEncodingComboBox";
            this.OutputFileEncodingComboBox.Size = new System.Drawing.Size(121, 20);
            this.OutputFileEncodingComboBox.TabIndex = 7;
            // 
            // OutputFileEncodingLabel
            // 
            this.OutputFileEncodingLabel.AutoSize = true;
            this.OutputFileEncodingLabel.Location = new System.Drawing.Point(12, 112);
            this.OutputFileEncodingLabel.Name = "OutputFileEncodingLabel";
            this.OutputFileEncodingLabel.Size = new System.Drawing.Size(93, 12);
            this.OutputFileEncodingLabel.TabIndex = 6;
            this.OutputFileEncodingLabel.Text = "출력파일 인코딩";
            // 
            // OutputFileTextBox
            // 
            this.OutputFileTextBox.Location = new System.Drawing.Point(75, 45);
            this.OutputFileTextBox.Name = "OutputFileTextBox";
            this.OutputFileTextBox.Size = new System.Drawing.Size(224, 21);
            this.OutputFileTextBox.TabIndex = 5;
            // 
            // OutputFileLabel
            // 
            this.OutputFileLabel.AutoSize = true;
            this.OutputFileLabel.Location = new System.Drawing.Point(12, 48);
            this.OutputFileLabel.Name = "OutputFileLabel";
            this.OutputFileLabel.Size = new System.Drawing.Size(53, 12);
            this.OutputFileLabel.TabIndex = 4;
            this.OutputFileLabel.Text = "출력파일";
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(273, 145);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(83, 23);
            this.ConvertButton.TabIndex = 8;
            this.ConvertButton.Text = "파일로 저장";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // InputFileButton
            // 
            this.InputFileButton.Location = new System.Drawing.Point(309, 14);
            this.InputFileButton.Name = "InputFileButton";
            this.InputFileButton.Size = new System.Drawing.Size(47, 23);
            this.InputFileButton.TabIndex = 9;
            this.InputFileButton.Text = "선택";
            this.InputFileButton.UseVisualStyleBackColor = true;
            this.InputFileButton.Click += new System.EventHandler(this.InputFileButton_Click);
            // 
            // OutputFileButton
            // 
            this.OutputFileButton.Location = new System.Drawing.Point(309, 43);
            this.OutputFileButton.Name = "OutputFileButton";
            this.OutputFileButton.Size = new System.Drawing.Size(47, 23);
            this.OutputFileButton.TabIndex = 10;
            this.OutputFileButton.Text = "선택";
            this.OutputFileButton.UseVisualStyleBackColor = true;
            this.OutputFileButton.Click += new System.EventHandler(this.OutputFileButton_Click);
            // 
            // ClipBoardCopy
            // 
            this.ClipBoardCopy.Location = new System.Drawing.Point(14, 145);
            this.ClipBoardCopy.Name = "ClipBoardCopy";
            this.ClipBoardCopy.Size = new System.Drawing.Size(110, 23);
            this.ClipBoardCopy.TabIndex = 11;
            this.ClipBoardCopy.Text = "파일⇒클립보드";
            this.ClipBoardCopy.UseVisualStyleBackColor = true;
            this.ClipBoardCopy.Click += new System.EventHandler(this.ClipBoardCopy_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "클립보드⇒클립보드";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LineEndComboBox
            // 
            this.LineEndComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LineEndComboBox.FormattingEnabled = true;
            this.LineEndComboBox.Location = new System.Drawing.Point(301, 77);
            this.LineEndComboBox.Name = "LineEndComboBox";
            this.LineEndComboBox.Size = new System.Drawing.Size(55, 20);
            this.LineEndComboBox.TabIndex = 13;
            // 
            // LineEnd
            // 
            this.LineEnd.AutoSize = true;
            this.LineEnd.Location = new System.Drawing.Point(246, 81);
            this.LineEnd.Name = "LineEnd";
            this.LineEnd.Size = new System.Drawing.Size(53, 12);
            this.LineEnd.TabIndex = 14;
            this.LineEnd.Text = "개행종류";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 176);
            this.Controls.Add(this.LineEnd);
            this.Controls.Add(this.LineEndComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ClipBoardCopy);
            this.Controls.Add(this.OutputFileButton);
            this.Controls.Add(this.InputFileButton);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.OutputFileEncodingComboBox);
            this.Controls.Add(this.OutputFileEncodingLabel);
            this.Controls.Add(this.OutputFileTextBox);
            this.Controls.Add(this.OutputFileLabel);
            this.Controls.Add(this.InputFileEncodingComboBox);
            this.Controls.Add(this.InputFileEncodingLabel);
            this.Controls.Add(this.InputFileTextBox);
            this.Controls.Add(this.InputFileLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "HTML문자열형식변환";
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
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.Button InputFileButton;
        private System.Windows.Forms.Button OutputFileButton;
        private System.Windows.Forms.Button ClipBoardCopy;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox LineEndComboBox;
        private System.Windows.Forms.Label LineEnd;
    }
}

