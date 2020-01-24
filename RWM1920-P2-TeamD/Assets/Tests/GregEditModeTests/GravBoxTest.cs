using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class GravBoxTest
    {
       
      
        [UnityTest]
        public IEnumerator GravBoxRotateWorks()
        {
            Vector3 testVec = new Vector3(0, 0, 5);
            Assert.AreNotEqual(testVec, RotateObj.Rotate(testVec));
            yield return null;
        }

        [UnityTest]
        public IEnumerator GravBoxLaunchWorks()
        {
            Vector3 testVec = new Vector3(0, 0, 5);
            Assert.AreNotEqual(testVec, GravityInvert.getVec(testVec));
            yield return null;
        }
    }
}
