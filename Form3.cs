using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // قراءة الأرقام المدخلة من مربع النص الأول والثاني
                double num1 = Convert.ToDouble(textBox1.Text);
                double num2 = Convert.ToDouble(textBox2.Text);
                double result = 0;

                // التحقق من زر الراديو المفعل لتحديد العملية الحسابية
                if (radioButton1.Checked) // الجمع
                {
                    result = num1 + num2;
                }
                else if (radioButton2.Checked) // الطرح
                {
                    result = num1 - num2;
                }
                else if (radioButton3.Checked) // الضرب
                {
                    result = num1 * num2;
                }
                else if (radioButton4.Checked) // القسمة
                {
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        MessageBox.Show("لا يمكن القسمة على الصفر!");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("الرجاء اختيار عملية حسابية أولاً.");
                    return;
                }

                // عرض النتيجة في مربع النص الخاص بالناتج
                textBox3.Text = result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("الرجاء إدخال أرقام صحيحة في الخانات المخصصة.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // تفريغ مربعات النص
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            // إلغاء تحديد خيارات العمليات
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;

            // إعادة التركيز إلى خانة العدد الأول
            textBox1.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
