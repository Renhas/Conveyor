using ConveyorSystem;
using Genetic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timetable;

namespace Forms
{
    public partial class EvolutionForm : Form
    {
        public List<Color> Colors { get; private set; }
        Conveyor conveyor;
        public EvolutionForm()
        {
            InitializeComponent();
        }

        public EvolutionForm(List<Color> colors, Conveyor conveyor) : this() 
        {
            Colors = colors;
            this.conveyor = conveyor;
            EvolutionTimetable.Colors = Colors;
            EvolutionTimetable.Visible = false;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {

            TableInitAsync();
            StartButton.Enabled = false;
            
        }


        private async void TableInitAsync() 
        {
            GenerationProgressBar.Value = 0;
            Result result = await Task.Run(() => TableInit());

            Job lastJob = result.Permutation.Values.Last();
            int totalTacts = lastJob.StartTimes[conveyor.Machines - 1]
                + lastJob.Tacts[conveyor.Machines - 1];
            EvolutionTimetable.SetResult(result);
            EvolutionTimetable.TableInit(conveyor.TimetableMatrix(totalTacts));
            EvolutionTimetable.Visible = true;
            StartButton.Enabled = true;
        }

        private Result TableInit() 
        {
            Result result = MainAlgorythm.Run(conveyor, (int)CountNumeric.Value, (float)CrossoverNumeric.Value, (float)MutationNumeric.Value);
            return result;
        }



        private void ProgressTimer_Tick(object sender, EventArgs e)
        {
            float percent = MainAlgorythm.GetProgress();
            GenerationProgressBar.Value = (int)(percent * 100);
            if (GenerationProgressBar.Value == GenerationProgressBar.Maximum)
            {
                GenerationProgressBar.Visible = false;
            }
            else 
            {
                GenerationProgressBar.Visible = true;
            }

        }
    }
}
