using NUnit.Framework;
using System.Collections;
using UnityEngine;
using UnityEngine.TestTools;

namespace RMC.BestPractices.Features.UnitTesting.Calculator_02Complete
{
    /// <summary>
    /// The Unity Test Runner tests your code in Edit mode and Play mode,
    /// as well as on target platforms such as Standalone, Android, or iOS.
    /// See https://docs.unity3d.com/Manual/PlaymodeTestFramework.html
    ///
    /// NOTE: This is an example of an PLAY MODE TEST.
    ///
    /// You can run Play Mode tests as a standalone in a Player or inside the
    /// Editor. Play Mode tests allow you to exercise your game code, as the
    /// tests run as coroutines if marked with the UnityTest attribute.
    /// 
    /// </summary>
    public class CalculatorDemoPlayModeTest
    {
        [UnityTest]
        public IEnumerator Add_10Plus5_Equals15()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Wait for new GameObject's Start() to complete
            yield return null;

            // Act
            float result = calculator.Add(10, 5);

            // Asset
            Assert.That(result, Is.EqualTo(15));
        }
        
        [UnityTest]
        public IEnumerator Subtract_9Minus4_Equals5()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Wait for new GameObject's Start() to complete
            yield return null;

            // Act
            float result = calculator.Subtract(9, 4);

            // Asset
            Assert.That(result, Is.EqualTo(5));
        }
    }
}