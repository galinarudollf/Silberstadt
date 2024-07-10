using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Silberstadt;

public class PersonViewModel : INotifyPropertyChanged{
    private List<Person> daten;

    public event PropertyChangedEventHandler? PropertyChanged;

    public List<Person> Daten{
        get=>daten;
        set{
            SetProperty<List<Person>>(ref daten, value);
        }
    }
    private ListView listView;
    private Entry entryName;
    private Entry entryYears;
    
    public PersonViewModel(ListView _listview, Entry _entryname, Entry _entryyears)
    {
        listView = _listview;
        entryName = _entryname;
        entryYears = _entryyears;
        Daten=[
            new Person(){ Name="Gottfried Silbermann", Data="14.1.1683 Kleinbobritzsch – 4.8.1753 Dresden"},
            new Person(){ Name="Abraham Gottlob Werner", Data=" 25.9.1749 Wehrau am Queis – 30.6.1817 Dresden"},
            new Person(){ Name="Alexander von Humboldt", Data="1769 Berlin – 1859 Berlin"},
            new Person(){ Name="Clemens Winkler", Data="26.12.1838 Freiberg – 8.10.1904 Dresden"}];
        UpdateViewList();
        MyCommand=new Command(
            execute: () =>
            {
                string name = entryName.Text;
                string data = entryYears.Text;
                Daten.Add(new Person { Name = name, Data = data });
                UpdateViewList();
                entryName.Text = string.Empty;
                entryYears.Text = string.Empty;
            });
    }

    public ICommand MyCommand { private set; get; }

    private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
    {
        if (Object.Equals(storage, value)) return false;
        storage = value;
        NotifyPropertyChanged(propertyName);
        return true;
    }
    private void UpdateViewList(){
        // Update the ListView using LINQ
        var displayData = from person in Daten
             select new { Display = $"{person.Name}, {person.Data}" };
        listView.ItemsSource = displayData.ToList();
    }

}

    
