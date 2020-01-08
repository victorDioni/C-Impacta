namespace Aula08
{
    partial class Form1
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
            this.btnCliqueAqui = new System.Windows.Forms.Button();
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCliqueAqui
            // 
            this.btnCliqueAqui.Location = new System.Drawing.Point(96, 115);
            this.btnCliqueAqui.Name = "btnCliqueAqui";
            this.btnCliqueAqui.Size = new System.Drawing.Size(118, 40);
            this.btnCliqueAqui.TabIndex = 0;
            this.btnCliqueAqui.Text = "Clique Aqui";
            this.btnCliqueAqui.UseVisualStyleBackColor = true;
            this.btnCliqueAqui.Click += new System.EventHandler(this.BtnCliqueAqui_Click);
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBemVindo.Location = new System.Drawing.Point(12, 23);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(67, 13);
            this.lblBemVindo.TabIndex = 1;
            this.lblBemVindo.Text = "Bem Vindo";
            this.lblBemVindo.Visible = false;
            this.lblBemVindo.Click += new System.EventHandler(this.Label1_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(232, 115);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(118, 40);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 167);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblBemVindo);
            this.Controls.Add(this.btnCliqueAqui);
            this.Name = "Form1";
            this.Text = "Exemplo1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCliqueAqui;
        private System.Windows.Forms.Label lblBemVindo;
        private System.Windows.Forms.Button btnSair;
    }
}

