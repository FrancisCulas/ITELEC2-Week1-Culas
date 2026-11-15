
namespace Week2_Prototype;

public class ChildNutritionRecord
{
    public string ChildName { get; private set; }
    public int AgeInMonths { get; private set; }
    public double WeightKg { get; private set; }
    public double HeightCm { get; private set; }

    public ChildNutritionRecord(
        string childName,
        int ageInMonths,
        double weightKg,
        double heightCm)
    {
        if (string.IsNullOrWhiteSpace(childName))
            throw new ArgumentException("Child name cannot be empty.");

        if (ageInMonths < 0)
            throw new ArgumentException("Age cannot be negative.");

        if (weightKg <= 0 || heightCm <= 0)
            throw new ArgumentException(
                "Weight and height must be greater than zero.");

        ChildName = childName;
        AgeInMonths = ageInMonths;
        WeightKg = weightKg;
        HeightCm = heightCm;
    }

    public bool UpdateMeasurements(
        double newWeightKg,
        double newHeightCm)
    {
        if (newWeightKg <= 0 || newHeightCm <= 0)
            return false;

        WeightKg = newWeightKg;
        HeightCm = newHeightCm;

        return true;
    }

    public void DisplayRecord()
    {
        Console.WriteLine($"Child: {ChildName}");
        Console.WriteLine($"Age: {AgeInMonths} months");
        Console.WriteLine($"Weight: {WeightKg:F2} kg");
        Console.WriteLine($"Height: {HeightCm:F2} cm");
    }
}
