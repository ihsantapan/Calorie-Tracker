namespace Program.UI
{
    partial class Analyse
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
            lvConsumption = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            lvWhatDidIEat = new ListView();
            columnHeader14 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            grpCompareConsumption = new GroupBox();
            rbMonthlyCompare = new RadioButton();
            rbWeeklyCompare = new RadioButton();
            grpCompareMeal = new GroupBox();
            lvCompareByMeal = new ListView();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            groupBox1 = new GroupBox();
            grpCompareConsumption.SuspendLayout();
            grpCompareMeal.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lvConsumption
            // 
            lvConsumption.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader3, columnHeader4, columnHeader2, columnHeader5 });
            lvConsumption.FullRowSelect = true;
            lvConsumption.Location = new Point(6, 75);
            lvConsumption.Name = "lvConsumption";
            lvConsumption.Size = new Size(488, 325);
            lvConsumption.TabIndex = 0;
            lvConsumption.UseCompatibleStateImageBehavior = false;
            lvConsumption.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            columnHeader1.Width = 97;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Total Consumption";
            columnHeader3.Width = 97;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "User Consumption";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 97;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Total Calories";
            columnHeader2.Width = 97;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "User Calories";
            columnHeader5.Width = 97;
            // 
            // lvWhatDidIEat
            // 
            lvWhatDidIEat.Columns.AddRange(new ColumnHeader[] { columnHeader14, columnHeader11, columnHeader12, columnHeader13 });
            lvWhatDidIEat.Location = new Point(18, 34);
            lvWhatDidIEat.Name = "lvWhatDidIEat";
            lvWhatDidIEat.Size = new Size(444, 618);
            lvWhatDidIEat.TabIndex = 1;
            lvWhatDidIEat.UseCompatibleStateImageBehavior = false;
            lvWhatDidIEat.View = View.Details;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "Index";
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Name";
            columnHeader11.Width = 150;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Quantity";
            columnHeader12.Width = 150;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Calorie";
            columnHeader13.Width = 150;
            // 
            // grpCompareConsumption
            // 
            grpCompareConsumption.Controls.Add(rbMonthlyCompare);
            grpCompareConsumption.Controls.Add(rbWeeklyCompare);
            grpCompareConsumption.Controls.Add(lvConsumption);
            grpCompareConsumption.Location = new Point(12, 21);
            grpCompareConsumption.Name = "grpCompareConsumption";
            grpCompareConsumption.Size = new Size(494, 407);
            grpCompareConsumption.TabIndex = 2;
            grpCompareConsumption.TabStop = false;
            grpCompareConsumption.Text = "Compare Yourself";
            // 
            // rbMonthlyCompare
            // 
            rbMonthlyCompare.AutoSize = true;
            rbMonthlyCompare.Checked = true;
            rbMonthlyCompare.Location = new Point(224, 45);
            rbMonthlyCompare.Name = "rbMonthlyCompare";
            rbMonthlyCompare.Size = new Size(121, 24);
            rbMonthlyCompare.TabIndex = 2;
            rbMonthlyCompare.TabStop = true;
            rbMonthlyCompare.Text = "Monthly Basis";
            rbMonthlyCompare.UseVisualStyleBackColor = true;
            // 
            // rbWeeklyCompare
            // 
            rbWeeklyCompare.AutoSize = true;
            rbWeeklyCompare.Location = new Point(43, 45);
            rbWeeklyCompare.Name = "rbWeeklyCompare";
            rbWeeklyCompare.Size = new Size(114, 24);
            rbWeeklyCompare.TabIndex = 1;
            rbWeeklyCompare.Text = "Weekly Basis";
            rbWeeklyCompare.UseVisualStyleBackColor = true;
            // 
            // grpCompareMeal
            // 
            grpCompareMeal.Controls.Add(lvCompareByMeal);
            grpCompareMeal.Location = new Point(12, 434);
            grpCompareMeal.Name = "grpCompareMeal";
            grpCompareMeal.Size = new Size(494, 260);
            grpCompareMeal.TabIndex = 3;
            grpCompareMeal.TabStop = false;
            grpCompareMeal.Text = "Compare By Meal";
            // 
            // lvCompareByMeal
            // 
            lvCompareByMeal.Columns.AddRange(new ColumnHeader[] { columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10 });
            lvCompareByMeal.FullRowSelect = true;
            lvCompareByMeal.Location = new Point(6, 26);
            lvCompareByMeal.Name = "lvCompareByMeal";
            lvCompareByMeal.Size = new Size(482, 224);
            lvCompareByMeal.TabIndex = 3;
            lvCompareByMeal.UseCompatibleStateImageBehavior = false;
            lvCompareByMeal.View = View.Details;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Meal";
            columnHeader6.Width = 97;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Total Consumption";
            columnHeader7.Width = 97;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "User Consumption";
            columnHeader8.TextAlign = HorizontalAlignment.Center;
            columnHeader8.Width = 97;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Total Calories";
            columnHeader9.Width = 97;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "User Calories";
            columnHeader10.Width = 97;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lvWhatDidIEat);
            groupBox1.Location = new Point(512, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(468, 662);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "What Did You Eat In Your Meals?";
            // 
            // Analyse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 696);
            Controls.Add(groupBox1);
            Controls.Add(grpCompareMeal);
            Controls.Add(grpCompareConsumption);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Analyse";
            Text = "Analyse";
            Load += Analyse_Load;
            grpCompareConsumption.ResumeLayout(false);
            grpCompareConsumption.PerformLayout();
            grpCompareMeal.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView lvConsumption;
        private ColumnHeader columnHeader1;
        private ListView lvWhatDidIEat;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private GroupBox grpCompareConsumption;
        private RadioButton rbMonthlyCompare;
        private RadioButton rbWeeklyCompare;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader5;
        private GroupBox grpCompareMeal;
        private ListView lvCompareByMeal;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private GroupBox groupBox1;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
    }
}