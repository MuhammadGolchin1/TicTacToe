using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace Dooz_Game
{

    public partial class Form1 : Form
    {
        int imp = 0; //0 is 2 player || 1 ez|| 2 normal ||3 impossible
        int pc = 0;
        int harekate_aval;
        int harekate_dovom;
        int harekate_sevom;
        int harekate_chaharom;
        int rang = 10;
        int shomare_barende = 0;//red 1 blue 0
        //Rang = 10 Blue is Starter and rang=9 Computer is starter // Rang dovom tag shode 

        //int shomare_barende = 0;//red 1 blue 0    //Dar barrasy dovam fahmidam : Fek konam ezafiee pas hame ro comment kardam
        int red_win, blue_win, draw = 0;

        // Red is computer and blue is User

        public void AI()
        {
            barande();
            if (rang == 9)
            {

                if (button1.Enabled == true
                    && button2.Enabled == true
                    && button3.Enabled == true
                    && button4.Enabled == true
                    && button5.Enabled == true
                    && button6.Enabled == true
                    && button7.Enabled == true
                    && button8.Enabled == true
                    && button9.Enabled == true)
                {
                    pc = 1;
                    button2.BackColor = Color.Red;
                    button2.Text = "x";
                    button2.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;

                }

                else if (button1.Enabled == false)
                {
                    harekate_aval = 1;
                    button5.BackColor = Color.Red;
                    button5.Text = "x";
                    button5.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;


                }
                else if (button2.Enabled == false)
                {
                    harekate_aval = 2;
                    button5.BackColor = Color.Red;
                    button5.Text = "x";
                    button5.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;
                }
                else if (button3.Enabled == false)
                {
                    harekate_aval = 3;
                    button5.BackColor = Color.Red;
                    button5.Text = "x";
                    button5.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;
                }
                else if (button4.Enabled == false)
                {
                    harekate_aval = 4;
                    button5.BackColor = Color.Red;
                    button5.Text = "x";
                    button5.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;
                }
                else if (button5.Enabled == false)
                {
                    harekate_aval = 5;
                    button3.BackColor = Color.Red;
                    button3.Text = "x";
                    button3.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;
                }
                else if (button6.Enabled == false)
                {
                    harekate_aval = 6;
                    button5.BackColor = Color.Red;
                    button5.Text = "x";
                    button5.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;

                }
                else if (button7.Enabled == false)
                {
                    harekate_aval = 7;
                    button5.BackColor = Color.Red;
                    button5.Text = "x";
                    button5.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;
                }
                else if (button8.Enabled == false)
                {
                    harekate_aval = 8;
                    button5.BackColor = Color.Red;
                    button5.Text = "x";
                    button5.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;
                }
                else if (button9.Enabled == false)
                {

                    harekate_aval = 9;
                    button5.BackColor = Color.Red;
                    button5.Text = "x";
                    button5.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;
                }
            }
            else if (rang == 7)
            {
                if (/*button1.BackColor == Color.Blue && */harekate_aval == 1)
                {
                    if (button2.BackColor == Color.Blue)
                    {
                        harekate_dovom = 2;
                        button3.BackColor = Color.Red;
                        button3.Text = "x";
                        button3.Enabled = false;
                    }
                    else if (button3.BackColor == Color.Blue)
                    {
                        harekate_dovom = 3;
                        button2.BackColor = Color.Red;
                        button2.Text = "x";
                        button2.Enabled = false;
                    }
                    else if (button4.BackColor == Color.Blue)
                    {
                        harekate_dovom = 4;
                        button7.BackColor = Color.Red;
                        button7.Text = "x";
                        button7.Enabled = false;
                    }
                    else if (button6.BackColor == Color.Blue)
                    {
                        harekate_dovom = 6;
                        button2.BackColor = Color.Red;
                        button2.Text = "x";
                        button2.Enabled = false;
                    }
                    else if (button7.BackColor == Color.Blue)
                    {
                        harekate_dovom = 7;
                        button4.BackColor = Color.Red;
                        button4.Text = "x";
                        button4.Enabled = false;
                    }
                    else if (button8.BackColor == Color.Blue)
                    {
                        harekate_dovom = 8;
                        button4.BackColor = Color.Red;
                        button4.Text = "x";
                        button4.Enabled = false;
                    }
                    else if (button9.BackColor == Color.Blue)
                    {
                        harekate_dovom = 9;
                        button4.BackColor = Color.Red;
                        button4.Text = "x";
                        button4.Enabled = false;
                    }
                    label1.Text = "player's Blue turn";
                    rang--;

                }
                else if (button2.BackColor == Color.Blue && button3.BackColor == Color.Blue && harekate_aval == 2)
                {
                    harekate_dovom = 3;
                    button1.BackColor = Color.Red;
                    button1.Text = "x";
                    button1.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;
                }
                else if (button2.BackColor == Color.Blue && button4.BackColor == Color.Blue && harekate_aval == 2)
                {
                    harekate_dovom = 4;
                    button7.BackColor = Color.Red;
                    button7.Text = "x";
                    button7.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;
                }
                else if (button2.BackColor == Color.Blue && button6.BackColor == Color.Blue && harekate_aval == 2)
                {
                    harekate_dovom = 6;
                    button9.BackColor = Color.Red;
                    button9.Text = "x";
                    button9.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;
                }
                else if (button2.BackColor == Color.Blue && button7.BackColor == Color.Blue && harekate_aval == 2)
                {
                    harekate_dovom = 7;
                    button4.BackColor = Color.Red;
                    button4.Text = "x";
                    button4.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;
                }
                else if (button2.BackColor == Color.Blue && button8.BackColor == Color.Blue && harekate_aval == 2)
                {
                    harekate_dovom = 8;
                    button7.BackColor = Color.Red;
                    button7.Text = "x";
                    button7.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;
                }
                else if (button2.BackColor == Color.Blue && button9.BackColor == Color.Blue && harekate_aval == 2)
                {
                    harekate_dovom = 9;
                    button6.BackColor = Color.Red;
                    button6.Text = "x";
                    button6.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;
                }
                else if (button2.BackColor == Color.Blue && button1.BackColor == Color.Blue && harekate_aval == 2)
                {
                    harekate_dovom = 1;
                    button3.BackColor = Color.Red;
                    button3.Text = "x";
                    button3.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;
                }

                else if (button3.BackColor == Color.Blue && button1.BackColor == Color.Blue && harekate_aval == 3)
                {
                    harekate_dovom = 1;
                    button2.BackColor = Color.Red;
                    button2.Text = "x";
                    button2.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;
                }
                else if (button3.BackColor == Color.Blue && button2.BackColor == Color.Blue && harekate_aval == 3)
                {
                    harekate_dovom = 2;
                    button1.BackColor = Color.Red;
                    button1.Text = "x";
                    button1.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;
                }
                else if (button3.BackColor == Color.Blue && button4.BackColor == Color.Blue && harekate_aval == 3)
                {
                    harekate_dovom = 4;
                    button2.BackColor = Color.Red;
                    button2.Text = "x";
                    button2.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;
                }
                else if (button3.BackColor == Color.Blue && button6.BackColor == Color.Blue && harekate_aval == 3)
                {
                    harekate_dovom = 6;
                    button9.BackColor = Color.Red;
                    button9.Text = "x";
                    button9.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;
                }
                else if (button3.BackColor == Color.Blue && button7.BackColor == Color.Blue && harekate_aval == 3)
                {
                    harekate_dovom = 7;
                    button6.BackColor = Color.Red;
                    button6.Text = "x";
                    button6.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;
                }
                else if (button3.BackColor == Color.Blue && button8.BackColor == Color.Blue && harekate_aval == 3)
                {
                    harekate_dovom = 8;
                    button6.BackColor = Color.Red;
                    button6.Text = "x";
                    button6.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;
                }
                else if (button3.BackColor == Color.Blue && button9.BackColor == Color.Blue && harekate_aval == 3)
                {
                    harekate_dovom = 9;
                    button6.BackColor = Color.Red;
                    button6.Text = "x";
                    button6.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;
                }

                else if (button4.BackColor == Color.Blue && button1.BackColor == Color.Blue && harekate_aval == 4)
                {
                    harekate_dovom = 1;
                    button7.BackColor = Color.Red;
                    button7.Text = "x";
                    button7.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;
                }
                else if (button4.BackColor == Color.Blue && button2.BackColor == Color.Blue && harekate_aval == 4)
                {
                    harekate_dovom = 2;
                    button7.BackColor = Color.Red;
                    button7.Text = "x";
                    button7.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;
                }
                else if (button4.BackColor == Color.Blue && button3.BackColor == Color.Blue && harekate_aval == 4)
                {
                    harekate_dovom = 3;
                    button2.BackColor = Color.Red;
                    button2.Text = "x";
                    button2.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;
                }
                else if (button4.BackColor == Color.Blue && button6.BackColor == Color.Blue && harekate_aval == 4)
                {
                    harekate_dovom = 6;
                    button7.BackColor = Color.Red;
                    button7.Text = "x";
                    button7.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;
                }
                else if (button4.BackColor == Color.Blue && button7.BackColor == Color.Blue && harekate_aval == 4)
                {
                    harekate_dovom = 7;
                    button1.BackColor = Color.Red;
                    button1.Text = "x";
                    button1.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;
                }
                else if (button4.BackColor == Color.Blue && button8.BackColor == Color.Blue && harekate_aval == 4)
                {
                    harekate_dovom = 8;
                    button1.BackColor = Color.Red;
                    button1.Text = "x";
                    button1.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;
                }
                else if (button4.BackColor == Color.Blue && button9.BackColor == Color.Blue && harekate_aval == 4)
                {
                    harekate_dovom = 9;
                    button8.BackColor = Color.Red;
                    button8.Text = "x";
                    button8.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;
                }

                else if (button5.BackColor == Color.Blue && button1.BackColor == Color.Blue && harekate_aval == 5)
                {
                    harekate_dovom = 1;
                    button9.BackColor = Color.Red;
                    button9.Text = "x";
                    button9.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;
                }
                else if (button5.BackColor == Color.Blue && button2.BackColor == Color.Blue && harekate_aval == 5)
                {
                    harekate_dovom = 2;
                    button8.BackColor = Color.Red;
                    button8.Text = "x";
                    button8.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;
                }
                else if (button5.BackColor == Color.Blue && button4.BackColor == Color.Blue && harekate_aval == 5)
                {
                    harekate_dovom = 4;
                    button6.BackColor = Color.Red;
                    button6.Text = "x";
                    button6.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;
                }
                else if (button5.BackColor == Color.Blue && button6.BackColor == Color.Blue && harekate_aval == 5)
                {
                    harekate_dovom = 6;
                    button4.BackColor = Color.Red;
                    button4.Text = "x";
                    button4.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;
                }
                else if (button5.BackColor == Color.Blue && button7.BackColor == Color.Blue && harekate_aval == 5)
                {
                    harekate_dovom = 7;
                    button9.BackColor = Color.Red;
                    button9.Text = "x";
                    button9.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;
                }
                else if (button5.BackColor == Color.Blue && button8.BackColor == Color.Blue && harekate_aval == 5)
                {
                    harekate_dovom = 8;
                    button2.BackColor = Color.Red;
                    button2.Text = "x";
                    button2.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;
                }
                else if (button5.BackColor == Color.Blue && button9.BackColor == Color.Blue && harekate_aval == 5)
                {
                    harekate_dovom = 9;
                    button1.BackColor = Color.Red;
                    button1.Text = "x";
                    button1.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;
                }

                else if (button6.BackColor == Color.Blue && button1.BackColor == Color.Blue && harekate_aval == 6)
                {
                    harekate_dovom = 1;
                    button2.BackColor = Color.Red;
                    button2.Text = "x";
                    button2.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;

                }
                else if (button6.BackColor == Color.Blue && button2.BackColor == Color.Blue && harekate_aval == 6)
                {
                    harekate_dovom = 2;
                    button3.BackColor = Color.Red;
                    button3.Text = "x";
                    button3.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;
                }
                else if (button6.BackColor == Color.Blue && button3.BackColor == Color.Blue && harekate_aval == 6)
                {
                    harekate_dovom = 3;
                    button9.BackColor = Color.Red;
                    button9.Text = "x";
                    button9.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;
                }
                else if (button6.BackColor == Color.Blue && button4.BackColor == Color.Blue && harekate_aval == 6)
                {
                    harekate_dovom = 4;
                    button7.BackColor = Color.Red;
                    button7.Text = "x";
                    button7.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;
                }
                else if (button6.BackColor == Color.Blue && button7.BackColor == Color.Blue && harekate_aval == 6)
                {
                    harekate_dovom = 7;
                    button9.BackColor = Color.Red;
                    button9.Text = "x";
                    button9.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;
                }
                else if (button6.BackColor == Color.Blue && button8.BackColor == Color.Blue && harekate_aval == 6)
                {
                    harekate_dovom = 8;
                    button9.BackColor = Color.Red;
                    button9.Text = "x";
                    button9.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;
                }
                else if (button6.BackColor == Color.Blue && button9.BackColor == Color.Blue && harekate_aval == 6)
                {
                    harekate_dovom = 9;
                    button3.BackColor = Color.Red;
                    button3.Text = "x";
                    button3.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;
                }

                else if (button7.BackColor == Color.Blue && button1.BackColor == Color.Blue && harekate_aval == 7)
                {
                    harekate_dovom = 1;
                    button4.BackColor = Color.Red;
                    button4.Text = "x";
                    button4.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;
                }
                else if (button7.BackColor == Color.Blue && button2.BackColor == Color.Blue && harekate_aval == 7)
                {
                    harekate_dovom = 2;
                    button1.BackColor = Color.Red;
                    button1.Text = "x";
                    button1.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;
                }
                else if (button7.BackColor == Color.Blue && button3.BackColor == Color.Blue && harekate_aval == 7)
                {
                    harekate_dovom = 3;
                    button4.BackColor = Color.Red;
                    button4.Text = "x";
                    button4.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;
                }
                else if (button7.BackColor == Color.Blue && button4.BackColor == Color.Blue && harekate_aval == 7)
                {
                    harekate_dovom = 4;
                    button1.BackColor = Color.Red;
                    button1.Text = "x";
                    button1.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;
                }
                else if (button7.BackColor == Color.Blue && button6.BackColor == Color.Blue && harekate_aval == 7)
                {
                    harekate_dovom = 6;
                    button9.BackColor = Color.Red;
                    button9.Text = "x";
                    button9.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;
                }
                else if (button7.BackColor == Color.Blue && button8.BackColor == Color.Blue && harekate_aval == 7)
                {
                    harekate_dovom = 8;
                    button9.BackColor = Color.Red;
                    button9.Text = "x";
                    button9.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;
                }
                else if (button7.BackColor == Color.Blue && button9.BackColor == Color.Blue && harekate_aval == 7)
                {
                    harekate_dovom = 9;
                    button8.BackColor = Color.Red;
                    button8.Text = "x";
                    button8.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;
                }

                else if (button8.BackColor == Color.Blue && button1.BackColor == Color.Blue && harekate_aval == 8)
                {
                    harekate_dovom = 1;
                    button7.BackColor = Color.Red;
                    button7.Text = "x";
                    button7.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;
                }
                else if (button8.BackColor == Color.Blue && button2.BackColor == Color.Blue && harekate_aval == 8)
                {
                    harekate_dovom = 2;
                    button9.BackColor = Color.Red;
                    button9.Text = "x";
                    button9.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;
                }
                else if (button8.BackColor == Color.Blue && button3.BackColor == Color.Blue && harekate_aval == 8)
                {
                    harekate_dovom = 3;
                    button9.BackColor = Color.Red;
                    button9.Text = "x";
                    button9.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;
                }
                else if (button8.BackColor == Color.Blue && button4.BackColor == Color.Blue && harekate_aval == 8)
                {
                    harekate_dovom = 4;
                    button7.BackColor = Color.Red;
                    button7.Text = "x";
                    button7.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;
                }
                else if (button8.BackColor == Color.Blue && button6.BackColor == Color.Blue && harekate_aval == 8)
                {
                    harekate_dovom = 6;
                    button9.BackColor = Color.Red;
                    button9.Text = "x";
                    button9.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;
                }
                else if (button8.BackColor == Color.Blue && button7.BackColor == Color.Blue && harekate_aval == 8)
                {
                    harekate_dovom = 7;
                    button9.BackColor = Color.Red;
                    button9.Text = "x";
                    button9.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;
                }
                else if (button8.BackColor == Color.Blue && button9.BackColor == Color.Blue && harekate_aval == 8)
                {
                    harekate_dovom = 9;
                    button7.BackColor = Color.Red;
                    button7.Text = "x";
                    button7.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;
                }

                else if (button9.BackColor == Color.Blue && button1.BackColor == Color.Blue && harekate_aval == 9)
                {
                    harekate_dovom = 1;
                    button4.BackColor = Color.Red;
                    button4.Text = "x";
                    button4.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;
                }
                else if (button9.BackColor == Color.Blue && button2.BackColor == Color.Blue && harekate_aval == 9)
                {
                    harekate_dovom = 2;
                    button3.BackColor = Color.Red;
                    button3.Text = "x";
                    button3.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;
                }
                else if (button9.BackColor == Color.Blue && button3.BackColor == Color.Blue && harekate_aval == 9)
                {
                    harekate_dovom = 3;
                    button6.BackColor = Color.Red;
                    button6.Text = "x";
                    button6.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;
                }
                else if (button9.BackColor == Color.Blue && button4.BackColor == Color.Blue && harekate_aval == 9)
                {
                    harekate_dovom = 4;
                    button7.BackColor = Color.Red;
                    button7.Text = "x";
                    button7.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;
                }
                else if (button9.BackColor == Color.Blue && button6.BackColor == Color.Blue && harekate_aval == 9)
                {
                    harekate_dovom = 6;
                    button3.BackColor = Color.Red;
                    button3.Text = "x";
                    button3.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;
                }
                else if (button9.BackColor == Color.Blue && button7.BackColor == Color.Blue && harekate_aval == 9)
                {
                    harekate_dovom = 7;
                    button8.BackColor = Color.Red;
                    button8.Text = "x";
                    button8.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;
                }
                else if (button9.BackColor == Color.Blue && button8.BackColor == Color.Blue && harekate_aval == 9)
                {
                    harekate_dovom = 8;
                    button7.BackColor = Color.Red;
                    button7.Text = "x";
                    button7.Enabled = false;
                    label1.Text = "player's Blue turn";
                    rang--;
                }//complited

                else if (pc == 1 && button1.BackColor == Color.Blue)
                {
                    //harekate_aval = 1;
                    //button7.BackColor = Color.Red;
                    //button7.Text = "x";
                    //button7.Enabled = false;
                    //label1.Text = "player's Blue turn";
                    //rang--;
                }
                else if (pc == 1 && button2.BackColor == Color.Blue)
                {
                    harekate_aval = 2;
                    //button7.BackColor = Color.Red;
                    //button7.Text = "x";
                    //button7.Enabled = false;
                    //label1.Text = "player's Blue turn";
                    //rang--;
                }
                else if (pc == 1 && button3.BackColor == Color.Blue)
                {
                    harekate_aval = 3;
                    //button7.BackColor = Color.Red;
                    //button7.Text = "x";
                    //button7.Enabled = false;
                    //label1.Text = "player's Blue turn";
                    //rang--;
                }
                else if (pc == 1 && button4.BackColor == Color.Blue)
                {
                    harekate_aval = 4;
                    //button7.BackColor = Color.Red;
                    //button7.Text = "x";
                    //button7.Enabled = false;
                    //label1.Text = "player's Blue turn";
                    //rang--;
                }
                else if (pc == 1 && button5.BackColor == Color.Blue)
                {
                    harekate_aval = 5;
                    //button7.BackColor = Color.Red;
                    //button7.Text = "x";
                    //button7.Enabled = false;
                    //label1.Text = "player's Blue turn";
                    //rang--;
                }
                else if (pc == 1 && button6.BackColor == Color.Blue)
                {
                    harekate_aval = 6;
                    //button7.BackColor = Color.Red;
                    //button7.Text = "x";
                    //button7.Enabled = false;
                    //label1.Text = "player's Blue turn";
                    //rang--;
                }
                else if (pc == 1 && button7.BackColor == Color.Blue)
                {
                    harekate_aval = 7;
                    //button7.BackColor = Color.Red;
                    //button7.Text = "x";
                    //button7.Enabled = false;
                    //label1.Text = "player's Blue turn";
                    //rang--;
                }
                else if (pc == 1 && button8.BackColor == Color.Blue)
                {
                    harekate_aval = 8;
                    //button7.BackColor = Color.Red;
                    //button7.Text = "x";
                    //button7.Enabled = false;
                    //label1.Text = "player's Blue turn";
                    //rang--;
                }
            }
            else if (rang == 5 || rang == 3)
            {
                if (/*button1.BackColor == Color.Blue && */harekate_aval == 1)
                {
                    if (button2.BackColor == Color.Blue && harekate_dovom == 2)
                    {
                        if (harekate_sevom == 7)
                        {
                            if (button6.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 6;
                                button9.BackColor = Color.Red;
                                button9.Text = "x";
                                button9.Enabled = false;
                            }
                            else
                            {
                                button6.BackColor = Color.Red;
                                button6.Text = "x";
                                button6.Enabled = false;
                            }
                        }
                        else if (button7.BackColor == Color.Blue)
                        {
                            harekate_sevom = 7;
                            button4.BackColor = Color.Red;
                            button4.Text = "x";
                            button4.Enabled = false;
                        }
                        else
                        {
                            button7.BackColor = Color.Red;
                            button7.Text = "x";
                            button7.Enabled = false;
                        }
                    }
                    else if (button3.BackColor == Color.Blue && harekate_dovom == 3)
                    {
                        if (harekate_sevom == 8)
                        {
                            if (button6.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 6;
                                button9.BackColor = Color.Red;
                                button9.Text = "x";
                                button9.Enabled = false;
                            }
                            else
                            {
                                button6.BackColor = Color.Red;
                                button6.Text = "x";
                                button6.Enabled = false;
                            }
                        }
                        else if (button8.BackColor == Color.Blue)
                        {
                            harekate_sevom = 8;
                            button4.BackColor = Color.Red;
                            button4.Text = "x";
                            button4.Enabled = false;
                        }
                        else
                        {
                            button8.BackColor = Color.Red;
                            button8.Text = "x";
                            button8.Enabled = false;
                        }
                    }
                    else if (button4.BackColor == Color.Blue && harekate_dovom == 4)
                    {
                        if (harekate_sevom == 3)
                        {
                            if (button8.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 8;
                                button6.BackColor = Color.Red;
                                button6.Text = "x";
                                button6.Enabled = false;
                            }
                            else
                            {
                                button8.BackColor = Color.Red;
                                button8.Text = "x";
                                button8.Enabled = false;
                            }
                        }
                        else if (button3.BackColor == Color.Blue)
                        {
                            harekate_sevom = 3;
                            button2.BackColor = Color.Red;
                            button2.Text = "x";
                            button2.Enabled = false;
                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            button3.Text = "x";
                            button3.Enabled = false;
                        }
                    }
                    else if (button6.BackColor == Color.Blue && harekate_dovom == 6)
                    {
                        if (harekate_sevom == 8)
                        {
                            if (button3.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 7;
                                button9.BackColor = Color.Red;
                                button9.Text = "x";
                                button9.Enabled = false;
                            }
                            else
                            {
                                button3.BackColor = Color.Red;
                                button3.Text = "x";
                                button3.Enabled = false;
                            }
                        }
                        else if (button8.BackColor == Color.Blue)
                        {
                            harekate_sevom = 8;
                            button7.BackColor = Color.Red;
                            button7.Text = "x";
                            button7.Enabled = false;
                        }
                        else
                        {
                            button8.BackColor = Color.Red;
                            button8.Text = "x";
                            button8.Enabled = false;
                        }
                    }
                    else if (button7.BackColor == Color.Blue && harekate_dovom == 7)
                    {
                        if (harekate_sevom == 6)
                        {
                            if (button8.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 8;
                                button9.BackColor = Color.Red;
                                button9.Text = "x";
                                button9.Enabled = false;
                            }
                            else
                            {
                                button8.BackColor = Color.Red;
                                button8.Text = "x";
                                button8.Enabled = false;
                            }
                        }
                        else if (button6.BackColor == Color.Blue)
                        {
                            harekate_sevom = 6;
                            button2.BackColor = Color.Red;
                            button2.Text = "x";
                            button2.Enabled = false;
                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                            button6.Text = "x";
                            button6.Enabled = false;
                        }
                    }
                    else if (button8.BackColor == Color.Blue && harekate_dovom == 8)
                    {
                        if (harekate_sevom == 6)
                        {
                            if (button7.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 7;
                                button9.BackColor = Color.Red;
                                button9.Text = "x";
                                button9.Enabled = false;
                            }
                            else
                            {
                                button7.BackColor = Color.Red;
                                button7.Text = "x";
                                button7.Enabled = false;
                            }
                        }
                        else if (button6.BackColor == Color.Blue)
                        {
                            harekate_sevom = 6;
                            button3.BackColor = Color.Red;
                            button3.Text = "x";
                            button3.Enabled = false;
                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                            button6.Text = "x";
                            button6.Enabled = false;
                        }
                    }
                    else if (button9.BackColor == Color.Blue && harekate_dovom == 9)
                    {
                        if (harekate_sevom == 6)
                        {
                            if (button7.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 7;
                                button8.BackColor = Color.Red;
                                button8.Text = "x";
                                button8.Enabled = false;
                            }
                            else
                            {
                                button7.BackColor = Color.Red;
                                button7.Text = "x";
                                button7.Enabled = false;
                            }
                        }
                        else if (button6.BackColor == Color.Blue)
                        {
                            harekate_sevom = 6;
                            button3.BackColor = Color.Red;
                            button3.Text = "x";
                            button3.Enabled = false;
                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                            button6.Text = "x";
                            button6.Enabled = false;
                        }
                    }
                }//complited

                else if (/*button2.BackColor == Color.Blue && */harekate_aval == 2)
                {
                    if (/*button3.BackColor == Color.Blue && */harekate_dovom == 1)
                    {
                        if (harekate_sevom == 7)
                        {
                            if (button6.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 6;
                                button8.BackColor = Color.Red;
                                button8.Text = "x";
                                button8.Enabled = false;
                            }
                            else
                            {
                                button6.BackColor = Color.Red;
                                button6.Text = "x";
                                button6.Enabled = false;
                            }
                        }
                        else if (button7.BackColor == Color.Blue)
                        {
                            harekate_sevom = 7;
                            button4.BackColor = Color.Red;
                            button4.Text = "x";
                            button4.Enabled = false;
                        }
                        else
                        {
                            button7.BackColor = Color.Red;
                            button7.Text = "x";
                            button7.Enabled = false;
                        }
                    }
                    else if (/*button4.BackColor == Color.Blue && */harekate_dovom == 3)
                    {
                        if (harekate_sevom == 9)
                        {
                            if (button4.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 4;
                                button8.BackColor = Color.Red;
                                button8.Text = "x";
                                button8.Enabled = false;
                            }
                            else
                            {
                                button4.BackColor = Color.Red;
                                button4.Text = "x";
                                button4.Enabled = false;
                            }
                        }
                        else if (button9.BackColor == Color.Blue)
                        {
                            harekate_sevom = 9;
                            button6.BackColor = Color.Red;
                            button6.Text = "x";
                            button6.Enabled = false;
                        }
                        else
                        {
                            button9.BackColor = Color.Red;
                            button9.Text = "x";
                            button9.Enabled = false;
                        }
                    }
                    else if (/*button5.BackColor == Color.Blue && */harekate_dovom == 4)
                    {
                        if (harekate_sevom == 3)
                        {
                            if (button9.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 9;
                                button6.BackColor = Color.Red;
                                button6.Text = "x";
                                button6.Enabled = false;
                            }
                            else
                            {
                                button9.BackColor = Color.Red;
                                button9.Text = "x";
                                button9.Enabled = false;
                            }
                        }
                        else if (button3.BackColor == Color.Blue)
                        {
                            harekate_sevom = 3;
                            button1.BackColor = Color.Red;
                            button1.Text = "x";
                            button1.Enabled = false;
                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            button3.Text = "x";
                            button3.Enabled = false;
                        }
                    }
                    else if (/*button6.BackColor == Color.Blue && */harekate_dovom == 6)
                    {
                        if (harekate_sevom == 1)
                        {
                            if (button7.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 7;
                                button4.BackColor = Color.Red;
                                button4.Text = "x";
                                button4.Enabled = false;
                            }
                            else
                            {
                                button7.BackColor = Color.Red;
                                button7.Text = "x";
                                button7.Enabled = false;
                            }
                        }
                        else if (button1.BackColor == Color.Blue)
                        {
                            harekate_sevom = 1;
                            button3.BackColor = Color.Red;
                            button3.Text = "x";
                            button3.Enabled = false;
                        }
                        else
                        {
                            button1.BackColor = Color.Red;
                            button1.Text = "x";
                            button1.Enabled = false;
                        }
                    }
                    else if (/*button7.BackColor == Color.Blue && */harekate_dovom == 7)
                    {
                        if (harekate_sevom == 6)
                        {
                            if (button1.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 1;
                                button3.BackColor = Color.Red;
                                button3.Text = "x";
                                button3.Enabled = false;
                            }
                            else
                            {
                                button1.BackColor = Color.Red;
                                button1.Text = "x";
                                button1.Enabled = false;
                            }
                        }
                        else if (button6.BackColor == Color.Blue)
                        {
                            harekate_sevom = 6;
                            button9.BackColor = Color.Red;
                            button9.Text = "x";
                            button9.Enabled = false;
                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                            button6.Text = "x";
                            button6.Enabled = false;
                        }
                    }
                    else if (/*button8.BackColor == Color.Blue && */harekate_dovom == 8)
                    {
                        if (harekate_sevom == 3)
                        {
                            if (button9.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 9;
                                button4.BackColor = Color.Red;
                                button4.Text = "x";
                                button4.Enabled = false;
                            }
                            else
                            {
                                button9.BackColor = Color.Red;
                                button9.Text = "x";
                                button9.Enabled = false;
                            }
                        }
                        else if (button3.BackColor == Color.Blue)
                        {
                            harekate_sevom = 3;
                            button1.BackColor = Color.Red;
                            button1.Text = "x";
                            button1.Enabled = false;
                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            button3.Text = "x";
                            button3.Enabled = false;
                        }
                    }
                    else if (/*button9.BackColor == Color.Blue && */harekate_dovom == 9)
                    {
                        if (harekate_sevom == 4)
                        {
                            if (button3.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 3;
                                button1.BackColor = Color.Red;
                                button1.Text = "x";
                                button1.Enabled = false;
                            }
                            else
                            {
                                button3.BackColor = Color.Red;
                                button3.Text = "x";
                                button3.Enabled = false;
                            }
                        }
                        else if (button4.BackColor == Color.Blue)
                        {
                            harekate_sevom = 4;
                            button7.BackColor = Color.Red;
                            button7.Text = "x";
                            button7.Enabled = false;
                        }
                        else
                        {
                            button4.BackColor = Color.Red;
                            button4.Text = "x";
                            button4.Enabled = false;
                        }
                    }
                }//compilted

                else if (/*button3.BackColor == Color.Blue && */harekate_aval == 3)
                {
                    if (harekate_dovom == 1)
                    {
                        if (harekate_sevom == 8)
                        {
                            if (button6.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 6;
                                button9.BackColor = Color.Red;
                                button9.Text = "x";
                                button9.Enabled = false;
                            }
                            else
                            {
                                button6.BackColor = Color.Red;
                                button6.Text = "x";
                                button6.Enabled = false;
                            }
                        }
                        else if (button8.BackColor == Color.Blue)
                        {
                            harekate_sevom = 8;
                            button4.BackColor = Color.Red;
                            button4.Text = "x";
                            button4.Enabled = false;
                        }
                        else
                        {
                            button8.BackColor = Color.Red;
                            button8.Text = "x";
                            button8.Enabled = false;
                        }
                    }
                    else if (harekate_dovom == 2)
                    {
                        if (harekate_sevom == 9)
                        {
                            if (button4.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 4;
                                button8.BackColor = Color.Red;
                                button8.Text = "x";
                                button8.Enabled = false;
                            }
                            else
                            {
                                button4.BackColor = Color.Red;
                                button4.Text = "x";
                                button4.Enabled = false;
                            }
                        }
                        else if (button9.BackColor == Color.Blue)
                        {
                            harekate_sevom = 9;
                            button6.BackColor = Color.Red;
                            button6.Text = "x";
                            button6.Enabled = false;
                        }
                        else
                        {
                            button9.BackColor = Color.Red;
                            button9.Text = "x";
                            button9.Enabled = false;
                        }
                    }
                    else if (harekate_dovom == 4)
                    {
                        if (harekate_sevom == 8)
                        {
                            if (button1.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 1;
                                button7.BackColor = Color.Red;
                                button7.Text = "x";
                                button7.Enabled = false;
                            }
                            else
                            {
                                button1.BackColor = Color.Red;
                                button1.Text = "x";
                                button1.Enabled = false;
                            }
                        }
                        else if (button8.BackColor == Color.Blue)
                        {
                            harekate_sevom = 8;
                            button9.BackColor = Color.Red;
                            button9.Text = "x";
                            button9.Enabled = false;
                        }
                        else
                        {
                            button8.BackColor = Color.Red;
                            button8.Text = "x";
                            button8.Enabled = false;
                        }
                    }
                    else if (harekate_dovom == 6)
                    {
                        if (harekate_sevom == 1)
                        {
                            if (button8.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 8;
                                button4.BackColor = Color.Red;
                                button4.Text = "x";
                                button4.Enabled = false;
                            }
                            else
                            {
                                button8.BackColor = Color.Red;
                                button8.Text = "x";
                                button8.Enabled = false;
                            }
                        }
                        else if (button1.BackColor == Color.Blue)
                        {
                            harekate_sevom = 1;
                            button2.BackColor = Color.Red;
                            button2.Text = "x";
                            button2.Enabled = false;
                        }
                        else
                        {
                            button1.BackColor = Color.Red;
                            button1.Text = "x";
                            button1.Enabled = false;
                        }
                    }
                    else if (harekate_dovom == 7)
                    {
                        if (harekate_sevom == 4)
                        {
                            if (button9.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 9;
                                button8.BackColor = Color.Red;
                                button8.Text = "x";
                                button8.Enabled = false;
                            }
                            else
                            {
                                button9.BackColor = Color.Red;
                                button9.Text = "x";
                                button9.Enabled = false;
                            }
                        }
                        else if (button4.BackColor == Color.Blue)
                        {
                            harekate_sevom = 4;
                            button1.BackColor = Color.Red;
                            button1.Text = "x";
                            button1.Enabled = false;
                        }
                        else
                        {
                            button4.BackColor = Color.Red;
                            button4.Text = "x";
                            button4.Enabled = false;
                        }
                    }
                    else if (harekate_dovom == 8)
                    {
                        if (harekate_sevom == 4)
                        {
                            if (button9.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 9;
                                button7.BackColor = Color.Red;
                                button7.Text = "x";
                                button7.Enabled = false;
                            }
                            else
                            {
                                button9.BackColor = Color.Red;
                                button9.Text = "x";
                                button9.Enabled = false;
                            }
                        }
                        else if (button4.BackColor == Color.Blue)
                        {
                            harekate_sevom = 4;
                            button1.BackColor = Color.Red;
                            button1.Text = "x";
                            button1.Enabled = false;
                        }
                        else
                        {
                            button4.BackColor = Color.Red;
                            button4.Text = "x";
                            button4.Enabled = false;
                        }
                    }
                    else if (harekate_dovom == 9)
                    {
                        if (harekate_sevom == 4)
                        {
                            if (button8.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 8;
                                button7.BackColor = Color.Red;
                                button7.Text = "x";
                                button7.Enabled = false;
                            }
                            else
                            {
                                button8.BackColor = Color.Red;
                                button8.Text = "x";
                                button8.Enabled = false;
                            }
                        }
                        else if (button4.BackColor == Color.Blue)
                        {
                            harekate_sevom = 4;
                            button2.BackColor = Color.Red;
                            button2.Text = "x";
                            button2.Enabled = false;
                        }
                        else
                        {
                            button4.BackColor = Color.Red;
                            button4.Text = "x";
                            button4.Enabled = false;
                        }
                    }
                }//complited

                else if (/*button4.BackColor == Color.Blue && */harekate_aval == 4)
                {
                    if (harekate_dovom == 1)
                    {
                        if (harekate_sevom == 3)
                        {
                            if (button8.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 8;
                                button9.BackColor = Color.Red;
                                button9.Text = "x";
                                button9.Enabled = false;
                            }
                            else
                            {
                                button8.BackColor = Color.Red;
                                button8.Text = "x";
                                button8.Enabled = false;
                            }
                        }
                        else if (button3.BackColor == Color.Blue)
                        {
                            harekate_sevom = 3;
                            button2.BackColor = Color.Red;
                            button2.Text = "x";
                            button2.Enabled = false;
                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            button3.Text = "x";
                            button3.Enabled = false;
                        }
                    }
                    else if (harekate_dovom == 2)
                    {
                        if (harekate_sevom == 3)
                        {
                            if (button9.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 9;
                                button6.BackColor = Color.Red;
                                button6.Text = "x";
                                button6.Enabled = false;
                            }
                            else
                            {
                                button9.BackColor = Color.Red;
                                button9.Text = "x";
                                button9.Enabled = false;
                            }
                        }
                        else if (button3.BackColor == Color.Blue)
                        {
                            harekate_sevom = 3;
                            button1.BackColor = Color.Red;
                            button1.Text = "x";
                            button1.Enabled = false;
                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            button3.Text = "x";
                            button3.Enabled = false;
                        }
                    }
                    else if (harekate_dovom == 3)
                    {
                        if (harekate_sevom == 8)
                        {
                            if (button1.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 1;
                                button7.BackColor = Color.Red;
                                button7.Text = "x";
                                button7.Enabled = false;
                            }
                            else
                            {
                                button1.BackColor = Color.Red;
                                button1.Text = "x";
                                button1.Enabled = false;
                            }
                        }
                        else if (button8.BackColor == Color.Blue)
                        {
                            harekate_sevom = 8;
                            button9.BackColor = Color.Red;
                            button9.Text = "x";
                            button9.Enabled = false;
                        }
                        else
                        {
                            button8.BackColor = Color.Red;
                            button8.Text = "x";
                            button8.Enabled = false;
                        }
                    }
                    else if (harekate_dovom == 6)
                    {
                        if (harekate_sevom == 3)
                        {
                            if (button1.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 1;
                                button8.BackColor = Color.Red;
                                button8.Text = "x";
                                button8.Enabled = false;
                            }
                            else
                            {
                                button1.BackColor = Color.Red;
                                button1.Text = "x";
                                button1.Enabled = false;
                            }
                        }
                        else if (button3.BackColor == Color.Blue)
                        {
                            harekate_sevom = 3;
                            button9.BackColor = Color.Red;
                            button9.Text = "x";
                            button9.Enabled = false;
                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            button3.Text = "x";
                            button3.Enabled = false;
                        }
                    }
                    else if (harekate_dovom == 7)
                    {
                        if (harekate_sevom == 9)
                        {
                            if (button2.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 2;
                                button3.BackColor = Color.Red;
                                button3.Text = "x";
                                button3.Enabled = false;
                            }
                            else
                            {
                                button2.BackColor = Color.Red;
                                button2.Text = "x";
                                button2.Enabled = false;
                            }
                        }
                        else if (button9.BackColor == Color.Blue)
                        {
                            harekate_sevom = 9;
                            button8.BackColor = Color.Red;
                            button8.Text = "x";
                            button8.Enabled = false;
                        }
                        else
                        {
                            button9.BackColor = Color.Red;
                            button9.Text = "x";
                            button9.Enabled = false;
                        }
                    }
                    else if (harekate_dovom == 8)
                    {
                        if (harekate_sevom == 9)
                        {
                            if (button3.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 3;
                                button6.BackColor = Color.Red;
                                button6.Text = "x";
                                button6.Enabled = false;
                            }
                            else
                            {
                                button3.BackColor = Color.Red;
                                button3.Text = "x";
                                button3.Enabled = false;
                            }
                        }
                        else if (button9.BackColor == Color.Blue)
                        {
                            harekate_sevom = 9;
                            button7.BackColor = Color.Red;
                            button7.Text = "x";
                            button7.Enabled = false;
                        }
                        else
                        {
                            button9.BackColor = Color.Red;
                            button9.Text = "x";
                            button9.Enabled = false;
                        }
                    }
                    else if (harekate_dovom == 9)
                    {
                        if (harekate_sevom == 2)
                        {
                            if (button7.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 7;
                                button1.BackColor = Color.Red;
                                button1.Text = "x";
                                button1.Enabled = false;
                            }
                            else
                            {
                                button7.BackColor = Color.Red;
                                button7.Text = "x";
                                button7.Enabled = false;
                            }
                        }
                        else if (button2.BackColor == Color.Blue)
                        {
                            harekate_sevom = 2;
                            button3.BackColor = Color.Red;
                            button3.Text = "x";
                            button3.Enabled = false;
                        }
                        else
                        {
                            button2.BackColor = Color.Red;
                            button2.Text = "x";
                            button2.Enabled = false;
                        }
                    }
                }//complited

                else if (/*button5.BackColor == Color.Blue && */harekate_aval == 5)
                {
                    if (button1.BackColor == Color.Blue && harekate_dovom == 1)
                    {
                        if (harekate_sevom == 6)
                        {
                            if (button8.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 8;
                                button2.BackColor = Color.Red;
                                button2.Text = "x";
                                button2.Enabled = false;
                            }
                            else
                            {
                                button8.BackColor = Color.Red;
                                button8.Text = "x";
                                button8.Enabled = false;
                            }
                        }
                        else if (button6.BackColor == Color.Blue)
                        {
                            harekate_sevom = 6;
                            button4.BackColor = Color.Red;
                            button4.Text = "x";
                            button4.Enabled = false;
                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                            button6.Text = "x";
                            button6.Enabled = false;
                        }
                    }
                    else if (button2.BackColor == Color.Blue && harekate_dovom == 2)
                    {
                        if (harekate_sevom == 1)
                        {
                            if (button7.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 7;
                                button4.BackColor = Color.Red;
                                button4.Text = "x";
                                button4.Enabled = false;
                            }
                            else
                            {
                                button7.BackColor = Color.Red;
                                button7.Text = "x";
                                button7.Enabled = false;
                            }
                        }
                        else if (button1.BackColor == Color.Blue)
                        {
                            harekate_sevom = 1;
                            button9.BackColor = Color.Red;
                            button9.Text = "x";
                            button9.Enabled = false;
                        }
                        else if (harekate_sevom == 4)
                        {
                            if (button9.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 9;
                                button1.BackColor = Color.Red;
                                button1.Text = "x";
                                button1.Enabled = false;
                            }
                            else
                            {
                                button9.BackColor = Color.Red;
                                button9.Text = "x";
                                button9.Enabled = false;
                            }
                        }
                        else if (button4.BackColor == Color.Blue)
                        {
                            harekate_sevom = 4;
                            button6.BackColor = Color.Red;
                            button6.Text = "x";
                            button6.Enabled = false;
                        }
                        else if (harekate_sevom == 6)
                        {
                            if (button1.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 1;
                                button9.BackColor = Color.Red;
                                button9.Text = "x";
                                button9.Enabled = false;
                            }
                            else
                            {
                                button1.BackColor = Color.Red;
                                button1.Text = "x";
                                button1.Enabled = false;
                            }
                        }
                        else if (button6.BackColor == Color.Blue)
                        {
                            harekate_sevom = 6;
                            button4.BackColor = Color.Red;
                            button4.Text = "x";
                            button4.Enabled = false;
                        }
                        else if (harekate_sevom == 7)
                        {
                            if (button6.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 6;
                                button4.BackColor = Color.Red;
                                button4.Text = "x";
                                button4.Enabled = false;
                            }
                            else
                            {
                                button6.BackColor = Color.Red;
                                button6.Text = "x";
                                button6.Enabled = false;
                            }
                        }
                        else if (button7.BackColor == Color.Blue)
                        {
                            harekate_sevom = 7;
                            button9.BackColor = Color.Red;
                            button9.Text = "x";
                            button9.Enabled = false;
                        }
                        else if (harekate_sevom == 9)
                        {
                            if (button4.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 4;
                                button6.BackColor = Color.Red;
                                button6.Text = "x";
                                button6.Enabled = false;
                            }
                            else
                            {
                                button4.BackColor = Color.Red;
                                button4.Text = "x";
                                button4.Enabled = false;
                            }
                        }
                        else if (button9.BackColor == Color.Blue)
                        {
                            harekate_sevom = 9;
                            button1.BackColor = Color.Red;
                            button1.Text = "x";
                            button1.Enabled = false;
                        }
                    }
                    else if (button4.BackColor == Color.Blue && harekate_dovom == 4)
                    {
                        if (harekate_sevom == 9)
                        {
                            if (button2.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 2;
                                button8.BackColor = Color.Red;
                                button8.Text = "x";
                                button8.Enabled = false;
                            }
                            else
                            {
                                button2.BackColor = Color.Red;
                                button2.Text = "x";
                                button2.Enabled = false;
                            }
                        }
                        else if (button9.BackColor == Color.Blue)
                        {
                            harekate_sevom = 9;
                            button1.BackColor = Color.Red;
                            button1.Text = "x";
                            button1.Enabled = false;
                        }
                        else
                        {
                            button9.BackColor = Color.Red;
                            button9.Text = "x";
                            button9.Enabled = false;
                        }
                    }
                    else if (button6.BackColor == Color.Blue && harekate_dovom == 6)
                    {
                        if (harekate_sevom == 1)
                        {
                            if (button2.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 2;
                                button8.BackColor = Color.Red;
                                button8.Text = "x";
                                button8.Enabled = false;
                            }
                            else
                            {
                                button2.BackColor = Color.Red;
                                button2.Text = "x";
                                button2.Enabled = false;
                            }
                        }
                        else if (button1.BackColor == Color.Blue)
                        {
                            harekate_sevom = 1;
                            button9.BackColor = Color.Red;
                            button9.Text = "x";
                            button9.Enabled = false;
                        }
                        else if (harekate_sevom == 2)
                        {
                            if (button1.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 1;
                                button9.BackColor = Color.Red;
                                button9.Text = "x";
                                button9.Enabled = false;
                            }
                            else
                            {
                                button1.BackColor = Color.Red;
                                button1.Text = "x";
                                button1.Enabled = false;
                            }
                        }
                        else if (button2.BackColor == Color.Blue)
                        {
                            harekate_sevom = 2;
                            button8.BackColor = Color.Red;
                            button8.Text = "x";
                            button8.Enabled = false;
                        }
                        else if (harekate_sevom == 7)
                        {
                            if (button2.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 2;
                                button8.BackColor = Color.Red;
                                button8.Text = "x";
                                button8.Enabled = false;
                            }
                            else
                            {
                                button2.BackColor = Color.Red;
                                button2.Text = "x";
                                button2.Enabled = false;
                            }
                        }
                        else if (button7.BackColor == Color.Blue)
                        {
                            harekate_sevom = 7;
                            button1.BackColor = Color.Red;
                            button1.Text = "x";
                            button1.Enabled = false;
                        }
                        else if (harekate_sevom == 8)
                        {
                            if (button1.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 1;
                                button9.BackColor = Color.Red;
                                button9.Text = "x";
                                button9.Enabled = false;
                            }
                            else
                            {
                                button1.BackColor = Color.Red;
                                button1.Text = "x";
                                button1.Enabled = false;
                            }
                        }
                        else if (button8.BackColor == Color.Blue)
                        {
                            harekate_sevom = 8;
                            button2.BackColor = Color.Red;
                            button2.Text = "x";
                            button2.Enabled = false;
                        }
                        else if (harekate_sevom == 9)
                        {
                            if (button2.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 2;
                                button8.BackColor = Color.Red;
                                button8.Text = "x";
                                button8.Enabled = false;
                            }
                            else
                            {
                                button2.BackColor = Color.Red;
                                button2.Text = "x";
                                button2.Enabled = false;
                            }
                        }
                        else if (button9.BackColor == Color.Blue)
                        {
                            harekate_sevom = 9;
                            button1.BackColor = Color.Red;
                            button1.Text = "x";
                            button1.Enabled = false;
                        }
                    }
                    else if (button7.BackColor == Color.Blue && harekate_dovom == 7)
                    {
                        if (harekate_sevom == 6)
                        {
                            if (button2.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 2;
                                button8.BackColor = Color.Red;
                                button8.Text = "x";
                                button8.Enabled = false;
                            }
                            else
                            {
                                button2.BackColor = Color.Red;
                                button2.Text = "x";
                                button2.Enabled = false;
                            }
                        }
                        else if (button6.BackColor == Color.Blue)
                        {
                            harekate_sevom = 6;
                            button4.BackColor = Color.Red;
                            button4.Text = "x";
                            button4.Enabled = false;
                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                            button6.Text = "x";
                            button6.Enabled = false;
                        }
                    }
                    else if (button8.BackColor == Color.Blue && harekate_dovom == 8)
                    {
                        if (harekate_sevom == 1)
                        {
                            if (button6.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 6;
                                button4.BackColor = Color.Red;
                                button4.Text = "x";
                                button4.Enabled = false;
                            }
                            else
                            {
                                button6.BackColor = Color.Red;
                                button6.Text = "x";
                                button6.Enabled = false;
                            }
                        }
                        else if (button1.BackColor == Color.Blue)
                        {
                            harekate_sevom = 1;
                            button9.BackColor = Color.Red;
                            button9.Text = "x";
                            button9.Enabled = false;
                        }
                        else
                        {
                            button1.BackColor = Color.Red;
                            button1.Text = "x";
                            button1.Enabled = false;
                        }
                    }
                    else if (button9.BackColor == Color.Blue && harekate_dovom == 9)
                    {
                        if (harekate_sevom == 2)
                        {
                            if (button6.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 6;
                                button4.BackColor = Color.Red;
                                button4.Text = "x";
                                button4.Enabled = false;
                            }
                            else
                            {
                                button6.BackColor = Color.Red;
                                button6.Text = "x";
                                button6.Enabled = false;
                            }
                        }
                        else if (button2.BackColor == Color.Blue)
                        {
                            harekate_sevom = 2;
                            button8.BackColor = Color.Red;
                            button8.Text = "x";
                            button8.Enabled = false;
                        }
                        else
                        {
                            button2.BackColor = Color.Red;
                            button2.Text = "x";
                            button2.Enabled = false;
                        }
                    }
                }//complited

                else if (/*button6.BackColor == Color.Blue && */harekate_aval == 6)
                {
                    if (harekate_dovom == 1)
                    {
                        if (harekate_sevom == 8)
                        {
                            if (button3.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 3;
                                button9.BackColor = Color.Red;
                                button9.Text = "x";
                                button9.Enabled = false;
                            }
                            else
                            {
                                button3.BackColor = Color.Red;
                                button3.Text = "x";
                                button3.Enabled = false;
                            }
                        }
                        else if (button8.BackColor == Color.Blue)
                        {
                            harekate_sevom = 8;
                            button7.BackColor = Color.Red;
                            button7.Text = "x";
                            button7.Enabled = false;
                        }
                        else
                        {
                            button8.BackColor = Color.Red;
                            button8.Text = "x";
                            button8.Enabled = false;
                        }
                    }
                    else if (harekate_dovom == 2)
                    {
                        if (harekate_sevom == 7)
                        {
                            if (button9.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 9;
                                button8.BackColor = Color.Red;
                                button8.Text = "x";
                                button8.Enabled = false;
                            }
                            else
                            {
                                button9.BackColor = Color.Red;
                                button9.Text = "x";
                                button9.Enabled = false;
                            }
                        }
                        else if (button7.BackColor == Color.Blue)
                        {
                            harekate_sevom = 7;
                            button1.BackColor = Color.Red;
                            button1.Text = "x";
                            button1.Enabled = false;
                        }
                        else
                        {
                            button7.BackColor = Color.Red;
                            button7.Text = "x";
                            button7.Enabled = false;
                        }
                    }
                    else if (harekate_dovom == 3)
                    {
                        if (harekate_sevom == 1)
                        {
                            if (button8.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 8;
                                button7.BackColor = Color.Red;
                                button7.Text = "x";
                                button7.Enabled = false;
                            }
                            else
                            {
                                button8.BackColor = Color.Red;
                                button8.Text = "x";
                                button8.Enabled = false;
                            }
                        }
                        else if (button1.BackColor == Color.Blue)
                        {
                            harekate_sevom = 1;
                            button2.BackColor = Color.Red;
                            button2.Text = "x";
                            button2.Enabled = false;
                        }
                        else
                        {
                            button1.BackColor = Color.Red;
                            button1.Text = "x";
                            button1.Enabled = false;
                        }
                    }
                    else if (harekate_dovom == 4)
                    {
                        if (harekate_sevom == 3)
                        {
                            if (button1.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 1;
                                button8.BackColor = Color.Red;
                                button8.Text = "x";
                                button8.Enabled = false;
                            }
                            else
                            {
                                button1.BackColor = Color.Red;
                                button1.Text = "x";
                                button1.Enabled = false;
                            }
                        }
                        else if (button3.BackColor == Color.Blue)
                        {
                            harekate_sevom = 3;
                            button9.BackColor = Color.Red;
                            button9.Text = "x";
                            button9.Enabled = false;
                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            button3.Text = "x";
                            button3.Enabled = false;
                        }
                    }
                    else if (harekate_dovom == 7)
                    {
                        if (harekate_sevom == 1)
                        {
                            if (button2.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 2;
                                button3.BackColor = Color.Red;
                                button3.Text = "x";
                                button3.Enabled = false;
                            }
                            else
                            {
                                button2.BackColor = Color.Red;
                                button2.Text = "x";
                                button2.Enabled = false;
                            }
                        }
                        else if (button1.BackColor == Color.Blue)
                        {
                            harekate_sevom = 1;
                            button4.BackColor = Color.Red;
                            button4.Text = "x";
                            button4.Enabled = false;
                        }
                        else
                        {
                            button1.BackColor = Color.Red;
                            button1.Text = "x";
                            button1.Enabled = false;
                        }
                    }
                    else if (harekate_dovom == 8)
                    {
                        if (harekate_sevom == 1)
                        {
                            if (button7.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 7;
                                button4.BackColor = Color.Red;
                                button4.Text = "x";
                                button4.Enabled = false;
                            }
                            else
                            {
                                button7.BackColor = Color.Red;
                                button7.Text = "x";
                                button7.Enabled = false;
                            }
                        }
                        else if (button1.BackColor == Color.Blue)
                        {
                            harekate_sevom = 1;
                            button3.BackColor = Color.Red;
                            button3.Text = "x";
                            button3.Enabled = false;
                        }
                        else
                        {
                            button1.BackColor = Color.Red;
                            button1.Text = "x";
                            button1.Enabled = false;
                        }
                    }
                    else if (harekate_dovom == 9)
                    {
                        if (harekate_sevom == 7)
                        {
                            if (button2.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 2;
                                button4.BackColor = Color.Red;
                                button4.Text = "x";
                                button4.Enabled = false;
                            }
                            else
                            {
                                button2.BackColor = Color.Red;
                                button2.Text = "x";
                                button2.Enabled = false;
                            }
                        }
                        else if (button7.BackColor == Color.Blue)
                        {
                            harekate_sevom = 7;
                            button8.BackColor = Color.Red;
                            button8.Text = "x";
                            button8.Enabled = false;
                        }
                        else
                        {
                            button7.BackColor = Color.Red;
                            button7.Text = "x";
                            button7.Enabled = false;
                        }
                    }
                }//complited

                else if (/*button7.BackColor == Color.Blue && */harekate_aval == 7)
                {
                    if (button1.BackColor == Color.Blue && harekate_dovom == 1)
                    {
                        if (harekate_sevom == 6)
                        {
                            if (button8.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 8;
                                button9.BackColor = Color.Red;
                                button9.Text = "x";
                                button9.Enabled = false;
                            }
                            else
                            {
                                button8.BackColor = Color.Red;
                                button8.Text = "x";
                                button8.Enabled = false;
                            }
                        }
                        else if (button6.BackColor == Color.Blue)
                        {
                            harekate_sevom = 6;
                            button2.BackColor = Color.Red;
                            button2.Text = "x";
                            button2.Enabled = false;
                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                            button6.Text = "x";
                            button6.Enabled = false;
                        }
                    }
                    else if (button2.BackColor == Color.Blue && harekate_dovom == 2)
                    {
                        if (harekate_sevom == 9)
                        {
                            if (button6.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 6;
                                button3.BackColor = Color.Red;
                                button3.Text = "x";
                                button3.Enabled = false;
                            }
                            else
                            {
                                button6.BackColor = Color.Red;
                                button6.Text = "x";
                                button6.Enabled = false;
                            }
                        }
                        else if (button9.BackColor == Color.Blue)
                        {
                            harekate_sevom = 9;
                            button8.BackColor = Color.Red;
                            button8.Text = "x";
                            button8.Enabled = false;
                        }
                        else
                        {
                            button9.BackColor = Color.Red;
                            button9.Text = "x";
                            button9.Enabled = false;
                        }
                    }
                    else if (button3.BackColor == Color.Blue && harekate_dovom == 3)
                    {
                        if (harekate_sevom == 6)
                        {
                            if (button1.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 1;
                                button2.BackColor = Color.Red;
                                button2.Text = "x";
                                button2.Enabled = false;
                            }
                            else
                            {
                                button1.BackColor = Color.Red;
                                button1.Text = "x";
                                button1.Enabled = false;
                            }
                        }
                        else if (button6.BackColor == Color.Blue)
                        {
                            harekate_sevom = 6;
                            button9.BackColor = Color.Red;
                            button9.Text = "x";
                            button9.Enabled = false;
                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                            button6.Text = "x";
                            button6.Enabled = false;
                        }
                    }
                    else if (button4.BackColor == Color.Blue && harekate_dovom == 4)
                    {
                        if (harekate_sevom == 9)
                        {
                            if (button2.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 2;
                                button3.BackColor = Color.Red;
                                button3.Text = "x";
                                button3.Enabled = false;
                            }
                            else
                            {
                                button2.BackColor = Color.Red;
                                button2.Text = "x";
                                button2.Enabled = false;
                            }
                        }
                        else if (button9.BackColor == Color.Blue)
                        {
                            harekate_sevom = 9;
                            button8.BackColor = Color.Red;
                            button8.Text = "x";
                            button8.Enabled = false;
                        }
                        else
                        {
                            button9.BackColor = Color.Red;
                            button9.Text = "x";
                            button9.Enabled = false;
                        }
                    }
                    else if (button6.BackColor == Color.Blue && harekate_dovom == 6)
                    {
                        if (harekate_sevom == 1)
                        {
                            if (button2.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 2;
                                button3.BackColor = Color.Red;
                                button3.Text = "x";
                                button3.Enabled = false;
                            }
                            else
                            {
                                button2.BackColor = Color.Red;
                                button2.Text = "x";
                                button2.Enabled = false;
                            }
                        }
                        else if (button1.BackColor == Color.Blue)
                        {
                            harekate_sevom = 1;
                            button4.BackColor = Color.Red;
                            button4.Text = "x";
                            button4.Enabled = false;
                        }
                        else
                        {
                            button1.BackColor = Color.Red;
                            button1.Text = "x";
                            button1.Enabled = false;
                        }
                    }
                    else if (button8.BackColor == Color.Blue && harekate_dovom == 8)
                    {
                        if (harekate_sevom == 1)
                        {
                            if (button6.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 6;
                                button2.BackColor = Color.Red;
                                button2.Text = "x";
                                button2.Enabled = false;
                            }
                            else
                            {
                                button6.BackColor = Color.Red;
                                button6.Text = "x";
                                button6.Enabled = false;
                            }
                        }
                        else if (button1.BackColor == Color.Blue)
                        {
                            harekate_sevom = 1;
                            button4.BackColor = Color.Red;
                            button4.Text = "x";
                            button4.Enabled = false;
                        }
                        else
                        {
                            button1.BackColor = Color.Red;
                            button1.Text = "x";
                            button1.Enabled = false;
                        }
                    }
                    else if (button9.BackColor == Color.Blue && harekate_dovom == 9)
                    {
                        if (harekate_sevom == 2)
                        {
                            if (button6.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 6;
                                button3.BackColor = Color.Red;
                                button3.Text = "x";
                                button3.Enabled = false;
                            }
                            else
                            {
                                button6.BackColor = Color.Red;
                                button6.Text = "x";
                                button6.Enabled = false;
                            }
                        }
                        else if (button2.BackColor == Color.Blue)
                        {
                            harekate_sevom = 2;
                            button4.BackColor = Color.Red;
                            button4.Text = "x";
                            button4.Enabled = false;
                        }
                        else
                        {
                            button2.BackColor = Color.Red;
                            button2.Text = "x";
                            button2.Enabled = false;
                        }
                    }
                }//complited

                else if (/*button8.BackColor == Color.Blue && */harekate_aval == 8)
                {
                    if (button1.BackColor == Color.Blue && harekate_dovom == 1)
                    {
                        if (harekate_sevom == 3)
                        {
                            if (button6.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 6;
                                button9.BackColor = Color.Red;
                                button9.Text = "x";
                                button9.Enabled = false;
                            }
                            else
                            {
                                button6.BackColor = Color.Red;
                                button6.Text = "x";
                                button6.Enabled = false;
                            }
                        }
                        else if (button3.BackColor == Color.Blue)
                        {
                            harekate_sevom = 3;
                            button2.BackColor = Color.Red;
                            button2.Text = "x";
                            button2.Enabled = false;
                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            button3.Text = "x";
                            button3.Enabled = false;
                        }
                    }
                    else if (button2.BackColor == Color.Blue && harekate_dovom == 2)
                    {
                        if (harekate_sevom == 1)
                        {
                            if (button6.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 6;
                                button7.BackColor = Color.Red;
                                button7.Text = "x";
                                button7.Enabled = false;
                            }
                            else
                            {
                                button6.BackColor = Color.Red;
                                button6.Text = "x";
                                button6.Enabled = false;
                            }
                        }
                        else if (button1.BackColor == Color.Blue)
                        {
                            harekate_sevom = 1;
                            button3.BackColor = Color.Red;
                            button3.Text = "x";
                            button3.Enabled = false;
                        }
                        else
                        {
                            button1.BackColor = Color.Red;
                            button1.Text = "x";
                            button1.Enabled = false;
                        }
                    }
                    else if (button3.BackColor == Color.Blue && harekate_dovom == 3)
                    {
                        if (harekate_sevom == 1)
                        {
                            if (button4.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 4;
                                button7.BackColor = Color.Red;
                                button7.Text = "x";
                                button7.Enabled = false;
                            }
                            else
                            {
                                button4.BackColor = Color.Red;
                                button4.Text = "x";
                                button4.Enabled = false;
                            }
                        }
                        else if (button1.BackColor == Color.Blue)
                        {
                            harekate_sevom = 1;
                            button2.BackColor = Color.Red;
                            button2.Text = "x";
                            button2.Enabled = false;
                        }
                        else
                        {
                            button1.BackColor = Color.Red;
                            button1.Text = "x";
                            button1.Enabled = false;
                        }
                    }
                    else if (button4.BackColor == Color.Blue && harekate_dovom == 4)
                    {
                        if (harekate_sevom == 3)
                        {
                            if (button9.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 9;
                                button6.BackColor = Color.Red;
                                button6.Text = "x";
                                button6.Enabled = false;
                            }
                            else
                            {
                                button9.BackColor = Color.Red;
                                button9.Text = "x";
                                button9.Enabled = false;
                            }
                        }
                        else if (button3.BackColor == Color.Blue)
                        {
                            harekate_sevom = 3;
                            button1.BackColor = Color.Red;
                            button1.Text = "x";
                            button1.Enabled = false;
                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            button3.Text = "x";
                            button3.Enabled = false;
                        }
                    }
                    else if (button6.BackColor == Color.Blue && harekate_dovom == 6)
                    {
                        if (harekate_sevom == 1)
                        {
                            if (button4.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 4;
                                button7.BackColor = Color.Red;
                                button7.Text = "x";
                                button7.Enabled = false;
                            }
                            else
                            {
                                button4.BackColor = Color.Red;
                                button4.Text = "x";
                                button4.Enabled = false;
                            }
                        }
                        else if (button1.BackColor == Color.Blue)
                        {
                            harekate_sevom = 1;
                            button3.BackColor = Color.Red;
                            button3.Text = "x";
                            button3.Enabled = false;
                        }
                        else
                        {
                            button1.BackColor = Color.Red;
                            button1.Text = "x";
                            button1.Enabled = false;
                        }
                    }
                    else if (button7.BackColor == Color.Blue && harekate_dovom == 7)
                    {
                        if (harekate_sevom == 1)
                        {
                            if (button6.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 6;
                                button2.BackColor = Color.Red;
                                button2.Text = "x";
                                button2.Enabled = false;
                            }
                            else
                            {
                                button6.BackColor = Color.Red;
                                button6.Text = "x";
                                button6.Enabled = false;
                            }
                        }
                        else if (button1.BackColor == Color.Blue)
                        {
                            harekate_sevom = 1;
                            button4.BackColor = Color.Red;
                            button4.Text = "x";
                            button4.Enabled = false;
                        }
                        else
                        {
                            button1.BackColor = Color.Red;
                            button1.Text = "x";
                            button1.Enabled = false;
                        }
                    }
                    else if (button9.BackColor == Color.Blue && harekate_dovom == 9)
                    {
                        if (harekate_sevom == 3)
                        {
                            if (button4.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 4;
                                button2.BackColor = Color.Red;
                                button2.Text = "x";
                                button2.Enabled = false;
                            }
                            else
                            {
                                button4.BackColor = Color.Red;
                                button4.Text = "x";
                                button4.Enabled = false;
                            }
                        }
                        else if (button3.BackColor == Color.Blue)
                        {
                            harekate_sevom = 3;
                            button6.BackColor = Color.Red;
                            button6.Text = "x";
                            button6.Enabled = false;
                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            button3.Text = "x";
                            button3.Enabled = false;
                        }
                    }
                }//complited

                else if (/*button9.BackColor == Color.Blue && */harekate_aval == 9)
                {
                    if (button1.BackColor == Color.Blue && harekate_dovom == 1)
                    {
                        if (harekate_sevom == 6)
                        {
                            if (button7.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 7;
                                button8.BackColor = Color.Red;
                                button8.Text = "x";
                                button8.Enabled = false;
                            }
                            else
                            {
                                button7.BackColor = Color.Red;
                                button7.Text = "x";
                                button7.Enabled = false;
                            }
                        }
                        else if (button6.BackColor == Color.Blue)
                        {
                            harekate_sevom = 6;
                            button3.BackColor = Color.Red;
                            button3.Text = "x";
                            button3.Enabled = false;
                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                            button6.Text = "x";
                            button6.Enabled = false;
                        }
                    }
                    else if (button2.BackColor == Color.Blue && harekate_dovom == 2)
                    {
                        if (harekate_sevom == 7)
                        {
                            if (button4.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 4;
                                button1.BackColor = Color.Red;
                                button1.Text = "x";
                                button1.Enabled = false;
                            }
                            else
                            {
                                button4.BackColor = Color.Red;
                                button4.Text = "x";
                                button4.Enabled = false;
                            }
                        }
                        else if (button7.BackColor == Color.Blue)
                        {
                            harekate_sevom = 7;
                            button8.BackColor = Color.Red;
                            button8.Text = "x";
                            button8.Enabled = false;
                        }
                        else
                        {
                            button7.BackColor = Color.Red;
                            button7.Text = "x";
                            button7.Enabled = false;
                        }
                    }
                    else if (button3.BackColor == Color.Blue && harekate_dovom == 3)
                    {
                        if (harekate_sevom == 4)
                        {
                            if (button8.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 8;
                                button7.BackColor = Color.Red;
                                button7.Text = "x";
                                button7.Enabled = false;
                            }
                            else
                            {
                                button8.BackColor = Color.Red;
                                button8.Text = "x";
                                button8.Enabled = false;
                            }
                        }
                        else if (button4.BackColor == Color.Blue)
                        {
                            harekate_sevom = 4;
                            button2.BackColor = Color.Red;
                            button2.Text = "x";
                            button2.Enabled = false;
                        }
                        else
                        {
                            button4.BackColor = Color.Red;
                            button4.Text = "x";
                            button4.Enabled = false;
                        }
                    }
                    else if (button4.BackColor == Color.Blue && harekate_dovom == 4)
                    {
                        if (harekate_sevom == 3)
                        {
                            if (button2.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 2;
                                button1.BackColor = Color.Red;
                                button1.Text = "x";
                                button1.Enabled = false;
                            }
                            else
                            {
                                button2.BackColor = Color.Red;
                                button2.Text = "x";
                                button2.Enabled = false;
                            }
                        }
                        else if (button3.BackColor == Color.Blue)
                        {
                            harekate_sevom = 3;
                            button6.BackColor = Color.Red;
                            button6.Text = "x";
                            button6.Enabled = false;
                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            button3.Text = "x";
                            button3.Enabled = false;
                        }
                    }
                    else if (button6.BackColor == Color.Blue && harekate_dovom == 6)
                    {
                        if (harekate_sevom == 7)
                        {
                            if (button2.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 2;
                                button4.BackColor = Color.Red;
                                button4.Text = "x";
                                button4.Enabled = false;
                            }
                            else
                            {
                                button2.BackColor = Color.Red;
                                button2.Text = "x";
                                button2.Enabled = false;
                            }
                        }
                        else if (button7.BackColor == Color.Blue)
                        {
                            harekate_sevom = 7;
                            button8.BackColor = Color.Red;
                            button8.Text = "x";
                            button8.Enabled = false;
                        }
                        else
                        {
                            button7.BackColor = Color.Red;
                            button7.Text = "x";
                            button7.Enabled = false;
                        }
                    }
                    else if (button7.BackColor == Color.Blue && harekate_dovom == 7)
                    {
                        if (harekate_sevom == 2)
                        {
                            if (button4.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 4;
                                button1.BackColor = Color.Red;
                                button1.Text = "x";
                                button1.Enabled = false;
                            }
                            else
                            {
                                button4.BackColor = Color.Red;
                                button4.Text = "x";
                                button4.Enabled = false;
                            }
                        }
                        else if (button2.BackColor == Color.Blue)
                        {
                            harekate_sevom = 2;
                            button6.BackColor = Color.Red;
                            button6.Text = "x";
                            button6.Enabled = false;
                        }
                        else
                        {
                            button2.BackColor = Color.Red;
                            button2.Text = "x";
                            button2.Enabled = false;
                        }
                    }
                    else if (button8.BackColor == Color.Blue && harekate_dovom == 8)
                    {
                        if (harekate_sevom == 3)
                        {
                            if (button4.BackColor == Color.Blue)
                            {
                                harekate_chaharom = 4;
                                button1.BackColor = Color.Red;
                                button1.Text = "x";
                                button1.Enabled = false;
                            }
                            else
                            {
                                button4.BackColor = Color.Red;
                                button4.Text = "x";
                                button4.Enabled = false;
                            }
                        }
                        else if (button3.BackColor == Color.Blue)
                        {
                            harekate_sevom = 3;
                            button6.BackColor = Color.Red;
                            button6.Text = "x";
                            button6.Enabled = false;
                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            button3.Text = "x";
                            button3.Enabled = false;
                        }
                    }
                }//complited 

                else if (pc == 1)
                {
                    if (harekate_aval == 1)
                    {
                        if (button3.BackColor == Color.Blue)
                        {
                            //harekate_sevom = 5;
                            //button5.BackColor = Color.Red;
                            //button5.Text = "x";
                            //button5.Enabled = false;
                        }
                        if (button3.BackColor == Color.Blue)
                        {
                            //harekate_sevom = 5;
                            //button5.BackColor = Color.Red;
                            //button5.Text = "x";
                            //button5.Enabled = false;
                        }
                        if (button3.BackColor == Color.Blue)
                        {
                            //harekate_sevom = 5;
                            //button5.BackColor = Color.Red;
                            //button5.Text = "x";
                            //button5.Enabled = false;
                        }
                        if (button3.BackColor == Color.Blue)
                        {
                            //harekate_sevom = 5;
                            //button5.BackColor = Color.Red;
                            //button5.Text = "x";
                            //button5.Enabled = false;
                        }
                        if (button3.BackColor == Color.Blue)
                        {
                            //harekate_sevom = 5;
                            //button5.BackColor = Color.Red;
                            //button5.Text = "x";
                            //button5.Enabled = false;
                        }
                        if (button3.BackColor == Color.Blue)
                        {
                            //harekate_sevom = 5;
                            //button5.BackColor = Color.Red;
                            //button5.Text = "x";
                            //button5.Enabled = false;
                        }

                    }
                    else if (harekate_aval == 2)
                    {
                        if (button3.BackColor == Color.Blue)
                        {
                            //harekate_sevom = 5;
                            //button5.BackColor = Color.Red;
                            //button5.Text = "x";
                            //button5.Enabled = false;
                        }
                        if (button3.BackColor == Color.Blue)
                        {
                            //harekate_sevom = 5;
                            //button5.BackColor = Color.Red;
                            //button5.Text = "x";
                            //button5.Enabled = false;
                        }
                        if (button3.BackColor == Color.Blue)
                        {
                            //harekate_sevom = 5;
                            //button5.BackColor = Color.Red;
                            //button5.Text = "x";
                            //button5.Enabled = false;
                        }
                        if (button3.BackColor == Color.Blue)
                        {
                            //harekate_sevom = 5;
                            //button5.BackColor = Color.Red;
                            //button5.Text = "x";
                            //button5.Enabled = false;
                        }
                        if (button3.BackColor == Color.Blue)
                        {
                            //harekate_sevom = 5;
                            //button5.BackColor = Color.Red;
                            //button5.Text = "x";
                            //button5.Enabled = false;
                        }
                        if (button3.BackColor == Color.Blue)
                        {
                            //harekate_sevom = 5;
                            //button5.BackColor = Color.Red;
                            //button5.Text = "x";
                            //button5.Enabled = false;
                        }
                    }
                    else if (harekate_aval == 3)
                    {
                        if (button3.BackColor == Color.Blue)
                        {
                            //harekate_sevom = 5;
                            //button5.BackColor = Color.Red;
                            //button5.Text = "x";
                            //button5.Enabled = false;
                        }
                        if (button3.BackColor == Color.Blue)
                        {
                            //harekate_sevom = 5;
                            //button5.BackColor = Color.Red;
                            //button5.Text = "x";
                            //button5.Enabled = false;
                        }
                        if (button3.BackColor == Color.Blue)
                        {
                            //harekate_sevom = 5;
                            //button5.BackColor = Color.Red;
                            //button5.Text = "x";
                            //button5.Enabled = false;
                        }
                        if (button3.BackColor == Color.Blue)
                        {
                            //harekate_sevom = 5;
                            //button5.BackColor = Color.Red;
                            //button5.Text = "x";
                            //button5.Enabled = false;
                        }
                        if (button3.BackColor == Color.Blue)
                        {
                            //harekate_sevom = 5;
                            //button5.BackColor = Color.Red;
                            //button5.Text = "x";
                            //button5.Enabled = false;
                        }
                        if (button3.BackColor == Color.Blue)
                        {
                            //harekate_sevom = 5;
                            //button5.BackColor = Color.Red;
                            //button5.Text = "x";
                            //button5.Enabled = false;
                        }
                    }
                    else if (harekate_aval == 4)
                    {
                        if (button3.BackColor == Color.Blue)
                        {
                            //harekate_sevom = 5;
                            //button5.BackColor = Color.Red;
                            //button5.Text = "x";
                            //button5.Enabled = false;
                        }
                        if (button3.BackColor == Color.Blue)
                        {
                            //harekate_sevom = 5;
                            //button5.BackColor = Color.Red;
                            //button5.Text = "x";
                            //button5.Enabled = false;
                        }
                        if (button3.BackColor == Color.Blue)
                        {
                            //harekate_sevom = 5;
                            //button5.BackColor = Color.Red;
                            //button5.Text = "x";
                            //button5.Enabled = false;
                        }
                        if (button3.BackColor == Color.Blue)
                        {
                            //harekate_sevom = 5;
                            //button5.BackColor = Color.Red;
                            //button5.Text = "x";
                            //button5.Enabled = false;
                        }
                        if (button3.BackColor == Color.Blue)
                        {
                            //harekate_sevom = 5;
                            //button5.BackColor = Color.Red;
                            //button5.Text = "x";
                            //button5.Enabled = false;
                        }
                        if (button3.BackColor == Color.Blue)
                        {
                            //harekate_sevom = 5;
                            //button5.BackColor = Color.Red;
                            //button5.Text = "x";
                            //button5.Enabled = false;
                        }
                    }
                    else if (harekate_aval == 5)
                    {
                        if (button3.BackColor == Color.Blue)
                        {
                            //harekate_sevom = 5;
                            //button5.BackColor = Color.Red;
                            //button5.Text = "x";
                            //button5.Enabled = false;
                        }
                        if (button3.BackColor == Color.Blue)
                        {
                            //harekate_sevom = 5;
                            //button5.BackColor = Color.Red;
                            //button5.Text = "x";
                            //button5.Enabled = false;
                        }
                        if (button3.BackColor == Color.Blue)
                        {
                            //harekate_sevom = 5;
                            //button5.BackColor = Color.Red;
                            //button5.Text = "x";
                            //button5.Enabled = false;
                        }
                        if (button3.BackColor == Color.Blue)
                        {
                            //harekate_sevom = 5;
                            //button5.BackColor = Color.Red;
                            //button5.Text = "x";
                            //button5.Enabled = false;
                        }
                        if (button3.BackColor == Color.Blue)
                        {
                            //harekate_sevom = 5;
                            //button5.BackColor = Color.Red;
                            //button5.Text = "x";
                            //button5.Enabled = false;
                        }
                        if (button3.BackColor == Color.Blue)
                        {
                            //harekate_sevom = 5;
                            //button5.BackColor = Color.Red;
                            //button5.Text = "x";
                            //button5.Enabled = false;
                        }
                    }
                    else if (harekate_aval == 6)
                    {
                        if (button3.BackColor == Color.Blue)
                        {
                            //harekate_sevom = 5;
                            //button5.BackColor = Color.Red;
                            //button5.Text = "x";
                            //button5.Enabled = false;
                        }
                        if (button3.BackColor == Color.Blue)
                        {
                            //harekate_sevom = 5;
                            //button5.BackColor = Color.Red;
                            //button5.Text = "x";
                            //button5.Enabled = false;
                        }
                        if (button3.BackColor == Color.Blue)
                        {
                            //harekate_sevom = 5;
                            //button5.BackColor = Color.Red;
                            //button5.Text = "x";
                            //button5.Enabled = false;
                        }
                        if (button3.BackColor == Color.Blue)
                        {
                            //harekate_sevom = 5;
                            //button5.BackColor = Color.Red;
                            //button5.Text = "x";
                            //button5.Enabled = false;
                        }
                        if (button3.BackColor == Color.Blue)
                        {
                            //harekate_sevom = 5;
                            //button5.BackColor = Color.Red;
                            //button5.Text = "x";
                            //button5.Enabled = false;
                        }
                        if (button3.BackColor == Color.Blue)
                        {
                            //harekate_sevom = 5;
                            //button5.BackColor = Color.Red;
                            //button5.Text = "x";
                            //button5.Enabled = false;
                        }
                    }
                    else if (harekate_aval == 7)
                    {
                        if (button3.BackColor == Color.Blue)
                        {
                            //harekate_sevom = 5;
                            //button5.BackColor = Color.Red;
                            //button5.Text = "x";
                            //button5.Enabled = false;
                        }
                        if (button3.BackColor == Color.Blue)
                        {
                            //harekate_sevom = 5;
                            //button5.BackColor = Color.Red;
                            //button5.Text = "x";
                            //button5.Enabled = false;
                        }
                        if (button3.BackColor == Color.Blue)
                        {
                            //harekate_sevom = 5;
                            //button5.BackColor = Color.Red;
                            //button5.Text = "x";
                            //button5.Enabled = false;
                        }
                        if (button3.BackColor == Color.Blue)
                        {
                            //harekate_sevom = 5;
                            //button5.BackColor = Color.Red;
                            //button5.Text = "x";
                            //button5.Enabled = false;
                        }
                        if (button3.BackColor == Color.Blue)
                        {
                            //harekate_sevom = 5;
                            //button5.BackColor = Color.Red;
                            //button5.Text = "x";
                            //button5.Enabled = false;
                        }
                        if (button3.BackColor == Color.Blue)
                        {
                            //harekate_sevom = 5;
                            //button5.BackColor = Color.Red;
                            //button5.Text = "x";
                            //button5.Enabled = false;
                        }
                    }
                    else if (harekate_aval == 8)
                    {
                        if (button3.BackColor == Color.Blue)
                        {
                            //harekate_sevom = 5;
                            //button5.BackColor = Color.Red;
                            //button5.Text = "x";
                            //button5.Enabled = false;
                        }
                        if (button3.BackColor == Color.Blue)
                        {
                            //harekate_sevom = 5;
                            //button5.BackColor = Color.Red;
                            //button5.Text = "x";
                            //button5.Enabled = false;
                        }
                        if (button3.BackColor == Color.Blue)
                        {
                            //harekate_sevom = 5;
                            //button5.BackColor = Color.Red;
                            //button5.Text = "x";
                            //button5.Enabled = false;
                        }
                        if (button3.BackColor == Color.Blue)
                        {
                            //harekate_sevom = 5;
                            //button5.BackColor = Color.Red;
                            //button5.Text = "x";
                            //button5.Enabled = false;
                        }
                        if (button3.BackColor == Color.Blue)
                        {
                            //harekate_sevom = 5;
                            //button5.BackColor = Color.Red;
                            //button5.Text = "x";
                            //button5.Enabled = false;
                        }
                        if (button3.BackColor == Color.Blue)
                        {
                            //harekate_sevom = 5;
                            //button5.BackColor = Color.Red;
                            //button5.Text = "x";
                            //button5.Enabled = false;
                        }
                    }
                }
                label1.Text = "player's Blue turn";
                rang--;
                barande();
            }
            else if (rang == 3)
            {

                label1.Text = "player's Blue turn";
                rang--;
                barande();

            }
            else if (rang == 1)
            {
                if (button1.Enabled == true)
                {
                    button1.BackColor = Color.Red;
                    button1.Text = "x";
                    button1.Enabled = false;
                    barande();
                }
                else if (button2.Enabled == true)
                {
                    button2.BackColor = Color.Red;
                    button2.Text = "x";
                    button2.Enabled = false;
                    barande();
                }
                else if (button3.Enabled == true)
                {
                    button3.BackColor = Color.Red;
                    button3.Text = "x";
                    button3.Enabled = false;
                    barande();
                }
                else if (button4.Enabled == true)
                {
                    button4.BackColor = Color.Red;
                    button4.Text = "x";
                    button4.Enabled = false;
                    barande();
                }
                else if (button5.Enabled == true)
                {
                    button5.BackColor = Color.Red;
                    button5.Text = "x";
                    button5.Enabled = false;
                    barande();
                }
                else if (button6.Enabled == true)
                {
                    button6.BackColor = Color.Red;
                    button6.Text = "x";
                    button6.Enabled = false;
                    barande();
                }
                else if (button7.Enabled == true)
                {
                    button7.BackColor = Color.Red;
                    button7.Text = "x";
                    button7.Enabled = false;
                    barande();
                }
                else if (button8.Enabled == true)
                {
                    button8.BackColor = Color.Red;
                    button8.Text = "x";
                    button8.Enabled = false;
                    barande();
                }
                else if (button9.Enabled == true)
                {
                    button9.BackColor = Color.Red;
                    button9.Text = "x";
                    button9.Enabled = false;
                    barande();
                }
            }
            barande();

        }
        public void easy()
        {
            barande();
            Button[] butn = { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            Random ez = new Random();
            int a = ez.Next(0, 8); ;
            int b = 0;
            do
            {
                if (a == 8)
                {
                    a = 0;
                }
                else
                {
                    a++;
                }
                b++;
                if (b > 16)
                {
                    break;
                }

            } while (butn[a].Enabled == false);
            if (b <= 16)
            {
                butn[a].BackColor = Color.Red;
                butn[a].Text = "x";
                butn[a].Enabled = false;
                //label1.Text = "player's Blue turn";
                rang--;
            }
            barande();


        }
        public void normal()
        {
            barande();

            if ((button2.Text == button3.Text || button5.Text == button9.Text || button4.Text == button7.Text) && button1.Enabled == true)
            {
                butn(button1);
            }
            else if ((button1.Text == button3.Text || button5.Text == button8.Text) && button2.Enabled == true)
            {
                butn(button2);
            }
            else if ((button2.Text == button1.Text || button5.Text == button7.Text || button6.Text == button9.Text) && button3.Enabled == true)
            {
                butn(button3);
            }
            else if ((button1.Text == button7.Text || button5.Text == button6.Text) && button4.Enabled == true)
            {
                butn(button4);
            }
            else if ((button1.Text == button9.Text || button3.Text == button7.Text || button4.Text == button6.Text || button2.Text == button8.Text) && button5.Enabled == true)
            {
                butn(button5);
            }
            else if ((button9.Text == button3.Text || button5.Text == button4.Text) && button6.Enabled == true)
            {
                butn(button6);
            }
            else if ((button1.Text == button4.Text || button5.Text == button3.Text || button8.Text == button9.Text) && button7.Enabled == true)
            {
                butn(button7);
            }
            else if ((button5.Text == button2.Text || button7.Text == button9.Text) && button8.Enabled == true)
            {
                butn(button8);
            }
            else if ((button6.Text == button3.Text || button5.Text == button1.Text || button8.Text == button7.Text) && button9.Enabled == true)
            {
                butn(button9);
            }
            else
            {
                easy();
            }
            barande();

        }
        public void redwin()
        {
            red_win++;
            label2.Text = "red wins =" + red_win;
            rang = 10;
            if (imp == 0) { label1.Text = "player's Red turn"; }
            Console.Beep();
            MessageBox.Show("Red win !! ", "Winner:");
            disabel();

        }
        public void bluewin()
        {
            blue_win++;
            label3.Text = "blue wins =" + blue_win;
            rang = 10;
            if (imp == 0) { label1.Text = "player's Blue turn"; }
            Console.Beep();
            MessageBox.Show("Blue win !! ", "Winer:");
            //System.IO.File.WriteAllText(@"C:\Temp\bug number " + txt+ ".text", "harekate_aval = \n" + harekate_aval + "harekate_dovom = " + harekate_dovom + "harekate_sevom = " + harekate_sevom + "harekate_chaharom = " + harekate_chaharom);

            disabel();

        }
        public void disabel()
        {
            button1.Enabled = true;
            button1.BackColor = Color.White;
            button1.Text = "1";
            button2.Enabled = true;
            button2.BackColor = Color.White;
            button2.Text = "2";
            button3.Enabled = true;
            button3.BackColor = Color.White;
            button3.Text = "3";
            button4.Enabled = true;
            button4.BackColor = Color.White;
            button4.Text = "4";
            button5.Enabled = true;
            button5.BackColor = Color.White;
            button5.Text = "5";
            button6.Enabled = true;
            button6.BackColor = Color.White;
            button6.Text = "6";
            button7.Enabled = true;
            button7.BackColor = Color.White;
            button7.Text = "7";
            button8.Enabled = true;
            button8.BackColor = Color.White;
            button8.Text = "8";
            button9.Enabled = true;
            button9.BackColor = Color.White;
            button9.Text = "9";
            harekate_aval = 0;
            harekate_dovom = 0;
            harekate_sevom = 0;
            harekate_chaharom = 0;
        }
        public void barande()
        {
            if (button1.Text == button2.Text && button2.Text == button3.Text && button3.Text == "x")
            {
                redwin();
            }
            else if (button1.Text == button2.Text && button2.Text == button3.Text && button3.Text == "o")
            {
                bluewin();
            }
            else if (button1.Text == button5.Text && button5.Text == button9.Text && button9.Text == "x")
            {
                redwin();
            }
            else if (button1.Text == button5.Text && button5.Text == button9.Text && button9.Text == "o")
            {
                bluewin();
            }
            else if (button1.Text == button4.Text && button4.Text == button7.Text && button7.Text == "x")
            {
                redwin();
            }
            else if (button1.Text == button4.Text && button4.Text == button7.Text && button7.Text == "o")
            {
                bluewin();
            }
            else if (button7.Text == button8.Text && button8.Text == button9.Text && button9.Text == "x")
            {
                redwin();
            }
            else if (button7.Text == button8.Text && button8.Text == button9.Text && button9.Text == "o")
            {
                bluewin();
            }
            else if (button7.Text == button5.Text && button5.Text == button3.Text && button3.Text == "x")
            {
                redwin();
            }
            else if (button7.Text == button5.Text && button5.Text == button3.Text && button3.Text == "o")
            {
                bluewin();
            }
            else if (button4.Text == button5.Text && button5.Text == button6.Text && button6.Text == "x")
            {
                redwin();
            }
            else if (button4.Text == button5.Text && button5.Text == button6.Text && button6.Text == "o")
            {
                bluewin();
            }
            else if (button1.Text == button4.Text && button4.Text == button7.Text && button7.Text == "x")
            {
                redwin();
            }
            else if (button1.Text == button4.Text && button4.Text == button7.Text && button7.Text == "o")
            {
                bluewin();
            }
            else if (button2.Text == button5.Text && button5.Text == button8.Text && button8.Text == "x")
            {
                redwin();
            }
            else if (button2.Text == button5.Text && button5.Text == button8.Text && button8.Text == "o")
            {
                bluewin();
            }
            else if (button3.Text == button6.Text && button6.Text == button9.Text && button9.Text == "x")
            {
                redwin();
            }
            else if (button3.Text == button6.Text && button6.Text == button9.Text && button9.Text == "o")
            {
                bluewin();

            }

            else if (button1.Enabled == false &&
                button2.Enabled == false &&
                button3.Enabled == false &&
                button4.Enabled == false &&
                button5.Enabled == false &&
                button6.Enabled == false &&
                button7.Enabled == false &&
                button8.Enabled == false &&
                button9.Enabled == false)
            {
                draw++;
                label4.Text = "draws = " + draw;
                disabel();
                if (imp == 3)
                {
                    //label1.Text = "player's Blue turn";
                    rang = 10;
                }

                if (imp == 1 || imp == 2 || imp == 0)
                {
                    if (draw % 2 == 0)
                    {
                        rang = 9;
                        if (imp == 0)
                        { label1.Text = "player's Red turn"; }
                    }
                    else
                    {
                        rang = 10;

                        if (imp == 0)
                        { label1.Text = "player's Blue turn"; }
                    }
                }
            }




        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (imp != 0)
            {
                    button1.BackColor = Color.Blue;
                    button1.Text = "o";
                rang--;
                button1.Enabled = false;
                if (imp == 3)
                {
                    AI();
                }
                if (imp == 2)
                {
                    normal();
                }
                if (imp == 1)
                {
                    easy();
                }


            }
            if (imp == 0)
            {
                if (rang % 2 == 1)
                {
                    button1.BackColor = Color.Red;
                    button1.Text = "x";
                    label1.Text = "player's Blue turn";
                }

                else
                {
                    button1.BackColor = Color.Blue;
                    button1.Text = "o";
                    label1.Text = "playe's Red turn";
                }
                rang--;

                button1.Enabled = false;
                barande();

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (imp != 0)
            {
                //if (rang % 2 == 0)
                {
                    button2.BackColor = Color.Blue;
                    button2.Text = "o";
                    
                }
                rang--;

                button2.Enabled = false;
                if (imp == 3)
                {
                    AI();
                }
                if (imp == 2)
                {
                    normal();
                }
                if (imp == 1)
                {
                    easy();
                }
            }
            if (imp == 0)
            {
                if (rang % 2 == 1)
                {
                    button2.BackColor = Color.Red;
                    button2.Text = "x";
                    label1.Text = "player's Blue turn";
                }

                else
                {
                    button2.BackColor = Color.Blue;
                    button2.Text = "o";
                    label1.Text = "playe's Red turn";
                }
                rang--;

                button2.Enabled = false;
                barande();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (imp != 0)
            {
               // if (rang % 2 == 0)
                {
                    button3.BackColor = Color.Blue;
                    button3.Text = "o";
                    
                }
                rang--;

                button3.Enabled = false;
                if (imp == 3)
                {
                    AI();
                }
                if (imp == 2)
                {
                    normal();
                }
                if (imp == 1)
                {
                    easy();
                }
            }
            if (imp == 0)
            {
                if (rang % 2 == 1)
                {
                    button3.BackColor = Color.Red;
                    button3.Text = "x";
                    label1.Text = "player's Blue turn";
                }

                else
                {
                    button3.BackColor = Color.Blue;
                    button3.Text = "o";
                    label1.Text = "playe's Red turn";
                }
                rang--;
                barande();
                button3.Enabled = false;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (imp != 0)
            {
                //if (rang % 2 == 0)
                {
                    button4.BackColor = Color.Blue;
                    button4.Text = "o";
                    
                }
                rang--;

                button4.Enabled = false;
                if (imp == 3)
                {
                    AI();
                }
                if (imp == 2)
                {
                    normal();
                }
                if (imp == 1)
                {
                    easy();
                }
            }
            if (imp == 0)
            {
                if (rang % 2 == 1)
                {
                    button4.BackColor = Color.Red;
                    button4.Text = "x";
                    label1.Text = "player's Blue turn";
                }

                else
                {
                    button4.BackColor = Color.Blue;
                    button4.Text = "o";
                    label1.Text = "playe's Red turn";
                }
                rang--;

                button4.Enabled = false; barande();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (imp != 0)
            {
                //if (rang % 2 == 0)
                {
                    button5.BackColor = Color.Blue;
                    button5.Text = "o";
                    

                }
                rang--;

                button5.Enabled = false;
                if (imp == 3)
                {
                    AI();
                }
                if (imp == 2)
                {
                    normal();
                }
                if (imp == 1)
                {
                    easy();
                }
            }
            if (imp == 0)
            {
                if (rang % 2 == 1)
                {
                    button5.BackColor = Color.Red;
                    button5.Text = "x";
                    label1.Text = "player's Blue turn";
                }

                else
                {
                    button5.BackColor = Color.Blue;
                    button5.Text = "o";
                    label1.Text = "playe's Red turn";
                }
                rang--;

                button5.Enabled = false;barande();
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (imp != 0)
            {
                //if (rang % 2 == 0)
                {
                    button6.BackColor = Color.Blue;
                    button6.Text = "o";
                    
                }
                rang--;

                button6.Enabled = false;
                if (imp == 3)
                {
                    AI();
                }
                if (imp == 2)
                {
                    normal();
                }
                if (imp == 1)
                {
                    easy();
                }
            }
            if (imp == 0)
            {
                if (rang % 2 == 1)
                {
                    button6.BackColor = Color.Red;
                    button6.Text = "x";
                    label1.Text = "player's Blue turn";
                }

                else
                {
                    button6.BackColor = Color.Blue;
                    button6.Text = "o";
                    label1.Text = "playe's Red turn";
                }
                rang--;

                button6.Enabled = false;barande();
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (imp != 0)
            {
                //if (rang % 2 == 0)
                {
                    button7.BackColor = Color.Blue;
                    button7.Text = "o";
                    
                }
                rang--;

                button7.Enabled = false;
                if (imp == 3)
                {
                    AI();
                }
                if (imp == 2)
                {
                    normal();
                }
                if (imp == 1)
                {
                    easy();
                }
            }
            if (imp == 0)
            {
                if (rang % 2 == 1)
                {
                    button7.BackColor = Color.Red;
                    button7.Text = "x";
                    label1.Text = "player's Blue turn";
                }

                else
                {
                    button7.BackColor = Color.Blue;
                    button7.Text = "o";
                    label1.Text = "playe's Red turn";
                }
                rang--;

                button7.Enabled = false;barande();
            }
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (imp != 0)
            {
                //if (rang % 2 == 0)
                {
                    button8.BackColor = Color.Blue;
                    button8.Text = "o";
                   
                }
                rang--;

                button8.Enabled = false;
                if (imp == 3)
                {
                    AI();
                }
                if (imp == 2)
                {
                    normal();
                }
                if (imp == 1)
                {
                    easy();
                }
            }
            if (imp == 0)
            {
                if (rang % 2 == 1)
                {
                    button8.BackColor = Color.Red;
                    button8.Text = "x";
                    label1.Text = "player's Blue turn";
                }

                else
                {
                    button8.BackColor = Color.Blue;
                    button8.Text = "o";
                    label1.Text = "playe's Red turn";
                }
                rang--;

                button8.Enabled = false;barande();
            }
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (imp != 0)
            {
                //if (rang % 2 == 0)
                {
                    button9.BackColor = Color.Blue;
                    button9.Text = "o";
                    
                }
                rang--;

                button9.Enabled = false;
                if (imp == 3)
                {
                    AI();
                }
                if (imp == 2)
                {
                    normal();
                }
                if (imp == 1)
                {
                    easy();
                }
            }
            if (imp == 0)
            {
                if (rang % 2 == 1)
                {
                    button9.BackColor = Color.Red;
                    button9.Text = "x";
                    label1.Text = "player's Blue turn";
                }

                else
                {
                    button9.BackColor = Color.Blue;
                    button9.Text = "o";
                    label1.Text = "playe's Red turn";
                }
                rang--;

                button9.Enabled = false;barande();
            }
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            restart();
        }
        int g = 1;
        private void button11_Click(object sender, EventArgs e)
        {
            g++;
            var thread = new Thread(music);
            thread.IsBackground = true;
            thread.Start();
            //m.PlayLooping();

        }
        private void music()
        {
            Label p;
            while (g % 2 == 0)
            {
                Console.Beep(659, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(523, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(375); Console.Beep(392, 125); Thread.Sleep(375); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(375); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125); Thread.Sleep(1125); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125);
            }
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.NumPad1)
            {
                button1.PerformClick();

            }
            if (e.KeyCode == Keys.NumPad2)
            {
                button2.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad3)
            {
                button3.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad4)
            {
                button4.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad5)
            {
                button5.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad6)
            {
                button6.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad7)
            {
                button7.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad8)
            {
                button8.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad9)
            {
                button9.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.R)
            {
                button10.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.S)
            {
                button11.PerformClick();
            }
            if (e.KeyCode == Keys.M)
            {
                button12.PerformClick();
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (imp == 0)
            {
                imp = 1;
                button12.Text = "Easy";
                restart();
                label1.Text = " ";

            }
            else if (imp == 1)
            {
                imp = 2;
                button12.Text = "Normal ";
                restart();
                label1.Text = " ";
            }
            else if (imp == 2)
            {
                imp = 3;
                restart();
                button12.Text = "impossibel !";
                label1.Text = " ";
            }
            else if (imp == 3)
            {
                imp = 0;
                restart();
                button12.Text = "2 players ";
                label1.Text = "player's Blue turn";
            }
        }

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.KeyPreview = true;
            if (imp == 3)
            { AI(); }
            if (imp == 2)
            { normal(); }
            if (imp == 1)
            { easy(); }
        }
        private void restart()
        {
            disabel();
            rang = 10;
            //shomare_barende = 0;
            red_win = 0;
            label2.Text = "red wins =" + red_win;
            blue_win = 0;
            label3.Text = "blue wins =" + blue_win;
            draw = 0;
            label4.Text = "draws = " + draw;
            if (imp == 0)
            { label1.Text = "playe's Red turn"; }
            //AI();
        }
        private void butn(Button a)
        {
            a.BackColor = Color.Red;
            a.Text = "x";
            a.Enabled = false;
            //label1.Text = "player's Blue turn";
            rang--;
        }
    }
}
