using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Threading;
using System.Collections.Generic;

namespace PaintDZ
{
    public partial class Main_Paint : Form
    {
        int x1, x2, y1, y2, xx, yy, k, tbvalue, nh = 1, x_MouseDown_1, y_MouseDown_1;         
        string per, uvel, cvet;        
        private bool isPainting = false;        
        Graphics drawArea;
        private SolidBrush myBrush;
        private Pen myPen;
        void x1x2y1y2()
        {

            string[] parametr = per.Split(',');
            int number;
            bool result1 = int.TryParse(parametr[0], out number);
            bool result2 = int.TryParse(parametr[1], out number);
            bool result3 = int.TryParse(parametr[2], out number);
            bool result4 = int.TryParse(parametr[3], out number);
            if (result1 && result2 && result3 && result4)
            {
                x1 = Convert.ToInt32(parametr[0]);
                y1 = Convert.ToInt32(parametr[1]);
                x2 = Convert.ToInt32(parametr[2]);
                y2 = Convert.ToInt32(parametr[3]);
            }
            else
            {
                Form newForm = new FormError1();
                newForm.Show();
                Thread.Sleep(2000);
                newForm.Close();
            }
        }

        void xxyy()
        {
            string[] uvelichenie = uvel.Split(',');
            int number;
            bool result5 = int.TryParse(uvelichenie[0], out number);
            bool result6 = int.TryParse(uvelichenie[1], out number);
            if (result5 && result6)
            {
                xx = Convert.ToInt32(uvelichenie[0]);
                yy = Convert.ToInt32(uvelichenie[1]);
            }
            else
            {
                Form newForm = new FormError1();
                newForm.Show();
                Thread.Sleep(2000);
                newForm.Close();
            }
        }

        void color()
        {
            Color myColor = ColorTranslator.FromHtml(cvet);
            myBrush.Color = myColor;
            myPen.Color = myColor;
        }
       
        public Main_Paint()
        {
            InitializeComponent();
            drawArea = drawingArea.CreateGraphics();   
        }

        private void pColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                myBrush.Color = colorDialog1.Color;
                myPen.Color = myBrush.Color;
                pColor.BackColor = colorDialog1.Color;
            }            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            myBrush = new SolidBrush(pColor.BackColor);
            myPen = new Pen(pColor.BackColor, 3);
        }

        private void bGO_Click(object sender, EventArgs e)
        {
            string all;
            all = Convert.ToString(cmdBox.Text);//считываем из комбобокса в стринг
            all = (all.ToLower());//убираем верхний регистр
            all = System.Text.RegularExpressions.Regex.Replace(all, " +", " ");//убираем лишнее
            all = System.Text.RegularExpressions.Regex.Replace(all, " d", "d");//убираем лишнее
            all = System.Text.RegularExpressions.Regex.Replace(all, " c", "c");//убираем лишнее
            all = System.Text.RegularExpressions.Regex.Replace(all, " ,", ",");//убираем лишнее
            all = System.Text.RegularExpressions.Regex.Replace(all, ", ", ",");//убираем лишнее
            cmdBox.Text = all;//выводим исправленное комбобокс
            string[] slova = all.Split(' ');//разбивает строку на куски от пробела до пробела
            if ((string.Compare(slova[0], "delete", true) == 0) && (all.Length > 7))//проверка первого слова draw
            {
                SolidBrush whiteBrush = new SolidBrush(Color.White);
                Rectangle rect = new Rectangle(0, 0, 5000, 5000);
                drawArea.FillRectangle(whiteBrush, rect);
                listBox.Items.Add(all);
                listBox.Items.Clear();
                historyBox.Items.Add(all);
                historyBoxNumber.Items.Add(nh);
                nh++;
            }  //закрылся if clear                  
            if ((string.Compare(slova[0], "draw", true) == 0) && (all.Length > 16))//проверка draw
            {
                k = 0;//левая переменная для удобства
                if (string.Compare(slova[1], "line", true) == 0)//проверка line
                {
                    per = slova[2];
                    x1x2y1y2();
                    drawArea.DrawLine(myPen, x1, y1, x2, y2);
                    string color1 = ColorTranslator.ToHtml(myPen.Color);//записать в string цвет
                    listBox.Items.Add("2 " + all + " " + color1);
                    k = 1;
                    historyBox.Items.Add(all);
                    historyBoxNumber.Items.Add(nh);
                    listBoxNumber.Items.Add(nh);
                    nh++;
                }  //конец if line                
                if (string.Compare(slova[1], "rectangle", true) == 0)//проверка rectangle
                {
                    per = slova[2];
                    x1x2y1y2();
                    drawArea.DrawRectangle(myPen, x1, y1, x2, y2);
                    string color1 = ColorTranslator.ToHtml(myPen.Color);//записать в string цвет
                    listBox.Items.Add("1 " + all + " " + color1);
                    k = 1;
                    historyBox.Items.Add(all);
                    historyBoxNumber.Items.Add(nh);
                    listBoxNumber.Items.Add(nh);
                    nh++;
                } //конец if rectangle
                if (string.Compare(slova[1], "ellipse", true) == 0)//проверка ellipse
                {
                    per = slova[2];
                    x1x2y1y2();
                    drawArea.DrawEllipse(myPen, x1, y1, x2, y2);
                    string color1 = ColorTranslator.ToHtml(myPen.Color);//записать в string цвет
                    listBox.Items.Add("3 " + all + " " + color1);
                    k = 1;
                    historyBox.Items.Add(all);
                    historyBoxNumber.Items.Add(nh);
                    listBoxNumber.Items.Add(nh);
                    nh++;
                }   //конец if ellipse
                if ((string.Compare(slova[1], "filled", true) == 0) && (all.Length > 22))//проверка filled
                {
                    if (string.Compare(slova[2], "rectangle", true) == 0)//проверка rectangle
                    {
                        per = slova[3];
                        x1x2y1y2();
                        Rectangle rect = new Rectangle(x1, y1, x2, y2);
                        drawArea.FillRectangle(myBrush, rect);
                        string color1 = ColorTranslator.ToHtml(myBrush.Color);//записать в string цвет
                        listBox.Items.Add("4 " + all + " " + color1);
                        k = 1;
                        historyBox.Items.Add(all);
                        historyBoxNumber.Items.Add(nh);
                        listBoxNumber.Items.Add(nh);
                        nh++;
                    }  //конец if rectangle внутри filled
                    if (String.Compare(slova[2], "ellipse", true) == 0)//проверка ellipse
                    {
                        per = slova[3];
                        x1x2y1y2();
                        Rectangle elli = new Rectangle(x1, y1, x2, y2);
                        drawArea.FillEllipse(myBrush, elli);
                        string color1 = ColorTranslator.ToHtml(myBrush.Color);//записать в string цвет
                        listBox.Items.Add("5 " + all + " " + color1);
                        k = 1;
                        historyBox.Items.Add(all);
                        historyBoxNumber.Items.Add(nh);
                        listBoxNumber.Items.Add(nh);
                        nh++;
                    }//конец if ellipse внутри filled
                    //k = 1;
                } //конец if filled, k будет 0 если ничего не нарисовалось
                if ((k == 0) && (all.Length > 22))
                {
                    int number;
                    int count;
                    bool result = int.TryParse(slova[1], out number);
                    if (result)//количество фигурок в цикле
                    {
                        count = Convert.ToInt32(slova[1]);
                        if (string.Compare(slova[2], "ellipses", true) == 0)
                        {
                            per = slova[3];
                            uvel = slova[7];
                            x1x2y1y2();
                            xxyy();
                            for (int i = 0; i < count; i++)
                            {
                                drawArea.DrawEllipse(myPen, x1 + xx * i, y1 + yy * i, x2, y2);
                                string color1 = ColorTranslator.ToHtml(myPen.Color);//записать в string цвет
                                listBox.Items.Add("3 draw ellipse " + (x1 + xx * i) + "," + (y1 + yy * i) + "," + x2 + "," + y2 + " " + color1);
                                k = 1;
                                historyBox.Items.Add("draw ellipse " + (x1 + xx * i) + "," + (y1 + yy * i) + "," + x2 + "," + y2 + " " + color1);
                                historyBoxNumber.Items.Add(nh);
                                listBoxNumber.Items.Add(nh);
                                nh++;
                            } 
                        } // конец элипса циклического
                        if (string.Compare(slova[2], "rectangles", true) == 0)
                        {
                            per = slova[3];
                            uvel = slova[7];
                            x1x2y1y2();
                            xxyy();
                            for (int i = 0; i < count; i++)
                            {
                                drawArea.DrawRectangle(myPen, x1 + xx * i, y1 + yy * i, x2, y2);
                                string color1 = ColorTranslator.ToHtml(myPen.Color);//записать в string цвет
                                listBox.Items.Add("1 draw rectangle " + (x1 + xx * i) + "," + (y1 + yy * i) + "," + x2 + "," + y2 + " " + color1);
                                k = 1;
                                historyBox.Items.Add("draw rectangle " + (x1 + xx * i) + "," + (y1 + yy * i) + "," + x2 + "," + y2 + " " + color1);
                                historyBoxNumber.Items.Add(nh);
                                listBoxNumber.Items.Add(nh);
                                nh++;
                            } 
                        } // конец прямоугольника циклического
                        if (string.Compare(slova[2], "filled", true) == 0)
                        {
                            if (string.Compare(slova[3], "ellipses", true) == 0)
                            {
                                per = slova[4];
                                uvel = slova[8];
                                x1x2y1y2();
                                xxyy();
                                for (int i = 0; i < count; i++)
                                {
                                    Rectangle rect = new Rectangle(x1 + xx * i, y1 + yy * i, x2, y2);
                                    drawArea.FillEllipse(myBrush, rect);
                                    string color1 = ColorTranslator.ToHtml(myBrush.Color);//записать в string цвет
                                    listBox.Items.Add("5 draw filled ellipse " + (x1 + xx * i) + "," + (y1 + yy * i) + "," + x2 + "," + y2 + " " + color1);
                                    k = 1;
                                    historyBox.Items.Add("draw filled ellipse " + (x1 + xx * i) + "," + (y1 + yy * i) + "," + x2 + "," + y2 + " " + color1);
                                    historyBoxNumber.Items.Add(nh);
                                    listBoxNumber.Items.Add(nh);
                                    nh++;
                                } 
                            }// конец залитого элипса циклического
                            if (string.Compare(slova[3], "rectangles", true) == 0)
                            {
                                per = slova[4];
                                uvel = slova[8];
                                x1x2y1y2();
                                xxyy();
                                for (int i = 0; i < count; i++)
                                {
                                    Rectangle elli = new Rectangle(x1 + xx * i, y1 + yy * i, x2, y2);
                                    drawArea.FillRectangle(myBrush, elli);
                                    string color1 = ColorTranslator.ToHtml(myBrush.Color);//записать в string цвет
                                    listBox.Items.Add("4 draw filled rectangle " + (x1 + xx * i) + "," + (y1 + yy * i) + "," + x2 + "," + y2 + " " + color1);
                                    k = 1;
                                    historyBox.Items.Add("draw filled rectangle " + (x1 + xx * i) + "," + (y1 + yy * i) + "," + x2 + "," + y2 + " " + color1);
                                    historyBoxNumber.Items.Add(nh);
                                    listBoxNumber.Items.Add(nh);
                                    nh++;
                                } 
                            }// конец залитого прямоугольника циклического
                        }//конец if для filled циклического                         
                    } //конец if result OK 
                    else
                    {
                        Form newForm = new FormError1();
                        newForm.Show();
                        Thread.Sleep(2000);
                        newForm.Close();
                    }
                }//конец if k==0
            }//конец if для draw 
            else
            {
                Form newForm = new FormError4();
                newForm.Show();
                Thread.Sleep(2500);
                newForm.Close();
            }
        }//конец кнопки GO

        private void bDelete_Click(object sender, EventArgs e)
        {
            int x = (listBox.SelectedIndex);
            if (x >= 0)
            {
                listBox.Items.RemoveAt(x);
                listBoxNumber.Items.RemoveAt(x);
                historyBox.Items.Add("delete object number " + (x + 1));
                historyBoxNumber.Items.Add(nh);
                nh++;
                bRefresh_Click(sender, e);
            }
            else
            {
                Form newForm = new FormError2();
                newForm.Show();
                Thread.Sleep(2000);
                newForm.Close();
            }            
        } //конец кнопку удаления строки

        private void bDeleteAll_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            listBoxNumber.Items.Clear();
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            Rectangle rect = new Rectangle(0, 0, 5000, 5000);
            drawArea.FillRectangle(whiteBrush, rect);
            historyBox.Items.Add("delete all");
            historyBoxNumber.Items.Add(nh);
            nh++;
        }//конец кнопки очитски

        private void bRefresh_Click(object sender, EventArgs e)
        {
            int n = 1;
            int pervoe;
            string[] spisok = new string[listBox.Items.Count];
            for (int i = 0; i < spisok.Length; i++)
            {
                n++;
                spisok[i] = listBox.Items[i].ToString();
            }
            //конец цикла считывание из списка
            for (int i = 0; i < n - 1; i++)
            {
                string[] slova = spisok[i].Split(' ');//разбивает строку на куски от пробела до пробела
                pervoe = Convert.ToInt32(slova[0]);
                switch (pervoe)
                {
                    case 1:
                        per = slova[3];
                        cvet = slova[4];
                        color();
                        x1x2y1y2();
                        drawArea.DrawRectangle(myPen, x1, y1, x2, y2);
                        break;
                    case 2:
                        per = slova[3];
                        cvet = slova[4];
                        color();
                        x1x2y1y2();
                        drawArea.DrawLine(myPen, x1, y1, x2, y2);
                        break;
                    case 3:
                        per = slova[3];
                        cvet = slova[4];
                        color();
                        x1x2y1y2();
                        drawArea.DrawEllipse(myPen, x1, y1, x2, y2);
                        break;
                    case 4:
                        per = slova[4];
                        cvet = slova[5];
                        color();
                        x1x2y1y2();
                        Rectangle rectan = new Rectangle(x1, y1, x2, y2);
                        drawArea.FillRectangle(myBrush, rectan);
                        break;
                    case 5:
                        per = slova[4];
                        cvet = slova[5];
                        color();
                        x1x2y1y2();
                        Rectangle ellipse = new Rectangle(x1, y1, x2, y2);
                        drawArea.FillEllipse(myBrush, ellipse);
                        break;
                    case 6:
                        cvet = slova[6];
                        color();
                        drawArea.FillEllipse(myBrush, Convert.ToInt32(slova[3]), Convert.ToInt32(slova[4]), Convert.ToInt32(slova[5]), Convert.ToInt32(slova[5]));
                        break;
                }//конец свича
            }//конец цикла перерисовки
        } //конец кнопку refresh

        private void drawingArea_MouseDown(object sender, MouseEventArgs e)
        {
            x_MouseDown_1 = e.X;
            y_MouseDown_1 = e.Y;
            tbvalue = chooseBar.Value;
            if (chooseBar.Value == 6)
            {
                isPainting = true;
            }
        }//конец нажатия мыши

        private void historyBox_MouseUp(object sender, MouseEventArgs e)
        {
            Thread.Sleep(150);
            historyBoxNumber.TopIndex = historyBox.TopIndex;
            historyBoxNumber.Refresh();
        }

        private void listBoxNumber_MouseUp(object sender, MouseEventArgs e)
        {
            Thread.Sleep(150);
            listBoxNumber.TopIndex = listBox.TopIndex;
            listBoxNumber.Refresh();
        }

        private void Main_Paint_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                bGO_Click(new object(), new EventArgs());
            }
            if (e.Control && e.KeyCode == Keys.Z)
            {
                int x = (listBox.Items.Count - 1);
                if (x > -1)
                {
                    listBox.Items.RemoveAt(x);
                    listBoxNumber.Items.RemoveAt(x);
                }
                int m = (historyBox.Items.Count - 1);
                if (m > -1)
                {
                    historyBox.Items.RemoveAt(m);
                    historyBoxNumber.Items.RemoveAt(m);
                    bRefresh_Click(sender, e);
                }
                if (e.KeyData == Keys.Delete)
                {
                    bDelete_Click(new object(), new EventArgs());
                }
            }
            if (e.KeyData == Keys.Escape)
            {
                drawingArea.Enabled = false;
                drawingArea.Cursor = Cursors.Arrow;
            }
        }

        private void chooseBar_MouseDown(object sender, MouseEventArgs e)
        {
            drawingArea.Enabled = true;
            drawingArea.Cursor = Cursors.Hand;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AboutBox newForm = new AboutBox();
            newForm.Show();
        }

        private void bSave_Click(object sender, EventArgs e)
        {           
            Bitmap saved = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics graphics = Graphics.FromImage(saved as Image);
            graphics.CopyFromScreen(0,0,0,0, saved.Size);            
            saved.Save("printscreen.bmp", ImageFormat.Bmp);
        }

        private void pColor_Paint(object sender, PaintEventArgs e){}

        private void bSaveList_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)

                {
                    StreamWriter sw = new StreamWriter(myStream);
                    for (int i = 0; i < listBox.Items.Count; i++)
                    {
                        listBox.SelectedIndex = i;
                        sw.WriteLine(listBox.SelectedItem.ToString());
                    }
                    sw.Close();
                    myStream.Close();
                }
            }
        }

        private void bListLoad_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            OpenFileDialog f = new OpenFileDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                listBox.Items.Clear();
                List<string> lines = new List<string>();
                using (StreamReader r = new StreamReader(f.OpenFile()))
                {
                    string line;
                    while ((line = r.ReadLine()) != null)
                    {
                        listBox.Items.Add(line);
                    }
                }
            }
            bRefresh_Click(sender, e);
        }

        private void bList_Click(object sender, EventArgs e)
        {
            historyBox.Visible = false;
            historyBoxNumber.Visible = false;
            bhistory.BackColor = Color.FromArgb(255, 255, 192);
            bList.BackColor = Color.FromArgb(0, 255, 255);
        }

        private void bSize_Click(object sender, EventArgs e)
        {
            int X, Y, number;
            bool result1 = int.TryParse(Text = textBoxX.Text, out number);
            bool result2 = int.TryParse(Text = textBoxY.Text, out number);
            if (result1 && result2)
            {
                X = Convert.ToInt32(textBoxX.Text);
                Y = Convert.ToInt32(textBoxY.Text);
                if (X > 0 && X < 4001 && Y > 0 && Y < 4001)
                {
                    drawingArea.Size = new Size(X, Y);
                }
                Text = "Paint";
            }
            else
            {
                Form newForm = new FormError3();
                newForm.Show();
                Thread.Sleep(2500);
                newForm.Close();
            }
            bRefresh_Click(sender, e);
        }

        private  void bRe(object sender, PaintEventArgs e)
        {
                bRefresh_Click(sender, e);            
        }      
       
        private void bhistory_Click(object sender, EventArgs e)
        {
            historyBox.Visible = true;
            historyBoxNumber.Visible = true;
            bhistory.BackColor = Color.FromArgb(0, 255, 255);
            bList.BackColor = Color.FromArgb(255, 255, 192);            
        }

        private void drawingArea_MouseUp(object sender, MouseEventArgs e)
        {
            Graphics g = Graphics.FromHwnd(drawingArea.Handle);
            string color1 = ColorTranslator.ToHtml(myPen.Color);//записать в string цвет
            switch (tbvalue)
            {
                case 1:
                    g.DrawLine(myPen, x_MouseDown_1, y_MouseDown_1, e.X, e.Y);
                    listBox.Items.Add("2 draw line " + x_MouseDown_1 + "," + y_MouseDown_1 + "," + e.X + "," + e.Y + " " + color1);
                    historyBox.Items.Add("draw line " + x_MouseDown_1 + "," + y_MouseDown_1 + "," + e.X + "," + e.Y + " " + color1);
                    historyBoxNumber.Items.Add(nh);
                    listBoxNumber.Items.Add(nh);
                    nh++;
                    break;
                case 2:
                    g.DrawEllipse(myPen, x_MouseDown_1, y_MouseDown_1, e.X - x_MouseDown_1, e.Y - y_MouseDown_1);
                    listBox.Items.Add("3 draw ellipse " + x_MouseDown_1 + "," + y_MouseDown_1 + "," + (e.X - x_MouseDown_1) + "," + (e.Y - y_MouseDown_1) + " " + color1);
                    historyBox.Items.Add("draw ellipse " + x_MouseDown_1 + ", " + y_MouseDown_1 + ", " + (e.X - x_MouseDown_1) + ", " + (e.Y - y_MouseDown_1) + " " + color1);
                    historyBoxNumber.Items.Add(nh);
                    listBoxNumber.Items.Add(nh);
                    nh++;
                    break;
                case 3:
                    Rectangle ellip = new Rectangle(x_MouseDown_1, y_MouseDown_1, e.X - x_MouseDown_1, e.Y - y_MouseDown_1);
                    g.FillEllipse(myBrush, ellip);
                    listBox.Items.Add("5 draw filled ellipse " + x_MouseDown_1 + "," + y_MouseDown_1 + "," + (e.X - x_MouseDown_1) + "," + (e.Y - y_MouseDown_1) + " " + color1);
                    historyBox.Items.Add("draw filled ellipse " + x_MouseDown_1 + "," + y_MouseDown_1 + "," + (e.X - x_MouseDown_1) + "," + (e.Y - y_MouseDown_1) + " " + color1);
                    historyBoxNumber.Items.Add(nh);
                    listBoxNumber.Items.Add(nh);
                    nh++;
                    break;
                case 4:
                    g.DrawRectangle(myPen, x_MouseDown_1, y_MouseDown_1, e.X - x_MouseDown_1, e.Y - y_MouseDown_1);
                    listBox.Items.Add("1 draw rectangle " + x_MouseDown_1 + "," + y_MouseDown_1 + "," + (e.X - x_MouseDown_1) + "," + (e.Y - y_MouseDown_1) + " " + color1);
                    historyBox.Items.Add("draw rectangle " + x_MouseDown_1 + "," + y_MouseDown_1 + "," + (e.X - x_MouseDown_1) + "," + (e.Y - y_MouseDown_1) + " " + color1);
                    historyBoxNumber.Items.Add(nh);
                    listBoxNumber.Items.Add(nh);
                    nh++;
                    break;
                case 5:
                    Rectangle rectang = new Rectangle(x_MouseDown_1, y_MouseDown_1, e.X - x_MouseDown_1, e.Y - y_MouseDown_1);
                    g.FillRectangle(myBrush, rectang);
                    listBox.Items.Add("4 draw filled rectangle " + x_MouseDown_1 + "," + y_MouseDown_1 + "," + (e.X - x_MouseDown_1) + "," + (e.Y - y_MouseDown_1) + " " + color1);
                    historyBox.Items.Add("draw filled rectangle " + x_MouseDown_1 + "," + y_MouseDown_1 + "," + (e.X - x_MouseDown_1) + "," + (e.Y - y_MouseDown_1) + " " + color1);
                    historyBoxNumber.Items.Add(nh);
                    listBoxNumber.Items.Add(nh);
                    nh++;
                    break;
                case 6:
                    isPainting = false;
                    break;
            } //конец свича            
        }
        //конец отжатия мыши
        private void drawingArea_MouseMove(object sender, MouseEventArgs e)
        {
            if (isPainting == true)
            {              
                Graphics g = Graphics.FromHwnd(drawingArea.Handle);
                g.FillEllipse(myBrush, e.X, e.Y, thicknessBar.Value, thicknessBar.Value);
                string color1 = ColorTranslator.ToHtml(myPen.Color);//записать в string цвет
                listBox.Items.Add("6 brush dot " + e.X + " " + e.Y + " " + thicknessBar.Value + " " + color1);
                historyBox.Items.Add("brush dot " + e.X + " " + e.Y + " " + thicknessBar.Value + " " + color1);
                historyBoxNumber.Items.Add(nh);
                listBoxNumber.Items.Add(nh);
                nh++;
            }
        }
        //конец движения мышки
        //ниже изменения положения трекбара при нажатии на фигурки 
        private void pLine_Click(object sender, EventArgs e)
        {
            chooseBar.Value = 1;
            drawingArea.Enabled = true;
            drawingArea.Cursor = Cursors.Hand;
        }

        private void pElli_Click(object sender, EventArgs e)
        {
            chooseBar.Value = 2;
            drawingArea.Enabled = true;
            drawingArea.Cursor = Cursors.Hand;
        }

        private void pFElli_Click(object sender, EventArgs e)
        {
            chooseBar.Value = 3;
            drawingArea.Enabled = true;
            drawingArea.Cursor = Cursors.Hand;
        }

        private void pRect_Click(object sender, EventArgs e)
        {
            chooseBar.Value = 4;
            drawingArea.Enabled = true;
            drawingArea.Cursor = Cursors.Hand;
        }

        private void pFRect_Click(object sender, EventArgs e)
        {
            chooseBar.Value = 5;
            drawingArea.Enabled = true;
            drawingArea.Cursor = Cursors.Hand;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            chooseBar.Value = 6;
            drawingArea.Enabled = true;
            drawingArea.Cursor = Cursors.Hand;
        }
    } //закрытие Main_Paint   
}//PaintDZ
