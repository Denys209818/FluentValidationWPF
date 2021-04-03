using Cat.Application.Models;
using EFDataContext;
using EFDataEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFGridServices
{
    /// <summary>
    /// Interaction logic for AddCatWindow.xaml
    /// </summary>
    public partial class AddCatWindow : Window
    {
        
        public CatModel Cat { get; set; }
        private DataContext _context { get; set; }
        public bool _gender { get; set; }
        public AddCatWindow(DataContext context)
        {
            InitializeComponent();
            _context = context;
            Cat = new CatModel();
            this.DataContext = Cat;

        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            Cat.IsEnabledValidation = true;
            if (string.IsNullOrEmpty(Cat.Error))
            {
                int res;
                if (!int.TryParse(this.txtAge.Text, out res) || !int.TryParse(this.txtPrice.Text, out res)) 
                {
                    MessageBox.Show("Некоректно введені дані!");
                    return;
                }
                var cat = new EFDataEntities.Cat
                {
                    Name = this.txtName.Text,
                    Details = this.txtDetails.Text,
                    Gender = _gender,
                    Birthday = new DateTime(DateTime.Now.Year - int.Parse(this.txtAge.Text), DateTime.Now.Month,
                    DateTime.Now.Day),
                    imgPath = this.txtImage.Text,

                };
                
                _context.Cats.Add(cat);
                cat.CatPrices = new List<CatPrice> {
                        new CatPrice
                        {
                            DateCreate = DateTime.Now,
                            Price = decimal.Parse(this.txtPrice.Text),
                            CatId = cat.Id
                        } };
                _context.SaveChanges();
                
                this.Close();
            }
            else 
            {
                MessageBox.Show(Cat.Error, "Помилка валідації");
                this.Refresh();
            }
            
        }

        private void Refresh() 
        {
            this.txtName.Text = this.txtName.Text.Trim();
            this.txtPrice.Text = this.txtPrice.Text.Trim();
            this.txtImage.Text = this.txtImage.Text.Trim();
            this.txtDetails.Text = this.txtDetails.Text.Trim();
            this.txtAge.Text = this.txtAge.Text.Trim();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Cat.IsEnabledValidation = true;
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            _gender = Convert.ToBoolean((sender as RadioButton).Tag);
        }
    }
}
