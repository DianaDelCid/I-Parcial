namespace IParcial
{
    partial class Ejercicio5
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
            this.HornearButton = new System.Windows.Forms.Button();
            this.HornearAzincronoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HornearButton
            // 
            this.HornearButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HornearButton.Location = new System.Drawing.Point(40, 27);
            this.HornearButton.Name = "HornearButton";
            this.HornearButton.Size = new System.Drawing.Size(166, 59);
            this.HornearButton.TabIndex = 0;
            this.HornearButton.Text = "Hornear Pizza";
            this.HornearButton.UseVisualStyleBackColor = true;
            this.HornearButton.Click += new System.EventHandler(this.HornearButton_Click);
            // 
            // HornearAzincronoButton
            // 
            this.HornearAzincronoButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HornearAzincronoButton.Location = new System.Drawing.Point(228, 27);
            this.HornearAzincronoButton.Name = "HornearAzincronoButton";
            this.HornearAzincronoButton.Size = new System.Drawing.Size(166, 59);
            this.HornearAzincronoButton.TabIndex = 1;
            this.HornearAzincronoButton.Text = "Hornear Pizza Asincrono";
            this.HornearAzincronoButton.UseVisualStyleBackColor = true;
            this.HornearAzincronoButton.Click += new System.EventHandler(this.HornearAzincronoButton_Click);
            // 
            // Ejercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 315);
            this.Controls.Add(this.HornearAzincronoButton);
            this.Controls.Add(this.HornearButton);
            this.Name = "Ejercicio5";
            this.Text = "Ejercicio5";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HornearButton;
        private System.Windows.Forms.Button HornearAzincronoButton;
    }
}