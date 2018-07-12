using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace URLopener
{
    public partial class Form1 : Form
    {
        FileManager fileManager;
        URLmanager urlManager;

        public Form1()
        {
            InitializeComponent();
            fileManager = new FileManager();
            urlManager = new URLmanager();
            urlManager.addComboboxValues(comboBox1);
        }               

        private void Form1_Load(object sender, EventArgs e)
        {

        }        

        //открытие вписанных урл
        private void button1_Click(object sender, EventArgs e)
        {
            string URLstring = richTextBox1.Text;
            List<String> URLs = new List<string>(URLstring.Split('\n'));
            URLs.Remove("");
            urlManager.openURL(URLs, comboBox1.SelectedItem.ToString());            
            fileManager.writeToFile(@"lastUrls.txt", richTextBox1.Text, label3);
        }
        
        //чтение из файла последних открытых урл
        private void button3_Click(object sender, EventArgs e)
        {            
            richTextBox1.Text = fileManager.readFile(@"lastUrls.txt",label3);           
        }

        //Скрины стриниц
        private void button2_Click(object sender, EventArgs e)
        {
            string URLstring = richTextBox1.Text;
            List<String> URLs = new List<string>(URLstring.Split('\n'));
            URLs.Remove("");
            urlManager.screenURL(URLs);
            fileManager.writeToFile(@"lastScreenedUrls.txt", richTextBox1.Text, label3);
        }

        //чтение из файла последних скриненых урл
        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = fileManager.readFile(@"lastScreenedUrls.txt", label3);
        }
    }
}
