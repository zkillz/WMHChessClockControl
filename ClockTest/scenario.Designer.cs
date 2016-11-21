namespace ClockTest
{
    partial class scenario
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
            this.scenarioPoints = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // scenarioPoints
            // 
            this.scenarioPoints.AutoSize = true;
            this.scenarioPoints.Font = new System.Drawing.Font("Lucida Console", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scenarioPoints.ForeColor = System.Drawing.Color.White;
            this.scenarioPoints.Location = new System.Drawing.Point(13, 13);
            this.scenarioPoints.Name = "scenarioPoints";
            this.scenarioPoints.Size = new System.Drawing.Size(98, 96);
            this.scenarioPoints.TabIndex = 0;
            this.scenarioPoints.Text = "0";
            // 
            // scenario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(120, 114);
            this.Controls.Add(this.scenarioPoints);
            this.Name = "scenario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "scenario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scenarioPoints;
    }
}