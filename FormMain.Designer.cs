namespace CodePainterApp
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.rtxtCode = new System.Windows.Forms.RichTextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.pnlArena = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClearArena = new System.Windows.Forms.Button();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtxtLogShower = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAvaialableCommands = new System.Windows.Forms.ToolStripMenuItem();
            this.abourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.drawer = new CodePainterApp.Drawer();
            this.pnlArena.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtxtCode
            // 
            this.rtxtCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rtxtCode.BackColor = System.Drawing.Color.Black;
            this.rtxtCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtCode.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.rtxtCode.ForeColor = System.Drawing.Color.White;
            this.rtxtCode.Location = new System.Drawing.Point(12, 71);
            this.rtxtCode.Name = "rtxtCode";
            this.rtxtCode.Size = new System.Drawing.Size(366, 552);
            this.rtxtCode.TabIndex = 0;
            this.rtxtCode.Text = "REPEAT(5)\nDONTPAINT()\nGO()\nPAINT()\nGO()\nENDREPEAT()";
            // 
            // btnRun
            // 
            this.btnRun.Image = ((System.Drawing.Image)(resources.GetObject("btnRun.Image")));
            this.btnRun.Location = new System.Drawing.Point(12, 27);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(116, 43);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Run Code";
            this.btnRun.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // pnlArena
            // 
            this.pnlArena.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlArena.Controls.Add(this.drawer);
            this.pnlArena.Location = new System.Drawing.Point(20, 20);
            this.pnlArena.Name = "pnlArena";
            this.pnlArena.Size = new System.Drawing.Size(1201, 1201);
            this.pnlArena.TabIndex = 2;
            this.pnlArena.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlArena_Paint);
            // 
            // btnClear
            // 
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.Location = new System.Drawing.Point(134, 27);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(113, 43);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear Code";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClearArena
            // 
            this.btnClearArena.Image = ((System.Drawing.Image)(resources.GetObject("btnClearArena.Image")));
            this.btnClearArena.Location = new System.Drawing.Point(384, 27);
            this.btnClearArena.Name = "btnClearArena";
            this.btnClearArena.Size = new System.Drawing.Size(131, 43);
            this.btnClearArena.TabIndex = 4;
            this.btnClearArena.Text = "Clear Arena";
            this.btnClearArena.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClearArena.UseVisualStyleBackColor = true;
            this.btnClearArena.Click += new System.EventHandler(this.btnClearArena_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContainer.AutoScroll = true;
            this.pnlContainer.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlContainer.Controls.Add(this.panel2);
            this.pnlContainer.Controls.Add(this.panel1);
            this.pnlContainer.Controls.Add(this.pnlArena);
            this.pnlContainer.Location = new System.Drawing.Point(384, 71);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(697, 551);
            this.pnlContainer.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(1221, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(20, 100);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(20, 1221);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 20);
            this.panel1.TabIndex = 3;
            // 
            // rtxtLogShower
            // 
            this.rtxtLogShower.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtLogShower.BackColor = System.Drawing.Color.Black;
            this.rtxtLogShower.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtLogShower.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtLogShower.ForeColor = System.Drawing.Color.White;
            this.rtxtLogShower.Location = new System.Drawing.Point(12, 629);
            this.rtxtLogShower.Name = "rtxtLogShower";
            this.rtxtLogShower.Size = new System.Drawing.Size(1058, 84);
            this.rtxtLogShower.TabIndex = 8;
            this.rtxtLogShower.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1082, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpenFile,
            this.mnuSaveFile});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAvaialableCommands,
            this.abourToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // mnuAvaialableCommands
            // 
            this.mnuAvaialableCommands.Name = "mnuAvaialableCommands";
            this.mnuAvaialableCommands.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.mnuAvaialableCommands.Size = new System.Drawing.Size(206, 22);
            this.mnuAvaialableCommands.Text = "Available Commands";
            this.mnuAvaialableCommands.Click += new System.EventHandler(this.mnuAvailableCommands_Click);
            // 
            // abourToolStripMenuItem
            // 
            this.abourToolStripMenuItem.Name = "abourToolStripMenuItem";
            this.abourToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.abourToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.abourToolStripMenuItem.Text = "About";
            this.abourToolStripMenuItem.Click += new System.EventHandler(this.abourToolStripMenuItem_Click);
            // 
            // mnuOpenFile
            // 
            this.mnuOpenFile.Name = "mnuOpenFile";
            this.mnuOpenFile.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.mnuOpenFile.Size = new System.Drawing.Size(152, 22);
            this.mnuOpenFile.Text = "Open";
            // 
            // mnuSaveFile
            // 
            this.mnuSaveFile.Name = "mnuSaveFile";
            this.mnuSaveFile.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.mnuSaveFile.Size = new System.Drawing.Size(152, 22);
            this.mnuSaveFile.Text = "Save";
            // 
            // drawer
            // 
            this.drawer.Arena = null;
            this.drawer.BackColor = System.Drawing.Color.Transparent;
            this.drawer.Location = new System.Drawing.Point(0, 0);
            this.drawer.Name = "drawer";
            this.drawer.Size = new System.Drawing.Size(20, 20);
            this.drawer.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 725);
            this.Controls.Add(this.rtxtLogShower);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.btnClearArena);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.rtxtCode);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CodePainter";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.pnlArena.ResumeLayout(false);
            this.pnlContainer.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtCode;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Panel pnlArena;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClearArena;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox rtxtLogShower;
        private Drawer drawer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAvaialableCommands;
        private System.Windows.Forms.ToolStripMenuItem abourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenFile;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveFile;
    }
}

