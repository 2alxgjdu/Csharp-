
namespace Csharp作業集
{
    partial class 貸款計算
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(貸款計算));
            this.money = new System.Windows.Forms.Label();
            this.fmoney = new System.Windows.Forms.Label();
            this.percent = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.Label();
            this.moneytx = new System.Windows.Forms.TextBox();
            this.percenttx = new System.Windows.Forms.TextBox();
            this.fmoneytx = new System.Windows.Forms.TextBox();
            this.yeartx = new System.Windows.Forms.TextBox();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // money
            // 
            this.money.BackColor = System.Drawing.Color.Transparent;
            this.money.Font = new System.Drawing.Font("新細明體", 20F);
            this.money.ForeColor = System.Drawing.SystemColors.Control;
            this.money.Location = new System.Drawing.Point(122, 87);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(124, 31);
            this.money.TabIndex = 0;
            this.money.Text = "貸款金額";
            // 
            // fmoney
            // 
            this.fmoney.BackColor = System.Drawing.Color.Transparent;
            this.fmoney.Font = new System.Drawing.Font("新細明體", 20F);
            this.fmoney.ForeColor = System.Drawing.SystemColors.Control;
            this.fmoney.Location = new System.Drawing.Point(117, 263);
            this.fmoney.Name = "fmoney";
            this.fmoney.Size = new System.Drawing.Size(124, 31);
            this.fmoney.TabIndex = 1;
            this.fmoney.Text = "頭期款";
            // 
            // percent
            // 
            this.percent.BackColor = System.Drawing.Color.Transparent;
            this.percent.Font = new System.Drawing.Font("新細明體", 20F);
            this.percent.ForeColor = System.Drawing.SystemColors.Control;
            this.percent.Location = new System.Drawing.Point(117, 208);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(124, 31);
            this.percent.TabIndex = 2;
            this.percent.Text = "利率(%)";
            // 
            // year
            // 
            this.year.BackColor = System.Drawing.Color.Transparent;
            this.year.Font = new System.Drawing.Font("新細明體", 20F);
            this.year.ForeColor = System.Drawing.SystemColors.Control;
            this.year.Location = new System.Drawing.Point(117, 151);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(124, 31);
            this.year.TabIndex = 3;
            this.year.Text = "期限(年)";
            // 
            // moneytx
            // 
            this.moneytx.Font = new System.Drawing.Font("新細明體", 20F);
            this.moneytx.Location = new System.Drawing.Point(303, 87);
            this.moneytx.Name = "moneytx";
            this.moneytx.Size = new System.Drawing.Size(166, 39);
            this.moneytx.TabIndex = 4;
            // 
            // percenttx
            // 
            this.percenttx.Font = new System.Drawing.Font("新細明體", 20F);
            this.percenttx.Location = new System.Drawing.Point(303, 205);
            this.percenttx.Name = "percenttx";
            this.percenttx.Size = new System.Drawing.Size(166, 39);
            this.percenttx.TabIndex = 5;
            // 
            // fmoneytx
            // 
            this.fmoneytx.Font = new System.Drawing.Font("新細明體", 20F);
            this.fmoneytx.Location = new System.Drawing.Point(303, 263);
            this.fmoneytx.Name = "fmoneytx";
            this.fmoneytx.Size = new System.Drawing.Size(166, 39);
            this.fmoneytx.TabIndex = 6;
            // 
            // yeartx
            // 
            this.yeartx.Font = new System.Drawing.Font("新細明體", 20F);
            this.yeartx.Location = new System.Drawing.Point(303, 148);
            this.yeartx.Name = "yeartx";
            this.yeartx.Size = new System.Drawing.Size(166, 39);
            this.yeartx.TabIndex = 7;
            // 
            // bt1
            // 
            this.bt1.Font = new System.Drawing.Font("新細明體", 20F);
            this.bt1.Location = new System.Drawing.Point(122, 325);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(124, 41);
            this.bt1.TabIndex = 8;
            this.bt1.Text = "月付額";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt2
            // 
            this.bt2.Font = new System.Drawing.Font("新細明體", 20F);
            this.bt2.Location = new System.Drawing.Point(303, 325);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(124, 41);
            this.bt2.TabIndex = 9;
            this.bt2.Text = "總付款";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt3
            // 
            this.bt3.Font = new System.Drawing.Font("新細明體", 20F);
            this.bt3.Location = new System.Drawing.Point(508, 325);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(124, 41);
            this.bt3.TabIndex = 10;
            this.bt3.Text = "Report";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // 貸款計算
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.yeartx);
            this.Controls.Add(this.fmoneytx);
            this.Controls.Add(this.percenttx);
            this.Controls.Add(this.moneytx);
            this.Controls.Add(this.year);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.fmoney);
            this.Controls.Add(this.money);
            this.Name = "貸款計算";
            this.Text = "貸款計算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label money;
        private System.Windows.Forms.Label fmoney;
        private System.Windows.Forms.Label percent;
        private System.Windows.Forms.Label year;
        private System.Windows.Forms.TextBox moneytx;
        private System.Windows.Forms.TextBox percenttx;
        private System.Windows.Forms.TextBox fmoneytx;
        private System.Windows.Forms.TextBox yeartx;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
    }
}

