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
            lblTotalEps = new Label();
            lblCompEps = new Label();
            lblProgress = new Label();
            cmbTitle = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkMagenta;
            label1.Location = new Point(195, 31);
            label1.Name = "label1";
            label1.Size = new Size(59, 27);
            label1.TabIndex = 0;
            label1.Text = "ADD";
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.FromArgb(255, 224, 192);
            txtTitle.Location = new Point(164, 117);
            txtTitle.Multiline = true;
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(125, 34);
            txtTitle.TabIndex = 1;
            // 
            // txtGenre
            // 
            txtGenre.BackColor = Color.FromArgb(255, 224, 192);
            txtGenre.Location = new Point(164, 157);
            txtGenre.Multiline = true;
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(125, 34);
            txtGenre.TabIndex = 2;
            // 
            // txtCompleted
            // 
            txtCompleted.BackColor = Color.FromArgb(255, 224, 192);
            txtCompleted.Location = new Point(164, 237);
            txtCompleted.Multiline = true;
            txtCompleted.Name = "txtCompleted";
            txtCompleted.Size = new Size(125, 34);
            txtCompleted.TabIndex = 3;
            // 
            // txtTotalEps
            // 
            txtTotalEps.BackColor = Color.FromArgb(255, 224, 192);
            txtTotalEps.Location = new Point(164, 197);
            txtTotalEps.Multiline = true;
            txtTotalEps.Name = "txtTotalEps";
            txtTotalEps.Size = new Size(125, 34);
            txtTotalEps.TabIndex = 4;
            // 
            // txtProgress
            // 
            txtProgress.BackColor = Color.FromArgb(255, 224, 192);
            txtProgress.Location = new Point(164, 277);
            txtProgress.Multiline = true;
            txtProgress.Name = "txtProgress";
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
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.BackColor = Color.MistyRose;
            btnCancel.Location = new Point(271, 349);
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
            lblTitle.Location = new Point(120, 120);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(38, 20);
            lblTitle.TabIndex = 8;
            lblTitle.Text = "Title";
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Location = new Point(110, 160);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(48, 20);
            lblGenre.TabIndex = 9;
            lblGenre.Text = "Genre";
            // 
            // lblTotalEps
            // 
            lblTotalEps.AutoSize = true;
            lblTotalEps.Location = new Point(55, 200);
            lblTotalEps.Name = "lblTotalEps";
            lblTotalEps.Size = new Size(105, 20);
            lblTotalEps.TabIndex = 10;
            lblTotalEps.Text = "Total Episodes";
            // 
            // lblCompEps
            // 
            lblCompEps.AutoSize = true;
            lblCompEps.Location = new Point(14, 240);
            lblCompEps.Name = "lblCompEps";
            lblCompEps.Size = new Size(146, 20);
            lblCompEps.TabIndex = 11;
            lblCompEps.Text = "Completed Episodes";
            // 
            // lblProgress
            // 
            lblProgress.AutoSize = true;
            lblProgress.Location = new Point(51, 280);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(109, 20);
            lblProgress.TabIndex = 12;
            lblProgress.Text = "Progress Status";
            // 
            // cmbTitle
            // 
            cmbTitle.AllowDrop = true;
            cmbTitle.BackColor = Color.FromArgb(255, 224, 192);
            cmbTitle.FormattingEnabled = true;
            cmbTitle.Location = new Point(165, 78);
            cmbTitle.Name = "cmbTitle";
            cmbTitle.Size = new Size(124, 28);
            cmbTitle.TabIndex = 13;
            cmbTitle.SelectedIndexChanged += cmbTitle_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 81);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 14;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkMagenta;
            label3.Location = new Point(174, 31);
            label3.Name = "label3";
            label3.Size = new Size(98, 27);
            label3.TabIndex = 15;
            label3.Text = "MODIFY";
            // 
            // KDramaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(419, 408);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbTitle);
            Controls.Add(lblProgress);
            Controls.Add(lblCompEps);
            Controls.Add(lblTotalEps);
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
        private Label lblTotalEps;
        private Label lblCompEps;
        private Label lblProgress;
        private ComboBox cmbTitle;
        private Label label2;
        private Label label3;
    }
}