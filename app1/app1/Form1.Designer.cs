namespace app1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.connectdatabase = new System.Windows.Forms.Button();
            this.InputUsername = new System.Windows.Forms.TextBox();
            this.InputPassword = new System.Windows.Forms.TextBox();
            this.InputEmail = new System.Windows.Forms.TextBox();
            this.saveuser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listausuarios = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // connectdatabase
            // 
            this.connectdatabase.Location = new System.Drawing.Point(12, 12);
            this.connectdatabase.Name = "connectdatabase";
            this.connectdatabase.Size = new System.Drawing.Size(75, 23);
            this.connectdatabase.TabIndex = 0;
            this.connectdatabase.Text = "Conectar";
            this.connectdatabase.UseVisualStyleBackColor = true;
            this.connectdatabase.Click += new System.EventHandler(this.connectdatabase_Click);
            // 
            // InputUsername
            // 
            this.InputUsername.Location = new System.Drawing.Point(12, 128);
            this.InputUsername.Name = "InputUsername";
            this.InputUsername.Size = new System.Drawing.Size(191, 20);
            this.InputUsername.TabIndex = 1;
            // 
            // InputPassword
            // 
            this.InputPassword.Location = new System.Drawing.Point(12, 170);
            this.InputPassword.Name = "InputPassword";
            this.InputPassword.Size = new System.Drawing.Size(191, 20);
            this.InputPassword.TabIndex = 2;
            // 
            // InputEmail
            // 
            this.InputEmail.Location = new System.Drawing.Point(12, 214);
            this.InputEmail.Name = "InputEmail";
            this.InputEmail.Size = new System.Drawing.Size(191, 20);
            this.InputEmail.TabIndex = 3;
            // 
            // saveuser
            // 
            this.saveuser.Location = new System.Drawing.Point(67, 240);
            this.saveuser.Name = "saveuser";
            this.saveuser.Size = new System.Drawing.Size(75, 23);
            this.saveuser.TabIndex = 4;
            this.saveuser.Text = "Guardar";
            this.saveuser.UseVisualStyleBackColor = true;
            this.saveuser.Click += new System.EventHandler(this.saveuser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "No conectado";
            // 
            // listausuarios
            // 
            this.listausuarios.FormattingEnabled = true;
            this.listausuarios.Location = new System.Drawing.Point(218, 12);
            this.listausuarios.Name = "listausuarios";
            this.listausuarios.Size = new System.Drawing.Size(241, 290);
            this.listausuarios.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Añadir usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Email";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 309);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listausuarios);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveuser);
            this.Controls.Add(this.InputEmail);
            this.Controls.Add(this.InputPassword);
            this.Controls.Add(this.InputUsername);
            this.Controls.Add(this.connectdatabase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectdatabase;
        private System.Windows.Forms.TextBox InputUsername;
        private System.Windows.Forms.TextBox InputPassword;
        private System.Windows.Forms.TextBox InputEmail;
        private System.Windows.Forms.Button saveuser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listausuarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

