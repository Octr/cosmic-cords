using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonMenuSelect : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    bool Select;
    public string String_;

    private AudioSource buttonSound;
    private AudioSource buttonClickSound;
    private void Start()
    {
        String_ = GetComponent<TextMeshProUGUI>().text;
        buttonSound = GameObject.Find("blipButton").GetComponent<AudioSource>();
        buttonClickSound = GameObject.Find("clickButton").GetComponent<AudioSource>();
    }
    public void OnPointerClick(PointerEventData pointerEventData)
    {
        buttonClickSound.Play();
        Select = false;
    }
    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        buttonSound.Play();
        Select = true;
    }

    public void OnPointerExit(PointerEventData pointerEventData)
    {
        Select = false;
    }
    void Update()
    {

        if (Select)
        {
            GetComponent<TextMeshProUGUI>().text = "> "+ String_;
        }
        else
        {
            GetComponent<TextMeshProUGUI>().text = "  " + String_;
        }
    }
}
