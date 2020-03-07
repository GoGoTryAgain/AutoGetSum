namespace 弱智凑数
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
            ((System.ComponentModel.ISupportInitialize)(this.resultGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // resultGridView
            // 
            this.resultGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.resultGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.resultGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultGridView.Location = new System.Drawing.Point(206, 110);
            this.resultGridView.Name = "resultGridView";
            this.resultGridView.RowHeadersWidth = 51;
            this.resultGridView.RowTemplate.Height = 27;
            this.resultGridView.Size = new System.Drawing.Size(519, 364);
            this.resultGridView.TabIndex = 1;
            // 
            // srcInputTextbox
            // 
            this.srcInputTextbox.Location = new System.Drawing.Point(18, 110);
            this.srcInputTextbox.Multiline = true;
            this.srcInputTextbox.Name = "srcInputTextbox";
            this.srcInputTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.srcInputTextbox.Size = new System.Drawing.Size(134, 364);
            this.srcInputTextbox.TabIndex = 2;
            this.srcInputTextbox.TextChanged += new System.EventHandler(this.srcInputTextbox_TextChanged);
            // 
            // srcInputLabel
            // 
            this.srcInputLabel.AutoSize = true;
            this.srcInputLabel.Location = new System.Drawing.Point(54, 83);
            this.srcInputLabel.Name = "srcInputLabel";
            this.srcInputLabel.Size = new System.Drawing.Size(52, 15);
            this.srcInputLabel.TabIndex = 3;
            this.srcInputLabel.Text = "数据源";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(433, 83);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(67, 15);
            this.resultLabel.TabIndex = 4;
            this.resultLabel.Text = "凑数结果";
            // 
            // dataHandleButton
            // 
            this.dataHandleButton.Location = new System.Drawing.Point(755, 451);
            this.dataHandleButton.Name = "dataHandleButton";
            this.dataHandleButton.Size = new System.Drawing.Size(112, 30);
            this.dataHandleButton.TabIndex = 5;
            this.dataHandleButton.Text = "凑数";
            this.dataHandleButton.UseVisualStyleBackColor = true;
            this.dataHandleButton.Click += new System.EventHandler(this.dataHandleButton_Click);
            // 
            // dataWant
            // 
            this.dataWant.Location = new System.Drawing.Point(848, 117);
            this.dataWant.Name = "dataWant";
            this.dataWant.Size = new System.Drawing.Size(183, 25);
            this.dataWant.TabIndex = 6;
            this.dataWant.Text = "0";
            // 
            // dataLabel
            // 
            this.dataLabel.AutoSize = true;
            this.dataLabel.Location = new System.Drawing.Point(748, 117);
            this.dataLabel.Name = "dataLabel";
            this.dataLabel.Size = new System.Drawing.Size(67, 15);
            this.dataLabel.TabIndex = 7;
            this.dataLabel.Text = "待凑数值";
            // 
            // mulDataLabel
            // 
            this.mulDataLabel.AutoSize = true;
            this.mulDataLabel.Location = new System.Drawing.Point(748, 263);
            this.mulDataLabel.Name = "mulDataLabel";
            this.mulDataLabel.Size = new System.Drawing.Size(97, 15);
            this.mulDataLabel.TabIndex = 8;
            this.mulDataLabel.Text = "全部待凑数值";
            // 
            // mulDataWant
            // 
            this.mulDataWant.Location = new System.Drawing.Point(848, 204);
            this.mulDataWant.Multiline = true;
            this.mulDataWant.Name = "mulDataWant";
            this.mulDataWant.Size = new System.Drawing.Size(183, 128);
            this.mulDataWant.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(752, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(748, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "波动范围";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // rangeTextbox
            // 
            this.rangeTextbox.Location = new System.Drawing.Point(848, 382);
            this.rangeTextbox.Name = "rangeTextbox";
            this.rangeTextbox.Size = new System.Drawing.Size(183, 25);
            this.rangeTextbox.TabIndex = 12;
            this.rangeTextbox.Text = "0.2";
            // 
            // roundDataHandleButton
            // 
            this.roundDataHandleButton.Location = new System.Drawing.Point(924, 451);
            this.roundDataHandleButton.Name = "roundDataHandleButton";
            this.roundDataHandleButton.Size = new System.Drawing.Size(107, 30);
            this.roundDataHandleButton.TabIndex = 13;
            this.roundDataHandleButton.Text = "循环凑数";
            this.roundDataHandleButton.UseVisualStyleBackColor = true;
            this.roundDataHandleButton.Click += new System.EventHandler(this.roundDataHandleButton_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 530);
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
            this.Name = "form1";
            this.Text = "奇奇凑数 V0.0.3";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

