namespace DesignPatterns.Creational.AbstractFactory;

public sealed class WeekendRoutineFactory : IRoutineFactory
{
    public IMenu CreateDailyMenu()
    {
        return new WeekendMenu();
    }

    public IWorkout CreateDailyWorkout()
    {
        return new WeekendWorkout();
    }
}