using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace CountDown_Silvester
{
    public partial class Form1 : Form
    {
        #region Variables
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        private string soundLocation = "C:/Users/Zocke/Music/Panic! At The Disco - High Hopes.wav";
        private string sSoundLength = "0:3:16";
        private int iSoundLength = 0;

        private int iCurrentHours = 0, iCurrentMinutes = 0, iCurrentSeconds = 0;
        #endregion

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Layout();

            player.SoundLocation = soundLocation;
            iSoundLength = ConvertTime_PlayMusic(sSoundLength);

            timerCountdown_Tick(sender, e);
            timerCountdown.Start();
        }
        
        private new void Layout()
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            Form1.ActiveForm.BackColor = Color.Black;
            /*
            labelLayout.AutoSize = false;
            labelLayout.Dock = DockStyle.Fill;
            labelLayout.Anchor = AnchorStyles.None;
            */

            ///*
            lCountdownHours.AutoSize = false;
            lCountdownHours.TextAlign = ContentAlignment.MiddleCenter;
            lCountdownHours.Dock = DockStyle.Fill;
            lCountdownHours.Font = new Font("Microsoft Sans Serif", 150, FontStyle.Bold);
            //*/
            //lCountdownHours.Dock = DockStyle.Fill;
            lCountdownHours.ForeColor = Color.LightGray;

            /*lCountdownMinutes.AutoSize = false;
            lCountdownMinutes.TextAlign = ContentAlignment.MiddleCenter;
            lCountdownMinutes.Dock = DockStyle.Fill;
            lCountdownMinutes.Font = new Font("Microsoft Sans Serif", 150, FontStyle.Bold);
            */
            lCountdownMinutes.Dock = DockStyle.Fill;
            lCountdownMinutes.ForeColor = Color.LightGray;

            /*lCountdownSeconds.AutoSize = false;
            lCountdownSeconds.TextAlign = ContentAlignment.MiddleCenter;
            lCountdownSeconds.Dock = DockStyle.Fill;
            lCountdownSeconds.Font = new Font("Microsoft Sans Serif", 150, FontStyle.Bold);
            */
            lCountdownSeconds.Dock = DockStyle.Fill;
            lCountdownSeconds.ForeColor = Color.LightGray;
        }

        private void timerCountdown_Tick(object sender, EventArgs e)
        {
            GetCurrentTime();
            lCountdownHours.Text = GetLeftTime();
            PlayMusic();
        }

        private void Log()
        {
            Console.WriteLine("-------------------------------");
            //Console.WriteLine("Uhrzeit gerade: " + GetCurrentHours() + ":" + GetCurrentMinutes() + ":" + GetCurrentSeconds());
            //Console.WriteLine("Zeit bis 24 Uhr: " + GetLeftHours() + ":" + GetLeftMinutes() + ":" + GetLeftSeconds());
            //Console.WriteLine("Zeit in Sekunden: " + ((GetLeftHours() * 60 * 60) + (GetLeftMinutes() * 60) + GetLeftSeconds()));
            //Console.WriteLine("Sekunden von ConvertTime: " + (86400 - ConvertTime_PlayMusic("12:12:30")));
        }

        #region getter & setter
        private void GetCurrentTime()
        {
            string time = DateTime.Now.TimeOfDay.ToString();
            string[] timeSplit = time.Split(':');
            int i = 0;
            foreach (string word in timeSplit)
            {
                i++;
                switch (i)
                {
                    default:
                        return;
                    case 1:
                        Int32.TryParse(word, out iCurrentHours);
                        break;
                    case 2:
                        Int32.TryParse(word, out iCurrentMinutes);
                        break;
                    case 3:
                        string[] sSeconds = word.Split('.');
                        int[] iSeconds = new int[2];
                        Int32.TryParse(sSeconds[0], out iSeconds[0]);
                        Int32.TryParse(sSeconds[1], out iSeconds[1]);
                        if (iSeconds[1] < 5)
                            iCurrentSeconds = iSeconds[0];
                        else if(iSeconds[1] >= 5)
                            iCurrentSeconds = iSeconds[0] + 1;
                        break;
                }
            }
        }

        private string GetLeftTime()
        {
            int hours = 24, minutes = 60, seconds = 60;
            return  (hours - GetCurrentHours() - 1).ToString() + ":" + 
                    (minutes - GetCurrentMinutes() - 1).ToString() + ":" +
                    (seconds - GetCurrentSeconds()).ToString();
        }

        private int GetCurrentHours()
        {
            return iCurrentHours;
        }

        private int GetCurrentMinutes()
        {
            return iCurrentMinutes;
        }

        private int GetCurrentSeconds()
        {
            return iCurrentSeconds;
        }

        private int GetLeftHours()
        {
            return (24 - iCurrentHours - 1);
        }

        private int GetLeftMinutes()
        {
            return (60 - iCurrentMinutes - 1);
        }

        private int GetLeftSeconds()
        {
            return (60 - iCurrentSeconds);
        }
        #endregion

        #region stop & play song
        private void PlayMusic()
        {
            if (((GetLeftHours() * 60 * 60) + (GetLeftMinutes() * 60) + GetLeftSeconds()) == (86400 - ConvertTime_PlayMusic("12:16:0"))) //86400 = 24h
                PlaySound();
        }

        private void PlaySound()
        {
            player.Play();
        }

        private int ConvertTime_PlayMusic(string time)
        {
            string[] asTime = time.Split(':');
            int[] aiTime = new int[asTime.Length];
            Int32.TryParse(asTime[0], out aiTime[0]);
            Int32.TryParse(asTime[1], out aiTime[1]);
            Int32.TryParse(asTime[2], out aiTime[2]);
            return (aiTime[0] * 60 * 60) + (aiTime[1] * 60) + aiTime[2];
        }
        #endregion
    }
}
