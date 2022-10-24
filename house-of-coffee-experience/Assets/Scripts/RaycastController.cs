using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastController : MonoBehaviour
{
    [SerializeField]
    public GameObject m_AboutUsCanvas;
    [SerializeField]
    public GameObject m_SurveyCanvas;
    [SerializeField]
    public GameObject m_SupremoCanvas;
    [SerializeField]
    public GameObject m_ArabicaCanvas;
    private string btnName; 

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit; 

            if (Physics.Raycast(ray, out hit))
            {
                btnName = hit.transform.tag;
                OnSelect(btnName);
            }

            
        }
    }

    private void OnSelect(string name)
    {
        switch (name)
        {
            case "Facebook":
                Application.OpenURL("https://www.facebook.com/HouseOfCoffeesZA/");
                break;
            case "Instagram":
                Application.OpenURL("https://www.instagram.com/houseofcoffeesza/?hl=en");
                break;
            case "AboutUs":
                m_AboutUsCanvas.SetActive(true);
                break;
            case "Survey":
                m_SurveyCanvas.SetActive(true);
                break;
            case "Supremo":
                m_SupremoCanvas.SetActive(true);
                break;
            case "Arabica":
                m_ArabicaCanvas.SetActive(true);
                break;
            default:
                break;


        }
    }
}
