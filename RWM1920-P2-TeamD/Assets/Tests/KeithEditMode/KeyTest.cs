﻿using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class KeyTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void KeyTestSimplePasses()
        {
            // Use the Assert class to test conditions
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator CheckCollectedIsFalseOnStart()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.

            Key key = new Key();

            bool collected = key.Collected;

            Assert.AreEqual(collected, false);

            yield return null;
        }
        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator CheckSpeedIs5()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.

            Key key = new Key();

            int speed = key.speed;

            Assert.AreEqual(speed, 5);

            yield return null;
        }
    }
}
