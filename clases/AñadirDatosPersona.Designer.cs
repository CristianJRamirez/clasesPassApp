namespace clases
{
    partial class AñadirDatosPersona
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
            this.button1 = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.t = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PaginaApp = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPage = new System.Windows.Forms.TextBox();
            this.txtPassUser = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(33, 74);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 21;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Location = new System.Drawing.Point(30, 126);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(29, 13);
            this.t.TabIndex = 20;
            this.t.Text = "User";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Page";
            // 
            // PaginaApp
            // 
            this.PaginaApp.AutoSize = true;
            this.PaginaApp.Location = new System.Drawing.Point(30, 152);
            this.PaginaApp.Name = "PaginaApp";
            this.PaginaApp.Size = new System.Drawing.Size(52, 13);
            this.PaginaApp.TabIndex = 16;
            this.PaginaApp.Text = "PassUser";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(95, 123);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(210, 20);
            this.txtUser.TabIndex = 15;
            // 
            // txtPage
            // 
            this.txtPage.Location = new System.Drawing.Point(95, 177);
            this.txtPage.Name = "txtPage";
            this.txtPage.Size = new System.Drawing.Size(210, 20);
            this.txtPage.TabIndex = 14;
            // 
            // txtPassUser
            // 
            this.txtPassUser.Location = new System.Drawing.Point(95, 149);
            this.txtPassUser.Name = "txtPassUser";
            this.txtPassUser.Size = new System.Drawing.Size(210, 20);
            this.txtPassUser.TabIndex = 11;
            // 
            // AñadirDatosPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 410);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.t);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PaginaApp);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtPage);
            this.Controls.Add(this.txtPassUser);
            this.Controls.Add(this.button1);
            this.Name = "AñadirDatosPersona";
            this.Text = "AñadirDatosPersona";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Label t;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label PaginaApp;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPage;
        private System.Windows.Forms.TextBox txtPassUser;
    }
}