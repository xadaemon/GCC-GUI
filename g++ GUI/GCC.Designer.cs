namespace g___GUI
{
    partial class GCC
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GCC));
            this.topMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.githubIssuesPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileDialogInput = new System.Windows.Forms.OpenFileDialog();
            this.fileDialogOutput = new System.Windows.Forms.SaveFileDialog();
            this.delObjFiles = new System.Windows.Forms.CheckBox();
            this.compilationThread = new System.ComponentModel.BackgroundWorker();
            this.customContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.compileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.link = new System.Windows.Forms.LinkLabel();
            this.watcher = new System.IO.FileSystemWatcher();
            this.watchFS = new System.Windows.Forms.CheckBox();
            this.compileStart = new System.Windows.Forms.Button();
            this.cmdArgs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userOutputOverride = new System.Windows.Forms.TextBox();
            this.findOutput = new System.Windows.Forms.Button();
            this.makefileContents = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.stdout = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.baseFolder = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.baseFolderBrowse = new System.Windows.Forms.Button();
            this.baseFolderSelector = new System.Windows.Forms.FolderBrowserDialog();
            this.topMenu.SuspendLayout();
            this.customContext.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.watcher)).BeginInit();
            this.SuspendLayout();
            // 
            // topMenu
            // 
            this.topMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.topMenu.Location = new System.Drawing.Point(0, 0);
            this.topMenu.Name = "topMenu";
            this.topMenu.Size = new System.Drawing.Size(878, 24);
            this.topMenu.TabIndex = 0;
            this.topMenu.Text = "Bar";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem1});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // openFileToolStripMenuItem1
            // 
            this.openFileToolStripMenuItem1.Name = "openFileToolStripMenuItem1";
            this.openFileToolStripMenuItem1.Size = new System.Drawing.Size(151, 22);
            this.openFileToolStripMenuItem1.Text = "Open makefile";
            this.openFileToolStripMenuItem1.Click += new System.EventHandler(this.openFileToolStripMenuItem1_Click_1);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wIPToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // wIPToolStripMenuItem
            // 
            this.wIPToolStripMenuItem.Name = "wIPToolStripMenuItem";
            this.wIPToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.wIPToolStripMenuItem.Text = "WIP";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.githubIssuesPageToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // githubIssuesPageToolStripMenuItem
            // 
            this.githubIssuesPageToolStripMenuItem.Name = "githubIssuesPageToolStripMenuItem";
            this.githubIssuesPageToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.githubIssuesPageToolStripMenuItem.Text = "Github issues page";
            // 
            // fileDialogInput
            // 
            this.fileDialogInput.Filter = "C++|*.cpp,*.hpp,*.h|C|*.c,*.h|makefile|makefile";
            // 
            // fileDialogOutput
            // 
            this.fileDialogOutput.DefaultExt = "exe";
            this.fileDialogOutput.Filter = "Windows exeutable|*.exe|All files|*.*";
            // 
            // delObjFiles
            // 
            this.delObjFiles.AutoSize = true;
            this.delObjFiles.Location = new System.Drawing.Point(12, 325);
            this.delObjFiles.Name = "delObjFiles";
            this.delObjFiles.Size = new System.Drawing.Size(177, 17);
            this.delObjFiles.TabIndex = 1;
            this.delObjFiles.Text = "Delete .*o files after compilation.";
            this.delObjFiles.UseVisualStyleBackColor = true;
            // 
            // compilationThread
            // 
            this.compilationThread.WorkerReportsProgress = true;
            this.compilationThread.WorkerSupportsCancellation = true;
            // 
            // customContext
            // 
            this.customContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compileToolStripMenuItem});
            this.customContext.Name = "customContext";
            this.customContext.Size = new System.Drawing.Size(120, 26);
            // 
            // compileToolStripMenuItem
            // 
            this.compileToolStripMenuItem.Name = "compileToolStripMenuItem";
            this.compileToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.compileToolStripMenuItem.Text = "Compile";
            // 
            // link
            // 
            this.link.AutoSize = true;
            this.link.Cursor = System.Windows.Forms.Cursors.Hand;
            this.link.Location = new System.Drawing.Point(698, 329);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(168, 13);
            this.link.TabIndex = 3;
            this.link.TabStop = true;
            this.link.Text = "Copyright (C)2015 MugFoundation";
            // 
            // watcher
            // 
            this.watcher.EnableRaisingEvents = true;
            this.watcher.Filter = "*.c,*.cpp,*.h,*.hpp";
            this.watcher.IncludeSubdirectories = true;
            this.watcher.SynchronizingObject = this;
            // 
            // watchFS
            // 
            this.watchFS.AutoSize = true;
            this.watchFS.Location = new System.Drawing.Point(12, 302);
            this.watchFS.Name = "watchFS";
            this.watchFS.Size = new System.Drawing.Size(130, 17);
            this.watchFS.TabIndex = 4;
            this.watchFS.Text = "Watch for file chages.";
            this.watchFS.UseVisualStyleBackColor = true;
            // 
            // compileStart
            // 
            this.compileStart.Location = new System.Drawing.Point(195, 302);
            this.compileStart.Name = "compileStart";
            this.compileStart.Size = new System.Drawing.Size(492, 40);
            this.compileStart.TabIndex = 6;
            this.compileStart.Text = "Compile";
            this.compileStart.UseVisualStyleBackColor = true;
            this.compileStart.Click += new System.EventHandler(this.compileStart_Click);
            // 
            // cmdArgs
            // 
            this.cmdArgs.Location = new System.Drawing.Point(73, 276);
            this.cmdArgs.Name = "cmdArgs";
            this.cmdArgs.Size = new System.Drawing.Size(272, 20);
            this.cmdArgs.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Arguments:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Output file:";
            // 
            // userOutputOverride
            // 
            this.userOutputOverride.Location = new System.Drawing.Point(73, 250);
            this.userOutputOverride.Name = "userOutputOverride";
            this.userOutputOverride.Size = new System.Drawing.Size(272, 20);
            this.userOutputOverride.TabIndex = 10;
            this.userOutputOverride.Text = "Will overide makefile defined output";
            // 
            // findOutput
            // 
            this.findOutput.Location = new System.Drawing.Point(351, 250);
            this.findOutput.Name = "findOutput";
            this.findOutput.Size = new System.Drawing.Size(71, 20);
            this.findOutput.TabIndex = 11;
            this.findOutput.Text = "Browse...";
            this.findOutput.UseVisualStyleBackColor = true;
            // 
            // makefileContents
            // 
            this.makefileContents.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.makefileContents.Location = new System.Drawing.Point(12, 46);
            this.makefileContents.Name = "makefileContents";
            this.makefileContents.Size = new System.Drawing.Size(410, 198);
            this.makefileContents.TabIndex = 12;
            this.makefileContents.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Makefile preview:";
            // 
            // stdout
            // 
            this.stdout.Cursor = System.Windows.Forms.Cursors.No;
            this.stdout.Location = new System.Drawing.Point(428, 46);
            this.stdout.Name = "stdout";
            this.stdout.ReadOnly = true;
            this.stdout.Size = new System.Drawing.Size(438, 198);
            this.stdout.TabIndex = 14;
            this.stdout.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(425, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Command line results:";
            // 
            // baseFolder
            // 
            this.baseFolder.Location = new System.Drawing.Point(417, 276);
            this.baseFolder.Name = "baseFolder";
            this.baseFolder.Size = new System.Drawing.Size(270, 20);
            this.baseFolder.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Base folder:";
            // 
            // baseFolderBrowse
            // 
            this.baseFolderBrowse.Location = new System.Drawing.Point(693, 275);
            this.baseFolderBrowse.Name = "baseFolderBrowse";
            this.baseFolderBrowse.Size = new System.Drawing.Size(71, 21);
            this.baseFolderBrowse.TabIndex = 18;
            this.baseFolderBrowse.Text = "Browse...";
            this.baseFolderBrowse.UseVisualStyleBackColor = true;
            this.baseFolderBrowse.Click += new System.EventHandler(this.baseFolderBrowse_Click);
            // 
            // baseFolderSelector
            // 
            this.baseFolderSelector.RootFolder = System.Environment.SpecialFolder.DesktopDirectory;
            this.baseFolderSelector.ShowNewFolderButton = false;
            // 
            // GCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 352);
            this.ContextMenuStrip = this.customContext;
            this.Controls.Add(this.baseFolderBrowse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.baseFolder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.stdout);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.makefileContents);
            this.Controls.Add(this.findOutput);
            this.Controls.Add(this.userOutputOverride);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdArgs);
            this.Controls.Add(this.compileStart);
            this.Controls.Add(this.watchFS);
            this.Controls.Add(this.link);
            this.Controls.Add(this.delObjFiles);
            this.Controls.Add(this.topMenu);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.topMenu;
            this.MaximizeBox = false;
            this.Name = "GCC";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "GCC";
            this.topMenu.ResumeLayout(false);
            this.topMenu.PerformLayout();
            this.customContext.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.watcher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip topMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog fileDialogInput;
        private System.Windows.Forms.SaveFileDialog fileDialogOutput;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem githubIssuesPageToolStripMenuItem;
        private System.Windows.Forms.CheckBox delObjFiles;
        private System.ComponentModel.BackgroundWorker compilationThread;
        private System.Windows.Forms.ContextMenuStrip customContext;
        private System.Windows.Forms.ToolStripMenuItem compileToolStripMenuItem;
        private System.Windows.Forms.LinkLabel link;
        private System.IO.FileSystemWatcher watcher;
        private System.Windows.Forms.TextBox userOutputOverride;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cmdArgs;
        private System.Windows.Forms.Button compileStart;
        private System.Windows.Forms.CheckBox watchFS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox makefileContents;
        private System.Windows.Forms.Button findOutput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox stdout;
        private System.Windows.Forms.ToolStripMenuItem wIPToolStripMenuItem;
        private System.Windows.Forms.Button baseFolderBrowse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox baseFolder;
        private System.Windows.Forms.FolderBrowserDialog baseFolderSelector;
    }
}

