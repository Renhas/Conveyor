namespace Forms
{
    partial class ColorSelectElement
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ColorId = new System.Windows.Forms.Label();
            this.ColorPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.ColorId);
            this.flowLayoutPanel1.Controls.Add(this.ColorPanel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(69, 30);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // ColorId
            // 
            this.ColorId.AutoSize = true;
            this.ColorId.Location = new System.Drawing.Point(3, 6);
            this.ColorId.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.ColorId.Name = "ColorId";
            this.ColorId.Size = new System.Drawing.Size(13, 13);
            this.ColorId.TabIndex = 0;
            this.ColorId.Text = "1";
            // 
            // ColorPanel
            // 
            this.ColorPanel.Location = new System.Drawing.Point(22, 3);
            this.ColorPanel.Name = "ColorPanel";
            this.ColorPanel.Size = new System.Drawing.Size(30, 20);
            this.ColorPanel.TabIndex = 1;
            this.ColorPanel.Click += new System.EventHandler(this.ColorPanel_Click);
            // 
            // ColorSelectElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ColorSelectElement";
            this.Size = new System.Drawing.Size(69, 30);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label ColorId;
        private System.Windows.Forms.Panel ColorPanel;
    }
}
