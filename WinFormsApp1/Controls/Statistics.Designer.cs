namespace WinFormsApp1.Controls
{
    partial class Statistics
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnReloadStats;
        private System.Windows.Forms.Label lblTitle;

        /// <summary> 
        /// Nettoie les ressources utilisées.
        /// </summary>
        /// <param name="disposing">True si les ressources managées doivent être supprimées; sinon, False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de Windows Form

        private void InitializeComponent()
        {
            btnReloadStats = new Button();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // btnReloadStats
            // 
            btnReloadStats.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold);
            btnReloadStats.Location = new Point(28, 16);
            btnReloadStats.Name = "btnReloadStats";
            btnReloadStats.Size = new Size(100, 30);
            btnReloadStats.TabIndex = 0;
            btnReloadStats.Text = "Reset";
            btnReloadStats.Click += btnReloadStats_Click;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe Print", 15.8F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkGreen;
            lblTitle.Location = new Point(221, 5);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(208, 41);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Animals Statistics";
            lblTitle.Click += lblTitle_Click;
            // 
            // Statistics
            // 
            Controls.Add(btnReloadStats);
            Controls.Add(lblTitle);
            Name = "Statistics";
            Size = new Size(658, 530);
            ResumeLayout(false);
        }

        #endregion
    }

}
