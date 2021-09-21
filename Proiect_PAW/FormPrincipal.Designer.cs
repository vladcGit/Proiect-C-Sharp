namespace Proiect_PAW
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.adaugaEchipaBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.echipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.meciuriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vizualizareListaCompletaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.rapoarteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaMeciuriDintroZiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informatiiDespreEchipaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficulMeciurilorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbEchipe = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copiazaInClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.echipeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meciuriToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.rapoarteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaMeciuriDintroZiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.informatiiDespreEchipaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.graficulMeciurilorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.schimbaCuloareFundalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnPrevDay = new System.Windows.Forms.Button();
            this.btnNextDay = new System.Windows.Forms.Button();
            this.userControl11 = new Proiect_PAW.UserControl1();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // adaugaEchipaBtn
            // 
            this.adaugaEchipaBtn.Location = new System.Drawing.Point(29, 160);
            this.adaugaEchipaBtn.Name = "adaugaEchipaBtn";
            this.adaugaEchipaBtn.Size = new System.Drawing.Size(135, 23);
            this.adaugaEchipaBtn.TabIndex = 0;
            this.adaugaEchipaBtn.Text = "Ada&uga Echipa";
            this.adaugaEchipaBtn.UseVisualStyleBackColor = true;
            this.adaugaEchipaBtn.Click += new System.EventHandler(this.adaugaEchipaBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.echipeToolStripMenuItem,
            this.meciuriToolStripMenuItem,
            this.rapoarteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(741, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem1,
            this.deserializeToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "&File";
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.saveToolStripMenuItem1.Text = "&Serialize";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // deserializeToolStripMenuItem
            // 
            this.deserializeToolStripMenuItem.Name = "deserializeToolStripMenuItem";
            this.deserializeToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.deserializeToolStripMenuItem.Text = "&Deserialize";
            this.deserializeToolStripMenuItem.Click += new System.EventHandler(this.deserializeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.exitToolStripMenuItem1.Text = "&Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // echipeToolStripMenuItem
            // 
            this.echipeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaToolStripMenuItem,
            this.stergeToolStripMenuItem1});
            this.echipeToolStripMenuItem.Name = "echipeToolStripMenuItem";
            this.echipeToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.echipeToolStripMenuItem.Text = "&Echipe";
            // 
            // adaugaToolStripMenuItem
            // 
            this.adaugaToolStripMenuItem.Name = "adaugaToolStripMenuItem";
            this.adaugaToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.adaugaToolStripMenuItem.Text = "&Adauga";
            this.adaugaToolStripMenuItem.Click += new System.EventHandler(this.adaugaToolStripMenuItem_Click);
            // 
            // stergeToolStripMenuItem1
            // 
            this.stergeToolStripMenuItem1.Name = "stergeToolStripMenuItem1";
            this.stergeToolStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.stergeToolStripMenuItem1.Text = "&Sterge";
            this.stergeToolStripMenuItem1.Click += new System.EventHandler(this.stergeToolStripMenuItem1_Click);
            // 
            // meciuriToolStripMenuItem
            // 
            this.meciuriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaToolStripMenuItem1,
            this.modificaToolStripMenuItem,
            this.vizualizareListaCompletaToolStripMenuItem,
            this.stergeToolStripMenuItem2});
            this.meciuriToolStripMenuItem.Name = "meciuriToolStripMenuItem";
            this.meciuriToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.meciuriToolStripMenuItem.Text = "&Meciuri";
            // 
            // adaugaToolStripMenuItem1
            // 
            this.adaugaToolStripMenuItem1.Name = "adaugaToolStripMenuItem1";
            this.adaugaToolStripMenuItem1.Size = new System.Drawing.Size(206, 22);
            this.adaugaToolStripMenuItem1.Text = "&Adauga";
            this.adaugaToolStripMenuItem1.Click += new System.EventHandler(this.adaugaToolStripMenuItem1_Click);
            // 
            // modificaToolStripMenuItem
            // 
            this.modificaToolStripMenuItem.Name = "modificaToolStripMenuItem";
            this.modificaToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.modificaToolStripMenuItem.Text = "&Modifica";
            this.modificaToolStripMenuItem.Click += new System.EventHandler(this.modificaToolStripMenuItem_Click);
            // 
            // vizualizareListaCompletaToolStripMenuItem
            // 
            this.vizualizareListaCompletaToolStripMenuItem.Name = "vizualizareListaCompletaToolStripMenuItem";
            this.vizualizareListaCompletaToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.vizualizareListaCompletaToolStripMenuItem.Text = "&Vizualizare lista completa";
            this.vizualizareListaCompletaToolStripMenuItem.Click += new System.EventHandler(this.vizualizareListaCompletaToolStripMenuItem_Click);
            // 
            // stergeToolStripMenuItem2
            // 
            this.stergeToolStripMenuItem2.Name = "stergeToolStripMenuItem2";
            this.stergeToolStripMenuItem2.Size = new System.Drawing.Size(206, 22);
            this.stergeToolStripMenuItem2.Text = "&Sterge";
            this.stergeToolStripMenuItem2.Click += new System.EventHandler(this.stergeToolStripMenuItem2_Click);
            // 
            // rapoarteToolStripMenuItem
            // 
            this.rapoarteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaMeciuriDintroZiToolStripMenuItem,
            this.informatiiDespreEchipaToolStripMenuItem,
            this.graficulMeciurilorToolStripMenuItem});
            this.rapoarteToolStripMenuItem.Name = "rapoarteToolStripMenuItem";
            this.rapoarteToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.rapoarteToolStripMenuItem.Text = "&Rapoarte";
            // 
            // listaMeciuriDintroZiToolStripMenuItem
            // 
            this.listaMeciuriDintroZiToolStripMenuItem.Name = "listaMeciuriDintroZiToolStripMenuItem";
            this.listaMeciuriDintroZiToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.listaMeciuriDintroZiToolStripMenuItem.Text = "&Lista meciuri din ziua selectata";
            this.listaMeciuriDintroZiToolStripMenuItem.Click += new System.EventHandler(this.listaMeciuriDintroZiToolStripMenuItem_Click);
            // 
            // informatiiDespreEchipaToolStripMenuItem
            // 
            this.informatiiDespreEchipaToolStripMenuItem.Name = "informatiiDespreEchipaToolStripMenuItem";
            this.informatiiDespreEchipaToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.informatiiDespreEchipaToolStripMenuItem.Text = "&Informatii despre echipa";
            this.informatiiDespreEchipaToolStripMenuItem.Click += new System.EventHandler(this.informatiiDespreEchipaToolStripMenuItem_Click);
            // 
            // graficulMeciurilorToolStripMenuItem
            // 
            this.graficulMeciurilorToolStripMenuItem.Name = "graficulMeciurilorToolStripMenuItem";
            this.graficulMeciurilorToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.graficulMeciurilorToolStripMenuItem.Text = "&Graficul meciurilor";
            this.graficulMeciurilorToolStripMenuItem.Click += new System.EventHandler(this.graficulMeciurilorToolStripMenuItem_Click);
            // 
            // cbEchipe
            // 
            this.cbEchipe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEchipe.FormattingEnabled = true;
            this.cbEchipe.Location = new System.Drawing.Point(29, 120);
            this.cbEchipe.Name = "cbEchipe";
            this.cbEchipe.Size = new System.Drawing.Size(135, 21);
            this.cbEchipe.TabIndex = 4;
            this.cbEchipe.SelectedIndexChanged += new System.EventHandler(this.cbEchipe_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vizualizare Echipa";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePicker1.Location = new System.Drawing.Point(400, 45);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(202, 20);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BackColor = System.Drawing.Color.LightGreen;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.ContextMenuStrip = this.contextMenuStrip2;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(221, 83);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(527, 310);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Echipa Gazda";
            this.columnHeader1.Width = 207;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Echipa Oaspete";
            this.columnHeader2.Width = 177;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Locatie";
            this.columnHeader3.Width = 139;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiazaInClipboardToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.exportXMLToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(183, 70);
            // 
            // copiazaInClipboardToolStripMenuItem
            // 
            this.copiazaInClipboardToolStripMenuItem.Name = "copiazaInClipboardToolStripMenuItem";
            this.copiazaInClipboardToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.copiazaInClipboardToolStripMenuItem.Text = "Copiaza in clipboard";
            this.copiazaInClipboardToolStripMenuItem.Click += new System.EventHandler(this.copiazaInClipboardToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.updateToolStripMenuItem.Text = "Modifica";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.modificaToolStripMenuItem_Click);
            // 
            // exportXMLToolStripMenuItem
            // 
            this.exportXMLToolStripMenuItem.Name = "exportXMLToolStripMenuItem";
            this.exportXMLToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.exportXMLToolStripMenuItem.Text = "Export XML";
            this.exportXMLToolStripMenuItem.Click += new System.EventHandler(this.exportXMLToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.echipeToolStripMenuItem1,
            this.meciuriToolStripMenuItem1,
            this.rapoarteToolStripMenuItem1,
            this.schimbaCuloareFundalToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(204, 92);
            // 
            // echipeToolStripMenuItem1
            // 
            this.echipeToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaToolStripMenuItem2,
            this.stergeToolStripMenuItem});
            this.echipeToolStripMenuItem1.Name = "echipeToolStripMenuItem1";
            this.echipeToolStripMenuItem1.Size = new System.Drawing.Size(203, 22);
            this.echipeToolStripMenuItem1.Text = "Echipe";
            // 
            // adaugaToolStripMenuItem2
            // 
            this.adaugaToolStripMenuItem2.Name = "adaugaToolStripMenuItem2";
            this.adaugaToolStripMenuItem2.Size = new System.Drawing.Size(115, 22);
            this.adaugaToolStripMenuItem2.Text = "Adauga";
            this.adaugaToolStripMenuItem2.Click += new System.EventHandler(this.adaugaToolStripMenuItem_Click);
            // 
            // stergeToolStripMenuItem
            // 
            this.stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            this.stergeToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.stergeToolStripMenuItem.Text = "Sterge";
            this.stergeToolStripMenuItem.Click += new System.EventHandler(this.stergeToolStripMenuItem1_Click);
            // 
            // meciuriToolStripMenuItem1
            // 
            this.meciuriToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaToolStripMenuItem3,
            this.modificaToolStripMenuItem1,
            this.stergeToolStripMenuItem3});
            this.meciuriToolStripMenuItem1.Name = "meciuriToolStripMenuItem1";
            this.meciuriToolStripMenuItem1.Size = new System.Drawing.Size(203, 22);
            this.meciuriToolStripMenuItem1.Text = "Meciuri";
            // 
            // adaugaToolStripMenuItem3
            // 
            this.adaugaToolStripMenuItem3.Name = "adaugaToolStripMenuItem3";
            this.adaugaToolStripMenuItem3.Size = new System.Drawing.Size(121, 22);
            this.adaugaToolStripMenuItem3.Text = "Adauga";
            this.adaugaToolStripMenuItem3.Click += new System.EventHandler(this.adaugaToolStripMenuItem1_Click);
            // 
            // modificaToolStripMenuItem1
            // 
            this.modificaToolStripMenuItem1.Name = "modificaToolStripMenuItem1";
            this.modificaToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.modificaToolStripMenuItem1.Text = "Modifica";
            this.modificaToolStripMenuItem1.Click += new System.EventHandler(this.modificaToolStripMenuItem_Click);
            // 
            // stergeToolStripMenuItem3
            // 
            this.stergeToolStripMenuItem3.Name = "stergeToolStripMenuItem3";
            this.stergeToolStripMenuItem3.Size = new System.Drawing.Size(121, 22);
            this.stergeToolStripMenuItem3.Text = "Sterge";
            this.stergeToolStripMenuItem3.Click += new System.EventHandler(this.stergeToolStripMenuItem2_Click);
            // 
            // rapoarteToolStripMenuItem1
            // 
            this.rapoarteToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaMeciuriDintroZiToolStripMenuItem1,
            this.informatiiDespreEchipaToolStripMenuItem1,
            this.graficulMeciurilorToolStripMenuItem1});
            this.rapoarteToolStripMenuItem1.Name = "rapoarteToolStripMenuItem1";
            this.rapoarteToolStripMenuItem1.Size = new System.Drawing.Size(203, 22);
            this.rapoarteToolStripMenuItem1.Text = "Rapoarte";
            // 
            // listaMeciuriDintroZiToolStripMenuItem1
            // 
            this.listaMeciuriDintroZiToolStripMenuItem1.Name = "listaMeciuriDintroZiToolStripMenuItem1";
            this.listaMeciuriDintroZiToolStripMenuItem1.Size = new System.Drawing.Size(234, 22);
            this.listaMeciuriDintroZiToolStripMenuItem1.Text = "Lista meciuri din ziua selectata";
            this.listaMeciuriDintroZiToolStripMenuItem1.Click += new System.EventHandler(this.listaMeciuriDintroZiToolStripMenuItem_Click);
            // 
            // informatiiDespreEchipaToolStripMenuItem1
            // 
            this.informatiiDespreEchipaToolStripMenuItem1.Name = "informatiiDespreEchipaToolStripMenuItem1";
            this.informatiiDespreEchipaToolStripMenuItem1.Size = new System.Drawing.Size(234, 22);
            this.informatiiDespreEchipaToolStripMenuItem1.Text = "Informatii despre echipa";
            this.informatiiDespreEchipaToolStripMenuItem1.Click += new System.EventHandler(this.informatiiDespreEchipaToolStripMenuItem_Click);
            // 
            // graficulMeciurilorToolStripMenuItem1
            // 
            this.graficulMeciurilorToolStripMenuItem1.Name = "graficulMeciurilorToolStripMenuItem1";
            this.graficulMeciurilorToolStripMenuItem1.Size = new System.Drawing.Size(234, 22);
            this.graficulMeciurilorToolStripMenuItem1.Text = "Graficul meciurilor";
            this.graficulMeciurilorToolStripMenuItem1.Click += new System.EventHandler(this.graficulMeciurilorToolStripMenuItem_Click);
            // 
            // schimbaCuloareFundalToolStripMenuItem
            // 
            this.schimbaCuloareFundalToolStripMenuItem.Name = "schimbaCuloareFundalToolStripMenuItem";
            this.schimbaCuloareFundalToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.schimbaCuloareFundalToolStripMenuItem.Text = "Schimba Culoare Fundal";
            this.schimbaCuloareFundalToolStripMenuItem.Click += new System.EventHandler(this.schimbaCuloareFundalToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 391);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(741, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnPrevDay
            // 
            this.btnPrevDay.Location = new System.Drawing.Point(363, 42);
            this.btnPrevDay.Name = "btnPrevDay";
            this.btnPrevDay.Size = new System.Drawing.Size(31, 23);
            this.btnPrevDay.TabIndex = 10;
            this.btnPrevDay.Text = "<";
            this.btnPrevDay.UseVisualStyleBackColor = true;
            this.btnPrevDay.Click += new System.EventHandler(this.btnPrevDay_Click);
            // 
            // btnNextDay
            // 
            this.btnNextDay.Location = new System.Drawing.Point(608, 42);
            this.btnNextDay.Name = "btnNextDay";
            this.btnNextDay.Size = new System.Drawing.Size(31, 23);
            this.btnNextDay.TabIndex = 11;
            this.btnNextDay.Text = ">";
            this.btnNextDay.UseVisualStyleBackColor = true;
            this.btnNextDay.Click += new System.EventHandler(this.btnNextDay_Click);
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(12, 230);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(158, 97);
            this.userControl11.TabIndex = 12;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(741, 413);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.btnNextDay);
            this.Controls.Add(this.btnPrevDay);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbEchipe);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.adaugaEchipaBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "Aplicatie";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button adaugaEchipaBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ComboBox cbEchipe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem echipeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ToolStripMenuItem meciuriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ToolStripMenuItem rapoarteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaMeciuriDintroZiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informatiiDespreEchipaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem echipeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem adaugaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meciuriToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem adaugaToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem modificaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem rapoarteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listaMeciuriDintroZiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem informatiiDespreEchipaToolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem vizualizareListaCompletaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schimbaCuloareFundalToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficulMeciurilorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficulMeciurilorToolStripMenuItem1;
        private System.Windows.Forms.Button btnPrevDay;
        private System.Windows.Forms.Button btnNextDay;
        private System.Windows.Forms.ToolStripMenuItem copiazaInClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializeToolStripMenuItem;
        private UserControl1 userControl11;
    }
}

