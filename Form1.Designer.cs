namespace KSP_Rocket_Science
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tab_maths = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txb_isp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_emptyMass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_totalMass = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_body = new System.Windows.Forms.ComboBox();
            this.txb_satNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txb_finalOrbit = new System.Windows.Forms.TextBox();
            this.btn_calc = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_result = new System.Windows.Forms.TextBox();
            this.lbl_error = new System.Windows.Forms.Label();
            this.tab_maths.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_maths
            // 
            this.tab_maths.Controls.Add(this.tabPage1);
            this.tab_maths.Controls.Add(this.tabPage2);
            this.tab_maths.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_maths.Location = new System.Drawing.Point(11, 59);
            this.tab_maths.Name = "tab_maths";
            this.tab_maths.SelectedIndex = 0;
            this.tab_maths.Size = new System.Drawing.Size(326, 160);
            this.tab_maths.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tab_maths.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txb_isp);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txb_emptyMass);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txb_totalMass);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(318, 123);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ΔV";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txb_isp
            // 
            this.txb_isp.Location = new System.Drawing.Point(122, 85);
            this.txb_isp.Name = "txb_isp";
            this.txb_isp.Size = new System.Drawing.Size(190, 29);
            this.txb_isp.TabIndex = 5;
            this.txb_isp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_isp_KeyDown);
            this.txb_isp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_isp_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 96);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(38, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "ISP";
            // 
            // txb_emptyMass
            // 
            this.txb_emptyMass.Location = new System.Drawing.Point(122, 48);
            this.txb_emptyMass.Name = "txb_emptyMass";
            this.txb_emptyMass.Size = new System.Drawing.Size(190, 29);
            this.txb_emptyMass.TabIndex = 3;
            this.txb_emptyMass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_emptyMass_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 56);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(112, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Empty Mass";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Mass";
            // 
            // txb_totalMass
            // 
            this.txb_totalMass.Location = new System.Drawing.Point(122, 11);
            this.txb_totalMass.Name = "txb_totalMass";
            this.txb_totalMass.Size = new System.Drawing.Size(190, 29);
            this.txb_totalMass.TabIndex = 0;
            this.txb_totalMass.TextChanged += new System.EventHandler(this.txb_totalMass_TextChanged);
            this.txb_totalMass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_totalMass_KeyPress);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.cmb_body);
            this.tabPage2.Controls.Add(this.txb_satNumber);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txb_finalOrbit);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(318, 123);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CommNet";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 51);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(53, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Body";
            // 
            // cmb_body
            // 
            this.cmb_body.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_body.FormattingEnabled = true;
            this.cmb_body.Location = new System.Drawing.Point(122, 48);
            this.cmb_body.Name = "cmb_body";
            this.cmb_body.Size = new System.Drawing.Size(190, 32);
            this.cmb_body.TabIndex = 14;
            this.cmb_body.SelectedIndexChanged += new System.EventHandler(this.cmb_body_SelectedIndexChanged);
            // 
            // txb_satNumber
            // 
            this.txb_satNumber.Location = new System.Drawing.Point(122, 85);
            this.txb_satNumber.Name = "txb_satNumber";
            this.txb_satNumber.Size = new System.Drawing.Size(189, 29);
            this.txb_satNumber.TabIndex = 13;
            this.txb_satNumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txb_satNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_satNumber_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 85);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(110, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Sat Number";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 14);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(96, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Final Orbit";
            // 
            // txb_finalOrbit
            // 
            this.txb_finalOrbit.Location = new System.Drawing.Point(122, 11);
            this.txb_finalOrbit.Name = "txb_finalOrbit";
            this.txb_finalOrbit.Size = new System.Drawing.Size(189, 29);
            this.txb_finalOrbit.TabIndex = 6;
            this.txb_finalOrbit.TextChanged += new System.EventHandler(this.txb_finalOrbit_TextChanged);
            this.txb_finalOrbit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_finalOrbit_KeyPress);
            // 
            // btn_calc
            // 
            this.btn_calc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_calc.FlatAppearance.BorderSize = 0;
            this.btn_calc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calc.Location = new System.Drawing.Point(12, 225);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(88, 43);
            this.btn_calc.TabIndex = 6;
            this.btn_calc.Text = "CALC";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(233, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 43);
            this.button1.TabIndex = 8;
            this.button1.Text = "CLEAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_result
            // 
            this.lbl_result.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_result.Location = new System.Drawing.Point(0, 8);
            this.lbl_result.Multiline = true;
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.ReadOnly = true;
            this.lbl_result.Size = new System.Drawing.Size(351, 45);
            this.lbl_result.TabIndex = 9;
            this.lbl_result.Text = "0";
            this.lbl_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_error
            // 
            this.lbl_error.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(11, 271);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_error.Size = new System.Drawing.Size(326, 32);
            this.lbl_error.TabIndex = 13;
            this.lbl_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(349, 312);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.tab_maths);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KSP Rocket Science";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tab_maths.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tab_maths;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.TextBox txb_isp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_emptyMass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_totalMass;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox lbl_result;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txb_finalOrbit;
        private System.Windows.Forms.TextBox txb_satNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_body;
        private System.Windows.Forms.Label lbl_error;
    }
}

