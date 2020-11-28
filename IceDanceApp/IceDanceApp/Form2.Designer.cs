namespace IceDanceApp
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAddCountry = new System.Windows.Forms.Button();
            this.buttonAddJudge = new System.Windows.Forms.Button();
            this.buttonAddCoach = new System.Windows.Forms.Button();
            this.buttonAddCompetitor = new System.Windows.Forms.Button();
            this.buttonNewCompetition = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(199, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 385);
            this.panel1.TabIndex = 0;
            // 
            // buttonAddCountry
            // 
            this.buttonAddCountry.Location = new System.Drawing.Point(29, 312);
            this.buttonAddCountry.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddCountry.Name = "buttonAddCountry";
            this.buttonAddCountry.Size = new System.Drawing.Size(134, 62);
            this.buttonAddCountry.TabIndex = 14;
            this.buttonAddCountry.Text = "Add New Country";
            this.buttonAddCountry.UseVisualStyleBackColor = true;
            this.buttonAddCountry.Click += new System.EventHandler(this.buttonAddCountry_Click);
            // 
            // buttonAddJudge
            // 
            this.buttonAddJudge.Location = new System.Drawing.Point(29, 244);
            this.buttonAddJudge.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddJudge.Name = "buttonAddJudge";
            this.buttonAddJudge.Size = new System.Drawing.Size(134, 62);
            this.buttonAddJudge.TabIndex = 13;
            this.buttonAddJudge.Text = "Add New Judge";
            this.buttonAddJudge.UseVisualStyleBackColor = true;
            this.buttonAddJudge.Click += new System.EventHandler(this.buttonAddJudge_Click);
            // 
            // buttonAddCoach
            // 
            this.buttonAddCoach.Location = new System.Drawing.Point(29, 176);
            this.buttonAddCoach.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddCoach.Name = "buttonAddCoach";
            this.buttonAddCoach.Size = new System.Drawing.Size(134, 62);
            this.buttonAddCoach.TabIndex = 12;
            this.buttonAddCoach.Text = "Add New Coach";
            this.buttonAddCoach.UseVisualStyleBackColor = true;
            this.buttonAddCoach.Click += new System.EventHandler(this.buttonAddCoach_Click);
            // 
            // buttonAddCompetitor
            // 
            this.buttonAddCompetitor.Location = new System.Drawing.Point(29, 108);
            this.buttonAddCompetitor.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddCompetitor.Name = "buttonAddCompetitor";
            this.buttonAddCompetitor.Size = new System.Drawing.Size(134, 62);
            this.buttonAddCompetitor.TabIndex = 11;
            this.buttonAddCompetitor.Text = "Add New Competitors";
            this.buttonAddCompetitor.UseVisualStyleBackColor = true;
            this.buttonAddCompetitor.Click += new System.EventHandler(this.buttonAddCompetitor_Click);
            // 
            // buttonNewCompetition
            // 
            this.buttonNewCompetition.Location = new System.Drawing.Point(29, 40);
            this.buttonNewCompetition.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNewCompetition.Name = "buttonNewCompetition";
            this.buttonNewCompetition.Size = new System.Drawing.Size(134, 62);
            this.buttonNewCompetition.TabIndex = 10;
            this.buttonNewCompetition.Text = "Add New Competition";
            this.buttonNewCompetition.UseVisualStyleBackColor = true;
            this.buttonNewCompetition.Click += new System.EventHandler(this.buttonNewCompetition_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 407);
            this.Controls.Add(this.buttonAddCountry);
            this.Controls.Add(this.buttonAddJudge);
            this.Controls.Add(this.buttonAddCoach);
            this.Controls.Add(this.buttonAddCompetitor);
            this.Controls.Add(this.buttonNewCompetition);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAddCountry;
        private System.Windows.Forms.Button buttonAddJudge;
        private System.Windows.Forms.Button buttonAddCoach;
        private System.Windows.Forms.Button buttonAddCompetitor;
        private System.Windows.Forms.Button buttonNewCompetition;
    }
}