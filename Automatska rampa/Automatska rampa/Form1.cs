using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Automatska_rampa
{
    public partial class Form1 : Form
    {
        bool caratgate = false;
        bool carexited = false;
        bool rtop = false;
        bool rbottom = false;
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
            not_car_at_gate.Text = "Auto nije na rampi";
            not_car_at_gate.BackColor = Color.Red;
            btt_start.Select();
            gate_top.Visible = false;
        }

        private void Random_atGate()
        {
            int mseconds;
            Random random = new Random();
            mseconds = random.Next(5, 10) * 1000;
            //System.Threading.Thread.Sleep(mseconds);
            delay(mseconds);
            Atgate();
        }
        private void Atgate()
        {
            caratgate = true;
            Waiting();
        }
        private void Waiting()
        {
            if (caratgate == true)
            {

                car_at_gate.Text = "Auto na rampi";
                car_at_gate.BackColor = Color.Green;
                not_car_at_gate.Visible = false;
                Raising();
            }
            else { MessageBox.Show("Auto nije na rampi"); }
        }
        private void Raising()
        {
            rtop = true;
            Gate_raised();
        }
        private void Gate_raised()
        {
            if (rtop == true)
            {
               // MessageBox.Show("Rampa se diže");
                gate_bottom.Visible = false;
                gate_top.Visible = true;
                car_at_gate.Visible = false;
                not_car_just_exited.Text = "Auto nije prošao rampu";
                not_car_just_exited.BackColor = Color.Red;
               // MessageBox.Show("Auto još nije prošao rampu");
            }
            else { MessageBox.Show("Rampa se nije digla"); }
        }
        
        private void Random_notExited()
        {
            int mseconds2;
            Random random2 = new Random();
            mseconds2 = random2.Next(5, 7) * 1000;
            delay(mseconds2);
        }

        private void Onexit()
        {
            carexited = true;
        }
        private void Lowering()
        {
            if (carexited == true)
            {
                rbottom = true;
                Lower();
            }
        }
        private void Lower()
        {
            if (rbottom == true)
            {
                
                gate_bottom.Visible = true;
                gate_top.Visible = false;
                not_car_just_exited.Visible = false;
                car_just_exited.Text = "Auto je prošao rampu";
                car_just_exited.BackColor = Color.Green;
            }
        }
        private void btt_start_Click(object sender, EventArgs e)
        {
            Random_atGate();
            Atgate();
            Waiting();
            Random_notExited();
            Onexit();
            Lowering();
        }
        private static void delay(int Time_delay)
        {
            int i = 0;
            System.Timers.Timer
            _delayTimer = new System.Timers.Timer();
            _delayTimer.Interval = Time_delay;
            _delayTimer.AutoReset = false;
            _delayTimer.Elapsed += (s, args) => i = 1;
            _delayTimer.Start();
            while (i == 0) { };
        }
    }
}
