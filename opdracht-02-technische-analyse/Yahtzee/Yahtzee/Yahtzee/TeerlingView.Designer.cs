namespace Yahtzee
{
    partial class TeerlingView
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
            this.lbllalbel1 = new System.Windows.Forms.Label();
            this.btnWerp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbllalbel1
            // 
            this.lbllalbel1.Location = new System.Drawing.Point(3, 9);
            this.lbllalbel1.Name = "lbllalbel1";
            this.lbllalbel1.Size = new System.Drawing.Size(144, 65);
            this.lbllalbel1.TabIndex = 0;
            this.lbllalbel1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnWerp
            // 
            this.btnWerp.Location = new System.Drawing.Point(28, 107);
            this.btnWerp.Name = "btnWerp";
            this.btnWerp.Size = new System.Drawing.Size(75, 23);
            this.btnWerp.TabIndex = 1;
            this.btnWerp.Text = "Werp";
            this.btnWerp.UseVisualStyleBackColor = true;
            this.btnWerp.Click += new System.EventHandler(this.btnWerp_Click);
            // 
            // TeerlingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnWerp);
            this.Controls.Add(this.lbllalbel1);
            this.Name = "TeerlingView";
            this.Load += new System.EventHandler(this.TeerlingView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbllalbel1;
        private System.Windows.Forms.Button btnWerp;

    }
}
