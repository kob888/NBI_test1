using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test_1_NBI.Data;
using Test_1_NBI.Models;

namespace Test_1_NBI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            stateLable.Text = "Выберите файл для добавления в БД";
        }

        private void openFileBtn_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Json files (*.json)|*.json|Text files (*.txt)|*.txt";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePathTxtBox.Text = openFileDialog.FileName;
                }                
            }
            stateLable.Text = "";
        }

        private void parseBtn_Click(object sender, EventArgs e)
        {
            List<InputDataModel> inputList;
            using (StreamReader reader = new StreamReader(filePathTxtBox.Text))
            {
                string json = reader.ReadToEnd();
                inputList = JsonConvert.DeserializeObject<List<InputDataModel>>(json);
            }

            List<OutputDataModel> validList = Validation(inputList);

            if(validList.Count != 0)
            {
                AddToDB(validList);

                stateLable.Text = "База данных обновлена";
                stateLable.ForeColor = Color.Green;
            }
            else
            {
                stateLable.Text = "Файл не содержит данных, или данные не соответствуют формату...";
                stateLable.ForeColor = Color.Red;
            }
            
        }


        private List<OutputDataModel> Validation(List<InputDataModel> inputList)
        {
            List<OutputDataModel> outputList = new List<OutputDataModel>();
            DateTime _date;
            double _value;

            foreach (var item in inputList)
            {
                if (String.IsNullOrEmpty(item.Date) || String.IsNullOrWhiteSpace(item.Date))
                    continue;

                bool successDateTime = DateTime.TryParse(item.Date, out _date);
                if (!successDateTime)
                    continue;

                if (String.IsNullOrEmpty(item.Value) || String.IsNullOrWhiteSpace(item.Value))
                    continue;

                bool successValue = double.TryParse(item.Value, NumberStyles.Any, CultureInfo.GetCultureInfo("en-US"), out _value);
                if (!successValue)
                    continue;

                if (String.IsNullOrEmpty(item.City) || String.IsNullOrWhiteSpace(item.City))
                    continue;

                OutputDataModel model = new OutputDataModel()
                {
                    Date = _date,
                    Value = _value,
                    City = item.City
                };
                outputList.Add(model);

            }

            return outputList;
        }


        private void AddToDB(List<OutputDataModel> validList)
        {
            using (var db = new ApplicationDbContext())
            {
                foreach (var item in validList)
                {

                    string[] citiesArray = item.City.Split(',');

                    foreach (var city in citiesArray)
                    {
                        if (!db.Cities.Any(p => p.Name == city.TrimStart()))
                        {
                            var cityModel = new City()
                            {
                                Name = city.TrimStart()
                            };
                            db.Cities.Add(cityModel);
                            db.SaveChanges();
                        }

                        var result = db.Cities.Where(p => p.Name == city.TrimStart()).FirstOrDefault();
                        var factModel = new Fact()
                        {
                            CityId = result.Id,
                            Date = item.Date,
                            Value = item.Value
                        };

                        db.Facts.Add(factModel);
                        db.SaveChanges();
                    }
                }
            }            
        }
    }
}
