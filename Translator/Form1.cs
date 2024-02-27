using System.Diagnostics;
using System.Net.Http.Json;

namespace Translator;

public partial class TranslatorForm : Form
{
    readonly HttpClient client = new HttpClient()
    {
        BaseAddress = new Uri("http://127.0.0.1:5000")
    };

    List<Language>? supportedLanguages;
    List<DetectedLanguage> detectedLanguages;
    TranslatedLanguage translatedLanguage;
    bool isTranslating = true;

    public TranslatorForm()
    {
        InitializeComponent();
    }
    private async Task<List<Language>>? GetSupportedLanguages()
    {
        return await client.GetFromJsonAsync<List<Language>>("languages");
    }

    private async Task PopulateLanguageDropdownsAsync()
    {
        var langNames = new List<string>();
        foreach (var lang in supportedLanguages)
        {
            langNames.Add(lang.LangName);
        }
        ToLanguageDropdown.DataSource = langNames;
        ToLanguageDropdown.DropDownHeight = ToLanguageDropdown.ItemHeight * 8 + 2;
        langNames.Insert(0, "Auto Detect");
        FromLanguageDropdown.DataSource = langNames;
        FromLanguageDropdown.DropDownHeight = FromLanguageDropdown.ItemHeight * 8 + 2;
    }
    private async void FromLanguageDropdown_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            while (isTranslating)
            {
                if ((string)FromLanguageDropdown.SelectedItem == "Auto Detect")
                {
                    if (KeyboardTranslationBox.Text != string.Empty)
                    {
                        detectedLanguages = await client.PostAsJsonAsync("detect", new { q = KeyboardTranslationBox.Text })
                                        .Result.Content.ReadFromJsonAsync<List<DetectedLanguage>>();
                        detectedLanguages.Sort((x, y) => x.Confidence.CompareTo(y.Confidence));
                        var detectedLanguage = detectedLanguages[0];
                        var lang = FindLanguageDetails(ToLanguageDropdown.Text);
                        translatedLanguage = await client.PostAsJsonAsync("translate",
                            new
                            {
                                q = KeyboardTranslationBox.Text,
                                source = detectedLanguage.LangCode,
                                target = lang.LangCode
                            })
                                .Result.Content.ReadFromJsonAsync<TranslatedLanguage>();
                        TranslatedTextBox.Text = translatedLanguage.TranslatedText; 
                    }
                    await Task.Delay(2000);
                }
                else
                {
                    var lang = FindLanguageDetails(FromLanguageDropdown.Text);
                    var lang2 = FindLanguageDetails(ToLanguageDropdown.Text);
                    translatedLanguage = await client.PostAsJsonAsync("translate",
                        new
                        {
                            q = KeyboardTranslationBox.Text,
                            source = lang.LangCode,
                            target = lang2.LangCode
                        })
                            .Result.Content.ReadFromJsonAsync<TranslatedLanguage>();
                    TranslatedTextBox.Text = translatedLanguage.TranslatedText;
                    await Task.Delay(2000);
                }
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
        }
    }

    private Language FindLanguageDetails(string LangName)
    {
        var language = supportedLanguages.Find(x => x.LangName == LangName);
        return language;
    }

    private async void TranslatorForm_Load(object sender, EventArgs e)
    {
        supportedLanguages = await GetSupportedLanguages();
        await PopulateLanguageDropdownsAsync();
    }

}
