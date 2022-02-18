using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace RPG_game
{
    public partial class Main_window : Form
    {
        Rpg_core Core = new Rpg_core();

        public Main_window()
        {
            InitializeComponent();
            atk_Button.Visible = false;
            atk_panel.Visible = false;
            def_panel.Visible = false;
            continue_btn.Visible = true;
        }

        private void Main_window_Load(object sender, EventArgs e)
        {
            Core.Start_new_game();
        }

        private void atk_Button_Click(object sender, EventArgs e)
        {
            //Core.BC.Turn(;
        }

        private void Main_window_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void continue_btn_Click(object sender, EventArgs e)
        {
            Core.Start_battle();
        }
    }
}
