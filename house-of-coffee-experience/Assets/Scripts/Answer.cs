using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Answer : MonoBehaviour
{
    //public bool isCorrect = false;
    public SurveyManager m_SurveyManager;

    public void GetAnswer()
    {
        m_SurveyManager.NextQuestion();
      
    }
}
