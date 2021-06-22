using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class InputControlsUI : MonoBehaviour
{
    [SerializeField] Toggle DemoToggle;
    [SerializeField] Slider DemoSlider;
    [SerializeField] TMP_InputField DemoInputField;

    // Start is called before the first frame update
    void Start()
    {
        // untick the toggle but DO NOT run the on value changed event
        DemoToggle.SetIsOnWithoutNotify(false);

        // randomise the slider value
        DemoSlider.SetValueWithoutNotify(Random.Range(DemoSlider.minValue, DemoSlider.maxValue));

        // set the input text
        DemoInputField.SetTextWithoutNotify(DemoSlider.value.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnDemoToggleChanged(bool newValue)
    {
        Debug.Log("Toggle is now " + newValue);
    }

    public void OnDemoSliderChanged(float newValue)
    {
        Debug.Log("Slider is now " + newValue);
    }

    public void OnDemoInputFieldChanged(string newValue)
    {
        Debug.Log("Input Field is now " + newValue);
    }
}
