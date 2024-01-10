using UnityEngine;

namespace Movement {
    [RequireComponent(typeof(Rigidbody2D))]
    public class BaseMovement : MonoBehaviour {
        [field: SerializeField] public Rigidbody2D RigidBody { get; protected set; }
        public bool IsMoving { get; private set; }

        public Vector2 Direction { get; private set; }

        public void SetDirection(Vector2 direction) {
            Direction = direction;
        }
        public virtual void Move(Vector2 direction) {

        }
        public virtual void Move() {

        }
        public void CacheChildren() {
            RigidBody ??= GetComponent<Rigidbody2D>();
        }
    }
}