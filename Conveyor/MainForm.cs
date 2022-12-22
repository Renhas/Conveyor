using ConveyorSystem;
using Genetic;
using Permutations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timetable;

namespace Forms
{
    public partial class MainForm : Form
    {
        Conveyor conveyor;
        List<Color> colors;
        public MainForm()
        {
            InitializeComponent();
            conveyor = null;
            colors = new List<Color>
            {
                Color.BlueViolet,
                Color.Green,
                Color.Gold,
                Color.Yellow,
                Color.Orchid
            };


        }

        private void PathSelectButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog() 
            {
                Title = "Открыть файл",
                Filter = "Текстовый файл (*.txt) | *.txt"
            };
            if (ofd.ShowDialog() != DialogResult.OK) 
            {
                ElementsInit(false);
                return;
            }
            conveyor = MyReader.Read(ofd.FileName);
            StepsNumeric.Value = StepsNumeric.Minimum;
            StepsNumeric.Maximum = conveyor.JobCount;
            ElementsInit(true);
        }
        private void ElementsInit(bool mode)
        {
            Tables.Visible = mode;
            InfoButton.Visible = mode;
            EvolutionButton.Visible = mode;
            RunButton.Visible = false;   


        }

        private void TablesInit() 
        {
            
            TableInit(Bruteforce.Run(conveyor), BruteforceTimetable);
            TableInit(Heuristic.Upper(conveyor), UpperTimetable);
            TableInit(Heuristic.Lower(conveyor), LowerTimetable);
            TableInit(Heuristic.Tanaev(conveyor), TanaevTimetable);
            TableInit(h_StepAlgorythm.Run((int)StepsNumeric.Value, conveyor),
                h_stepsTimetable);
        }

        private void TableInit(Result result, Timetable table) 
        {
            TimetableAlgorythm.Run(result.Permutation, conveyor);
            Job lastJob = result.Permutation.Values.Last();
            int totalTacts = lastJob.StartTimes[conveyor.Machines - 1]
                + lastJob.Tacts[conveyor.Machines - 1];
            table.Colors = colors;
            table.SetResult(result);
            table.TableInit(conveyor.TimetableMatrix(totalTacts));
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            InfoForm form = new InfoForm();
            form.SetConveyor(conveyor);
            form.ShowDialog();
        }

        private void Tables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Tables.SelectedIndex == 4) StepsNumeric.Visible = true;
            else StepsNumeric.Visible = false;

            var table = Tables.SelectedTab.Controls[0] as Timetable;
            if (table == null) return;
            table.Colors = colors;


        }

        private void StepsNumeric_ValueChanged(object sender, EventArgs e)
        {
            TableInit(h_StepAlgorythm.Run((int)StepsNumeric.Value, conveyor),
                h_stepsTimetable);
        }

        private void EvolutionButton_Click(object sender, EventArgs e)
        {
            EvolutionForm form = new EvolutionForm(colors, conveyor);
            form.ShowDialog();
            colors = form.Colors;
        }
        private void RunButton_Click(object sender, EventArgs e)
        {
            switch (Tables.SelectedIndex) 
            {
                case 0:
                    TableInit(Bruteforce.Run(conveyor), BruteforceTimetable);
                    break;
                case 1:
                    TableInit(Heuristic.Upper(conveyor), UpperTimetable);
                    break;
                case 2:
                    TableInit(Heuristic.Lower(conveyor), LowerTimetable);
                    break;
                case 3:
                    TableInit(Heuristic.Tanaev(conveyor), TanaevTimetable);
                    break;
                case 4:
                    TableInit(h_StepAlgorythm.Run((int)StepsNumeric.Value, conveyor),
                h_stepsTimetable);
                    break;
            }
        }
    }
}
