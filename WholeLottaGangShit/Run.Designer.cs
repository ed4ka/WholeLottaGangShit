namespace WholeLottaGangShit
{
    partial class Run
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Run));
            this.label1 = new System.Windows.Forms.Label();
            this.btnTurn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(188, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "You escaped! But wait! Turn around!";
            // 
            // btnTurn
            // 
            this.btnTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTurn.Location = new System.Drawing.Point(313, 97);
            this.btnTurn.Name = "btnTurn";
            this.btnTurn.Size = new System.Drawing.Size(169, 64);
            this.btnTurn.TabIndex = 1;
            this.btnTurn.Text = "Turn around";
            this.btnTurn.UseVisualStyleBackColor = true;
            this.btnTurn.Click += new System.EventHandler(this.btnTurn_Click);
            // 
            // Run
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTurn);
            this.Controls.Add(this.label1);
            this.Name = "Run";
            this.Text = "Run";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTurn;
    }
}