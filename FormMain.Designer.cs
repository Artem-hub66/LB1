namespace LB1
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelTop = new Panel();
            labelUsers = new Label();
            panel2 = new Panel();
            labelinAboutUsers = new Label();
            panelTop.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(labelUsers);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(5);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(10);
            panelTop.Size = new Size(684, 70);
            panelTop.TabIndex = 0;
            // 
            // labelUsers
            // 
            labelUsers.Dock = DockStyle.Fill;
            labelUsers.Location = new Point(10, 10);
            labelUsers.Name = "labelUsers";
            labelUsers.Size = new Size(664, 50);
            labelUsers.TabIndex = 0;
            labelUsers.Text = "Список пользователей";
            labelUsers.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(labelinAboutUsers);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 70);
            panel2.Margin = new Padding(5);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(684, 491);
            panel2.TabIndex = 1;
            // 
            // labelinAboutUsers
            // 
            labelinAboutUsers.AutoSize = true;
            labelinAboutUsers.Dock = DockStyle.Fill;
            labelinAboutUsers.Location = new Point(10, 10);
            labelinAboutUsers.Name = "labelinAboutUsers";
            labelinAboutUsers.Size = new Size(0, 25);
            labelinAboutUsers.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(684, 561);
            Controls.Add(panel2);
            Controls.Add(panelTop);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormMain";
            Text = "Пользователи";
            Load += FormMain_Load;
            panelTop.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Panel panel2;
        private Label labelUsers;
        private Label labelinAboutUsers;
    }
}
