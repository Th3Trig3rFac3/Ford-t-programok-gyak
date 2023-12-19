namespace AXAF1W_Beadando
{
    public partial class Output : Form
    {
        private List<string> stringList;

        public Output(List<string> initialStringList)
        {
            InitializeComponent();
            stringList = initialStringList;
            listBoxOutput.Width = Width; listBoxOutput.Height = Height;
        }

        private void Output_Load(object sender, EventArgs e)
        {
            OutputStringList();
        }
        private void OutputStringList()
        {
            listBoxOutput.Items.Clear();

            // Add each string in the string list to the ListBox
            foreach (string str in stringList)
            {
                listBoxOutput.Items.Add(str);
            }
        }

        private void Output_Resize(object sender, EventArgs e)
        {
            listBoxOutput.Width = Width; listBoxOutput.Height = Height;
        }
    }
}
