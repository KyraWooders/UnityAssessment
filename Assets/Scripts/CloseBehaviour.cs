using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseBehaviour : MonoBehaviour
{
    /**
     * Once the button is clicked, the scene will close.
    **/
    public void CloseGame()
    {
        Application.Quit();
    }
}
