using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;
public class LoadingImage : MonoBehaviour
{
    public static string fileName;
    Texture2D loadedImageTexture;
    // Start is called before the first frame update
    void Start()
    {
        fileName = CapturePhoto.fileName;
        byte[] readImage = null;
        readImage = File.ReadAllBytes(Application.persistentDataPath + "/" + fileName + ".png");

        loadedImageTexture = new Texture2D(300, 200, TextureFormat.RGB24, false);
        loadedImageTexture.LoadImage(readImage);
        GameObject newImage = GameObject.Find("Background");     //newImage is the backGround from webcam now
        newImage.GetComponent<RawImage>().texture = loadedImageTexture;    //Sets

    }


    // Update is called once per frame

    void Update()
    {
        
    }
}
