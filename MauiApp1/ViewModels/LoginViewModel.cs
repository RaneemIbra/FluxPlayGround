using System.ComponentModel;
using MauiApp1.Models;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace MauiApp1.ViewModels;

public class LoginViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;
    private UserModel _user;
    private string _loginResult;

    public UserModel User
    {
        get { return _user; }
        set { 
            _user = value;
            OnPropertyChanged();
        }
    }
    public ICommand LoginCommand { get; set; }
    
    public LoginViewModel()
    {
        User = new UserModel();
        LoginCommand = new Command(OnLogin);
    }

    private void OnLogin()
    {
        if (string.IsNullOrEmpty(User.userName) || string.IsNullOrEmpty(User.email))
        {
            LoginResult = "Please enter a valid username and email.";
        }
        else
        {
            LoginResult = $"Welcome, {User.userName} ({User.email})";
        }
    }
    
    public string LoginResult
    {
        get { return _loginResult; }
        set
        {
            _loginResult = value;
            OnPropertyChanged();
        }
    }

    protected void OnPropertyChanged([CallerMemberName] string name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}