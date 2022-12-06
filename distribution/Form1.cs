// Laska Andrey

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Serialization;

namespace distribution
{
    public partial class Form1 : Form
    {
        private List<double> Analit = new List<double>();
        private List<double> listInverse = new List<double>();
        private List<double> listNeimon = new List<double>();
        private List<double> listMetropolis = new List<double>();

        private double constA, nIter, left, right, step, y, qMax, cdf;
        private double a, aN, aM, aI;
        private double disp, dispN, dispM, dispI;
        private double sigma, sigmaN, sigmaM, sigmaI;
        Random rand = new Random();
        private int progress;
        private bool stop, pause;

        private List<double> answerInverse = new List<double>();
        private List<double> answerNeimon = new List<double>();
        private List<double> answerMetropolis = new List<double>();

        ManualResetEvent _busy = new ManualResetEvent(false);

        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            //присвоение значений введенных на форме
            constA = (double) formA.Value;
            nIter = (double) formNiter.Value;
            if (formLeft.Value < formRight.Value)
            {
                left = (double)formLeft.Value;
                right = (double)formRight.Value;
            }
            else
            {
                right = (double)formLeft.Value;
                left = (double)formRight.Value;
            }
            step = (right - left)/ (double) formStep.Value;
            progress = (int)nIter/100;

            //очистка переменных
            qMax = 0;
            progressBarMetropolis.Value = 0;
            progressBarNeymon.Value = 0;
            progressBarInverse.Value = 0;

            chart1.Series[0].Points.Clear();
            Analit.Clear();

            chart1.Series[1].Points.Clear();
            listNeimon.Clear();

            chart1.Series[2].Points.Clear();
            listMetropolis.Clear();

            chart1.Series[3].Points.Clear();
            listInverse.Clear();

            checkBoxNeymon.Checked = true;
            checkBoxMetropolis.Checked = true;
            checkBoxInverse.Checked = true;

            answerNeimon.Clear();
            answerMetropolis.Clear();
            answerInverse.Clear();

            //изменения на форме
            dataGrid.Visible = true;
            checkBoxNeymon.Visible = true;
            checkBoxMetropolis.Visible = true;
            checkBoxInverse.Visible = true;

            Save.Enabled = false;
            Open.Enabled = false;

            saveResultToolStripMenuItem.Enabled = false;

            PauseButton.BackColor = Color.FromArgb(192, 192, 0);
            StopButton.BackColor = Color.LightCoral;

            Start.Enabled = false;

            stop = false;
            StopButton.Enabled = true;

            pause = false;
            PauseButton.Enabled = true;

            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync(); //старт
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Absolute(sender, e);
            Neymon(sender, e);
            Metropolis(sender, e);
            Inverse(sender, e);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (progressBarNeymon.Value < 100)
                progressBarNeymon.Value += e.ProgressPercentage;
            else
            {
                if (progressBarMetropolis.Value < 100)
                    progressBarMetropolis.Value += e.ProgressPercentage;
                else
                {
                    if(progressBarInverse.Value < 100)
                        progressBarInverse.Value += e.ProgressPercentage;
                }
            }

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Answer();

            stop = false;
            StopButton.Enabled = false;

            pause = false;
            PauseButton.Enabled = false;

            PauseButton.BackColor = Color.AliceBlue;
            StopButton.BackColor = Color.AliceBlue;
            Start.Enabled = true;

            Save.Visible = true;
            Save.Enabled = true;

            Open.Visible = true;
            Open.Enabled = true;

            saveResultToolStripMenuItem.Enabled = true;

            _busy.Reset();
        }

        //вывод ответа
        private void Answer()
        {
            //диаграммы
            AnswerAbsolute();
            Answerdiagram(chart1, 1, listNeimon, left, right, step, listNeimon.Count, answerNeimon);
            Answerdiagram(chart1, 2, listMetropolis, left, right, step, listMetropolis.Count, answerMetropolis);
            Answerdiagram(chart1, 3, listInverse, left, right, step, listInverse.Count, answerInverse);

            //Мода
            a = 2*constA*Math.Sqrt(2/Math.PI);
            aN = Methods.Mean(listNeimon);
            aM = Methods.Mean(listMetropolis);
            aI = Methods.Mean(listInverse);

            //дисперсия
            disp = Math.Sqrt(Math.Pow(constA, 2)*(3*Math.PI - 8)/Math.PI);
            dispN = Methods.Disp(listNeimon, aN);
            dispM = Methods.Disp(listMetropolis, aM);
            dispI = Methods.Disp(listInverse, aI);

            //sigma
            sigma = Math.Sqrt(disp/nIter);
            sigmaN = Math.Sqrt(dispN/listNeimon.Count);
            sigmaM = Math.Sqrt(dispM/listMetropolis.Count);
            sigmaI = Math.Sqrt(dispI/listInverse.Count);

            //Таблица
            AnswerGrig();
        }

        //вывод ответов в таблицу
        private void AnswerGrig()
        {
            dataGrid.RowCount = 4;

            dataGrid.Rows[0].SetValues("Absolute", a, disp, sigma);
            dataGrid.Rows[1].SetValues("Neymann", aN, dispN, sigmaN);
            dataGrid.Rows[2].SetValues("Metropolis", aM, dispM, sigmaM);
            dataGrid.Rows[3].SetValues("Inverse", aI, dispI, sigmaI);
        }

        //график плотности распределения
        private void Absolute(object sender, DoWorkEventArgs e)
        {
            double st = Math.Abs((right - left)/100);
            for (var i = left; i < right; i += st)
            {
                y = Methods.Function(constA, i);
                Analit.Add(y);
                if (qMax < y) qMax = y;
            }
        }

        //метод Неймана
        private void Neymon(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            double xN;
            for (int i = 0; i < nIter; i++)
            {
                xN = Methods.Neymon(constA, qMax, left, right);      //берем нашу координату по Х
                listNeimon.Add(xN);                                  //записываем в массив значений по методу Неймана

                if (stop) break;
                if (pause) _busy.WaitOne(Timeout.Infinite);
                if (i % progress == 0) worker.ReportProgress(1);
            }

            listNeimon.Sort();
        }

        //метод Метрополиса
        private void Metropolis(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            double xM, delta;
            delta = (right - left) / 3.0;                       //рассчет delta
            xM = left + (right - left) * rand.NextDouble();    //генерируем начальную точку

            for (int i = 0; i < nIter; i++)
            {
                if (stop) break;
                if (pause) _busy.WaitOne(Timeout.Infinite);
                if (i % progress == 0) worker.ReportProgress(1);

                xM = Methods.Metropolis(constA, left, right, xM, delta);      //следующая точка

                if (i > 100 && xM > left && xM <= right)                      //проверка на холостой ход и попала ли точка в промежуток
                    listMetropolis.Add(xM);
                
            }

            listMetropolis.Sort();
        }
        
        //метод обратных функций
        void Inverse(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            for (int i = 0; i < nIter; i++)
            {
                if (stop) break;
                if (pause) _busy.WaitOne(Timeout.Infinite);
                if (i % progress == 0) worker.ReportProgress(1);

                double Inv = Methods.Inverse(constA); //присвоение значения полученного методом обр. функ
                if(Inv > left)                        //если точка попала в заданный промежуток
                    listInverse.Add(Inv);             //сохраняем ее
                else
                    i--;                              //иначе, делаем откат и все сначала    
            }
            listInverse.Sort();
        }

        //вывод графика функции
        private void AnswerAbsolute()
        {
            var j = 0;
            double st = Math.Abs(right - left) / 100;
            for (var i = left; i < right; i += st)
            {
                chart1.Series[0].Points.AddXY(i, Analit[j]);
                j++;
            }
        }

        //вывод ответа на диаграмму
        private void Answerdiagram(Chart chartX, int series, List<double> listX, double leftX, double rightX,
            double stepX, double nX, List<double> myList)
        {
            var a = 0;
            var j = 0;
            for (var i = leftX; i < rightX; i += stepX)
            {
                double k = 0;
                if (j == listX.Count) continue;
                for (j = a; j < listX.Count; j++)
                {
                    if (listX[j] < i + stepX)
                        k++;
                    else
                    {
                        a = j;
                        break;
                    }
                }
                if (k != 0)
                {
                    k = k / (stepX*nX);
                    chartX.Series[series].Points.AddXY(i + stepX/2, k);
                    myList.Add(k);
                }
            }
        }

        #region FormChanges
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

        private void formA_ValueChanged(object sender, EventArgs e)
        {
            formRight.Value = formA.Value*5;
            formLeft.Value = 0;
        }
        #endregion

        #region Save & Load
        //запись результатов в файл
        private void saveResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TestResult my = new TestResult(constA, nIter, left, right, step, Analit, answerNeimon, answerMetropolis, answerInverse);
                my.AnswerResults(a, disp, sigma);
                my.AnswerResults(aN, dispN, sigmaN);
                my.AnswerResults(aM, dispM, sigmaM);
                my.AnswerResults(aI, dispI, sigmaI);

                XmlSerializer xmlSerializer = new XmlSerializer(typeof (TestResult));
                StringWriter stringWriter = new StringWriter();
                xmlSerializer.Serialize(stringWriter, my);

                string xml = stringWriter.ToString();

                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = "unknown.txt";
                savefile.Filter = @"Text files (*.txt)|*.txt|All files (*.*)|*.*";

                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(savefile.FileName, xml);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        //считывание результатов с файла и вывод
        private void openResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TestResult collection = new TestResult();

                OpenFileDialog theDialog = new OpenFileDialog();
                theDialog.Title = @"Open Text File";
                theDialog.Filter = @"TXT files|*.txt";

                if (theDialog.ShowDialog() == DialogResult.OK)
                {
                    Encoding xml = new ASCIIEncoding();
                    string text = File.ReadAllText(theDialog.FileName, xml);

                    var xmlSerializer = new XmlSerializer(typeof(TestResult));
                    var stringReader = new StringReader(text);
                    collection = (TestResult)xmlSerializer.Deserialize(stringReader);

                    //create formResult
                    FormResult fResult = new FormResult();
                    fResult.FeelResult(collection);
                    fResult.Answer();

                    fResult.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Buttons
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FormDistribution dist = new FormDistribution();
            dist.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FormAbout about = new FormAbout();
            about.Show();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void PauseButton_Click(object sender, EventArgs e)
        {
            if (!pause)
            {
                pause = true;
                PauseButton.Text = @"Resume";
            }

            else
            {
                _busy.Set();
                pause = false;
                PauseButton.Text = @"Pause";
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            stop = true;
        }
        
        private void Open_Click(object sender, EventArgs e)
        {
            TestResult my = new TestResult(constA, nIter, left, right, step, Analit, answerNeimon, answerMetropolis, answerInverse);
            my.AnswerResults(a, disp, sigma);
            my.AnswerResults(aN, dispN, sigmaN);
            my.AnswerResults(aM, dispM, sigmaM);
            my.AnswerResults(aI, dispI, sigmaI);

            FormResult fResult = new FormResult();
            fResult.FeelResult(my);
            fResult.Answer();

            fResult.Show();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            saveResultToolStripMenuItem_Click(sender, e);
        }
        
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"To start the programm press 'Start'");
        }
        #endregion
    }
}



/*Метод Неймана
            double xN, yN;
            for (var i = 0; i < nIter; i++)
            {
                xN = left + (right - left)*rand.NextDouble();
                yN = qMax*rand.NextDouble();

                if (function(constA, xN) > yN) answerNeimon.Add(xN);
                else i--;
            }*/

/*//метод Метрополиса
       private void Metropolis()
       {
           double xM, xNext, delta, pI;
           delta = (right - left)/3;
           xM = left + (right - left) * rand.NextDouble();

           for (int i = 0; i < nIter; i++)
           {

               xNext = xM + delta*(2*rand.NextDouble() - 1);
               pI = function(constA, xNext) / function(constA, xM);
               if (pI > 1)
                   xM = xNext;

               if (rand.NextDouble() < pI)
                   xM = xNext;

               if(i > 100 && xM >= left && xM <= right)
                   answerMetropolis.Add(xM);
           }

           answerMetropolis.Sort();
       }*/

/*        //обратная функция
        double inverseCDF(double s)
        {
            double x;
            if (s < 0.346691)
            {
                x = 1.0642622768277956e-6 * Math.Sqrt(2.1347980205189531e12 * Math.Pow(s, 0.6666666666666666) +
                    1.0323831697580514e12 * Math.Pow(s, 1.3333333333333333) + 6.775644406955992e11 * s * s +
                    5.0331929839908344e11 * Math.Pow(s, 2.6666666666666665) +
                    3.9996925883820276e11 * Math.Pow(s, 3.3333333333333335) + 3.3163359755658606e11 * Math.Pow(s, 4) +
                    2.831279191020564e11 * Math.Pow(s, 4.666666666666667));
            }
            else if (s < 0.796567)
            {
                x = 0.014527571050476862 + s * (9.294742731011485 +
                    s * (-37.43519439668487 + s * (105.40885039276776 +
                    s * (-183.6190579712269 + s * (196.7067172374017 +
                    s * (-118.99569035897035 + 31.66450688674963 * s))))));
            }
            else
            {
                x = (-665.6950297578719 + s * (13652.127578664917 +
                    s * (-47641.68123439248 + s * (73592.91391855325 +
                    s * (-60775.51067786972 + (27088.54652502034 - 5250.64365989075 * s) * s))))) /
                    (2004.625993588326 + s * (-5790.900684890041 + (5572.531218092137 - 1786.242621106215 * s) * s));
            }
            return x;
        }

        public double Next(double sigma)
        {
            return sigma * inverseCDF(rand.NextDouble());
        }
        */