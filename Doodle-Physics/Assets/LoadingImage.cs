using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class LoadingImage : MonoBehaviour
{

     string fileName;
     public bool onLoaded = false;
     Texture2D loadedImageTexture;
     public Image img;
     Sprite img1;
     GameObject myImage;


     // Start is called before the first frame update
     void Start()
    {
          //byte[] readImage = null;
          //string filePath = Path.Combine(Application.persistentDataPath, )
          //readImage = File.ReadAllBytes(Application.persistentDataPath + "/" + fileName + ".png");

          //loadedImageTexture = new Texture2D(300, 200, TextureFormat.RGB24, false);
          //loadedImageTexture.LoadImage(readImage);
          //Sprite s = Sprite.Create(loadedImageTexture, new Rect(0, 0, Screen.width, Screen.height), Vector2.zero, 1f);
          //background.GetComponent<UnityEngine.UI.Image>().sprite = s;

          myImage.AddComponent(typeof(Image));
          img1 = Resources.Load<Sprite>(Application.persistentDataPath + "/" + "2019-11-02_22-04-18.png");
          myImage.GetComponent<Image>().sprite = img1;

     }

    // Update is called once per frame
    void Update()
    {
        
    }
}
