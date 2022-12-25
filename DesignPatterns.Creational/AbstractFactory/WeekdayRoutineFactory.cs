namespace DesignPatterns.Creational.AbstractFactory;

public sealed class WeekdayRoutineFactory : IRoutineFactory
{
    public IMenu CreateDailyMenu()
    {
        return new WeekdayMenu();
    }

    public IWorkout CreateDailyWorkout()
    {
        return new WeekdayWorkout();
    }
}