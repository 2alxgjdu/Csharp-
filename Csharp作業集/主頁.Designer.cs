
namespace Csharp作業集
{
    partial class 主頁
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(主頁));
            this.框1 = new System.Windows.Forms.SplitContainer();
            this.框2 = new System.Windows.Forms.SplitContainer();
            this.OXgame = new System.Windows.Forms.Button();
            this.計算機 = new System.Windows.Forms.Button();
            this.自我介紹 = new System.Windows.Forms.Button();
            this.成績搜尋 = new System.Windows.Forms.Button();
            this.貸款計算 = new System.Windows.Forms.Button();
            this.成績登入 = new System.Windows.Forms.Button();
            this.成績統計 = new System.Windows.Forms.Button();
            this.點菜單 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.框1)).BeginInit();
            this.框1.Panel2.SuspendLayout();
            this.框1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.框2)).BeginInit();
            this.框2.Panel1.SuspendLayout();
            this.框2.SuspendLayout();
            this.SuspendLayout();
            // 
            // 框1
            // 
            this.框1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.框1.Location = new System.Drawing.Point(0, 0);
            this.框1.Name = "框1";
            this.框1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // 框1.Panel1
            // 
            this.框1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.框1.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("框1.Panel1.BackgroundImage")));
            this.框1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.框1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // 框1.Panel2
            // 
            this.框1.Panel2.AutoScroll = true;
            this.框1.Panel2.Controls.Add(this.框2);
            this.框1.Size = new System.Drawing.Size(923, 561);
            this.框1.SplitterDistance = 142;
            this.框1.SplitterWidth = 6;
            this.框1.TabIndex = 0;
            // 
            // 框2
            // 
            this.框2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.框2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.框2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.框2.Location = new System.Drawing.Point(0, 0);
            this.框2.Name = "框2";
            // 
            // 框2.Panel1
            // 
            this.框2.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.框2.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("框2.Panel1.BackgroundImage")));
            this.框2.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.框2.Panel1.Controls.Add(this.button1);
            this.框2.Panel1.Controls.Add(this.OXgame);
            this.框2.Panel1.Controls.Add(this.計算機);
            this.框2.Panel1.Controls.Add(this.自我介紹);
            this.框2.Panel1.Controls.Add(this.成績搜尋);
            this.框2.Panel1.Controls.Add(this.貸款計算);
            this.框2.Panel1.Controls.Add(this.成績登入);
            this.框2.Panel1.Controls.Add(this.成績統計);
            this.框2.Panel1.Controls.Add(this.點菜單);
            // 
            // 框2.Panel2
            // 
            this.框2.Panel2.AutoScroll = true;
            this.框2.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.框2.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("框2.Panel2.BackgroundImage")));
            this.框2.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.框2.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.框2_Panel2_Paint);
            this.框2.Size = new System.Drawing.Size(923, 413);
            this.框2.SplitterDistance = 285;
            this.框2.SplitterWidth = 6;
            this.框2.TabIndex = 0;
            // 
            // OXgame
            // 
            this.OXgame.Font = new System.Drawing.Font("新細明體", 14F);
            this.OXgame.Location = new System.Drawing.Point(4, 153);
            this.OXgame.Name = "OXgame";
            this.OXgame.Size = new System.Drawing.Size(115, 28);
            this.OXgame.TabIndex = 15;
            this.OXgame.Text = "井字遊戲";
            this.OXgame.UseVisualStyleBackColor = true;
            this.OXgame.Click += new System.EventHandler(this.OXgame_Click);
            // 
            // 計算機
            // 
            this.計算機.Font = new System.Drawing.Font("新細明體", 14F);
            this.計算機.Location = new System.Drawing.Point(4, 221);
            this.計算機.Name = "計算機";
            this.計算機.Size = new System.Drawing.Size(115, 28);
            this.計算機.TabIndex = 14;
            this.計算機.Text = "計算機";
            this.計算機.UseVisualStyleBackColor = true;
            this.計算機.Click += new System.EventHandler(this.計算機_Click);
            // 
            // 自我介紹
            // 
            this.自我介紹.Font = new System.Drawing.Font("新細明體", 14F);
            this.自我介紹.Location = new System.Drawing.Point(4, 3);
            this.自我介紹.Name = "自我介紹";
            this.自我介紹.Size = new System.Drawing.Size(115, 29);
            this.自我介紹.TabIndex = 7;
            this.自我介紹.Text = "自我介紹";
            this.自我介紹.UseVisualStyleBackColor = true;
            this.自我介紹.Click += new System.EventHandler(this.自我介紹_Click);
            // 
            // 成績搜尋
            // 
            this.成績搜尋.Font = new System.Drawing.Font("新細明體", 14F);
            this.成績搜尋.Location = new System.Drawing.Point(3, 187);
            this.成績搜尋.Name = "成績搜尋";
            this.成績搜尋.Size = new System.Drawing.Size(116, 28);
            this.成績搜尋.TabIndex = 12;
            this.成績搜尋.Text = "成績搜尋";
            this.成績搜尋.UseVisualStyleBackColor = true;
            this.成績搜尋.Click += new System.EventHandler(this.成績搜尋_Click);
            // 
            // 貸款計算
            // 
            this.貸款計算.Font = new System.Drawing.Font("新細明體", 14F);
            this.貸款計算.Location = new System.Drawing.Point(4, 118);
            this.貸款計算.Name = "貸款計算";
            this.貸款計算.Size = new System.Drawing.Size(116, 29);
            this.貸款計算.TabIndex = 11;
            this.貸款計算.Text = "貸款計算";
            this.貸款計算.UseVisualStyleBackColor = true;
            this.貸款計算.Click += new System.EventHandler(this.貸款計算_Click);
            // 
            // 成績登入
            // 
            this.成績登入.Font = new System.Drawing.Font("新細明體", 14F);
            this.成績登入.Location = new System.Drawing.Point(4, 78);
            this.成績登入.Name = "成績登入";
            this.成績登入.Size = new System.Drawing.Size(115, 34);
            this.成績登入.TabIndex = 10;
            this.成績登入.Text = "成績登入";
            this.成績登入.UseVisualStyleBackColor = true;
            this.成績登入.Click += new System.EventHandler(this.成績登入_Click);
            // 
            // 成績統計
            // 
            this.成績統計.Font = new System.Drawing.Font("新細明體", 14F);
            this.成績統計.Location = new System.Drawing.Point(4, 255);
            this.成績統計.Name = "成績統計";
            this.成績統計.Size = new System.Drawing.Size(115, 28);
            this.成績統計.TabIndex = 9;
            this.成績統計.Text = "成績統計";
            this.成績統計.UseVisualStyleBackColor = true;
            this.成績統計.Click += new System.EventHandler(this.成績統計_Click);
            // 
            // 點菜單
            // 
            this.點菜單.Font = new System.Drawing.Font("新細明體", 14F);
            this.點菜單.Location = new System.Drawing.Point(4, 38);
            this.點菜單.Name = "點菜單";
            this.點菜單.Size = new System.Drawing.Size(116, 34);
            this.點菜單.TabIndex = 8;
            this.點菜單.Text = "點菜單";
            this.點菜單.UseVisualStyleBackColor = true;
            this.點菜單.Click += new System.EventHandler(this.點菜單_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 14F);
            this.button1.Location = new System.Drawing.Point(4, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 28);
            this.button1.TabIndex = 16;
            this.button1.Text = "陣列表單";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // 主頁
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 561);
            this.Controls.Add(this.框1);
            this.Name = "主頁";
            this.Text = "主頁";
            this.框1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.框1)).EndInit();
            this.框1.ResumeLayout(false);
            this.框2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.框2)).EndInit();
            this.框2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer 框1;
        private System.Windows.Forms.SplitContainer 框2;
        private System.Windows.Forms.Button 自我介紹;
        private System.Windows.Forms.Button 成績搜尋;
        private System.Windows.Forms.Button 貸款計算;
        private System.Windows.Forms.Button 成績登入;
        private System.Windows.Forms.Button 成績統計;
        private System.Windows.Forms.Button 點菜單;
        private System.Windows.Forms.Button 計算機;
        private System.Windows.Forms.Button OXgame;
        private System.Windows.Forms.Button button1;
    }
}