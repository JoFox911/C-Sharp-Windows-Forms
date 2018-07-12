using System;
using System.Windows.Forms;

namespace ITEnterpriseTest
{
    public partial class Form1 : Form
    {
        QueryСollector queryCollector;//класс для сборки запроса
        DBManager dbManager;//класс для работы с БД

        public Form1()
        {
            //Инициализируем компоненты формы 
            InitializeComponent();
            //Создаем менеджер базы даных
            dbManager = new DBManager();
            //Подключаемся к БД
            dbManager.createConnection();
            //Создаем екземпляр класса для сборки запроса
            queryCollector = new QueryСollector();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Заносим начальные значения
            newDataToGrid();
        }       

        //внесение новых значений в грид
        private void newDataToGrid()
        {
            dataGridView1.ReadOnly = true;
            //вносим в грид значения полученные из результата запроса
            try
            {
                dataGridView1.DataSource = dbManager.getQueryResult(queryCollector.getQuery()).Tables[0];
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e);
            }
        }

        //Действия по нажатию кнопти сброса выборки
        private void button2_Click(object sender, EventArgs e)
        {
            //Все столбцы в гриде делаем видимыми
            for (int i = 0; i < dataGridView1.ColumnCount; i++) {
                dataGridView1.Columns[i].Visible = true;
            }
            //У всех чекбоксов сбразываем галочки
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            //Удаляем сформированный запрос
            queryCollector.clearQuery();
            //Обновляем значения в грид
            newDataToGrid();
        }

        //Проверка стоит ли галочка у чекбокса
        private void isChecked(System.Windows.Forms.CheckBox checkBox, int number)
        {
            //Если галочка стоит
            if (checkBox.Checked)
            {
                //выбраный столбец делаем видимым
                dataGridView1.Columns[number].Visible = true;
                //Добавляем значение чекбокса в запрос
                queryCollector.addCheckBoxValue(checkBox.Text, number);
            }
            //Если нет галочки
            else
            {
                //делаем столбец невидимым
                dataGridView1.Columns[number].Visible = false;
            }
        }

        //Действия по нажатию на кнопку подтверждения
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].Visible = false;
            //Проверяем все чекбоксы на наличие галочек
            isChecked(checkBox1, 1);
            isChecked(checkBox2, 2);
            isChecked(checkBox3, 3);
            isChecked(checkBox4, 4);
            isChecked(checkBox5, 5);
            isChecked(checkBox6, 6);
            isChecked(checkBox7, 7);
            //Формирование запроса
            queryCollector.createQuery();
            //несение 
            newDataToGrid();
            //очистка запроса
            queryCollector.clearQuery();
        }
              
    }
}
