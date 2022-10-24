using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickClose : MonoBehaviour
{
   
    public void CloseUI(GameObject m_CanvasToClose)
    {
        m_CanvasToClose.SetActive(false);
    }
}
