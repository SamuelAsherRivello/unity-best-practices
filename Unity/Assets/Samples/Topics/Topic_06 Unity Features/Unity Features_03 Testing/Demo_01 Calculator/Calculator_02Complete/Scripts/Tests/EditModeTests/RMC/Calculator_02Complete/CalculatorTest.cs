using NUnit.Framework;

namespace RMC.BestPractices.Features.UnitTesting.Calculator_02Complete
{
    /// <summary>
    /// The Unity Test Runner tests your code in Edit mode and Play mode,
    /// as well as on target platforms such as Standalone, Android, or iOS.
    /// See https://docs.unity3d.com/Manual/PlaymodeTestFramework.html
    ///
    /// NOTE: This is an example of an EDIT MODE TEST.
    ///
    /// Edit Mode tests (also known as Editor tests) are only run in the
    /// Unity Editor and have access to the Editor code.
    /// 
    /// </summary>
    public class CalculatorTest
    {
        [Test]
        public void Add_10Plus5_Equals15()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            float result = calculator.Add(10, 5);

            // Asset
            Assert.That(result, Is.EqualTo(15));
        }
        
        [Test]
        public void Subtract_9Minus4_Equals5()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            float result = calculator.Subtract(9, 4);

            // Asset
            Assert.That(result, Is.EqualTo(5));
        }

        /*
        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator CalculatorTestWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
        */
    }
}
