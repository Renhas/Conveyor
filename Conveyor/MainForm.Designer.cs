namespace Forms
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Tables = new System.Windows.Forms.TabControl();
            this.Brutforce = new System.Windows.Forms.TabPage();
            this.BruteforceTimetable = new Forms.Timetable();
            this.UpperHeuristic = new System.Windows.Forms.TabPage();
            this.UpperTimetable = new Forms.Timetable();
            this.LowerHeuristic = new System.Windows.Forms.TabPage();
            this.LowerTimetable = new Forms.Timetable();
            this.TanaevHeuristic = new System.Windows.Forms.TabPage();
            this.TanaevTimetable = new Forms.Timetable();
            this.h_steps = new System.Windows.Forms.TabPage();
            this.h_stepsTimetable = new Forms.Timetable();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.PathSelectButton = new System.Windows.Forms.Button();
            this.InfoButton = new System.Windows.Forms.Button();
            this.StepsNumeric = new System.Windows.Forms.NumericUpDown();
            this.Tables.SuspendLayout();
            this.Brutforce.SuspendLayout();
            this.UpperHeuristic.SuspendLayout();
            this.LowerHeuristic.SuspendLayout();
            this.TanaevHeuristic.SuspendLayout();
            this.h_steps.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StepsNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // Tables
            // 
            this.Tables.Controls.Add(this.Brutforce);
            this.Tables.Controls.Add(this.UpperHeuristic);
            this.Tables.Controls.Add(this.LowerHeuristic);
            this.Tables.Controls.Add(this.TanaevHeuristic);
            this.Tables.Controls.Add(this.h_steps);
            this.Tables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tables.Location = new System.Drawing.Point(0, 39);
            this.Tables.Name = "Tables";
            this.Tables.SelectedIndex = 0;
            this.Tables.Size = new System.Drawing.Size(800, 411);
            this.Tables.TabIndex = 0;
            this.Tables.Visible = false;
            this.Tables.SelectedIndexChanged += new System.EventHandler(this.Tables_SelectedIndexChanged);
            // 
            // Brutforce
            // 
            this.Brutforce.Controls.Add(this.BruteforceTimetable);
            this.Brutforce.Location = new System.Drawing.Point(4, 22);
            this.Brutforce.Name = "Brutforce";
            this.Brutforce.Size = new System.Drawing.Size(792, 385);
            this.Brutforce.TabIndex = 0;
            this.Brutforce.Text = "Полный перебор";
            this.Brutforce.UseVisualStyleBackColor = true;
            // 
            // BruteforceTimetable
            // 
            this.BruteforceTimetable.Colors = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("BruteforceTimetable.Colors")));
            this.BruteforceTimetable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BruteforceTimetable.Location = new System.Drawing.Point(0, 0);
            this.BruteforceTimetable.Name = "BruteforceTimetable";
            this.BruteforceTimetable.Size = new System.Drawing.Size(792, 385);
            this.BruteforceTimetable.TabIndex = 0;
            // 
            // UpperHeuristic
            // 
            this.UpperHeuristic.Controls.Add(this.UpperTimetable);
            this.UpperHeuristic.Location = new System.Drawing.Point(4, 22);
            this.UpperHeuristic.Name = "UpperHeuristic";
            this.UpperHeuristic.Size = new System.Drawing.Size(792, 385);
            this.UpperHeuristic.TabIndex = 1;
            this.UpperHeuristic.Text = "По возрастанию";
            this.UpperHeuristic.UseVisualStyleBackColor = true;
            // 
            // UpperTimetable
            // 
            this.UpperTimetable.Colors = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("UpperTimetable.Colors")));
            this.UpperTimetable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UpperTimetable.Location = new System.Drawing.Point(0, 0);
            this.UpperTimetable.Name = "UpperTimetable";
            this.UpperTimetable.Size = new System.Drawing.Size(792, 385);
            this.UpperTimetable.TabIndex = 0;
            // 
            // LowerHeuristic
            // 
            this.LowerHeuristic.Controls.Add(this.LowerTimetable);
            this.LowerHeuristic.Location = new System.Drawing.Point(4, 22);
            this.LowerHeuristic.Name = "LowerHeuristic";
            this.LowerHeuristic.Size = new System.Drawing.Size(792, 385);
            this.LowerHeuristic.TabIndex = 2;
            this.LowerHeuristic.Text = "По убыванию";
            this.LowerHeuristic.UseVisualStyleBackColor = true;
            // 
            // LowerTimetable
            // 
            this.LowerTimetable.Colors = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("LowerTimetable.Colors")));
            this.LowerTimetable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LowerTimetable.Location = new System.Drawing.Point(0, 0);
            this.LowerTimetable.Name = "LowerTimetable";
            this.LowerTimetable.Size = new System.Drawing.Size(792, 385);
            this.LowerTimetable.TabIndex = 0;
            // 
            // TanaevHeuristic
            // 
            this.TanaevHeuristic.Controls.Add(this.TanaevTimetable);
            this.TanaevHeuristic.Location = new System.Drawing.Point(4, 22);
            this.TanaevHeuristic.Name = "TanaevHeuristic";
            this.TanaevHeuristic.Size = new System.Drawing.Size(792, 385);
            this.TanaevHeuristic.TabIndex = 3;
            this.TanaevHeuristic.Text = "Алгоритм Танаева";
            this.TanaevHeuristic.UseVisualStyleBackColor = true;
            // 
            // TanaevTimetable
            // 
            this.TanaevTimetable.Colors = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("TanaevTimetable.Colors")));
            this.TanaevTimetable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TanaevTimetable.Location = new System.Drawing.Point(0, 0);
            this.TanaevTimetable.Name = "TanaevTimetable";
            this.TanaevTimetable.Size = new System.Drawing.Size(792, 385);
            this.TanaevTimetable.TabIndex = 0;
            // 
            // h_steps
            // 
            this.h_steps.Controls.Add(this.h_stepsTimetable);
            this.h_steps.Location = new System.Drawing.Point(4, 22);
            this.h_steps.Name = "h_steps";
            this.h_steps.Size = new System.Drawing.Size(792, 385);
            this.h_steps.TabIndex = 4;
            this.h_steps.Text = "h-алгоритм";
            this.h_steps.UseVisualStyleBackColor = true;
            // 
            // h_stepsTimetable
            // 
            this.h_stepsTimetable.Colors = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("h_stepsTimetable.Colors")));
            this.h_stepsTimetable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.h_stepsTimetable.Location = new System.Drawing.Point(0, 0);
            this.h_stepsTimetable.Name = "h_stepsTimetable";
            this.h_stepsTimetable.Size = new System.Drawing.Size(792, 385);
            this.h_stepsTimetable.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.PathSelectButton);
            this.flowLayoutPanel1.Controls.Add(this.InfoButton);
            this.flowLayoutPanel1.Controls.Add(this.StepsNumeric);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 39);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // PathSelectButton
            // 
            this.PathSelectButton.Location = new System.Drawing.Point(3, 3);
            this.PathSelectButton.Name = "PathSelectButton";
            this.PathSelectButton.Size = new System.Drawing.Size(96, 24);
            this.PathSelectButton.TabIndex = 0;
            this.PathSelectButton.Text = "Выбрать путь";
            this.PathSelectButton.UseVisualStyleBackColor = true;
            this.PathSelectButton.Click += new System.EventHandler(this.PathSelectButton_Click);
            // 
            // InfoButton
            // 
            this.InfoButton.Location = new System.Drawing.Point(105, 3);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(75, 24);
            this.InfoButton.TabIndex = 3;
            this.InfoButton.Text = "Подробнее";
            this.InfoButton.UseVisualStyleBackColor = true;
            this.InfoButton.Visible = false;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // StepsNumeric
            // 
            this.StepsNumeric.Location = new System.Drawing.Point(186, 5);
            this.StepsNumeric.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.StepsNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StepsNumeric.Name = "StepsNumeric";
            this.StepsNumeric.Size = new System.Drawing.Size(120, 20);
            this.StepsNumeric.TabIndex = 2;
            this.StepsNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StepsNumeric.Visible = false;
            this.StepsNumeric.ValueChanged += new System.EventHandler(this.StepsNumeric_ValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tables);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Конвейер";
            this.Tables.ResumeLayout(false);
            this.Brutforce.ResumeLayout(false);
            this.UpperHeuristic.ResumeLayout(false);
            this.LowerHeuristic.ResumeLayout(false);
            this.TanaevHeuristic.ResumeLayout(false);
            this.h_steps.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StepsNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tables;
        private System.Windows.Forms.TabPage Brutforce;
        private System.Windows.Forms.TabPage UpperHeuristic;
        private System.Windows.Forms.TabPage LowerHeuristic;
        private System.Windows.Forms.TabPage TanaevHeuristic;
        private System.Windows.Forms.TabPage h_steps;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Timetable BruteforceTimetable;
        private Timetable UpperTimetable;
        private Timetable LowerTimetable;
        private Timetable TanaevTimetable;
        private Timetable h_stepsTimetable;
        private System.Windows.Forms.Button PathSelectButton;
        private System.Windows.Forms.NumericUpDown StepsNumeric;
        private System.Windows.Forms.Button InfoButton;
    }
}

