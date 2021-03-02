using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using CsvHelper;
using CsvHelper.Configuration;
using System.Linq;
using FastFourierTransform;
using ZedGraph;
using System.Numerics;
using System.Drawing;

namespace SpectrumImager
{
    public partial class SpectrumImagerForm : Form
    {
        private List<SingnalPoint> signalPoints = new List<SingnalPoint>();

        public SpectrumImagerForm()
        {
            InitializeComponent();

            // Задаём параметры поля вывода графика:
            GraphPane pane = imager.GraphPane;
            pane.Title.Text = "Спектр сигнала";
            // Тип оси ординат – логарифмический
            pane.YAxis.Type = AxisType.Log;
            // Сделать основную сетку по оси абсцисс видимой и непрерывной
            pane.XAxis.MajorGrid.IsVisible = true;
            pane.XAxis.MajorGrid.DashOff = 0;
            pane.XAxis.Title.Text = "f, Гц";
            // Сдедать основную и дочернюю сетку оси ординат видимыми и непрерывными
            pane.YAxis.MajorGrid.IsVisible = true;
            pane.YAxis.MajorGrid.DashOff = 0;
            pane.YAxis.MinorGrid.IsVisible = true;
            pane.YAxis.MinorGrid.DashOff = 0;
            pane.YAxis.Title.Text = "А, дБ";
        }
        /// <summary>
        /// Получение пути к файлу с данными
        /// </summary>
        private void SelectPathButton_Click(object sender, EventArgs e)
        {
            // Создаём диалог открытия файла
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                // Задаём фильтры (тип файла и блокировка множественного выбора файла)
                dialog.Filter = "CSV|*csv";
                dialog.Multiselect = false;
                // Если файл успешно выбран
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // Выводим путь в специальное поле
                    filePathTextBox.Text = dialog.FileName;
                }
            }
        }
        /// <summary>
        /// Загрузка данных из файла по заданному пути
        /// </summary>
        private void LoadDataButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Если путь к файлу задан
                using (var streamReader = new StreamReader(filePathTextBox.Text))
                {
                    // Задаём параметры считывателя файла (установить разделитель как ";")
                    var csvReaderConfig = new CsvConfiguration(CultureInfo.InvariantCulture) { Delimiter = ";" };
                    // Инициализируем считыватель CSV-файла
                    using (var csvReader = new CsvReader(streamReader, csvReaderConfig))
                    {
                        // Получаем список точек сигнала
                        signalPoints = csvReader.GetRecords<SingnalPoint>().ToList();
                        // Вывод количества отсчётов сигнала в поле
                        pointCountLabel.Text = signalPoints.Count.ToString();
                        // Сообщение об успешном считывании данных из файла
                        MessageBox.Show("Данные успешно загружены!", "Spectrum Imager", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Spectrum Imager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// Расчёт СКЗ
        /// </summary>
        private void RmsCalculationButton_Click(object sender, EventArgs e)
        {
            // Если данные загружены (есть какие-то значения в списке точек сигнала) 
            if (signalPoints.Any())
            {
                // Суммируем квадраты значений сигнала
                double sum = 0.0;
                foreach (var point in signalPoints)
                {
                    sum += Math.Pow(point.Acceleration, 2);
                }
                // Вычисляем, исходя из суммы, СКЗ
                var rms = Math.Sqrt((1.0 / signalPoints.Count) * sum);
                // Выводим полученное значение в поле
                rmsValueLabel.Text = rms.ToString();
                // Сообщение об успешном вычислении значения СКЗ
                MessageBox.Show("СКЗ вычислено успешно!", "Spectrum Imager", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Требуется предварительно загрузить данные!", "Spectrum Imager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// Вывод изображения спектра
        /// </summary>
        private void ShowSpectrumButton_Click(object sender, EventArgs e)
        {
            // Если данные загружены (есть какие-то значения в списке точек сигнала) и частота задана
            if (signalPoints.Any() && !string.IsNullOrEmpty(frequencyValueTextBox.Text))
            {
                // Парсим частоту сигнала из поля ввода
                double freq = Convert.ToDouble(frequencyValueTextBox.Text);
                // Вычисляем шаг частоты
                double h = 1.0 / freq;
                // Инициализируем массив комплексных чисел с числом элементов, равных числу точек исходного сигнала
                Complex[] values = new Complex[signalPoints.Count];
                // Заполняем массив комплексных чисел:
                int iterator = 0;
                foreach (var point in signalPoints)
                {
                    // Пусть исходный сигнал – это тоже комплексное число, только без мнимой части
                    values[iterator] = new Complex(point.Acceleration, 0);
                    iterator++;
                }
                // Вычисляем быстрое преобразование Фурье
                Complex[] fft_values = FFT.fft(values);
                // Очистить список кривых
                imager.GraphPane.CurveList.Clear();
                // Инициализируем список точек изображаемой кривой
                PointPairList pointList = new PointPairList();
                // Заполняем список точек кривой значениями
                iterator = 0;
                for (double x = 0; x < (fft_values.Length * h); x += h)
                {
                    pointList.Add(x, Complex.Abs(fft_values[iterator]));
                    if (iterator < fft_values.Length - 1) iterator++;
                }
                // Установить поля вывода графика масштаб по умолчанию
                imager.ZoomOutAll(imager.GraphPane);
                // Добавить кривую на поле вывода и обновить состояние поля
                imager.GraphPane.AddCurve("", pointList, Color.Blue, SymbolType.Circle);
                imager.AxisChange();
                imager.Invalidate();
            }
            else
            {
                MessageBox.Show("Требуется предварительно загрузить данные и задать частоту сигнала!", "Spectrum Imager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// Очистка данных приложения
        /// </summary>
        private void ClearDataButton_Click(object sender, EventArgs e)
        {
            // Очистить список точек сигнала
            signalPoints.Clear();
            // Очистить путь к файлу значений
            filePathTextBox.Clear();
            // Очистить значение СКЗ
            rmsValueLabel.Text = "0";
            // Очистить значение количества точек
            pointCountLabel.Text = "0";
            // Очистить поле вывода спектра
            imager.GraphPane.CurveList.Clear();
            imager.AxisChange();
            imager.Invalidate();
        }
    }
}
