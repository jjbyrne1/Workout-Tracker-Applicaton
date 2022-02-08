namespace WinFormsApp1
{
    partial class AddMuscle
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
            this.muscleNameTextbox = new System.Windows.Forms.TextBox();
            this.addMuscleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // muscleNameTextbox
            // 
            this.muscleNameTextbox.Location = new System.Drawing.Point(12, 12);
            this.muscleNameTextbox.Name = "muscleNameTextbox";
            this.muscleNameTextbox.Size = new System.Drawing.Size(150, 23);
            this.muscleNameTextbox.TabIndex = 2;
            // 
            // addMuscleButton
            // 
            this.addMuscleButton.Location = new System.Drawing.Point(168, 12);
            this.addMuscleButton.Name = "addMuscleButton";
            this.addMuscleButton.Size = new System.Drawing.Size(75, 23);
            this.addMuscleButton.TabIndex = 3;
            this.addMuscleButton.Text = "Add Muscle";
            this.addMuscleButton.UseVisualStyleBackColor = true;
            this.addMuscleButton.Click += new System.EventHandler(this.addMuscleButton_Click);
            // 
            // AddMuscle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 50);
            this.Controls.Add(this.addMuscleButton);
            this.Controls.Add(this.muscleNameTextbox);
            this.Name = "AddMuscle";
            this.Text = "AddMuscle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox muscleNameTextbox;
        private Button addMuscleButton;
    }
}