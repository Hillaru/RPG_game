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
using static RPG_game.Converter;
using static RPG_game.Constants;

namespace RPG_game
{
    public partial class Main_window : Form
    {
        Rpg_core Core = new Rpg_core();
        Body_part Atk_part = Body_part.body;
        Body_part Def_part = Body_part.body;
        bool New_battle = true;
        List<Enemy> Enemy_ds = new List<Enemy>();
        Panel lvl_up_panel;
        int[] Stats_to_add;
        int Stat_points = 0;

        private void Main_window_Load(object sender, EventArgs e)
        {
            atk_body_RadioButton.Checked = true;
            def_body_RadioButton.Checked = true;

            Change_controls_properties("battle_form", false);

            Start_battle_button_initializer(true);
        }

        #region Log_actions
        enum ErrorType : int
        {
            no_target = 0
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

        public Main_window()
        {
            InitializeComponent();
        }

        private void Show_stats()
        {
            enemy_stats.Items.Clear();
        }
        private void Show_stats(Enemy unit)
        {
            enemy_stats.Items.Clear();
            int j = 0;

            for (int i = 1; i < 30; i++)
            {
                if (unit.Max_stats[i] != 0)
                {
                    String line = $"{Stat_to_string((Stat)i)}: {unit.Current_stats[i]}";
                    if (unit.Current_stats[i] != unit.Max_stats[i])
                        line += $" / {unit.Max_stats[i]}";
                    enemy_stats.Items.Insert(j, line);
                    j++;
                }
            }
        }
        private void Show_stats(Player unit)
        {
            player_stats.Items.Clear();
            int j = 0;

            for (int i = 1; i < 30; i++)
            {
                if (unit.Max_stats[i] != 0)
                {
                    String line = $"{Stat_to_string((Stat)i)}: {unit.Current_stats[i]}";
                    if (unit.Current_stats[i] != unit.Max_stats[i])
                        line += $" / {unit.Max_stats[i]}";
                    player_stats.Items.Insert(j, line);
                    j++;
                }
            }
        }

        private void Update_log()
        {
            List<String> Logs = Core.BC.Logger();
            foreach (String s in Logs)
                log_window.Text += s + "\n";
        }

        private void Update_interface()
        {
            Update_log();
            Update_battle_status();
            Show_stats(Core.Player_squad[0]);
        }

        private void Log_window_TextChanged(object sender, EventArgs e)
        {
            log_window.SelectionStart = log_window.Text.Length;
            log_window.ScrollToCaret();
        }
        #endregion

        #region Lvl_up_panel
        private void Show_lvlup_panel()
        {
            Player player = Core.Player_squad[0];

            Stats_to_add = new int[Stats_list_size];
            Stat_points = player.Current_stats[(int)Stat.stat_points];

            lvl_up_panel = new Panel();
            lvl_up_panel.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom);
            lvl_up_panel.Font = new Font("Segoe UI Semibold", 20, FontStyle.Bold);
            lvl_up_panel.ForeColor = Color.Black;
            lvl_up_panel.Name = "lvlup_panel";
            lvl_up_panel.Size = new Size(613, 517);
            lvl_up_panel.Location = new Point(303, 23);
            lvl_up_panel.BackColor = Color.FromArgb(20, 20, 20);
            lvl_up_panel.BorderStyle = BorderStyle.FixedSingle;
            int num = 0;

            Label lvl_points_lbl = new Label();
            lvl_points_lbl.Anchor = (AnchorStyles.Bottom);
            lvl_points_lbl.Name = "lvl_points_lbl";
            lvl_points_lbl.ForeColor = Color.White;
            lvl_points_lbl.Location = new Point(28, 405);
            lvl_points_lbl.AutoSize = true;
            lvl_points_lbl.Text = $"Осталось очков характеристик: {Stat_points}";
            lvl_up_panel.Controls.Add(lvl_points_lbl);

            Button cncl_btn = new Button();
            cncl_btn.Anchor = (AnchorStyles.Left | AnchorStyles.Bottom);
            cncl_btn.Name = "cncl_btn";
            cncl_btn.Font = new Font("Arial Narrow", 20, FontStyle.Bold);
            cncl_btn.BackColor = Color.Gray;
            cncl_btn.Size = new Size(237, 51);
            cncl_btn.Location = new Point(35, 445);
            cncl_btn.FlatStyle = FlatStyle.Popup;
            cncl_btn.Text = "Отменить";
            cncl_btn.Click += new EventHandler(lvlup_panel_Button_Click);
            lvl_up_panel.Controls.Add(cncl_btn);

            Button accept_btn = new Button();
            accept_btn.Anchor = (AnchorStyles.Right | AnchorStyles.Bottom);
            accept_btn.Name = "accept_btn";
            accept_btn.Font = new Font("Arial Narrow", 20, FontStyle.Bold);
            accept_btn.BackColor = Color.Gray;
            accept_btn.Size = new Size(237, 51);
            accept_btn.Location = new Point(336, 445);
            accept_btn.FlatStyle = FlatStyle.Popup;
            accept_btn.Text = "Подтвердить";
            accept_btn.Click += new EventHandler(lvlup_panel_Button_Click);
            lvl_up_panel.Controls.Add(accept_btn);

            for (int stat_id = 40; stat_id < 50; stat_id++)
            {
                String Name = Stat_to_string((Stat)stat_id);
                if (Name == "-")
                    continue;

                Panel stat_panel = new Panel();
                stat_panel.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);
                stat_panel.Size = new Size(530, 58);
                stat_panel.Location = new Point(35, 11 + 64 * num);
                num++;
                lvl_up_panel.Controls.Add(stat_panel);

                Button l_button = new Button();
                l_button.Anchor = (AnchorStyles.Left);
                l_button.Name = Name + "_lbtn";
                l_button.Font = new Font("Arial Narrow", 20, FontStyle.Bold);
                l_button.BackColor = Color.Gray;
                l_button.Size = new Size(56, 51);
                l_button.Location = new Point(13, 3);
                l_button.FlatStyle = FlatStyle.Popup;
                l_button.Text = "<";
                l_button.Click += new EventHandler(lvlup_panel_Button_Click);
                stat_panel.Controls.Add(l_button);

                Button r_button = new Button();
                r_button.Anchor = (AnchorStyles.Right);
                r_button.Name = Name + "_rbtn";
                r_button.Font = new Font("Arial Narrow", 20, FontStyle.Bold);
                r_button.BackColor = Color.Gray;
                r_button.Size = new Size(56, 51);
                r_button.Location = new Point(461, 3);
                r_button.FlatStyle = FlatStyle.Popup;
                r_button.Text = ">";
                r_button.Click += new EventHandler(lvlup_panel_Button_Click);
                stat_panel.Controls.Add(r_button);

                Label stat_label = new Label();
                stat_label.Anchor = (AnchorStyles.Left | AnchorStyles.Right);
                stat_label.Name = Name + "_lbl";
                stat_label.ForeColor = Color.White;
                stat_label.Location = new Point(75, 15);
                stat_label.AutoSize = true;
                stat_label.Text = Name + $": {player.Max_stats[stat_id]}";
                stat_panel.Controls.Add(stat_label);
            }

            Controls.Add(lvl_up_panel);
            Change_controls_properties("battle_form", false); ;
            lvl_up_panel.BringToFront();
        }

        private void lvlup_panel_Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            String Name = button.Name;
            Player player = Core.Player_squad[0];

            if (Name == "cncl_btn")
            {
                Start_battle_button_initializer(true);
                lvl_up_panel.Dispose();
                return;
            }

            if (Name == "accept_btn")
            {
                player.Active_stats_gain(Stats_to_add, Stat_points);
                Start_battle_button_initializer(true);
                Show_stats(player);
                lvl_up_panel.Dispose();
                return;
            }

            string[] words = Name.Split(new char[] { '_' });
            Label lbl = (Label)lvl_up_panel.Controls.Find(words[0] + "_lbl", true)[0];
            Stat stat = String_to_stat(words[0]);
            int stat_index = (int)stat;

            if (Stat_points != 0 && words[1] == "rbtn")
            {
                Stats_to_add[stat_index]++;
                Stat_points--;
                if (lbl.ForeColor != Color.Green)
                    lbl.ForeColor = Color.Green;
            }
            else if (Stats_to_add[stat_index] != 0 && words[1] == "lbtn")
            {
                Stats_to_add[stat_index]--;
                Stat_points++;
                if (lbl.ForeColor == Color.Green && Stats_to_add[stat_index] == 0)
                    lbl.ForeColor = Color.White;
            }

            lvl_up_panel.Controls.Find("lvl_points_lbl", true)[0].Text = $"Осталось очков характеристик: {Stat_points}";
            lbl.Text = $"{words[0]}: {player.Max_stats[stat_index] + Stats_to_add[stat_index]}";
        }
        #endregion

        public void Change_controls_properties(string tag, bool visible, bool enabled = true)
        {
            for (int i = 0; i < Controls.Count; i++)
                if ((string)Controls[i].Tag == tag)
                {
                    Controls[i].Visible = visible;
                    Controls[i].Enabled = enabled;
                }
        }

        public void Start_battle_button_initializer(bool Show)
        {
            if (Show)
            {
                Button start_btn = new Button();
                start_btn.Anchor = (AnchorStyles.Bottom);
                start_btn.Name = "start_btn";
                start_btn.Font = new Font("Arial Narrow", 20, FontStyle.Bold);
                start_btn.BackColor = Color.Gray;
                start_btn.ForeColor = Color.Black;
                start_btn.Size = new Size(325, 124);
                start_btn.Location = new Point(476, 540);
                start_btn.FlatStyle = FlatStyle.Popup;
                start_btn.Text = "Начать битву";
                start_btn.Click += new EventHandler(start_battle_btn_Click);
                Controls.Add(start_btn);
            }
            else
            {
                Controls.Find("start_btn", true)[0].Dispose();
            }
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
            Update_interface();
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

        private void Update_battle_status()
        {
            if (Core.BC.Status == Battle_status.player_win)
            {
                atk_body_RadioButton.Checked = true;
                def_body_RadioButton.Checked = true;

                Change_controls_properties("battle_form", false);

                if (Core.Player_squad[0].Current_stats[(int)Stat.stat_points] != 0)
                    Show_lvlup_panel();
                else
                    Start_battle_button_initializer(true);
            }

            if (Core.BC.Status == Battle_status.enemies_win)
            {
                New_battle = true;
                atk_body_RadioButton.Checked = true;
                def_body_RadioButton.Checked = true;

                Change_controls_properties("battle_form", false);
                Start_battle_button_initializer(true);
            }
        }

        private void start_battle_btn_Click(object sender, EventArgs e)
        {
            log_window.Clear();
            Change_controls_properties("battle_form", true);

            if (New_battle)
            {
                New_battle = false;
                Core.Start_new_game();
            }
            else
                Core.Start_battle();

            Configure_enemy_data_source();
            Update_interface();
            Start_battle_button_initializer(false);
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

        private void enemies_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            Show_stats(Enemy_ds[enemies_list.SelectedIndex]);
        }
    }
}
