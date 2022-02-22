
namespace RPG_game
{
    partial class Main_window
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Log_window = new System.Windows.Forms.RichTextBox();
            this.atk_Button = new System.Windows.Forms.Button();
            this.atk_panel = new System.Windows.Forms.Panel();
            this.atk_legs_RadioButton = new System.Windows.Forms.RadioButton();
            this.atk_body_RadioButton = new System.Windows.Forms.RadioButton();
            this.Atttack_lbl = new System.Windows.Forms.Label();
            this.atk_head_RadioButton = new System.Windows.Forms.RadioButton();
            this.def_panel = new System.Windows.Forms.Panel();
            this.def_legs_RadioButton = new System.Windows.Forms.RadioButton();
            this.def_body_RadioButton = new System.Windows.Forms.RadioButton();
            this.def_head_RadioButton = new System.Windows.Forms.RadioButton();
            this.Defence_lbl = new System.Windows.Forms.Label();
            this.continue_btn = new System.Windows.Forms.Button();
            this.enemies_list = new System.Windows.Forms.ListBox();
            this.enemies_list_lbl = new System.Windows.Forms.Label();
            this.turn_panel = new System.Windows.Forms.Panel();
            this.enemy_stats_group = new System.Windows.Forms.GroupBox();
            this.Player_stats_group = new System.Windows.Forms.GroupBox();
            this.enemy_stats = new System.Windows.Forms.ListBox();
            this.player_stats = new System.Windows.Forms.ListBox();
            this.Leveling_tab = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.atk_panel.SuspendLayout();
            this.def_panel.SuspendLayout();
            this.turn_panel.SuspendLayout();
            this.enemy_stats_group.SuspendLayout();
            this.Player_stats_group.SuspendLayout();
            this.Leveling_tab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // Log_window
            // 
            this.Log_window.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Log_window.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Log_window.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Log_window.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Log_window.ForeColor = System.Drawing.SystemColors.Window;
            this.Log_window.Location = new System.Drawing.Point(291, 12);
            this.Log_window.Name = "Log_window";
            this.Log_window.ReadOnly = true;
            this.Log_window.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.Log_window.Size = new System.Drawing.Size(638, 441);
            this.Log_window.TabIndex = 0;
            this.Log_window.Text = "";
            this.Log_window.TextChanged += new System.EventHandler(this.Log_window_TextChanged);
            // 
            // atk_Button
            // 
            this.atk_Button.BackColor = System.Drawing.Color.Gray;
            this.atk_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.atk_Button.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atk_Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.atk_Button.Location = new System.Drawing.Point(216, 17);
            this.atk_Button.Name = "atk_Button";
            this.atk_Button.Size = new System.Drawing.Size(146, 124);
            this.atk_Button.TabIndex = 2;
            this.atk_Button.Text = "Сделать ход";
            this.atk_Button.UseVisualStyleBackColor = false;
            this.atk_Button.Click += new System.EventHandler(this.atk_Button_Click);
            // 
            // atk_panel
            // 
            this.atk_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.atk_panel.Controls.Add(this.atk_legs_RadioButton);
            this.atk_panel.Controls.Add(this.atk_body_RadioButton);
            this.atk_panel.Controls.Add(this.Atttack_lbl);
            this.atk_panel.Controls.Add(this.atk_head_RadioButton);
            this.atk_panel.Location = new System.Drawing.Point(14, 563);
            this.atk_panel.Name = "atk_panel";
            this.atk_panel.Size = new System.Drawing.Size(164, 129);
            this.atk_panel.TabIndex = 3;
            // 
            // atk_legs_RadioButton
            // 
            this.atk_legs_RadioButton.AutoSize = true;
            this.atk_legs_RadioButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.atk_legs_RadioButton.Location = new System.Drawing.Point(3, 84);
            this.atk_legs_RadioButton.Name = "atk_legs_RadioButton";
            this.atk_legs_RadioButton.Size = new System.Drawing.Size(115, 23);
            this.atk_legs_RadioButton.TabIndex = 0;
            this.atk_legs_RadioButton.TabStop = true;
            this.atk_legs_RadioButton.Text = "нижняя часть";
            this.atk_legs_RadioButton.UseVisualStyleBackColor = true;
            this.atk_legs_RadioButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // atk_body_RadioButton
            // 
            this.atk_body_RadioButton.AutoSize = true;
            this.atk_body_RadioButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.atk_body_RadioButton.Location = new System.Drawing.Point(3, 61);
            this.atk_body_RadioButton.Name = "atk_body_RadioButton";
            this.atk_body_RadioButton.Size = new System.Drawing.Size(148, 23);
            this.atk_body_RadioButton.TabIndex = 0;
            this.atk_body_RadioButton.TabStop = true;
            this.atk_body_RadioButton.Text = "центральная часть";
            this.atk_body_RadioButton.UseVisualStyleBackColor = true;
            this.atk_body_RadioButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // Atttack_lbl
            // 
            this.Atttack_lbl.AutoSize = true;
            this.Atttack_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Atttack_lbl.Location = new System.Drawing.Point(3, 7);
            this.Atttack_lbl.Name = "Atttack_lbl";
            this.Atttack_lbl.Size = new System.Drawing.Size(63, 25);
            this.Atttack_lbl.TabIndex = 7;
            this.Atttack_lbl.Text = "Атака";
            // 
            // atk_head_RadioButton
            // 
            this.atk_head_RadioButton.AutoSize = true;
            this.atk_head_RadioButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.atk_head_RadioButton.Location = new System.Drawing.Point(3, 38);
            this.atk_head_RadioButton.Name = "atk_head_RadioButton";
            this.atk_head_RadioButton.Size = new System.Drawing.Size(118, 23);
            this.atk_head_RadioButton.TabIndex = 0;
            this.atk_head_RadioButton.TabStop = true;
            this.atk_head_RadioButton.Text = "верхняя часть";
            this.atk_head_RadioButton.UseVisualStyleBackColor = true;
            this.atk_head_RadioButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // def_panel
            // 
            this.def_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.def_panel.Controls.Add(this.def_legs_RadioButton);
            this.def_panel.Controls.Add(this.def_body_RadioButton);
            this.def_panel.Controls.Add(this.def_head_RadioButton);
            this.def_panel.Controls.Add(this.Defence_lbl);
            this.def_panel.Location = new System.Drawing.Point(184, 563);
            this.def_panel.Name = "def_panel";
            this.def_panel.Size = new System.Drawing.Size(176, 129);
            this.def_panel.TabIndex = 5;
            // 
            // def_legs_RadioButton
            // 
            this.def_legs_RadioButton.AutoSize = true;
            this.def_legs_RadioButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.def_legs_RadioButton.Location = new System.Drawing.Point(3, 84);
            this.def_legs_RadioButton.Name = "def_legs_RadioButton";
            this.def_legs_RadioButton.Size = new System.Drawing.Size(115, 23);
            this.def_legs_RadioButton.TabIndex = 0;
            this.def_legs_RadioButton.TabStop = true;
            this.def_legs_RadioButton.Text = "нижняя часть";
            this.def_legs_RadioButton.UseVisualStyleBackColor = true;
            this.def_legs_RadioButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // def_body_RadioButton
            // 
            this.def_body_RadioButton.AutoSize = true;
            this.def_body_RadioButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.def_body_RadioButton.Location = new System.Drawing.Point(3, 61);
            this.def_body_RadioButton.Name = "def_body_RadioButton";
            this.def_body_RadioButton.Size = new System.Drawing.Size(148, 23);
            this.def_body_RadioButton.TabIndex = 0;
            this.def_body_RadioButton.TabStop = true;
            this.def_body_RadioButton.Text = "центральная часть";
            this.def_body_RadioButton.UseVisualStyleBackColor = true;
            this.def_body_RadioButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // def_head_RadioButton
            // 
            this.def_head_RadioButton.AutoSize = true;
            this.def_head_RadioButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.def_head_RadioButton.Location = new System.Drawing.Point(3, 38);
            this.def_head_RadioButton.Name = "def_head_RadioButton";
            this.def_head_RadioButton.Size = new System.Drawing.Size(118, 23);
            this.def_head_RadioButton.TabIndex = 0;
            this.def_head_RadioButton.TabStop = true;
            this.def_head_RadioButton.Text = "верхняя часть";
            this.def_head_RadioButton.UseVisualStyleBackColor = true;
            this.def_head_RadioButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // Defence_lbl
            // 
            this.Defence_lbl.AutoSize = true;
            this.Defence_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Defence_lbl.Location = new System.Drawing.Point(3, 7);
            this.Defence_lbl.Name = "Defence_lbl";
            this.Defence_lbl.Size = new System.Drawing.Size(77, 25);
            this.Defence_lbl.TabIndex = 6;
            this.Defence_lbl.Text = "Защита";
            // 
            // continue_btn
            // 
            this.continue_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.continue_btn.BackColor = System.Drawing.Color.Gray;
            this.continue_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.continue_btn.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold);
            this.continue_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.continue_btn.Location = new System.Drawing.Point(448, 563);
            this.continue_btn.Name = "continue_btn";
            this.continue_btn.Size = new System.Drawing.Size(325, 124);
            this.continue_btn.TabIndex = 8;
            this.continue_btn.Text = "Начать битву";
            this.continue_btn.UseVisualStyleBackColor = false;
            this.continue_btn.Visible = false;
            this.continue_btn.Click += new System.EventHandler(this.continue_btn_Click);
            // 
            // enemies_list
            // 
            this.enemies_list.BackColor = System.Drawing.Color.Gray;
            this.enemies_list.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enemies_list.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enemies_list.FormattingEnabled = true;
            this.enemies_list.ItemHeight = 17;
            this.enemies_list.Location = new System.Drawing.Point(2, 37);
            this.enemies_list.Name = "enemies_list";
            this.enemies_list.Size = new System.Drawing.Size(208, 104);
            this.enemies_list.TabIndex = 9;
            // 
            // enemies_list_lbl
            // 
            this.enemies_list_lbl.AutoSize = true;
            this.enemies_list_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enemies_list_lbl.Location = new System.Drawing.Point(3, 9);
            this.enemies_list_lbl.Name = "enemies_list_lbl";
            this.enemies_list_lbl.Size = new System.Drawing.Size(119, 25);
            this.enemies_list_lbl.TabIndex = 7;
            this.enemies_list_lbl.Text = "Выбор цели";
            // 
            // turn_panel
            // 
            this.turn_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.turn_panel.Controls.Add(this.enemies_list_lbl);
            this.turn_panel.Controls.Add(this.enemies_list);
            this.turn_panel.Controls.Add(this.atk_Button);
            this.turn_panel.Location = new System.Drawing.Point(824, 546);
            this.turn_panel.Name = "turn_panel";
            this.turn_panel.Size = new System.Drawing.Size(365, 146);
            this.turn_panel.TabIndex = 10;
            // 
            // enemy_stats_group
            // 
            this.enemy_stats_group.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.enemy_stats_group.Controls.Add(this.enemy_stats);
            this.enemy_stats_group.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enemy_stats_group.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.enemy_stats_group.Location = new System.Drawing.Point(947, 14);
            this.enemy_stats_group.Name = "enemy_stats_group";
            this.enemy_stats_group.Size = new System.Drawing.Size(248, 439);
            this.enemy_stats_group.TabIndex = 11;
            this.enemy_stats_group.TabStop = false;
            this.enemy_stats_group.Text = "Характеристики врага";
            // 
            // Player_stats_group
            // 
            this.Player_stats_group.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Player_stats_group.Controls.Add(this.player_stats);
            this.Player_stats_group.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Player_stats_group.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Player_stats_group.Location = new System.Drawing.Point(14, 13);
            this.Player_stats_group.Name = "Player_stats_group";
            this.Player_stats_group.Size = new System.Drawing.Size(259, 440);
            this.Player_stats_group.TabIndex = 12;
            this.Player_stats_group.TabStop = false;
            this.Player_stats_group.Text = "Характеристики игрока";
            // 
            // enemy_stats
            // 
            this.enemy_stats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.enemy_stats.BackColor = System.Drawing.SystemColors.MenuText;
            this.enemy_stats.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.enemy_stats.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enemy_stats.ForeColor = System.Drawing.SystemColors.Window;
            this.enemy_stats.FormattingEnabled = true;
            this.enemy_stats.ItemHeight = 17;
            this.enemy_stats.Items.AddRange(new object[] {
            "asd",
            "asd",
            "asd"});
            this.enemy_stats.Location = new System.Drawing.Point(7, 22);
            this.enemy_stats.MultiColumn = true;
            this.enemy_stats.Name = "enemy_stats";
            this.enemy_stats.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.enemy_stats.Size = new System.Drawing.Size(235, 408);
            this.enemy_stats.TabIndex = 0;
            // 
            // player_stats
            // 
            this.player_stats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.player_stats.BackColor = System.Drawing.SystemColors.MenuText;
            this.player_stats.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.player_stats.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.player_stats.ForeColor = System.Drawing.SystemColors.Window;
            this.player_stats.FormattingEnabled = true;
            this.player_stats.ItemHeight = 17;
            this.player_stats.Items.AddRange(new object[] {
            "asd",
            "asd",
            "asd"});
            this.player_stats.Location = new System.Drawing.Point(6, 21);
            this.player_stats.MultiColumn = true;
            this.player_stats.Name = "player_stats";
            this.player_stats.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.player_stats.Size = new System.Drawing.Size(247, 408);
            this.player_stats.TabIndex = 13;
            // 
            // Leveling_tab
            // 
            this.Leveling_tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Leveling_tab.Controls.Add(this.button14);
            this.Leveling_tab.Controls.Add(this.button13);
            this.Leveling_tab.Controls.Add(this.label7);
            this.Leveling_tab.Controls.Add(this.panel6);
            this.Leveling_tab.Controls.Add(this.panel5);
            this.Leveling_tab.Controls.Add(this.panel4);
            this.Leveling_tab.Controls.Add(this.panel3);
            this.Leveling_tab.Controls.Add(this.panel2);
            this.Leveling_tab.Controls.Add(this.panel1);
            this.Leveling_tab.Location = new System.Drawing.Point(303, 23);
            this.Leveling_tab.Name = "Leveling_tab";
            this.Leveling_tab.Size = new System.Drawing.Size(613, 517);
            this.Leveling_tab.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(35, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 58);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(75, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(13, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 51);
            this.button1.TabIndex = 3;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(461, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 51);
            this.button2.TabIndex = 4;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(35, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(530, 58);
            this.panel2.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(461, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 51);
            this.button3.TabIndex = 4;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(13, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 51);
            this.button4.TabIndex = 3;
            this.button4.Text = "<";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(75, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(35, 139);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(530, 58);
            this.panel3.TabIndex = 6;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Gray;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Location = new System.Drawing.Point(461, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 51);
            this.button5.TabIndex = 4;
            this.button5.Text = ">";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Gray;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Location = new System.Drawing.Point(13, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(56, 51);
            this.button6.TabIndex = 3;
            this.button6.Text = "<";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(75, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "label3";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button7);
            this.panel4.Controls.Add(this.button8);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(35, 203);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(530, 58);
            this.panel4.TabIndex = 5;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Gray;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button7.Location = new System.Drawing.Point(461, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(56, 51);
            this.button7.TabIndex = 4;
            this.button7.Text = ">";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Gray;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button8.Location = new System.Drawing.Point(13, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(56, 51);
            this.button8.TabIndex = 3;
            this.button8.Text = "<";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(75, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "label4";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button9);
            this.panel5.Controls.Add(this.button10);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(35, 267);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(530, 58);
            this.panel5.TabIndex = 5;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Gray;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button9.Location = new System.Drawing.Point(461, 3);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(56, 51);
            this.button9.TabIndex = 4;
            this.button9.Text = ">";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Gray;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button10.Location = new System.Drawing.Point(13, 3);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(56, 51);
            this.button10.TabIndex = 3;
            this.button10.Text = "<";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(75, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "label5";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button11);
            this.panel6.Controls.Add(this.button12);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(35, 331);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(530, 58);
            this.panel6.TabIndex = 7;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Gray;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button11.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button11.Location = new System.Drawing.Point(461, 3);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(56, 51);
            this.button11.TabIndex = 4;
            this.button11.Text = ">";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Gray;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button12.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button12.Location = new System.Drawing.Point(13, 3);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(56, 51);
            this.button12.TabIndex = 3;
            this.button12.Text = "<";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(75, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(28, 405);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(418, 37);
            this.label7.TabIndex = 8;
            this.label7.Text = "Осталось очков характеристик:";
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Gray;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button13.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button13.Location = new System.Drawing.Point(35, 445);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(237, 51);
            this.button13.TabIndex = 9;
            this.button13.Text = "Отмена";
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Gray;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button14.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button14.Location = new System.Drawing.Point(316, 445);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(259, 51);
            this.button14.TabIndex = 10;
            this.button14.Text = "Подтвердить";
            this.button14.UseVisualStyleBackColor = false;
            // 
            // Main_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(1208, 704);
            this.Controls.Add(this.Leveling_tab);
            this.Controls.Add(this.Player_stats_group);
            this.Controls.Add(this.enemy_stats_group);
            this.Controls.Add(this.turn_panel);
            this.Controls.Add(this.continue_btn);
            this.Controls.Add(this.def_panel);
            this.Controls.Add(this.atk_panel);
            this.Controls.Add(this.Log_window);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Main_window";
            this.Text = "RPG game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_window_FormClosed);
            this.Load += new System.EventHandler(this.Main_window_Load);
            this.atk_panel.ResumeLayout(false);
            this.atk_panel.PerformLayout();
            this.def_panel.ResumeLayout(false);
            this.def_panel.PerformLayout();
            this.turn_panel.ResumeLayout(false);
            this.turn_panel.PerformLayout();
            this.enemy_stats_group.ResumeLayout(false);
            this.Player_stats_group.ResumeLayout(false);
            this.Leveling_tab.ResumeLayout(false);
            this.Leveling_tab.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Log_window;
        private System.Windows.Forms.Button atk_Button;
        private System.Windows.Forms.Panel atk_panel;
        private System.Windows.Forms.RadioButton atk_legs_RadioButton;
        private System.Windows.Forms.RadioButton atk_body_RadioButton;
        private System.Windows.Forms.RadioButton atk_head_RadioButton;
        private System.Windows.Forms.Panel def_panel;
        private System.Windows.Forms.RadioButton def_legs_RadioButton;
        private System.Windows.Forms.RadioButton def_body_RadioButton;
        private System.Windows.Forms.RadioButton def_head_RadioButton;
        private System.Windows.Forms.Label Defence_lbl;
        private System.Windows.Forms.Label Atttack_lbl;
        private System.Windows.Forms.Button continue_btn;
        private System.Windows.Forms.ListBox enemies_list;
        private System.Windows.Forms.Label enemies_list_lbl;
        private System.Windows.Forms.Panel turn_panel;
        private System.Windows.Forms.GroupBox enemy_stats_group;
        private System.Windows.Forms.GroupBox Player_stats_group;
        private System.Windows.Forms.ListBox enemy_stats;
        private System.Windows.Forms.ListBox player_stats;
        private System.Windows.Forms.Panel Leveling_tab;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

