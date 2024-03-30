using UnityEngine;

public class Creatures : MonoBehaviour
{
    [SerializeField] private float speed;

    private Rigidbody2D _rigidbody;
    private Vector2 _direction;
    
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    public void SetDirection(Vector2 direction)
    {
        _direction = direction;
    }

    private void FixedUpdate()
    {
        var velocity = _direction * speed * Run();
        _rigidbody.velocity = velocity;
    }

    protected virtual float Run()
    {
        return 1f;
    }
}
