
namespace WindowsFormsApp1
{
    partial class FrmHelloworld
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
            this.Frm_HelloWorld = new System.Windows.Forms.Label();
            this.Btm_Sair = new System.Windows.Forms.Button();
            this.Btn_ModificaLabel = new System.Windows.Forms.Button();
            this.txt_ConteudoLabel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Frm_HelloWorld
            // 
            this.Frm_HelloWorld.AutoSize = true;
            this.Frm_HelloWorld.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frm_HelloWorld.Location = new System.Drawing.Point(30, 30);
            this.Frm_HelloWorld.Name = "Frm_HelloWorld";
            this.Frm_HelloWorld.Size = new System.Drawing.Size(192, 18);
            this.Frm_HelloWorld.TabIndex = 0;
            this.Frm_HelloWorld.Text = "Visual Studio .net Version";
            // 
            // Btm_Sair
            // 
            this.Btm_Sair.Location = new System.Drawing.Point(250, 265);
            this.Btm_Sair.Name = "Btm_Sair";
            this.Btm_Sair.Size = new System.Drawing.Size(150, 23);
            this.Btm_Sair.TabIndex = 1;
            this.Btm_Sair.Text = "Fechar Aplicação";
            this.Btm_Sair.UseVisualStyleBackColor = true;
            this.Btm_Sair.Click += new System.EventHandler(this.Btm_Sair_Click);
            // 
            // Btn_ModificaLabel
            // 
            this.Btn_ModificaLabel.Location = new System.Drawing.Point(33, 51);
            this.Btn_ModificaLabel.Name = "Btn_ModificaLabel";
            this.Btn_ModificaLabel.Size = new System.Drawing.Size(189, 22);
            this.Btn_ModificaLabel.TabIndex = 2;
            this.Btn_ModificaLabel.Text = "Modifica texto do label";
            this.Btn_ModificaLabel.UseVisualStyleBackColor = true;
            this.Btn_ModificaLabel.Click += new System.EventHandler(this.Btn_ModificaLabel_Click);
            // 
            // txt_ConteudoLabel
            // 
            this.txt_ConteudoLabel.Location = new System.Drawing.Point(34, 81);
            this.txt_ConteudoLabel.Name = "txt_ConteudoLabel";
            this.txt_ConteudoLabel.Size = new System.Drawing.Size(311, 20);
            this.txt_ConteudoLabel.TabIndex = 3;
            this.txt_ConteudoLabel.Click += new System.EventHandler(this.txt_ConteudoLabel_Click);
            // 
            // FrmHelloworld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 300);
            this.Controls.Add(this.txt_ConteudoLabel);
            this.Controls.Add(this.Btn_ModificaLabel);
            this.Controls.Add(this.Btm_Sair);
            this.Controls.Add(this.Frm_HelloWorld);
            this.Name = "FrmHelloworld";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hello World";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Frm_HelloWorld;
        private System.Windows.Forms.Button Btm_Sair;
        private System.Windows.Forms.Button Btn_ModificaLabel;
        private System.Windows.Forms.TextBox txt_ConteudoLabel;
    }
}

