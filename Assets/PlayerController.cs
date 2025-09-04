using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
  [SerializeField]
  float speed = 3f;

  [SerializeField]
  GameObject boltPrefab;

  Vector2 movement = Vector2.zero;

  void Update()
  {
    transform.Translate(movement * speed * Time.deltaTime);
  }

  void OnMove(InputValue value)
  {
    movement = value.Get<Vector2>();
  }

  void OnFire()
  {
    Instantiate(boltPrefab, transform.position, Quaternion.identity);
  }
}
