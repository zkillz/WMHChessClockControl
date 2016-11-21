namespace ClockTest
{
    partial class Form1
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
            this.startBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.portName = new System.Windows.Forms.ComboBox();
            this.player1Name = new System.Windows.Forms.TextBox();
            this.player2Name = new System.Windows.Forms.TextBox();
            this.playerTime = new System.Windows.Forms.TextBox();
            this.playerTimeBtn = new System.Windows.Forms.Button();
            this.p1NameBtn = new System.Windows.Forms.Button();
            this.p2NameBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(266, 197);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(106, 23);
            this.startBtn.TabIndex = 1;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(266, 226);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(106, 23);
            this.stopBtn.TabIndex = 2;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // outputBox
            // 
            this.outputBox.BackColor = System.Drawing.SystemColors.Window;
            this.outputBox.Location = new System.Drawing.Point(12, 25);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(171, 219);
            this.outputBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Output";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Port Name";
            // 
            // portName
            // 
            this.portName.FormattingEnabled = true;
            this.portName.Location = new System.Drawing.Point(266, 12);
            this.portName.Name = "portName";
            this.portName.Size = new System.Drawing.Size(106, 21);
            this.portName.TabIndex = 7;
            // 
            // player1Name
            // 
            this.player1Name.Location = new System.Drawing.Point(266, 92);
            this.player1Name.Name = "player1Name";
            this.player1Name.Size = new System.Drawing.Size(106, 20);
            this.player1Name.TabIndex = 12;
            this.player1Name.Text = "LEFT";
            // 
            // player2Name
            // 
            this.player2Name.Location = new System.Drawing.Point(266, 119);
            this.player2Name.Name = "player2Name";
            this.player2Name.Size = new System.Drawing.Size(106, 20);
            this.player2Name.TabIndex = 13;
            this.player2Name.Text = "RIGHT";
            // 
            // playerTime
            // 
            this.playerTime.Location = new System.Drawing.Point(266, 66);
            this.playerTime.Name = "playerTime";
            this.playerTime.Size = new System.Drawing.Size(106, 20);
            this.playerTime.TabIndex = 14;
            this.playerTime.Text = "60";
            // 
            // playerTimeBtn
            // 
            this.playerTimeBtn.Location = new System.Drawing.Point(190, 66);
            this.playerTimeBtn.Name = "playerTimeBtn";
            this.playerTimeBtn.Size = new System.Drawing.Size(70, 20);
            this.playerTimeBtn.TabIndex = 15;
            this.playerTimeBtn.Text = "Player Time";
            this.playerTimeBtn.UseVisualStyleBackColor = true;
            this.playerTimeBtn.Click += new System.EventHandler(this.playerTimeBtn_Click);
            // 
            // p1NameBtn
            // 
            this.p1NameBtn.Location = new System.Drawing.Point(190, 92);
            this.p1NameBtn.Name = "p1NameBtn";
            this.p1NameBtn.Size = new System.Drawing.Size(70, 20);
            this.p1NameBtn.TabIndex = 16;
            this.p1NameBtn.Text = "P1 Name";
            this.p1NameBtn.UseVisualStyleBackColor = true;
            this.p1NameBtn.Click += new System.EventHandler(this.p1NameBtn_Click);
            // 
            // p2NameBtn
            // 
            this.p2NameBtn.Location = new System.Drawing.Point(190, 119);
            this.p2NameBtn.Name = "p2NameBtn";
            this.p2NameBtn.Size = new System.Drawing.Size(70, 20);
            this.p2NameBtn.TabIndex = 17;
            this.p2NameBtn.Text = "P2 Name";
            this.p2NameBtn.UseVisualStyleBackColor = true;
            this.p2NameBtn.Click += new System.EventHandler(this.p2NameBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.p2NameBtn);
            this.Controls.Add(this.p1NameBtn);
            this.Controls.Add(this.playerTimeBtn);
            this.Controls.Add(this.playerTime);
            this.Controls.Add(this.player2Name);
            this.Controls.Add(this.player1Name);
            this.Controls.Add(this.portName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.startBtn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Clock Console";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox portName;
        private System.Windows.Forms.TextBox player1Name;
        private System.Windows.Forms.TextBox player2Name;
        private System.Windows.Forms.TextBox playerTime;
        private System.Windows.Forms.Button playerTimeBtn;
        private System.Windows.Forms.Button p1NameBtn;
        private System.Windows.Forms.Button p2NameBtn;
    }
}

