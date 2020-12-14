namespace IceDanceApp
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonNewCompetition = new System.Windows.Forms.Button();
            this.buttonAddCompetitor = new System.Windows.Forms.Button();
            this.buttonManageCouple = new System.Windows.Forms.Button();
            this.buttonAddCoach = new System.Windows.Forms.Button();
            this.buttonAddJudge = new System.Windows.Forms.Button();
            this.buttonManageCompetition = new System.Windows.Forms.Button();
            this.buttonAddCountry = new System.Windows.Forms.Button();
            this.rankingDataGridView = new System.Windows.Forms.DataGridView();
            this.buttonCreateExcel = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rankingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skatePanel = new System.Windows.Forms.Panel();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.rankingDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rankingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(239, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Ice Dance App";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(84, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Season\'s ranking";
            // 
            // buttonNewCompetition
            // 
            this.buttonNewCompetition.Location = new System.Drawing.Point(442, 97);
            this.buttonNewCompetition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonNewCompetition.Name = "buttonNewCompetition";
            this.buttonNewCompetition.Size = new System.Drawing.Size(312, 44);
            this.buttonNewCompetition.TabIndex = 3;
            this.buttonNewCompetition.Text = "Add New Competition";
            this.buttonNewCompetition.UseVisualStyleBackColor = true;
            this.buttonNewCompetition.Click += new System.EventHandler(this.buttonNewCompetition_Click);
            // 
            // buttonAddCompetitor
            // 
            this.buttonAddCompetitor.Location = new System.Drawing.Point(442, 161);
            this.buttonAddCompetitor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddCompetitor.Name = "buttonAddCompetitor";
            this.buttonAddCompetitor.Size = new System.Drawing.Size(312, 44);
            this.buttonAddCompetitor.TabIndex = 4;
            this.buttonAddCompetitor.Text = "Add New Competitors";
            this.buttonAddCompetitor.UseVisualStyleBackColor = true;
            this.buttonAddCompetitor.Click += new System.EventHandler(this.buttonAddCompetitor_Click);
            // 
            // buttonManageCouple
            // 
            this.buttonManageCouple.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonManageCouple.Location = new System.Drawing.Point(442, 405);
            this.buttonManageCouple.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonManageCouple.Name = "buttonManageCouple";
            this.buttonManageCouple.Size = new System.Drawing.Size(312, 44);
            this.buttonManageCouple.TabIndex = 5;
            this.buttonManageCouple.Text = "Manage Couples";
            this.buttonManageCouple.UseVisualStyleBackColor = false;
            this.buttonManageCouple.Click += new System.EventHandler(this.buttonManageCouple_Click);
            // 
            // buttonAddCoach
            // 
            this.buttonAddCoach.Location = new System.Drawing.Point(442, 222);
            this.buttonAddCoach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddCoach.Name = "buttonAddCoach";
            this.buttonAddCoach.Size = new System.Drawing.Size(312, 44);
            this.buttonAddCoach.TabIndex = 6;
            this.buttonAddCoach.Text = "Add New Coach";
            this.buttonAddCoach.UseVisualStyleBackColor = true;
            this.buttonAddCoach.Click += new System.EventHandler(this.buttonAddCoach_Click);
            // 
            // buttonAddJudge
            // 
            this.buttonAddJudge.Location = new System.Drawing.Point(442, 283);
            this.buttonAddJudge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddJudge.Name = "buttonAddJudge";
            this.buttonAddJudge.Size = new System.Drawing.Size(312, 44);
            this.buttonAddJudge.TabIndex = 7;
            this.buttonAddJudge.Text = "Add New Judge";
            this.buttonAddJudge.UseVisualStyleBackColor = true;
            this.buttonAddJudge.Click += new System.EventHandler(this.buttonAddJudge_Click);
            // 
            // buttonManageCompetition
            // 
            this.buttonManageCompetition.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonManageCompetition.Location = new System.Drawing.Point(442, 465);
            this.buttonManageCompetition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonManageCompetition.Name = "buttonManageCompetition";
            this.buttonManageCompetition.Size = new System.Drawing.Size(312, 44);
            this.buttonManageCompetition.TabIndex = 8;
            this.buttonManageCompetition.Text = "Manage Competition";
            this.buttonManageCompetition.UseVisualStyleBackColor = false;
            this.buttonManageCompetition.Click += new System.EventHandler(this.buttonManageCompetition_Click);
            // 
            // buttonAddCountry
            // 
            this.buttonAddCountry.Location = new System.Drawing.Point(442, 345);
            this.buttonAddCountry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddCountry.Name = "buttonAddCountry";
            this.buttonAddCountry.Size = new System.Drawing.Size(312, 44);
            this.buttonAddCountry.TabIndex = 9;
            this.buttonAddCountry.Text = "Add New Country";
            this.buttonAddCountry.UseVisualStyleBackColor = true;
            this.buttonAddCountry.Click += new System.EventHandler(this.buttonAddCountry_Click);
            // 
            // rankingDataGridView
            // 
            this.rankingDataGridView.AutoGenerateColumns = false;
            this.rankingDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rankingDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.rankingDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rankingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rankingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.rankingDataGridView.DataSource = this.rankingBindingSource;
            this.rankingDataGridView.Location = new System.Drawing.Point(41, 97);
            this.rankingDataGridView.Name = "rankingDataGridView";
            this.rankingDataGridView.RowHeadersWidth = 51;
            this.rankingDataGridView.RowTemplate.Height = 24;
            this.rankingDataGridView.Size = new System.Drawing.Size(365, 313);
            this.rankingDataGridView.TabIndex = 11;
            // 
            // buttonCreateExcel
            // 
            this.buttonCreateExcel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCreateExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCreateExcel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCreateExcel.Location = new System.Drawing.Point(41, 436);
            this.buttonCreateExcel.Name = "buttonCreateExcel";
            this.buttonCreateExcel.Size = new System.Drawing.Size(365, 73);
            this.buttonCreateExcel.TabIndex = 12;
            this.buttonCreateExcel.Text = "Create Excel";
            this.buttonCreateExcel.UseVisualStyleBackColor = false;
            this.buttonCreateExcel.Click += new System.EventHandler(this.buttonCreateExcel_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Point";
            this.dataGridViewTextBoxColumn2.HeaderText = "Point";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // rankingBindingSource
            // 
            this.rankingBindingSource.DataSource = typeof(IceDanceApp.Ranking);
            // 
            // skatePanel
            // 
            this.skatePanel.Location = new System.Drawing.Point(41, 538);
            this.skatePanel.Name = "skatePanel";
            this.skatePanel.Size = new System.Drawing.Size(713, 100);
            this.skatePanel.TabIndex = 13;
            // 
            // createTimer
            // 
            this.createTimer.Enabled = true;
            this.createTimer.Interval = 3000;
            this.createTimer.Tick += new System.EventHandler(this.createTimer_Tick);
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Enabled = true;
            this.conveyorTimer.Interval = 10;
            this.conveyorTimer.Tick += new System.EventHandler(this.conveyorTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(796, 650);
            this.Controls.Add(this.skatePanel);
            this.Controls.Add(this.buttonCreateExcel);
            this.Controls.Add(this.rankingDataGridView);
            this.Controls.Add(this.buttonAddCountry);
            this.Controls.Add(this.buttonManageCompetition);
            this.Controls.Add(this.buttonAddJudge);
            this.Controls.Add(this.buttonAddCoach);
            this.Controls.Add(this.buttonManageCouple);
            this.Controls.Add(this.buttonAddCompetitor);
            this.Controls.Add(this.buttonNewCompetition);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.rankingDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rankingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonNewCompetition;
        private System.Windows.Forms.Button buttonAddCompetitor;
        private System.Windows.Forms.Button buttonManageCouple;
        private System.Windows.Forms.Button buttonAddCoach;
        private System.Windows.Forms.Button buttonAddJudge;
        private System.Windows.Forms.Button buttonManageCompetition;
        private System.Windows.Forms.Button buttonAddCountry;
        private System.Windows.Forms.BindingSource rankingBindingSource;
        private System.Windows.Forms.DataGridView rankingDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button buttonCreateExcel;
        private System.Windows.Forms.Panel skatePanel;
        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.Timer conveyorTimer;
    }
}

