using System;


    abstract class Person 
    {
        //--. Тип сущности
        protected String sPersonType;
        //--. Фамилия работника
        protected String sSurnamePerson;
        //--. Дата рождения работника 
        protected String sDateOfBirth;
        //--. Подразделение: лаборатория, факультет, т.д.
        protected String sSubDivision;
        //--. гражданство
        protected String sCitizen;


        //--.
        public Person()
        {
            sPersonType = "";
            sSurnamePerson = "";
            sDateOfBirth = "";
            sSubDivision = "";
        }
        

        //--. метод "расчёта заработной платы сотрудника"
        abstract public void funcPayrolPreporation();
        
        //--. метод "расчёта возраста и стажа сотрудника"
        abstract public void funcCalcAgeAndExperience();
        
        //--. метод "вывода информации о сотруднике"
        public virtual void ShowPersonInfo()
        {
            Console.WriteLine("\n{0}: \nФамилия : {1}, дата рождения: {2}, гражданство: {3}, подразделение: {4} ", sPersonType, sSurnamePerson, sDateOfBirth, sCitizen, sSubDivision);
        }
}
