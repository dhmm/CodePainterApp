namespace CodePainterApp
{
    partial class FormCommands
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCommands));
            this.rtxtCommands = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtxtCommands
            // 
            this.rtxtCommands.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.rtxtCommands.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtCommands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtCommands.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtCommands.Location = new System.Drawing.Point(0, 0);
            this.rtxtCommands.Name = "rtxtCommands";
            this.rtxtCommands.Size = new System.Drawing.Size(782, 555);
            this.rtxtCommands.TabIndex = 1;
            this.rtxtCommands.Text = resources.GetString("rtxtCommands.Text");
            // 
            // FormCommands
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 555);
            this.Controls.Add(this.rtxtCommands);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCommands";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Available Commands";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtCommands;
    }
}