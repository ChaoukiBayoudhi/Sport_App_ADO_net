namespace Sport_App
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
            this.bt_addplayer = new System.Windows.Forms.Button();
            this.bt_modifyplayer = new System.Windows.Forms.Button();
            this.bt_deketeplayer = new System.Windows.Forms.Button();
            this.bt_showplyers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_addplayer
            // 
            this.bt_addplayer.Location = new System.Drawing.Point(140, 38);
            this.bt_addplayer.Name = "bt_addplayer";
            this.bt_addplayer.Size = new System.Drawing.Size(130, 35);
            this.bt_addplayer.TabIndex = 0;
            this.bt_addplayer.Text = "Add Player";
            this.bt_addplayer.UseVisualStyleBackColor = true;
            this.bt_addplayer.Click += new System.EventHandler(this.bt_addplayer_Click);
            // 
            // bt_modifyplayer
            // 
            this.bt_modifyplayer.Location = new System.Drawing.Point(140, 128);
            this.bt_modifyplayer.Name = "bt_modifyplayer";
            this.bt_modifyplayer.Size = new System.Drawing.Size(130, 35);
            this.bt_modifyplayer.TabIndex = 1;
            this.bt_modifyplayer.Text = "Modify Player";
            this.bt_modifyplayer.UseVisualStyleBackColor = true;
            // 
            // bt_deketeplayer
            // 
            this.bt_deketeplayer.Location = new System.Drawing.Point(140, 196);
            this.bt_deketeplayer.Name = "bt_deketeplayer";
            this.bt_deketeplayer.Size = new System.Drawing.Size(130, 35);
            this.bt_deketeplayer.TabIndex = 2;
            this.bt_deketeplayer.Text = "Delete Player";
            this.bt_deketeplayer.UseVisualStyleBackColor = true;
            // 
            // bt_showplyers
            // 
            this.bt_showplyers.Location = new System.Drawing.Point(140, 269);
            this.bt_showplyers.Name = "bt_showplyers";
            this.bt_showplyers.Size = new System.Drawing.Size(130, 35);
            this.bt_showplyers.TabIndex = 3;
            this.bt_showplyers.Text = "Show Players";
            this.bt_showplyers.UseVisualStyleBackColor = true;
            this.bt_showplyers.Click += new System.EventHandler(this.bt_showplyers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 450);
            this.Controls.Add(this.bt_showplyers);
            this.Controls.Add(this.bt_deketeplayer);
            this.Controls.Add(this.bt_modifyplayer);
            this.Controls.Add(this.bt_addplayer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_addplayer;
        private System.Windows.Forms.Button bt_modifyplayer;
        private System.Windows.Forms.Button bt_deketeplayer;
        private System.Windows.Forms.Button bt_showplyers;
    }
}

