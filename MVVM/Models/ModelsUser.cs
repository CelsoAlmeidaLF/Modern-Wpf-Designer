
namespace MVVM.Models
{
    public class ModelUser : ModelBase
    {
        public int _Id;
        public string _UserName = Environment.UserName;
        public string _Password = String.Empty;
        public DateTime _CreatedDate;
        public DateTime _UpdateDate;
        public string _Email = String.Empty;
        public string _Celular = String.Empty;
        public DateTime _DtLogin;
        public bool _IsDelete;

        public int Id { 
            get { return _Id; }
            set { _Id = value; OnPropertyChanged("Id"); }
        }
        public string UserName { 
            get { return _UserName; }
            set { _UserName = value; OnPropertyChanged("UserName"); } 
        }
        public string Password {
            get { return _Password; }
            set { _Password = value; OnPropertyChanged("Password"); } 
        }
        public DateTime CreatedDate { 
            get { return _CreatedDate; }
            set { _CreatedDate = value; OnPropertyChanged("CreatedDate"); } 
        }       
        public DateTime UpdateDate {
            get { return _UpdateDate; } 
            set { _UpdateDate = value; OnPropertyChanged("UpdateDate"); }
        }
        public string Email {
            get { return _Email; }
            set { _Email = value; OnPropertyChanged("Email"); } 
        }
        public string Celular { 
            get { return _Celular; }
            set { _Celular = value; OnPropertyChanged("Celular"); }
        }
        public DateTime DtLogin {
            get { return _DtLogin; }
            set { _DtLogin = value; OnPropertyChanged("DtLogin"); } 
        }
        public bool IsDelete { 
            get { return _IsDelete; }
            set { _IsDelete = value; OnPropertyChanged("IsDelete"); } 
        }

    }
}
