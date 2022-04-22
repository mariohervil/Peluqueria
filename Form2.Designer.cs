
namespace P02
{
    partial class Form2
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
            this.radioButtonWomen = new System.Windows.Forms.RadioButton();
            this.radioButtonMen = new System.Windows.Forms.RadioButton();
            this.radioButtonChildren = new System.Windows.Forms.RadioButton();
            this.checkBoxWash = new System.Windows.Forms.CheckBox();
            this.checkBoxCutHairdo = new System.Windows.Forms.CheckBox();
            this.checkBoxHairdo = new System.Windows.Forms.CheckBox();
            this.checkBoxDye = new System.Windows.Forms.CheckBox();
            this.checkBoxPermanent = new System.Windows.Forms.CheckBox();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.labelhour = new System.Windows.Forms.Label();
            this.labelday = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonWomen
            // 
            this.radioButtonWomen.AutoSize = true;
            this.radioButtonWomen.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonWomen.Font = new System.Drawing.Font("Onyx", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonWomen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButtonWomen.Location = new System.Drawing.Point(252, 26);
            this.radioButtonWomen.Name = "radioButtonWomen";
            this.radioButtonWomen.Size = new System.Drawing.Size(80, 34);
            this.radioButtonWomen.TabIndex = 0;
            this.radioButtonWomen.TabStop = true;
            this.radioButtonWomen.Text = "Women";
            this.radioButtonWomen.UseVisualStyleBackColor = false;
            this.radioButtonWomen.CheckedChanged += new System.EventHandler(this.calculate);
            // 
            // radioButtonMen
            // 
            this.radioButtonMen.AutoSize = true;
            this.radioButtonMen.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonMen.Font = new System.Drawing.Font("Onyx", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButtonMen.Location = new System.Drawing.Point(426, 26);
            this.radioButtonMen.Name = "radioButtonMen";
            this.radioButtonMen.Size = new System.Drawing.Size(58, 34);
            this.radioButtonMen.TabIndex = 1;
            this.radioButtonMen.TabStop = true;
            this.radioButtonMen.Text = "Men";
            this.radioButtonMen.UseVisualStyleBackColor = false;
            this.radioButtonMen.CheckedChanged += new System.EventHandler(this.calculate);
            // 
            // radioButtonChildren
            // 
            this.radioButtonChildren.AutoSize = true;
            this.radioButtonChildren.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonChildren.Font = new System.Drawing.Font("Onyx", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonChildren.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButtonChildren.Location = new System.Drawing.Point(91, 26);
            this.radioButtonChildren.Name = "radioButtonChildren";
            this.radioButtonChildren.Size = new System.Drawing.Size(86, 34);
            this.radioButtonChildren.TabIndex = 2;
            this.radioButtonChildren.TabStop = true;
            this.radioButtonChildren.Text = "Children";
            this.radioButtonChildren.UseVisualStyleBackColor = false;
            this.radioButtonChildren.CheckedChanged += new System.EventHandler(this.calculate);
            // 
            // checkBoxWash
            // 
            this.checkBoxWash.AutoSize = true;
            this.checkBoxWash.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxWash.Font = new System.Drawing.Font("Onyx", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxWash.ForeColor = System.Drawing.Color.White;
            this.checkBoxWash.Location = new System.Drawing.Point(14, 40);
            this.checkBoxWash.Name = "checkBoxWash";
            this.checkBoxWash.Size = new System.Drawing.Size(68, 34);
            this.checkBoxWash.TabIndex = 3;
            this.checkBoxWash.Text = "Wash";
            this.checkBoxWash.UseVisualStyleBackColor = false;
            // 
            // checkBoxCutHairdo
            // 
            this.checkBoxCutHairdo.AutoSize = true;
            this.checkBoxCutHairdo.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxCutHairdo.Font = new System.Drawing.Font("Onyx", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCutHairdo.ForeColor = System.Drawing.Color.White;
            this.checkBoxCutHairdo.Location = new System.Drawing.Point(14, 74);
            this.checkBoxCutHairdo.Name = "checkBoxCutHairdo";
            this.checkBoxCutHairdo.Size = new System.Drawing.Size(116, 34);
            this.checkBoxCutHairdo.TabIndex = 4;
            this.checkBoxCutHairdo.Text = "Cut+ Hairdo";
            this.checkBoxCutHairdo.UseVisualStyleBackColor = false;
            // 
            // checkBoxHairdo
            // 
            this.checkBoxHairdo.AutoSize = true;
            this.checkBoxHairdo.Font = new System.Drawing.Font("Onyx", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxHairdo.ForeColor = System.Drawing.Color.White;
            this.checkBoxHairdo.Location = new System.Drawing.Point(14, 108);
            this.checkBoxHairdo.Name = "checkBoxHairdo";
            this.checkBoxHairdo.Size = new System.Drawing.Size(77, 34);
            this.checkBoxHairdo.TabIndex = 5;
            this.checkBoxHairdo.Text = "Hairdo";
            this.checkBoxHairdo.UseVisualStyleBackColor = true;
            // 
            // checkBoxDye
            // 
            this.checkBoxDye.AutoSize = true;
            this.checkBoxDye.Font = new System.Drawing.Font("Onyx", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDye.ForeColor = System.Drawing.Color.White;
            this.checkBoxDye.Location = new System.Drawing.Point(14, 142);
            this.checkBoxDye.Name = "checkBoxDye";
            this.checkBoxDye.Size = new System.Drawing.Size(56, 34);
            this.checkBoxDye.TabIndex = 7;
            this.checkBoxDye.Text = "Dye";
            this.checkBoxDye.UseVisualStyleBackColor = true;
            // 
            // checkBoxPermanent
            // 
            this.checkBoxPermanent.AutoSize = true;
            this.checkBoxPermanent.Font = new System.Drawing.Font("Onyx", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPermanent.ForeColor = System.Drawing.Color.White;
            this.checkBoxPermanent.Location = new System.Drawing.Point(14, 176);
            this.checkBoxPermanent.Name = "checkBoxPermanent";
            this.checkBoxPermanent.Size = new System.Drawing.Size(107, 34);
            this.checkBoxPermanent.TabIndex = 6;
            this.checkBoxPermanent.Text = "Permanent";
            this.checkBoxPermanent.UseVisualStyleBackColor = true;
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // labelhour
            // 
            this.labelhour.AutoSize = true;
            this.labelhour.BackColor = System.Drawing.Color.Transparent;
            this.labelhour.Font = new System.Drawing.Font("Onyx", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelhour.ForeColor = System.Drawing.Color.White;
            this.labelhour.Location = new System.Drawing.Point(3, 30);
            this.labelhour.Name = "labelhour";
            this.labelhour.Size = new System.Drawing.Size(31, 19);
            this.labelhour.TabIndex = 10;
            this.labelhour.Text = "label1";
            // 
            // labelday
            // 
            this.labelday.AutoSize = true;
            this.labelday.BackColor = System.Drawing.Color.Transparent;
            this.labelday.Font = new System.Drawing.Font("Onyx", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelday.ForeColor = System.Drawing.Color.White;
            this.labelday.Location = new System.Drawing.Point(3, 14);
            this.labelday.Name = "labelday";
            this.labelday.Size = new System.Drawing.Size(33, 19);
            this.labelday.TabIndex = 11;
            this.labelday.Text = "label2";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.labelday);
            this.panel2.Controls.Add(this.labelhour);
            this.panel2.Location = new System.Drawing.Point(605, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(95, 57);
            this.panel2.TabIndex = 12;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.BackColor = System.Drawing.Color.Black;
            this.textBoxTotal.Font = new System.Drawing.Font("Onyx", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotal.ForeColor = System.Drawing.Color.White;
            this.textBoxTotal.Location = new System.Drawing.Point(180, 380);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(231, 29);
            this.textBoxTotal.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.checkBoxPermanent);
            this.panel1.Controls.Add(this.checkBoxDye);
            this.panel1.Controls.Add(this.checkBoxCutHairdo);
            this.panel1.Controls.Add(this.checkBoxWash);
            this.panel1.Controls.Add(this.checkBoxHairdo);
            this.panel1.Location = new System.Drawing.Point(14, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 241);
            this.panel1.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Sienna;
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(561, 92);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(227, 267);
            this.panel3.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::P02.Properties.Resources.pngwing_com;
            this.pictureBox1.Image = global::P02.Properties.Resources.img;
            this.pictureBox1.InitialImage = global::P02.Properties.Resources.pngwing_com;
            this.pictureBox1.Location = new System.Drawing.Point(33, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 267);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.BackColor = System.Drawing.Color.Black;
            this.buttonCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalculate.Font = new System.Drawing.Font("Onyx", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculate.ForeColor = System.Drawing.Color.White;
            this.buttonCalculate.Location = new System.Drawing.Point(575, 380);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(200, 48);
            this.buttonCalculate.TabIndex = 9;
            this.buttonCalculate.Text = "Price";
            this.buttonCalculate.UseVisualStyleBackColor = false;
            this.buttonCalculate.Click += new System.EventHandler(this.calculate);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.radioButtonChildren);
            this.Controls.Add(this.radioButtonMen);
            this.Controls.Add(this.radioButtonWomen);
            this.Controls.Add(this.panel2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonWomen;
        private System.Windows.Forms.RadioButton radioButtonMen;
        private System.Windows.Forms.RadioButton radioButtonChildren;
        private System.Windows.Forms.CheckBox checkBoxWash;
        private System.Windows.Forms.CheckBox checkBoxCutHairdo;
        private System.Windows.Forms.CheckBox checkBoxHairdo;
        private System.Windows.Forms.CheckBox checkBoxDye;
        private System.Windows.Forms.CheckBox checkBoxPermanent;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelday;
        private System.Windows.Forms.Label labelhour;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCalculate;
    }
}