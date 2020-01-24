using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class LifeControllerTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void LifeControllerTestSimplePasses()
        {
            // Use the Assert class to test conditions
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator CheckStartingLifeIs5()
        {
            int health = LifeControllerScript.health;
            Assert.AreEqual(health, 5);

            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator CheckStartingTimeIs20()
        {
            float time = LifeControllerScript.timeLeft;
            Assert.AreEqual(time, 20);

            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator CheckStartingScore()
        {
            int score = PlayerPrefs.GetInt("Score");
            Assert.AreEqual(score, 0);

            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
