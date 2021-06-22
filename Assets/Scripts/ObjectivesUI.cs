using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // allow us to easily access TextMeshPro

public class ObjectivesUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI ObjectivesText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnChangeObjectivesText()
    {
        ObjectivesText.text = "<i>Text</i> has been <b>changed</b>";
    }
}
