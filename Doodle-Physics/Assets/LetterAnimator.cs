using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Reference: https://www.youtube.com/watch?time_continue=250&v=JubT4ldOwZQ&feature=emb_logo

public class LetterAnimator : MonoBehaviour
{
     List<Animator> myAnimators;
    // Start is called before the first frame update
    void Start()
    {
          //Gets all of the animators for each loading character
          GameObject letters = GameObject.Find("TextAnimationContainer");
          myAnimators = new List<Animator>(letters.GetComponentsInChildren<Animator>());

          StartCoroutine(DoTheAnimation());
    }

     IEnumerator DoTheAnimation()
     {
          //Animates each letter .15s apart then pauses for a half second
          while (true)
          {
               foreach(var letter in myAnimators)
               {
                    letter.SetTrigger("DoAnimation");
                    yield return new WaitForSeconds(.15f);
               }
               yield return new WaitForSeconds(.5f);
          }
     }

    // Update is called once per frame
    void Update()
    {
        
    }
}
