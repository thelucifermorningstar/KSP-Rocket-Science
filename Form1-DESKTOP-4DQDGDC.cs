﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace KSP_Rocket_Science
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            

            //add body in list
          
            bod.Add(new calc.body { name = "Kerbin", radius = 600000, gm = 3530760595000 });
            bod.Add(new calc.body { name = "Mun", radius = 200000, gm = 65138398 });
            bod.Add(new calc.body { name = "Minmus", radius = 60000, gm = 1.7658000 });

            bod.Add(new calc.body { name = "Moho", radius = 250000, gm = 16860938 });

            bod.Add(new calc.body { name = "Eve", radius = 700000, gm = 81717302 });



            //add itens in combo box
            foreach (var it in bod)
            {
                cmb_body.Items.Add(it.name + " (R = " + it.radius + ")");
            }

            cmbIndex = 0;


        }


        calc.calcs doMath = new calc.calcs();
        

        List<calc.body> bod = new List<calc.body>();

        double radius, gm;

        int cmbIndex;

        private void btn_calc_Click(object sender, EventArgs e)
        {
            if (tab_maths.SelectedTab == tabPage1)
            {

               
                    double deltaV;

                    deltaV = doMath.deltaV(Convert.ToDouble(txb_totalMass.Text), Convert.ToDouble(txb_emptyMass.Text), Convert.ToDouble(txb_isp.Text));

                    lbl_result.Text = Convert.ToString(deltaV);
                
            }

            if(tab_maths.SelectedTab == tabPage2)
            {
                if (Convert.ToDouble(txb_finalOrbit.Text) <= bod[cmbIndex].radius)
                {
                    MessageBox.Show("The final orbit must be greater than the radius of the body you are orbiting. " + bod[cmbIndex].name + " radius = " + bod[cmbIndex].radius);
                    txb_finalOrbit.Text = Convert.ToString(radius + 1);

                }
                else
                {
                    double initialOrbit;

                    initialOrbit = doMath.commNet(Convert.ToDouble(txb_finalOrbit.Text), Convert.ToDouble(radius), Convert.ToDouble(gm), Convert.ToInt32(txb_satNumber.Text));

                    lbl_result.Text = "IO " + Convert.ToString(initialOrbit);
                }


            }
        }
    
        private void txb_isp_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txb_isp_KeyDown(object sender, KeyEventArgs e)
        {
            

           
        }

        private void button1_Click(object sender, EventArgs e)
        {


            clearTxb(tabPage1);
            clearTxb(tabPage2);

        }

        private void clearTxb(Control tabpage)
        {
            foreach (Control objCtrl in tabpage.Controls)
            {
                if (objCtrl is TextBox)
                {
                    objCtrl.Text = "";
                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void txb_totalMass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_finalOrbit_TextChanged(object sender, EventArgs e)
        {
            if (txb_finalOrbit.Text != "")
            {
                if (Convert.ToDouble(txb_finalOrbit.Text) <= bod[cmbIndex].radius)
                {
                    //MessageBox.Show("The final orbit must be greater than the radius of the body you are orbiting. " + bod[cmbIndex].name + " radius = " + bod[cmbIndex].radius);
                    //txb_finalOrbit.Text = Convert.ToString(radius + 1);
                    lbl_error.Text = "The final orbit must be greater than the radius of the body you are orbiting. " + bod[cmbIndex].name + " radius = " + bod[cmbIndex].radius;
                }
                else
                {
                    lbl_error.Text = "";
                }
            }
            else
            {
                lbl_error.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmb_body_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            radius = bod[cmbIndex].radius;
            gm = bod[cmbIndex].gm;
            cmbIndex = cmbIndex;

            if (txb_finalOrbit.Text != "")
            {
                if (Convert.ToDouble(txb_finalOrbit.Text) <= bod[cmbIndex].radius)
                {
                    lbl_error.Text = "The final orbit must be greater than the radius of the body you are orbiting. " + bod[cmbIndex].name + " radius = " + bod[cmbIndex].radius;
                    //txb_finalOrbit.Text = Convert.ToString(radius + 1);
                }
                else
                {
                    lbl_error.Text = "";
                }
            }
        }
    }

    

}
