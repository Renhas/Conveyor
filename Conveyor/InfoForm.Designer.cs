namespace Forms
{
    partial class InfoForm
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
            this.ConveyorBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ConveyorBox
            // 
            this.ConveyorBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConveyorBox.Location = new System.Drawing.Point(0, 0);
            this.ConveyorBox.Name = "ConveyorBox";
            this.ConveyorBox.ReadOnly = true;
            this.ConveyorBox.Size = new System.Drawing.Size(562, 311);
            this.ConveyorBox.TabIndex = 0;
            this.ConveyorBox.Text = "";
            this.ConveyorBox.WordWrap = false;
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 311);
            this.Controls.Add(this.ConveyorBox);
            this.Name = "InfoForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Информация о работах";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox ConveyorBox;
    }
}