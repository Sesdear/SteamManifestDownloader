namespace SteamGamesTool
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
            DownloadButton = new Button();
            label = new Label();
            appIdTextBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // DownloadButton
            // 
            DownloadButton.Font = new Font("Segoe UI", 8F);
            DownloadButton.Location = new Point(70, 56);
            DownloadButton.Name = "DownloadButton";
            DownloadButton.Size = new Size(135, 23);
            DownloadButton.TabIndex = 0;
            DownloadButton.Text = "Download";
            DownloadButton.UseVisualStyleBackColor = true;
            DownloadButton.Click += button1_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(70, 9);
            label.Name = "label";
            label.Size = new Size(144, 15);
            label.TabIndex = 1;
            label.Text = "Steam Manifest Generator";
            // 
            // appIdTextBox
            // 
            appIdTextBox.Location = new Point(12, 27);
            appIdTextBox.MaxLength = 12;
            appIdTextBox.Name = "appIdTextBox";
            appIdTextBox.Size = new Size(246, 23);
            appIdTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(108, 82);
            label1.Name = "label1";
            label1.Size = new Size(56, 12);
            label1.TabIndex = 3;
            label1.Text = "By HLNikNiky";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(270, 94);
            Controls.Add(label1);
            Controls.Add(appIdTextBox);
            Controls.Add(label);
            Controls.Add(DownloadButton);
            MaximumSize = new Size(286, 133);
            MinimumSize = new Size(286, 133);
            Name = "Form1";
            Text = "Steam Manifest Downloader";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DownloadButton;
        private Label label;
        private TextBox appIdTextBox;
        private Label label1;
    }
}
