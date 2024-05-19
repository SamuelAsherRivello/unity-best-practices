
namespace RMC.BestPractices.DesignPatterns.StructuralPatterns.Strategy
{
	/// <summary>
	/// TODO: Add comment
	/// </summary>
	public class AdditionMathQuizCreator : IMathQuizCreator 
	{
		public string CreateQuizTitle ()
		{
			return "Addition Quiz";
		}
		
		public string CreateQuiz ()
		{
			return "What is 10 + 10?";
		}
	}
}