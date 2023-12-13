namespace Translator;

partial class TranslatorForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        var resources = new System.ComponentModel.ComponentResourceManager(typeof(TranslatorForm));
        TranslatedTextBox = new TextBox();
        KeyboardTranslationBox = new TextBox();
        StartTranslatingButton = new Button();
        StopTranslatingButton = new Button();
        KeyboardTranslationButton = new Button();
        SettingsButton = new Button();
        TranslateFromLabel = new Label();
        FromLanguageDropdown = new ComboBox();
        ToLanguageDropdown = new ComboBox();
        TranslateToLabel = new Label();
        SuspendLayout();
        // 
        // TranslatedTextBox
        // 
        resources.ApplyResources(TranslatedTextBox, "TranslatedTextBox");
        TranslatedTextBox.Name = "TranslatedTextBox";
        // 
        // KeyboardTranslationBox
        // 
        resources.ApplyResources(KeyboardTranslationBox, "KeyboardTranslationBox");
        KeyboardTranslationBox.Name = "KeyboardTranslationBox";
        // 
        // StartTranslatingButton
        // 
        resources.ApplyResources(StartTranslatingButton, "StartTranslatingButton");
        StartTranslatingButton.Name = "StartTranslatingButton";
        StartTranslatingButton.UseVisualStyleBackColor = true;
        // 
        // StopTranslatingButton
        // 
        resources.ApplyResources(StopTranslatingButton, "StopTranslatingButton");
        StopTranslatingButton.Name = "StopTranslatingButton";
        StopTranslatingButton.UseVisualStyleBackColor = true;
        // 
        // KeyboardTranslationButton
        // 
        resources.ApplyResources(KeyboardTranslationButton, "KeyboardTranslationButton");
        KeyboardTranslationButton.Name = "KeyboardTranslationButton";
        KeyboardTranslationButton.UseVisualStyleBackColor = true;
        // 
        // SettingsButton
        // 
        resources.ApplyResources(SettingsButton, "SettingsButton");
        SettingsButton.Name = "SettingsButton";
        SettingsButton.UseVisualStyleBackColor = true;
        // 
        // TranslateFromLabel
        // 
        resources.ApplyResources(TranslateFromLabel, "TranslateFromLabel");
        TranslateFromLabel.Name = "TranslateFromLabel";
        // 
        // FromLanguageDropdown
        // 
        FromLanguageDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
        resources.ApplyResources(FromLanguageDropdown, "FromLanguageDropdown");
        FromLanguageDropdown.FormattingEnabled = true;
        FromLanguageDropdown.Name = "FromLanguageDropdown";
        FromLanguageDropdown.SelectedIndexChanged += FromLanguageDropdown_SelectedIndexChanged;
        // 
        // ToLanguageDropdown
        // 
        ToLanguageDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
        resources.ApplyResources(ToLanguageDropdown, "ToLanguageDropdown");
        ToLanguageDropdown.FormattingEnabled = true;
        ToLanguageDropdown.Name = "ToLanguageDropdown";
        // 
        // TranslateToLabel
        // 
        resources.ApplyResources(TranslateToLabel, "TranslateToLabel");
        TranslateToLabel.Name = "TranslateToLabel";
        // 
        // TranslatorForm
        // 
        resources.ApplyResources(this, "$this");
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(ToLanguageDropdown);
        Controls.Add(TranslateToLabel);
        Controls.Add(FromLanguageDropdown);
        Controls.Add(TranslateFromLabel);
        Controls.Add(SettingsButton);
        Controls.Add(KeyboardTranslationButton);
        Controls.Add(StopTranslatingButton);
        Controls.Add(StartTranslatingButton);
        Controls.Add(KeyboardTranslationBox);
        Controls.Add(TranslatedTextBox);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Name = "TranslatorForm";
        Load += TranslatorForm_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox TranslatedTextBox;
    private TextBox KeyboardTranslationBox;
    private Button StartTranslatingButton;
    private Button StopTranslatingButton;
    private Button KeyboardTranslationButton;
    private Button SettingsButton;
    private Label TranslateFromLabel;
    private ComboBox FromLanguageDropdown;
    private ComboBox ToLanguageDropdown;
    private Label TranslateToLabel;
}
