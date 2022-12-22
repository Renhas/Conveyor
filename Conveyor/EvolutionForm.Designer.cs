namespace Forms
{
    partial class EvolutionForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvolutionForm));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.CountLabel = new System.Windows.Forms.Label();
            this.CountNumeric = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.CrossoverLabel = new System.Windows.Forms.Label();
            this.CrossoverNumeric = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.MutationLabel = new System.Windows.Forms.Label();
            this.MutationNumeric = new System.Windows.Forms.NumericUpDown();
            this.StartButton = new System.Windows.Forms.Button();
            this.EvolutionTimetable = new Forms.Timetable();
            this.GenerationProgressBar = new System.Windows.Forms.ProgressBar();
            this.ProgressTimer = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CountNumeric)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CrossoverNumeric)).BeginInit();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MutationNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel1.Controls.Add(this.StartButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 59);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.CountLabel);
            this.flowLayoutPanel2.Controls.Add(this.CountNumeric);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(200, 50);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Location = new System.Drawing.Point(3, 3);
            this.CountLabel.Margin = new System.Windows.Forms.Padding(3);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(74, 13);
            this.CountLabel.TabIndex = 0;
            this.CountLabel.Text = "Численность";
            // 
            // CountNumeric
            // 
            this.CountNumeric.Location = new System.Drawing.Point(3, 22);
            this.CountNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CountNumeric.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.CountNumeric.Name = "CountNumeric";
            this.CountNumeric.Size = new System.Drawing.Size(120, 20);
            this.CountNumeric.TabIndex = 1;
            this.CountNumeric.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.CrossoverLabel);
            this.flowLayoutPanel3.Controls.Add(this.CrossoverNumeric);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(209, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(200, 50);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // CrossoverLabel
            // 
            this.CrossoverLabel.AutoSize = true;
            this.CrossoverLabel.Location = new System.Drawing.Point(3, 3);
            this.CrossoverLabel.Margin = new System.Windows.Forms.Padding(3);
            this.CrossoverLabel.Name = "CrossoverLabel";
            this.CrossoverLabel.Size = new System.Drawing.Size(97, 13);
            this.CrossoverLabel.TabIndex = 0;
            this.CrossoverLabel.Text = "Шанс кроссовера";
            // 
            // CrossoverNumeric
            // 
            this.CrossoverNumeric.DecimalPlaces = 2;
            this.CrossoverNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.CrossoverNumeric.Location = new System.Drawing.Point(3, 22);
            this.CrossoverNumeric.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CrossoverNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.CrossoverNumeric.Name = "CrossoverNumeric";
            this.CrossoverNumeric.Size = new System.Drawing.Size(120, 20);
            this.CrossoverNumeric.TabIndex = 1;
            this.CrossoverNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.MutationLabel);
            this.flowLayoutPanel4.Controls.Add(this.MutationNumeric);
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(415, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(200, 50);
            this.flowLayoutPanel4.TabIndex = 2;
            // 
            // MutationLabel
            // 
            this.MutationLabel.AutoSize = true;
            this.MutationLabel.Location = new System.Drawing.Point(3, 3);
            this.MutationLabel.Margin = new System.Windows.Forms.Padding(3);
            this.MutationLabel.Name = "MutationLabel";
            this.MutationLabel.Size = new System.Drawing.Size(79, 13);
            this.MutationLabel.TabIndex = 0;
            this.MutationLabel.Text = "Шанс мутации";
            // 
            // MutationNumeric
            // 
            this.MutationNumeric.DecimalPlaces = 2;
            this.MutationNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.MutationNumeric.Location = new System.Drawing.Point(3, 22);
            this.MutationNumeric.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MutationNumeric.Name = "MutationNumeric";
            this.MutationNumeric.Size = new System.Drawing.Size(120, 20);
            this.MutationNumeric.TabIndex = 1;
            this.MutationNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(621, 15);
            this.StartButton.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "Поехали!";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // EvolutionTimetable
            // 
            this.EvolutionTimetable.Colors = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("EvolutionTimetable.Colors")));
            this.EvolutionTimetable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EvolutionTimetable.Location = new System.Drawing.Point(0, 59);
            this.EvolutionTimetable.Name = "EvolutionTimetable";
            this.EvolutionTimetable.Size = new System.Drawing.Size(800, 391);
            this.EvolutionTimetable.TabIndex = 1;
            // 
            // GenerationProgressBar
            // 
            this.GenerationProgressBar.ForeColor = System.Drawing.Color.Lime;
            this.GenerationProgressBar.Location = new System.Drawing.Point(621, 65);
            this.GenerationProgressBar.Name = "GenerationProgressBar";
            this.GenerationProgressBar.Size = new System.Drawing.Size(167, 23);
            this.GenerationProgressBar.Step = 1;
            this.GenerationProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.GenerationProgressBar.TabIndex = 2;
            this.GenerationProgressBar.Visible = false;
            // 
            // ProgressTimer
            // 
            this.ProgressTimer.Enabled = true;
            this.ProgressTimer.Tick += new System.EventHandler(this.ProgressTimer_Tick);
            // 
            // EvolutionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GenerationProgressBar);
            this.Controls.Add(this.EvolutionTimetable);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "EvolutionForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Эволюция";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CountNumeric)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CrossoverNumeric)).EndInit();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MutationNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.NumericUpDown CountNumeric;
        private System.Windows.Forms.Label CrossoverLabel;
        private System.Windows.Forms.NumericUpDown CrossoverNumeric;
        private System.Windows.Forms.Label MutationLabel;
        private System.Windows.Forms.NumericUpDown MutationNumeric;
        private System.Windows.Forms.Button StartButton;
        private Timetable EvolutionTimetable;
        private System.Windows.Forms.ProgressBar GenerationProgressBar;
        private System.Windows.Forms.Timer ProgressTimer;
    }
}