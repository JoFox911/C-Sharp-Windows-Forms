using System;

namespace ITEnterpriseTest
{
    class QueryСollector
    {
        private string listColumns;//список поле которые должен вернуть запрос
        private string group;//список полей по которым будет группировка
        private string query;//запрос
        private string basicQuery;//запрос по умолчанию, берущий все столбцы

        //конструктор по умолчанию
        public QueryСollector() {
            clearQuery();
            basicQuery = "select* from shipment";
        }

        //очистка полей класс
        public void clearQuery()
        {
            listColumns = "";
            group = "";
            query = "";
        }

        //получая значение чекбокса и его номер формируются строки 
        //listColumns и group для запроса
        public void addCheckBoxValue(String text,int number)
        {
            //если это не первое поле в списке полей, то необходимо добавить запятую
            if (listColumns != "")
                listColumns += ",";
            //Если это поля 6 и 7, то к ним нужно применить агрегатную функцию суммы
            if ((number == 6) || (number == 7))
            {
                listColumns += "SUM(" + text + ") as " + text;
            }
            else
            {//если это не поля над которыми проводится суммирование, 
                //то добавляем их в строку для группировки и в список полей для вывода
                if (group != "")
                    group += ",";
                group += text;
                listColumns += text;
            }
        }

        //формирование запроса по списку возвращаемых полей и списку группировки
        public void createQuery()
        {
            //если было выбрано хоть одно поле
            if (listColumns != "")
            {
                //формируем строку запроса
                query = "select " + listColumns + " from shipment";
                //если есть поля по которым групировать
                if (group != "") 
                {
                    //добавляем строку с группировкой
                    query += " group by " + group;
                }
            }            
        }        

        //Возвращение сформированного запроса
        public string getQuery()
        {
            if(query=="")
                return basicQuery;
            return query;
        }

    }
}
