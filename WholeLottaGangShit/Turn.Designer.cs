﻿namespace WholeLottaGangShit
{
    partial class Turn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Turn));
            this.label1 = new System.Windows.Forms.Label();
            this.btnHouse = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(249, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lil Pimi is after you!";
            // 
            // btnHouse
            // 
            this.btnHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHouse.Location = new System.Drawing.Point(31, 75);
            this.btnHouse.Name = "btnHouse";
            this.btnHouse.Size = new System.Drawing.Size(138, 74);
            this.btnHouse.TabIndex = 1;
            this.btnHouse.Text = "Run away!";
            this.btnHouse.UseVisualStyleBackColor = true;
            this.btnHouse.Click += new System.EventHandler(this.btnHouse_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(31, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 73);
            this.button2.TabIndex = 2;
            this.button2.Text = "Fight him!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Turn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnHouse);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Turn";
            this.Text = "Turn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHouse;
        private System.Windows.Forms.Button button2;
    }
}