﻿using CarLogin.DataBase;
using CarLogin.FileManag;
using CarLogin.SearchModel;
using CarLogin.Session;
using CarLogin.UsersCars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarLogin
{
    public partial class AllSearchCars : Form
    {
        DbContext dbContext = new DbContext("CarDb");
        SearchCar searchCar = new SearchCar();
        List<SearchCar> searches;
        double TotalPage;
        public AllSearchCars()
        {
            InitializeComponent();
            searches = new List<SearchCar>();
        }


        int? page;
        private string email;

        private void AllSearchCars_Load(object sender, EventArgs e)
        {

            var cars = SessionDb.table;
           

                foreach (SearchCar user in cars)
                {
                    searches.Add(user);
                }
                if (page == null)
                {
                    page = 1;
                }

                int skip = ((int)page - 1) * 3;
                var users1 = searches.Skip(skip).Take(3).ToList();
                TotalPage = Math.Ceiling(searches.Count / 3.0);

                double totaPage = TotalPage;
                int x = 1;
                int y = 5;
                for (int i = 1; i <= totaPage; i++)
                {
                    Button button = new Button();
                    button.Name = "Total";
                    button.Size = new Size(30, 30);
                    button.Text = i.ToString();
                    button.Click += DataElm;
                    Controls.Add(button);
                    if (x % totaPage * 0 != 0)
                    {
                        y = y + 10;
                        x = 0;
                    }
                    button.Location = new Point(x * 30 + 30, 400);
                    x++;
                }
                int a = 0;
                int b = 45;
                foreach (SearchCar car in users1)
                {
                    string fullpath = ConfigurationManager.AppSettings["Path"].ToString();
                    string FullPath = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\", fullpath, car.Photo));
                    FileManager manager = new FileManager();
                    byte[] array = manager.ReadFromFile(FullPath);
                    CreatedToolBox(array, car.Model, car.Marka, car.Year, car.Prize,car.Currency, ref a, b);
                }
            
           
        }

        private void Index(int page)
        {
            searches.Clear();
            var cars = SessionDb.table;
         foreach(SearchCar car in cars)
            {
                searches.Add(car);
            }

           int skip = ((int)page - 1) * 3;
           var car1 = searches.Skip(skip).Take(3);
           TotalPage = Math.Ceiling(searches.Count / 3.0);
            int a = 0;
            int b = 45;
           foreach(SearchCar search in car1)
            {
                string appconfiq = ConfigurationManager.AppSettings["Path"];
                string FullPath = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\", appconfiq, search.Photo));
                FileManager file = new FileManager();
                byte[] array =  file.ReadFromFile(FullPath);
                CreatedToolBox(array, search.Model, search.Marka, search.Year, search.Prize,search.Currency, ref a, b);
            }
        }

        public void Controlss()
        {
            List<Control> cnt = new List<Control>();
            foreach (Control cont in this.Controls)
            {
                cnt.Add(cont);
            }
            foreach (Control control in cnt)
            {
                PictureBox box = control as PictureBox;

                if (box != null)
                {
                    this.Controls.Remove(box);
                }
                Label label = control as Label;
                if (label != null)
                {
                    this.Controls.Remove(label);
                }
                Panel panel = control as Panel;
                if (panel != null)
                {
                    this.Controls.Remove(panel);
                }
            }
        }


        private void DataElm(object sender, EventArgs e)
        {
            Controlss();
            string number = (sender as Button).Text;
            int pageNumber = Convert.ToInt32(number);
            Index(pageNumber);
        }


        public void CreatedToolBox(byte[] array, string text1, string text2, string text3, string text4,string text5, ref int a, int b)
        {
            PictureBox pict = new PictureBox();
            pict.Name = "img";
            pict.Size = new Size(280, 200);
            pict.SizeMode = PictureBoxSizeMode.StretchImage;
            pict.Image = Image.FromStream(new MemoryStream(array));
            Controls.Add(pict);
            if (a % page * 0 != 0)
            {
                b = b + 5;
                a = 0;
            }
            pict.Location = new Point(a * 300 + 40, b);



            Panel panel = new Panel();
            panel.Size = new Size(280, 300);
            panel.Location = new Point(a * 300 + 40, b);


            Label label = new Label();
            label.Text = "Model: " + text1;
            label.Size = new Size(100, 22);
            label.ForeColor = Color.Blue;
            label.Top = 250;
            label.Left = a * 300 + 140;

            Label label1 = new Label();
            label1.Text = "Marka: " + text2;
            label1.Size = new Size(100, 22);
            label1.ForeColor = Color.Blue;
            label1.Top = 280;
            label1.Left = a * 300 + 140;

            Label label2 = new Label();
            label2.Text = "Year: " + text3;
            label2.Size = new Size(80, 22);
            label2.ForeColor = Color.Blue;
            label2.Top = 310;
            label2.Left = a * 300 + 50;

            Label label3 = new Label();
            label3.Text = $"Prize:{text4} {text5}";
            label3.Size = new Size(90, 22);
            label3.ForeColor = Color.Blue;
            label3.Top = 309;
            label3.Left = a * 290 + 225;

            a++;
            Controls.Add(pict);
            Controls.Add(label);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(panel);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CarSearch carSearch = new CarSearch(email);
            this.Hide();
            carSearch.ShowDialog();
        }
    }

}
