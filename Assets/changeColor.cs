
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Image))]
public class changeColor : MonoBehaviour
{
    Image image;
    public void green()
    {
        image = GetComponent<Image>();
        image.color = new Color32(50, 205, 50, 255);
    }
    public void grey()
    {
        GetComponent<Image>().color = new Color32(168, 168, 168, 255);
    }
}
