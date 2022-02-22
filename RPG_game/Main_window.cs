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
            enemy_stats_group.Visible = false;
            player_stats_group.Visible = false;
            log_window.Visible = false;

            continue_btn.Visible = true;
        }

        private string Stat_to_string(Stat stat)
        {
            switch (stat)
            {
                case Stat.hp:
                    return "Здоровье";
                case Stat.defence:
                    return "Защита";
                case Stat.strength:
                    return "Сила";
                case Stat.stamina:
                    return "Выносливость";
                case Stat.mana:
                    return "Мана";
                default:
                    return "-";
            }
        }

        private void Show_lvlup_panel()
        {
            Panel lvl_up_panel = new Panel();
            lvl_up_panel.Font = new Font("Segoe UI Semibold", 20, FontStyle.Bold);
            lvl_up_panel.ForeColor = Color.Black;
            lvl_up_panel.Name = "lvlup_panel";
            lvl_up_panel.Size = new Size(613, 517);
            lvl_up_panel.Location = new Point(303, 23);
            lvl_up_panel.BackColor = Color.FromArgb(20, 20, 20);
            lvl_up_panel.BorderStyle = BorderStyle.FixedSingle;
            int num = 0;

            Label lvl_points_lbl = new Label();
            lvl_points_lbl.Name = "lvl_points_lbl";
            lvl_points_lbl.ForeColor = Color.White;
            lvl_points_lbl.Location = new Point(28, 405);
            lvl_points_lbl.AutoSize = true;
            lvl_points_lbl.Text = $"Осталось очков характеристик: ";
            lvl_up_panel.Controls.Add(lvl_points_lbl);

            Button cncl_btn = new Button();
            cncl_btn.Name = "cncl_btn";
            cncl_btn.Font = new Font("Arial Narrow", 20, FontStyle.Bold);
            cncl_btn.BackColor = Color.Gray;
            cncl_btn.Size = new Size(237, 51);
            cncl_btn.Location = new Point(35, 445);
            cncl_btn.FlatStyle = FlatStyle.Popup;
            cncl_btn.Text = "Отменить";
            lvl_up_panel.Controls.Add(cncl_btn);

            Button accept_btn = new Button();
            accept_btn.Name = "accept_btn";
            accept_btn.Font = new Font("Arial Narrow", 20, FontStyle.Bold);
            accept_btn.BackColor = Color.Gray;
            accept_btn.Size = new Size(237, 51);
            accept_btn.Location = new Point(336, 445);
            accept_btn.FlatStyle = FlatStyle.Popup;
            accept_btn.Text = "Подтвердить";
            lvl_up_panel.Controls.Add(accept_btn);

            for (int i = 0; i < Constants.Stats_list_size; i++)
            {
                if (Stat_to_string((Stat)i) == "-")
                    continue;
                String Name = Stat_to_string((Stat)i);

                Panel stat_panel = new Panel();
                stat_panel.Size = new Size(530, 58);
                stat_panel.Location = new Point(35, 11 + 64 * num);
                num++;
                lvl_up_panel.Controls.Add(stat_panel);

                Button l_button = new Button();
                l_button.Name = Name + "_lbtn";
                l_button.Font = new Font("Arial Narrow", 20, FontStyle.Bold);
                l_button.BackColor = Color.Gray;
                l_button.Size = new Size(56, 51);
                l_button.Location = new Point(13, 3);
                l_button.FlatStyle = FlatStyle.Popup;
                l_button.Text = "<";
                stat_panel.Controls.Add(l_button);

                Button r_button = new Button();
                r_button.Name = Name + "_rbtn";
                r_button.Font = new Font("Arial Narrow", 20, FontStyle.Bold);
                r_button.BackColor = Color.Gray;
                r_button.Size = new Size(56, 51);
                r_button.Location = new Point(461, 3);
                r_button.FlatStyle = FlatStyle.Popup;
                r_button.Text = ">";
                stat_panel.Controls.Add(r_button);

                Label stat_label = new Label();
                stat_label.Name = Name + "_lbl";
                stat_label.ForeColor = Color.White;
                stat_label.Location = new Point(75, 15);
                stat_label.AutoSize = true;
                stat_label.Text = Name + $": {Core.Player_squad[0].Max_stats[i]}";
                stat_panel.Controls.Add(stat_label);
            }

            Controls.Add(lvl_up_panel);
            lvl_up_panel.BringToFront();
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
            Configure_enemy_data_source();
            Update_log();
        }

        private void Main_window_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Configure_enemy_data_source()
        {
            Enemy_ds.Clear();
            enemies_list.Items.Clear();
            int j = 0;

            for (int i = 0; i < Core.BC.Enemy_squad.Count; i++)
            {
                if (!Core.BC.Enemy_squad[i].Is_dead)
                {
                    Enemy_ds.Add(Core.BC.Enemy_squad[i]);
                    enemies_list.Items.Insert(j, Core.BC.Enemy_squad[i].Name);
                    j++;
                }
            }

            if (enemies_list.Items.Count != 0)
                enemies_list.SetSelected(0, true);
        }

        private void Log_error(ErrorType err)
        {
            String error_definition;

            switch (err)
            {
                case ErrorType.no_target:
                    error_definition = "Не выбрана цель для атаки\n";
                    log_window.Text += error_definition;
                    break;
                default:
                    error_definition = "Возникла неизвестная ошибка\n";
                    log_window.Text += error_definition;
                    return;
            }
        }

        private void Update_log()
        {
            List<String> Logs = Core.BC.Logger();
            foreach (String s in Logs)
                log_window.Text += s + "\n";

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
            log_window.Clear();
            turn_panel.Visible = true;
            atk_panel.Visible = true;
            def_panel.Visible = true;
            continue_btn.Visible = false;
            enemy_stats_group.Visible = true;
            player_stats_group.Visible = true;
            log_window.Visible = true;

            if (New_battle)
            {
                New_battle = false;
                Core.Start_new_game();
                Show_lvlup_panel();
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
            log_window.SelectionStart = log_window.Text.Length;
            log_window.ScrollToCaret();
        }
    }
}
