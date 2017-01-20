namespace DeckMaker
{
    partial class DeckMaker
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.button = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(539, 23);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(91, 34);
            this.button.TabIndex = 0;
            this.button.Text = "構築開始";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.CreateDeck);
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(50, 30);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(464, 23);
            this.comboBox.TabIndex = 1;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(50, 87);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(580, 334);
            this.textBox.TabIndex = 2;
            // 
            // DeckMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 451);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.button);
            this.Name = "DeckMaker";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.ComboBox comboBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.TextBox textBox;
    }
}

