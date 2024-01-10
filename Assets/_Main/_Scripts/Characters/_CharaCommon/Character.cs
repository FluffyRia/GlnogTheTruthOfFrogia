using UnityEngine;
using Movement;
namespace Characters {
    public class Character : MonoBehaviour, IMovable {
        [field: SerializeField] public BaseMovement Movement { get; set; }
        public bool IsMoving => Movement ? Movement.IsMoving : false;

        protected virtual void CacheChildren() {
            this.Movement = GetComponent<BaseMovement>();
            this.Movement.CacheChildren();
        }

    }
}