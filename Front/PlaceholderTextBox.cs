using System;
using System.Drawing;
using System.Windows.Forms;

public class PlaceholderTextBox : TextBox
{
    private string placeholderText;

    public string PlaceholderText
    {
        get => placeholderText;
        set
        {
            placeholderText = value;
            UpdatePlaceholder();
        }
    }

    public PlaceholderTextBox()
    {
        this.GotFocus += RemovePlaceholder;
        this.LostFocus += ShowPlaceholder;
        this.ForeColor = Color.Gray; // Color por defecto del texto del placeholder
    }

    private void ShowPlaceholder(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(this.Text))
        {
            this.Text = placeholderText;
            this.ForeColor = Color.Gray;
        }
    }

    private void RemovePlaceholder(object sender, EventArgs e)
    {
        if (this.Text == placeholderText)
        {
            this.Text = "";
            this.ForeColor = Color.Black; // Cambia el color al escribir
        }
    }

    protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
    {
        base.OnPaint(e);
        if (string.IsNullOrEmpty(this.Text) && !string.IsNullOrEmpty(placeholderText))
        {
            TextRenderer.DrawText(e.Graphics, placeholderText, this.Font, this.ClientRectangle, Color.Gray);
        }
    }

    private void UpdatePlaceholder()
    {
        if (this.Focused)
        {
            this.ForeColor = Color.Black;
        }
        else
        {
            ShowPlaceholder(this, EventArgs.Empty);
        }
    }
}