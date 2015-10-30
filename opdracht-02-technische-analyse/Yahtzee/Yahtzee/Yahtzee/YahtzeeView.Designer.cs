namespace Yahtzee
{
    partial class YahtzeeView
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
            this.btnRollAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRollAll
            // 
            this.btnRollAll.Location = new System.Drawing.Point(13, 63);
            this.btnRollAll.Name = "btnRollAll";
            this.btnRollAll.Size = new System.Drawing.Size(113, 71);
            this.btnRollAll.TabIndex = 0;
            this.btnRollAll.Text = "rollAll";
            this.btnRollAll.UseVisualStyleBackColor = true;
            this.btnRollAll.Click += new System.EventHandler(this.btnRollAll_Click);
            // 
            // YahtzeeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRollAll);
            this.Name = "YahtzeeView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRollAll;
    }
}
