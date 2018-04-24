namespace WoWAddonSettingsSync
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.WTFPathTextbox = new System.Windows.Forms.TextBox();
            this.WTFPathLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FolderPathButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WTFPathTextbox
            // 
            this.WTFPathTextbox.Location = new System.Drawing.Point(91, 53);
            this.WTFPathTextbox.Name = "WTFPathTextbox";
            this.WTFPathTextbox.Size = new System.Drawing.Size(407, 20);
            this.WTFPathTextbox.TabIndex = 0;
            // 
            // WTFPathLabel
            // 
            this.WTFPathLabel.AutoSize = true;
            this.WTFPathLabel.Location = new System.Drawing.Point(12, 56);
            this.WTFPathLabel.Name = "WTFPathLabel";
            this.WTFPathLabel.Size = new System.Drawing.Size(60, 13);
            this.WTFPathLabel.TabIndex = 1;
            this.WTFPathLabel.Text = "Folder path";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Depending on drive you installed WoW on, the path will look something like:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(406, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Drive:\\Program Files (x86)\\World of Warcraft\\WTF\\Account\\AccountID#AccountID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Remember to choose the correct account ID folder.";
            // 
            // FolderPathButton
            // 
            this.FolderPathButton.Location = new System.Drawing.Point(70, 52);
            this.FolderPathButton.Name = "FolderPathButton";
            this.FolderPathButton.Size = new System.Drawing.Size(22, 22);
            this.FolderPathButton.TabIndex = 3;
            this.FolderPathButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 592);
            this.Controls.Add(this.FolderPathButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WTFPathLabel);
            this.Controls.Add(this.WTFPathTextbox);
            this.Name = "Form1";
            this.Text = "WoW Addon Settings Sync";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WTFPathTextbox;
        private System.Windows.Forms.Label WTFPathLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button FolderPathButton;
    }
}

