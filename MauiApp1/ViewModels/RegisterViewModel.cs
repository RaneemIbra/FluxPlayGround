using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using MauiApp1.Models;

namespace MauiApp1.ViewModels
{
    public class RegisterViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private UserModel _user;
        private string _registrationResult;
        private string _securityQuestion = "Select a question...";

        public RegisterViewModel()
        {
            User = new UserModel();
            ConfirmCommand = new Command(OnConfirm);
        }

        public UserModel User
        {
            get { return _user; }
            set
            {
                _user = value;
                OnPropertyChanged();
            }
        }

        public ICommand ConfirmCommand { get; set; }

        public string RegistrationResult
        {
            get { return _registrationResult; }
            set
            {
                _registrationResult = value;
                OnPropertyChanged();
            }
        }

        public string SecurityQuestion
        {
            get => _securityQuestion;
            set
            {
                if (_securityQuestion != value)
                {
                    _securityQuestion = value;
                    OnPropertyChanged();
                }
            }
        }

        public DateTime DateOfBirth
        {
            get { return User.DateOfBirth; }
            set
            {
                User.DateOfBirth = value;
                OnPropertyChanged();
            }
        }

        private void OnConfirm()
        {
            if (string.IsNullOrEmpty(User.FirstName) || string.IsNullOrEmpty(User.LastName) ||
                string.IsNullOrEmpty(User.Email) || string.IsNullOrEmpty(User.Password) ||
                string.IsNullOrEmpty(User.SecurityAnswer) || SecurityQuestion == "Select a question...")
            {
                RegistrationResult = "Please fill in all fields.";
            }
            else
            {
                RegistrationResult = $"Welcome, {User.FirstName}! Registration successful.";
            }
        }

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
