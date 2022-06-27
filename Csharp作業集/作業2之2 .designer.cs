
namespace Csharp作業集
{
    partial class 總結
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(總結));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.lb5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("新細明體", 20F);
            this.label1.Location = new System.Drawing.Point(25, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "貸款金額";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("新細明體", 20F);
            this.label2.Location = new System.Drawing.Point(25, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "月付額";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("新細明體", 20F);
            this.label3.Location = new System.Drawing.Point(25, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "利率(%)";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("新細明體", 20F);
            this.label4.Location = new System.Drawing.Point(25, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "期限(年)";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("新細明體", 20F);
            this.label5.Location = new System.Drawing.Point(25, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "總付款";
            // 
            // lb1
            // 
            this.lb1.Font = new System.Drawing.Font("新細明體", 20F);
            this.lb1.Location = new System.Drawing.Point(174, 84);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(125, 33);
            this.lb1.TabIndex = 5;
            // 
            // lb2
            // 
            this.lb2.Font = new System.Drawing.Font("新細明體", 20F);
            this.lb2.Location = new System.Drawing.Point(174, 129);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(125, 33);
            this.lb2.TabIndex = 6;
            // 
            // lb3
            // 
            this.lb3.Font = new System.Drawing.Font("新細明體", 20F);
            this.lb3.Location = new System.Drawing.Point(174, 181);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(125, 33);
            this.lb3.TabIndex = 7;
            // 
            // lb4
            // 
            this.lb4.Font = new System.Drawing.Font("新細明體", 20F);
            this.lb4.Location = new System.Drawing.Point(174, 228);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(125, 33);
            this.lb4.TabIndex = 8;
            // 
            // lb5
            // 
            this.lb5.Font = new System.Drawing.Font("新細明體", 20F);
            this.lb5.Location = new System.Drawing.Point(174, 273);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(125, 33);
            this.lb5.TabIndex = 9;
            // 
            // 總結
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb5);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "總結";
            this.Text = "Report";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label lb1;
        internal System.Windows.Forms.Label lb2;
        internal System.Windows.Forms.Label lb3;
        internal System.Windows.Forms.Label lb4;
        internal System.Windows.Forms.Label lb5;
    }
}