using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoShop
{
    public partial class MainMenu : Form
    {
        private List<RadioButton> options = new List<RadioButton>();
        private List<Panel> panels = new List<Panel>();
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(220, 93, 1);
            topPanel.BackColor = Color.FromArgb(134, 36, 0);
            menuPanel.BackColor = Color.FromArgb(255, 192, 57);

            getPanels();
            hidePanels();
            beginingPanel.Visible = true;

            FillRadioButtons();
            
        }

        private void minButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
       
        //putting all radio buttons in a list
        private void FillRadioButtons()
        {
            options.Add(showBegginingRadio);
            options.Add(showCatRadio);
            options.Add(showLibRadio);
            options.Add(showSeriesRadio);
            options.Add(showOptionRadio);
            

            foreach(RadioButton i in options)
            {
                i.Appearance = Appearance.Button;
            }
        }

        private void showBegginingRadio_CheckedChanged(object sender, EventArgs e)
        {
            Panel activePanel = returnActivePanel();
            activePanel.Visible = false;
            beginingPanel.Visible = true;
        }

        private void showLibRadio_CheckedChanged(object sender, EventArgs e)
        {
            Panel activePanel = returnActivePanel();
            activePanel.Visible = false;
            libraryPanel.Visible = true;
        }

        private void showCatRadio_CheckedChanged(object sender, EventArgs e)
        {
            Panel activePanel = returnActivePanel();
            activePanel.Visible = false;
            catPanel.Visible = true;
        }

        //putting all panels in a list to be easier to rotate them
        private void getPanels()
        {
            panels.Add(beginingPanel);
            panels.Add(libraryPanel);
            panels.Add(catPanel);
        }
        private void hidePanels()
        {
            foreach(Panel i in panels)
            {
                i.Visible = false;
            }
        }
        private Panel returnActivePanel()
        {
            foreach(Panel i in panels)
            {
                if (i.Visible)
                {
                    return i;
                }
            }
            return null;
        }

    }
}
