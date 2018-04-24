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
            this.RealmListView = new System.Windows.Forms.ListView();
            this.RealmLabel = new System.Windows.Forms.Label();
            this.CharacterListView = new System.Windows.Forms.ListView();
            this.CharacterLabel = new System.Windows.Forms.Label();
            this.SelectedCharacterLabel = new System.Windows.Forms.Label();
            this.CharacterToCopyTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SelectedCharactersLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CharactersToCopyToListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // WTFPathTextbox
            // 
            this.WTFPathTextbox.Location = new System.Drawing.Point(89, 52);
            this.WTFPathTextbox.Name = "WTFPathTextbox";
            this.WTFPathTextbox.Size = new System.Drawing.Size(381, 20);
            this.WTFPathTextbox.TabIndex = 0;
            // 
            // WTFPathLabel
            // 
            this.WTFPathLabel.AutoSize = true;
            this.WTFPathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WTFPathLabel.Location = new System.Drawing.Point(12, 55);
            this.WTFPathLabel.Name = "WTFPathLabel";
            this.WTFPathLabel.Size = new System.Drawing.Size(71, 13);
            this.WTFPathLabel.TabIndex = 1;
            this.WTFPathLabel.Text = "Folder path";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Depending on drive you installed WoW on, the path will resemble:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.FolderPathButton.Location = new System.Drawing.Point(470, 51);
            this.FolderPathButton.Name = "FolderPathButton";
            this.FolderPathButton.Size = new System.Drawing.Size(22, 22);
            this.FolderPathButton.TabIndex = 3;
            this.FolderPathButton.UseVisualStyleBackColor = true;
            // 
            // RealmListView
            // 
            this.RealmListView.Location = new System.Drawing.Point(15, 131);
            this.RealmListView.Name = "RealmListView";
            this.RealmListView.Size = new System.Drawing.Size(120, 337);
            this.RealmListView.TabIndex = 4;
            this.RealmListView.UseCompatibleStateImageBehavior = false;
            // 
            // RealmLabel
            // 
            this.RealmLabel.AutoSize = true;
            this.RealmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RealmLabel.Location = new System.Drawing.Point(12, 118);
            this.RealmLabel.Name = "RealmLabel";
            this.RealmLabel.Size = new System.Drawing.Size(42, 13);
            this.RealmLabel.TabIndex = 5;
            this.RealmLabel.Text = "Realm";
            // 
            // CharacterListView
            // 
            this.CharacterListView.Location = new System.Drawing.Point(142, 131);
            this.CharacterListView.Name = "CharacterListView";
            this.CharacterListView.Size = new System.Drawing.Size(120, 337);
            this.CharacterListView.TabIndex = 4;
            this.CharacterListView.UseCompatibleStateImageBehavior = false;
            // 
            // CharacterLabel
            // 
            this.CharacterLabel.AutoSize = true;
            this.CharacterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharacterLabel.Location = new System.Drawing.Point(139, 118);
            this.CharacterLabel.Name = "CharacterLabel";
            this.CharacterLabel.Size = new System.Drawing.Size(62, 13);
            this.CharacterLabel.TabIndex = 5;
            this.CharacterLabel.Text = "Character";
            // 
            // SelectedCharacterLabel
            // 
            this.SelectedCharacterLabel.AutoSize = true;
            this.SelectedCharacterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedCharacterLabel.Location = new System.Drawing.Point(266, 115);
            this.SelectedCharacterLabel.Name = "SelectedCharacterLabel";
            this.SelectedCharacterLabel.Size = new System.Drawing.Size(136, 13);
            this.SelectedCharacterLabel.TabIndex = 6;
            this.SelectedCharacterLabel.Text = "Character to copy from";
            // 
            // CharacterToCopyTextbox
            // 
            this.CharacterToCopyTextbox.Location = new System.Drawing.Point(269, 131);
            this.CharacterToCopyTextbox.Name = "CharacterToCopyTextbox";
            this.CharacterToCopyTextbox.Size = new System.Drawing.Size(229, 20);
            this.CharacterToCopyTextbox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(266, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Select the character you want to copy from in the \'character\' list";
            // 
            // SelectedCharactersLabel
            // 
            this.SelectedCharactersLabel.AutoSize = true;
            this.SelectedCharactersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedCharactersLabel.Location = new System.Drawing.Point(265, 227);
            this.SelectedCharactersLabel.Name = "SelectedCharactersLabel";
            this.SelectedCharactersLabel.Size = new System.Drawing.Size(129, 13);
            this.SelectedCharactersLabel.TabIndex = 9;
            this.SelectedCharactersLabel.Text = "Characters to copy to";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(265, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 44);
            this.label5.TabIndex = 9;
            this.label5.Text = "To select a character, click on a character in the list. To delete, click on the " +
    "character again in the characters to copy to list.";
            // 
            // CharactersToCopyToListView
            // 
            this.CharactersToCopyToListView.Location = new System.Drawing.Point(268, 240);
            this.CharactersToCopyToListView.Name = "CharactersToCopyToListView";
            this.CharactersToCopyToListView.Size = new System.Drawing.Size(229, 228);
            this.CharactersToCopyToListView.TabIndex = 4;
            this.CharactersToCopyToListView.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 592);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SelectedCharactersLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CharacterToCopyTextbox);
            this.Controls.Add(this.SelectedCharacterLabel);
            this.Controls.Add(this.CharacterLabel);
            this.Controls.Add(this.RealmLabel);
            this.Controls.Add(this.CharactersToCopyToListView);
            this.Controls.Add(this.CharacterListView);
            this.Controls.Add(this.RealmListView);
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
        private System.Windows.Forms.ListView RealmListView;
        private System.Windows.Forms.Label RealmLabel;
        private System.Windows.Forms.ListView CharacterListView;
        private System.Windows.Forms.Label CharacterLabel;
        private System.Windows.Forms.Label SelectedCharacterLabel;
        private System.Windows.Forms.TextBox CharacterToCopyTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label SelectedCharactersLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView CharactersToCopyToListView;
    }
}

