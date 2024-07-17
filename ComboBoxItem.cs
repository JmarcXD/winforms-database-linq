namespace WindowsFormsDBLinq
{
    public class ComboBoxItem
    {
        private int? value;
        private string text;

        public ComboBoxItem(int? value, string text)
        {
            this.value = value;
            this.text = text;
        }

        public int? Value { get => value; set => this.value = value; }
        public string Text { get => text; set => text = value; }
    }
}
