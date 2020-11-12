namespace WP_2020_01_HW02_3A713153
{
    partial class frmGame
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
            this.btnGO = new System.Windows.Forms.Button();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.picResult = new System.Windows.Forms.PictureBox();
            this.btn2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGO
            // 
            this.btnGO.BackColor = System.Drawing.Color.Gold;
            this.btnGO.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGO.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnGO.ForeColor = System.Drawing.Color.DarkRed;
            this.btnGO.Location = new System.Drawing.Point(367, 31);
            this.btnGO.Margin = new System.Windows.Forms.Padding(4);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(311, 131);
            this.btnGO.TabIndex = 0;
            this.btnGO.Text = "麻煩點我抽牌可以嗎";
            this.btnGO.UseVisualStyleBackColor = false;
            this.btnGO.Click += new System.EventHandler(this.btnGO_Click);
            // 
            // pic2
            // 
            this.pic2.Image = global::WP_2020_01_HW02_3A713153.Properties.Resources._053;
            this.pic2.Location = new System.Drawing.Point(101, 196);
            this.pic2.Margin = new System.Windows.Forms.Padding(4);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(304, 276);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic2.TabIndex = 4;
            this.pic2.TabStop = false;
            // 
            // picResult
            // 
            this.picResult.Location = new System.Drawing.Point(629, 196);
            this.picResult.Margin = new System.Windows.Forms.Padding(4);
            this.picResult.Name = "picResult";
            this.picResult.Size = new System.Drawing.Size(311, 278);
            this.picResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picResult.TabIndex = 3;
            this.picResult.TabStop = false;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(104, 31);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(199, 130);
            this.btn2.TabIndex = 5;
            this.btn2.Text = "洗牌";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.picResult);
            this.Controls.Add(this.btnGO);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGame";
            this.Text = "抽撲克牌";
            this.Load += new System.EventHandler(this.frmGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGO;
        private System.Windows.Forms.PictureBox picResult;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.Button btn2;
    }
}

