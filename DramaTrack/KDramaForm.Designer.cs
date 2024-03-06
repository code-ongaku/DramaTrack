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
            btnEdit = new Button();
            btnDelete = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkMagenta;
            label1.Location = new Point(198, 32);
            label1.Name = "label1";
            label1.Size = new Size(172, 27);
            label1.TabIndex = 0;
            label1.Text = "Stored Kdrama";
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Linen;
            btnEdit.FlatStyle = FlatStyle.Popup;
            btnEdit.ForeColor = SystemColors.ControlText;
            btnEdit.Location = new Point(63, 112);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(137, 49);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit Entry";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Linen;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Location = new Point(401, 112);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(137, 49);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete Entry";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LavenderBlush;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.GridColor = Color.Navy;
            dataGridView1.Location = new Point(0, 220);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(600, 188);
            dataGridView1.TabIndex = 3;
            // 
            // KDramaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(600, 408);
            Controls.Add(dataGridView1);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(label1);
            Name = "KDramaForm";
            Text = "KDrama Storage";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView dataGridView1;
    }
}