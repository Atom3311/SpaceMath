using UnityEngine;

public class MoveBackground : MonoBehaviour
{
    [SerializeField] private SpriteRenderer sprite;
    [SerializeField] private float backgroundSpeed;

    private float posMinY;
    private Vector2 resPos;

    void Start() {
        resPos = transform.position;

        posMinY = sprite.bounds.size.y * 2 - resPos.y;
    }

    void Update() {
        transform.Translate(Vector3.down * backgroundSpeed * Time.deltaTime);

        if(transform.position.y <= -posMinY) {

            transform.position = resPos;
        }
    }
}
