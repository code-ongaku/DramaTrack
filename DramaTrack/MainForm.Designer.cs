namespace DramaTrack
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnModifyKdrama = new Button();
            btnNewKdrama = new Button();
            lblWelcome = new Label();
            dataGridView1 = new DataGridView();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnModifyKdrama
            // 
            btnModifyKdrama.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnModifyKdrama.BackColor = Color.Lavender;
            btnModifyKdrama.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModifyKdrama.ForeColor = Color.MidnightBlue;
            btnModifyKdrama.Location = new Point(399, 112);
            btnModifyKdrama.Name = "btnModifyKdrama";
            btnModifyKdrama.Size = new Size(163, 59);
            btnModifyKdrama.TabIndex = 0;
            btnModifyKdrama.Text = "Modify Stored KDramas";
            btnModifyKdrama.UseVisualStyleBackColor = false;
            btnModifyKdrama.Click += btnModifyKdrama_Click;
            // 
            // btnNewKdrama
            // 
            btnNewKdrama.BackColor = Color.Lavender;
            btnNewKdrama.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNewKdrama.ForeColor = Color.MidnightBlue;
            btnNewKdrama.Location = new Point(12, 112);
            btnNewKdrama.Name = "btnNewKdrama";
            btnNewKdrama.Size = new Size(169, 59);
            btnNewKdrama.TabIndex = 1;
            btnNewKdrama.Text = "Enter a New KDrama";
            btnNewKdrama.UseVisualStyleBackColor = false;
            btnNewKdrama.Click += btnNewKdrama_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.Anchor = AnchorStyles.Top;
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Lucida Calligraphy", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(230, 54);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(142, 23);
            lblWelcome.TabIndex = 2;
            lblWelcome.Text = "WELCOME c:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.BackgroundColor = Color.MistyRose;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 228);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(574, 190);
            dataGridView1.TabIndex = 3;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Lavender;
            btnDelete.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.MidnightBlue;
            btnDelete.Location = new Point(251, 191);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(84, 31);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // Set the anchor property for btnDelete
            btnDelete.Anchor = AnchorStyles.Top;
            btnDelete.Click += btnDelete_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(574, 418);
            Controls.Add(btnDelete);
            Controls.Add(dataGridView1);
            Controls.Add(lblWelcome);
            Controls.Add(btnNewKdrama);
            Controls.Add(btnModifyKdrama);
            Name = "MainForm";
            Text = "DramaTrack";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnModifyKdrama;
        private Button btnNewKdrama;
        private Label lblWelcome;
        private DataGridView dataGridView1;
        private Button btnDelete;
    }
}
