
namespace Csharp作業集
{
    partial class 成績統計2
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
            this.components = new System.ComponentModel.Container();
            this.nemelb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.單一學生 = new System.Windows.Forms.Button();
            this.隨機加入 = new System.Windows.Forms.Button();
            this.總結 = new System.Windows.Forms.Button();
            this.重設 = new System.Windows.Forms.Button();
            this.隨機20 = new System.Windows.Forms.Button();
            this.score = new System.Windows.Forms.Label();
            this.allscore = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nametx = new System.Windows.Forms.TextBox();
            this.mathtx = new System.Windows.Forms.TextBox();
            this.entx = new System.Windows.Forms.TextBox();
            this.chtx = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.scorename = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nemelb
            // 
            this.nemelb.Font = new System.Drawing.Font("新細明體", 14F);
            this.nemelb.Location = new System.Drawing.Point(21, 51);
            this.nemelb.Name = "nemelb";
            this.nemelb.Size = new System.Drawing.Size(61, 23);
            this.nemelb.TabIndex = 0;
            this.nemelb.Text = "姓名:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("新細明體", 14F);
            this.label1.Location = new System.Drawing.Point(21, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "數學:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("新細明體", 14F);
            this.label2.Location = new System.Drawing.Point(21, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "國文:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("新細明體", 14F);
            this.label3.Location = new System.Drawing.Point(21, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "英文:";
            // 
            // 單一學生
            // 
            this.單一學生.Font = new System.Drawing.Font("新細明體", 12F);
            this.單一學生.Location = new System.Drawing.Point(25, 203);
            this.單一學生.Name = "單一學生";
            this.單一學生.Size = new System.Drawing.Size(124, 52);
            this.單一學生.TabIndex = 9;
            this.單一學生.Text = "加入學生資料";
            this.單一學生.UseVisualStyleBackColor = true;
            this.單一學生.Click += new System.EventHandler(this.button1_Click);
            // 
            // 隨機加入
            // 
            this.隨機加入.Font = new System.Drawing.Font("新細明體", 12F);
            this.隨機加入.Location = new System.Drawing.Point(25, 261);
            this.隨機加入.Name = "隨機加入";
            this.隨機加入.Size = new System.Drawing.Size(124, 52);
            this.隨機加入.TabIndex = 10;
            this.隨機加入.Text = "隨機儲存資料";
            this.隨機加入.UseVisualStyleBackColor = true;
            this.隨機加入.Click += new System.EventHandler(this.隨機加入_Click);
            // 
            // 總結
            // 
            this.總結.CausesValidation = false;
            this.總結.Enabled = false;
            this.總結.Font = new System.Drawing.Font("新細明體", 12F);
            this.總結.Location = new System.Drawing.Point(25, 319);
            this.總結.Name = "總結";
            this.總結.Size = new System.Drawing.Size(124, 52);
            this.總結.TabIndex = 11;
            this.總結.Text = "各科統計";
            this.總結.UseVisualStyleBackColor = true;
            this.總結.Click += new System.EventHandler(this.button3_Click);
            // 
            // 重設
            // 
            this.重設.Font = new System.Drawing.Font("新細明體", 12F);
            this.重設.Location = new System.Drawing.Point(25, 413);
            this.重設.Name = "重設";
            this.重設.Size = new System.Drawing.Size(124, 32);
            this.重設.TabIndex = 12;
            this.重設.Text = "重設所有資料";
            this.重設.UseVisualStyleBackColor = true;
            this.重設.Click += new System.EventHandler(this.button4_Click);
            // 
            // 隨機20
            // 
            this.隨機20.Font = new System.Drawing.Font("新細明體", 12F);
            this.隨機20.Location = new System.Drawing.Point(25, 457);
            this.隨機20.Name = "隨機20";
            this.隨機20.Size = new System.Drawing.Size(124, 32);
            this.隨機20.TabIndex = 13;
            this.隨機20.Text = "隨機加入20筆";
            this.隨機20.UseVisualStyleBackColor = true;
            this.隨機20.Click += new System.EventHandler(this.隨機20_Click);
            // 
            // score
            // 
            this.score.AllowDrop = true;
            this.score.AutoSize = true;
            this.score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.score.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.score.Font = new System.Drawing.Font("新細明體", 14F);
            this.score.Location = new System.Drawing.Point(0, 22);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(2, 21);
            this.score.TabIndex = 14;
            this.score.Click += new System.EventHandler(this.score_Click);
            // 
            // allscore
            // 
            this.allscore.BackColor = System.Drawing.SystemColors.Highlight;
            this.allscore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.allscore.Font = new System.Drawing.Font("新細明體", 14F);
            this.allscore.ForeColor = System.Drawing.Color.Black;
            this.allscore.Location = new System.Drawing.Point(-1, 0);
            this.allscore.Name = "allscore";
            this.allscore.Size = new System.Drawing.Size(419, 114);
            this.allscore.TabIndex = 15;
            this.allscore.Text = "\r\n";
            // 
            // nametx
            // 
            this.nametx.Location = new System.Drawing.Point(88, 51);
            this.nametx.Name = "nametx";
            this.nametx.Size = new System.Drawing.Size(100, 22);
            this.nametx.TabIndex = 16;
            // 
            // mathtx
            // 
            this.mathtx.Location = new System.Drawing.Point(88, 90);
            this.mathtx.Name = "mathtx";
            this.mathtx.Size = new System.Drawing.Size(100, 22);
            this.mathtx.TabIndex = 17;
            // 
            // entx
            // 
            this.entx.Location = new System.Drawing.Point(88, 125);
            this.entx.Name = "entx";
            this.entx.Size = new System.Drawing.Size(100, 22);
            this.entx.TabIndex = 18;
            // 
            // chtx
            // 
            this.chtx.Location = new System.Drawing.Point(88, 163);
            this.chtx.Name = "chtx";
            this.chtx.Size = new System.Drawing.Size(100, 22);
            this.chtx.TabIndex = 19;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splitContainer1.Location = new System.Drawing.Point(304, 53);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AllowDrop = true;
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.scorename);
            this.splitContainer1.Panel1.Controls.Add(this.score);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint_1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.allscore);
            this.splitContainer1.Size = new System.Drawing.Size(381, 450);
            this.splitContainer1.SplitterDistance = 326;
            this.splitContainer1.TabIndex = 20;
            // 
            // scorename
            // 
            this.scorename.AllowDrop = true;
            this.scorename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.scorename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scorename.Font = new System.Drawing.Font("新細明體", 14F);
            this.scorename.Location = new System.Drawing.Point(0, 1);
            this.scorename.Name = "scorename";
            this.scorename.Size = new System.Drawing.Size(380, 21);
            this.scorename.TabIndex = 21;
            // 
            // 成績統計2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1025, 651);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.隨機加入);
            this.Controls.Add(this.chtx);
            this.Controls.Add(this.單一學生);
            this.Controls.Add(this.nemelb);
            this.Controls.Add(this.總結);
            this.Controls.Add(this.entx);
            this.Controls.Add(this.重設);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.隨機20);
            this.Controls.Add(this.mathtx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nametx);
            this.Name = "成績統計2";
            this.Text = "作業5";
            this.Load += new System.EventHandler(this.作業5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nemelb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button 單一學生;
        private System.Windows.Forms.Button 隨機加入;
        private System.Windows.Forms.Button 總結;
        private System.Windows.Forms.Button 重設;
        private System.Windows.Forms.Button 隨機20;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label allscore;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox nametx;
        private System.Windows.Forms.TextBox mathtx;
        private System.Windows.Forms.TextBox entx;
        private System.Windows.Forms.TextBox chtx;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label scorename;
    }
}