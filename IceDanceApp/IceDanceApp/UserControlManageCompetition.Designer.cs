namespace IceDanceApp
{
    partial class UserControlManageCompetition
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxCouple = new System.Windows.Forms.ListBox();
            this.listBoxCompetition = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCoupleSearch = new System.Windows.Forms.TextBox();
            this.textBoxCompetitionSearch = new System.Windows.Forms.TextBox();
            this.textBoxRank = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCoupleCompetitionSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewCoupleCompetition = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoupleCompetition)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxCouple
            // 
            this.listBoxCouple.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxCouple.FormattingEnabled = true;
            this.listBoxCouple.ItemHeight = 16;
            this.listBoxCouple.Location = new System.Drawing.Point(24, 66);
            this.listBoxCouple.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxCouple.Name = "listBoxCouple";
            this.listBoxCouple.Size = new System.Drawing.Size(244, 404);
            this.listBoxCouple.TabIndex = 0;
            // 
            // listBoxCompetition
            // 
            this.listBoxCompetition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxCompetition.FormattingEnabled = true;
            this.listBoxCompetition.ItemHeight = 16;
            this.listBoxCompetition.Location = new System.Drawing.Point(321, 66);
            this.listBoxCompetition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxCompetition.Name = "listBoxCompetition";
            this.listBoxCompetition.Size = new System.Drawing.Size(236, 404);
            this.listBoxCompetition.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(599, 157);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(84, 64);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = ">";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(599, 270);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(84, 64);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "<";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(277, 188);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "+";
            // 
            // textBoxCoupleSearch
            // 
            this.textBoxCoupleSearch.Location = new System.Drawing.Point(24, 34);
            this.textBoxCoupleSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCoupleSearch.Name = "textBoxCoupleSearch";
            this.textBoxCoupleSearch.Size = new System.Drawing.Size(244, 22);
            this.textBoxCoupleSearch.TabIndex = 6;
            this.textBoxCoupleSearch.TextChanged += new System.EventHandler(this.textBoxCoupleSearch_TextChanged);
            // 
            // textBoxCompetitionSearch
            // 
            this.textBoxCompetitionSearch.Location = new System.Drawing.Point(321, 34);
            this.textBoxCompetitionSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCompetitionSearch.Name = "textBoxCompetitionSearch";
            this.textBoxCompetitionSearch.Size = new System.Drawing.Size(236, 22);
            this.textBoxCompetitionSearch.TabIndex = 7;
            this.textBoxCompetitionSearch.TextChanged += new System.EventHandler(this.textBoxCompetitionSearch_TextChanged);
            // 
            // textBoxRank
            // 
            this.textBoxRank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxRank.Location = new System.Drawing.Point(184, 520);
            this.textBoxRank.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxRank.Name = "textBoxRank";
            this.textBoxRank.Size = new System.Drawing.Size(203, 22);
            this.textBoxRank.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 524);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Placement: ";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(277, 480);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 36);
            this.label3.TabIndex = 10;
            this.label3.Text = "+";
            // 
            // textBoxCoupleCompetitionSearch
            // 
            this.textBoxCoupleCompetitionSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCoupleCompetitionSearch.Location = new System.Drawing.Point(720, 34);
            this.textBoxCoupleCompetitionSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCoupleCompetitionSearch.Name = "textBoxCoupleCompetitionSearch";
            this.textBoxCoupleCompetitionSearch.Size = new System.Drawing.Size(660, 22);
            this.textBoxCoupleCompetitionSearch.TabIndex = 11;
            this.textBoxCoupleCompetitionSearch.TextChanged += new System.EventHandler(this.textBoxCoupleCompetitionSearch_TextChanged);
            // 
            // dataGridViewCoupleCompetition
            // 
            this.dataGridViewCoupleCompetition.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCoupleCompetition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCoupleCompetition.Location = new System.Drawing.Point(720, 66);
            this.dataGridViewCoupleCompetition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewCoupleCompetition.Name = "dataGridViewCoupleCompetition";
            this.dataGridViewCoupleCompetition.RowHeadersWidth = 51;
            this.dataGridViewCoupleCompetition.Size = new System.Drawing.Size(660, 404);
            this.dataGridViewCoupleCompetition.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Couples:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Competitions:";
            // 
            // UserControlManageCompetition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewCoupleCompetition);
            this.Controls.Add(this.textBoxCoupleCompetitionSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxRank);
            this.Controls.Add(this.textBoxCompetitionSearch);
            this.Controls.Add(this.textBoxCoupleSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBoxCompetition);
            this.Controls.Add(this.listBoxCouple);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserControlManageCompetition";
            this.Size = new System.Drawing.Size(1405, 588);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoupleCompetition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCouple;
        private System.Windows.Forms.ListBox listBoxCompetition;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCoupleSearch;
        private System.Windows.Forms.TextBox textBoxCompetitionSearch;
        private System.Windows.Forms.TextBox textBoxRank;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCoupleCompetitionSearch;
        private System.Windows.Forms.DataGridView dataGridViewCoupleCompetition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
