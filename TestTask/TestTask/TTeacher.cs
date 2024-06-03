using System;

class TTeacher : Person, IEmployee
{
    //--.
    String sJobTitle;
    uint uExperience;

    public TTeacher(String surname, String dateofbirth, String subdivision, String jobtitle, uint experience)
    {
        //--.
        base.sPersonType = "Преподаватель";
        //--.
        base.sSurnamePerson = surname;
        //--.
        base.sDateOfBirth = dateofbirth;
        //--.
        sSubDivision = subdivision;
        //--. должность
        this.sJobTitle = jobtitle;
        //--. стаж работы
        this.uExperience = experience;
    }

    //--. метод "расчёта заработной платы сотрудника"
    public override void funcPayrolPreporation()
    {
        Console.WriteLine("Расчёт заработной платы Преподавателя... ");
    }

    //--. метод "расчёта возраста и стажа сотрудника"
    public override void funcCalcAgeAndExperience()
    {
        Console.WriteLine("Расчёт возраста и стажа Преподавателя... ");
    }

    //--. метод "вывода информации о сотруднике"
    public override void ShowPersonInfo()
    {
        base.ShowPersonInfo();
        Console.WriteLine(" , должность: {0}, стаж работы: {1} год", sJobTitle, uExperience);
    }

    public void setCitizen(String citizen)
    {
        base.sCitizen = citizen;
    }

}