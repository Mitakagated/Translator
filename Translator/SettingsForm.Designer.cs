namespace Translator;

partial class SettingsForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        var resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        keyboardTranslationDelay = new NumericUpDown();
        ((System.ComponentModel.ISupportInitialize)keyboardTranslationDelay).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        resources.ApplyResources(label1, "label1");
        label1.Name = "label1";
        // 
        // label2
        // 
        resources.ApplyResources(label2, "label2");
        label2.Name = "label2";
        // 
        // label3
        // 
        resources.ApplyResources(label3, "label3");
        label3.Name = "label3";
        // 
        // keyboardTranslationDelay
        // 
        resources.ApplyResources(keyboardTranslationDelay, "keyboardTranslationDelay");
        keyboardTranslationDelay.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
        keyboardTranslationDelay.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
        keyboardTranslationDelay.Name = "keyboardTranslationDelay";
        keyboardTranslationDelay.Value = new decimal(new int[] { 2, 0, 0, 0 });
        // 
        // SettingsForm
        // 
        resources.ApplyResources(this, "$this");
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(keyboardTranslationDelay);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Name = "SettingsForm";
        ((System.ComponentModel.ISupportInitialize)keyboardTranslationDelay).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private Label label3;
    private NumericUpDown keyboardTranslationDelay;
}