
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace distribution
{
    public partial class FormResult : Form
    {
        private List<double> Analit = new List<double>();
        private List<double> answerInverse = new List<double>();
        private List<double> answerMetropolis = new List<double>();
        private List<double> answerNeimon = new List<double>();
        private double constA, nIter, left, right, step;

        private List<double> Mean1 = new List<double>();
        private List<double> Dispers = new List<double>();
        private List<double> Sigma = new List<double>();

        private string[] meth = new string[4];

        public FormResult()
        {
            InitializeComponent();
        }

        public void FeelResult(TestResult obj)
        {
            Analit = new List<double>(obj.Analit);
            answerNeimon = new List<double>(obj.Neymon);
            answerMetropolis = new List<double>(obj.Metropolis);
            answerInverse = new List<double>(obj.Inverse);

            constA = obj.ConstA;
            nIter = obj.NIter;
            left = obj.Left;
            right = obj.Right;
            step = obj.Step;

            Mean1 = new List<double>(obj.Mean);
            Dispers = new List<double>(obj.Dispers);
            Sigma = new List<double>(obj.Sigma);

            meth[0] = "Absolute";
            meth[1] = "Neymann";
            meth[2] = "Metropolis";
            meth[3] = "Inverse";
        }

        //основной вывод всего на форму
        public void Answer()
        {
            Constants();
            AnswerAbsolute();
            Answerdiagram();
            AnswerGrig();
        }

        //textBox с константами
        public void Constants()
        {
            textBoxAnswer.AppendText(String.Format("Constant a: {0}{5}nIter: {1}{5}X from: {2} to: {3}{5}Step: {4}", constA, nIter, left, right, step, Environment.NewLine));
        }

        //вывод графика на диаграмму
        public void AnswerAbsolute()
        {
            var j = 0;
            var st = Math.Abs(right - left)/100;
            for (var i = left; i < right; i += st)
            {
                chart1.Series[0].Points.AddXY(i, Analit[j]);
                j++;
            }
        }

        //вывод ответов на диаграмму
        public void Answerdiagram()
        {
            for (var j = 1; j <= 3; j++)
            {
                var a = 0;
                for (var i = left; i < right; i += step)
                {
                    switch (j)
                    {
                        case 1:
                            if(answerNeimon.Count > a)
                                chart1.Series[j].Points.AddXY(i + step/2, answerNeimon[a]);
                            break;
                        case 2:
                            if(answerMetropolis.Count > a)
                                chart1.Series[j].Points.AddXY(i + step/2, answerMetropolis[a]);
                            break;
                        case 3:
                            if(answerInverse.Count > a)
                                chart1.Series[j].Points.AddXY(i + step/2, answerInverse[a]);
                            break;
                    }
                    a++;
                }
            }
        }

        private void AnswerGrig()
        {
            dataGrid.RowCount = 4;

            for (int i = 0; i < 4; i++)
            {
                dataGrid.Rows[i].SetValues(meth[i], Mean1[i], Dispers[i], Sigma[i]);
            }
        }

        #region CheckBoxes
        private void checkBoxNeymon_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxNeymon.Checked)
                chart1.Series[1].Enabled = false;
            else
                chart1.Series[1].Enabled = true;
        }

        private void checkBoxMetropolis_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxMetropolis.Checked)
                chart1.Series[2].Enabled = false;
            else
                chart1.Series[2].Enabled = true;
        }

        private void checkBoxInverse_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxInverse.Checked)
                chart1.Series[3].Enabled = false;
            else
                chart1.Series[3].Enabled = true;
        }
        #endregion
    }
}