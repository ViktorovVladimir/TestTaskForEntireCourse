using System;

class TManager : Person, IEmployee
{
    //--.
    String sJobTitle;
    uint uExperience;


    public TManager(String surname, String dateofbirth, String subdivision, String jobtitle)
    {
        //--.
        base.sPersonType = "Менеджер";
        //--.
        base.sSurnamePerson = surname;
        //--.
        base.sDateOfBirth = dateofbirth;
        //--.
        sSubDivision = subdivision;
        //--. должность
        this.sJobTitle = jobtitle;
    }

    //--. метод "расчёта заработной платы сотрудника"
    public override void funcPayrolPreporation()
    {
        Console.WriteLine("Расчёт заработной платы Менеджера... ");
    }

    //--. метод "расчёта возраста и стажа сотрудника"
    public override void funcCalcAgeAndExperience()
    {
        Console.WriteLine("Расчёт возраста и стажа Менеджера... ");
    }

    //--. метод "вывода информации о сотруднике"
    public override void ShowPersonInfo()
    {
        base.ShowPersonInfo();
        Console.WriteLine(" , должность: {0} ", sJobTitle);
    }

    public void setCitizen(String citizen)
    {
        base.sCitizen = citizen;
    }
}