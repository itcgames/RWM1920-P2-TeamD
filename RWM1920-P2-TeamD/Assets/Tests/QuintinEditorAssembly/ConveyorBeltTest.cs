using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class ConveyorBeltTest
    {
        [UnityTest]
        public IEnumerator ConveyorBeltTest1()
        {
            float degreesPreSec = 90;
            float time = 0.1f;
            float currentAngle = 0.0f;
            Vector3 desiredResult = new Vector3(0.0f, 0.0f, 9.0f);

            Quaternion resultQ = Rotate.NewRotation(degreesPreSec, time, currentAngle);
            Vector3 result = new Vector3(roundOff(resultQ.eulerAngles.x), roundOff(resultQ.eulerAngles.y), roundOff(resultQ.eulerAngles.z));
            Assert.AreEqual(result, desiredResult);
            yield return null;
        }
        [UnityTest]
        public IEnumerator ConveyorBeltTest2()
        {
            float degreesPreSec = 78;
            float time = 2.7f;
            float currentAngle = 259.0f;
            Vector3 desiredResult = new Vector3(0.0f, 0.0f, 109.6f);

            Quaternion resultQ = Rotate.NewRotation(degreesPreSec, time, currentAngle);
            Vector3 result = new Vector3(roundOff(resultQ.eulerAngles.x), roundOff(resultQ.eulerAngles.y), roundOff(resultQ.eulerAngles.z));
            Assert.AreEqual(result, desiredResult);
            yield return null;
        }
        public float roundOff(float t_change)
        {
            return (Mathf.Round(t_change * 100.0f)) / 100.0f;
        }
    }
}
