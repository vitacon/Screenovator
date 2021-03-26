
namespace Screenovator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fgdgfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.freeScreenwritingAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox_scene = new System.Windows.Forms.RichTextBox();
            this.textBox_heading = new System.Windows.Forms.TextBox();
            this.textBox_scenename = new System.Windows.Forms.TextBox();
            this.label_scenenumber = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.button_deletescene = new System.Windows.Forms.Button();
            this.flowLayoutPanel_characters = new System.Windows.Forms.FlowLayoutPanel();
            this.label_character_karel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_color = new System.Windows.Forms.Button();
            this.splitContainer_scenes = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel_scenes_main = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel_scenes_options = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBox_showname = new System.Windows.Forms.CheckBox();
            this.checkBox_showheading = new System.Windows.Forms.CheckBox();
            this.checkBox_relativeheight = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel_scenes_list = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_add = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label_addscene = new System.Windows.Forms.Label();
            this.label_pos = new System.Windows.Forms.Label();
            this.label_info = new System.Windows.Forms.Label();
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.flowLayoutPanel_characters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_scenes)).BeginInit();
            this.splitContainer_scenes.Panel1.SuspendLayout();
            this.splitContainer_scenes.Panel2.SuspendLayout();
            this.splitContainer_scenes.SuspendLayout();
            this.flowLayoutPanel_scenes_main.SuspendLayout();
            this.flowLayoutPanel_scenes_options.SuspendLayout();
            this.flowLayoutPanel_scenes_list.SuspendLayout();
            this.panel_add.SuspendLayout();
            this.tabControl_categories.SuspendLayout();
            this.tabScenes.SuspendLayout();
            this.tabExport.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fgdgfToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(919, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fgdgfToolStripMenuItem
            // 
            this.fgdgfToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.importToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fgdgfToolStripMenuItem.Name = "fgdgfToolStripMenuItem";
            this.fgdgfToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fgdgfToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.freeScreenwritingAppToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // freeScreenwritingAppToolStripMenuItem
            // 
            this.freeScreenwritingAppToolStripMenuItem.Name = "freeScreenwritingAppToolStripMenuItem";
            this.freeScreenwritingAppToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.freeScreenwritingAppToolStripMenuItem.Text = "Free screenwriting app.";
            // 
            // richTextBox_scene
            // 
            this.richTextBox_scene.AcceptsTab = true;
            this.richTextBox_scene.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBox_scene.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_scene.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.richTextBox_scene.Location = new System.Drawing.Point(4, 100);
            this.richTextBox_scene.Margin = new System.Windows.Forms.Padding(0);
            this.richTextBox_scene.Name = "richTextBox_scene";
            this.richTextBox_scene.Size = new System.Drawing.Size(638, 426);
            this.richTextBox_scene.TabIndex = 1;
            this.richTextBox_scene.Text = "";
            this.richTextBox_scene.TextChanged += new System.EventHandler(this.richTextBox_scene_TextChanged);
            this.richTextBox_scene.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox1_KeyDown);
            this.richTextBox_scene.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox_KeyPress);
            this.richTextBox_scene.KeyUp += new System.Windows.Forms.KeyEventHandler(this.richTextBox_KeyUp);
            this.richTextBox_scene.MouseUp += new System.Windows.Forms.MouseEventHandler(this.richTextBox_MouseUp);
            // 
            // textBox_heading
            // 
            this.textBox_heading.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_heading.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_heading.Location = new System.Drawing.Point(8, 60);
            this.textBox_heading.Name = "textBox_heading";
            this.textBox_heading.Size = new System.Drawing.Size(625, 26);
            this.textBox_heading.TabIndex = 4;
            this.textBox_heading.Text = "EXT. PŘED DOMEM - DEN";
            this.textBox_heading.TextChanged += new System.EventHandler(this.textBox_heading_TextChanged);
            this.textBox_heading.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_heading_KeyDown);
            // 
            // textBox_scenename
            // 
            this.textBox_scenename.Location = new System.Drawing.Point(77, 8);
            this.textBox_scenename.Name = "textBox_scenename";
            this.textBox_scenename.Size = new System.Drawing.Size(500, 20);
            this.textBox_scenename.TabIndex = 3;
            this.textBox_scenename.Text = "Name of the scene";
            this.textBox_scenename.TextChanged += new System.EventHandler(this.textBox_scenename_TextChanged);
            this.textBox_scenename.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_scenename_KeyDown);
            // 
            // label_scenenumber
            // 
            this.label_scenenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_scenenumber.Location = new System.Drawing.Point(8, 2);
            this.label_scenenumber.Name = "label_scenenumber";
            this.label_scenenumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_scenenumber.Size = new System.Drawing.Size(55, 52);
            this.label_scenenumber.TabIndex = 2;
            this.label_scenenumber.Text = "1";
            this.label_scenenumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.panelHeader.Location = new System.Drawing.Point(3, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(640, 94);
            this.panelHeader.TabIndex = 2;
            // 
            // button_deletescene
            // 
            this.button_deletescene.Location = new System.Drawing.Point(583, 32);
            this.button_deletescene.Name = "button_deletescene";
            this.button_deletescene.Size = new System.Drawing.Size(50, 23);
            this.button_deletescene.TabIndex = 7;
            this.button_deletescene.Text = "Delete";
            this.button_deletescene.UseVisualStyleBackColor = true;
            this.button_deletescene.Click += new System.EventHandler(this.button_deletescene_Click);
            // 
            // flowLayoutPanel_characters
            // 
            this.flowLayoutPanel_characters.Controls.Add(this.label_character_karel);
            this.flowLayoutPanel_characters.Controls.Add(this.label2);
            this.flowLayoutPanel_characters.Location = new System.Drawing.Point(77, 34);
            this.flowLayoutPanel_characters.Name = "flowLayoutPanel_characters";
            this.flowLayoutPanel_characters.Size = new System.Drawing.Size(500, 20);
            this.flowLayoutPanel_characters.TabIndex = 6;
            // 
            // label_character_karel
            // 
            this.label_character_karel.AutoSize = true;
            this.label_character_karel.BackColor = System.Drawing.Color.White;
            this.label_character_karel.ForeColor = System.Drawing.Color.DarkRed;
            this.label_character_karel.Location = new System.Drawing.Point(0, 0);
            this.label_character_karel.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label_character_karel.MinimumSize = new System.Drawing.Size(20, 18);
            this.label_character_karel.Name = "label_character_karel";
            this.label_character_karel.Size = new System.Drawing.Size(42, 18);
            this.label_character_karel.TabIndex = 0;
            this.label_character_karel.Text = "KAREL";
            this.label_character_karel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(45, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.MinimumSize = new System.Drawing.Size(20, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "JOSEF";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_color
            // 
            this.button_color.Location = new System.Drawing.Point(583, 6);
            this.button_color.Name = "button_color";
            this.button_color.Size = new System.Drawing.Size(50, 23);
            this.button_color.TabIndex = 5;
            this.button_color.Text = "Color";
            this.button_color.UseVisualStyleBackColor = true;
            this.button_color.Click += new System.EventHandler(this.button_color_Click);
            // 
            // splitContainer_scenes
            // 
            this.splitContainer_scenes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer_scenes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.splitContainer_scenes.Location = new System.Drawing.Point(3, 3);
            this.splitContainer_scenes.Name = "splitContainer_scenes";
            // 
            // splitContainer_scenes.Panel1
            // 
            this.splitContainer_scenes.Panel1.Controls.Add(this.flowLayoutPanel_scenes_main);
            this.splitContainer_scenes.Panel1.Resize += new System.EventHandler(this.splitContainer_Panel1_Resize);
            // 
            // splitContainer_scenes.Panel2
            // 
            this.splitContainer_scenes.Panel2.AutoScroll = true;
            this.splitContainer_scenes.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer_scenes.Panel2.Controls.Add(this.label_pos);
            this.splitContainer_scenes.Panel2.Controls.Add(this.panelHeader);
            this.splitContainer_scenes.Panel2.Controls.Add(this.label_info);
            this.splitContainer_scenes.Panel2.Controls.Add(this.richTextBox_scene);
            this.splitContainer_scenes.Panel2.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.splitContainer_scenes.Size = new System.Drawing.Size(912, 548);
            this.splitContainer_scenes.SplitterDistance = 255;
            this.splitContainer_scenes.SplitterWidth = 9;
            this.splitContainer_scenes.TabIndex = 2;
            // 
            // flowLayoutPanel_scenes_main
            // 
            this.flowLayoutPanel_scenes_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel_scenes_main.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel_scenes_main.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel_scenes_main.Controls.Add(this.flowLayoutPanel_scenes_options);
            this.flowLayoutPanel_scenes_main.Controls.Add(this.flowLayoutPanel_scenes_list);
            this.flowLayoutPanel_scenes_main.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel_scenes_main.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel_scenes_main.Name = "flowLayoutPanel_scenes_main";
            this.flowLayoutPanel_scenes_main.Size = new System.Drawing.Size(255, 548);
            this.flowLayoutPanel_scenes_main.TabIndex = 7;
            // 
            // flowLayoutPanel_scenes_options
            // 
            this.flowLayoutPanel_scenes_options.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel_scenes_options.AutoSize = true;
            this.flowLayoutPanel_scenes_options.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel_scenes_options.Controls.Add(this.checkBox_showname);
            this.flowLayoutPanel_scenes_options.Controls.Add(this.checkBox_showheading);
            this.flowLayoutPanel_scenes_options.Controls.Add(this.checkBox_relativeheight);
            this.flowLayoutPanel_scenes_options.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel_scenes_options.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.flowLayoutPanel_scenes_options.Name = "flowLayoutPanel_scenes_options";
            this.flowLayoutPanel_scenes_options.Size = new System.Drawing.Size(235, 23);
            this.flowLayoutPanel_scenes_options.TabIndex = 5;
            // 
            // checkBox_showname
            // 
            this.checkBox_showname.AutoSize = true;
            this.checkBox_showname.Checked = true;
            this.checkBox_showname.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_showname.Location = new System.Drawing.Point(3, 3);
            this.checkBox_showname.Name = "checkBox_showname";
            this.checkBox_showname.Size = new System.Drawing.Size(54, 17);
            this.checkBox_showname.TabIndex = 0;
            this.checkBox_showname.Text = "Name";
            this.checkBox_showname.UseVisualStyleBackColor = true;
            this.checkBox_showname.CheckedChanged += new System.EventHandler(this.checkBox_showname_CheckedChanged);
            // 
            // checkBox_showheading
            // 
            this.checkBox_showheading.AutoSize = true;
            this.checkBox_showheading.Checked = true;
            this.checkBox_showheading.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_showheading.Location = new System.Drawing.Point(63, 3);
            this.checkBox_showheading.Name = "checkBox_showheading";
            this.checkBox_showheading.Size = new System.Drawing.Size(66, 17);
            this.checkBox_showheading.TabIndex = 2;
            this.checkBox_showheading.Text = "Heading";
            this.checkBox_showheading.UseVisualStyleBackColor = true;
            this.checkBox_showheading.CheckedChanged += new System.EventHandler(this.checkBox_showheading_CheckedChanged);
            // 
            // checkBox_relativeheight
            // 
            this.checkBox_relativeheight.AutoSize = true;
            this.checkBox_relativeheight.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_relativeheight.Location = new System.Drawing.Point(135, 3);
            this.checkBox_relativeheight.Name = "checkBox_relativeheight";
            this.checkBox_relativeheight.Size = new System.Drawing.Size(97, 17);
            this.checkBox_relativeheight.TabIndex = 1;
            this.checkBox_relativeheight.Text = "Relative height";
            this.checkBox_relativeheight.UseVisualStyleBackColor = false;
            this.checkBox_relativeheight.CheckedChanged += new System.EventHandler(this.checkBox_relativeheight_CheckedChanged);
            // 
            // flowLayoutPanel_scenes_list
            // 
            this.flowLayoutPanel_scenes_list.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel_scenes_list.AutoScroll = true;
            this.flowLayoutPanel_scenes_list.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel_scenes_list.Controls.Add(this.panel_add);
            this.flowLayoutPanel_scenes_list.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel_scenes_list.Location = new System.Drawing.Point(0, 26);
            this.flowLayoutPanel_scenes_list.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel_scenes_list.Name = "flowLayoutPanel_scenes_list";
            this.flowLayoutPanel_scenes_list.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.flowLayoutPanel_scenes_list.Size = new System.Drawing.Size(255, 522);
            this.flowLayoutPanel_scenes_list.TabIndex = 6;
            this.flowLayoutPanel_scenes_list.WrapContents = false;
            this.flowLayoutPanel_scenes_list.Resize += new System.EventHandler(this.flowLayoutPanel2_Resize);
            // 
            // panel_add
            // 
            this.panel_add.AllowDrop = true;
            this.panel_add.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_add.Controls.Add(this.label9);
            this.panel_add.Controls.Add(this.label_addscene);
            this.panel_add.Location = new System.Drawing.Point(3, 3);
            this.panel_add.Name = "panel_add";
            this.panel_add.Size = new System.Drawing.Size(232, 20);
            this.panel_add.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(3, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 14);
            this.label9.TabIndex = 5;
            this.label9.Text = "+";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_addscene
            // 
            this.label_addscene.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_addscene.AutoSize = true;
            this.label_addscene.Location = new System.Drawing.Point(30, 3);
            this.label_addscene.Margin = new System.Windows.Forms.Padding(3);
            this.label_addscene.MinimumSize = new System.Drawing.Size(20, 13);
            this.label_addscene.Name = "label_addscene";
            this.label_addscene.Size = new System.Drawing.Size(90, 13);
            this.label_addscene.TabIndex = 0;
            this.label_addscene.Text = "Add a new scene";
            this.label_addscene.Click += new System.EventHandler(this.label_addscene_Click);
            // 
            // label_pos
            // 
            this.label_pos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_pos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label_pos.Location = new System.Drawing.Point(7, 529);
            this.label_pos.Name = "label_pos";
            this.label_pos.Size = new System.Drawing.Size(92, 15);
            this.label_pos.TabIndex = 4;
            this.label_pos.Text = "XY";
            // 
            // label_info
            // 
            this.label_info.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_info.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label_info.Location = new System.Drawing.Point(105, 529);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(453, 15);
            this.label_info.TabIndex = 3;
            this.label_info.Text = "Some common info stuff";
            // 
            // tabControl_categories
            // 
            this.tabControl_categories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl_categories.Controls.Add(this.tabScenes);
            this.tabControl_categories.Controls.Add(this.tabCharacters);
            this.tabControl_categories.Controls.Add(this.tabExport);
            this.tabControl_categories.Location = new System.Drawing.Point(0, 27);
            this.tabControl_categories.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl_categories.Name = "tabControl_categories";
            this.tabControl_categories.Padding = new System.Drawing.Point(0, 0);
            this.tabControl_categories.SelectedIndex = 0;
            this.tabControl_categories.Size = new System.Drawing.Size(919, 573);
            this.tabControl_categories.TabIndex = 4;
            this.tabControl_categories.SelectedIndexChanged += new System.EventHandler(this.tabControl_scenes_SelectedIndexChanged);
            // 
            // tabScenes
            // 
            this.tabScenes.AllowDrop = true;
            this.tabScenes.Controls.Add(this.splitContainer_scenes);
            this.tabScenes.Location = new System.Drawing.Point(4, 22);
            this.tabScenes.Margin = new System.Windows.Forms.Padding(0);
            this.tabScenes.Name = "tabScenes";
            this.tabScenes.Size = new System.Drawing.Size(911, 547);
            this.tabScenes.TabIndex = 0;
            this.tabScenes.Text = "Scenes";
            this.tabScenes.UseVisualStyleBackColor = true;
            // 
            // tabCharacters
            // 
            this.tabCharacters.Location = new System.Drawing.Point(4, 22);
            this.tabCharacters.Name = "tabCharacters";
            this.tabCharacters.Padding = new System.Windows.Forms.Padding(3);
            this.tabCharacters.Size = new System.Drawing.Size(911, 547);
            this.tabCharacters.TabIndex = 1;
            this.tabCharacters.Text = "Characters";
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
            this.tabExport.Location = new System.Drawing.Point(4, 22);
            this.tabExport.Name = "tabExport";
            this.tabExport.Padding = new System.Windows.Forms.Padding(3);
            this.tabExport.Size = new System.Drawing.Size(911, 547);
            this.tabExport.TabIndex = 2;
            this.tabExport.Text = "Export";
            this.tabExport.UseVisualStyleBackColor = true;
            // 
            // label_namefile
            // 
            this.label_namefile.AutoSize = true;
            this.label_namefile.Location = new System.Drawing.Point(8, 45);
            this.label_namefile.Name = "label_namefile";
            this.label_namefile.Size = new System.Drawing.Size(81, 13);
            this.label_namefile.TabIndex = 4;
            this.label_namefile.Text = "Name of the file";
            // 
            // label_namescreenplay
            // 
            this.label_namescreenplay.AutoSize = true;
            this.label_namescreenplay.Location = new System.Drawing.Point(8, 6);
            this.label_namescreenplay.Name = "label_namescreenplay";
            this.label_namescreenplay.Size = new System.Drawing.Size(119, 13);
            this.label_namescreenplay.TabIndex = 4;
            this.label_namescreenplay.Text = "Name of the screenplay";
            // 
            // textBox_namefile
            // 
            this.textBox_namefile.Location = new System.Drawing.Point(9, 61);
            this.textBox_namefile.Name = "textBox_namefile";
            this.textBox_namefile.Size = new System.Drawing.Size(190, 20);
            this.textBox_namefile.TabIndex = 3;
            this.textBox_namefile.TextChanged += new System.EventHandler(this.textBox_namefile_TextChanged);
            // 
            // textBox_namescreenplay
            // 
            this.textBox_namescreenplay.Location = new System.Drawing.Point(9, 22);
            this.textBox_namescreenplay.Name = "textBox_namescreenplay";
            this.textBox_namescreenplay.Size = new System.Drawing.Size(190, 20);
            this.textBox_namescreenplay.TabIndex = 3;
            this.textBox_namescreenplay.TextChanged += new System.EventHandler(this.textBox_namescreenplay_TextChanged);
            // 
            // button_print
            // 
            this.button_print.Location = new System.Drawing.Point(43, 143);
            this.button_print.Name = "button_print";
            this.button_print.Size = new System.Drawing.Size(75, 23);
            this.button_print.TabIndex = 2;
            this.button_print.Text = "Print export";
            this.button_print.UseVisualStyleBackColor = true;
            this.button_print.Click += new System.EventHandler(this.button_print_Click);
            // 
            // button_export
            // 
            this.button_export.Location = new System.Drawing.Point(43, 98);
            this.button_export.Name = "button_export";
            this.button_export.Size = new System.Drawing.Size(75, 23);
            this.button_export.TabIndex = 1;
            this.button_export.Text = "Save export";
            this.button_export.UseVisualStyleBackColor = true;
            this.button_export.Click += new System.EventHandler(this.button_ExportToFile_Click);
            // 
            // textBox_export
            // 
            this.textBox_export.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_export.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_export.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_export.Location = new System.Drawing.Point(205, 6);
            this.textBox_export.Multiline = true;
            this.textBox_export.Name = "textBox_export";
            this.textBox_export.ReadOnly = true;
            this.textBox_export.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_export.Size = new System.Drawing.Size(700, 534);
            this.textBox_export.TabIndex = 0;
            this.textBox_export.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 601);
            this.Controls.Add(this.tabControl_categories);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Screenovator";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.flowLayoutPanel_characters.ResumeLayout(false);
            this.flowLayoutPanel_characters.PerformLayout();
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
            this.tabControl_categories.ResumeLayout(false);
            this.tabScenes.ResumeLayout(false);
            this.tabExport.ResumeLayout(false);
            this.tabExport.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fgdgfToolStripMenuItem;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.TextBox textBox_heading;
        private System.Windows.Forms.RichTextBox richTextBox_scene;
        private System.Windows.Forms.TextBox textBox_scenename;
        private System.Windows.Forms.Label label_scenenumber;
        private System.Windows.Forms.SplitContainer splitContainer_scenes;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.Button button_color;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TabControl tabControl_categories;
        private System.Windows.Forms.TabPage tabScenes;
        private System.Windows.Forms.TabPage tabCharacters;
        private System.Windows.Forms.TabPage tabExport;
        private System.Windows.Forms.Label label_pos;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_scenes_options;
        private System.Windows.Forms.CheckBox checkBox_showname;
        private System.Windows.Forms.CheckBox checkBox_relativeheight;
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
        private System.Windows.Forms.ToolStripMenuItem freeScreenwritingAppToolStripMenuItem;
        private System.Windows.Forms.Button button_deletescene;
    }
}

