using System;

public abstract class Beverage
{
    public void PrepareRecipe()
    {
        BoilWater();
        Brew();
        PourInCup();
        if (CustomerWantsCondiments())
        {
            AddCondiments();
        }
    }

    protected void BoilWater()
    {
        Console.WriteLine("Кипятим воду");
    }

    protected void PourInCup()
    {
        Console.WriteLine("Наливаем в чашку");
    }

    protected abstract void Brew();
    protected abstract void AddCondiments();

    protected virtual bool CustomerWantsCondiments()
    {
        return true;
    }
}
