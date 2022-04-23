namespace Pogoda
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.bToForms1 = new System.Windows.Forms.Button();
            this.bToForms2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bToForms1
            // 
            this.bToForms1.BackColor = System.Drawing.Color.Teal;
            this.bToForms1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bToForms1.Location = new System.Drawing.Point(49, 387);
            this.bToForms1.Name = "bToForms1";
            this.bToForms1.Size = new System.Drawing.Size(330, 57);
            this.bToForms1.TabIndex = 0;
            this.bToForms1.Text = "Sprawdź pogodę w twoim mieście!";
            this.bToForms1.UseVisualStyleBackColor = false;
            this.bToForms1.Click += new System.EventHandler(this.bToForms1_Click);
            // 
            // bToForms2
            // 
            this.bToForms2.BackColor = System.Drawing.Color.DarkCyan;
            this.bToForms2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bToForms2.Location = new System.Drawing.Point(494, 387);
            this.bToForms2.Name = "bToForms2";
            this.bToForms2.Size = new System.Drawing.Size(367, 57);
            this.bToForms2.TabIndex = 1;
            this.bToForms2.Text = "Sprawdź porównanie z popularnych stron!";
            this.bToForms2.UseVisualStyleBackColor = false;
            this.bToForms2.Click += new System.EventHandler(this.bToForms2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(258, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nasza Pogoda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(316, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Porównywarka prognoz pogody";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(896, 534);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bToForms2);
            this.Controls.Add(this.bToForms1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bToForms1;
        private System.Windows.Forms.Button bToForms2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}