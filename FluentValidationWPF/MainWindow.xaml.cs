using Cat.Application.Models;
using EFDataContext;
using EFDataContext.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFGridServices;

namespace FluentValidationWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<CatModel> _cats { get; set; }
        private DataContext _context { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            _context = new DataContext();
            Seeder.SeedAll(_context);
            this.dgCats.CanUserAddRows = false;
            FillData();
        }

        public void FillData() 
        {
            _cats = new ObservableCollection<CatModel>(_context.Cats.Select(x => new CatModel
            {
                Id = x.Id,
                Name = x.Name,
                Age = (int)((int)DateTime.Now.Year - (int)x.Birthday.Year),
                Birthday = x.Birthday,
                Price = x.CatPrices.OrderByDescending(x => x.Id).FirstOrDefault().Price,
                ImgPath = x.imgPath,
                Details = x.Details
            }).ToList());

            this.dgCats.ItemsSource = _cats;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddCatWindow dlg = new AddCatWindow(_context);
            dlg.ShowDialog();
            FillData();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            var cat = this.dgCats.SelectedItem as CatModel;
            if (cat != null)
            {
                UpdateCatWindow dlg = new UpdateCatWindow(_context, cat);
                dlg.ShowDialog();
                FillData();
            }
            else
            {
                MessageBox.Show("Оберіть елемент!");
            }
        }
    }
}
