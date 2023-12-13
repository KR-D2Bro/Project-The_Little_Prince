using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skybox : MonoBehaviour
{
    public Material[] skybox; 
    public GameObject questManager;
    QuestManager qm;

    public Light targetLight;
    // Start is called before the first frame update
    void Start()
    {
        RenderSettings.skybox=skybox[0];
        qm=questManager.GetComponent<QuestManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(qm.IsNight){
            RenderSettings.skybox=skybox[1];
            targetLight.intensity=0.3f;
        }
    }
}
