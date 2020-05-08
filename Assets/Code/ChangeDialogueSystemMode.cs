using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeDialogueSystemMode : MonoBehaviour
{
    [SerializeField]
    private int controlModeId;
    private EventManager eventManager;

    // Start is called before the first frame update
    void Start()
    {
        eventManager = GameObject.Find("Overlord").GetComponent<EventManager>();
        eventManager.ControlMode(controlModeId);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
