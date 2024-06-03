using System;
using System.Collections.Generic;

class Test
    {
        //--.
        static void Main()
        {   
            //--.
            Person personObj;
            List<Person> array = new List<Person>();    
        

            //--. 1. Администратор
            //--. Инициализация
            TAdmin admin = new TAdmin(  "Иванов", "25.05.1987", "лаборатория N1"  );
            //--. методы
            admin.setCitizen("русский");
            admin.ShowPersonInfo();
            admin.funcPayrolPreporation();
            admin.funcCalcAgeAndExperience();
            array.Add( admin );

            //--. 2. Студент
            //--. Инициализация
            TStudent student = new TStudent( "Сидоров", "10.01.2015", "факультет N1", 601 );
            //--. методы
            student.setCitizen("русский");
            student.ShowPersonInfo();
            student.funcPayrolPreporation();
            student.funcCalcAgeAndExperience();
            array.Add(student);


            //--. 3. Преподаватель
            //--. Инициализация
            TTeacher teacher = new TTeacher( "Винокуров", "11.02.2067", "факультет N1", "старший преподаватель", 21);
            //--. методы
            teacher.setCitizen("русский");
            teacher.ShowPersonInfo();
            teacher.funcPayrolPreporation();
            teacher.funcCalcAgeAndExperience();
            array.Add(teacher);


            //--. 4. Менеджер
            //--. Инициализация
            TManager manager = new TManager("Нейман", "18.09.2007", "факультет N1", "старший менеджер");
            //--. методы
            manager.setCitizen("русский");
            manager.ShowPersonInfo();
            manager.funcPayrolPreporation();
            manager.funcCalcAgeAndExperience();
            array.Add(manager);

            Console.WriteLine("\n---------------------------------------------------------\n");
            //--.
            foreach(Person a in array )
            {
                a.ShowPersonInfo();
            }



        /*
        //--. Интерфейс поворота    
        sqr.IAngle = 45;
        sqr.RotationOperations();
        */
    }

}
