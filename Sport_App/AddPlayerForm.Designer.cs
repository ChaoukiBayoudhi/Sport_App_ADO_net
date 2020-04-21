namespace Sport_App
{
    partial class AddPlayerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_addplayer = new System.Windows.Forms.Button();
            this.bt_cacel = new System.Windows.Forms.Button();
            this.txt_goals = new System.Windows.Forms.TextBox();
            this.txt_poistionplayer = new System.Windows.Forms.TextBox();
            this.txt_nameplayer = new System.Windows.Forms.TextBox();
            this.txt_idplayer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Player";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Player Position";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Goals";
            // 
            // bt_addplayer
            // 
            this.bt_addplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_addplayer.Location = new System.Drawing.Point(177, 259);
            this.bt_addplayer.Name = "bt_addplayer";
            this.bt_addplayer.Size = new System.Drawing.Size(75, 23);
            this.bt_addplayer.TabIndex = 4;
            this.bt_addplayer.Text = "Add Player";
            this.bt_addplayer.UseVisualStyleBackColor = true;
            this.bt_addplayer.Click += new System.EventHandler(this.bt_addplayer_Click);
            // 
            // bt_cacel
            // 
            this.bt_cacel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cacel.Location = new System.Drawing.Point(402, 259);
            this.bt_cacel.Name = "bt_cacel";
            this.bt_cacel.Size = new System.Drawing.Size(75, 23);
            this.bt_cacel.TabIndex = 5;
            this.bt_cacel.Text = "Cancel";
            this.bt_cacel.UseVisualStyleBackColor = true;
            // 
            // txt_goals
            // 
            this.txt_goals.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_goals.Location = new System.Drawing.Point(177, 167);
            this.txt_goals.Name = "txt_goals";
            this.txt_goals.Size = new System.Drawing.Size(178, 24);
            this.txt_goals.TabIndex = 6;
            // 
            // txt_poistionplayer
            // 
            this.txt_poistionplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_poistionplayer.Location = new System.Drawing.Point(177, 117);
            this.txt_poistionplayer.Name = "txt_poistionplayer";
            this.txt_poistionplayer.Size = new System.Drawing.Size(178, 24);
            this.txt_poistionplayer.TabIndex = 7;
            // 
            // txt_nameplayer
            // 
            this.txt_nameplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nameplayer.Location = new System.Drawing.Point(177, 72);
            this.txt_nameplayer.Name = "txt_nameplayer";
            this.txt_nameplayer.Size = new System.Drawing.Size(178, 24);
            this.txt_nameplayer.TabIndex = 8;
            // 
            // txt_idplayer
            // 
            this.txt_idplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idplayer.Location = new System.Drawing.Point(177, 24);
            this.txt_idplayer.Name = "txt_idplayer";
            this.txt_idplayer.Size = new System.Drawing.Size(178, 24);
            this.txt_idplayer.TabIndex = 9;
            // 
            // AddPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 339);
            this.Controls.Add(this.txt_idplayer);
            this.Controls.Add(this.txt_nameplayer);
            this.Controls.Add(this.txt_poistionplayer);
            this.Controls.Add(this.txt_goals);
            this.Controls.Add(this.bt_cacel);
            this.Controls.Add(this.bt_addplayer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddPlayerForm";
            this.Text = "AddPlayerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_addplayer;
        private System.Windows.Forms.Button bt_cacel;
        private System.Windows.Forms.TextBox txt_goals;
        private System.Windows.Forms.TextBox txt_poistionplayer;
        private System.Windows.Forms.TextBox txt_nameplayer;
        private System.Windows.Forms.TextBox txt_idplayer;
    }
}