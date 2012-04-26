namespace km
{
    partial class Mainmenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.functionLabel = new System.Windows.Forms.Label();
            this.aboutMe = new System.Windows.Forms.TabPage();
            this.interestTab = new System.Windows.Forms.TabPage();
            this.documentsTab = new System.Windows.Forms.TabPage();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.docEdit = new System.Windows.Forms.Button();
            this.intEdit = new System.Windows.Forms.Button();
            this.aboutSave = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.aboutMe.SuspendLayout();
            this.interestTab.SuspendLayout();
            this.documentsTab.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.profileToolStripMenuItem,
            this.documentsToolStripMenuItem,
            this.interestsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(702, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.profileToolStripMenuItem.Text = "Profile";
            // 
            // documentsToolStripMenuItem
            // 
            this.documentsToolStripMenuItem.Name = "documentsToolStripMenuItem";
            this.documentsToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.documentsToolStripMenuItem.Text = "Documents";
            // 
            // interestsToolStripMenuItem
            // 
            this.interestsToolStripMenuItem.Name = "interestsToolStripMenuItem";
            this.interestsToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.interestsToolStripMenuItem.Text = "Interrests";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(285, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(391, 1);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(473, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Location = new System.Drawing.Point(12, 35);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(46, 13);
            this.fullNameLabel.TabIndex = 5;
            this.fullNameLabel.Text = "fullname";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(282, 35);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(31, 13);
            this.emailLabel.TabIndex = 6;
            this.emailLabel.Text = "email";
            // 
            // functionLabel
            // 
            this.functionLabel.AutoSize = true;
            this.functionLabel.Location = new System.Drawing.Point(146, 35);
            this.functionLabel.Name = "functionLabel";
            this.functionLabel.Size = new System.Drawing.Size(45, 13);
            this.functionLabel.TabIndex = 7;
            this.functionLabel.Text = "function";
            // 
            // aboutMe
            // 
            this.aboutMe.Controls.Add(this.richTextBox1);
            this.aboutMe.Controls.Add(this.aboutSave);
            this.aboutMe.Location = new System.Drawing.Point(4, 22);
            this.aboutMe.Name = "aboutMe";
            this.aboutMe.Padding = new System.Windows.Forms.Padding(3);
            this.aboutMe.Size = new System.Drawing.Size(694, 306);
            this.aboutMe.TabIndex = 2;
            this.aboutMe.Text = "About me";
            this.aboutMe.UseVisualStyleBackColor = true;
            // 
            // interestTab
            // 
            this.interestTab.Controls.Add(this.listBox2);
            this.interestTab.Controls.Add(this.intEdit);
            this.interestTab.Location = new System.Drawing.Point(4, 22);
            this.interestTab.Name = "interestTab";
            this.interestTab.Padding = new System.Windows.Forms.Padding(3);
            this.interestTab.Size = new System.Drawing.Size(694, 306);
            this.interestTab.TabIndex = 1;
            this.interestTab.Text = "Interest";
            this.interestTab.UseVisualStyleBackColor = true;
            // 
            // documentsTab
            // 
            this.documentsTab.Controls.Add(this.listBox1);
            this.documentsTab.Controls.Add(this.docEdit);
            this.documentsTab.Location = new System.Drawing.Point(4, 22);
            this.documentsTab.Name = "documentsTab";
            this.documentsTab.Padding = new System.Windows.Forms.Padding(3);
            this.documentsTab.Size = new System.Drawing.Size(694, 306);
            this.documentsTab.TabIndex = 0;
            this.documentsTab.Text = "Documents";
            this.documentsTab.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.documentsTab);
            this.tabControl.Controls.Add(this.interestTab);
            this.tabControl.Controls.Add(this.aboutMe);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl.Location = new System.Drawing.Point(0, 72);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(702, 332);
            this.tabControl.TabIndex = 0;
            // 
            // docEdit
            // 
            this.docEdit.Location = new System.Drawing.Point(495, 271);
            this.docEdit.Name = "docEdit";
            this.docEdit.Size = new System.Drawing.Size(75, 23);
            this.docEdit.TabIndex = 0;
            this.docEdit.Text = "Edit";
            this.docEdit.UseVisualStyleBackColor = true;
            // 
            // intEdit
            // 
            this.intEdit.Location = new System.Drawing.Point(495, 271);
            this.intEdit.Name = "intEdit";
            this.intEdit.Size = new System.Drawing.Size(75, 23);
            this.intEdit.TabIndex = 1;
            this.intEdit.Text = "Edit";
            this.intEdit.UseVisualStyleBackColor = true;
            // 
            // aboutSave
            // 
            this.aboutSave.Location = new System.Drawing.Point(549, 242);
            this.aboutSave.Name = "aboutSave";
            this.aboutSave.Size = new System.Drawing.Size(75, 23);
            this.aboutSave.TabIndex = 1;
            this.aboutSave.Text = "Save";
            this.aboutSave.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(350, 251);
            this.listBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(6, 6);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(350, 251);
            this.listBox2.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(11, 21);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(532, 244);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // Mainmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 404);
            this.Controls.Add(this.functionLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.fullNameLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Mainmenu";
            this.Text = "Mainmenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.aboutMe.ResumeLayout(false);
            this.interestTab.ResumeLayout(false);
            this.documentsTab.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interestsToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label functionLabel;
        private System.Windows.Forms.TabPage aboutMe;
        private System.Windows.Forms.TabPage interestTab;
        private System.Windows.Forms.Button intEdit;
        private System.Windows.Forms.TabPage documentsTab;
        private System.Windows.Forms.Button docEdit;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button aboutSave;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
    }
}