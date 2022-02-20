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
        Body_part Atk_part = Body_part.body;
        Body_part Def_part = Body_part.body;
        bool New_battle = true;
        List<Enemy> Enemy_ds = new List<Enemy>();

        enum ErrorType : int
        {
            no_target = 0
        }

        public Main_window()
        {
            InitializeComponent();
        }

        private void Main_window_Load(object sender, EventArgs e)
        {
            atk_body_RadioButton.Checked = true;
            def_body_RadioButton.Checked = true;

            turn_panel.Visible = false;
            atk_panel.Visible = false;
            def_panel.Visible = false;
            
            continue_btn.Visible = true;
        }

        private void atk_Button_Click(object sender, EventArgs e)
        {
            Enemy Target;
            try
            {
                Target = Enemy_ds[enemies_list.SelectedIndex];
            }
            catch
            {
                Log_error(ErrorType.no_target);
                return;
            }

            Core.BC.Turn(Def_part, Atk_part, Target);
            Update_log();
        }

        private void Main_window_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Configure_enemy_data_source()
        {
            Enemy_ds.Clear();
            enemies_list.Items.Clear();

            for (int i = 0; i < Core.BC.Enemy_squad.Count; i++)
            {
                Enemy_ds.Add(Core.BC.Enemy_squad[i]);
                enemies_list.Items.Insert(i, Core.BC.Enemy_squad[i].Name);
            }
        }

        private void Log_error(ErrorType err)
        {
            String error_definition;

            switch (err)
            {
                case ErrorType.no_target:
                    error_definition = "Не выбрана цель для атаки\n";
                    Log_window.Text += error_definition;
                    break;
                default:
                    error_definition = "Возникла неизвестная ошибка\n";
                    Log_window.Text += error_definition;
                    return;
            }
        }

        private void Update_log()
        {
            List<String> Logs = Core.BC.Logger();
            foreach (String s in Logs)
                Log_window.Text += s + "\n";

            if (Core.BC.Status == Battle_status.player_win)
            {
                atk_body_RadioButton.Checked = true;
                def_body_RadioButton.Checked = true;

                turn_panel.Visible = false;
                atk_panel.Visible = false;
                def_panel.Visible = false;
                continue_btn.Visible = true;
            }

            if (Core.BC.Status == Battle_status.enemies_win)
            {
                New_battle = true;
                atk_body_RadioButton.Checked = true;
                def_body_RadioButton.Checked = true;

                turn_panel.Visible = false;
                atk_panel.Visible = false;
                def_panel.Visible = false;
                continue_btn.Visible = true;
            }
        }

        private void continue_btn_Click(object sender, EventArgs e)
        {
            Log_window.Clear();
            turn_panel.Visible = true;
            atk_panel.Visible = true;
            def_panel.Visible = true;
            continue_btn.Visible = false;

            if (New_battle)
            {
                New_battle = false;
                Core.Start_new_game();
            }
            else
                Core.Start_battle();

            Configure_enemy_data_source();
            Update_log();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            switch (rb.Name)
            {
                case "atk_head_RadioButton":
                    Atk_part = Body_part.head;
                    break;
                case "atk_body_RadioButton":
                    Atk_part = Body_part.body;
                    break;
                case "atk_legs_RadioButton":
                    Atk_part = Body_part.legs;
                    break;
                case "def_head_RadioButton":
                    Def_part = Body_part.head;
                    break;
                case "def_body_RadioButton":
                    Def_part = Body_part.body;
                    break;
                case "def_legs_RadioButton":
                    Def_part = Body_part.legs;
                    break;
                default: return;
            }
        }

        private void Log_window_TextChanged(object sender, EventArgs e)
        {
            Log_window.SelectionStart = Log_window.Text.Length;
            Log_window.ScrollToCaret();
        }
    }
}
