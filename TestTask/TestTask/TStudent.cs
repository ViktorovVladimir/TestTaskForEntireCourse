using System;

class TStudent : Person, IEmployee
{
    //--.
    uint uGroupNumber;

    public TStudent(String surname, String dateofbirth, String subdivision, uint groupnumber)
    {
        //--.
        base.sPersonType = "Студент";
        //--.
        base.sSurnamePerson = surname;
        //--.
        base.sDateOfBirth = dateofbirth;
        //--.
        sSubDivision = subdivision;
        //--.
        this.uGroupNumber = groupnumber;
    }

    //--. метод "расчёта заработной платы сотрудника"
    public override void funcPayrolPreporation()
    {
        Console.WriteLine("Расчёт степендии Студента... ");
    }

    //--. метод "расчёта возраста и стажа сотрудника"
    public override void funcCalcAgeAndExperience()
    {
        Console.WriteLine("Расчёт возраста и года обучения Студента... ");
    }

    //--. метод "вывода информации о сотруднике"
    public override void ShowPersonInfo()
    {
        base.ShowPersonInfo();
        Console.WriteLine(" , номер группы: {0} ", uGroupNumber );
    }
    
    //--.
    public void setCitizen(String citizen)
    {
        base.sCitizen = citizen;
    }
}