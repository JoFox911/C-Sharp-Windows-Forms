using System;
using System.IO;
using System.Windows.Forms;

namespace URLopener
{
    class FileManager
    {

        public string readFile(string path, Label label)
        {
            String errorText = "";
            String URLs = "";
            try
            {                
                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        URLs += line + "\n";
                    }
                }
                
            }
            catch (Exception ex)
            {
                errorText = "Не знайдено файл із останніми відкритими сторінками!";
            }
            label.Text = errorText;

            return URLs;
        }

        public void writeToFile(string path, String text, Label label)
        {
            String errorText = "";
            try
            {
                using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(text);
                }
            }
            catch (Exception ex)
            {
                errorText = "Запис останніх відкритих сторінок у файл не виконан!";
            }
            label.Text = errorText;
        }
    }
}
