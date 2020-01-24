using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class pipeTests
    {
        [UnityTest]
        public IEnumerator checkAliveFalse()
        {
            bool check = MartinPipeScript.getAlive();
            Assert.IsTrue(check != true);
            yield return null;
        }

        [UnityTest]
        public IEnumerator checkedIfDistanceAfterTravellingThroughPipeIsCorrect()
        {
            Vector2 startingPos = new Vector2(0.0f, 0.0f);
            startingPos.y -= MartinPipeScript.getHeight();
            Assert.AreEqual(startingPos, new Vector2(0.0f, -0.9f));
            yield return null;
        }

        [UnityTest]
        public IEnumerator checkThatPipeHasNotBeenRotated()
        {
            float currentRotation = MartinPipeScript.getRotation();

            Assert.AreEqual(currentRotation, 0);
            yield return null;
        }
    }
}
