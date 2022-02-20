
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
            this.atk_panel.SuspendLayout();
            this.def_panel.SuspendLayout();
            this.turn_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Log_window
            // 
            this.Log_window.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Log_window.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Log_window.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Log_window.ForeColor = System.Drawing.SystemColors.Window;
            this.Log_window.Location = new System.Drawing.Point(12, 12);
            this.Log_window.Name = "Log_window";
            this.Log_window.ReadOnly = true;
            this.Log_window.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.Log_window.Size = new System.Drawing.Size(776, 312);
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
            this.atk_Button.Location = new System.Drawing.Point(155, 8);
            this.atk_Button.Name = "atk_Button";
            this.atk_Button.Size = new System.Drawing.Size(126, 84);
            this.atk_Button.TabIndex = 2;
            this.atk_Button.Text = "Сделать ход";
            this.atk_Button.UseVisualStyleBackColor = false;
            this.atk_Button.Click += new System.EventHandler(this.atk_Button_Click);
            // 
            // atk_panel
            // 
            this.atk_panel.Controls.Add(this.atk_legs_RadioButton);
            this.atk_panel.Controls.Add(this.atk_body_RadioButton);
            this.atk_panel.Controls.Add(this.Atttack_lbl);
            this.atk_panel.Controls.Add(this.atk_head_RadioButton);
            this.atk_panel.Location = new System.Drawing.Point(12, 335);
            this.atk_panel.Name = "atk_panel";
            this.atk_panel.Size = new System.Drawing.Size(128, 97);
            this.atk_panel.TabIndex = 3;
            // 
            // atk_legs_RadioButton
            // 
            this.atk_legs_RadioButton.AutoSize = true;
            this.atk_legs_RadioButton.Location = new System.Drawing.Point(3, 77);
            this.atk_legs_RadioButton.Name = "atk_legs_RadioButton";
            this.atk_legs_RadioButton.Size = new System.Drawing.Size(98, 17);
            this.atk_legs_RadioButton.TabIndex = 0;
            this.atk_legs_RadioButton.TabStop = true;
            this.atk_legs_RadioButton.Text = "нижняя часть";
            this.atk_legs_RadioButton.UseVisualStyleBackColor = true;
            this.atk_legs_RadioButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // atk_body_RadioButton
            // 
            this.atk_body_RadioButton.AutoSize = true;
            this.atk_body_RadioButton.Location = new System.Drawing.Point(3, 54);
            this.atk_body_RadioButton.Name = "atk_body_RadioButton";
            this.atk_body_RadioButton.Size = new System.Drawing.Size(125, 17);
            this.atk_body_RadioButton.TabIndex = 0;
            this.atk_body_RadioButton.TabStop = true;
            this.atk_body_RadioButton.Text = "центральная часть";
            this.atk_body_RadioButton.UseVisualStyleBackColor = true;
            this.atk_body_RadioButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // Atttack_lbl
            // 
            this.Atttack_lbl.AutoSize = true;
            this.Atttack_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Atttack_lbl.Location = new System.Drawing.Point(3, 7);
            this.Atttack_lbl.Name = "Atttack_lbl";
            this.Atttack_lbl.Size = new System.Drawing.Size(52, 21);
            this.Atttack_lbl.TabIndex = 7;
            this.Atttack_lbl.Text = "Атака";
            // 
            // atk_head_RadioButton
            // 
            this.atk_head_RadioButton.AutoSize = true;
            this.atk_head_RadioButton.Location = new System.Drawing.Point(3, 31);
            this.atk_head_RadioButton.Name = "atk_head_RadioButton";
            this.atk_head_RadioButton.Size = new System.Drawing.Size(100, 17);
            this.atk_head_RadioButton.TabIndex = 0;
            this.atk_head_RadioButton.TabStop = true;
            this.atk_head_RadioButton.Text = "верхняя часть";
            this.atk_head_RadioButton.UseVisualStyleBackColor = true;
            this.atk_head_RadioButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // def_panel
            // 
            this.def_panel.Controls.Add(this.def_legs_RadioButton);
            this.def_panel.Controls.Add(this.def_body_RadioButton);
            this.def_panel.Controls.Add(this.def_head_RadioButton);
            this.def_panel.Controls.Add(this.Defence_lbl);
            this.def_panel.Location = new System.Drawing.Point(146, 335);
            this.def_panel.Name = "def_panel";
            this.def_panel.Size = new System.Drawing.Size(134, 97);
            this.def_panel.TabIndex = 5;
            // 
            // def_legs_RadioButton
            // 
            this.def_legs_RadioButton.AutoSize = true;
            this.def_legs_RadioButton.Location = new System.Drawing.Point(3, 77);
            this.def_legs_RadioButton.Name = "def_legs_RadioButton";
            this.def_legs_RadioButton.Size = new System.Drawing.Size(98, 17);
            this.def_legs_RadioButton.TabIndex = 0;
            this.def_legs_RadioButton.TabStop = true;
            this.def_legs_RadioButton.Text = "нижняя часть";
            this.def_legs_RadioButton.UseVisualStyleBackColor = true;
            this.def_legs_RadioButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // def_body_RadioButton
            // 
            this.def_body_RadioButton.AutoSize = true;
            this.def_body_RadioButton.Location = new System.Drawing.Point(3, 54);
            this.def_body_RadioButton.Name = "def_body_RadioButton";
            this.def_body_RadioButton.Size = new System.Drawing.Size(125, 17);
            this.def_body_RadioButton.TabIndex = 0;
            this.def_body_RadioButton.TabStop = true;
            this.def_body_RadioButton.Text = "центральная часть";
            this.def_body_RadioButton.UseVisualStyleBackColor = true;
            this.def_body_RadioButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // def_head_RadioButton
            // 
            this.def_head_RadioButton.AutoSize = true;
            this.def_head_RadioButton.Location = new System.Drawing.Point(3, 31);
            this.def_head_RadioButton.Name = "def_head_RadioButton";
            this.def_head_RadioButton.Size = new System.Drawing.Size(100, 17);
            this.def_head_RadioButton.TabIndex = 0;
            this.def_head_RadioButton.TabStop = true;
            this.def_head_RadioButton.Text = "верхняя часть";
            this.def_head_RadioButton.UseVisualStyleBackColor = true;
            this.def_head_RadioButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // Defence_lbl
            // 
            this.Defence_lbl.AutoSize = true;
            this.Defence_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Defence_lbl.Location = new System.Drawing.Point(3, 7);
            this.Defence_lbl.Name = "Defence_lbl";
            this.Defence_lbl.Size = new System.Drawing.Size(66, 21);
            this.Defence_lbl.TabIndex = 6;
            this.Defence_lbl.Text = "Защита";
            // 
            // continue_btn
            // 
            this.continue_btn.BackColor = System.Drawing.Color.Gray;
            this.continue_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.continue_btn.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold);
            this.continue_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.continue_btn.Location = new System.Drawing.Point(286, 343);
            this.continue_btn.Name = "continue_btn";
            this.continue_btn.Size = new System.Drawing.Size(203, 88);
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
            this.enemies_list.FormattingEnabled = true;
            this.enemies_list.Location = new System.Drawing.Point(2, 25);
            this.enemies_list.Name = "enemies_list";
            this.enemies_list.Size = new System.Drawing.Size(147, 67);
            this.enemies_list.TabIndex = 9;
            // 
            // enemies_list_lbl
            // 
            this.enemies_list_lbl.AutoSize = true;
            this.enemies_list_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enemies_list_lbl.Location = new System.Drawing.Point(2, 1);
            this.enemies_list_lbl.Name = "enemies_list_lbl";
            this.enemies_list_lbl.Size = new System.Drawing.Size(103, 21);
            this.enemies_list_lbl.TabIndex = 7;
            this.enemies_list_lbl.Text = "Выбор цели";
            // 
            // turn_panel
            // 
            this.turn_panel.Controls.Add(this.enemies_list_lbl);
            this.turn_panel.Controls.Add(this.enemies_list);
            this.turn_panel.Controls.Add(this.atk_Button);
            this.turn_panel.Location = new System.Drawing.Point(493, 339);
            this.turn_panel.Name = "turn_panel";
            this.turn_panel.Size = new System.Drawing.Size(295, 104);
            this.turn_panel.TabIndex = 10;
            // 
            // Main_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

