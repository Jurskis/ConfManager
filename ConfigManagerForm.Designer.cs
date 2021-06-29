namespace ConfManager
{
    partial class ConfigManagerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_configFilesWindow = new System.Windows.Forms.ListBox();
            this.lv_configsWindow = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.Value = new System.Windows.Forms.ColumnHeader();
            this.rtb_outputWindow = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_showAllConfigs = new System.Windows.Forms.Button();
            this.btn_searchConfig = new System.Windows.Forms.Button();
            this.tb_config = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_configFilesWindow
            // 
            this.lb_configFilesWindow.FormattingEnabled = true;
            this.lb_configFilesWindow.HorizontalScrollbar = true;
            this.lb_configFilesWindow.ItemHeight = 15;
            this.lb_configFilesWindow.Location = new System.Drawing.Point(12, 30);
            this.lb_configFilesWindow.Name = "lb_configFilesWindow";
            this.lb_configFilesWindow.Size = new System.Drawing.Size(148, 259);
            this.lb_configFilesWindow.TabIndex = 0;
            // 
            // lv_configsWindow
            // 
            this.lv_configsWindow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Value});
            this.lv_configsWindow.HideSelection = false;
            this.lv_configsWindow.Location = new System.Drawing.Point(186, 30);
            this.lv_configsWindow.Name = "lv_configsWindow";
            this.lv_configsWindow.Size = new System.Drawing.Size(546, 259);
            this.lv_configsWindow.TabIndex = 1;
            this.lv_configsWindow.UseCompatibleStateImageBehavior = false;
            this.lv_configsWindow.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 150;
            // 
            // Value
            // 
            this.Value.Text = "Value";
            this.Value.Width = 150;
            // 
            // rtb_outputWindow
            // 
            this.rtb_outputWindow.Location = new System.Drawing.Point(12, 350);
            this.rtb_outputWindow.Name = "rtb_outputWindow";
            this.rtb_outputWindow.Size = new System.Drawing.Size(720, 121);
            this.rtb_outputWindow.TabIndex = 3;
            this.rtb_outputWindow.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Output";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Config Files";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Configs";
            // 
            // btn_showAllConfigs
            // 
            this.btn_showAllConfigs.Location = new System.Drawing.Point(657, 295);
            this.btn_showAllConfigs.Name = "btn_showAllConfigs";
            this.btn_showAllConfigs.Size = new System.Drawing.Size(75, 23);
            this.btn_showAllConfigs.TabIndex = 7;
            this.btn_showAllConfigs.Text = "Show All";
            this.btn_showAllConfigs.UseVisualStyleBackColor = true;
            this.btn_showAllConfigs.Click += new System.EventHandler(this.btn_showAllConfigs_Click);
            // 
            // btn_searchConfig
            // 
            this.btn_searchConfig.Location = new System.Drawing.Point(186, 295);
            this.btn_searchConfig.Name = "btn_searchConfig";
            this.btn_searchConfig.Size = new System.Drawing.Size(75, 23);
            this.btn_searchConfig.TabIndex = 8;
            this.btn_searchConfig.Text = "Search";
            this.btn_searchConfig.UseVisualStyleBackColor = true;
            this.btn_searchConfig.Click += new System.EventHandler(this.btn_searchConfig_Click);
            // 
            // tb_config
            // 
            this.tb_config.Location = new System.Drawing.Point(267, 296);
            this.tb_config.Name = "tb_config";
            this.tb_config.Size = new System.Drawing.Size(150, 23);
            this.tb_config.TabIndex = 9;
            // 
            // ConfigManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 483);
            this.Controls.Add(this.tb_config);
            this.Controls.Add(this.btn_searchConfig);
            this.Controls.Add(this.btn_showAllConfigs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtb_outputWindow);
            this.Controls.Add(this.lv_configsWindow);
            this.Controls.Add(this.lb_configFilesWindow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ConfigManager";
            this.Text = "Config Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_configFilesWindow;
        private System.Windows.Forms.ListView lv_configsWindow;
        private System.Windows.Forms.RichTextBox rtb_outputWindow;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Value;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_showAllConfigs;
        private System.Windows.Forms.Button btn_searchConfig;
        private System.Windows.Forms.TextBox tb_config;
    }
}

