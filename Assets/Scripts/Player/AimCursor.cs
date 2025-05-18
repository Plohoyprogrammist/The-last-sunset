using UnityEngine;

public class AimCursor : MonoBehaviour
{
    public Camera cam;

    void Update()
    {
        Vector2 cursorAim = cam.ScreenToWorldPoint(Input.mousePosition);

        transform.position = cursorAim;
    }
}
