namespace JottoAidBot
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.wordtext = new System.Windows.Forms.TextBox();
            this.addbutton = new System.Windows.Forms.Button();
            this.wordlist = new System.Windows.Forms.ListBox();
            this.removebutton = new System.Windows.Forms.Button();
            this.abutton = new System.Windows.Forms.Button();
            this.bbutton = new System.Windows.Forms.Button();
            this.cbutton = new System.Windows.Forms.Button();
            this.dbutton = new System.Windows.Forms.Button();
            this.ebutton = new System.Windows.Forms.Button();
            this.fbutton = new System.Windows.Forms.Button();
            this.gbutton = new System.Windows.Forms.Button();
            this.hbutton = new System.Windows.Forms.Button();
            this.ibutton = new System.Windows.Forms.Button();
            this.jbutton = new System.Windows.Forms.Button();
            this.kbutton = new System.Windows.Forms.Button();
            this.pbutton = new System.Windows.Forms.Button();
            this.lbutton = new System.Windows.Forms.Button();
            this.qbutton = new System.Windows.Forms.Button();
            this.mbutton = new System.Windows.Forms.Button();
            this.rbutton = new System.Windows.Forms.Button();
            this.nbutton = new System.Windows.Forms.Button();
            this.sbutton = new System.Windows.Forms.Button();
            this.obutton = new System.Windows.Forms.Button();
            this.tbutton = new System.Windows.Forms.Button();
            this.vbutton = new System.Windows.Forms.Button();
            this.wbutton = new System.Windows.Forms.Button();
            this.xbutton = new System.Windows.Forms.Button();
            this.ybutton = new System.Windows.Forms.Button();
            this.ubutton = new System.Windows.Forms.Button();
            this.zbutton = new System.Windows.Forms.Button();
            this.possiblecombinationslist = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader26 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader27 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.updatelistcheckbox = new System.Windows.Forms.CheckBox();
            this.totalbutton = new System.Windows.Forms.Button();
            this.jottotooltip = new System.Windows.Forms.ToolTip(this.components);
            this.helpcheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // wordtext
            // 
            this.wordtext.BackColor = System.Drawing.Color.White;
            this.wordtext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wordtext.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordtext.Location = new System.Drawing.Point(12, 12);
            this.wordtext.Name = "wordtext";
            this.wordtext.Size = new System.Drawing.Size(227, 23);
            this.wordtext.TabIndex = 0;
            this.jottotooltip.SetToolTip(this.wordtext, "Enter a word and the number of letters it shares with the hidden word\r\nUse the fo" +
        "llowing format: cheese, 2");
            this.wordtext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.wordtext_KeyPress);
            // 
            // addbutton
            // 
            this.addbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbutton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbutton.Location = new System.Drawing.Point(245, 12);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(35, 23);
            this.addbutton.TabIndex = 1;
            this.addbutton.Text = "Add";
            this.jottotooltip.SetToolTip(this.addbutton, "Adds a new item to the word list");
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // wordlist
            // 
            this.wordlist.BackColor = System.Drawing.Color.White;
            this.wordlist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wordlist.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordlist.FormattingEnabled = true;
            this.wordlist.ItemHeight = 15;
            this.wordlist.Location = new System.Drawing.Point(12, 41);
            this.wordlist.Name = "wordlist";
            this.wordlist.Size = new System.Drawing.Size(268, 317);
            this.wordlist.TabIndex = 2;
            this.jottotooltip.SetToolTip(this.wordlist, "Includes added words");
            // 
            // removebutton
            // 
            this.removebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removebutton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removebutton.Location = new System.Drawing.Point(12, 366);
            this.removebutton.Name = "removebutton";
            this.removebutton.Size = new System.Drawing.Size(107, 23);
            this.removebutton.TabIndex = 1;
            this.removebutton.TabStop = false;
            this.removebutton.Text = "Remove Selected";
            this.jottotooltip.SetToolTip(this.removebutton, "Removes selected items on the word list");
            this.removebutton.UseVisualStyleBackColor = true;
            this.removebutton.Click += new System.EventHandler(this.removebutton_Click);
            // 
            // abutton
            // 
            this.abutton.BackColor = System.Drawing.SystemColors.Control;
            this.abutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abutton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abutton.ForeColor = System.Drawing.Color.Black;
            this.abutton.Location = new System.Drawing.Point(327, 367);
            this.abutton.Name = "abutton";
            this.abutton.Size = new System.Drawing.Size(23, 23);
            this.abutton.TabIndex = 1;
            this.abutton.TabStop = false;
            this.abutton.Text = "a";
            this.jottotooltip.SetToolTip(this.abutton, "Green: the hidden word includes this letter.\r\nRed: the hidden word does not inclu" +
        "de this letter.\r\nBlue: the hidden word includes the letter under certain conditi" +
        "ons, click to view the conditions.");
            this.abutton.UseVisualStyleBackColor = false;
            this.abutton.Click += new System.EventHandler(this.aTozbuttons_Click);
            // 
            // bbutton
            // 
            this.bbutton.BackColor = System.Drawing.SystemColors.Control;
            this.bbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bbutton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbutton.ForeColor = System.Drawing.Color.Black;
            this.bbutton.Location = new System.Drawing.Point(356, 367);
            this.bbutton.Name = "bbutton";
            this.bbutton.Size = new System.Drawing.Size(23, 23);
            this.bbutton.TabIndex = 1;
            this.bbutton.TabStop = false;
            this.bbutton.Text = "b";
            this.jottotooltip.SetToolTip(this.bbutton, "Green means the hidden word includes this letter.\r\nRed means the hidden word does" +
        " not include this letter.\r\nBlue means might include the letter under certain con" +
        "ditions, click to view the conditions.");
            this.bbutton.UseVisualStyleBackColor = false;
            this.bbutton.Click += new System.EventHandler(this.aTozbuttons_Click);
            // 
            // cbutton
            // 
            this.cbutton.BackColor = System.Drawing.SystemColors.Control;
            this.cbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbutton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbutton.ForeColor = System.Drawing.Color.Black;
            this.cbutton.Location = new System.Drawing.Point(385, 367);
            this.cbutton.Name = "cbutton";
            this.cbutton.Size = new System.Drawing.Size(23, 23);
            this.cbutton.TabIndex = 1;
            this.cbutton.TabStop = false;
            this.cbutton.Text = "c";
            this.jottotooltip.SetToolTip(this.cbutton, "Green means the hidden word includes this letter.\r\nRed means the hidden word does" +
        " not include this letter.\r\nBlue means might include the letter under certain con" +
        "ditions, click to view the conditions.");
            this.cbutton.UseVisualStyleBackColor = false;
            this.cbutton.Click += new System.EventHandler(this.aTozbuttons_Click);
            // 
            // dbutton
            // 
            this.dbutton.BackColor = System.Drawing.SystemColors.Control;
            this.dbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dbutton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbutton.ForeColor = System.Drawing.Color.Black;
            this.dbutton.Location = new System.Drawing.Point(414, 367);
            this.dbutton.Name = "dbutton";
            this.dbutton.Size = new System.Drawing.Size(23, 23);
            this.dbutton.TabIndex = 1;
            this.dbutton.TabStop = false;
            this.dbutton.Text = "d";
            this.jottotooltip.SetToolTip(this.dbutton, "Green means the hidden word includes this letter.\r\nRed means the hidden word does" +
        " not include this letter.\r\nBlue means might include the letter under certain con" +
        "ditions, click to view the conditions.");
            this.dbutton.UseVisualStyleBackColor = false;
            this.dbutton.Click += new System.EventHandler(this.aTozbuttons_Click);
            // 
            // ebutton
            // 
            this.ebutton.BackColor = System.Drawing.SystemColors.Control;
            this.ebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ebutton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ebutton.ForeColor = System.Drawing.Color.Black;
            this.ebutton.Location = new System.Drawing.Point(443, 367);
            this.ebutton.Name = "ebutton";
            this.ebutton.Size = new System.Drawing.Size(23, 23);
            this.ebutton.TabIndex = 1;
            this.ebutton.TabStop = false;
            this.ebutton.Text = "e";
            this.jottotooltip.SetToolTip(this.ebutton, "Green means the hidden word includes this letter.\r\nRed means the hidden word does" +
        " not include this letter.\r\nBlue means might include the letter under certain con" +
        "ditions, click to view the conditions.");
            this.ebutton.UseVisualStyleBackColor = false;
            this.ebutton.Click += new System.EventHandler(this.aTozbuttons_Click);
            // 
            // fbutton
            // 
            this.fbutton.BackColor = System.Drawing.SystemColors.Control;
            this.fbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fbutton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fbutton.ForeColor = System.Drawing.Color.Black;
            this.fbutton.Location = new System.Drawing.Point(472, 367);
            this.fbutton.Name = "fbutton";
            this.fbutton.Size = new System.Drawing.Size(23, 23);
            this.fbutton.TabIndex = 1;
            this.fbutton.TabStop = false;
            this.fbutton.Text = "f";
            this.jottotooltip.SetToolTip(this.fbutton, "Green means the hidden word includes this letter.\r\nRed means the hidden word does" +
        " not include this letter.\r\nBlue means might include the letter under certain con" +
        "ditions, click to view the conditions.");
            this.fbutton.UseVisualStyleBackColor = false;
            this.fbutton.Click += new System.EventHandler(this.aTozbuttons_Click);
            // 
            // gbutton
            // 
            this.gbutton.BackColor = System.Drawing.SystemColors.Control;
            this.gbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbutton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbutton.ForeColor = System.Drawing.Color.Black;
            this.gbutton.Location = new System.Drawing.Point(501, 367);
            this.gbutton.Name = "gbutton";
            this.gbutton.Size = new System.Drawing.Size(23, 23);
            this.gbutton.TabIndex = 1;
            this.gbutton.TabStop = false;
            this.gbutton.Text = "g";
            this.jottotooltip.SetToolTip(this.gbutton, "Green means the hidden word includes this letter.\r\nRed means the hidden word does" +
        " not include this letter.\r\nBlue means might include the letter under certain con" +
        "ditions, click to view the conditions.");
            this.gbutton.UseVisualStyleBackColor = false;
            this.gbutton.Click += new System.EventHandler(this.aTozbuttons_Click);
            // 
            // hbutton
            // 
            this.hbutton.BackColor = System.Drawing.SystemColors.Control;
            this.hbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hbutton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hbutton.ForeColor = System.Drawing.Color.Black;
            this.hbutton.Location = new System.Drawing.Point(530, 367);
            this.hbutton.Name = "hbutton";
            this.hbutton.Size = new System.Drawing.Size(23, 23);
            this.hbutton.TabIndex = 1;
            this.hbutton.TabStop = false;
            this.hbutton.Text = "h";
            this.jottotooltip.SetToolTip(this.hbutton, "Green means the hidden word includes this letter.\r\nRed means the hidden word does" +
        " not include this letter.\r\nBlue means might include the letter under certain con" +
        "ditions, click to view the conditions.");
            this.hbutton.UseVisualStyleBackColor = false;
            this.hbutton.Click += new System.EventHandler(this.aTozbuttons_Click);
            // 
            // ibutton
            // 
            this.ibutton.BackColor = System.Drawing.SystemColors.Control;
            this.ibutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibutton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibutton.ForeColor = System.Drawing.Color.Black;
            this.ibutton.Location = new System.Drawing.Point(559, 367);
            this.ibutton.Name = "ibutton";
            this.ibutton.Size = new System.Drawing.Size(23, 23);
            this.ibutton.TabIndex = 1;
            this.ibutton.TabStop = false;
            this.ibutton.Text = "i";
            this.jottotooltip.SetToolTip(this.ibutton, "Green means the hidden word includes this letter.\r\nRed means the hidden word does" +
        " not include this letter.\r\nBlue means might include the letter under certain con" +
        "ditions, click to view the conditions.");
            this.ibutton.UseVisualStyleBackColor = false;
            this.ibutton.Click += new System.EventHandler(this.aTozbuttons_Click);
            // 
            // jbutton
            // 
            this.jbutton.BackColor = System.Drawing.SystemColors.Control;
            this.jbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jbutton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jbutton.ForeColor = System.Drawing.Color.Black;
            this.jbutton.Location = new System.Drawing.Point(588, 367);
            this.jbutton.Name = "jbutton";
            this.jbutton.Size = new System.Drawing.Size(23, 23);
            this.jbutton.TabIndex = 1;
            this.jbutton.TabStop = false;
            this.jbutton.Text = "j";
            this.jottotooltip.SetToolTip(this.jbutton, "Green means the hidden word includes this letter.\r\nRed means the hidden word does" +
        " not include this letter.\r\nBlue means might include the letter under certain con" +
        "ditions, click to view the conditions.");
            this.jbutton.UseVisualStyleBackColor = false;
            this.jbutton.Click += new System.EventHandler(this.aTozbuttons_Click);
            // 
            // kbutton
            // 
            this.kbutton.BackColor = System.Drawing.SystemColors.Control;
            this.kbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kbutton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbutton.ForeColor = System.Drawing.Color.Black;
            this.kbutton.Location = new System.Drawing.Point(617, 367);
            this.kbutton.Name = "kbutton";
            this.kbutton.Size = new System.Drawing.Size(23, 23);
            this.kbutton.TabIndex = 1;
            this.kbutton.TabStop = false;
            this.kbutton.Text = "k";
            this.jottotooltip.SetToolTip(this.kbutton, "Green means the hidden word includes this letter.\r\nRed means the hidden word does" +
        " not include this letter.\r\nBlue means might include the letter under certain con" +
        "ditions, click to view the conditions.");
            this.kbutton.UseVisualStyleBackColor = false;
            this.kbutton.Click += new System.EventHandler(this.aTozbuttons_Click);
            // 
            // pbutton
            // 
            this.pbutton.BackColor = System.Drawing.SystemColors.Control;
            this.pbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pbutton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbutton.ForeColor = System.Drawing.Color.Black;
            this.pbutton.Location = new System.Drawing.Point(762, 367);
            this.pbutton.Name = "pbutton";
            this.pbutton.Size = new System.Drawing.Size(23, 23);
            this.pbutton.TabIndex = 1;
            this.pbutton.TabStop = false;
            this.pbutton.Text = "p";
            this.jottotooltip.SetToolTip(this.pbutton, "Green means the hidden word includes this letter.\r\nRed means the hidden word does" +
        " not include this letter.\r\nBlue means might include the letter under certain con" +
        "ditions, click to view the conditions.");
            this.pbutton.UseVisualStyleBackColor = false;
            this.pbutton.Click += new System.EventHandler(this.aTozbuttons_Click);
            // 
            // lbutton
            // 
            this.lbutton.BackColor = System.Drawing.SystemColors.Control;
            this.lbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbutton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbutton.ForeColor = System.Drawing.Color.Black;
            this.lbutton.Location = new System.Drawing.Point(646, 367);
            this.lbutton.Name = "lbutton";
            this.lbutton.Size = new System.Drawing.Size(23, 23);
            this.lbutton.TabIndex = 1;
            this.lbutton.TabStop = false;
            this.lbutton.Text = "l";
            this.jottotooltip.SetToolTip(this.lbutton, "Green means the hidden word includes this letter.\r\nRed means the hidden word does" +
        " not include this letter.\r\nBlue means might include the letter under certain con" +
        "ditions, click to view the conditions.");
            this.lbutton.UseVisualStyleBackColor = false;
            this.lbutton.Click += new System.EventHandler(this.aTozbuttons_Click);
            // 
            // qbutton
            // 
            this.qbutton.BackColor = System.Drawing.SystemColors.Control;
            this.qbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.qbutton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qbutton.ForeColor = System.Drawing.Color.Black;
            this.qbutton.Location = new System.Drawing.Point(791, 367);
            this.qbutton.Name = "qbutton";
            this.qbutton.Size = new System.Drawing.Size(23, 23);
            this.qbutton.TabIndex = 1;
            this.qbutton.TabStop = false;
            this.qbutton.Text = "q";
            this.jottotooltip.SetToolTip(this.qbutton, "Green means the hidden word includes this letter.\r\nRed means the hidden word does" +
        " not include this letter.\r\nBlue means might include the letter under certain con" +
        "ditions, click to view the conditions.");
            this.qbutton.UseVisualStyleBackColor = false;
            this.qbutton.Click += new System.EventHandler(this.aTozbuttons_Click);
            // 
            // mbutton
            // 
            this.mbutton.BackColor = System.Drawing.SystemColors.Control;
            this.mbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mbutton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbutton.ForeColor = System.Drawing.Color.Black;
            this.mbutton.Location = new System.Drawing.Point(675, 367);
            this.mbutton.Name = "mbutton";
            this.mbutton.Size = new System.Drawing.Size(23, 23);
            this.mbutton.TabIndex = 1;
            this.mbutton.TabStop = false;
            this.mbutton.Text = "m";
            this.jottotooltip.SetToolTip(this.mbutton, "Green means the hidden word includes this letter.\r\nRed means the hidden word does" +
        " not include this letter.\r\nBlue means might include the letter under certain con" +
        "ditions, click to view the conditions.");
            this.mbutton.UseVisualStyleBackColor = false;
            this.mbutton.Click += new System.EventHandler(this.aTozbuttons_Click);
            // 
            // rbutton
            // 
            this.rbutton.BackColor = System.Drawing.SystemColors.Control;
            this.rbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbutton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbutton.ForeColor = System.Drawing.Color.Black;
            this.rbutton.Location = new System.Drawing.Point(820, 367);
            this.rbutton.Name = "rbutton";
            this.rbutton.Size = new System.Drawing.Size(23, 23);
            this.rbutton.TabIndex = 1;
            this.rbutton.TabStop = false;
            this.rbutton.Text = "r";
            this.jottotooltip.SetToolTip(this.rbutton, "Green means the hidden word includes this letter.\r\nRed means the hidden word does" +
        " not include this letter.\r\nBlue means might include the letter under certain con" +
        "ditions, click to view the conditions.");
            this.rbutton.UseVisualStyleBackColor = false;
            this.rbutton.Click += new System.EventHandler(this.aTozbuttons_Click);
            // 
            // nbutton
            // 
            this.nbutton.BackColor = System.Drawing.SystemColors.Control;
            this.nbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nbutton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbutton.ForeColor = System.Drawing.Color.Black;
            this.nbutton.Location = new System.Drawing.Point(704, 367);
            this.nbutton.Name = "nbutton";
            this.nbutton.Size = new System.Drawing.Size(23, 23);
            this.nbutton.TabIndex = 1;
            this.nbutton.TabStop = false;
            this.nbutton.Text = "n";
            this.jottotooltip.SetToolTip(this.nbutton, "Green means the hidden word includes this letter.\r\nRed means the hidden word does" +
        " not include this letter.\r\nBlue means might include the letter under certain con" +
        "ditions, click to view the conditions.");
            this.nbutton.UseVisualStyleBackColor = false;
            this.nbutton.Click += new System.EventHandler(this.aTozbuttons_Click);
            // 
            // sbutton
            // 
            this.sbutton.BackColor = System.Drawing.SystemColors.Control;
            this.sbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbutton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbutton.ForeColor = System.Drawing.Color.Black;
            this.sbutton.Location = new System.Drawing.Point(849, 367);
            this.sbutton.Name = "sbutton";
            this.sbutton.Size = new System.Drawing.Size(23, 23);
            this.sbutton.TabIndex = 1;
            this.sbutton.TabStop = false;
            this.sbutton.Text = "s";
            this.jottotooltip.SetToolTip(this.sbutton, "Green means the hidden word includes this letter.\r\nRed means the hidden word does" +
        " not include this letter.\r\nBlue means might include the letter under certain con" +
        "ditions, click to view the conditions.");
            this.sbutton.UseVisualStyleBackColor = false;
            this.sbutton.Click += new System.EventHandler(this.aTozbuttons_Click);
            // 
            // obutton
            // 
            this.obutton.BackColor = System.Drawing.SystemColors.Control;
            this.obutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.obutton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obutton.ForeColor = System.Drawing.Color.Black;
            this.obutton.Location = new System.Drawing.Point(733, 367);
            this.obutton.Name = "obutton";
            this.obutton.Size = new System.Drawing.Size(23, 23);
            this.obutton.TabIndex = 1;
            this.obutton.TabStop = false;
            this.obutton.Text = "o";
            this.jottotooltip.SetToolTip(this.obutton, "Green means the hidden word includes this letter.\r\nRed means the hidden word does" +
        " not include this letter.\r\nBlue means might include the letter under certain con" +
        "ditions, click to view the conditions.");
            this.obutton.UseVisualStyleBackColor = false;
            this.obutton.Click += new System.EventHandler(this.aTozbuttons_Click);
            // 
            // tbutton
            // 
            this.tbutton.BackColor = System.Drawing.SystemColors.Control;
            this.tbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbutton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbutton.ForeColor = System.Drawing.Color.Black;
            this.tbutton.Location = new System.Drawing.Point(878, 367);
            this.tbutton.Name = "tbutton";
            this.tbutton.Size = new System.Drawing.Size(23, 23);
            this.tbutton.TabIndex = 1;
            this.tbutton.TabStop = false;
            this.tbutton.Text = "t";
            this.jottotooltip.SetToolTip(this.tbutton, "Green means the hidden word includes this letter.\r\nRed means the hidden word does" +
        " not include this letter.\r\nBlue means might include the letter under certain con" +
        "ditions, click to view the conditions.");
            this.tbutton.UseVisualStyleBackColor = false;
            this.tbutton.Click += new System.EventHandler(this.aTozbuttons_Click);
            // 
            // vbutton
            // 
            this.vbutton.BackColor = System.Drawing.SystemColors.Control;
            this.vbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbutton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbutton.ForeColor = System.Drawing.Color.Black;
            this.vbutton.Location = new System.Drawing.Point(936, 367);
            this.vbutton.Name = "vbutton";
            this.vbutton.Size = new System.Drawing.Size(23, 23);
            this.vbutton.TabIndex = 1;
            this.vbutton.TabStop = false;
            this.vbutton.Text = "v";
            this.jottotooltip.SetToolTip(this.vbutton, "Green means the hidden word includes this letter.\r\nRed means the hidden word does" +
        " not include this letter.\r\nBlue means might include the letter under certain con" +
        "ditions, click to view the conditions.");
            this.vbutton.UseVisualStyleBackColor = false;
            this.vbutton.Click += new System.EventHandler(this.aTozbuttons_Click);
            // 
            // wbutton
            // 
            this.wbutton.BackColor = System.Drawing.SystemColors.Control;
            this.wbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wbutton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wbutton.ForeColor = System.Drawing.Color.Black;
            this.wbutton.Location = new System.Drawing.Point(965, 367);
            this.wbutton.Name = "wbutton";
            this.wbutton.Size = new System.Drawing.Size(23, 23);
            this.wbutton.TabIndex = 1;
            this.wbutton.TabStop = false;
            this.wbutton.Text = "w";
            this.jottotooltip.SetToolTip(this.wbutton, "Green means the hidden word includes this letter.\r\nRed means the hidden word does" +
        " not include this letter.\r\nBlue means might include the letter under certain con" +
        "ditions, click to view the conditions.");
            this.wbutton.UseVisualStyleBackColor = false;
            this.wbutton.Click += new System.EventHandler(this.aTozbuttons_Click);
            // 
            // xbutton
            // 
            this.xbutton.BackColor = System.Drawing.SystemColors.Control;
            this.xbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xbutton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xbutton.ForeColor = System.Drawing.Color.Black;
            this.xbutton.Location = new System.Drawing.Point(994, 367);
            this.xbutton.Name = "xbutton";
            this.xbutton.Size = new System.Drawing.Size(23, 23);
            this.xbutton.TabIndex = 1;
            this.xbutton.TabStop = false;
            this.xbutton.Text = "x";
            this.jottotooltip.SetToolTip(this.xbutton, "Green means the hidden word includes this letter.\r\nRed means the hidden word does" +
        " not include this letter.\r\nBlue means might include the letter under certain con" +
        "ditions, click to view the conditions.");
            this.xbutton.UseVisualStyleBackColor = false;
            this.xbutton.Click += new System.EventHandler(this.aTozbuttons_Click);
            // 
            // ybutton
            // 
            this.ybutton.BackColor = System.Drawing.SystemColors.Control;
            this.ybutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ybutton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ybutton.ForeColor = System.Drawing.Color.Black;
            this.ybutton.Location = new System.Drawing.Point(1023, 367);
            this.ybutton.Name = "ybutton";
            this.ybutton.Size = new System.Drawing.Size(23, 23);
            this.ybutton.TabIndex = 1;
            this.ybutton.TabStop = false;
            this.ybutton.Text = "y";
            this.jottotooltip.SetToolTip(this.ybutton, "Green means the hidden word includes this letter.\r\nRed means the hidden word does" +
        " not include this letter.\r\nBlue means might include the letter under certain con" +
        "ditions, click to view the conditions.");
            this.ybutton.UseVisualStyleBackColor = false;
            this.ybutton.Click += new System.EventHandler(this.aTozbuttons_Click);
            // 
            // ubutton
            // 
            this.ubutton.BackColor = System.Drawing.SystemColors.Control;
            this.ubutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ubutton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ubutton.ForeColor = System.Drawing.Color.Black;
            this.ubutton.Location = new System.Drawing.Point(907, 367);
            this.ubutton.Name = "ubutton";
            this.ubutton.Size = new System.Drawing.Size(23, 23);
            this.ubutton.TabIndex = 1;
            this.ubutton.TabStop = false;
            this.ubutton.Text = "u";
            this.jottotooltip.SetToolTip(this.ubutton, "Green means the hidden word includes this letter.\r\nRed means the hidden word does" +
        " not include this letter.\r\nBlue means might include the letter under certain con" +
        "ditions, click to view the conditions.");
            this.ubutton.UseVisualStyleBackColor = false;
            this.ubutton.Click += new System.EventHandler(this.aTozbuttons_Click);
            // 
            // zbutton
            // 
            this.zbutton.BackColor = System.Drawing.SystemColors.Control;
            this.zbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zbutton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zbutton.ForeColor = System.Drawing.Color.Black;
            this.zbutton.Location = new System.Drawing.Point(1052, 366);
            this.zbutton.Name = "zbutton";
            this.zbutton.Size = new System.Drawing.Size(23, 23);
            this.zbutton.TabIndex = 1;
            this.zbutton.TabStop = false;
            this.zbutton.Text = "z";
            this.jottotooltip.SetToolTip(this.zbutton, "Green means the hidden word includes this letter.\r\nRed means the hidden word does" +
        " not include this letter.\r\nBlue means might include the letter under certain con" +
        "ditions, click to view the conditions.");
            this.zbutton.UseVisualStyleBackColor = false;
            this.zbutton.Click += new System.EventHandler(this.aTozbuttons_Click);
            // 
            // possiblecombinationslist
            // 
            this.possiblecombinationslist.BackColor = System.Drawing.Color.White;
            this.possiblecombinationslist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.possiblecombinationslist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader21,
            this.columnHeader22,
            this.columnHeader23,
            this.columnHeader24,
            this.columnHeader25,
            this.columnHeader26,
            this.columnHeader27});
            this.possiblecombinationslist.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.possiblecombinationslist.ForeColor = System.Drawing.Color.Black;
            this.possiblecombinationslist.FullRowSelect = true;
            this.possiblecombinationslist.GridLines = true;
            this.possiblecombinationslist.HideSelection = false;
            this.possiblecombinationslist.Location = new System.Drawing.Point(286, 12);
            this.possiblecombinationslist.Name = "possiblecombinationslist";
            this.possiblecombinationslist.Size = new System.Drawing.Size(810, 348);
            this.possiblecombinationslist.TabIndex = 4;
            this.jottotooltip.SetToolTip(this.possiblecombinationslist, "Includes all conditions and discovered features of the hidden word");
            this.possiblecombinationslist.UseCompatibleStateImageBehavior = false;
            this.possiblecombinationslist.View = System.Windows.Forms.View.Details;
            this.possiblecombinationslist.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listView1_ColumnWidthChanging);
            this.possiblecombinationslist.SelectedIndexChanged += new System.EventHandler(this.possiblecombinationslist_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No.";
            this.columnHeader1.Width = 35;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "a";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 29;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "b";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 29;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "c";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 29;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "d";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 29;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "e";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 29;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "f";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 29;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "g";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 29;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "h";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 29;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "i";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 29;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "j";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader11.Width = 29;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "k";
            this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader12.Width = 29;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "l";
            this.columnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader13.Width = 29;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "m";
            this.columnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader14.Width = 29;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "n";
            this.columnHeader15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader15.Width = 29;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "o";
            this.columnHeader16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader16.Width = 29;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "p";
            this.columnHeader17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader17.Width = 29;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "q";
            this.columnHeader18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader18.Width = 29;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "r";
            this.columnHeader19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader19.Width = 29;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "s";
            this.columnHeader20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader20.Width = 29;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "t";
            this.columnHeader21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader21.Width = 29;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "u";
            this.columnHeader22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader22.Width = 29;
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "v";
            this.columnHeader23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader23.Width = 29;
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "w";
            this.columnHeader24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader24.Width = 29;
            // 
            // columnHeader25
            // 
            this.columnHeader25.Text = "x";
            this.columnHeader25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader25.Width = 29;
            // 
            // columnHeader26
            // 
            this.columnHeader26.Text = "y";
            this.columnHeader26.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader26.Width = 29;
            // 
            // columnHeader27
            // 
            this.columnHeader27.Text = "z";
            this.columnHeader27.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader27.Width = 29;
            // 
            // updatelistcheckbox
            // 
            this.updatelistcheckbox.Appearance = System.Windows.Forms.Appearance.Button;
            this.updatelistcheckbox.AutoSize = true;
            this.updatelistcheckbox.Checked = true;
            this.updatelistcheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.updatelistcheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatelistcheckbox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatelistcheckbox.Location = new System.Drawing.Point(125, 366);
            this.updatelistcheckbox.Name = "updatelistcheckbox";
            this.updatelistcheckbox.Size = new System.Drawing.Size(155, 23);
            this.updatelistcheckbox.TabIndex = 5;
            this.updatelistcheckbox.TabStop = false;
            this.updatelistcheckbox.Text = "Update List and Buttons";
            this.jottotooltip.SetToolTip(this.updatelistcheckbox, "Determines whether or not the application should update the conditions listview a" +
        "nd the buttons every time a new word is added. \r\nUncheck to maximize performance" +
        ".");
            this.updatelistcheckbox.UseVisualStyleBackColor = true;
            this.updatelistcheckbox.CheckedChanged += new System.EventHandler(this.updatelistcheckbox_CheckedChanged);
            // 
            // totalbutton
            // 
            this.totalbutton.BackColor = System.Drawing.SystemColors.Control;
            this.totalbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalbutton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalbutton.ForeColor = System.Drawing.Color.Black;
            this.totalbutton.Location = new System.Drawing.Point(286, 366);
            this.totalbutton.Name = "totalbutton";
            this.totalbutton.Size = new System.Drawing.Size(35, 23);
            this.totalbutton.TabIndex = 1;
            this.totalbutton.TabStop = false;
            this.jottotooltip.SetToolTip(this.totalbutton, "Shows the number of selected conditions\r\nClick to select all conditions");
            this.totalbutton.UseVisualStyleBackColor = false;
            this.totalbutton.Click += new System.EventHandler(this.totalbutton_Click);
            // 
            // jottotooltip
            // 
            this.jottotooltip.AutomaticDelay = 100;
            this.jottotooltip.AutoPopDelay = 3000;
            this.jottotooltip.InitialDelay = 100;
            this.jottotooltip.ReshowDelay = 20;
            this.jottotooltip.ShowAlways = true;
            this.jottotooltip.UseAnimation = false;
            this.jottotooltip.UseFading = false;
            // 
            // helpcheckbox
            // 
            this.helpcheckbox.AutoSize = true;
            this.helpcheckbox.Checked = true;
            this.helpcheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.helpcheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpcheckbox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpcheckbox.Location = new System.Drawing.Point(1084, 372);
            this.helpcheckbox.Name = "helpcheckbox";
            this.helpcheckbox.Size = new System.Drawing.Size(12, 11);
            this.helpcheckbox.TabIndex = 6;
            this.helpcheckbox.TabStop = false;
            this.jottotooltip.SetToolTip(this.helpcheckbox, "Determines the avalibility of help information");
            this.helpcheckbox.UseVisualStyleBackColor = true;
            this.helpcheckbox.CheckedChanged += new System.EventHandler(this.helpcheckbox_CheckedChanged);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 401);
            this.Controls.Add(this.updatelistcheckbox);
            this.Controls.Add(this.possiblecombinationslist);
            this.Controls.Add(this.wordlist);
            this.Controls.Add(this.removebutton);
            this.Controls.Add(this.abutton);
            this.Controls.Add(this.bbutton);
            this.Controls.Add(this.cbutton);
            this.Controls.Add(this.dbutton);
            this.Controls.Add(this.ebutton);
            this.Controls.Add(this.fbutton);
            this.Controls.Add(this.gbutton);
            this.Controls.Add(this.hbutton);
            this.Controls.Add(this.ibutton);
            this.Controls.Add(this.jbutton);
            this.Controls.Add(this.kbutton);
            this.Controls.Add(this.lbutton);
            this.Controls.Add(this.mbutton);
            this.Controls.Add(this.nbutton);
            this.Controls.Add(this.obutton);
            this.Controls.Add(this.pbutton);
            this.Controls.Add(this.qbutton);
            this.Controls.Add(this.rbutton);
            this.Controls.Add(this.sbutton);
            this.Controls.Add(this.tbutton);
            this.Controls.Add(this.ubutton);
            this.Controls.Add(this.vbutton);
            this.Controls.Add(this.wbutton);
            this.Controls.Add(this.xbutton);
            this.Controls.Add(this.ybutton);
            this.Controls.Add(this.zbutton);
            this.Controls.Add(this.totalbutton);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.wordtext);
            this.Controls.Add(this.helpcheckbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainForm";
            this.Text = "Jotto Aid Bot";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.mainForm_HelpButtonClicked);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox wordtext;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.ListBox wordlist;
        private System.Windows.Forms.Button removebutton;
        private System.Windows.Forms.Button abutton;
        private System.Windows.Forms.Button bbutton;
        private System.Windows.Forms.Button cbutton;
        private System.Windows.Forms.Button dbutton;
        private System.Windows.Forms.Button ebutton;
        private System.Windows.Forms.Button fbutton;
        private System.Windows.Forms.Button gbutton;
        private System.Windows.Forms.Button hbutton;
        private System.Windows.Forms.Button ibutton;
        private System.Windows.Forms.Button jbutton;
        private System.Windows.Forms.Button kbutton;
        private System.Windows.Forms.Button pbutton;
        private System.Windows.Forms.Button lbutton;
        private System.Windows.Forms.Button qbutton;
        private System.Windows.Forms.Button mbutton;
        private System.Windows.Forms.Button rbutton;
        private System.Windows.Forms.Button nbutton;
        private System.Windows.Forms.Button sbutton;
        private System.Windows.Forms.Button obutton;
        private System.Windows.Forms.Button tbutton;
        private System.Windows.Forms.Button vbutton;
        private System.Windows.Forms.Button wbutton;
        private System.Windows.Forms.Button xbutton;
        private System.Windows.Forms.Button ybutton;
        private System.Windows.Forms.Button ubutton;
        private System.Windows.Forms.Button zbutton;
        private System.Windows.Forms.ListView possiblecombinationslist;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ColumnHeader columnHeader24;
        private System.Windows.Forms.ColumnHeader columnHeader25;
        private System.Windows.Forms.ColumnHeader columnHeader26;
        private System.Windows.Forms.ColumnHeader columnHeader27;
        private System.Windows.Forms.CheckBox updatelistcheckbox;
        private System.Windows.Forms.Button totalbutton;
        private System.Windows.Forms.ToolTip jottotooltip;
        private System.Windows.Forms.CheckBox helpcheckbox;
    }
}

