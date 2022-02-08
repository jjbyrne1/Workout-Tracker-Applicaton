namespace WinFormsApp1
{
    partial class AddWorkoutForm
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
            this.workoutNameLabel = new System.Windows.Forms.Label();
            this.workoutNameTextbox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.muscleFocusLabel = new System.Windows.Forms.Label();
            this.createWorkoutButton = new System.Windows.Forms.Button();
            this.addMuscleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // workoutNameLabel
            // 
            this.workoutNameLabel.AutoSize = true;
            this.workoutNameLabel.Location = new System.Drawing.Point(10, 15);
            this.workoutNameLabel.Name = "workoutNameLabel";
            this.workoutNameLabel.Size = new System.Drawing.Size(91, 15);
            this.workoutNameLabel.TabIndex = 0;
            this.workoutNameLabel.Text = "Workout Name:";
            // 
            // workoutNameTextbox
            // 
            this.workoutNameTextbox.Location = new System.Drawing.Point(107, 12);
            this.workoutNameTextbox.Name = "workoutNameTextbox";
            this.workoutNameTextbox.Size = new System.Drawing.Size(100, 23);
            this.workoutNameTextbox.TabIndex = 1;
            this.workoutNameTextbox.TextChanged += new System.EventHandler(this.workoutNameTextbox_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(107, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 23);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            this.comboBox1.EnabledChanged += new System.EventHandler(this.comboBox1_EnabledChanged);
            // 
            // muscleFocusLabel
            // 
            this.muscleFocusLabel.AutoSize = true;
            this.muscleFocusLabel.Location = new System.Drawing.Point(19, 49);
            this.muscleFocusLabel.Name = "muscleFocusLabel";
            this.muscleFocusLabel.Size = new System.Drawing.Size(82, 15);
            this.muscleFocusLabel.TabIndex = 3;
            this.muscleFocusLabel.Text = "Muscle Focus:";
            // 
            // createWorkoutButton
            // 
            this.createWorkoutButton.Enabled = false;
            this.createWorkoutButton.Location = new System.Drawing.Point(50, 81);
            this.createWorkoutButton.Name = "createWorkoutButton";
            this.createWorkoutButton.Size = new System.Drawing.Size(108, 23);
            this.createWorkoutButton.TabIndex = 4;
            this.createWorkoutButton.Text = "Create Workout";
            this.createWorkoutButton.UseVisualStyleBackColor = true;
            this.createWorkoutButton.Click += new System.EventHandler(this.createWorkoutButton_Click);
            // 
            // addMuscleButton
            // 
            this.addMuscleButton.Location = new System.Drawing.Point(213, 46);
            this.addMuscleButton.Name = "addMuscleButton";
            this.addMuscleButton.Size = new System.Drawing.Size(20, 23);
            this.addMuscleButton.TabIndex = 5;
            this.addMuscleButton.Text = "+";
            this.addMuscleButton.UseVisualStyleBackColor = true;
            this.addMuscleButton.Click += new System.EventHandler(this.addMuscleButton_Click);
            // 
            // AddWorkoutForm
            // 
            this.AcceptButton = this.createWorkoutButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 116);
            this.Controls.Add(this.addMuscleButton);
            this.Controls.Add(this.createWorkoutButton);
            this.Controls.Add(this.muscleFocusLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.workoutNameTextbox);
            this.Controls.Add(this.workoutNameLabel);
            this.Name = "AddWorkoutForm";
            this.Text = "AddWorkoutForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label workoutNameLabel;
        private TextBox workoutNameTextbox;
        private ComboBox comboBox1;
        private Label muscleFocusLabel;
        private Button createWorkoutButton;
        private Button addMuscleButton;
    }
}