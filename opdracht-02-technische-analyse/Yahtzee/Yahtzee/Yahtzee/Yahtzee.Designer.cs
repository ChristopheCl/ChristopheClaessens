using System.Collections.Generic;

namespace Yahtzee
{
    partial class Yahtzee
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
            this.btnRollAll = new System.Windows.Forms.Button();
            this.btnCheat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRollAll
            // 
            this.btnRollAll.Location = new System.Drawing.Point(24, 209);
            this.btnRollAll.Name = "btnRollAll";
            this.btnRollAll.Size = new System.Drawing.Size(210, 46);
            this.btnRollAll.TabIndex = 0;
            this.btnRollAll.Text = "RollAll";
            this.btnRollAll.UseVisualStyleBackColor = true;
            this.btnRollAll.Click += new System.EventHandler(this.btnRollAll_Click);
            // 
            // btnCheat
            // 
            this.btnCheat.Location = new System.Drawing.Point(290, 259);
            this.btnCheat.Name = "btnCheat";
            this.btnCheat.Size = new System.Drawing.Size(45, 23);
            this.btnCheat.TabIndex = 1;
            this.btnCheat.Text = "cheat";
            this.btnCheat.UseVisualStyleBackColor = true;
            this.btnCheat.Click += new System.EventHandler(this.btnCheat_Click);
            // 
            // Yahtzee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(338, 282);
            this.Controls.Add(this.btnCheat);
            this.Controls.Add(this.btnRollAll);
            this.Name = "Yahtzee";
            this.Text = "Yahtzee";
            this.Load += new System.EventHandler(this.Yahtzee_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRollAll;
        private System.Windows.Forms.Button btnCheat;

    }
}