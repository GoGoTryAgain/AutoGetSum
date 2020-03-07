namespace 奇奇凑数
{
    partial class form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.resultGridView = new System.Windows.Forms.DataGridView();
            this.srcInputTextbox = new System.Windows.Forms.TextBox();
            this.srcInputLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.dataHandleButton = new System.Windows.Forms.Button();
            this.dataWant = new System.Windows.Forms.TextBox();
            this.dataLabel = new System.Windows.Forms.Label();
            this.mulDataLabel = new System.Windows.Forms.Label();
            this.mulDataWant = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rangeTextbox = new System.Windows.Forms.TextBox();
            this.roundDataHandleButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.resultGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // resultGridView
            // 
            this.resultGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.resultGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.resultGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultGridView.Location = new System.Drawing.Point(157, 77);
            this.resultGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.resultGridView.Name = "resultGridView";
            this.resultGridView.RowHeadersVisible = false;
            this.resultGridView.RowHeadersWidth = 51;
            this.resultGridView.RowTemplate.Height = 27;
            this.resultGridView.Size = new System.Drawing.Size(389, 291);
            this.resultGridView.TabIndex = 1;
            // 
            // srcInputTextbox
            // 
            this.srcInputTextbox.Location = new System.Drawing.Point(16, 77);
            this.srcInputTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.srcInputTextbox.Multiline = true;
            this.srcInputTextbox.Name = "srcInputTextbox";
            this.srcInputTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.srcInputTextbox.Size = new System.Drawing.Size(102, 292);
            this.srcInputTextbox.TabIndex = 2;
            this.srcInputTextbox.TextChanged += new System.EventHandler(this.srcInputTextbox_TextChanged);
            // 
            // srcInputLabel
            // 
            this.srcInputLabel.AutoSize = true;
            this.srcInputLabel.Location = new System.Drawing.Point(43, 55);
            this.srcInputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.srcInputLabel.Name = "srcInputLabel";
            this.srcInputLabel.Size = new System.Drawing.Size(41, 12);
            this.srcInputLabel.TabIndex = 3;
            this.srcInputLabel.Text = "数据源";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(327, 55);
            this.resultLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(53, 12);
            this.resultLabel.TabIndex = 4;
            this.resultLabel.Text = "凑数结果";
            // 
            // dataHandleButton
            // 
            this.dataHandleButton.Location = new System.Drawing.Point(568, 350);
            this.dataHandleButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataHandleButton.Name = "dataHandleButton";
            this.dataHandleButton.Size = new System.Drawing.Size(84, 24);
            this.dataHandleButton.TabIndex = 5;
            this.dataHandleButton.Text = "凑数";
            this.dataHandleButton.UseVisualStyleBackColor = true;
            this.dataHandleButton.Click += new System.EventHandler(this.dataHandleButton_Click);
            // 
            // dataWant
            // 
            this.dataWant.Location = new System.Drawing.Point(638, 82);
            this.dataWant.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataWant.Name = "dataWant";
            this.dataWant.Size = new System.Drawing.Size(138, 21);
            this.dataWant.TabIndex = 6;
            this.dataWant.Text = "0";
            // 
            // dataLabel
            // 
            this.dataLabel.AutoSize = true;
            this.dataLabel.Location = new System.Drawing.Point(563, 82);
            this.dataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dataLabel.Name = "dataLabel";
            this.dataLabel.Size = new System.Drawing.Size(53, 12);
            this.dataLabel.TabIndex = 7;
            this.dataLabel.Text = "待凑数值";
            // 
            // mulDataLabel
            // 
            this.mulDataLabel.AutoSize = true;
            this.mulDataLabel.Location = new System.Drawing.Point(563, 199);
            this.mulDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mulDataLabel.Name = "mulDataLabel";
            this.mulDataLabel.Size = new System.Drawing.Size(77, 12);
            this.mulDataLabel.TabIndex = 8;
            this.mulDataLabel.Text = "全部待凑数值";
            // 
            // mulDataWant
            // 
            this.mulDataWant.Location = new System.Drawing.Point(638, 152);
            this.mulDataWant.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mulDataWant.Multiline = true;
            this.mulDataWant.Name = "mulDataWant";
            this.mulDataWant.Size = new System.Drawing.Size(138, 103);
            this.mulDataWant.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(566, 297);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(563, 297);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "波动范围";
            // 
            // rangeTextbox
            // 
            this.rangeTextbox.Location = new System.Drawing.Point(638, 294);
            this.rangeTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rangeTextbox.Name = "rangeTextbox";
            this.rangeTextbox.Size = new System.Drawing.Size(138, 21);
            this.rangeTextbox.TabIndex = 12;
            this.rangeTextbox.Text = "0.2";
            // 
            // roundDataHandleButton
            // 
            this.roundDataHandleButton.Location = new System.Drawing.Point(695, 350);
            this.roundDataHandleButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.roundDataHandleButton.Name = "roundDataHandleButton";
            this.roundDataHandleButton.Size = new System.Drawing.Size(80, 24);
            this.roundDataHandleButton.TabIndex = 13;
            this.roundDataHandleButton.Text = "循环凑数";
            this.roundDataHandleButton.UseVisualStyleBackColor = true;
            this.roundDataHandleButton.Click += new System.EventHandler(this.roundDataHandleButton_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(11, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(298, 33);
            this.label3.TabIndex = 14;
            this.label3.Text = "小郑小郑 (*^▽^*) 出奇制胜";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 424);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.roundDataHandleButton);
            this.Controls.Add(this.rangeTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mulDataWant);
            this.Controls.Add(this.mulDataLabel);
            this.Controls.Add(this.dataLabel);
            this.Controls.Add(this.dataWant);
            this.Controls.Add(this.dataHandleButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.srcInputLabel);
            this.Controls.Add(this.srcInputTextbox);
            this.Controls.Add(this.resultGridView);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "form1";
            this.Text = "奇奇凑数 V1.0.3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.form1_Resize_1);
            ((System.ComponentModel.ISupportInitialize)(this.resultGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView resultGridView;
        private System.Windows.Forms.TextBox srcInputTextbox;
        private System.Windows.Forms.Label srcInputLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button dataHandleButton;
        private System.Windows.Forms.TextBox dataWant;
        private System.Windows.Forms.Label dataLabel;
        private System.Windows.Forms.Label mulDataLabel;
        private System.Windows.Forms.TextBox mulDataWant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rangeTextbox;
        private System.Windows.Forms.Button roundDataHandleButton;
        private System.Windows.Forms.Label label3;
    }
}

