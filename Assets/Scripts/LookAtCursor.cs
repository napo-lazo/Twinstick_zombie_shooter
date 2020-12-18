using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCursor : MonoBehaviour {

    Vector3 mousePos;

    void Update() {
        mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        transform.up = new Vector2(
                                    mousePos.x - transform.position.x,
                                    mousePos.y - transform.position.y
                                   );

    }
}
