namespace MauiListView202401;

public partial class MainPage : ContentPage
{
    public IReadOnlyList<string> availableItems;

    public IReadOnlyList<string> AvailableItems
    {
        get => this.availableItems;
        set
        {
            availableItems = value;
            OnPropertyChanged();
        }
    }


    public MainPage()
	{
        var list = new List<string>(capacity: 10_000);

        for (int i = 0; i < 10_000; i++)
        {
            list.Add($"#{i}");
        }

        AvailableItems = list;

        InitializeComponent();
		BindingContext = this;
	}
}