using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization;
using System.Windows.Forms.DataVisualization.Charting;

namespace balandin4
{
    public partial class Form : System.Windows.Forms.Form
    {
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, является ли введенный символ цифрой и не является ли он управляющим символом
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Отклоняем введенный символ
            }
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, является ли введенный символ цифрой и не является ли он управляющим символом
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Отклоняем введенный символ
            }
        }

        public Form()
        {
            InitializeComponent();
            MBox.KeyPress += textBox1_KeyPress;
            NBox.KeyPress += textBox2_KeyPress;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            const int gridWidth = 35;


            //grid A init
            A_GridView.RowCount = Convert.ToInt32(NBox.Text);
            A_GridView.ColumnCount = Convert.ToInt32(NBox.Text);
            for (int i = 0; i < A_GridView.ColumnCount; i++)
            {
                A_GridView.Columns[i].Width = gridWidth;
            }



            //grid B init
            B_GridView.RowCount = Convert.ToInt32(NBox.Text);
            B_GridView.ColumnCount = Convert.ToInt32(MBox.Text);
            for (int i = 0; i < B_GridView.ColumnCount; i++)
            {
                B_GridView.Columns[i].Width = gridWidth;
            }

            //grid N1 init
            N1_GridView.RowCount = Convert.ToInt32(NBox.Text);
            N1_GridView.ColumnCount = Convert.ToInt32(NBox.Text);
            for (int i = 0; i < N1_GridView.ColumnCount; i++)
            {
                N1_GridView.Columns[i].Width = gridWidth;
            }

            //grid N2 init
            N2_GridView.RowCount = Convert.ToInt32(NBox.Text);
            N2_GridView.ColumnCount = Convert.ToInt32(NBox.Text);
            for (int i = 0; i < N2_GridView.ColumnCount; i++)
            {
                N2_GridView.Columns[i].Width = gridWidth;
            }

            //grid N3 init
            N3_GridView.RowCount = Convert.ToInt32(MBox.Text);
            N3_GridView.ColumnCount = Convert.ToInt32(MBox.Text);
            for (int i = 0; i < N3_GridView.ColumnCount; i++)
            {
                N3_GridView.Columns[i].Width = gridWidth;
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Random random = new Random();

            // Заполняем A_GridView случайными числами
            FillDataGridViewWithRandomNumbers(A_GridView, random);

            // Заполняем B_GridView случайными числами
            FillDataGridViewWithRandomNumbers(B_GridView, random);

            // Заполняем N1_GridView случайными числами
            FillDataGridViewWithSymmetricRandomNumbers(N1_GridView, random);

            // Заполняем N2_GridView случайными числами
            FillDataGridViewWithSymmetricRandomNumbers(N2_GridView, random);

            // Заполняем N3_GridView случайными числами
            FillDataGridViewWithSymmetricRandomNumbers(N3_GridView, random);
        }
        private void FillDataGridViewWithRandomNumbers(DataGridView dataGridView, Random random)
        {
            // Проходим по всем строкам и столбцам
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    // Генерируем случайное вещественное число от 0 до 100 (выберите нужный диапазон)
                    double randomValue = random.NextDouble() * 10;
                    randomValue = Math.Round(randomValue, 2);
                    double ZeroProb = random.NextDouble() * 10;
                    if (ZeroProb < 3)
                    {
                        randomValue = 0;
                    }


                    // Устанавливаем значение в ячейке
                    dataGridView[j, i].Value = randomValue;

                    //TMP
                    dataGridView[j, i].Value = random.Next(3);

                }
            }
        }

        private void FillDataGridViewWithSymmetricRandomNumbers(DataGridView dataGridView, Random random)
        {
            // Проходим по всем строкам и столбцам
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                for (int j = 0; j <= i; j++)  // Только верхний или нижний треугольник, чтобы создать симметрию
                {
                    // Генерируем случайное вещественное число от 0 до 100 (выберите нужный диапазон)
                    double randomValue = random.NextDouble() * 10;
                    randomValue = Math.Round(randomValue, 2);
                    double zeroProb = random.NextDouble() * 10;

                    if (zeroProb < 3)
                    {
                        randomValue = 0;
                    }

                    // Устанавливаем значение в ячейке
                    dataGridView[j, i].Value = randomValue;
                    dataGridView[i, j].Value = randomValue;  // Симметричное значение

                    //TMP
                    dataGridView[j, i].Value = random.Next(3);
                    dataGridView[i, j].Value = dataGridView[j, i].Value;  // TMP

                }
            }
        }

        private void N2_GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private Matrix<Polynomial> ReadPolynomialMatrixFromDataGridView(DataGridView dataGridView)
        {
            try
            {
                int rows = dataGridView.RowCount;
                int columns = dataGridView.ColumnCount;

                Matrix<Polynomial> matrix = new Matrix<Polynomial>(rows, columns);

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        object cellValue = dataGridView[j, i].Value;

                        // Преобразуем значение в T
                        if (cellValue != null)
                        {
                            matrix[i, j] = new Polynomial();
                            Monomial p = new Monomial(Convert.ToDouble(cellValue.ToString()));
                            matrix[i, j].AddMonomial(p);
                        }
                        else
                        {
                            // Обработка ошибки, если значение в ячейке null
                            MessageBox.Show("Invalid input. Please enter valid values.");
                            return null;
                        }
                    }
                }

                return matrix;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return null;
            }
        }
        private Matrix<Double> ReadDoubleMatrixFromDataGridView(DataGridView dataGridView)
        {
            try
            {
                int rows = dataGridView.RowCount;
                int columns = dataGridView.ColumnCount;

                Matrix<Double> matrix = new Matrix<Double>(rows, columns);

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        object cellValue = dataGridView[j, i].Value;

                        // Преобразуем значение в T
                        if (cellValue != null)
                        {
                            matrix[i, j] = Convert.ToDouble(cellValue.ToString());
                        }
                        else
                        {
                            // Обработка ошибки, если значение в ячейке null
                            MessageBox.Show("Invalid input. Please enter valid values.");
                            return null;
                        }
                    }
                }

                return matrix;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return null;
            }
        }
        private List<double> RungeKutta(List<Polynomial> f, List<double> x0, double h)
        {
            List<List<double>> k1, k2, k3, k4;

            k1 = new List<List<double>>();
            k2 = new List<List<double>>();
            k3 = new List<List<double>>();
            k4 = new List<List<double>>();

            int n = x0.Count;

            // Расчет коэффициентов k1
            for (int i = 0; i < f.Count; i++)
            {
                k1.Add(new List<double>());
                for (int j = 0; j < n; j++)
                {
                    k1[i].Add(h * f[i].Evaluate(x0));
                }
            }

            // Расчет коэффициентов k2
            List<double> x1 = new List<double>();
            for (int i = 0; i < n; i++)
            {
                x1.Add(x0[i] + 0.5 * k1[0][i]);
            }
            for (int i = 0; i < f.Count; i++)
            {
                k2.Add(new List<double>());
                for (int j = 0; j < n; j++)
                {
                    k2[i].Add(h * f[i].Evaluate(x1));
                }
            }

            // Расчет коэффициентов k3
            List<double> x2 = new List<double>();
            for (int i = 0; i < n; i++)
            {
                x2.Add(x0[i] + 0.5 * k2[0][i]);
            }
            for (int i = 0; i < f.Count; i++)
            {
                k3.Add(new List<double>());
                for (int j = 0; j < n; j++)
                {
                    k3[i].Add(h * f[i].Evaluate(x2));
                }
            }

            // Расчет коэффициентов k4
            List<double> x3 = new List<double>();
            for (int i = 0; i < n; i++)
            {
                x3.Add(x0[i] + k3[0][i]);
            }
            for (int i = 0; i < f.Count; i++)
            {
                k4.Add(new List<double>());
                for (int j = 0; j < n; j++)
                {
                    k4[i].Add(h * f[i].Evaluate(x3));
                }
            }

            // Обновление значений
            List<double> result = new List<double>();
            for (int i = 0; i < n; i++)
            {
                result.Add(x0[i] + (k1[0][i] + 2 * k2[0][i] + 2 * k3[0][i] + k4[0][i]) / 6);
            }

            return result;
        }
        private static List<double> Runge(List<Polynomial> f, List<double> x0, double h, double cof = 1)
        {
            List<List<double>> coeff = new List<List<double>>();

            for (int i = 0; i < f.Count; i++)
            {
                List<double> tmp = new List<double>(4);
                tmp.Add(f[i].Evaluate(x0));

                List<double> tmpVec = new List<double>();
                foreach (var el in x0)
                    tmpVec.Append(el + (h / 2.0) * tmp[0]);
                tmp.Add(f[i].Evaluate(tmpVec));

                List<double> tmpVec1 = new List<double>();
                foreach (var el in tmpVec)
                    tmpVec1.Append(el + (h / 2.0) * tmp[1]);
                tmp.Add(f[i].Evaluate(tmpVec1));

                List<double> tmpVec2 = new List<double>();
                foreach (var el in tmpVec1)
                    tmpVec2.Append(el + h * tmp[2]);
                tmp.Add(f[i].Evaluate(tmpVec2));
                coeff.Add(tmp);
            }

            List<double> xi = new List<double>(f.Count);
            for (int i = 0; i < f.Count; i++)
            {
                xi.Add(x0[i] + cof * (h / 6.0) * (coeff[i][0] + coeff[i][1] * 2 + coeff[i][2] * 2 + coeff[i][3]));
            }

            return xi;
        }



        private void CalculateButton_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(NBox.Text);
            int m = Convert.ToInt32(MBox.Text);
            double t0 = Convert.ToInt32(t0Box.Text);
            double T = Convert.ToInt32(TBox.Text);
            double step = 0.1;

            Matrix<Polynomial> A = ReadPolynomialMatrixFromDataGridView(A_GridView);
            Matrix<Polynomial> B = ReadPolynomialMatrixFromDataGridView(B_GridView);

            Matrix<Polynomial> N1 = ReadPolynomialMatrixFromDataGridView(N1_GridView);
            Matrix<Polynomial> N2 = ReadPolynomialMatrixFromDataGridView(N2_GridView);
            Matrix<Polynomial> N3 = ReadPolynomialMatrixFromDataGridView(N3_GridView);
            Matrix<Double> N3_real = ReadDoubleMatrixFromDataGridView(N3_GridView);

            if (N3_real.Determinant() == 0)
            {
                MessageBox.Show("Zero determinant", "Error", MessageBoxButtons.OK);
                return;
            }

            Res_GridView.Rows.Clear();
            Res_GridView.Columns.Clear();
            Res_GridView.Columns.Add("t", "t");
            Res_GridView.Columns.Add("U(t)", "U(t)");

            //chart??????????????????

            for (int i = 0; i < n * 2 - 1; i++)
                Res_GridView.Columns.Add("P" + (i + 1).ToString() + "(t)", "P" + (i + 1).ToString() + "(t)");
            for (int i = 0; i < n; i++)
                Res_GridView.Columns.Add("X" + (i + 1).ToString() + "(t)", "X" + (i + 1).ToString() + "(t)");

            int size = n;
            Matrix<Polynomial> P = new Matrix<Polynomial>(n, n);
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                {
                    P[i, j] = new Polynomial();
                    Monomial tmp = new Monomial(i + j);
                    P[i, j].AddMonomial(tmp);
                }
            Matrix<Polynomial> dPdt = new Matrix<Polynomial>(size, size);
            dPdt = P * B * N3 * B.Transpose() * P - (A.Transpose() * P + P * A + N2);

            List<Polynomial> sys_p = new List<Polynomial>();

            for (int i = 0; i < dPdt.Rows; i++)
            {
                sys_p.Add(dPdt[0, i]);
            }
            for (int i = 1; i < dPdt.Columns; i++)
            {
                sys_p.Add(dPdt[i, dPdt.Rows - 1]);
            }



            List<double> p_curr = new List<double>();    //начальные условия

            List<double> tmpList = new() { 1, 1, 1, 1, 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i < N1.Rows; i++)
            {
                p_curr.Add(N1[0, i].Evaluate(tmpList));
            }
            for (int i = 0; i < N1.Columns; i++)
            {
                p_curr.Add(N1[0, N1.Rows - 1].Evaluate(tmpList));
            }

            List<Matrix<Polynomial>> PotT = new List<Matrix<Polynomial>>();
            List<List<double>> Pvals = new List<List<double>>();
            for (double t1 = T; t1 > t0 - step; t1 -= step)
            {
                List<double> res_ot_t = Runge(sys_p, p_curr, step);
                Matrix<Polynomial> tmp_matr = new Matrix<Polynomial>(size, size);
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        Polynomial tmp = new Polynomial();
                        tmp.AddMonomial(new Monomial(res_ot_t[i + j]));
                        tmp_matr[i, j] = tmp;
                    }
                }
                Res_GridView.Rows.Add("", "");

                PotT.Add(tmp_matr);
                p_curr = res_ot_t;
                Pvals.Add(res_ot_t);
            }
            double t_0 = t0;
            for (int i = 0; i < Pvals.Count; i++)
            {
                int k = Pvals.Count - i - 1;
                Res_GridView.Rows[i].Cells[0].Value = Math.Round(t_0, 2);
                t_0 += step;
                for (int j = 0; j < Pvals[k].Count; j++)
                    Res_GridView.Rows[i].Cells[j + 2].Value = Pvals[k][j];
            }

            List<Polynomial> UotT = new List<Polynomial>();
            dynamic revers = N3_real.GetInverse(); //Получаем n3^-1
            Matrix<Polynomial> minusN3rev = new Matrix<Polynomial>(revers.Rows, revers.Columns);
            for (int i = 0; i < revers.Rows; i++)
            {
                for (int j = 0; j < revers.Columns; j++)
                {
                    Monomial tmp_monom = new Monomial((-1) * revers[i, j]);
                    minusN3rev[i, j] = new Polynomial();
                    minusN3rev[i, j].AddMonomial(tmp_monom);
                }
            }

            Matrix<Polynomial> X = new Matrix<Polynomial>(size, size);
            for (int i = 0; i < size; i++)
            {
                Monomial tmp_monom = new Monomial(i);
                X[i, 0] = new Polynomial();
                X[i, 0].AddMonomial(tmp_monom);
                for (int j = 1; j < size; j++)
                {
                    Monomial tmp_monom2 = new Monomial(0);
                    X[i, j] = new Polynomial();
                    X[i, j].AddMonomial(tmp_monom2);
                }
            }

            List<double> x_curr = Enumerable.Repeat(1.0, size).ToList(); //начальные условия, в дальнейшем текущие

            //Um = minusN3rev * (*B).transpose() * PotT[0] * X;
            List<List<double>> XotT = new List<List<double>>();
            double t = 0;
            for (int i = 0; i < PotT.Count; t += step, i++)
            {
                Matrix<Polynomial> U_tmp = new Matrix<Polynomial>(size, size);
                U_tmp = minusN3rev;
                U_tmp = U_tmp * B.Transpose();
                U_tmp = U_tmp * PotT[i];
                U_tmp = U_tmp * X;


                UotT.Add(U_tmp[0, 0]);

                Matrix<Polynomial> dXDt = new Matrix<Polynomial>(size, size);
                dXDt = A * X + B * U_tmp;


                List<Polynomial> sys_x = new List<Polynomial>();
                for (int k = 0; k < size; k++)
                    sys_x.Add(dXDt[k, 0]);

                XotT.Add(Runge(sys_x, x_curr, step));
                x_curr = XotT[XotT.Count - 1];

                //textBox4->Text += U_tmp(0, 0).getVal(x_curr) + "\r\n";
            }
            chart1.Series.Clear();
            List<Series> seriesX = new List<Series>(XotT.Count);
            for (int i = 0; i < XotT[0].Count; i++)
            {
                seriesX.Add(new Series("X" + Convert.ToString(i)));
                seriesX[i].ChartType = SeriesChartType.Line;
                for (int j = 0; j < XotT.Count; j++)
                {
                    seriesX[i].Points.AddXY(j * step, XotT[j][i]);
                }
                chart1.Series.Add(seriesX[i]);
            }
            List<Series> seriesP = new List<Series>(PotT.Count);
            for (int i = 0; i < PotT[0].Rows; i++)
            {
                seriesP.Add(new Series("P" + Convert.ToString(i)));
                seriesP[i].ChartType = SeriesChartType.Line;

                for (int j = 0; j < PotT.Count; j++)
                {
                    Matrix<Polynomial> tmpM = PotT[i];
                    seriesP[i].Points.AddXY(j * step, tmpM[i, i].Evaluate(tmpList));
                }
                chart1.Series.Add(seriesP[i]);
            }
            Series seriesU = new Series("U");
            seriesU.ChartType = SeriesChartType.Line;


            for (int i = 0; i < XotT.Count; i++)
            {
                for (int j = 0; j < XotT[i].Count; j++)
                {
                    Res_GridView.Rows[i].Cells[j + 1 + size * 2].Value = XotT[i][j];

                }
                seriesU.Points.AddXY(i * step, UotT[i].Evaluate(XotT[i]));
                Res_GridView.Rows[i].Cells[1].Value = UotT[i].Evaluate(XotT[i]);

            }
            chart1.Series.Add(seriesU);

            chart1.ChartAreas[0].AxisX.Title = "X-Axis";
            chart1.ChartAreas[0].AxisY.Title = "Y-Axis";
            chart1.Update();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}