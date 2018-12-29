namespace AthenaExternal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.close_form = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.script_shit = new FastColoredTextBoxNS.FastColoredTextBox();
            this.autocompleteMenu1 = new AutocompleteMenuNS.AutocompleteMenu();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flatButton3 = new AthenaExternal.FlatButton();
            this.flatButton2 = new AthenaExternal.FlatButton();
            this.flatButton1 = new AthenaExternal.FlatButton();
            this.excpls = new AthenaExternal.FlatButton();
            this.hitormissbatman = new System.Windows.Forms.ListBox();
            this.fix_it_felix = new AthenaExternal.FlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.script_shit)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // close_form
            // 
            this.close_form.BackColor = System.Drawing.Color.Transparent;
            this.close_form.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.close_form.FlatAppearance.BorderSize = 0;
            this.close_form.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_form.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_form.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.close_form.Location = new System.Drawing.Point(841, 2);
            this.close_form.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.close_form.Name = "close_form";
            this.close_form.Size = new System.Drawing.Size(27, 30);
            this.close_form.TabIndex = 14;
            this.close_form.Text = "X";
            this.close_form.UseVisualStyleBackColor = false;
            this.close_form.Click += new System.EventHandler(this.close_form_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(790, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 30);
            this.button1.TabIndex = 15;
            this.button1.Text = "_";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // script_shit
            // 
            this.script_shit.AutoCompleteBrackets = true;
            this.script_shit.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.autocompleteMenu1.SetAutocompleteMenu(this.script_shit, this.autocompleteMenu1);
            this.script_shit.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>.+)";
            this.script_shit.AutoScrollMinSize = new System.Drawing.Size(31, 19);
            this.script_shit.BackBrush = null;
            this.script_shit.BackColor = System.Drawing.Color.Transparent;
            this.script_shit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.script_shit.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.script_shit.CaretColor = System.Drawing.Color.Gray;
            this.script_shit.CharHeight = 19;
            this.script_shit.CharWidth = 10;
            this.script_shit.CommentPrefix = "--";
            this.script_shit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.script_shit.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.script_shit.Font = new System.Drawing.Font("Courier New", 10.2F);
            this.script_shit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.script_shit.IndentBackColor = System.Drawing.Color.Transparent;
            this.script_shit.IsReplaceMode = false;
            this.script_shit.LeftBracket = '(';
            this.script_shit.LeftBracket2 = '{';
            this.script_shit.LineNumberColor = System.Drawing.Color.MintCream;
            this.script_shit.Location = new System.Drawing.Point(-4, 30);
            this.script_shit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.script_shit.Name = "script_shit";
            this.script_shit.Paddings = new System.Windows.Forms.Padding(0);
            this.script_shit.RightBracket = ')';
            this.script_shit.RightBracket2 = '}';
            this.script_shit.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.script_shit.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("script_shit.ServiceColors")));
            this.script_shit.Size = new System.Drawing.Size(687, 372);
            this.script_shit.TabIndex = 16;
            this.script_shit.TextAreaBorderColor = System.Drawing.Color.White;
            this.script_shit.ToolTip = null;
            this.script_shit.Zoom = 100;
            this.script_shit.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.script_shit_TextChanged);
            this.script_shit.Load += new System.EventHandler(this.script_shit_Load);
            // 
            // autocompleteMenu1
            // 
            this.autocompleteMenu1.AppearInterval = 1;
            this.autocompleteMenu1.Colors = ((AutocompleteMenuNS.Colors)(resources.GetObject("autocompleteMenu1.Colors")));
            this.autocompleteMenu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.autocompleteMenu1.ImageList = null;
            this.autocompleteMenu1.Items = new string[] {
        "w",
        "workspace",
        "g",
        "game",
        "getfenv",
        "getreg",
        "getgenv",
        "getrenv",
        "getrawmetatable",
        "getmetatable",
        "gethwid",
        "getname",
        "GeyKeyDown",
        "getfflag",
        "geturl",
        "p",
        "print",
        "w",
        "warn",
        "wait",
        "r",
        "rawequal",
        "rawset",
        "rawget",
        "l",
        "loadstring",
        "local",
        "luac",
        "c",
        "CFrame",
        "Color3",
        "copystring",
        "b",
        "BrickColor",
        "i",
        "Instance",
        "isreadonly",
        "IsMouseButton1Down",
        "IsMouseButton2Down",
        "IsMouseButton3Down",
        "ipairs",
        "io",
        "s",
        "setreadonly",
        "setrawmetatable",
        "setmetatable",
        "setfenv",
        "setfflag",
        "string",
        "m",
        "make_writeable",
        "MouseButton1Click",
        "MouseButton2Click",
        "MouseButton3Click",
        "e",
        "Enum",
        "r",
        "Ray",
        "return",
        "v",
        "Vector3",
        "Vector2",
        "u",
        "UDim",
        "UDim2",
        "until",
        "t",
        "table",
        "toclipboard",
        "f",
        "for",
        "function",
        "p",
        "pairs",
        "w",
        "while",
        "e",
        "else",
        "elseif",
        "end"};
            this.autocompleteMenu1.TargetControlWrapper = null;
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.fix_it_felix);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.close_form);
            this.panel1.Location = new System.Drawing.Point(-4, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(871, 31);
            this.panel1.TabIndex = 22;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(16, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ATHENA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.flatButton3);
            this.panel2.Controls.Add(this.flatButton2);
            this.panel2.Controls.Add(this.flatButton1);
            this.panel2.Controls.Add(this.excpls);
            this.panel2.Location = new System.Drawing.Point(-4, 407);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(882, 43);
            this.panel2.TabIndex = 3;
            // 
            // flatButton3
            // 
            this.flatButton3.BackColor = System.Drawing.Color.Transparent;
            this.flatButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatButton3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.flatButton3.ForeColor = System.Drawing.Color.White;
            this.flatButton3.Location = new System.Drawing.Point(633, 0);
            this.flatButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flatButton3.Name = "flatButton3";
            this.flatButton3.OnHoverBackColor = System.Drawing.Color.DarkTurquoise;
            this.flatButton3.Size = new System.Drawing.Size(169, 36);
            this.flatButton3.TabIndex = 23;
            this.flatButton3.Text = "Inject";
            this.flatButton3.UseVisualStyleBackColor = false;
            this.flatButton3.Click += new System.EventHandler(this.flatButton3_Click);
            // 
            // flatButton2
            // 
            this.flatButton2.BackColor = System.Drawing.Color.Transparent;
            this.flatButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.flatButton2.ForeColor = System.Drawing.Color.White;
            this.flatButton2.Location = new System.Drawing.Point(449, 0);
            this.flatButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flatButton2.Name = "flatButton2";
            this.flatButton2.OnHoverBackColor = System.Drawing.Color.DarkTurquoise;
            this.flatButton2.Size = new System.Drawing.Size(173, 36);
            this.flatButton2.TabIndex = 23;
            this.flatButton2.Text = "Clear";
            this.flatButton2.UseVisualStyleBackColor = false;
            this.flatButton2.Click += new System.EventHandler(this.flatButton2_Click);
            // 
            // flatButton1
            // 
            this.flatButton1.BackColor = System.Drawing.Color.Transparent;
            this.flatButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.flatButton1.ForeColor = System.Drawing.Color.White;
            this.flatButton1.Location = new System.Drawing.Point(260, 0);
            this.flatButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flatButton1.Name = "flatButton1";
            this.flatButton1.OnHoverBackColor = System.Drawing.Color.DarkTurquoise;
            this.flatButton1.Size = new System.Drawing.Size(173, 36);
            this.flatButton1.TabIndex = 1;
            this.flatButton1.Text = "Open File";
            this.flatButton1.UseVisualStyleBackColor = false;
            this.flatButton1.Click += new System.EventHandler(this.flatButton1_Click);
            // 
            // excpls
            // 
            this.excpls.BackColor = System.Drawing.Color.Transparent;
            this.excpls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excpls.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.excpls.ForeColor = System.Drawing.Color.White;
            this.excpls.Location = new System.Drawing.Point(70, 0);
            this.excpls.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.excpls.Name = "excpls";
            this.excpls.OnHoverBackColor = System.Drawing.Color.DarkTurquoise;
            this.excpls.Size = new System.Drawing.Size(173, 36);
            this.excpls.TabIndex = 0;
            this.excpls.Text = "Execute";
            this.excpls.UseVisualStyleBackColor = false;
            this.excpls.Click += new System.EventHandler(this.excpls_Click);
            // 
            // hitormissbatman
            // 
            this.hitormissbatman.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.hitormissbatman.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hitormissbatman.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.hitormissbatman.FormattingEnabled = true;
            this.hitormissbatman.ItemHeight = 16;
            this.hitormissbatman.Location = new System.Drawing.Point(689, 30);
            this.hitormissbatman.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hitormissbatman.Name = "hitormissbatman";
            this.hitormissbatman.Size = new System.Drawing.Size(178, 370);
            this.hitormissbatman.TabIndex = 23;
            this.hitormissbatman.SelectedIndexChanged += new System.EventHandler(this.hitormissbatman_SelectedIndexChanged);
            this.hitormissbatman.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hitormissbatman_KeyPress);
            // 
            // fix_it_felix
            // 
            this.fix_it_felix.BackColor = System.Drawing.Color.Transparent;
            this.fix_it_felix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fix_it_felix.Font = new System.Drawing.Font("Segoe UI Semibold", 5F, System.Drawing.FontStyle.Bold);
            this.fix_it_felix.ForeColor = System.Drawing.Color.White;
            this.fix_it_felix.Location = new System.Drawing.Point(660, 3);
            this.fix_it_felix.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fix_it_felix.Name = "fix_it_felix";
            this.fix_it_felix.OnHoverBackColor = System.Drawing.Color.DarkTurquoise;
            this.fix_it_felix.Size = new System.Drawing.Size(105, 24);
            this.fix_it_felix.TabIndex = 24;
            this.fix_it_felix.Text = "Fix Injection";
            this.fix_it_felix.UseVisualStyleBackColor = false;
            this.fix_it_felix.Click += new System.EventHandler(this.fix_it_felix_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(879, 457);
            this.Controls.Add(this.hitormissbatman);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.script_shit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "a";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.script_shit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button close_form;
        private System.Windows.Forms.Button button1;
        private FastColoredTextBoxNS.FastColoredTextBox script_shit;
        private AutocompleteMenuNS.AutocompleteMenu autocompleteMenu1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private FlatButton flatButton3;
        private FlatButton flatButton2;
        private FlatButton flatButton1;
        private FlatButton excpls;
        private System.Windows.Forms.ListBox hitormissbatman;
        private FlatButton fix_it_felix;
    }
}

