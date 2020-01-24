using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class BallTestScript
    {

        [UnityTest]
        public IEnumerator CheckBallYIsLessThanHeightOfScreen()
        {
            Vector2 checkPos = BallBoundaryDetection.getStartPos();
            Assert.That(checkPos.y, Is.LessThan(10.0f));
            Assert.That(checkPos.y, Is.GreaterThan(0.0f));
            yield return null;
        }

        [UnityTest]
        public IEnumerator CheckBallYIsGreaterThanZero()
        {
            Vector2 checkPos = BallBoundaryDetection.getStartPos();
            Assert.That(checkPos.y, Is.GreaterThan(0.0f));
            yield return null;
        }

        [UnityTest]
        public IEnumerator CheckBallIsAlive()
        {
            bool checkBall = BallBoundaryDetection.getAlive();
            Assert.IsTrue(checkBall);
            yield return null;
        }
    }
}
