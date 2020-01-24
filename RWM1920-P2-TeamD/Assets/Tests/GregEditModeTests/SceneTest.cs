using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

namespace Tests
{
    public class SceneTest
    {
        

        [UnityTest]
        public IEnumerator SceneTestWithEnumeratorPasses()
        {
            Scene scene = ReturnToMenu.getScene();
            Assert.IsNotNull(scene);
            yield return null;
        }
    }
}
