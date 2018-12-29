namespace AthenaExternal
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.openConsole = new AthenaExternal.FlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.topmostpls = new AthenaExternal.FlatButton();
            this.changetrans = new AthenaExternal.FlatButton();
            this.opacityW = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Raleway", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(501, 70);
            this.label1.TabIndex = 2;
            this.label1.Text = "Athena - Settings";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(332, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 1);
            this.panel1.TabIndex = 6;
            // 
            // openConsole
            // 
            this.openConsole.BackColor = System.Drawing.Color.MediumTurquoise;
            this.openConsole.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openConsole.ForeColor = System.Drawing.Color.White;
            this.openConsole.Location = new System.Drawing.Point(846, 422);
            this.openConsole.Name = "openConsole";
            this.openConsole.OnHoverBackColor = System.Drawing.Color.DarkTurquoise;
            this.openConsole.Size = new System.Drawing.Size(168, 46);
            this.openConsole.TabIndex = 8;
            this.openConsole.Text = "Open Console";
            this.openConsole.UseVisualStyleBackColor = false;
            this.openConsole.Click += new System.EventHandler(this.openConsole_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Raleway", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(441, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 50);
            this.label2.TabIndex = 5;
            this.label2.Text = "Window";
            // 
            // topmostpls
            // 
            this.topmostpls.BackColor = System.Drawing.Color.MediumTurquoise;
            this.topmostpls.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topmostpls.ForeColor = System.Drawing.Color.White;
            this.topmostpls.Location = new System.Drawing.Point(422, 163);
            this.topmostpls.Name = "topmostpls";
            this.topmostpls.OnHoverBackColor = System.Drawing.Color.DarkTurquoise;
            this.topmostpls.Size = new System.Drawing.Size(228, 46);
            this.topmostpls.TabIndex = 9;
            this.topmostpls.Text = "Top Most: False";
            this.topmostpls.UseVisualStyleBackColor = false;
            this.topmostpls.Click += new System.EventHandler(this.topmostpls_Click);
            // 
            // changetrans
            // 
            this.changetrans.BackColor = System.Drawing.Color.MediumTurquoise;
            this.changetrans.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changetrans.ForeColor = System.Drawing.Color.White;
            this.changetrans.Location = new System.Drawing.Point(422, 315);
            this.changetrans.Name = "changetrans";
            this.changetrans.OnHoverBackColor = System.Drawing.Color.DarkTurquoise;
            this.changetrans.Size = new System.Drawing.Size(228, 46);
            this.changetrans.TabIndex = 10;
            this.changetrans.Text = "Change Opacity";
            this.changetrans.UseVisualStyleBackColor = false;
            this.changetrans.Click += new System.EventHandler(this.changetrans_Click);
            // 
            // opacityW
            // 
            this.opacityW.Location = new System.Drawing.Point(504, 275);
            this.opacityW.Name = "opacityW";
            this.opacityW.Size = new System.Drawing.Size(43, 22);
            this.opacityW.TabIndex = 11;
            this.opacityW.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Raleway", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(362, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(348, 50);
            this.label3.TabIndex = 12;
            this.label3.Text = "Window Opacity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Raleway", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(553, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 28);
            this.label4.TabIndex = 13;
            this.label4.Text = "%";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 480);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.opacityW);
            this.Controls.Add(this.changetrans);
            this.Controls.Add(this.topmostpls);
            this.Controls.Add(this.openConsole);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.Text = "Athena - Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private FlatButton openConsole;
        private System.Windows.Forms.Label label2;
        private FlatButton topmostpls;
        private FlatButton changetrans;
        private System.Windows.Forms.TextBox opacityW;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}