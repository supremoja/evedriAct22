namespace evedriAct2
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
            this.lblName = new System.Windows.Forms.Label();
            this.chkBasketball = new System.Windows.Forms.CheckBox();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbFavoriteColor = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblHobbies = new System.Windows.Forms.Label();
            this.lblFavoriteColor = new System.Windows.Forms.Label();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.chkVolleyball = new System.Windows.Forms.CheckBox();
            this.chkSoccer = new System.Windows.Forms.CheckBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.lblSaying = new System.Windows.Forms.Label();
            this.txtSaying = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(153, 66);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // chkBasketball
            // 
            this.chkBasketball.AutoSize = true;
            this.chkBasketball.ForeColor = System.Drawing.Color.White;
            this.chkBasketball.Location = new System.Drawing.Point(277, 138);
            this.chkBasketball.Name = "chkBasketball";
            this.chkBasketball.Size = new System.Drawing.Size(75, 17);
            this.chkBasketball.TabIndex = 1;
            this.chkBasketball.Text = "Basketball";
            this.chkBasketball.UseVisualStyleBackColor = true;
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.ForeColor = System.Drawing.Color.White;
            this.radMale.Location = new System.Drawing.Point(277, 91);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(48, 17);
            this.radMale.TabIndex = 2;
            this.radMale.TabStop = true;
            this.radMale.Text = "Male";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(156, 329);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbFavoriteColor
            // 
            this.cmbFavoriteColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFavoriteColor.FormattingEnabled = true;
            this.cmbFavoriteColor.Items.AddRange(new object[] {
            "Pink",
            "Blue"});
            this.cmbFavoriteColor.Location = new System.Drawing.Point(277, 207);
            this.cmbFavoriteColor.Name = "cmbFavoriteColor";
            this.cmbFavoriteColor.Size = new System.Drawing.Size(121, 21);
            this.cmbFavoriteColor.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(277, 63);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 20);
            this.txtName.TabIndex = 5;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.ForeColor = System.Drawing.Color.White;
            this.lblGender.Location = new System.Drawing.Point(153, 93);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(45, 13);
            this.lblGender.TabIndex = 6;
            this.lblGender.Text = "Gender:";
            // 
            // lblHobbies
            // 
            this.lblHobbies.AutoSize = true;
            this.lblHobbies.ForeColor = System.Drawing.Color.White;
            this.lblHobbies.Location = new System.Drawing.Point(153, 138);
            this.lblHobbies.Name = "lblHobbies";
            this.lblHobbies.Size = new System.Drawing.Size(49, 13);
            this.lblHobbies.TabIndex = 7;
            this.lblHobbies.Text = "Hobbies:";
            // 
            // lblFavoriteColor
            // 
            this.lblFavoriteColor.AutoSize = true;
            this.lblFavoriteColor.ForeColor = System.Drawing.Color.White;
            this.lblFavoriteColor.Location = new System.Drawing.Point(153, 215);
            this.lblFavoriteColor.Name = "lblFavoriteColor";
            this.lblFavoriteColor.Size = new System.Drawing.Size(75, 13);
            this.lblFavoriteColor.TabIndex = 8;
            this.lblFavoriteColor.Text = "Favorite Color:";
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.ForeColor = System.Drawing.Color.White;
            this.radFemale.Location = new System.Drawing.Point(342, 93);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(59, 17);
            this.radFemale.TabIndex = 9;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "Female";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // chkVolleyball
            // 
            this.chkVolleyball.AutoSize = true;
            this.chkVolleyball.ForeColor = System.Drawing.Color.White;
            this.chkVolleyball.Location = new System.Drawing.Point(277, 161);
            this.chkVolleyball.Name = "chkVolleyball";
            this.chkVolleyball.Size = new System.Drawing.Size(70, 17);
            this.chkVolleyball.TabIndex = 10;
            this.chkVolleyball.Text = "Volleyball";
            this.chkVolleyball.UseVisualStyleBackColor = true;
            // 
            // chkSoccer
            // 
            this.chkSoccer.AutoSize = true;
            this.chkSoccer.ForeColor = System.Drawing.Color.White;
            this.chkSoccer.Location = new System.Drawing.Point(277, 184);
            this.chkSoccer.Name = "chkSoccer";
            this.chkSoccer.Size = new System.Drawing.Size(60, 17);
            this.chkSoccer.TabIndex = 11;
            this.chkSoccer.Text = "Soccer";
            this.chkSoccer.UseVisualStyleBackColor = true;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(342, 329);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 12;
            this.btnDisplay.Text = "DISPLAY";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // lblSaying
            // 
            this.lblSaying.AutoSize = true;
            this.lblSaying.ForeColor = System.Drawing.Color.White;
            this.lblSaying.Location = new System.Drawing.Point(153, 245);
            this.lblSaying.Name = "lblSaying";
            this.lblSaying.Size = new System.Drawing.Size(42, 13);
            this.lblSaying.TabIndex = 13;
            this.lblSaying.Text = "Saying:";
            // 
            // txtSaying
            // 
            this.txtSaying.Location = new System.Drawing.Point(277, 245);
            this.txtSaying.Multiline = true;
            this.txtSaying.Name = "txtSaying";
            this.txtSaying.Size = new System.Drawing.Size(121, 55);
            this.txtSaying.TabIndex = 14;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(250, 329);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(153, 165);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(0, 13);
            this.lblData.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(603, 422);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtSaying);
            this.Controls.Add(this.lblSaying);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.chkSoccer);
            this.Controls.Add(this.chkVolleyball);
            this.Controls.Add(this.radFemale);
            this.Controls.Add(this.lblFavoriteColor);
            this.Controls.Add(this.lblHobbies);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cmbFavoriteColor);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.radMale);
            this.Controls.Add(this.chkBasketball);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblHobbies;
        private System.Windows.Forms.Label lblFavoriteColor;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Label lblSaying;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.CheckBox chkBasketball;
        public System.Windows.Forms.RadioButton radMale;
        public System.Windows.Forms.ComboBox cmbFavoriteColor;
        public System.Windows.Forms.RadioButton radFemale;
        public System.Windows.Forms.CheckBox chkVolleyball;
        public System.Windows.Forms.CheckBox chkSoccer;
        public System.Windows.Forms.TextBox txtSaying;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Label lblData;
    }
}

