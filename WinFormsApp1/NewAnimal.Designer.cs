namespace WinFormsApp1
{
    partial class NewAnimal
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">True si les ressources managées doivent être supprimées ; sinon, False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le concepteur

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur – ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            NameTextBox = new TextBox();
            AGE = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            Add = new Button();
            MALE = new RadioButton();
            FEMALE = new RadioButton();
            Date = new DateTimePicker();
            label6 = new Label();
            SPECIES = new ComboBox();
            GENDER = new GroupBox();
            groupBox1 = new GroupBox();
            GENDER.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // NameTextBox
            // 
            NameTextBox.BackColor = Color.White;
            NameTextBox.BorderStyle = BorderStyle.FixedSingle;
            NameTextBox.Location = new Point(224, 61);
            NameTextBox.Margin = new Padding(3, 4, 3, 4);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(227, 60);
            NameTextBox.TabIndex = 0;
            // 
            // AGE
            // 
            AGE.BackColor = Color.White;
            AGE.BorderStyle = BorderStyle.FixedSingle;
            AGE.Location = new Point(224, 239);
            AGE.Margin = new Padding(3, 4, 3, 4);
            AGE.Name = "AGE";
            AGE.Size = new Size(186, 60);
            AGE.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(55, 71);
            label1.Name = "label1";
            label1.Size = new Size(84, 40);
            label1.TabIndex = 4;
            label1.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 13.8F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(69, 239);
            label3.Name = "label3";
            label3.Size = new Size(60, 40);
            label3.TabIndex = 6;
            label3.Text = "Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Print", 13.8F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(54, 162);
            label4.Name = "label4";
            label4.Size = new Size(100, 40);
            label4.TabIndex = 7;
            label4.Text = "Species";
            // 
            // Add
            // 
            Add.BackColor = Color.DarkGreen;
            Add.Font = new Font("Segoe Print", 13.8F, FontStyle.Bold);
            Add.ForeColor = Color.White;
            Add.Location = new Point(224, 518);
            Add.Margin = new Padding(3, 4, 3, 4);
            Add.Name = "Add";
            Add.Size = new Size(255, 56);
            Add.TabIndex = 9;
            Add.Text = "Add New Animal";
            Add.UseVisualStyleBackColor = false;
            Add.Click += Add_Click;
            // 
            // MALE
            // 
            MALE.AutoSize = true;
            MALE.Font = new Font("Segoe Print", 13.8F, FontStyle.Bold);
            MALE.ForeColor = Color.Black;
            MALE.Location = new Point(8, 31);
            MALE.Margin = new Padding(3, 4, 3, 4);
            MALE.Name = "MALE";
            MALE.Size = new Size(92, 44);
            MALE.TabIndex = 10;
            MALE.TabStop = true;
            MALE.Text = "Male";
            MALE.UseVisualStyleBackColor = true;
            // 
            // FEMALE
            // 
            FEMALE.AutoSize = true;
            FEMALE.Font = new Font("Segoe Print", 13.8F, FontStyle.Bold);
            FEMALE.ForeColor = Color.Black;
            FEMALE.Location = new Point(106, 31);
            FEMALE.Margin = new Padding(3, 4, 3, 4);
            FEMALE.Name = "FEMALE";
            FEMALE.Size = new Size(119, 44);
            FEMALE.TabIndex = 11;
            FEMALE.TabStop = true;
            FEMALE.Text = "Female";
            FEMALE.UseVisualStyleBackColor = true;
            // 
            // Date
            // 
            Date.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold);
            Date.Location = new Point(224, 421);
            Date.Margin = new Padding(3, 4, 3, 4);
            Date.Name = "Date";
            Date.Size = new Size(391, 39);
            Date.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(55, 428);
            label6.Name = "label6";
            label6.Size = new Size(126, 31);
            label6.TabIndex = 13;
            label6.Text = "Arrival Date";
            // 
            // SPECIES
            // 
            SPECIES.BackColor = Color.White;
            SPECIES.DropDownStyle = ComboBoxStyle.DropDownList;
            SPECIES.Font = new Font("Segoe UI", 10.2F);
            SPECIES.FormattingEnabled = true;
            SPECIES.Location = new Point(224, 171);
            SPECIES.Margin = new Padding(3, 4, 3, 4);
            SPECIES.Name = "SPECIES";
            SPECIES.Size = new Size(172, 31);
            SPECIES.TabIndex = 14;
            // 
            // GENDER
            // 
            GENDER.Controls.Add(FEMALE);
            GENDER.Controls.Add(MALE);
            GENDER.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold);
            GENDER.ForeColor = Color.Black;
            GENDER.Location = new Point(224, 310);
            GENDER.Margin = new Padding(3, 4, 3, 4);
            GENDER.Name = "GENDER";
            GENDER.Padding = new Padding(3, 4, 3, 4);
            GENDER.Size = new Size(236, 79);
            GENDER.TabIndex = 15;
            GENDER.TabStop = false;
            GENDER.Text = "Gender";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.WhiteSmoke;
            groupBox1.Controls.Add(NameTextBox);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(GENDER);
            groupBox1.Controls.Add(Add);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(Date);
            groupBox1.Controls.Add(SPECIES);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(AGE);
            groupBox1.Font = new Font("Segoe Print", 18F, FontStyle.Bold);
            groupBox1.ForeColor = Color.DarkGreen;
            groupBox1.Location = new Point(30, 24);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(674, 603);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "New Animal";
            // 
            // NewAnimal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 655);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NewAnimal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New Animal";
            GENDER.ResumeLayout(false);
            GENDER.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox AGE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.RadioButton MALE;
        private System.Windows.Forms.RadioButton FEMALE;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox SPECIES;
        private System.Windows.Forms.GroupBox GENDER;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}