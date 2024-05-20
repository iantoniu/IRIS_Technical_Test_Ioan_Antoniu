using Balanced_Brackets;

var expressions = new List<string>
{
    "[()]{}{[()()]()}",
    "[()]{}{()()}",
    "[()][](){()()]}",
    "[(])"
};

foreach (var exp in expressions)
{
    Console.WriteLine($"Input: exp = \"{exp}\"");
    Console.WriteLine($"Output: {(BalancedBracketsChecker.AreBracketsBalanced(exp) ? "Balanced" : "Not Balanced")}");
}
