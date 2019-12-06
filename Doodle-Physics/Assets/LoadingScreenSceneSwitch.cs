using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingScreenSceneSwitch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
          StartCoroutine(LoadGamePlayScene());
    }

     IEnumerator LoadGamePlayScene()
     {
          AsyncOperation async = SceneManager.LoadSceneAsync("load_photo");
          yield return new WaitForEndOfFrame();

          //while(!async.isDone)
          //{
               //yield return new WaitForEndOfFrame();
          //}
     }
}
