using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class SceneLoad4 : MonoBehaviour
{
    public Slider progressbar;
    public TextMeshProUGUI loadtext;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadScene());
    }
    IEnumerator LoadScene()
    {
      yield return null;
      AsyncOperation operation = SceneManager.LoadSceneAsync("Drunk Planet");
      operation.allowSceneActivation = false;

      while (!operation.isDone)
      {
        yield return null;
        if(progressbar.value < 0.9f)
        {
          progressbar.value = Mathf.MoveTowards(progressbar.value, 0.9f, Time.deltaTime);
        }else if(operation.progress >= 0.9f)
        {
          progressbar.value = Mathf.MoveTowards(progressbar.value, 1.0f, Time.deltaTime);
        }
        
        if (progressbar.value >= 1f)
        {
          loadtext.text = "Press G to continue";
        }

        if (Input.GetKeyDown(KeyCode.G) && progressbar.value >= 1f && operation.progress >= 0.9f)
        {
          operation.allowSceneActivation = true;
        }
      }
    }
}
