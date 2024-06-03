using System;

class TAdmin : Person, IEmployee
{
    public TAdmin(String surname, String dateofbirth, String subdivision)
    {
        //--.
        base.sPersonType = "Администратор";
        //--.
        base.sSurnamePerson = surname;
        //--.
        base.sDateOfBirth = dateofbirth;
        //--.
        sSubDivision = subdivision;
    }

    //--. метод "расчёта заработной платы сотрудника"
    public override void funcPayrolPreporation()
    {
        Console.WriteLine("Расчёт заработной платы Администратора... ");
    }

    //--. метод "расчёта возраста и стажа сотрудника"
    public override void funcCalcAgeAndExperience()
    {
        Console.WriteLine("Расчёт возраста и стажа Администратора... ");
    }

    public void setCitizen(String citizen)
    {
        base.sCitizen = citizen;
    }


}