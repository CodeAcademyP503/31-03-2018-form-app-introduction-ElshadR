using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaApp
{
    public partial class Seats : Form
    {
        public static TextBox SeatResault;
        public Button Resault;
        public Button Zal = new Button();
        public static  List<int> SeatNum = new List<int>();
        public static List<string> Seatname = new List<string>();
        public static  Button Vxt2,Vxt1;
        public Button btn;
        public static Button seat;
        public int TopPos = 80;
        public int LeftPos = 80;
        public int b = 3;
        public int l = 10;
        public int a = 6;
        public int count=1;
        public int y=1;
        public static List<int> ylar = new List<int>();
        public Seats()
        {

            InitializeComponent();


            SeatsEnabled();

            zal();




            for (int i = 0; i < 6; i++)
            {
                if (i < 3)
                {
                    for (int j = 0; j <l; j++)
                    {
                        seat = new Button();
                        seat.BackgroundImage = global::CinemaApp.Properties.Resources.seatcinema;
                        seat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                        seat.Width = 40;
                        seat.Height = 40;
                        seat.Top = TopPos;
                        seat.Left = LeftPos;
                        LeftPos += seat.Width;
                        seat.Name = count.ToString();
                        seat.BackColor = Color.White;
                        seat.FlatStyle = FlatStyle.Flat;
                        seat.Text = count.ToString();
                        
                        
                        count++;
                        seat.Click += new EventHandler(SeatData);
                        Controls.Add(seat);
                    }
                    LeftPos = seat.Width * b;
                    l -= 2;
                    b++;
                    TopPos += seat.Height;
                }
                else
                {
                    l = 10;
                    LeftPos = 80;
                    for (int k = 0; k < l; k++)
                    {
                        if (k == 0 || k == 9 /*|| k == 1 || k == 8*/)
                        {
                            seat = new Button();
                            seat.BackgroundImage = global::CinemaApp.Properties.Resources.seatcinema;
                            seat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                            seat.Width = 40;
                            seat.Height = 40;
                            seat.Top = TopPos;
                            seat.Left = LeftPos;
                            seat.BackColor = Color.White;
                            seat.FlatStyle = FlatStyle.Flat;
                            seat.Text = count.ToString();
                            seat.Name = count.ToString();
                            
                            count++;
                            seat.Click += new EventHandler(SeatData);
                            Controls.Add(seat);
                        }
                        else if (k > 2 && k < 7)
                        {
                            seat = new Button();
                            seat.BackgroundImage = global::CinemaApp.Properties.Resources.seatcinema;
                            seat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                            seat.Width = 40;
                            seat.Height = 40;
                            seat.Top = TopPos;
                            seat.Left = LeftPos;
                            seat.BackColor = Color.White;
                            seat.FlatStyle = FlatStyle.Flat;
                            seat.Text = count.ToString();
                            seat.Name = count.ToString();
                            count++;
                            
                            seat.Click += new EventHandler(SeatData);
                            Controls.Add(seat);
                        }
                        LeftPos += seat.Width;
                    }
                    TopPos += seat.Height;
                }
                
            }
         

            SeatResault = new TextBox();
            SeatResault.Width = 150;
            SeatResault.Height = 25;
            SeatResault.Top = this.Height+80;
            SeatResault.Enabled = false;
            SeatResault.Left = this.Width  - 17 - 150+80;
            Controls.Add(SeatResault);

            Resault = new Button();
            Resault.Text = "Rezerv Et";
            Resault.Width = 65;
            Resault.Height = 25;
            Resault.Top = this.Height+80;
            Resault.Left = 80;
            
            Resault.Click += new EventHandler(ResaultData);
            Controls.Add(Resault);

            this.Width = seat.Width*12 + 80 + 17;
            this.Height = Resault.Top + 45 + 40;


            Vxt1 = new Button();
            Vxt1.Width = 80;
            Vxt1.Height = 20;
            Vxt1.Top = 355;
            Vxt1.Left = 400;
            Vxt1.Text = " 12:00";
            Vxt1.BackColor = Color.White;
            Vxt1.Click += new EventHandler(Vxt21Data);
            Vxt1.Name = "seans12";
            Controls.Add(Vxt1);

            Vxt2 = new Button();
            Vxt2.Width = 80;
            Vxt2.Height = 20;
            Vxt2.Top = 395;
            Vxt2.Left = 400;
            Vxt2.Text = " 20:00";
            Vxt2.BackColor = Color.White;
            Vxt2.Click += new EventHandler(Vxt2Data);
            Vxt2.Name = "seans20";
            Controls.Add(Vxt2);


        }
        public void SeatData(object obj, EventArgs e)
        {

            Button btn = obj as Button;

            
            
                if (btn.BackColor == seat.BackColor)
                {

                    btn.BackColor = Color.Green;
                    SeatResault.Text += btn.Text + ", ";
                    SeatNum.Add(Convert.ToInt32(btn.Text));

                    Seatname.Add(btn.Name);


                }
                else
                {
                    btn.BackColor = Color.White;
                    SeatNum.Remove(Convert.ToInt32(btn.Text));
                    Seatname.Remove(btn.Name);
                    SeatResault.Text = "";
                    foreach (var num in SeatNum)
                    {
                        SeatResault.Text += num.ToString() + ",";
                    }
                }


            




        }
        public void Vxt2Data(object obj, EventArgs e)
        {
            Button Vxt2 = obj as Button;
            Vxt2.Text = "20:00";
           
            if (Vxt2.BackColor==Color.White)
            {
               
                Vxt2.BackColor = Color.Green;
                
                
            }
            else
            {
                Vxt2.BackColor = Color.White;
                
            }


        }
        public void Vxt21Data(object obj,EventArgs e)
        {
            
            Button vxt1 = obj as Button;
            vxt1.Text = "12:00";
            if (Vxt1.BackColor == Color.White)
            {
                Vxt1.BackColor = Color.Green;

                
            }
            else
            {
                Vxt1.BackColor = Color.White;
                
            }
        }

        public void ResaultData(object obj, EventArgs e)
        {


            SeatsEnabled();
            this.Close();
            Print Read = new Print();
            Read.ShowDialog();
          
            
        }
  
        public void SeatsEnabled()
        {
            foreach (var j in Controls)
            {
                foreach (var name in Seatname)
                {

                    if (j is Button)
                    {

                        Button btn = j as Button;
                        // btn.Enabled = false;

                        if (btn.Name == name)
                        {
                            //MessageBox.Show(btn.Name);
                            btn.Enabled = false;


                        }

                    }
                }

            }

        }
        public void zal()
        {




            Zal.Text = "ZAL" + " " + y.ToString();
            Zal.Width = 100;
            Zal.Height = 30;
            Zal.Top = 5;
            Zal.Left = this.Width / 2 + 100;
            Zal.FlatStyle = FlatStyle.Flat;
            Zal.BackColor = Color.DarkGray;
            Zal.Enabled = false;
            
            Controls.Add(Zal);

        }
    }
}
