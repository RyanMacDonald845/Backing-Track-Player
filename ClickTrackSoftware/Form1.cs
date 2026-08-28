namespace ClickTrackSoftware
{
    public partial class Form1 : Form
    {
        private MainPage _mainPage { get; set; } 
        public Form1()
        {
            InitializeComponent();
            ShowPanel(new MainPage());
        }

        public void ShowPanel (UserControl control)
        {
            MainPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(control);
        }

    }
}
