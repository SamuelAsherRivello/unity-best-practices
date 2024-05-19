
namespace RMC.BestPractices.DesignPatterns.StructuralPatterns.Strategy
{
	/// <summary>
	/// TODO: Add comment
	/// </summary>
	public class SubtractionMathQuizCreator : IMathQuizCreator 
	{
		public string CreateQuizTitle ()
		{
			return "Subtraction Quiz";
		}
		
		public string CreateQuiz ()
		{
			return "What is 9 - 1?";
		}
	}
}