// Load an assetbundle which contains Scenes.
// When the user clicks a button the first Scene in the assetbundle is
// loaded and replaces the current Scene.

using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    private AssetBundle myLoadedAssetBundle;
    private string[] scenePaths;

    // Use this for initialization
    void Start()
    {
        myLoadedAssetBundle = AssetBundle.LoadFromFile("Assets/Scenes");
        scenePaths = myLoadedAssetBundle.GetAllScenePaths();
    }

    //void ontriggerenter(collider other)
    //{
    //    if (other.gameobject.tag == "sepiroth")
    //    {
    //        debug.log("game over!");
    //        debug.log("scene2 loading: " + scenepaths[0]);
    //        scenemanager.loadscene(scenepaths[0], loadscenemode.single);
    //    }
    //}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Sepiroth")
        {
            Debug.Log("Game Over!");
            Debug.Log("Scene2 loading: " + scenePaths[0]);
            SceneManager.LoadScene(scenePaths[0], LoadSceneMode.Single);
        }
    }

    

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
    }

}
