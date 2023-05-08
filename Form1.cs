using System.Linq;

namespace MyExplorer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] drives = Environment.GetLogicalDrives();

            foreach (string drive in drives)
            {
                ListviewMain.Items.Add(new ListViewItem(drive)
                {
                    ImageIndex = 0
                });

               

            }
        }


    }
}