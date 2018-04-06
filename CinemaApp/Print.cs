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
    public partial class Print : Form
    {
        public TextBox Read1;
        public TextBox Read2;
        public TextBox Read3;
        public Button newResault;
        public Label Text1;
        public Label Text2;
        public Label Text3;
        public Print()
        {
            InitializeComponent();
            Read1 = new TextBox();
            Read1.Width = 100;
            Read1.Height = 30;
            Read1.Top = 20;
            Read1.Left = 5;
            Read1.Enabled = false;
            Read1.Text = Seats.SeatResault.Text;
            Controls.Add(Read1);
            Read2 = new TextBox();
            Read2.Width = 100;
            Read2.Height = 30;
            Read2.Top = 51;
            Read2.Left = 5;
            Read2.Enabled = false;
            Read2.Text =( Seats.SeatNum.Count*Cinema.l).ToString();
            Seats.SeatNum.Clear();
            Controls.Add(Read2);
            Read3 = new TextBox();
            Read3.Width = 100;
            Read3.Height = 30;
            Read3.Top = 82;
            Read3.Left = 5;
            Read3.Enabled = false;
            if (Seats.Vxt1.BackColor == Color.Green)
            {
                Read3.Text = Seats.Vxt1.Text;
            }
            else if (Seats.Vxt2.BackColor == Color.Green)
            {
                Read3.Text = Seats.Vxt2.Text;
            }
            
            
            Controls.Add(Read3);
            Text1 = new Label();
            Text1.Text = "Nomreli yerler rezerv edildi.";
            Text1.Width = 150;
            Text1.Top = 20;
            Text1.Left = 110;
            Controls.Add(Text1);
            Text2 = new Label();
            Text2.Text = "Azn odenilecek mebleg.";
            Text2.Width = 150;
            Text2.Top = 51;
            Text2.Left = 110;
            Controls.Add(Text2);
            Text3 = new Label();
            Text3.Text = "seans";
            Text3.Width = 150;
            Text3.Top = 82;
            Text3.Left = 110;
            
            
            Controls.Add(Text3);
            newResault = new Button();
            newResault.Width = 150;
            newResault.Height = 30;
            newResault.Top = 120;
            newResault.Left = 5;
            newResault.Text = "new Rezervation";
            newResault.Click += new EventHandler(newResaultData);
            Controls.Add(newResault);




            this.Width = 300;
            this.Height = 200;
        }
        public void newResaultData(object obj,EventArgs e)
        {
            Seats.SeatResault.Text = " ";
            //()
            this.Close();
            
            //for (int i = 0; i < Seats.SeatNum.Count; i++)
            //{
            //    for (int j = 0; j < 42; j++)
            //    {
            //        if (Convert.ToInt32(Seats.seat.Name) == Seats.SeatNum[i])
            //        {

            //        }
            //    }
            //}

           


        }

    }
}
