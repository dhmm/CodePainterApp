namespace CodePainterApp
{
    partial class Drawer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Drawer));
            this.pctDown = new System.Windows.Forms.PictureBox();
            this.pctRight = new System.Windows.Forms.PictureBox();
            this.pctUp = new System.Windows.Forms.PictureBox();
            this.pctLeft = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // pctDown
            // 
            this.pctDown.Image = ((System.Drawing.Image)(resources.GetObject("pctDown.Image")));
            this.pctDown.Location = new System.Drawing.Point(0, 0);
            this.pctDown.Name = "pctDown";
            this.pctDown.Size = new System.Drawing.Size(20, 20);
            this.pctDown.TabIndex = 0;
            this.pctDown.TabStop = false;
            // 
            // pctRight
            // 
            this.pctRight.Image = ((System.Drawing.Image)(resources.GetObject("pctRight.Image")));
            this.pctRight.Location = new System.Drawing.Point(0, 0);
            this.pctRight.Name = "pctRight";
            this.pctRight.Size = new System.Drawing.Size(20, 20);
            this.pctRight.TabIndex = 1;
            this.pctRight.TabStop = false;
            this.pctRight.Visible = false;
            // 
            // pctUp
            // 
            this.pctUp.Image = ((System.Drawing.Image)(resources.GetObject("pctUp.Image")));
            this.pctUp.Location = new System.Drawing.Point(0, 0);
            this.pctUp.Name = "pctUp";
            this.pctUp.Size = new System.Drawing.Size(20, 20);
            this.pctUp.TabIndex = 2;
            this.pctUp.TabStop = false;
            this.pctUp.Visible = false;
            // 
            // pctLeft
            // 
            this.pctLeft.Image = ((System.Drawing.Image)(resources.GetObject("pctLeft.Image")));
            this.pctLeft.Location = new System.Drawing.Point(0, 0);
            this.pctLeft.Name = "pctLeft";
            this.pctLeft.Size = new System.Drawing.Size(20, 20);
            this.pctLeft.TabIndex = 3;
            this.pctLeft.TabStop = false;
            this.pctLeft.Visible = false;
            // 
            // Drawer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pctLeft);
            this.Controls.Add(this.pctUp);
            this.Controls.Add(this.pctRight);
            this.Controls.Add(this.pctDown);
            this.Name = "Drawer";
            this.Size = new System.Drawing.Size(20, 20);
            ((System.ComponentModel.ISupportInitialize)(this.pctDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLeft)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctDown;
        private System.Windows.Forms.PictureBox pctRight;
        private System.Windows.Forms.PictureBox pctUp;
        private System.Windows.Forms.PictureBox pctLeft;
    }
}
