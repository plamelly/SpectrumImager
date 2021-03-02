using CsvHelper.Configuration.Attributes;

namespace SpectrumImager
{
    class SingnalPoint
    {
        [Name("Time, s")]
        public double Time { get; set; }
        [Name("Task: Acceleration, g")]
        public double Acceleration { get; set; }
    }
}
