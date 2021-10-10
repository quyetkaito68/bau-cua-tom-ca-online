
namespace BauCuaServer
{
    partial class MayChu
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
            this.TimeBtn = new System.Windows.Forms.Button();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.result1 = new System.Windows.Forms.Label();
            this.result2 = new System.Windows.Forms.Label();
            this.result3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TimeBtn
            // 
            this.TimeBtn.Location = new System.Drawing.Point(325, 208);
            this.TimeBtn.Name = "TimeBtn";
            this.TimeBtn.Size = new System.Drawing.Size(75, 23);
            this.TimeBtn.TabIndex = 0;
            this.TimeBtn.Text = "Time";
            this.TimeBtn.UseVisualStyleBackColor = true;
            this.TimeBtn.Click += new System.EventHandler(this.TimeBtn_Click);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(345, 75);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(35, 13);
            this.TimeLabel.TabIndex = 1;
            this.TimeLabel.Text = "label1";
            // 
            // result1
            // 
            this.result1.AutoSize = true;
            this.result1.Location = new System.Drawing.Point(193, 128);
            this.result1.Name = "result1";
            this.result1.Size = new System.Drawing.Size(33, 13);
            this.result1.TabIndex = 2;
            this.result1.Text = "Huou";
            // 
            // result2
            // 
            this.result2.AutoSize = true;
            this.result2.Location = new System.Drawing.Point(345, 128);
            this.result2.Name = "result2";
            this.result2.Size = new System.Drawing.Size(33, 13);
            this.result2.TabIndex = 3;
            this.result2.Text = "Huou";
            // 
            // result3
            // 
            this.result3.AutoSize = true;
            this.result3.Location = new System.Drawing.Point(516, 128);
            this.result3.Name = "result3";
            this.result3.Size = new System.Drawing.Size(33, 13);
            this.result3.TabIndex = 4;
            this.result3.Text = "Huou";
            // 
            // MayChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.result3);
            this.Controls.Add(this.result2);
            this.Controls.Add(this.result1);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.TimeBtn);
            this.Name = "MayChu";
            this.Text = "MayChu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TimeBtn;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label result1;
        private System.Windows.Forms.Label result2;
        private System.Windows.Forms.Label result3;
    }
}