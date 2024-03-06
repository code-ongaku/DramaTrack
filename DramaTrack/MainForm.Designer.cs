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
            btnStoredKdrama = new Button();
            btnNewKdrama = new Button();
            lblWelcome = new Label();
            SuspendLayout();
            // 
            // btnStoredKdrama
            // 
            btnStoredKdrama.BackColor = Color.Lavender;
            btnStoredKdrama.Dock = DockStyle.Bottom;
            btnStoredKdrama.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStoredKdrama.ForeColor = Color.MidnightBlue;
            btnStoredKdrama.Location = new Point(0, 307);
            btnStoredKdrama.Name = "btnStoredKdrama";
            btnStoredKdrama.Size = new Size(543, 109);
            btnStoredKdrama.TabIndex = 0;
            btnStoredKdrama.Text = "Check Stored KDramas";
            btnStoredKdrama.UseVisualStyleBackColor = false;
            btnStoredKdrama.Click += btnStoredKdrama_Click;
            // 
            // btnNewKdrama
            // 
            btnNewKdrama.BackColor = Color.Lavender;
            btnNewKdrama.Dock = DockStyle.Bottom;
            btnNewKdrama.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNewKdrama.ForeColor = Color.MidnightBlue;
            btnNewKdrama.Location = new Point(0, 198);
            btnNewKdrama.Name = "btnNewKdrama";
            btnNewKdrama.Size = new Size(543, 109);
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
            lblWelcome.Location = new Point(197, 51);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(142, 23);
            lblWelcome.TabIndex = 2;
            lblWelcome.Text = "WELCOME c:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(543, 416);
            Controls.Add(lblWelcome);
            Controls.Add(btnNewKdrama);
            Controls.Add(btnStoredKdrama);
            Name = "MainForm";
            Text = "DramaTrack";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStoredKdrama;
        private Button btnNewKdrama;
        private Label lblWelcome;
    }
}
