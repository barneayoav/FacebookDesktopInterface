﻿namespace FacebookDesktopInterface.UI
{
    public partial class FormMemoriesFetch
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
            this.labelStartDate = new System.Windows.Forms.Label();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.labelFilterContent = new System.Windows.Forms.Label();
            this.buttonFetchData = new System.Windows.Forms.Button();
            this.monthCalendarStartDate = new System.Windows.Forms.MonthCalendar();
            this.monthCalendarEndDate = new System.Windows.Forms.MonthCalendar();
            this.textBoxFetchResult = new System.Windows.Forms.TextBox();
            this.checkBoxCheckAll = new System.Windows.Forms.CheckBox();
            this.checkBoxPosts = new System.Windows.Forms.CheckBox();
            this.checkBoxCheckIn = new System.Windows.Forms.CheckBox();
            this.checkBoxEvents = new System.Windows.Forms.CheckBox();
            this.checkBoxSingleDay = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Location = new System.Drawing.Point(14, 149);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(58, 13);
            this.labelStartDate.TabIndex = 1;
            this.labelStartDate.Text = "Start Date:";
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Location = new System.Drawing.Point(14, 354);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(55, 13);
            this.labelEndDate.TabIndex = 2;
            this.labelEndDate.Text = "End Date:";
            // 
            // labelFilterContent
            // 
            this.labelFilterContent.AutoSize = true;
            this.labelFilterContent.Location = new System.Drawing.Point(14, 9);
            this.labelFilterContent.Name = "labelFilterContent";
            this.labelFilterContent.Size = new System.Drawing.Size(116, 13);
            this.labelFilterContent.TabIndex = 5;
            this.labelFilterContent.Text = "Show me the following:";
            // 
            // buttonFetchData
            // 
            this.buttonFetchData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFetchData.Location = new System.Drawing.Point(301, 9);
            this.buttonFetchData.Name = "buttonFetchData";
            this.buttonFetchData.Size = new System.Drawing.Size(227, 63);
            this.buttonFetchData.TabIndex = 7;
            this.buttonFetchData.Text = "Fetch";
            this.buttonFetchData.UseVisualStyleBackColor = true;
            this.buttonFetchData.Click += new System.EventHandler(this.buttonFetchData_Click);
            // 
            // monthCalendarStartDate
            // 
            this.monthCalendarStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendarStartDate.Location = new System.Drawing.Point(17, 171);
            this.monthCalendarStartDate.MaxSelectionCount = 1;
            this.monthCalendarStartDate.Name = "monthCalendarStartDate";
            this.monthCalendarStartDate.ScrollChange = 1;
            this.monthCalendarStartDate.ShowToday = false;
            this.monthCalendarStartDate.TabIndex = 8;
            this.monthCalendarStartDate.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarStartDate_DateSelected);
            // 
            // monthCalendarEndDate
            // 
            this.monthCalendarEndDate.Location = new System.Drawing.Point(17, 376);
            this.monthCalendarEndDate.MaxSelectionCount = 1;
            this.monthCalendarEndDate.Name = "monthCalendarEndDate";
            this.monthCalendarEndDate.ShowToday = false;
            this.monthCalendarEndDate.TabIndex = 9;
            this.monthCalendarEndDate.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarEndDate_DateSelected);
            // 
            // textBoxFetchResult
            // 
            this.textBoxFetchResult.Location = new System.Drawing.Point(301, 78);
            this.textBoxFetchResult.Multiline = true;
            this.textBoxFetchResult.Name = "textBoxFetchResult";
            this.textBoxFetchResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxFetchResult.Size = new System.Drawing.Size(439, 460);
            this.textBoxFetchResult.TabIndex = 10;
            // 
            // checkBoxCheckAll
            // 
            this.checkBoxCheckAll.AutoSize = true;
            this.checkBoxCheckAll.Location = new System.Drawing.Point(17, 35);
            this.checkBoxCheckAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxCheckAll.Name = "checkBoxCheckAll";
            this.checkBoxCheckAll.Size = new System.Drawing.Size(70, 17);
            this.checkBoxCheckAll.TabIndex = 11;
            this.checkBoxCheckAll.Text = "Check all";
            this.checkBoxCheckAll.UseVisualStyleBackColor = true;
            this.checkBoxCheckAll.CheckedChanged += new System.EventHandler(this.checkBoxCheckAll_CheckedChanged);
            // 
            // checkBoxPosts
            // 
            this.checkBoxPosts.AutoSize = true;
            this.checkBoxPosts.Location = new System.Drawing.Point(17, 53);
            this.checkBoxPosts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxPosts.Name = "checkBoxPosts";
            this.checkBoxPosts.Size = new System.Drawing.Size(52, 17);
            this.checkBoxPosts.TabIndex = 12;
            this.checkBoxPosts.Text = "Posts";
            this.checkBoxPosts.UseVisualStyleBackColor = true;
            this.checkBoxPosts.CheckedChanged += new System.EventHandler(this.checkBoxPosts_CheckedChanged);
            // 
            // checkBoxCheckIn
            // 
            this.checkBoxCheckIn.AutoSize = true;
            this.checkBoxCheckIn.Location = new System.Drawing.Point(17, 71);
            this.checkBoxCheckIn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxCheckIn.Name = "checkBoxCheckIn";
            this.checkBoxCheckIn.Size = new System.Drawing.Size(68, 17);
            this.checkBoxCheckIn.TabIndex = 14;
            this.checkBoxCheckIn.Text = "Check in";
            this.checkBoxCheckIn.UseVisualStyleBackColor = true;
            this.checkBoxCheckIn.CheckedChanged += new System.EventHandler(this.checkBoxCheckIn_CheckedChanged);
            // 
            // checkBoxEvents
            // 
            this.checkBoxEvents.AutoSize = true;
            this.checkBoxEvents.Location = new System.Drawing.Point(17, 92);
            this.checkBoxEvents.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxEvents.Name = "checkBoxEvents";
            this.checkBoxEvents.Size = new System.Drawing.Size(59, 17);
            this.checkBoxEvents.TabIndex = 15;
            this.checkBoxEvents.Text = "Events";
            this.checkBoxEvents.UseVisualStyleBackColor = true;
            this.checkBoxEvents.CheckedChanged += new System.EventHandler(this.checkBoxEvents_CheckedChanged);
            // 
            // checkBoxSingleDay
            // 
            this.checkBoxSingleDay.AutoSize = true;
            this.checkBoxSingleDay.Enabled = false;
            this.checkBoxSingleDay.Location = new System.Drawing.Point(81, 335);
            this.checkBoxSingleDay.Name = "checkBoxSingleDay";
            this.checkBoxSingleDay.Size = new System.Drawing.Size(75, 17);
            this.checkBoxSingleDay.TabIndex = 16;
            this.checkBoxSingleDay.Text = "Single day";
            this.checkBoxSingleDay.UseVisualStyleBackColor = true;
            this.checkBoxSingleDay.CheckedChanged += new System.EventHandler(this.checkBoxSingleDay_CheckedChanged);
            // 
            // FormMemoriesFetch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 556);
            this.Controls.Add(this.checkBoxSingleDay);
            this.Controls.Add(this.checkBoxEvents);
            this.Controls.Add(this.checkBoxCheckIn);
            this.Controls.Add(this.checkBoxPosts);
            this.Controls.Add(this.checkBoxCheckAll);
            this.Controls.Add(this.textBoxFetchResult);
            this.Controls.Add(this.monthCalendarEndDate);
            this.Controls.Add(this.monthCalendarStartDate);
            this.Controls.Add(this.buttonFetchData);
            this.Controls.Add(this.labelFilterContent);
            this.Controls.Add(this.labelEndDate);
            this.Controls.Add(this.labelStartDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMemoriesFetch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Memories";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.Label labelFilterContent;
        private System.Windows.Forms.Button buttonFetchData;
        private System.Windows.Forms.MonthCalendar monthCalendarStartDate;
        private System.Windows.Forms.MonthCalendar monthCalendarEndDate;
        private System.Windows.Forms.TextBox textBoxFetchResult;
        private System.Windows.Forms.CheckBox checkBoxCheckAll;
        private System.Windows.Forms.CheckBox checkBoxPosts;
        private System.Windows.Forms.CheckBox checkBoxCheckIn;
        private System.Windows.Forms.CheckBox checkBoxEvents;
        private System.Windows.Forms.CheckBox checkBoxSingleDay;
    }
}