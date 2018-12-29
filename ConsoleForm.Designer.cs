namespace AthenaExternal
{
    partial class ConsoleForm
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
            this.console = new System.Windows.Forms.TextBox();
            this.consoleCmd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // console
            // 
            this.console.BackColor = System.Drawing.SystemColors.InfoText;
            this.console.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.console.Location = new System.Drawing.Point(-1, -4);
            this.console.Multiline = true;
            this.console.Name = "console";
            this.console.ReadOnly = true;
            this.console.Size = new System.Drawing.Size(796, 366);
            this.console.TabIndex = 0;
            this.console.Text = "Welcome to Athena! Type \'cmds\' for a list of console commands.";
            // 
            // consoleCmd
            // 
            this.consoleCmd.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.consoleCmd.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.consoleCmd.Location = new System.Drawing.Point(-1, 360);
            this.consoleCmd.Name = "consoleCmd";
            this.consoleCmd.Size = new System.Drawing.Size(796, 22);
            this.consoleCmd.TabIndex = 1;
            this.consoleCmd.TextChanged += new System.EventHandler(this.consoleCmd_TextChanged);
            // 
            // ConsoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 383);
            this.Controls.Add(this.consoleCmd);
            this.Controls.Add(this.console);
            this.Name = "ConsoleForm";
            this.Text = "Athena Console";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox console;
        private System.Windows.Forms.TextBox consoleCmd;
    }
}