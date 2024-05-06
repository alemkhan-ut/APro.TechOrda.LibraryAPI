namespace Library.WinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TitleText = new Label();
            DescText = new Label();
            AuthorText = new Label();
            PublishDateText = new Label();
            ApiButton = new Button();
            SuspendLayout();
            // 
            // TitleText
            // 
            TitleText.AutoSize = true;
            TitleText.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            TitleText.Location = new Point(144, 23);
            TitleText.Name = "TitleText";
            TitleText.Size = new Size(206, 54);
            TitleText.TabIndex = 0;
            TitleText.Text = "ЗАГРУЗКА";
            // 
            // DescText
            // 
            DescText.AutoSize = true;
            DescText.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            DescText.Location = new Point(12, 96);
            DescText.Name = "DescText";
            DescText.Size = new Size(103, 28);
            DescText.TabIndex = 1;
            DescText.Text = "ЗАГРУЗКА";
            // 
            // AuthorText
            // 
            AuthorText.AutoSize = true;
            AuthorText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AuthorText.Location = new Point(12, 32);
            AuthorText.Name = "AuthorText";
            AuthorText.Size = new Size(83, 21);
            AuthorText.TabIndex = 2;
            AuthorText.Text = "ЗАГРУЗКА";
            // 
            // PublishDateText
            // 
            PublishDateText.AutoSize = true;
            PublishDateText.Location = new Point(12, 62);
            PublishDateText.Name = "PublishDateText";
            PublishDateText.Size = new Size(64, 15);
            PublishDateText.TabIndex = 3;
            PublishDateText.Text = "ЗАГРУЗКА";
            // 
            // ApiButton
            // 
            ApiButton.Location = new Point(81, 385);
            ApiButton.Name = "ApiButton";
            ApiButton.Size = new Size(199, 53);
            ApiButton.TabIndex = 4;
            ApiButton.Text = "ЗАГРУЗИТЬ";
            ApiButton.UseVisualStyleBackColor = true;
            ApiButton.Click += ApiButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 450);
            Controls.Add(ApiButton);
            Controls.Add(PublishDateText);
            Controls.Add(AuthorText);
            Controls.Add(DescText);
            Controls.Add(TitleText);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TitleText;
        private Label DescText;
        private Label AuthorText;
        private Label PublishDateText;
        private Button ApiButton;
    }
}