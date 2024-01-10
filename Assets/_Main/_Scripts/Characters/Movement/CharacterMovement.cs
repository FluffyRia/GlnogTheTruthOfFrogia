using UnityEngine;

namespace Movement {
    public class CharacterMovement : BaseMovement {
        [field: SerializeField] public CharacterMovementConfig MovementConfig { get; private set; }
        public float Speed => MovementConfig ? MovementConfig.Speed : 0;

        public override void Move() {
            var velocity = Direction.normalized * Speed;
            RigidBody.position += velocity * Time.deltaTime;
        }

        public override void Move(Vector2 direction) {
            var velocity = direction.normalized * Speed;
            RigidBody.position += velocity * Time.deltaTime;
        }
    }
}
