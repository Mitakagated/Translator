using System.Net.Http.Json;

namespace Translator;

public partial class TranslatorForm : Form
{
    readonly HttpClient client = new HttpClient()
    {
        BaseAddress = new Uri("http://127.0.0.1:5000")
    };

    public TranslatorForm()
    {
        InitializeComponent();
    }

    private async Task PopulateFromLanguageDropdownAsync()
    {
        var supportedLanguages = await client.GetFromJsonAsync<List<Language>>("languages");
        var langNames = new List<string>();
        foreach (var lang in supportedLanguages)
        {
            langNames.Add(lang.LangName);
        }
        FromLanguageDropdown.DataSource = langNames;
        FromLanguageDropdown.DropDownHeight = FromLanguageDropdown.ItemHeight * 8 + 2;
    }



    private void FromLanguageDropdown_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private async void TranslatorForm_Load(object sender, EventArgs e)
    {
        await PopulateFromLanguageDropdownAsync();
    }
}
