using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;


public class GregTestSuite
{

    [UnityTest]
    public IEnumerator ObjectRotate()
    {

        //SceneManager.LoadScene(13);
        GameObject gameGameObject =
   MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/GravBox"));
        GravityInvert grav = gameGameObject.GetComponent<GravityInvert>();
        GameObject box = grav.spawnSelf();
        //MonoBehaviour.Instantiate(path: "Prefabs/GravBox.prefab", new Vector3(0, 0, 0), Quaternion.identity);


        float zRot = box.transform.rotation.eulerAngles.z;
        gameGameObject.GetComponent<RotateObj>().rotate();

        Assert.AreNotEqual(zRot, gameGameObject.gameObject.transform.rotation.eulerAngles.z);
        Object.Destroy(gameGameObject);
        yield return null;
    }
}
      
    

