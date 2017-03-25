namespace JottoAidBot
{
    partial class wordfinderForm
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
            this.possiblewordlist = new System.Windows.Forms.ListBox();
            this.dosearchbutton = new System.Windows.Forms.Button();
            this.maximumwordlengthnumericupdown = new System.Windows.Forms.NumericUpDown();
            this.maximumwordlengthcheckbox = new System.Windows.Forms.CheckBox();
            this.noduplicatecheckbox = new System.Windows.Forms.CheckBox();
            this.minimumwordlengthcheckbox = new System.Windows.Forms.CheckBox();
            this.minimumwordlengthnumericupdown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.maximumwordlengthnumericupdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimumwordlengthnumericupdown)).BeginInit();
            this.SuspendLayout();
            // 
            // possiblewordlist
            // 
            this.possiblewordlist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.possiblewordlist.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.possiblewordlist.FormattingEnabled = true;
            this.possiblewordlist.ItemHeight = 15;
            this.possiblewordlist.Location = new System.Drawing.Point(12, 12);
            this.possiblewordlist.Name = "possiblewordlist";
            this.possiblewordlist.Size = new System.Drawing.Size(251, 317);
            this.possiblewordlist.TabIndex = 0;
            // 
            // dosearchbutton
            // 
            this.dosearchbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dosearchbutton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dosearchbutton.Location = new System.Drawing.Point(12, 422);
            this.dosearchbutton.Name = "dosearchbutton";
            this.dosearchbutton.Size = new System.Drawing.Size(251, 25);
            this.dosearchbutton.TabIndex = 1;
            this.dosearchbutton.Text = "Search";
            this.dosearchbutton.UseVisualStyleBackColor = true;
            this.dosearchbutton.Click += new System.EventHandler(this.dosearchbutton_Click);
            // 
            // maximumwordlengthnumericupdown
            // 
            this.maximumwordlengthnumericupdown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maximumwordlengthnumericupdown.Enabled = false;
            this.maximumwordlengthnumericupdown.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximumwordlengthnumericupdown.Location = new System.Drawing.Point(229, 364);
            this.maximumwordlengthnumericupdown.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.maximumwordlengthnumericupdown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maximumwordlengthnumericupdown.Name = "maximumwordlengthnumericupdown";
            this.maximumwordlengthnumericupdown.Size = new System.Drawing.Size(34, 23);
            this.maximumwordlengthnumericupdown.TabIndex = 2;
            this.maximumwordlengthnumericupdown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // maximumwordlengthcheckbox
            // 
            this.maximumwordlengthcheckbox.Appearance = System.Windows.Forms.Appearance.Button;
            this.maximumwordlengthcheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximumwordlengthcheckbox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximumwordlengthcheckbox.Location = new System.Drawing.Point(12, 364);
            this.maximumwordlengthcheckbox.Name = "maximumwordlengthcheckbox";
            this.maximumwordlengthcheckbox.Size = new System.Drawing.Size(211, 23);
            this.maximumwordlengthcheckbox.TabIndex = 3;
            this.maximumwordlengthcheckbox.Text = "Set Maximum Word Length";
            this.maximumwordlengthcheckbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.maximumwordlengthcheckbox.UseVisualStyleBackColor = true;
            this.maximumwordlengthcheckbox.CheckedChanged += new System.EventHandler(this.maximumwordlengthcheckbox_CheckedChanged);
            // 
            // noduplicatecheckbox
            // 
            this.noduplicatecheckbox.Appearance = System.Windows.Forms.Appearance.Button;
            this.noduplicatecheckbox.AutoSize = true;
            this.noduplicatecheckbox.Checked = true;
            this.noduplicatecheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.noduplicatecheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noduplicatecheckbox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noduplicatecheckbox.Location = new System.Drawing.Point(12, 335);
            this.noduplicatecheckbox.Name = "noduplicatecheckbox";
            this.noduplicatecheckbox.Size = new System.Drawing.Size(251, 23);
            this.noduplicatecheckbox.TabIndex = 3;
            this.noduplicatecheckbox.Text = "Don\'t Show Words with Duplicate Letters";
            this.noduplicatecheckbox.UseVisualStyleBackColor = true;
            // 
            // minimumwordlengthcheckbox
            // 
            this.minimumwordlengthcheckbox.Appearance = System.Windows.Forms.Appearance.Button;
            this.minimumwordlengthcheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimumwordlengthcheckbox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimumwordlengthcheckbox.Location = new System.Drawing.Point(12, 393);
            this.minimumwordlengthcheckbox.Name = "minimumwordlengthcheckbox";
            this.minimumwordlengthcheckbox.Size = new System.Drawing.Size(211, 23);
            this.minimumwordlengthcheckbox.TabIndex = 3;
            this.minimumwordlengthcheckbox.Text = "Set Minimum Word Length";
            this.minimumwordlengthcheckbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.minimumwordlengthcheckbox.UseVisualStyleBackColor = true;
            this.minimumwordlengthcheckbox.CheckedChanged += new System.EventHandler(this.minimumwordlengthcheckbox_CheckedChanged);
            // 
            // minimumwordlengthnumericupdown
            // 
            this.minimumwordlengthnumericupdown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minimumwordlengthnumericupdown.Enabled = false;
            this.minimumwordlengthnumericupdown.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimumwordlengthnumericupdown.Location = new System.Drawing.Point(229, 393);
            this.minimumwordlengthnumericupdown.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.minimumwordlengthnumericupdown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.minimumwordlengthnumericupdown.Name = "minimumwordlengthnumericupdown";
            this.minimumwordlengthnumericupdown.Size = new System.Drawing.Size(34, 23);
            this.minimumwordlengthnumericupdown.TabIndex = 2;
            this.minimumwordlengthnumericupdown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // wordfinderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 459);
            this.Controls.Add(this.noduplicatecheckbox);
            this.Controls.Add(this.minimumwordlengthcheckbox);
            this.Controls.Add(this.maximumwordlengthcheckbox);
            this.Controls.Add(this.minimumwordlengthnumericupdown);
            this.Controls.Add(this.maximumwordlengthnumericupdown);
            this.Controls.Add(this.dosearchbutton);
            this.Controls.Add(this.possiblewordlist);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wordfinderForm";
            this.Text = "wordfinderForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.wordfinderForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.maximumwordlengthnumericupdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimumwordlengthnumericupdown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox possiblewordlist;
        private System.Windows.Forms.Button dosearchbutton;
        private System.Windows.Forms.NumericUpDown maximumwordlengthnumericupdown;
        private System.Windows.Forms.CheckBox maximumwordlengthcheckbox;
        private System.Windows.Forms.CheckBox noduplicatecheckbox;
        private System.Windows.Forms.CheckBox minimumwordlengthcheckbox;
        private System.Windows.Forms.NumericUpDown minimumwordlengthnumericupdown;
    }
}