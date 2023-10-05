using System.Diagnostics;
using System.Timers;

namespace Timer_MrT
{
    public partial class Timer_Form : Form
    {
        private Timer_MrT timer;

        public Timer_Form()
        {
            InitializeComponent();

            timer = new Timer_MrT(1);

            timer.Elapsed += (sender, e) =>
            {
                timeTextBox.Invoke(new Action(() =>
                {
                    timeTextBox.Text = (TimeSpan.FromMicroseconds(timer.ElapsedTimeMicroseconds)).ToString(@"hh\:mm\:ss\.ffffff");
                }));
            };

            timeTextBox.SelectionStart = timeTextBox.Text.Length;
            timeTextBox.SelectionLength = 0;
        }

        private void startStopBtn_Click(object sender, EventArgs e)
        {
            if (startStopBtn.Text == "Start")
            {
                startStopBtn.Text = "Stop";
                timer.Start();
                lapResetBtn.Text = "Lap";
            }
            else
            {
                startStopBtn.Text = "Start";
                timer.Stop();
                lapResetBtn.Text = "Reset";
            }
        }

        private void lapResetBtn_Click(object sender, EventArgs e)
        {
            if (lapResetBtn.Text == "Reset")
            {
                timer.Reset();
                lapsTextBox.Text = "";


                if (startStopBtn.Text == "Stop")
                {
                    startStopBtn.Text = "Start";
                }
            }
            else
            {
                timer.AddLap();

                if (lapsTextBox.Text == "")
                {
                    lapsTextBox.AppendText("Lap         Lap Time                  Total Time            " + Environment.NewLine);
                }

                lapsTextBox.AppendText("Lap " + timer.CurrentLaps.Last().lapNumber.ToString() + "     "
                    + (TimeSpan.FromMicroseconds(timer.CurrentLaps.Last().lapTime)).ToString(@"hh\:mm\:ss\.ffffff") + "     "
                    + (TimeSpan.FromMicroseconds(timer.CurrentLaps.Last().totalTime)).ToString(@"hh\:mm\:ss\.ffffff") + Environment.NewLine);
            }
        }
    }

    internal struct Lap
    {
        public int lapNumber;
        public double lapTime;
        public double totalTime;
    }

    internal class Timer_MrT
    {
        // Timer Items
        private System.Timers.Timer timer;
        private Stopwatch stopwatch = new Stopwatch(); // Using Stopwatch for high-resolution timing

        // Laps Items
        private double lapElapsedTime = 0;
        private List<Lap> laps = new List<Lap>();

        public Timer_MrT(double intervalMicroseconds)
        {
            timer = new System.Timers.Timer(intervalMicroseconds / 1000000); // Convert microseconds to milliseconds

            timer.Elapsed += TimerElapsed;
        }

        public double ElapsedTimeMicroseconds
        {
            get { return stopwatch.ElapsedTicks * (1000000.0 / Stopwatch.Frequency); }
        }

        public event EventHandler Elapsed;

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            stopwatch.Start(); // Start or resume the stopwatch
            Elapsed?.Invoke(this, EventArgs.Empty);
        }

        public void Start()
        {
            stopwatch.Start(); // Start the stopwatch
            timer.Start();
        }

        public void Stop()
        {
            stopwatch.Stop(); // Stop the stopwatch
            timer.Stop();
        }

        public void AddLap()
        {
            double elapsedTicks = stopwatch.ElapsedTicks;
            double lapTicks;

            if (laps.Count == 0)
            {
                lapTicks = elapsedTicks;
            }
            else
            {
                lapTicks = elapsedTicks - lapElapsedTime;
            }

            laps.Add(new Lap()
            {
                lapNumber = laps.Count + 1,
                lapTime = lapTicks * (1000000.0 / Stopwatch.Frequency),         // Convert ticks to microseconds
                totalTime = elapsedTicks * (1000000.0 / Stopwatch.Frequency)    // Convert ticks to microseconds
            });

            lapElapsedTime += lapTicks;
        }

        public List<Lap> CurrentLaps
        {
            get { return laps; }
        }

        public void Reset()
        {
            stopwatch.Stop(); // Stop the stopwatch
            timer.Stop();

            stopwatch.Reset(); // Reset the stopwatch
            lapElapsedTime = 0;
            laps = new List<Lap>();

            Elapsed?.Invoke(this, EventArgs.Empty);
        }
    }

}