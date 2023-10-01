using UnityEngine;

public class Player : MonoBehaviour
{
    private void Update()
    {
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;

        GetComponent<Rigidbody2D>().MovePosition(mousePos);
    }
}
