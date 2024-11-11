namespace Astronomical_Processing
{
    partial class AstronomicalForm
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
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.ButtonSort = new System.Windows.Forms.Button();
            this.ListBoxResults = new System.Windows.Forms.ListBox();
            this.TextBoxInput = new System.Windows.Forms.TextBox();
            this.nameApp = new System.Windows.Forms.Label();
            this.ButtonSeqSearch = new System.Windows.Forms.Button();
            this.ButtonMidExtreme = new System.Windows.Forms.Button();
            this.ButtonMode = new System.Windows.Forms.Button();
            this.ButtonAverage = new System.Windows.Forms.Button();
            this.ButtonRange = new System.Windows.Forms.Button();
            this.TextboxMidExtreme = new System.Windows.Forms.TextBox();
            this.TextboxMode = new System.Windows.Forms.TextBox();
            this.TextboxAverage = new System.Windows.Forms.TextBox();
            this.TextboxRange = new System.Windows.Forms.TextBox();
            this.ButtonReset = new System.Windows.Forms.Button();
            this.toolTipTextbox = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipSearch = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipSeqSearch = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipSort = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipSave = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipMidExtBtn = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipMidExTextBox = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipModeBtn = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipModeTextBox = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipAveBtn = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipAveTextBox = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipRanBtn = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipRanTextBox = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipListBox = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipReset = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Location = new System.Drawing.Point(200, 174);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(213, 23);
            this.ButtonEdit.TabIndex = 0;
            this.ButtonEdit.Text = "SAVE/EDIT";
            this.toolTipTextbox.SetToolTip(this.ButtonEdit, "you can save or edit the data you want");
            this.ButtonEdit.UseVisualStyleBackColor = true;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Location = new System.Drawing.Point(200, 86);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(213, 23);
            this.ButtonSearch.TabIndex = 1;
            this.ButtonSearch.Text = "SEARCH";
            this.toolTipTextbox.SetToolTip(this.ButtonSearch, "you can search the data using binary search");
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // ButtonSort
            // 
            this.ButtonSort.Location = new System.Drawing.Point(200, 145);
            this.ButtonSort.Name = "ButtonSort";
            this.ButtonSort.Size = new System.Drawing.Size(213, 23);
            this.ButtonSort.TabIndex = 2;
            this.ButtonSort.Text = "SORT";
            this.toolTipTextbox.SetToolTip(this.ButtonSort, "you can sort data in ascending order");
            this.ButtonSort.UseVisualStyleBackColor = true;
            this.ButtonSort.Click += new System.EventHandler(this.ButtonSort_Click);
            // 
            // ListBoxResults
            // 
            this.ListBoxResults.FormattingEnabled = true;
            this.ListBoxResults.Location = new System.Drawing.Point(39, 46);
            this.ListBoxResults.Name = "ListBoxResults";
            this.ListBoxResults.Size = new System.Drawing.Size(120, 329);
            this.ListBoxResults.TabIndex = 3;
            this.toolTipTextbox.SetToolTip(this.ListBoxResults, "It shows the entire data searched");
            // 
            // TextBoxInput
            // 
            this.TextBoxInput.Location = new System.Drawing.Point(200, 48);
            this.TextBoxInput.Name = "TextBoxInput";
            this.TextBoxInput.Size = new System.Drawing.Size(213, 20);
            this.TextBoxInput.TabIndex = 4;
            this.toolTipTextbox.SetToolTip(this.TextBoxInput, "Insert a data you want to search or edit");
            // 
            // nameApp
            // 
            this.nameApp.AutoSize = true;
            this.nameApp.Location = new System.Drawing.Point(174, 22);
            this.nameApp.Name = "nameApp";
            this.nameApp.Size = new System.Drawing.Size(122, 13);
            this.nameApp.TabIndex = 6;
            this.nameApp.Text = "Astronomical Processing";
            // 
            // ButtonSeqSearch
            // 
            this.ButtonSeqSearch.Location = new System.Drawing.Point(200, 116);
            this.ButtonSeqSearch.Name = "ButtonSeqSearch";
            this.ButtonSeqSearch.Size = new System.Drawing.Size(213, 23);
            this.ButtonSeqSearch.TabIndex = 7;
            this.ButtonSeqSearch.Text = "SEQUENTIAL SEARCH";
            this.toolTipTextbox.SetToolTip(this.ButtonSeqSearch, "you can search the data using liner search");
            this.ButtonSeqSearch.UseVisualStyleBackColor = true;
            this.ButtonSeqSearch.Click += new System.EventHandler(this.ButtonSeqSearch_Click);
            // 
            // ButtonMidExtreme
            // 
            this.ButtonMidExtreme.Location = new System.Drawing.Point(200, 203);
            this.ButtonMidExtreme.Name = "ButtonMidExtreme";
            this.ButtonMidExtreme.Size = new System.Drawing.Size(109, 23);
            this.ButtonMidExtreme.TabIndex = 8;
            this.ButtonMidExtreme.Text = "MID-EXTREME";
            this.toolTipTextbox.SetToolTip(this.ButtonMidExtreme, "Calulate the intermediate valude between the smallest and largest numbers");
            this.ButtonMidExtreme.UseVisualStyleBackColor = true;
            this.ButtonMidExtreme.Click += new System.EventHandler(this.ButtonMidExtreme_Click);
            // 
            // ButtonMode
            // 
            this.ButtonMode.Location = new System.Drawing.Point(200, 232);
            this.ButtonMode.Name = "ButtonMode";
            this.ButtonMode.Size = new System.Drawing.Size(109, 23);
            this.ButtonMode.TabIndex = 9;
            this.ButtonMode.Text = "MODE";
            this.toolTipTextbox.SetToolTip(this.ButtonMode, "Claulate the value that appears most frequently in a data");
            this.ButtonMode.UseVisualStyleBackColor = true;
            this.ButtonMode.Click += new System.EventHandler(this.ButtonMode_Click);
            // 
            // ButtonAverage
            // 
            this.ButtonAverage.Location = new System.Drawing.Point(200, 261);
            this.ButtonAverage.Name = "ButtonAverage";
            this.ButtonAverage.Size = new System.Drawing.Size(109, 21);
            this.ButtonAverage.TabIndex = 10;
            this.ButtonAverage.Text = "AVERAGE";
            this.toolTipTextbox.SetToolTip(this.ButtonAverage, "Calculate value that best represents a set of data");
            this.ButtonAverage.UseVisualStyleBackColor = true;
            this.ButtonAverage.Click += new System.EventHandler(this.ButtonAverage_Click);
            // 
            // ButtonRange
            // 
            this.ButtonRange.Location = new System.Drawing.Point(200, 286);
            this.ButtonRange.Name = "ButtonRange";
            this.ButtonRange.Size = new System.Drawing.Size(109, 23);
            this.ButtonRange.TabIndex = 11;
            this.ButtonRange.Text = "RANGE";
            this.toolTipTextbox.SetToolTip(this.ButtonRange, "Calculate the difference between the lowest and highest values");
            this.ButtonRange.UseVisualStyleBackColor = true;
            this.ButtonRange.Click += new System.EventHandler(this.ButtonRange_Click);
            // 
            // TextboxMidExtreme
            // 
            this.TextboxMidExtreme.Location = new System.Drawing.Point(316, 205);
            this.TextboxMidExtreme.Name = "TextboxMidExtreme";
            this.TextboxMidExtreme.Size = new System.Drawing.Size(97, 20);
            this.TextboxMidExtreme.TabIndex = 12;
            this.toolTipTextbox.SetToolTip(this.TextboxMidExtreme, "Diplyed Mid-Extreme value");
            // 
            // TextboxMode
            // 
            this.TextboxMode.Location = new System.Drawing.Point(316, 232);
            this.TextboxMode.Name = "TextboxMode";
            this.TextboxMode.Size = new System.Drawing.Size(97, 20);
            this.TextboxMode.TabIndex = 13;
            this.toolTipTextbox.SetToolTip(this.TextboxMode, "Displyed Mode value");
            // 
            // TextboxAverage
            // 
            this.TextboxAverage.Location = new System.Drawing.Point(316, 261);
            this.TextboxAverage.Name = "TextboxAverage";
            this.TextboxAverage.Size = new System.Drawing.Size(97, 20);
            this.TextboxAverage.TabIndex = 14;
            this.toolTipTextbox.SetToolTip(this.TextboxAverage, "Displalyed Average value");
            // 
            // TextboxRange
            // 
            this.TextboxRange.Location = new System.Drawing.Point(316, 289);
            this.TextboxRange.Name = "TextboxRange";
            this.TextboxRange.Size = new System.Drawing.Size(97, 20);
            this.TextboxRange.TabIndex = 15;
            this.toolTipTextbox.SetToolTip(this.TextboxRange, "DIsplayed Range value");
            // 
            // ButtonReset
            // 
            this.ButtonReset.Location = new System.Drawing.Point(39, 381);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(120, 23);
            this.ButtonReset.TabIndex = 16;
            this.ButtonReset.Text = "RESET";
            this.toolTipTextbox.SetToolTip(this.ButtonReset, "It will restart");
            this.ButtonReset.UseVisualStyleBackColor = true;
            this.ButtonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 428);
            this.Controls.Add(this.ButtonReset);
            this.Controls.Add(this.TextboxRange);
            this.Controls.Add(this.TextboxAverage);
            this.Controls.Add(this.TextboxMode);
            this.Controls.Add(this.TextboxMidExtreme);
            this.Controls.Add(this.ButtonRange);
            this.Controls.Add(this.ButtonAverage);
            this.Controls.Add(this.ButtonMode);
            this.Controls.Add(this.ButtonMidExtreme);
            this.Controls.Add(this.ButtonSeqSearch);
            this.Controls.Add(this.nameApp);
            this.Controls.Add(this.TextBoxInput);
            this.Controls.Add(this.ListBoxResults);
            this.Controls.Add(this.ButtonSort);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.ButtonEdit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.Button ButtonSort;
        private System.Windows.Forms.ListBox ListBoxResults;
        private System.Windows.Forms.TextBox TextBoxInput;
        private System.Windows.Forms.Label nameApp;
        private System.Windows.Forms.Button ButtonSeqSearch;
        private System.Windows.Forms.Button ButtonMidExtreme;
        private System.Windows.Forms.Button ButtonMode;
        private System.Windows.Forms.Button ButtonAverage;
        private System.Windows.Forms.Button ButtonRange;
        private System.Windows.Forms.TextBox TextboxMidExtreme;
        private System.Windows.Forms.TextBox TextboxMode;
        private System.Windows.Forms.TextBox TextboxAverage;
        private System.Windows.Forms.TextBox TextboxRange;
        private System.Windows.Forms.Button ButtonReset;
        private System.Windows.Forms.ToolTip toolTipTextbox;
        private System.Windows.Forms.ToolTip toolTipSearch;
        private System.Windows.Forms.ToolTip toolTipSeqSearch;
        private System.Windows.Forms.ToolTip toolTipSort;
        private System.Windows.Forms.ToolTip toolTipSave;
        private System.Windows.Forms.ToolTip toolTipMidExtBtn;
        private System.Windows.Forms.ToolTip toolTipMidExTextBox;
        private System.Windows.Forms.ToolTip toolTipModeBtn;
        private System.Windows.Forms.ToolTip toolTipModeTextBox;
        private System.Windows.Forms.ToolTip toolTipAveBtn;
        private System.Windows.Forms.ToolTip toolTipAveTextBox;
        private System.Windows.Forms.ToolTip toolTipRanBtn;
        private System.Windows.Forms.ToolTip toolTipRanTextBox;
        private System.Windows.Forms.ToolTip toolTipListBox;
        private System.Windows.Forms.ToolTip toolTipReset;
    }
}

