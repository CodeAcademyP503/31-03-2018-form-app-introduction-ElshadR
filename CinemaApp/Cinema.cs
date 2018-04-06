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
    public partial class Cinema : Form
    {

        public static List<int> u=new List<int>() {1,2,3,4,5 };
        public static int l;
        public Seats seatss = new Seats();
        public  Seats seatsss = new Seats();
        public  Seats seatssss = new Seats();
        public  Seats seatsssss = new Seats();
        public  Seats seatssssss = new Seats();
        public static List<string> films = new List<string>() { "Inception", "FastFive", "Shaolin Soccer", "Iron Man 3", "BRUC" };
        public Cinema()
        {

            InitializeComponent();

            foreach (var film in films)
            {
                Cinemalist.Items.Add(film);
            } 
        }
        
        public void Cinema1Data(object obj, EventArgs e)
        {
            l = 20;
            

            seatss.ShowDialog();
            

        }
        public void Cinema2Data(object obj, EventArgs e)
        {
           
            l = 15;
                

                seatsss.ShowDialog();

        
            

        }
        public void Cinema3Data(object obj, EventArgs e)
        {
            
            l = 10;
            
            seatssss.ShowDialog();
            

        }
        public void Cinema4Data(object obj, EventArgs e)
        {
           
            l = 7;
            
            seatsssss.ShowDialog();
            

        }
        public void Cinema5Data(object obj, EventArgs e)
        {
           
            l = 5;
            
            seatssssss.ShowDialog();
            

        }
       



        public void SeatsData(object obj,EventArgs e)
        {
            
            
            
            
        }

        private void Info_cinema_Click(object sender, EventArgs e)
        {
            InfoCinema infos = new InfoCinema();
            infos.ShowDialog();
        }
    }
}
