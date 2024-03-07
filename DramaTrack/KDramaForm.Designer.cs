namespace DramaTrack
{
    partial class KDramaForm
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
            label1 = new Label();
            txtTitle = new TextBox();
            txtGenre = new TextBox();
            txtCompleted = new TextBox();
            txtTotalEps = new TextBox();
            txtProgress = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            lblTitle = new Label();
            lblGenre = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkMagenta;
            label1.Location = new Point(151, 32);
            label1.Name = "label1";
            label1.Size = new Size(157, 27);
            label1.TabIndex = 0;
            label1.Text = "ADD/MODIFY";
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.FromArgb(255, 224, 192);
            txtTitle.Location = new Point(164, 117);
            txtTitle.Multiline = true;
            txtTitle.Name = "txtTitle";
            txtTitle.ReadOnly = true;
            txtTitle.Size = new Size(125, 34);
            txtTitle.TabIndex = 1;
            // 
            // txtGenre
            // 
            txtGenre.BackColor = Color.FromArgb(255, 224, 192);
            txtGenre.Location = new Point(164, 157);
            txtGenre.Multiline = true;
            txtGenre.Name = "txtGenre";
            txtGenre.ReadOnly = true;
            txtGenre.Size = new Size(125, 34);
            txtGenre.TabIndex = 2;
            // 
            // txtCompleted
            // 
            txtCompleted.BackColor = Color.FromArgb(255, 224, 192);
            txtCompleted.Location = new Point(164, 237);
            txtCompleted.Multiline = true;
            txtCompleted.Name = "txtCompleted";
            txtCompleted.ReadOnly = true;
            txtCompleted.Size = new Size(125, 34);
            txtCompleted.TabIndex = 3;
            // 
            // txtTotalEps
            // 
            txtTotalEps.BackColor = Color.FromArgb(255, 224, 192);
            txtTotalEps.Location = new Point(164, 197);
            txtTotalEps.Multiline = true;
            txtTotalEps.Name = "txtTotalEps";
            txtTotalEps.ReadOnly = true;
            txtTotalEps.Size = new Size(125, 34);
            txtTotalEps.TabIndex = 4;
            // 
            // txtProgress
            // 
            txtProgress.BackColor = Color.FromArgb(255, 224, 192);
            txtProgress.Location = new Point(164, 277);
            txtProgress.Multiline = true;
            txtProgress.Name = "txtProgress";
            txtProgress.ReadOnly = true;
            txtProgress.Size = new Size(125, 34);
            txtProgress.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.MistyRose;
            btnSave.Location = new Point(55, 349);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(103, 47);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.MistyRose;
            btnCancel.Location = new Point(345, 349);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(103, 47);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(55, 120);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(38, 20);
            lblTitle.TabIndex = 8;
            lblTitle.Text = "Title";
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Location = new Point(55, 160);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(48, 20);
            lblGenre.TabIndex = 9;
            lblGenre.Text = "Genre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 200);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 10;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 240);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 11;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(55, 280);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 12;
            label6.Text = "label6";
            // 
            // KDramaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(507, 408);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblGenre);
            Controls.Add(lblTitle);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtProgress);
            Controls.Add(txtTotalEps);
            Controls.Add(txtCompleted);
            Controls.Add(txtGenre);
            Controls.Add(txtTitle);
            Controls.Add(label1);
            Name = "KDramaForm";
            Text = "KDrama Storage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTitle;
        private TextBox txtGenre;
        private TextBox txtCompleted;
        private TextBox txtTotalEps;
        private TextBox txtProgress;
        private Button btnSave;
        private Button btnCancel;
        private Label lblTitle;
        private Label lblGenre;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}