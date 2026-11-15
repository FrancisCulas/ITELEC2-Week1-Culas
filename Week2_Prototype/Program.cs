using Week2_Prototype;

// Create two child nutrition records.
var child1 = new ChildNutritionRecord(
    "Ana Santos", 36, 12.5, 90.0);

var child2 = new ChildNutritionRecord(
    "Ben Cruz", 48, 15.2, 101.5);

// Display first child's record.
Console.WriteLine("=== CHILD 1 ===");
child1.DisplayRecord();

// Test 1: Valid update.
Console.WriteLine("\n=== TEST 1: VALID UPDATE ===");

bool validUpdate = child1.UpdateMeasurements(12.8, 91.0);

Console.WriteLine($"Update successful: {validUpdate}");
child1.DisplayRecord();

// Test 2: Invalid update.
Console.WriteLine("\n=== TEST 2: INVALID UPDATE ===");

bool invalidUpdate = child1.UpdateMeasurements(0, 92.0);

Console.WriteLine($"Update successful: {invalidUpdate}");
Console.WriteLine("Previous measurements are kept:");
child1.DisplayRecord();

// Display second child's record.
Console.WriteLine("\n=== CHILD 2 ===");
child2.DisplayRecord();

// Test 3: Update second object.
Console.WriteLine("\n=== TEST 3: SECOND OBJECT UPDATE ===");

bool secondUpdate = child2.UpdateMeasurements(15.5, 102.0);

Console.WriteLine($"Update successful: {secondUpdate}");
child2.DisplayRecord();

