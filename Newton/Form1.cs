using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Поля

        private static int Degree;
        private double maxf;
        private static DataGridView XData;
        private static DataGridView[] YData;

        private static double[] XArray;
        private static double[][] YArray;

        #endregion

        private void InitializeDataContainers()//контейнер для розділених різниць
        {
            if (XData != null)
            
                XData.Dispose();

            if (YData != null)
                foreach (DataGridView NewData in YData)
                {
                    NewData.Dispose();
                }

            XData = new DataGridView();
            YData = new DataGridView[Degree];

            XArray = new double[Degree];
            YArray = new double[Degree][];

            for (int i = 0; i < YArray.Length; i++)
            {
                YArray[i] = new double[Degree - i];
            }

        }
        private void InitializeDataGridView(DataGridView data, int rowCount, Point location)//cтворення таблиці
        {
            data.Size = new Size(50, rowCount * 22);
            data.Location = location;
            data.TabIndex = 0;

            data.Columns.Add("Value", "");
            data.Columns["Value"].Width = 47;
            data.RowCount = rowCount + 1;
            data.RowHeadersVisible = false;//заголовки стопців
            data.ColumnHeadersVisible = false;//заголовки стопців

            data.ScrollBars = ScrollBars.None;//прокрутка
            
            
            //Стрічки
            data.AllowUserToAddRows = false;
            data.AllowUserToDeleteRows = false;
            data.AllowUserToOrderColumns = false;
            data.AllowUserToResizeColumns = false;
            data.AllowUserToResizeRows = false;
            data.ReadOnly = true;//комірки таблиці
        }
        private void CheckFormSizes()//визначатиме розміри нашої форми
        {
            Width = 800 + XData.Width + Degree * 47;

            textBoxPolynom.Width = Width - 485;

            if (XData.Height > 200)
            {
                Height = 95 + XData.Height;
                textBoxPolynom.Location = new Point(12, 20 + XData.Height);
            }
            else
            {
                Height = 450;
                textBoxPolynom.Location = new Point(12, 200);
            }

            tableInterpolationPoints.Location = new Point(Width - 470, tableInterpolationPoints.Location.Y);
            tableInterpolationPoints.Height = Height - 57;
        }

        private void buttonCreateTable_Click(object sender, EventArgs e)
        {
            Degree = Convert.ToInt32(textBox1.Text);

            InitializeDataContainers();

            InitializeDataGridView(XData, Degree, new Point(196, 12));
            Controls.Add(XData);

            for (int i = 0; i < Degree; i++)
            {
                YData[i] = new DataGridView();

                InitializeDataGridView(YData[i], Degree - i, new Point(208 + XData.Width + i * 47, 12 + i * 11));

                Controls.Add(YData[i]);
            }
            
            textBoxPolynom.Text = String.Empty;

            CheckFormSizes();
        }
      
        #region Заповнення таблиці розділених різниць

        private void buttonFillTableFromFile_Click(object sender, EventArgs e)// читання з файлу таблиці розділених різниць
        {
            string Path;

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Path = openFileDialog.FileName;
                string[] Data;

                using (StreamReader Reader = new StreamReader(Path))
                {
                    Data = Reader.ReadToEnd().Split(new char[] { ' ', '\n' });
                }

                for (int i = 0; i < Degree; i++)
                {
                    XArray[i] = Convert.ToDouble(Data[i * 2]);
                    YArray[0][i] = Convert.ToDouble(Data[i * 2 + 1]);

                    XData[0, i].Value = Data[i * 2];
                    YData[0][0, i].Value = Data[i * 2 + 1];
                }
            }
        }
        private void buttonFillTableWithTabulation_Click(object sender, EventArgs e)
        {
           

            // ПРОГРАМНЕ ЗАДАННЯ 
            int i = 0;//лічильник
            int a = 1, b = 4;//межі нашої функції
            double r = Math.Abs(b - a);
            double d = Degree;
            double h = r / d;//крок
            maxf = maxabsderivf(a, Degree);
            for (double j = a; i < d; j += h)
            {
                XArray[i] = j;
                YArray[0][i] = f(j);

                XData[0, i].Value = j;
                YData[0][0, i].Value = f(j);

                if (f(j) > maxf) maxf = f(j);
                                
                i++;
            }
        }

        #endregion

        private void buttonCalculatePolynom_Click(object sender, EventArgs e)//обчислення многочлена
        {
            for (int i = 1; i < Degree; i++)
            {
                for (int j = 0; j < YData[i].RowCount; j++)
                {
                    YArray[i][j] = (YArray[i - 1][j + 1] - YArray[i - 1][j]) / (XArray[i + j] - XArray[j]);
                    YData[i][0, j].Value = YArray[i][j];
                }
            }

            textBoxPolynom.Text = String.Empty;

            CreateStringHornerPolynom(3);
           // CreateStringNewtonPolynom(3);
        }

        #region Формування многочлена

        private void CreateStringHornerPolynom(int roundDecimals)// Горнер
        {
            textBoxPolynom.Text = "L(x) = ";
            if (YArray[0][0] != 0) textBoxPolynom.Text += YArray[0][0] + " + ";

            for (int i = 0; i < Degree - 1; i++)
            {
                if (XArray[i] != 0)
                    textBoxPolynom.Text += "(x-" + XArray[i] + ")(";
                else textBoxPolynom.Text += "x(";

                if (YArray[i+1][0] != 0)
                {
                    if (YArray[i+1][0] < 0)
                        textBoxPolynom.Text += "-";
                    textBoxPolynom.Text += Math.Round(Math.Abs(YArray[i+1][0]), roundDecimals) + " + ";
                }
            }
            
            for (int i = 0; i < Degree - 1; i++) textBoxPolynom.Text += ")";

            textBoxPolynom.Text = textBoxPolynom.Text.Replace(" + )", ")");
            textBoxPolynom.Text = textBoxPolynom.Text.Replace("()","");

            for (int i = Degree - 1; i > 0; i--)
            {
                string Expression = "(x-" + XArray[i] + ")";

                if (textBoxPolynom.Text.Contains(Expression + ")"))
                {
                    textBoxPolynom.Text = textBoxPolynom.Text.Replace(Expression, "");
                    textBoxPolynom.Text = textBoxPolynom.Text.Replace(" + )", ")");
                    textBoxPolynom.Text = textBoxPolynom.Text.Replace("()", "");
                }
            }
        }
        private void CreateStringNewtonPolynom(int roundDecimals)//Ньютон
        {
            textBoxPolynom.Text = "L(x) = ";
            if (YArray[0][0] != 0) textBoxPolynom.Text += YArray[0][0] + " ";

            for (int i = 1; i < Degree; i++)
            {
                if (YArray[i][0] != 0)
                {
                    if (YArray[i][0] > 0)
                        textBoxPolynom.Text += "+ ";
                    else 
                        textBoxPolynom.Text += "- ";
                    if (Math.Round(Math.Abs(YArray[i][0]), roundDecimals) != 1)
                        textBoxPolynom.Text += Math.Round(Math.Abs(YArray[i][0]), roundDecimals);

                    for (int j = 0; j < i; j++)
                    {
                        if (XArray[j] != 0)
                            textBoxPolynom.Text += "(x-" + XArray[j] + ")";
                        else textBoxPolynom.Text += "x";
                    }
                }
                textBoxPolynom.Text += " ";
            }

            textBoxPolynom.Text = textBoxPolynom.Text.Replace("--", "+");

            if (textBoxPolynom.Text.IndexOf('+') != -1)
            {
                if (textBoxPolynom.Text.IndexOf('+') < textBoxPolynom.Text.IndexOfAny("123456789".ToCharArray()))
                {
                    textBoxPolynom.Text = textBoxPolynom.Text.Remove(textBoxPolynom.Text.IndexOf('+'), 2);
                }
                else if (textBoxPolynom.Text.IndexOfAny("123456789".ToCharArray()) == -1)
                {
                    textBoxPolynom.Text = textBoxPolynom.Text.Remove(textBoxPolynom.Text.IndexOf('+'), 2);
                }
            }          
        }

        #endregion        

        private void buttonCalculateAtPoint_Click(object sender, EventArgs e)//обчислення і запис у таблицю
        {
            double InterpolationPoint = Convert.ToDouble(textBox2.Text);
            double Result = 0;

            for (int i = Degree - 1; i > 0; i--)
            {
                Result += YArray[i][0];
                Result *= (InterpolationPoint - XArray[i - 1]);
            }
            Result += YArray[0][0];

            tableInterpolationPoints.Rows.Add();
            tableInterpolationPoints[0, tableInterpolationPoints.RowCount - 1].Value = InterpolationPoint;
            tableInterpolationPoints[1, tableInterpolationPoints.RowCount - 1].Value = Result;
            tableInterpolationPoints[2, tableInterpolationPoints.RowCount - 1].Value = f(InterpolationPoint);
            tableInterpolationPoints[3, tableInterpolationPoints.RowCount - 1].Value = maxf * omega(InterpolationPoint,Degree);
            tableInterpolationPoints[4, tableInterpolationPoints.RowCount - 1].Value = Math.Abs(f(InterpolationPoint)-Result);
            
        }

        double f(double x)//Ф-ція
        {
            return  2*Math.Pow(x,5)+Math.Sin(7*x) ;
        }

        double maxabsderivf(double x, int n)//n-тта похідна
        {
            return Math.Pow(7,n+1) ;
        }

        double omega(double x, int n)//ф-ція омега
        {
            double result = 1;
            for (int i = 0; i <= n; i++)
            {
                result *= (x - XArray[i]) ;
            }
            return Math.Abs(result);
        }

        private void textBoxPolynom_TextChanged(object sender, EventArgs e)
        {

        } 
    }
}
