namespace Program.UI
{
    partial class MainMenu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            panel2 = new Panel();
            label2 = new Label();
            lblTime = new Label();
            btnUserInfo = new Button();
            btnApplicationExit = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            panel1 = new Panel();
            pbLogo = new PictureBox();
            btnAddNutrition = new Button();
            btnAddMeal = new Button();
            btnHistory = new Button();
            btnHealthStatus = new Button();
            btnHome = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            btnAnalyse = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(lblTime);
            panel2.Controls.Add(btnUserInfo);
            panel2.Controls.Add(btnApplicationExit);
            panel2.Controls.Add(button8);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button6);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(229, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1009, 96);
            panel2.TabIndex = 3;
            panel2.MouseDown += panel1_MouseDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DimGray;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(34, 28);
            label2.Name = "label2";
            label2.Size = new Size(289, 23);
            label2.TabIndex = 6;
            label2.Text = "Calorie Tracker Diet Program";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("MV Boli", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTime.Location = new Point(557, 47);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(75, 34);
            lblTime.TabIndex = 5;
            lblTime.Text = "Time";
            // 
            // btnUserInfo
            // 
            btnUserInfo.FlatAppearance.BorderSize = 0;
            btnUserInfo.FlatStyle = FlatStyle.Flat;
            btnUserInfo.ForeColor = SystemColors.ControlText;
            btnUserInfo.Image = (Image)resources.GetObject("btnUserInfo.Image");
            btnUserInfo.Location = new Point(862, 4);
            btnUserInfo.Margin = new Padding(3, 4, 3, 4);
            btnUserInfo.Name = "btnUserInfo";
            btnUserInfo.Size = new Size(72, 80);
            btnUserInfo.TabIndex = 4;
            btnUserInfo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUserInfo.UseVisualStyleBackColor = true;
            btnUserInfo.Click += btnUserInfo_Click;
            // 
            // btnApplicationExit
            // 
            btnApplicationExit.FlatAppearance.BorderSize = 0;
            btnApplicationExit.FlatStyle = FlatStyle.Flat;
            btnApplicationExit.ForeColor = SystemColors.ControlText;
            btnApplicationExit.Image = (Image)resources.GetObject("btnApplicationExit.Image");
            btnApplicationExit.Location = new Point(941, 16);
            btnApplicationExit.Margin = new Padding(3, 4, 3, 4);
            btnApplicationExit.Name = "btnApplicationExit";
            btnApplicationExit.Size = new Size(55, 56);
            btnApplicationExit.TabIndex = 4;
            btnApplicationExit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnApplicationExit.UseVisualStyleBackColor = true;
            btnApplicationExit.Click += btnApplicationExit_Click;
            // 
            // button8
            // 
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.ForeColor = SystemColors.ControlText;
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.Location = new Point(805, 1);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(31, 37);
            button8.TabIndex = 4;
            button8.TextImageRelation = TextImageRelation.ImageBeforeText;
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = SystemColors.ControlText;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.Location = new Point(753, 1);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(32, 37);
            button7.TabIndex = 4;
            button7.TextImageRelation = TextImageRelation.ImageBeforeText;
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = SystemColors.ControlText;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(704, 1);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(31, 37);
            button6.TabIndex = 3;
            button6.TextImageRelation = TextImageRelation.ImageBeforeText;
            button6.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(btnAnalyse);
            panel1.Controls.Add(pbLogo);
            panel1.Controls.Add(btnAddNutrition);
            panel1.Controls.Add(btnAddMeal);
            panel1.Controls.Add(btnHistory);
            panel1.Controls.Add(btnHealthStatus);
            panel1.Controls.Add(btnHome);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(229, 847);
            panel1.TabIndex = 2;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(24, 32);
            pbLogo.Margin = new Padding(3, 4, 3, 4);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(179, 151);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 2;
            pbLogo.TabStop = false;
            // 
            // btnAddNutrition
            // 
            btnAddNutrition.FlatAppearance.BorderSize = 0;
            btnAddNutrition.FlatStyle = FlatStyle.Flat;
            btnAddNutrition.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddNutrition.ForeColor = SystemColors.ControlText;
            btnAddNutrition.Image = (Image)resources.GetObject("btnAddNutrition.Image");
            btnAddNutrition.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddNutrition.Location = new Point(14, 733);
            btnAddNutrition.Margin = new Padding(3, 4, 3, 4);
            btnAddNutrition.Name = "btnAddNutrition";
            btnAddNutrition.Size = new Size(215, 97);
            btnAddNutrition.TabIndex = 3;
            btnAddNutrition.Text = "       ADD \r\n     NUTRİTİON";
            btnAddNutrition.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddNutrition.UseVisualStyleBackColor = true;
            btnAddNutrition.Click += btnAddNutrition_Click;
            // 
            // btnAddMeal
            // 
            btnAddMeal.FlatAppearance.BorderSize = 0;
            btnAddMeal.FlatStyle = FlatStyle.Flat;
            btnAddMeal.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddMeal.ForeColor = SystemColors.ControlText;
            btnAddMeal.Image = (Image)resources.GetObject("btnAddMeal.Image");
            btnAddMeal.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddMeal.Location = new Point(14, 604);
            btnAddMeal.Margin = new Padding(3, 4, 3, 4);
            btnAddMeal.Name = "btnAddMeal";
            btnAddMeal.Size = new Size(215, 97);
            btnAddMeal.TabIndex = 3;
            btnAddMeal.Text = "       ADD MEAL";
            btnAddMeal.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddMeal.UseVisualStyleBackColor = true;
            btnAddMeal.Click += btnAddMeal_Click;
            // 
            // btnHistory
            // 
            btnHistory.FlatAppearance.BorderSize = 0;
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnHistory.ForeColor = SystemColors.ControlText;
            btnHistory.Image = (Image)resources.GetObject("btnHistory.Image");
            btnHistory.ImageAlign = ContentAlignment.MiddleLeft;
            btnHistory.Location = new Point(14, 477);
            btnHistory.Margin = new Padding(3, 4, 3, 4);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(211, 97);
            btnHistory.TabIndex = 3;
            btnHistory.Text = "       HISTORY";
            btnHistory.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHistory.UseVisualStyleBackColor = true;
            btnHistory.Click += btnHistory_Click;
            // 
            // btnHealthStatus
            // 
            btnHealthStatus.FlatAppearance.BorderSize = 0;
            btnHealthStatus.FlatStyle = FlatStyle.Flat;
            btnHealthStatus.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnHealthStatus.ForeColor = SystemColors.ControlText;
            btnHealthStatus.Image = (Image)resources.GetObject("btnHealthStatus.Image");
            btnHealthStatus.ImageAlign = ContentAlignment.MiddleLeft;
            btnHealthStatus.Location = new Point(0, 353);
            btnHealthStatus.Margin = new Padding(3, 4, 3, 4);
            btnHealthStatus.Name = "btnHealthStatus";
            btnHealthStatus.Size = new Size(225, 97);
            btnHealthStatus.TabIndex = 3;
            btnHealthStatus.Text = "     HEALTH \r\n   STATUS";
            btnHealthStatus.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHealthStatus.UseVisualStyleBackColor = true;
            btnHealthStatus.Click += btnHealthStatus_Click;
            // 
            // btnHome
            // 
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnHome.ForeColor = Color.Black;
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 223);
            btnHome.Margin = new Padding(3, 4, 3, 4);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(229, 97);
            btnHome.TabIndex = 2;
            btnHome.Text = "       HOME";
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // btnAnalyse
            // 
            btnAnalyse.Location = new Point(106, 205);
            btnAnalyse.Name = "btnAnalyse";
            btnAnalyse.Size = new Size(94, 29);
            btnAnalyse.TabIndex = 4;
            btnAnalyse.Text = "ANALYSE";
            btnAnalyse.UseVisualStyleBackColor = true;
            btnAnalyse.Click += btnAnalyse_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1238, 847);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainMenu";
            Text = "MainMenu";
            Load += MainMenu_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label lblTime;
        private Button btnUserInfo;
        private Button btnApplicationExit;
        private Button button8;
        private Button button7;
        private Button button6;
        private Panel panel1;
        private PictureBox pbLogo;
        private Button btnAddNutrition;
        private Button btnAddMeal;
        private Button btnHistory;
        private Button btnHealthStatus;
        private Button btnHome;
        private System.Windows.Forms.Timer timer1;
        private Label label2;
        private Button btnAnalyse;
    }
}