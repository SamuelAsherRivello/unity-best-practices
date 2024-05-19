
namespace RMC.BestPractices.DesignPatterns.StructuralPatterns.Strategy
{
	/// <summary>
	/// TODO: Add comment
	/// </summary>
	public class MathQuizCreatorContext 
	{
		private readonly IMathQuizCreator _mathQuizCreator;
		
		public MathQuizCreatorContext(IMathQuizCreator mathQuizCreator)
		{
			_mathQuizCreator = mathQuizCreator;
		}
		
		public string CreateQuizTitle ()
		{
			return _mathQuizCreator.CreateQuizTitle();
		}
		
		public string CreateQuiz ()
		{
			return _mathQuizCreator.CreateQuiz();
		}
	}
}