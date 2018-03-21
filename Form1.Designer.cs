namespace IssueTran
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
            this.label1 = new System.Windows.Forms.Label();
            this.CIDTextBox = new System.Windows.Forms.TextBox();
            this.VideoCodeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IssueDateDTP = new System.Windows.Forms.DateTimePicker();
            this.DueDateDTP = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.RemarksTextBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.CustLookupButton = new System.Windows.Forms.Button();
            this.VideoLookupButton = new System.Windows.Forms.Button();
            this.CustNameTextBox = new System.Windows.Forms.TextBox();
            this.MovieTitleTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer ID";
            // 
            // CIDTextBox
            // 
            this.CIDTextBox.Location = new System.Drawing.Point(267, 46);
            this.CIDTextBox.Name = "CIDTextBox";
            this.CIDTextBox.Size = new System.Drawing.Size(187, 34);
            this.CIDTextBox.TabIndex = 1;
            this.CIDTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CIDTextBox_KeyDown);
            // 
            // VideoCodeTextBox
            // 
            this.VideoCodeTextBox.Location = new System.Drawing.Point(266, 131);
            this.VideoCodeTextBox.Name = "VideoCodeTextBox";
            this.VideoCodeTextBox.Size = new System.Drawing.Size(188, 34);
            this.VideoCodeTextBox.TabIndex = 3;
            this.VideoCodeTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.VideoCodeTextBox_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Video Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Issue Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Due Date";
            // 
            // IssueDateDTP
            // 
            this.IssueDateDTP.Location = new System.Drawing.Point(267, 211);
            this.IssueDateDTP.Name = "IssueDateDTP";
            this.IssueDateDTP.Size = new System.Drawing.Size(383, 34);
            this.IssueDateDTP.TabIndex = 8;
            // 
            // DueDateDTP
            // 
            this.DueDateDTP.Location = new System.Drawing.Point(267, 261);
            this.DueDateDTP.Name = "DueDateDTP";
            this.DueDateDTP.Size = new System.Drawing.Size(383, 34);
            this.DueDateDTP.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Remarks";
            // 
            // RemarksTextBox
            // 
            this.RemarksTextBox.Location = new System.Drawing.Point(267, 329);
            this.RemarksTextBox.Multiline = true;
            this.RemarksTextBox.Name = "RemarksTextBox";
            this.RemarksTextBox.Size = new System.Drawing.Size(320, 92);
            this.RemarksTextBox.TabIndex = 11;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(316, 434);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(115, 33);
            this.SubmitButton.TabIndex = 12;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CustLookupButton
            // 
            this.CustLookupButton.Location = new System.Drawing.Point(460, 44);
            this.CustLookupButton.Name = "CustLookupButton";
            this.CustLookupButton.Size = new System.Drawing.Size(42, 33);
            this.CustLookupButton.TabIndex = 13;
            this.CustLookupButton.Text = "...";
            this.CustLookupButton.UseVisualStyleBackColor = true;
            this.CustLookupButton.Click += new System.EventHandler(this.CustLookupButton_Click);
            // 
            // VideoLookupButton
            // 
            this.VideoLookupButton.Location = new System.Drawing.Point(460, 132);
            this.VideoLookupButton.Name = "VideoLookupButton";
            this.VideoLookupButton.Size = new System.Drawing.Size(42, 33);
            this.VideoLookupButton.TabIndex = 14;
            this.VideoLookupButton.Text = "...";
            this.VideoLookupButton.UseVisualStyleBackColor = true;
            this.VideoLookupButton.Click += new System.EventHandler(this.VideoLookupButton_Click);
            // 
            // CustNameTextBox
            // 
            this.CustNameTextBox.Location = new System.Drawing.Point(267, 85);
            this.CustNameTextBox.Name = "CustNameTextBox";
            this.CustNameTextBox.ReadOnly = true;
            this.CustNameTextBox.Size = new System.Drawing.Size(246, 34);
            this.CustNameTextBox.TabIndex = 15;
            // 
            // MovieTitleTextBox
            // 
            this.MovieTitleTextBox.Location = new System.Drawing.Point(266, 170);
            this.MovieTitleTextBox.Name = "MovieTitleTextBox";
            this.MovieTitleTextBox.ReadOnly = true;
            this.MovieTitleTextBox.Size = new System.Drawing.Size(246, 34);
            this.MovieTitleTextBox.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 540);
            this.Controls.Add(this.MovieTitleTextBox);
            this.Controls.Add(this.CustNameTextBox);
            this.Controls.Add(this.VideoLookupButton);
            this.Controls.Add(this.CustLookupButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.RemarksTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DueDateDTP);
            this.Controls.Add(this.IssueDateDTP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.VideoCodeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CIDTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CIDTextBox;
        private System.Windows.Forms.TextBox VideoCodeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker IssueDateDTP;
        private System.Windows.Forms.DateTimePicker DueDateDTP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox RemarksTextBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button CustLookupButton;
        private System.Windows.Forms.Button VideoLookupButton;
        private System.Windows.Forms.TextBox CustNameTextBox;
        private System.Windows.Forms.TextBox MovieTitleTextBox;
    }
}

