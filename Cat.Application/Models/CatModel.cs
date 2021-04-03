using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Cat.Application.Services;

namespace Cat.Application.Models
{
    public class CatModel : INotifyPropertyChanged, IDataErrorInfo
    {
        private CatValidator _catValidator { get; set; }
        public string this[string columnName] 
        {
            get 
            {
                var res = _catValidator.Validate(this).Errors.FirstOrDefault(x => x.PropertyName == columnName);
                if (res != null && string.IsNullOrEmpty(res.ErrorMessage)) 
                {
                    return res.ErrorMessage;
                }
                return "";
            }
        }

        public CatModel()
        {
            _catValidator = new CatValidator();
        }

        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value;
                OnPropertyChanged("Id");
            }
        }


        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value;
                OnPropertyChanged("Name");
            }
        }

        private DateTime _birthday;

        public DateTime Birthday
        {
            get { return _birthday; }
            set { _birthday = value;
                OnPropertyChanged("Birthday");
            }
        }

        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value;
                OnPropertyChanged("Age");
            }
        }

        private decimal _price;

        public decimal Price
        {
            get { return _price; }
            set { _price = value;
                OnPropertyChanged("Price");
            }
        }

        private string _imgPath;

        public string ImgPath
        {
            get { return _imgPath; }
            set { _imgPath = value;
                OnPropertyChanged("ImgPath");
            }
        }



        public string Error => throw new NotImplementedException();

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string prop) 
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
