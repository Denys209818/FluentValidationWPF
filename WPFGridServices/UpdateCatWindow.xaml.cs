using Cat.Application.Models;
using EFDataContext;
using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Interaction logic for UpdateCatWindow.xaml
    /// </summary>
    public partial class UpdateCatWindow : Window
    {
        public CatModel _cat { get; set; }
        private DataContext _context { get; set; }
        public UpdateCatWindow(DataContext context, CatModel cat)
        {
            InitializeComponent();
            _context = context;
            cat.IsEnabledValidation = true;
            this.DataContext = cat;
            _cat = cat;
            
        }
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            int res;
            int r;
            if (!int.TryParse(this.txtAge.Text, out res) || !int.TryParse(this.txtPrice.Text, out r))
            {
                MessageBox.Show("Некоректно введені дані!");
                return;
            }
            if (string.IsNullOrEmpty(_cat.Error))
            {
                var cat = this._context.Cats.FirstOrDefault(x => x.Id == _cat.Id);
                cat.Name = this.txtName.Text;
                cat.Details = this.txtDetails.Text;
                cat.imgPath = this.txtImgPath.Text;
                cat.Birthday = new DateTime(DateTime.Now.Year - int.Parse(this.txtAge.Text), cat.Birthday.Month,
                    cat.Birthday.Day);
                _context.SaveChanges();
                this._context.CatPrices.Add(new EFDataEntities.CatPrice
                {
                    CatId = cat.Id,
                    DateCreate = DateTime.Now,
                    Price = decimal.Parse(this.txtPrice.Text),
                });
                this._context.SaveChanges();
                this.Close();
            }
            else
            {
                MessageBox.Show(_cat.Error);
            }
        }
    }
}
