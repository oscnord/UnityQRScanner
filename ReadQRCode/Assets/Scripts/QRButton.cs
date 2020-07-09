using UnityEngine;
/// <summary>
/// Click state of QRButton
/// </summary>
public class QRButton : MonoBehaviour
{
    public static bool clicked = false;
    void LateUpdate ()
    {
        clicked = false;
    }
    public void Click()
    {
        clicked = true;
    }
}