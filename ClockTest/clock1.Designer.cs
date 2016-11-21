namespace ClockTest
{
    partial class clock1
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
            this.clockText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clockText
            // 
            this.clockText.AutoSize = true;
            this.clockText.Font = new System.Drawing.Font("Lucida Console", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockText.ForeColor = System.Drawing.Color.White;
            this.clockText.Location = new System.Drawing.Point(13, 13);
            this.clockText.Name = "clockText";
            this.clockText.Size = new System.Drawing.Size(330, 96);
            this.clockText.TabIndex = 0;
            this.clockText.Text = "00:00";
            // 
            // clock1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(349, 121);
            this.Controls.Add(this.clockText);
            this.Name = "clock1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "clock1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clockText;
    }
}