using System.Transactions;

internal class Program
{
    private static void Main(string[] args)
    {
        Recipe recipe = new Recipe();
        while (true) 
        {
            Console.WriteLine("WELCOME TO THE KITCHEN!!!");
            Console.WriteLine("=========================================");
            Console.WriteLine("Enter 1 to enter recipe details : ");
            Console.WriteLine("Enter 2 to display Recipe : ");
            Console.WriteLine("Enter 3 to scale Recipe : ");
            Console.WriteLine("Enter 4 to reset Quantities : ");
            Console.WriteLine("Enter 5 to clear Recipes : ");
            Console.WriteLine("Enter 6 to exit : ");
            Console.WriteLine("=========================================");

            string ans = Console.ReadLine();
            switch (ans)
            {
                case "1":
                    recipe.InsertData();
                break;
                case "2":
                    recipe.RecipeDisplay();
                break;
                case "3":
                    Console.WriteLine("Enter a scale of 0.5,2 or 3");
                    double scale1 = Convert.ToDouble(Console.ReadLine());
                    recipe.Scale(scale1);
                break;
                case "4":
                    recipe.ResetRecipe();
                break;
                case "5":
                    recipe.Clear();
                break;
                case "6":
                    Environment.Exit(1);
                break;

                default:
                    Console.WriteLine("Wrong value. Please try again");
                break;
            }

        }
    }
}

class Recipe
{
    private String[] ingredient;
    private double[] number;
    private String[] unit;
    private String[] steps;

    public Recipe()
    {
        ingredient = new String[0];
        number = new double[0];  
        unit = new String[0];   
        steps = new String[0];  

    }
    public void InsertData()
    {
        Console.WriteLine("Enter the amount of ingredients : ");
        int ingAmount = Convert.ToInt32(Console.ReadLine());

        ingredient = new String[ingAmount];
        number = new double[ingAmount];
        unit = new String[ingAmount];

        for (int i = 0;i < ingAmount;i++) 
        {
            Console.WriteLine($"Enter ingredient details#{i+1} : ");
            Console.Write("Name : ");
            ingredient[i] = Console.ReadLine();
            Console.Write("Quantity : ");
            number[i] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Units of measurements : ");
            unit[i] = Console.ReadLine();

        }
        Console.WriteLine("Enter the amount of steps : ");
        int stepNum = Convert.ToInt32(Console.ReadLine());
        steps = new String[stepNum];

        for(int a = 0;a < stepNum;a++)
        {
            Console.Write($"Steps#{a + 1} : ");
            steps[a] = Console.ReadLine();
        }
    }

    public void RecipeDisplay()
    {
        Console.WriteLine("Ingredient :");
         for(int i = 0;i < ingredient.Length;i++) 
        {
            Console.WriteLine($"- {number[i]}{unit[i]} of {ingredient[i]}");

        }
        Console.WriteLine("Steps : ");
        for(int a = 0; a < steps.Length;a++)
        {
            Console.WriteLine($"-{steps[a]}");
        }
    }

    public void Scale(double scale)
    {
        for(int i = 0;i < number.Length;i++)
        {
            number[i]*=scale;
        
        }
    }

    public void ResetRecipe()
    {
        for(int i = 0;i < number.Length;i++)
        {
            number[i] /= 2;
        }
    }

    public void Clear()
    {
        ingredient = new String[0];
        number = new double[0];
        unit = new String[0];
        steps = new String[0];
    }


}