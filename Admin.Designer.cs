namespace taxis
{
    partial class Admin
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
            lblmensajeAdmin = new Label();
            lblAdmin = new Label();
            SuspendLayout();
            // 
            // lblmensajeAdmin
            // 
            lblmensajeAdmin.AutoSize = true;
            lblmensajeAdmin.Location = new Point(169, 96);
            lblmensajeAdmin.Name = "lblmensajeAdmin";
            lblmensajeAdmin.Size = new Size(0, 15);
            lblmensajeAdmin.TabIndex = 0;
            // 
            // lblAdmin
            // 
            lblAdmin.AutoSize = true;
            lblAdmin.Location = new Point(278, 275);
            lblAdmin.Name = "lblAdmin";
            lblAdmin.Size = new Size(83, 15);
            lblAdmin.TabIndex = 1;
            lblAdmin.Text = "Administrador";
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblAdmin);
            Controls.Add(lblmensajeAdmin);
            Name = "Admin";
            Text = "Admin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblmensajeAdmin;
        private Label lblAdmin;
    }
}