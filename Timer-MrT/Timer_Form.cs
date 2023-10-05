using System;
using System.Timers;

namespace Timer_MrT
{
    public partial class Timer_Form : Form
    {
        private Timer_MrT timer;

        public Timer_Form()
        {
            InitializeComponent();

            timer = new Timer_MrT(50);

            timer.Elapsed += (sender, e) =>
            {
                timeTextBox.Invoke(new Action(() =>
                {
                    timeTextBox.Text = (TimeSpan.FromMilliseconds(timer.ElapsedTime)).ToString(@"hh\:mm\:ss\.ff");
                }));
            };
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

                if (lapsTextBox.Text.Length > 0)
                {
                    lapResetBtn.Text = "Reset";
                }
                else
                {
                    lapResetBtn.Text = "Lap";
                }
            }
        }

        private void lapResetBtn_Click(object sender, EventArgs e)
        {
            if (lapResetBtn.Text == "Reset")
            {
                timer.Reset();
                lapsTextBox.Text = "";
                lapsTextBox.Visible = false;


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
                    lapsTextBox.Visible = true;
                    lapsTextBox.AppendText("Lap     Lap Time     Total Time" + Environment.NewLine);
                }

                string lapString = "Lap " + timer.currentLaps.Count.ToString() + "  "
                    + (TimeSpan.FromMilliseconds(timer.currentLaps.Last().lapTime)).ToString(@"hh\:mm\:ss\.ff") + "  "
                    + (TimeSpan.FromMilliseconds(timer.currentLaps.Last().totalTime)).ToString(@"hh\:mm\:ss\.ff");

                lapsTextBox.AppendText(lapString + Environment.NewLine);
            }
        }
    }

    struct Lap
    {
        public int lapNumber;
        public double lapTime;
        public double totalTime;
    }

    class Timer_MrT
    {
        private System.Timers.Timer timer;
        private double elapsedTime = 0; // Elapsed time in milliseconds
        private List<Lap> laps = new List<Lap>();

        public Timer_MrT(double interval)
        {
            timer = new System.Timers.Timer(interval);
            timer.Elapsed += TimerElapsed;
        }

        public double ElapsedTime
        {
            get { return elapsedTime; }
        }

        public event EventHandler Elapsed;

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            elapsedTime += timer.Interval;
            Elapsed?.Invoke(this, EventArgs.Empty);
        }

        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }

        public void AddLap()
        {
            laps.Add(new Lap()
            {
                lapNumber = laps.Count + 1,
                lapTime = (laps.Count > 1) ? elapsedTime - laps.ElementAt(laps.Count - 1).lapTime : elapsedTime,
                totalTime = elapsedTime
            });
        }

        public List<Lap> currentLaps
        {
            get { return laps; }
        }

        public void Reset()
        {
            timer.Stop();

            elapsedTime = 0;
            laps.Clear();

            Elapsed?.Invoke(this, EventArgs.Empty);
        }
    }
}