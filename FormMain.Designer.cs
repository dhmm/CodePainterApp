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
            this.rtxtCode = new System.Windows.Forms.RichTextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.pnlArena = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClearArena = new System.Windows.Forms.Button();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.rtxtDebug = new System.Windows.Forms.RichTextBox();
            this.drawer = new CodePainterApp.Drawer();
            this.pnlArena.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtxtCode
            // 
            this.rtxtCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rtxtCode.BackColor = System.Drawing.Color.Black;
            this.rtxtCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtCode.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtCode.ForeColor = System.Drawing.Color.White;
            this.rtxtCode.Location = new System.Drawing.Point(12, 51);
            this.rtxtCode.Name = "rtxtCode";
            this.rtxtCode.Size = new System.Drawing.Size(366, 572);
            this.rtxtCode.TabIndex = 0;
            this.rtxtCode.Text = "REPEAT(5)\nDONTPAINT()\nGO()\nPAINT()\nGO()\nENDREPEAT()";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(12, 21);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(72, 24);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Run Code";
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
            this.btnClear.Location = new System.Drawing.Point(99, 21);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(72, 24);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear Code";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClearArena
            // 
            this.btnClearArena.Location = new System.Drawing.Point(384, 21);
            this.btnClearArena.Name = "btnClearArena";
            this.btnClearArena.Size = new System.Drawing.Size(72, 24);
            this.btnClearArena.TabIndex = 4;
            this.btnClearArena.Text = "Clear Arena";
            this.btnClearArena.UseVisualStyleBackColor = true;
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
            this.pnlContainer.Location = new System.Drawing.Point(384, 51);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(697, 571);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(915, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Tests";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // rtxtDebug
            // 
            this.rtxtDebug.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtDebug.BackColor = System.Drawing.Color.Black;
            this.rtxtDebug.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtDebug.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtDebug.ForeColor = System.Drawing.Color.White;
            this.rtxtDebug.Location = new System.Drawing.Point(12, 629);
            this.rtxtDebug.Name = "rtxtDebug";
            this.rtxtDebug.Size = new System.Drawing.Size(1058, 84);
            this.rtxtDebug.TabIndex = 8;
            this.rtxtDebug.Text = "";
            // 
            // drawer
            // 
            this.drawer.Arena = null;
            this.drawer.BackColor = System.Drawing.Color.Maroon;
            this.drawer.Location = new System.Drawing.Point(0, 0);
            this.drawer.Name = "drawer";
            this.drawer.Size = new System.Drawing.Size(20, 20);
            this.drawer.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 725);
            this.Controls.Add(this.rtxtDebug);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.btnClearArena);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.rtxtCode);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.pnlArena.ResumeLayout(false);
            this.pnlContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtCode;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Panel pnlArena;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClearArena;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Panel panel1;
        private Drawer drawer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox rtxtDebug;
    }
}

