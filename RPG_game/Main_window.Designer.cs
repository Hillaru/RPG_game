
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
            this.enemy_stats = new System.Windows.Forms.ListBox();
            this.player_stats_group = new System.Windows.Forms.GroupBox();
            this.player_stats = new System.Windows.Forms.ListBox();
            this.atk_panel.SuspendLayout();
            this.def_panel.SuspendLayout();
            this.turn_panel.SuspendLayout();
            this.enemy_stats_group.SuspendLayout();
            this.player_stats_group.SuspendLayout();
            this.SuspendLayout();
            // 
            // log_window
            // 
            this.log_window.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.log_window.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.log_window.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.log_window.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.log_window.ForeColor = System.Drawing.SystemColors.Window;
            this.log_window.Location = new System.Drawing.Point(291, 12);
            this.log_window.Name = "log_window";
            this.log_window.ReadOnly = true;
            this.log_window.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.log_window.Size = new System.Drawing.Size(638, 441);
            this.log_window.TabIndex = 0;
            this.log_window.Tag = "";
            this.log_window.Text = "";
            this.log_window.TextChanged += new System.EventHandler(this.Log_window_TextChanged);
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
            this.continue_btn.Tag = "";
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
            this.enemies_list.SelectedIndexChanged += new System.EventHandler(this.enemies_list_SelectedIndexChanged);
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
            this.turn_panel.Tag = "battle_form";
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
            this.enemy_stats.Size = new System.Drawing.Size(235, 408);
            this.enemy_stats.TabIndex = 0;
            // 
            // player_stats_group
            // 
            this.player_stats_group.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.player_stats_group.Controls.Add(this.player_stats);
            this.player_stats_group.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.player_stats_group.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.player_stats_group.Location = new System.Drawing.Point(14, 13);
            this.player_stats_group.Name = "player_stats_group";
            this.player_stats_group.Size = new System.Drawing.Size(259, 440);
            this.player_stats_group.TabIndex = 12;
            this.player_stats_group.TabStop = false;
            this.player_stats_group.Tag = "battle_form";
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
            this.player_stats.Size = new System.Drawing.Size(247, 408);
            this.player_stats.TabIndex = 13;
            // 
            // Main_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(1208, 704);
            this.Controls.Add(this.player_stats_group);
            this.Controls.Add(this.enemy_stats_group);
            this.Controls.Add(this.turn_panel);
            this.Controls.Add(this.continue_btn);
            this.Controls.Add(this.def_panel);
            this.Controls.Add(this.atk_panel);
            this.Controls.Add(this.log_window);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox log_window;
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
        private System.Windows.Forms.GroupBox player_stats_group;
        private System.Windows.Forms.ListBox enemy_stats;
        private System.Windows.Forms.ListBox player_stats;
    }
}

