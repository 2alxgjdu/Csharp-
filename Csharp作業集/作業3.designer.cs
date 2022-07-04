
namespace Csharp作業集
{
    partial class 菜單
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(菜單));
            this.memulb = new System.Windows.Forms.Label();
            this.julice01LB = new System.Windows.Forms.Button();
            this.julice02LB = new System.Windows.Forms.Button();
            this.allLB = new System.Windows.Forms.Button();
            this.chocoLB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.card = new System.Windows.Forms.Button();
            this.cash = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.menufrom = new System.Windows.Forms.Label();
            this.money = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // memulb
            // 
            this.memulb.BackColor = System.Drawing.Color.Transparent;
            this.memulb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.memulb.Font = new System.Drawing.Font("新細明體", 20F);
            this.memulb.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.memulb.Location = new System.Drawing.Point(12, 36);
            this.memulb.Name = "memulb";
            this.memulb.Size = new System.Drawing.Size(292, 347);
            this.memulb.TabIndex = 0;
            this.memulb.Text = "菜單menu";
            // 
            // julice01LB
            // 
            this.julice01LB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("julice01LB.BackgroundImage")));
            this.julice01LB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.julice01LB.Font = new System.Drawing.Font("新細明體", 20F);
            this.julice01LB.Location = new System.Drawing.Point(26, 78);
            this.julice01LB.Name = "julice01LB";
            this.julice01LB.Size = new System.Drawing.Size(112, 119);
            this.julice01LB.TabIndex = 1;
            this.julice01LB.Text = "柳橙汁\r\n30元\r\n";
            this.julice01LB.UseVisualStyleBackColor = true;
            this.julice01LB.Click += new System.EventHandler(this.julice1LB_Click);
            // 
            // julice02LB
            // 
            this.julice02LB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("julice02LB.BackgroundImage")));
            this.julice02LB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.julice02LB.Font = new System.Drawing.Font("新細明體", 20F);
            this.julice02LB.Location = new System.Drawing.Point(161, 78);
            this.julice02LB.Name = "julice02LB";
            this.julice02LB.Size = new System.Drawing.Size(112, 119);
            this.julice02LB.TabIndex = 2;
            this.julice02LB.Text = "檸檬汁\r\n35元\r\n";
            this.julice02LB.UseVisualStyleBackColor = true;
            this.julice02LB.Click += new System.EventHandler(this.julice02LB_Click);
            // 
            // allLB
            // 
            this.allLB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("allLB.BackgroundImage")));
            this.allLB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.allLB.Font = new System.Drawing.Font("新細明體", 20F);
            this.allLB.Location = new System.Drawing.Point(26, 229);
            this.allLB.Name = "allLB";
            this.allLB.Size = new System.Drawing.Size(112, 119);
            this.allLB.TabIndex = 3;
            this.allLB.Text = "綜合百匯\r\n250元\r\n";
            this.allLB.UseVisualStyleBackColor = true;
            this.allLB.Click += new System.EventHandler(this.allLB_Click);
            // 
            // chocoLB
            // 
            this.chocoLB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chocoLB.BackgroundImage")));
            this.chocoLB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chocoLB.Font = new System.Drawing.Font("新細明體", 20F);
            this.chocoLB.Location = new System.Drawing.Point(161, 229);
            this.chocoLB.Name = "chocoLB";
            this.chocoLB.Size = new System.Drawing.Size(112, 119);
            this.chocoLB.TabIndex = 4;
            this.chocoLB.Text = "巧克力百匯\r\n220元\r\n";
            this.chocoLB.UseVisualStyleBackColor = true;
            this.chocoLB.Click += new System.EventHandler(this.chocoLB_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("新細明體", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label1.Location = new System.Drawing.Point(310, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 109);
            this.label1.TabIndex = 5;
            this.label1.Text = "總金額      total price";
            // 
            // pc
            // 
            this.pc.BackColor = System.Drawing.SystemColors.Window;
            this.pc.Font = new System.Drawing.Font("新細明體", 20F);
            this.pc.Location = new System.Drawing.Point(329, 69);
            this.pc.Name = "pc";
            this.pc.Size = new System.Drawing.Size(229, 33);
            this.pc.TabIndex = 6;
            this.pc.Text = "NT $ 元";
            this.pc.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("新細明體", 20F);
            this.label3.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label3.Location = new System.Drawing.Point(310, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 135);
            this.label3.TabIndex = 7;
            this.label3.Text = "總金額      total price";
            // 
            // card
            // 
            this.card.Font = new System.Drawing.Font("新細明體", 15F);
            this.card.Location = new System.Drawing.Point(446, 220);
            this.card.Name = "card";
            this.card.Size = new System.Drawing.Size(112, 46);
            this.card.TabIndex = 8;
            this.card.Text = "信用卡";
            this.card.UseVisualStyleBackColor = true;
            this.card.Click += new System.EventHandler(this.card_Click);
            // 
            // cash
            // 
            this.cash.Font = new System.Drawing.Font("新細明體", 15F);
            this.cash.Location = new System.Drawing.Point(310, 220);
            this.cash.Name = "cash";
            this.cash.Size = new System.Drawing.Size(112, 46);
            this.cash.TabIndex = 9;
            this.cash.Text = "現金";
            this.cash.UseVisualStyleBackColor = true;
            this.cash.Click += new System.EventHandler(this.cash_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("新細明體", 12F);
            this.label4.Location = new System.Drawing.Point(389, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "現在信用卡付費只要9折";
            // 
            // menufrom
            // 
            this.menufrom.BackColor = System.Drawing.Color.Transparent;
            this.menufrom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.menufrom.Font = new System.Drawing.Font("新細明體", 20F);
            this.menufrom.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.menufrom.Location = new System.Drawing.Point(573, 36);
            this.menufrom.Name = "menufrom";
            this.menufrom.Size = new System.Drawing.Size(292, 373);
            this.menufrom.TabIndex = 11;
            this.menufrom.Text = "點菜清單";
            // 
            // money
            // 
            this.money.BackColor = System.Drawing.Color.Wheat;
            this.money.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.money.Font = new System.Drawing.Font("新細明體", 15F);
            this.money.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.money.Location = new System.Drawing.Point(605, 82);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(238, 266);
            this.money.TabIndex = 12;
            this.money.Text = "尚未點餐";
            this.money.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.money.Click += new System.EventHandler(this.money_Click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("新細明體", 15F);
            this.clear.Location = new System.Drawing.Point(743, 351);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(112, 46);
            this.clear.TabIndex = 13;
            this.clear.Text = "清除清單";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // 菜單
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(867, 528);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.money);
            this.Controls.Add(this.menufrom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cash);
            this.Controls.Add(this.card);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chocoLB);
            this.Controls.Add(this.allLB);
            this.Controls.Add(this.julice02LB);
            this.Controls.Add(this.julice01LB);
            this.Controls.Add(this.memulb);
            this.Name = "菜單";
            this.Text = "菜單";
            this.Load += new System.EventHandler(this.菜單_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label memulb;
        private System.Windows.Forms.Button julice01LB;
        private System.Windows.Forms.Button julice02LB;
        private System.Windows.Forms.Button allLB;
        private System.Windows.Forms.Button chocoLB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button card;
        private System.Windows.Forms.Button cash;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label menufrom;
        private System.Windows.Forms.Label money;
        private System.Windows.Forms.Button clear;
    }
}

