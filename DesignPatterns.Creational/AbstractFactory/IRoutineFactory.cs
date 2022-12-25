namespace DesignPatterns.Creational.AbstractFactory;

public interface IRoutineFactory
{
    IMenu CreateDailyMenu();
    IWorkout CreateDailyWorkout();
}