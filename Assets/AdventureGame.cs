using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text textComponent;

    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = "Now that you're awake, welcome to Gadgetsville. What is Gadgetsville? Where is Gadgetsville? Don't worry about those questions. The only thing you need to know is you aren't leaving this room alive.";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
