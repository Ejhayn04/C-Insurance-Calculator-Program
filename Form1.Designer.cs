namespace Program_2
{
    partial class Form_Program2
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
            this.lb_age = new System.Windows.Forms.Label();
            this.lb_car = new System.Windows.Forms.Label();
            this.lb_HealthCov = new System.Windows.Forms.Label();
            this.lb_CarCov = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.combo_Hc = new System.Windows.Forms.ComboBox();
            this.combo_carCov = new System.Windows.Forms.ComboBox();
            this.tb_enterage = new System.Windows.Forms.TextBox();
            this.tb_Year = new System.Windows.Forms.TextBox();
            this.lb_HCPY = new System.Windows.Forms.Label();
            this.lb_CCCPY = new System.Windows.Forms.Label();
            this.lb_TotalCost = new System.Windows.Forms.Label();
            this.lb_HealthCost = new System.Windows.Forms.Label();
            this.lb_CarCost = new System.Windows.Forms.Label();
            this.lb_TotalOp = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioSmoke_No = new System.Windows.Forms.RadioButton();
            this.radioSmoke_yes = new System.Windows.Forms.RadioButton();
            this.lb_Smoke = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioYear_No = new System.Windows.Forms.RadioButton();
            this.radioYear_Yes = new System.Windows.Forms.RadioButton();
            this.lb_Year = new System.Windows.Forms.Label();
            this.button_calculate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_age
            // 
            this.lb_age.AutoSize = true;
            this.lb_age.Location = new System.Drawing.Point(67, 105);
            this.lb_age.Name = "lb_age";
            this.lb_age.Size = new System.Drawing.Size(123, 20);
            this.lb_age.TabIndex = 0;
            this.lb_age.Text = "Enter Your Age:";
            // 
            // lb_car
            // 
            this.lb_car.AutoSize = true;
            this.lb_car.Location = new System.Drawing.Point(67, 165);
            this.lb_car.Name = "lb_car";
            this.lb_car.Size = new System.Drawing.Size(188, 20);
            this.lb_car.TabIndex = 1;
            this.lb_car.Text = "Manufacture Year of Car:";
            // 
            // lb_HealthCov
            // 
            this.lb_HealthCov.AutoSize = true;
            this.lb_HealthCov.Location = new System.Drawing.Point(67, 226);
            this.lb_HealthCov.Name = "lb_HealthCov";
            this.lb_HealthCov.Size = new System.Drawing.Size(207, 20);
            this.lb_HealthCov.TabIndex = 2;
            this.lb_HealthCov.Text = "Health Insurance Coverage:";
            // 
            // lb_CarCov
            // 
            this.lb_CarCov.AutoSize = true;
            this.lb_CarCov.Location = new System.Drawing.Point(67, 294);
            this.lb_CarCov.Name = "lb_CarCov";
            this.lb_CarCov.Size = new System.Drawing.Size(181, 20);
            this.lb_CarCov.TabIndex = 3;
            this.lb_CarCov.Text = "Car Insurance Coverage";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(261, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cardinal Insurance Policy Calculator";
            // 
            // combo_Hc
            // 
            this.combo_Hc.FormattingEnabled = true;
            this.combo_Hc.Items.AddRange(new object[] {
            "EPO",
            "PPO",
            "HDP"});
            this.combo_Hc.Location = new System.Drawing.Point(310, 226);
            this.combo_Hc.Name = "combo_Hc";
            this.combo_Hc.Size = new System.Drawing.Size(121, 28);
            this.combo_Hc.TabIndex = 5;
            // 
            // combo_carCov
            // 
            this.combo_carCov.FormattingEnabled = true;
            this.combo_carCov.Items.AddRange(new object[] {
            "Full",
            "Liability"});
            this.combo_carCov.Location = new System.Drawing.Point(310, 294);
            this.combo_carCov.Name = "combo_carCov";
            this.combo_carCov.Size = new System.Drawing.Size(121, 28);
            this.combo_carCov.TabIndex = 6;
            // 
            // tb_enterage
            // 
            this.tb_enterage.Location = new System.Drawing.Point(363, 104);
            this.tb_enterage.Name = "tb_enterage";
            this.tb_enterage.Size = new System.Drawing.Size(100, 26);
            this.tb_enterage.TabIndex = 7;
            // 
            // tb_Year
            // 
            this.tb_Year.Location = new System.Drawing.Point(363, 165);
            this.tb_Year.Name = "tb_Year";
            this.tb_Year.Size = new System.Drawing.Size(100, 26);
            this.tb_Year.TabIndex = 8;
            // 
            // lb_HCPY
            // 
            this.lb_HCPY.AutoSize = true;
            this.lb_HCPY.Location = new System.Drawing.Point(43, 777);
            this.lb_HCPY.Name = "lb_HCPY";
            this.lb_HCPY.Size = new System.Drawing.Size(234, 20);
            this.lb_HCPY.TabIndex = 15;
            this.lb_HCPY.Text = "Health Coverage Cost per Year:";
            // 
            // lb_CCCPY
            // 
            this.lb_CCCPY.AutoSize = true;
            this.lb_CCCPY.Location = new System.Drawing.Point(43, 842);
            this.lb_CCCPY.Name = "lb_CCCPY";
            this.lb_CCCPY.Size = new System.Drawing.Size(212, 20);
            this.lb_CCCPY.TabIndex = 16;
            this.lb_CCCPY.Text = "Car Coverage Cost per Year:";
            // 
            // lb_TotalCost
            // 
            this.lb_TotalCost.AutoSize = true;
            this.lb_TotalCost.Location = new System.Drawing.Point(40, 906);
            this.lb_TotalCost.Name = "lb_TotalCost";
            this.lb_TotalCost.Size = new System.Drawing.Size(194, 20);
            this.lb_TotalCost.TabIndex = 17;
            this.lb_TotalCost.Text = "Total Policy Cost per Year:";
            // 
            // lb_HealthCost
            // 
            this.lb_HealthCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_HealthCost.Location = new System.Drawing.Point(300, 777);
            this.lb_HealthCost.Name = "lb_HealthCost";
            this.lb_HealthCost.Size = new System.Drawing.Size(100, 23);
            this.lb_HealthCost.TabIndex = 18;
            // 
            // lb_CarCost
            // 
            this.lb_CarCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_CarCost.Location = new System.Drawing.Point(300, 842);
            this.lb_CarCost.Name = "lb_CarCost";
            this.lb_CarCost.Size = new System.Drawing.Size(100, 23);
            this.lb_CarCost.TabIndex = 19;
            // 
            // lb_TotalOp
            // 
            this.lb_TotalOp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_TotalOp.Location = new System.Drawing.Point(300, 906);
            this.lb_TotalOp.Name = "lb_TotalOp";
            this.lb_TotalOp.Size = new System.Drawing.Size(100, 23);
            this.lb_TotalOp.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioSmoke_No);
            this.groupBox1.Controls.Add(this.radioSmoke_yes);
            this.groupBox1.Controls.Add(this.lb_Smoke);
            this.groupBox1.Location = new System.Drawing.Point(71, 381);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 144);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // radioSmoke_No
            // 
            this.radioSmoke_No.AutoSize = true;
            this.radioSmoke_No.Location = new System.Drawing.Point(172, 101);
            this.radioSmoke_No.Name = "radioSmoke_No";
            this.radioSmoke_No.Size = new System.Drawing.Size(54, 24);
            this.radioSmoke_No.TabIndex = 12;
            this.radioSmoke_No.TabStop = true;
            this.radioSmoke_No.Text = "No";
            this.radioSmoke_No.UseVisualStyleBackColor = true;
            // 
            // radioSmoke_yes
            // 
            this.radioSmoke_yes.AutoSize = true;
            this.radioSmoke_yes.Location = new System.Drawing.Point(172, 49);
            this.radioSmoke_yes.Name = "radioSmoke_yes";
            this.radioSmoke_yes.Size = new System.Drawing.Size(62, 24);
            this.radioSmoke_yes.TabIndex = 11;
            this.radioSmoke_yes.TabStop = true;
            this.radioSmoke_yes.Text = "Yes";
            this.radioSmoke_yes.UseVisualStyleBackColor = true;
            // 
            // lb_Smoke
            // 
            this.lb_Smoke.AutoSize = true;
            this.lb_Smoke.Location = new System.Drawing.Point(6, 54);
            this.lb_Smoke.Name = "lb_Smoke";
            this.lb_Smoke.Size = new System.Drawing.Size(126, 20);
            this.lb_Smoke.TabIndex = 10;
            this.lb_Smoke.Text = "Do You Smoke?";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioYear_No);
            this.groupBox2.Controls.Add(this.radioYear_Yes);
            this.groupBox2.Controls.Add(this.lb_Year);
            this.groupBox2.Location = new System.Drawing.Point(73, 553);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(410, 114);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // radioYear_No
            // 
            this.radioYear_No.AutoSize = true;
            this.radioYear_No.Location = new System.Drawing.Point(290, 84);
            this.radioYear_No.Name = "radioYear_No";
            this.radioYear_No.Size = new System.Drawing.Size(54, 24);
            this.radioYear_No.TabIndex = 13;
            this.radioYear_No.TabStop = true;
            this.radioYear_No.Text = "No";
            this.radioYear_No.UseVisualStyleBackColor = true;
            // 
            // radioYear_Yes
            // 
            this.radioYear_Yes.AutoSize = true;
            this.radioYear_Yes.Location = new System.Drawing.Point(290, 36);
            this.radioYear_Yes.Name = "radioYear_Yes";
            this.radioYear_Yes.Size = new System.Drawing.Size(62, 24);
            this.radioYear_Yes.TabIndex = 12;
            this.radioYear_Yes.TabStop = true;
            this.radioYear_Yes.Text = "Yes";
            this.radioYear_Yes.UseVisualStyleBackColor = true;
            // 
            // lb_Year
            // 
            this.lb_Year.AutoSize = true;
            this.lb_Year.Location = new System.Drawing.Point(6, 41);
            this.lb_Year.Name = "lb_Year";
            this.lb_Year.Size = new System.Drawing.Size(226, 20);
            this.lb_Year.TabIndex = 11;
            this.lb_Year.Text = "Car Accident in the Past Year?";
            // 
            // button_calculate
            // 
            this.button_calculate.AutoSize = true;
            this.button_calculate.Location = new System.Drawing.Point(184, 692);
            this.button_calculate.Name = "button_calculate";
            this.button_calculate.Size = new System.Drawing.Size(203, 30);
            this.button_calculate.TabIndex = 23;
            this.button_calculate.Text = "Calculate Policy Premiums";
            this.button_calculate.UseVisualStyleBackColor = true;
            this.button_calculate.Click += new System.EventHandler(this.button_calculate_Click);
            // 
            // Form_Program2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 972);
            this.Controls.Add(this.button_calculate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_TotalOp);
            this.Controls.Add(this.lb_CarCost);
            this.Controls.Add(this.lb_HealthCost);
            this.Controls.Add(this.lb_TotalCost);
            this.Controls.Add(this.lb_CCCPY);
            this.Controls.Add(this.lb_HCPY);
            this.Controls.Add(this.tb_Year);
            this.Controls.Add(this.tb_enterage);
            this.Controls.Add(this.combo_carCov);
            this.Controls.Add(this.combo_Hc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_CarCov);
            this.Controls.Add(this.lb_HealthCov);
            this.Controls.Add(this.lb_car);
            this.Controls.Add(this.lb_age);
            this.Name = "Form_Program2";
            this.Text = "Insurance Policy Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_age;
        private System.Windows.Forms.Label lb_car;
        private System.Windows.Forms.Label lb_HealthCov;
        private System.Windows.Forms.Label lb_CarCov;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combo_Hc;
        private System.Windows.Forms.ComboBox combo_carCov;
        private System.Windows.Forms.TextBox tb_enterage;
        private System.Windows.Forms.TextBox tb_Year;
        private System.Windows.Forms.Label lb_HCPY;
        private System.Windows.Forms.Label lb_CCCPY;
        private System.Windows.Forms.Label lb_TotalCost;
        private System.Windows.Forms.Label lb_HealthCost;
        private System.Windows.Forms.Label lb_CarCost;
        private System.Windows.Forms.Label lb_TotalOp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioSmoke_No;
        private System.Windows.Forms.RadioButton radioSmoke_yes;
        private System.Windows.Forms.Label lb_Smoke;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioYear_No;
        private System.Windows.Forms.RadioButton radioYear_Yes;
        private System.Windows.Forms.Label lb_Year;
        private System.Windows.Forms.Button button_calculate;
    }
}

