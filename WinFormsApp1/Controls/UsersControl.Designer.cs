namespace WinFormsApp1.Controls
{
    partial class UsersControl
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView usersDataGridView;
        private Button addButton;
        private Button deleteButton; // Déclaration du bouton de suppression

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            usersDataGridView = new DataGridView();
            addButton = new Button();
            deleteButton = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)usersDataGridView).BeginInit();
            SuspendLayout();
            // 
            // usersDataGridView
            // 
            usersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            usersDataGridView.Location = new Point(64, 104);
            usersDataGridView.Name = "usersDataGridView";
            usersDataGridView.RowHeadersWidth = 51;
            usersDataGridView.RowTemplate.Height = 25;
            usersDataGridView.Size = new Size(616, 411);
            usersDataGridView.TabIndex = 0;
            usersDataGridView.CellContentClick += usersDataGridView_CellContentClick;
            // 
            // addButton
            // 
            addButton.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold);
            addButton.ForeColor = Color.DarkGreen;
            addButton.Location = new Point(20, 540);
            addButton.Name = "addButton";
            addButton.Size = new Size(178, 40);
            addButton.TabIndex = 1;
            addButton.Text = "ADD A USER +";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold);
            deleteButton.ForeColor = Color.DarkRed;
            deleteButton.Location = new Point(458, 540);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(178, 40);
            deleteButton.TabIndex = 2;
            deleteButton.Text = "DELETE USER -";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 20.8F, FontStyle.Bold);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(257, 19);
            label1.Name = "label1";
            label1.Size = new Size(239, 62);
            label1.TabIndex = 3;
            label1.Text = "USERS LIST";
            // 
            // UsersControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(deleteButton);
            Controls.Add(addButton);
            Controls.Add(usersDataGridView);
            Name = "UsersControl";
            Size = new Size(743, 605);
            ((System.ComponentModel.ISupportInitialize)usersDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
    }
}
