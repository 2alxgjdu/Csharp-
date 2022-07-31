
namespace Csharp作業集
{
    partial class 介紹
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(介紹));
            this.nametx = new System.Windows.Forms.TextBox();
            this.mgtx = new System.Windows.Forms.TextBox();
            this.bloodtx = new System.Windows.Forms.TextBox();
            this.ennametx = new System.Windows.Forms.TextBox();
            this.cn = new System.Windows.Forms.Button();
            this.en = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.mg = new System.Windows.Forms.Label();
            this.blood = new System.Windows.Forms.Label();
            this.ENname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nametx
            // 
            this.nametx.Font = new System.Drawing.Font("新細明體", 20F);
            this.nametx.Location = new System.Drawing.Point(526, 76);
            this.nametx.Name = "nametx";
            this.nametx.Size = new System.Drawing.Size(200, 39);
            this.nametx.TabIndex = 0;
            // 
            // mgtx
            // 
            this.mgtx.Font = new System.Drawing.Font("新細明體", 20F);
            this.mgtx.Location = new System.Drawing.Point(526, 266);
            this.mgtx.Name = "mgtx";
            this.mgtx.Size = new System.Drawing.Size(200, 39);
            this.mgtx.TabIndex = 1;
            // 
            // bloodtx
            // 
            this.bloodtx.Font = new System.Drawing.Font("新細明體", 20F);
            this.bloodtx.Location = new System.Drawing.Point(526, 209);
            this.bloodtx.Name = "bloodtx";
            this.bloodtx.Size = new System.Drawing.Size(200, 39);
            this.bloodtx.TabIndex = 2;
            // 
            // ennametx
            // 
            this.ennametx.Font = new System.Drawing.Font("新細明體", 20F);
            this.ennametx.Location = new System.Drawing.Point(526, 144);
            this.ennametx.Name = "ennametx";
            this.ennametx.Size = new System.Drawing.Size(200, 39);
            this.ennametx.TabIndex = 3;
            // 
            // cn
            // 
            this.cn.Font = new System.Drawing.Font("新細明體", 20F);
            this.cn.Location = new System.Drawing.Point(81, 340);
            this.cn.Name = "cn";
            this.cn.Size = new System.Drawing.Size(144, 52);
            this.cn.TabIndex = 4;
            this.cn.Text = "中文";
            this.cn.UseVisualStyleBackColor = true;
            this.cn.Click += new System.EventHandler(this.cn_Click);
            // 
            // en
            // 
            this.en.Font = new System.Drawing.Font("新細明體", 20F);
            this.en.Location = new System.Drawing.Point(526, 340);
            this.en.Name = "en";
            this.en.Size = new System.Drawing.Size(144, 52);
            this.en.TabIndex = 5;
            this.en.Text = "英文";
            this.en.UseVisualStyleBackColor = true;
            this.en.Click += new System.EventHandler(this.en_Click);
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("新細明體", 20F);
            this.name.Location = new System.Drawing.Point(76, 79);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(149, 39);
            this.name.TabIndex = 6;
            this.name.Text = "中文姓名";
            // 
            // mg
            // 
            this.mg.Font = new System.Drawing.Font("新細明體", 20F);
            this.mg.Location = new System.Drawing.Point(76, 266);
            this.mg.Name = "mg";
            this.mg.Size = new System.Drawing.Size(149, 39);
            this.mg.TabIndex = 7;
            this.mg.Text = "性別";
            // 
            // blood
            // 
            this.blood.Font = new System.Drawing.Font("新細明體", 20F);
            this.blood.Location = new System.Drawing.Point(76, 209);
            this.blood.Name = "blood";
            this.blood.Size = new System.Drawing.Size(149, 39);
            this.blood.TabIndex = 8;
            this.blood.Text = "血型";
            // 
            // ENname
            // 
            this.ENname.Font = new System.Drawing.Font("新細明體", 20F);
            this.ENname.Location = new System.Drawing.Point(76, 144);
            this.ENname.Name = "ENname";
            this.ENname.Size = new System.Drawing.Size(149, 39);
            this.ENname.TabIndex = 9;
            this.ENname.Text = "英文姓名";
            // 
            // 介紹
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ENname);
            this.Controls.Add(this.blood);
            this.Controls.Add(this.mg);
            this.Controls.Add(this.name);
            this.Controls.Add(this.en);
            this.Controls.Add(this.cn);
            this.Controls.Add(this.ennametx);
            this.Controls.Add(this.bloodtx);
            this.Controls.Add(this.mgtx);
            this.Controls.Add(this.nametx);
            this.Name = "介紹";
            this.Text = "自我介紹";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nametx;
        private System.Windows.Forms.TextBox mgtx;
        private System.Windows.Forms.TextBox bloodtx;
        private System.Windows.Forms.TextBox ennametx;
        private System.Windows.Forms.Button cn;
        private System.Windows.Forms.Button en;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label mg;
        private System.Windows.Forms.Label blood;
        private System.Windows.Forms.Label ENname;
    }
}

