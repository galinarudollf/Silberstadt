namespace Silberstadt;
public partial class FamousPage : ContentPage
{
    //private List<Person> persons;
    public FamousPage()
    {
        InitializeComponent();
        BindingContext = new PersonViewModel(DataListView, NameEntry, YearEntry);
    /*    persons = [
        new Person(){ Name="Gottfried Silbermann", Data="14.1.1683 Kleinbobritzsch – 4.8.1753 Dresden"},
        new Person(){ Name="Abraham Gottlob Werner", Data=" 25.9.1749 Wehrau am Queis – 30.6.1817 Dresden"},
        new Person(){ Name="Alexander von Humboldt", Data="1769 Berlin – 1859 Berlin"},
        new Person(){ Name="Clemens Winkler", Data="26.12.1838 Freiberg – 8.10.1904 Dresden"}];
        UpdateViewList();*/
    }
    /*private void OnAddClicked(object sender, EventArgs e)//async 
    {
            string name = NameEntry.Text;
            string data = YearEntry.Text;
            {
                persons.Add(new Person { Name = name, Data = data });
                UpdateViewList();

            }
            NameEntry.Text = string.Empty;
            YearEntry.Text = string.Empty;
    }

    private void UpdateViewList(){
        // Update the ListView using LINQ
        var displayData = from person in persons
             select new { Display = $"{person.Name}, {person.Data}" };

        DataListView.ItemsSource = displayData.ToList();
    }


    public class Person
    {
        public string Name { get; set; }
        public string Data { get; set; }
    }*/
}