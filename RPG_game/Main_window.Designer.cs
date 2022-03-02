
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
            this.log_window = new System.Windows.Forms.RichTextBox();
            this.end_turn_Button = new System.Windows.Forms.Button();
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
            this.enemies_list = new System.Windows.Forms.ListBox();
            this.enemy_squad_lbl = new System.Windows.Forms.Label();
            this.turn_panel = new System.Windows.Forms.Panel();
            this.skill_description = new System.Windows.Forms.RichTextBox();
            this.use_skill_btn = new System.Windows.Forms.Button();
            this.enemy_stats_group = new System.Windows.Forms.GroupBox();
            this.enemy_stats = new System.Windows.Forms.ListBox();
            this.player_squad_lbl = new System.Windows.Forms.Label();
            this.players_list = new System.Windows.Forms.ListBox();
            this.player_stats_group = new System.Windows.Forms.GroupBox();
            this.player_stats = new System.Windows.Forms.ListBox();
            this.skill_panel = new System.Windows.Forms.GroupBox();
            this.skills_list = new System.Windows.Forms.ListBox();
            this.atk_panel.SuspendLayout();
            this.def_panel.SuspendLayout();
            this.turn_panel.SuspendLayout();
            this.enemy_stats_group.SuspendLayout();
            this.player_stats_group.SuspendLayout();
            this.skill_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // log_window
            // 
            this.log_window.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.log_window.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.log_window.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.log_window.ForeColor = System.Drawing.SystemColors.Window;
            this.log_window.Location = new System.Drawing.Point(533, 16);
            this.log_window.Name = "log_window";
            this.log_window.ReadOnly = true;
            this.log_window.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.log_window.Size = new System.Drawing.Size(466, 650);
            this.log_window.TabIndex = 0;
            this.log_window.Tag = "";
            this.log_window.Text = "";
            this.log_window.TextChanged += new System.EventHandler(this.Log_window_TextChanged);
            // 
            // end_turn_Button
            // 
            this.end_turn_Button.BackColor = System.Drawing.Color.Gray;
            this.end_turn_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.end_turn_Button.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_turn_Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.end_turn_Button.Location = new System.Drawing.Point(1008, 556);
            this.end_turn_Button.Name = "end_turn_Button";
            this.end_turn_Button.Size = new System.Drawing.Size(248, 110);
            this.end_turn_Button.TabIndex = 2;
            this.end_turn_Button.Tag = "battle_form";
            this.end_turn_Button.Text = "Закончить ход";
            this.end_turn_Button.UseVisualStyleBackColor = false;
            this.end_turn_Button.Click += new System.EventHandler(this.atk_Button_Click);
            // 
            // atk_panel
            // 
            this.atk_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.atk_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.atk_panel.Controls.Add(this.atk_legs_RadioButton);
            this.atk_panel.Controls.Add(this.atk_body_RadioButton);
            this.atk_panel.Controls.Add(this.Atttack_lbl);
            this.atk_panel.Controls.Add(this.atk_head_RadioButton);
            this.atk_panel.Location = new System.Drawing.Point(12, 549);
            this.atk_panel.Name = "atk_panel";
            this.atk_panel.Size = new System.Drawing.Size(246, 114);
            this.atk_panel.TabIndex = 3;
            this.atk_panel.Tag = "battle_form";
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
            this.Atttack_lbl.Location = new System.Drawing.Point(88, 10);
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
            this.def_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.def_panel.Controls.Add(this.def_legs_RadioButton);
            this.def_panel.Controls.Add(this.def_body_RadioButton);
            this.def_panel.Controls.Add(this.def_head_RadioButton);
            this.def_panel.Controls.Add(this.Defence_lbl);
            this.def_panel.Location = new System.Drawing.Point(264, 549);
            this.def_panel.Name = "def_panel";
            this.def_panel.Size = new System.Drawing.Size(248, 114);
            this.def_panel.TabIndex = 5;
            this.def_panel.Tag = "battle_form";
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
            this.Defence_lbl.Location = new System.Drawing.Point(74, 10);
            this.Defence_lbl.Name = "Defence_lbl";
            this.Defence_lbl.Size = new System.Drawing.Size(77, 25);
            this.Defence_lbl.TabIndex = 6;
            this.Defence_lbl.Text = "Защита";
            // 
            // enemies_list
            // 
            this.enemies_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.enemies_list.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enemies_list.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enemies_list.ForeColor = System.Drawing.SystemColors.Window;
            this.enemies_list.FormattingEnabled = true;
            this.enemies_list.ItemHeight = 17;
            this.enemies_list.Location = new System.Drawing.Point(264, 440);
            this.enemies_list.Name = "enemies_list";
            this.enemies_list.Size = new System.Drawing.Size(242, 104);
            this.enemies_list.TabIndex = 9;
            this.enemies_list.SelectedIndexChanged += new System.EventHandler(this.enemies_list_SelectedIndexChanged);
            // 
            // enemy_squad_lbl
            // 
            this.enemy_squad_lbl.AutoSize = true;
            this.enemy_squad_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enemy_squad_lbl.Location = new System.Drawing.Point(315, 415);
            this.enemy_squad_lbl.Name = "enemy_squad_lbl";
            this.enemy_squad_lbl.Size = new System.Drawing.Size(120, 25);
            this.enemy_squad_lbl.TabIndex = 7;
            this.enemy_squad_lbl.Text = "Отряд врага";
            // 
            // turn_panel
            // 
            this.turn_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.turn_panel.Controls.Add(this.skill_description);
            this.turn_panel.Controls.Add(this.def_panel);
            this.turn_panel.Controls.Add(this.use_skill_btn);
            this.turn_panel.Controls.Add(this.enemy_squad_lbl);
            this.turn_panel.Controls.Add(this.enemy_stats_group);
            this.turn_panel.Controls.Add(this.atk_panel);
            this.turn_panel.Controls.Add(this.enemies_list);
            this.turn_panel.Location = new System.Drawing.Point(12, 3);
            this.turn_panel.Name = "turn_panel";
            this.turn_panel.Size = new System.Drawing.Size(515, 666);
            this.turn_panel.TabIndex = 10;
            this.turn_panel.Tag = "battle_form";
            // 
            // skill_description
            // 
            this.skill_description.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skill_description.BackColor = System.Drawing.Color.Black;
            this.skill_description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.skill_description.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.skill_description.ForeColor = System.Drawing.SystemColors.Window;
            this.skill_description.Location = new System.Drawing.Point(3, 306);
            this.skill_description.Name = "skill_description";
            this.skill_description.ReadOnly = true;
            this.skill_description.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.skill_description.Size = new System.Drawing.Size(255, 128);
            this.skill_description.TabIndex = 14;
            this.skill_description.Tag = "";
            this.skill_description.Text = "";
            // 
            // use_skill_btn
            // 
            this.use_skill_btn.BackColor = System.Drawing.Color.Gray;
            this.use_skill_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.use_skill_btn.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.use_skill_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.use_skill_btn.Location = new System.Drawing.Point(3, 440);
            this.use_skill_btn.Name = "use_skill_btn";
            this.use_skill_btn.Size = new System.Drawing.Size(255, 104);
            this.use_skill_btn.TabIndex = 12;
            this.use_skill_btn.Tag = "battle_form";
            this.use_skill_btn.Text = "Использовать способность";
            this.use_skill_btn.UseVisualStyleBackColor = false;
            // 
            // enemy_stats_group
            // 
            this.enemy_stats_group.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.enemy_stats_group.Controls.Add(this.enemy_stats);
            this.enemy_stats_group.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enemy_stats_group.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.enemy_stats_group.Location = new System.Drawing.Point(264, 0);
            this.enemy_stats_group.Name = "enemy_stats_group";
            this.enemy_stats_group.Size = new System.Drawing.Size(242, 409);
            this.enemy_stats_group.TabIndex = 11;
            this.enemy_stats_group.TabStop = false;
            this.enemy_stats_group.Tag = "battle_form";
            this.enemy_stats_group.Text = "Характеристики врага";
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
            this.enemy_stats.Size = new System.Drawing.Size(229, 323);
            this.enemy_stats.TabIndex = 0;
            // 
            // player_squad_lbl
            // 
            this.player_squad_lbl.AutoSize = true;
            this.player_squad_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.player_squad_lbl.Location = new System.Drawing.Point(1087, 418);
            this.player_squad_lbl.Name = "player_squad_lbl";
            this.player_squad_lbl.Size = new System.Drawing.Size(105, 25);
            this.player_squad_lbl.TabIndex = 12;
            this.player_squad_lbl.Text = "Ваш отряд";
            // 
            // players_list
            // 
            this.players_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.players_list.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.players_list.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.players_list.ForeColor = System.Drawing.SystemColors.Window;
            this.players_list.FormattingEnabled = true;
            this.players_list.ItemHeight = 17;
            this.players_list.Location = new System.Drawing.Point(1008, 446);
            this.players_list.Name = "players_list";
            this.players_list.Size = new System.Drawing.Size(248, 104);
            this.players_list.TabIndex = 13;
            // 
            // player_stats_group
            // 
            this.player_stats_group.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.player_stats_group.Controls.Add(this.player_stats);
            this.player_stats_group.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.player_stats_group.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.player_stats_group.Location = new System.Drawing.Point(1008, 6);
            this.player_stats_group.Name = "player_stats_group";
            this.player_stats_group.Size = new System.Drawing.Size(248, 409);
            this.player_stats_group.TabIndex = 12;
            this.player_stats_group.TabStop = false;
            this.player_stats_group.Tag = "";
            this.player_stats_group.Text = "Характеристики игрока";
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
            this.player_stats.Size = new System.Drawing.Size(236, 357);
            this.player_stats.TabIndex = 13;
            // 
            // skill_panel
            // 
            this.skill_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skill_panel.Controls.Add(this.skills_list);
            this.skill_panel.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.skill_panel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.skill_panel.Location = new System.Drawing.Point(15, 3);
            this.skill_panel.Name = "skill_panel";
            this.skill_panel.Size = new System.Drawing.Size(255, 300);
            this.skill_panel.TabIndex = 12;
            this.skill_panel.TabStop = false;
            this.skill_panel.Tag = "battle_form";
            this.skill_panel.Text = "Выбор способностей";
            // 
            // skills_list
            // 
            this.skills_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skills_list.BackColor = System.Drawing.SystemColors.MenuText;
            this.skills_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skills_list.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.skills_list.ForeColor = System.Drawing.SystemColors.Window;
            this.skills_list.FormattingEnabled = true;
            this.skills_list.ItemHeight = 17;
            this.skills_list.Items.AddRange(new object[] {
            "asd",
            "asd",
            "asd"});
            this.skills_list.Location = new System.Drawing.Point(7, 22);
            this.skills_list.MultiColumn = true;
            this.skills_list.Name = "skills_list";
            this.skills_list.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.skills_list.Size = new System.Drawing.Size(242, 272);
            this.skills_list.TabIndex = 0;
            // 
            // Main_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.skill_panel);
            this.Controls.Add(this.player_squad_lbl);
            this.Controls.Add(this.player_stats_group);
            this.Controls.Add(this.players_list);
            this.Controls.Add(this.turn_panel);
            this.Controls.Add(this.log_window);
            this.Controls.Add(this.end_turn_Button);
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
            this.player_stats_group.ResumeLayout(false);
            this.skill_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox log_window;
        private System.Windows.Forms.Button end_turn_Button;
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
        private System.Windows.Forms.ListBox enemies_list;
        private System.Windows.Forms.Label enemy_squad_lbl;
        private System.Windows.Forms.Panel turn_panel;
        private System.Windows.Forms.GroupBox enemy_stats_group;
        private System.Windows.Forms.GroupBox player_stats_group;
        private System.Windows.Forms.ListBox enemy_stats;
        private System.Windows.Forms.ListBox player_stats;
        private System.Windows.Forms.Label player_squad_lbl;
        private System.Windows.Forms.ListBox players_list;
        private System.Windows.Forms.Button use_skill_btn;
        private System.Windows.Forms.GroupBox skill_panel;
        private System.Windows.Forms.ListBox skills_list;
        private System.Windows.Forms.RichTextBox skill_description;
    }
}

