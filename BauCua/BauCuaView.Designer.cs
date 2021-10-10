
namespace KhanhClient
{
    partial class BauCua
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
            this.Timelabel = new System.Windows.Forms.Label();
            this.HuouBtn = new System.Windows.Forms.Button();
            this.BauBtn = new System.Windows.Forms.Button();
            this.GaBtn = new System.Windows.Forms.Button();
            this.Tombtn = new System.Windows.Forms.Button();
            this.CuaBtn = new System.Windows.Forms.Button();
            this.CaBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thời gian :";
            // 
            // Timelabel
            // 
            this.Timelabel.AutoSize = true;
            this.Timelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timelabel.Location = new System.Drawing.Point(379, 71);
            this.Timelabel.Name = "Timelabel";
            this.Timelabel.Size = new System.Drawing.Size(30, 22);
            this.Timelabel.TabIndex = 1;
            this.Timelabel.Text = "50";
            // 
            // HuouBtn
            // 
            this.HuouBtn.Location = new System.Drawing.Point(132, 115);
            this.HuouBtn.Name = "HuouBtn";
            this.HuouBtn.Size = new System.Drawing.Size(114, 60);
            this.HuouBtn.TabIndex = 2;
            this.HuouBtn.Text = "Hươu";
            this.HuouBtn.UseVisualStyleBackColor = true;
            // 
            // BauBtn
            // 
            this.BauBtn.Location = new System.Drawing.Point(311, 115);
            this.BauBtn.Name = "BauBtn";
            this.BauBtn.Size = new System.Drawing.Size(117, 60);
            this.BauBtn.TabIndex = 3;
            this.BauBtn.Text = "Bầu";
            this.BauBtn.UseVisualStyleBackColor = true;
            // 
            // GaBtn
            // 
            this.GaBtn.Location = new System.Drawing.Point(482, 115);
            this.GaBtn.Name = "GaBtn";
            this.GaBtn.Size = new System.Drawing.Size(119, 60);
            this.GaBtn.TabIndex = 4;
            this.GaBtn.Text = "Gà";
            this.GaBtn.UseVisualStyleBackColor = true;
            // 
            // Tombtn
            // 
            this.Tombtn.Location = new System.Drawing.Point(132, 235);
            this.Tombtn.Name = "Tombtn";
            this.Tombtn.Size = new System.Drawing.Size(114, 66);
            this.Tombtn.TabIndex = 5;
            this.Tombtn.Text = "Tôm";
            this.Tombtn.UseVisualStyleBackColor = true;
            // 
            // CuaBtn
            // 
            this.CuaBtn.Location = new System.Drawing.Point(311, 235);
            this.CuaBtn.Name = "CuaBtn";
            this.CuaBtn.Size = new System.Drawing.Size(114, 66);
            this.CuaBtn.TabIndex = 6;
            this.CuaBtn.Text = "Cua";
            this.CuaBtn.UseVisualStyleBackColor = true;
            // 
            // CaBtn
            // 
            this.CaBtn.Location = new System.Drawing.Point(482, 235);
            this.CaBtn.Name = "CaBtn";
            this.CaBtn.Size = new System.Drawing.Size(119, 66);
            this.CaBtn.TabIndex = 7;
            this.CaBtn.Text = "Cá";
            this.CaBtn.UseVisualStyleBackColor = true;
            // 
            // BauCua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CaBtn);
            this.Controls.Add(this.CuaBtn);
            this.Controls.Add(this.Tombtn);
            this.Controls.Add(this.GaBtn);
            this.Controls.Add(this.BauBtn);
            this.Controls.Add(this.HuouBtn);
            this.Controls.Add(this.Timelabel);
            this.Controls.Add(this.label1);
            this.Name = "BauCua";
            this.Text = "BauCua";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Timelabel;
        private System.Windows.Forms.Button HuouBtn;
        private System.Windows.Forms.Button BauBtn;
        private System.Windows.Forms.Button GaBtn;
        private System.Windows.Forms.Button Tombtn;
        private System.Windows.Forms.Button CuaBtn;
        private System.Windows.Forms.Button CaBtn;
    }
}