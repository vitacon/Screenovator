
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;

namespace Screenovator
{
    partial class FormMain
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            // check for unsaved changes
            if (screenplay.unsaved == true)
            {
                var result = MessageBox.Show(localization.UnsavedChangesQuestion, localization.UnsavedChangesCaption,  MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                // If the no button was pressed ...
                if (result == DialogResult.No)
                    // cancel the closure of the main form.
                    return;
            }

            // update and save config
            conf.latestfilename = screenplay.filename;
            conf.windowstate = this.WindowState;
            conf.location = this.Location;
            conf.size = this.Size;
            conf.splitterdistance = splitContainer_scenes.SplitterDistance;
            conf.displayname = checkBox_showname.Checked;
            conf.displayheading = checkBox_showheading.Checked;
            conf.heighttype = comboBox_panelheight.SelectedIndex;

            conf.SaveXMLConfig();
            //
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.splitContainer_scenes = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel_scenes_main = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel_scenes_options = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBox_showname = new System.Windows.Forms.CheckBox();
            this.checkBox_showheading = new System.Windows.Forms.CheckBox();
            this.comboBox_panelheight = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel_scenes_list = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_add = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label_addscene = new System.Windows.Forms.Label();
            this.label_pos = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.button_deletescene = new System.Windows.Forms.Button();
            this.flowLayoutPanel_characters = new System.Windows.Forms.FlowLayoutPanel();
            this.label_character_karel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_color = new System.Windows.Forms.Button();
            this.textBox_heading = new System.Windows.Forms.TextBox();
            this.textBox_scenename = new System.Windows.Forms.TextBox();
            this.label_scenenumber = new System.Windows.Forms.Label();
            this.label_info = new System.Windows.Forms.Label();
            this.richTextBox_scene = new System.Windows.Forms.RichTextBox();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl_categories = new System.Windows.Forms.TabControl();
            this.tabScenes = new System.Windows.Forms.TabPage();
            this.tabCharacters = new System.Windows.Forms.TabPage();
            this.tabExport = new System.Windows.Forms.TabPage();
            this.label_namefile = new System.Windows.Forms.Label();
            this.label_namescreenplay = new System.Windows.Forms.Label();
            this.textBox_namefile = new System.Windows.Forms.TextBox();
            this.textBox_namescreenplay = new System.Windows.Forms.TextBox();
            this.button_print = new System.Windows.Forms.Button();
            this.button_export = new System.Windows.Forms.Button();
            this.textBox_export = new System.Windows.Forms.TextBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_scenes)).BeginInit();
            this.splitContainer_scenes.Panel1.SuspendLayout();
            this.splitContainer_scenes.Panel2.SuspendLayout();
            this.splitContainer_scenes.SuspendLayout();
            this.flowLayoutPanel_scenes_main.SuspendLayout();
            this.flowLayoutPanel_scenes_options.SuspendLayout();
            this.flowLayoutPanel_scenes_list.SuspendLayout();
            this.panel_add.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.flowLayoutPanel_characters.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            this.tabControl_categories.SuspendLayout();
            this.tabScenes.SuspendLayout();
            this.tabExport.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer_scenes
            // 
            this.splitContainer_scenes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            resources.ApplyResources(this.splitContainer_scenes, "splitContainer_scenes");
            this.splitContainer_scenes.Name = "splitContainer_scenes";
            // 
            // splitContainer_scenes.Panel1
            // 
            this.splitContainer_scenes.Panel1.Controls.Add(this.flowLayoutPanel_scenes_main);
            this.splitContainer_scenes.Panel1.Resize += new System.EventHandler(this.splitContainer_Panel1_Resize);
            // 
            // splitContainer_scenes.Panel2
            // 
            resources.ApplyResources(this.splitContainer_scenes.Panel2, "splitContainer_scenes.Panel2");
            this.splitContainer_scenes.Panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer_scenes.Panel2.Controls.Add(this.label_pos);
            this.splitContainer_scenes.Panel2.Controls.Add(this.panelHeader);
            this.splitContainer_scenes.Panel2.Controls.Add(this.label_info);
            this.splitContainer_scenes.Panel2.Controls.Add(this.richTextBox_scene);
            // 
            // flowLayoutPanel_scenes_main
            // 
            resources.ApplyResources(this.flowLayoutPanel_scenes_main, "flowLayoutPanel_scenes_main");
            this.flowLayoutPanel_scenes_main.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel_scenes_main.Controls.Add(this.flowLayoutPanel_scenes_options);
            this.flowLayoutPanel_scenes_main.Controls.Add(this.flowLayoutPanel_scenes_list);
            this.flowLayoutPanel_scenes_main.Name = "flowLayoutPanel_scenes_main";
            this.flowLayoutPanel_scenes_main.Resize += new System.EventHandler(this.flowLayoutPanel_scenes_main_Resize);
            // 
            // flowLayoutPanel_scenes_options
            // 
            resources.ApplyResources(this.flowLayoutPanel_scenes_options, "flowLayoutPanel_scenes_options");
            this.flowLayoutPanel_scenes_options.Controls.Add(this.checkBox_showname);
            this.flowLayoutPanel_scenes_options.Controls.Add(this.checkBox_showheading);
            this.flowLayoutPanel_scenes_options.Controls.Add(this.comboBox_panelheight);
            this.flowLayoutPanel_scenes_options.Name = "flowLayoutPanel_scenes_options";
            // 
            // checkBox_showname
            // 
            resources.ApplyResources(this.checkBox_showname, "checkBox_showname");
            this.checkBox_showname.Checked = true;
            this.checkBox_showname.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_showname.Name = "checkBox_showname";
            this.checkBox_showname.UseVisualStyleBackColor = true;
            this.checkBox_showname.CheckedChanged += new System.EventHandler(this.checkBox_showname_CheckedChanged);
            // 
            // checkBox_showheading
            // 
            resources.ApplyResources(this.checkBox_showheading, "checkBox_showheading");
            this.checkBox_showheading.Checked = true;
            this.checkBox_showheading.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_showheading.Name = "checkBox_showheading";
            this.checkBox_showheading.UseVisualStyleBackColor = true;
            this.checkBox_showheading.CheckedChanged += new System.EventHandler(this.checkBox_showheading_CheckedChanged);
            // 
            // comboBox_panelheight
            // 
            this.comboBox_panelheight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_panelheight.FormattingEnabled = true;
            this.comboBox_panelheight.Items.AddRange(new object[] {
            resources.GetString("comboBox_panelheight.Items"),
            resources.GetString("comboBox_panelheight.Items1"),
            resources.GetString("comboBox_panelheight.Items2")});
            resources.ApplyResources(this.comboBox_panelheight, "comboBox_panelheight");
            this.comboBox_panelheight.Name = "comboBox_panelheight";
            this.comboBox_panelheight.SelectedIndexChanged += new System.EventHandler(this.comboBox_panelheight_SelectedIndexChanged);
            // 
            // flowLayoutPanel_scenes_list
            // 
            resources.ApplyResources(this.flowLayoutPanel_scenes_list, "flowLayoutPanel_scenes_list");
            this.flowLayoutPanel_scenes_list.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel_scenes_list.Controls.Add(this.panel_add);
            this.flowLayoutPanel_scenes_list.Name = "flowLayoutPanel_scenes_list";
            this.flowLayoutPanel_scenes_list.Resize += new System.EventHandler(this.flowLayoutPanel_scenelist_Resize);
            // 
            // panel_add
            // 
            this.panel_add.AllowDrop = true;
            this.panel_add.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_add.Controls.Add(this.label9);
            this.panel_add.Controls.Add(this.label_addscene);
            resources.ApplyResources(this.panel_add, "panel_add");
            this.panel_add.Name = "panel_add";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label_addscene
            // 
            resources.ApplyResources(this.label_addscene, "label_addscene");
            this.label_addscene.Name = "label_addscene";
            this.label_addscene.Click += new System.EventHandler(this.label_addscene_Click);
            // 
            // label_pos
            // 
            resources.ApplyResources(this.label_pos, "label_pos");
            this.label_pos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label_pos.Name = "label_pos";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelHeader.Controls.Add(this.button_deletescene);
            this.panelHeader.Controls.Add(this.flowLayoutPanel_characters);
            this.panelHeader.Controls.Add(this.button_color);
            this.panelHeader.Controls.Add(this.textBox_heading);
            this.panelHeader.Controls.Add(this.textBox_scenename);
            this.panelHeader.Controls.Add(this.label_scenenumber);
            resources.ApplyResources(this.panelHeader, "panelHeader");
            this.panelHeader.Name = "panelHeader";
            // 
            // button_deletescene
            // 
            resources.ApplyResources(this.button_deletescene, "button_deletescene");
            this.button_deletescene.Name = "button_deletescene";
            this.button_deletescene.UseVisualStyleBackColor = true;
            this.button_deletescene.Click += new System.EventHandler(this.button_deletescene_Click);
            // 
            // flowLayoutPanel_characters
            // 
            this.flowLayoutPanel_characters.Controls.Add(this.label_character_karel);
            this.flowLayoutPanel_characters.Controls.Add(this.label2);
            resources.ApplyResources(this.flowLayoutPanel_characters, "flowLayoutPanel_characters");
            this.flowLayoutPanel_characters.Name = "flowLayoutPanel_characters";
            // 
            // label_character_karel
            // 
            resources.ApplyResources(this.label_character_karel, "label_character_karel");
            this.label_character_karel.BackColor = System.Drawing.Color.White;
            this.label_character_karel.ForeColor = System.Drawing.Color.DarkRed;
            this.label_character_karel.Name = "label_character_karel";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Name = "label2";
            // 
            // button_color
            // 
            resources.ApplyResources(this.button_color, "button_color");
            this.button_color.Name = "button_color";
            this.button_color.UseVisualStyleBackColor = true;
            this.button_color.Click += new System.EventHandler(this.button_color_Click);
            // 
            // textBox_heading
            // 
            this.textBox_heading.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            resources.ApplyResources(this.textBox_heading, "textBox_heading");
            this.textBox_heading.Name = "textBox_heading";
            this.textBox_heading.TextChanged += new System.EventHandler(this.textBox_heading_TextChanged);
            this.textBox_heading.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_heading_KeyDown);
            // 
            // textBox_scenename
            // 
            resources.ApplyResources(this.textBox_scenename, "textBox_scenename");
            this.textBox_scenename.Name = "textBox_scenename";
            this.textBox_scenename.TextChanged += new System.EventHandler(this.textBox_scenename_TextChanged);
            this.textBox_scenename.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_scenename_KeyDown);
            // 
            // label_scenenumber
            // 
            this.label_scenenumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.label_scenenumber, "label_scenenumber");
            this.label_scenenumber.Name = "label_scenenumber";
            // 
            // label_info
            // 
            resources.ApplyResources(this.label_info, "label_info");
            this.label_info.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label_info.Name = "label_info";
            // 
            // richTextBox_scene
            // 
            this.richTextBox_scene.AcceptsTab = true;
            resources.ApplyResources(this.richTextBox_scene, "richTextBox_scene");
            this.richTextBox_scene.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_scene.Name = "richTextBox_scene";
            this.richTextBox_scene.TextChanged += new System.EventHandler(this.richTextBox_scene_TextChanged);
            this.richTextBox_scene.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox1_KeyDown);
            this.richTextBox_scene.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox_KeyPress);
            this.richTextBox_scene.KeyUp += new System.Windows.Forms.KeyEventHandler(this.richTextBox_KeyUp);
            this.richTextBox_scene.MouseUp += new System.Windows.Forms.MouseEventHandler(this.richTextBox_MouseUp);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            resources.ApplyResources(this.mainMenuStrip, "mainMenuStrip");
            this.mainMenuStrip.Name = "mainMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            resources.ApplyResources(this.newToolStripMenuItem, "newToolStripMenuItem");
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            resources.ApplyResources(this.saveAsToolStripMenuItem, "saveAsToolStripMenuItem");
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tabControl_categories
            // 
            resources.ApplyResources(this.tabControl_categories, "tabControl_categories");
            this.tabControl_categories.Controls.Add(this.tabScenes);
            this.tabControl_categories.Controls.Add(this.tabCharacters);
            this.tabControl_categories.Controls.Add(this.tabExport);
            this.tabControl_categories.Name = "tabControl_categories";
            this.tabControl_categories.SelectedIndex = 0;
            this.tabControl_categories.SelectedIndexChanged += new System.EventHandler(this.tabControl_scenes_SelectedIndexChanged);
            // 
            // tabScenes
            // 
            this.tabScenes.AllowDrop = true;
            this.tabScenes.Controls.Add(this.splitContainer_scenes);
            resources.ApplyResources(this.tabScenes, "tabScenes");
            this.tabScenes.Name = "tabScenes";
            this.tabScenes.UseVisualStyleBackColor = true;
            // 
            // tabCharacters
            // 
            resources.ApplyResources(this.tabCharacters, "tabCharacters");
            this.tabCharacters.Name = "tabCharacters";
            this.tabCharacters.UseVisualStyleBackColor = true;
            // 
            // tabExport
            // 
            this.tabExport.Controls.Add(this.label_namefile);
            this.tabExport.Controls.Add(this.label_namescreenplay);
            this.tabExport.Controls.Add(this.textBox_namefile);
            this.tabExport.Controls.Add(this.textBox_namescreenplay);
            this.tabExport.Controls.Add(this.button_print);
            this.tabExport.Controls.Add(this.button_export);
            this.tabExport.Controls.Add(this.textBox_export);
            resources.ApplyResources(this.tabExport, "tabExport");
            this.tabExport.Name = "tabExport";
            this.tabExport.UseVisualStyleBackColor = true;
            // 
            // label_namefile
            // 
            resources.ApplyResources(this.label_namefile, "label_namefile");
            this.label_namefile.Name = "label_namefile";
            // 
            // label_namescreenplay
            // 
            resources.ApplyResources(this.label_namescreenplay, "label_namescreenplay");
            this.label_namescreenplay.Name = "label_namescreenplay";
            // 
            // textBox_namefile
            // 
            resources.ApplyResources(this.textBox_namefile, "textBox_namefile");
            this.textBox_namefile.Name = "textBox_namefile";
            this.textBox_namefile.ReadOnly = true;
            this.textBox_namefile.TextChanged += new System.EventHandler(this.textBox_namefile_TextChanged);
            // 
            // textBox_namescreenplay
            // 
            resources.ApplyResources(this.textBox_namescreenplay, "textBox_namescreenplay");
            this.textBox_namescreenplay.Name = "textBox_namescreenplay";
            this.textBox_namescreenplay.TextChanged += new System.EventHandler(this.textBox_namescreenplay_TextChanged);
            // 
            // button_print
            // 
            resources.ApplyResources(this.button_print, "button_print");
            this.button_print.Name = "button_print";
            this.button_print.UseVisualStyleBackColor = true;
            this.button_print.Click += new System.EventHandler(this.button_print_Click);
            // 
            // button_export
            // 
            resources.ApplyResources(this.button_export, "button_export");
            this.button_export.Name = "button_export";
            this.button_export.UseVisualStyleBackColor = true;
            this.button_export.Click += new System.EventHandler(this.button_ExportToFile_Click);
            // 
            // textBox_export
            // 
            resources.ApplyResources(this.textBox_export, "textBox_export");
            this.textBox_export.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_export.Name = "textBox_export";
            this.textBox_export.ReadOnly = true;
            // 
            // colorDialog
            // 
            this.colorDialog.AnyColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "scrxml";
            resources.ApplyResources(this.openFileDialog, "openFileDialog");
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "scrxml";
            resources.ApplyResources(this.saveFileDialog, "saveFileDialog");
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl_categories);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "FormMain";
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.splitContainer_scenes.Panel1.ResumeLayout(false);
            this.splitContainer_scenes.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_scenes)).EndInit();
            this.splitContainer_scenes.ResumeLayout(false);
            this.flowLayoutPanel_scenes_main.ResumeLayout(false);
            this.flowLayoutPanel_scenes_main.PerformLayout();
            this.flowLayoutPanel_scenes_options.ResumeLayout(false);
            this.flowLayoutPanel_scenes_options.PerformLayout();
            this.flowLayoutPanel_scenes_list.ResumeLayout(false);
            this.panel_add.ResumeLayout(false);
            this.panel_add.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.flowLayoutPanel_characters.ResumeLayout(false);
            this.flowLayoutPanel_characters.PerformLayout();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.tabControl_categories.ResumeLayout(false);
            this.tabScenes.ResumeLayout(false);
            this.tabExport.ResumeLayout(false);
            this.tabExport.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.TextBox textBox_heading;
        private System.Windows.Forms.RichTextBox richTextBox_scene;
        private System.Windows.Forms.TextBox textBox_scenename;
        private System.Windows.Forms.Label label_scenenumber;
        private System.Windows.Forms.SplitContainer splitContainer_scenes;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.Button button_color;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.TabControl tabControl_categories;
        private System.Windows.Forms.TabPage tabScenes;
        private System.Windows.Forms.TabPage tabCharacters;
        private System.Windows.Forms.TabPage tabExport;
        private System.Windows.Forms.Label label_pos;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_scenes_options;
        private System.Windows.Forms.CheckBox checkBox_showname;
        private System.Windows.Forms.Panel panel_add;
        private System.Windows.Forms.Label label_addscene;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_scenes_list;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_characters;
        private System.Windows.Forms.Label label_character_karel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_export;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_scenes_main;
        private System.Windows.Forms.CheckBox checkBox_showheading;
        private System.Windows.Forms.Button button_export;
        private System.Windows.Forms.Button button_print;
        private System.Windows.Forms.TextBox textBox_namefile;
        private System.Windows.Forms.TextBox textBox_namescreenplay;
        private System.Windows.Forms.Label label_namefile;
        private System.Windows.Forms.Label label_namescreenplay;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button button_deletescene;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private ComboBox comboBox_panelheight;
    }
}

