namespace VisualWebGuiApplication1
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

        #region Visual WebGui Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new Gizmox.WebGUI.Forms.TextBox();
            this.listBox1 = new Gizmox.WebGUI.Forms.ListBox();
            this.label1 = new Gizmox.WebGUI.Forms.Label();
            this.checkBox1 = new Gizmox.WebGUI.Forms.CheckBox();
            this.checkBox2 = new Gizmox.WebGUI.Forms.CheckBox();
            this.button1 = new Gizmox.WebGUI.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(158, 122);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.Location = new System.Drawing.Point(175, 185);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(100, 95);
            this.listBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(341, 231);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(77, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "checkBox1";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(341, 262);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(77, 17);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "checkBox2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button2";
            this.button1.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Size = new System.Drawing.Size(597, 425);
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.TextBox textBox1;
        private Gizmox.WebGUI.Forms.ListBox listBox1;
        private Gizmox.WebGUI.Forms.Label label1;
        private Gizmox.WebGUI.Forms.CheckBox checkBox1;
        private Gizmox.WebGUI.Forms.CheckBox checkBox2;
        private Gizmox.WebGUI.Forms.Button button1;
    }
}