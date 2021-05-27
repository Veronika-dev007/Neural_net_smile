using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

using System.IO;

using FANNCSharp;
#if FANN_FIXED
using FANNCSharp.Fixed;
using DataType = System.Int32;
#elif FANN_DOUBLE
using FANNCSharp.Double;
using DataType = System.Double;
#else
using FANNCSharp.Float;
using DataType = System.Single;
#endif

namespace prSquare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NeuralNet net;
        float[] input;

        Pen p;
        bool isMouseDown;
        Point lastPoint;
        List<string> lstPic1 = new List<string>();
        Image resImg;
        Bitmap pic,bmp;
        StringBuilder sb;
         
        int k=10;
        int[] arr;

        private Image CompressImage(Image img)
        {
            Bitmap res = new Bitmap(10, 10);
            using (Graphics gr = Graphics.FromImage(res))
            {
                gr.DrawImage(img, 0, 0, res.Width, res.Height);
            }
            return res;
        }

        public void BasePic(Bitmap sourceBmp)
        {
            lstPic1.Clear();
            resImg = CompressImage(Image.FromHbitmap(sourceBmp.GetHbitmap()));
            picBig.Image = resImg;
            bmp = new Bitmap(resImg);
           
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color col = bmp.GetPixel(x, y);
                    if (col.R >= 150 && col.R <= 255 && col.G >= 150 && col.G <= 255 && col.B >= 150 && col.B <= 255)
                    {
                        lstPic1.Add(0.ToString());
                    }
                    else
                    {
                        lstPic1.Add(1.ToString());
                    }
                }
            }
        }
        public void outputToNote(List<string> lst,string a)
        {
            using (StreamWriter sw = new StreamWriter("test.data", true))
            {
                string str = "";
                foreach (string s in lst)
                {
                    str += s + " ";
                }
                sw.WriteLine(str+"\n"+a);
            }
        }
        private void train(int[] m)
        {
            using (TrainingData data = new TrainingData())
            {
                if (File.Exists("test_float.net"))
                {
                    label1.Text = "connect yes";
                    net = new NeuralNet("test_float.net");
                    input = new float[100];
                    for (int i = 0; i < 100; i++)
                        input[i] = m[i];
                    float[] calc_out = net.Run(input);
                    label1.Text += "\n sad=" + calc_out[0].ToString();
                    label1.Text += "\n smile=" + calc_out[1].ToString();
                    if (calc_out[0] > calc_out[1]) label2.Text = "Грустный смайлик";
                    else label2.Text = "Весёлый смайлик";
                }
            }
        }
        private void btnStudy_Click(object sender, EventArgs e)
        {
            uint num_input = 100;
            uint num_out = 2;
            uint num_hidden = 101;
            uint num_layar = 3;
            float num_error = 0.001f;
            uint max_epochs = 50000;
            uint epochs_between = 1000;

            net = new NeuralNet(NetworkType.LAYER, num_layar, num_input, num_hidden, num_out);
            using (net)
            {
                net.ActivationFunctionHidden = ActivationFunction.SIGMOID_SYMMETRIC;
                net.ActivationFunctionOutput = ActivationFunction.SIGMOID_SYMMETRIC;

                net.TrainOnFile("test.data", max_epochs, epochs_between, num_error);
                net.Save("test_float.net");
            }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            BasePic((Bitmap)picDraw.Image);
            arr = new int[100];
            for (int i = 0; i < lstPic1.Count(); i++)
            {
                arr[i] = Convert.ToInt32(lstPic1[i]);
            }
            train(arr);
        }
        
        private void btnTrFun_Click(object sender, EventArgs e)
        {
            replaceLine();
            outputToNote(lstPic1, "0 1");
        }
        private void btnTrSad_Click(object sender, EventArgs e)
        {
            replaceLine();
            outputToNote(lstPic1, "1 0");
        }
        public void replaceLine() 
        {
            string[] lines = File.ReadAllLines("test.data");
            k++;
                sb = new StringBuilder(lines[0]);
                sb.Remove(0, 2);
                sb.Insert(0, k);
                lines[0] = sb.ToString();

            File.WriteAllText("test.data", string.Empty);
            File.WriteAllLines("test.data",lines);

            sb =null;
        }
        private void picDraw_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            lastPoint = Point.Empty;
        }

        private void picDraw_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = e.Location;
            isMouseDown = true;
        }

        private void picDraw_MouseMove(object sender, MouseEventArgs e)
        {
            p = new Pen(Color.Black, 30f);
            p.EndCap = LineCap.Round;
            p.StartCap = LineCap.Round;

            if (isMouseDown == true)
            {
                if (lastPoint != null)
                {
                    if (picDraw.Image == null)
                    {
                        pic = new Bitmap(picDraw.Width, picDraw.Height);
                        picDraw.Image = pic;
                    }

                    using (Graphics g = Graphics.FromImage(pic))
                    {
                        g.DrawLine(p, lastPoint, e.Location);
                    }

                    picDraw.Invalidate();
                    lastPoint = e.Location;

                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] lin = File.ReadAllLines("test2.data");
            File.WriteAllText("test.data", string.Empty);
            File.WriteAllLines("test.data", lin);
        }

        private void cmb_TextChanged(object sender, EventArgs e)
        {
            clean_pic();
            picDraw.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(cmb.Text);
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            clean_pic();
        }
        public void clean_pic() 
        {
            if (picDraw.Image != null)
            {
                picDraw.Image = null;
                Invalidate();
            }
            input = null;
            lstPic1.Clear();
            arr = null;
            resImg = null;
            label2.Text = "";
            
        }
    }
}
