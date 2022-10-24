using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SurveyManager : MonoBehaviour
{
    public List<QuestionsAndAnswers> m_QnA;
    public GameObject[] m_Options;
    public int m_CurrentQuestion;
    public TextMeshProUGUI m_QuestionText;
    public GameObject m_FinishCanvas;
    public GameObject m_SurveyCanvas;
    

    private void Start()
    {
        GenerateQuestions();
    }

    public void NextQuestion()
    {
        m_QnA.RemoveAt(m_CurrentQuestion);
        GenerateQuestions();
    }

    public void SurveyOver()
    {
        m_SurveyCanvas.SetActive(false);
        m_FinishCanvas.SetActive(true);
    }

    void SetAnswers()
    {
        for (int i=0; i<m_Options.Length; i++)
        {
            //m_Options[i].GetComponent<Answer>().isCorrect = false;
            m_Options[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = m_QnA[m_CurrentQuestion].Answers[i];

            //if (m_QnA[m_CurrentQuestion].CorrectAnswer == i+1)
            //{
            //    m_Options[i].GetComponent<Answer>().isCorrect = true;
            //}
        }
    }

    void GenerateQuestions()
    {
        if (m_QnA.Count > 0)
        {
            m_CurrentQuestion = Random.Range(0, m_QnA.Count);

            m_QuestionText.text = m_QnA[m_CurrentQuestion].Question;

            SetAnswers();
        }
        else
        {
            SurveyOver();
        }
        

        
    }
}
