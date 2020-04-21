/* ===================================
 * 当前项目：二维码生成解析工具
 * 功能描述：Form1  
 * 创 建 者：hackgsl
 * 创建日期：2020-04-15 21:47:25
 * CLR Ver ：4.0.30319.42000
 * =================================*/
using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ThoughtWorks.QRCode.Codec;
using ThoughtWorks.QRCode.Codec.Data;

namespace 二维码生成解析工具
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked)
                {
                    Regex re = new Regex(@"\r\n");//分割回车符
                    string[] method = re.Split(textBox1.Text);
                    foreach (var i in method)
                    //for (int i = 0; i < method.GetLength(0); i++)
                    {
                        DateTime time = DateTime.Now;
                        QRCodeSave(i, time.ToString("yyyy-MM-dd_HHmmss.ffff")+".png");
                    }
                    MessageBox.Show($"保存成功，总数：{method.Length}\n保存路径为当前程序同目录QRCodeimage文件夹。", "批量生成二维码");
                }
                else
                {
                    Image img = QRCodeBimapForString(textBox1.Text);
                    if (img != null)
                    {
                        this.pictureBox1.Image = img;
                    }
                }

            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "二维码生成失败");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                QRCodeSave(textBox1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("二维码保存失败，请检测生成的链接格式是否正常！", "保存状态");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog
                {
                    Multiselect = true,
                    Title = "请选择二维码图片",
                    Filter = "图像文件(*.jpg;*.jpeg;*.jpeg;*.gif;*.png;*.bmp)|*.jpg;*.jpeg;*.gif;*.png;*.bmp"
                };

                if (dialog.ShowDialog() != DialogResult.OK) return;
                var fileName = dialog.FileName;

                textBox1.Text = DeCode(fileName);

            }
            catch (Exception ex3)
            {
                MessageBox.Show(ex3.Message, "二维码识别失败");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Clipboard.ContainsImage()) return;//判断剪切板中是否复制了图片
                var imgClip = Clipboard.GetImage();

                pictureBox1.Image = imgClip;//粘贴图片
                if (imgClip == null) return;
                Bitmap map = new Bitmap(imgClip);
                textBox1.Text = new QRCodeDecoder().decode(new QRCodeBitmapImage(map));//解析二维码
            }
            catch (Exception ex4)
            {
                MessageBox.Show(ex4.Message, "解析失败");
                //throw;
            }
        }

        /// <summary>
        /// 生成二维码
        /// </summary>
        /// <param name="nr">生成二维码的字符串</param>
        /// <returns></returns>
        private Bitmap QRCodeBimapForString(string nr)
        {
            string enCodeString = nr;
            QRCodeEncoder qrCodeEncoder = new QRCodeEncoder
            {
                QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE,//编码方式(注意：BYTE能支持中文，ALPHA_NUMERIC扫描出来的都是数字)
                QRCodeScale = 8,//大小(值越大生成的二维码图片像素越高)
                QRCodeVersion = 0,//版本(注意：设置为0主要是防止编码的字符串太长时发生错误)
                QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M//错误效验、错误更正(有4个等级)
            };
            return qrCodeEncoder.Encode(enCodeString, Encoding.UTF8);
        }

        /// <summary>
        /// 保存二维码
        /// </summary>
        /// <param name="nr">生成二维码的字符串</param>
        /// <param name="fileName">文件名</param>
        /// <returns></returns>
        private Image QRCodeSave(string nr, string fileName)
        {
            Bitmap bt = QRCodeBimapForString(nr);
            Image img = bt;
            string filePath = "./QRCodeimage/";//这里默认文件夹在当前目录下，可以自己修改为自定义文件夹

            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }

            string path = Path.Combine(filePath, fileName);
            bt.Save(path);
            
            //如果要显示图片就要有返回值
            return img;

        }

        private void QRCodeSave(string nr)
        {
            Bitmap bt = QRCodeBimapForString(nr);
            Image img = bt;
            DateTime time = DateTime.Now;
            string filePath = "./QRCodeimage/";//这里默认文件夹在当前目录下，可以自己修改为自定义文件夹
            string fileName = time.ToString("yyyy-MM-dd HHmmss.ffff") + ".png";

            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }

            string path = Path.Combine(filePath, fileName);
            bt.Save(path);
            MessageBox.Show("保存成功，文件名：" + fileName + "\n保存路径为当前程序同目录QRCodeimage文件夹。", "保存二维码图片");

        }

        /// <summary>
        /// 解析二维码
        /// </summary>
        /// <param name="AbsoluteQRCodePath">二维码的绝对路径</param>
        /// <returns></returns>
        private static string DeCode(string AbsoluteQRCodePath)
        {
            string decodedString = new QRCodeDecoder().decode(new QRCodeBitmapImage(new Bitmap(AbsoluteQRCodePath)), Encoding.UTF8);
            return decodedString;
        }

    }
}
