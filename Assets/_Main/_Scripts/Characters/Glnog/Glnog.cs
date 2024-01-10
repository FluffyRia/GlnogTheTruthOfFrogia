using UnityEngine.InputSystem;
using UnityEngine;

namespace Characters {
    public class Glnog : Character, IControllable {
        [field: SerializeField] public PlayerInput Controls { get; set; }

        private void Awake() {
            EnableControls();
            Controls.actions.FindAction("Move").performed += OnMove;
            Controls.actions.FindAction("Move").canceled += OnMove;
        }

        private void FixedUpdate() {
            Movement.Move();
        }

        public void OnMove(InputAction.CallbackContext context) {
            Movement.SetDirection(new Vector2(context.ReadValue<float>(), 0));
        }

        public void EnableControls() {
            Controls.actions.Enable();
        }
        public void DisableControls() {
            Controls.actions.Disable();
        }

        private void OnDisable() {
            Controls.actions.FindAction("Move").performed -= OnMove;
            Controls.actions.FindAction("Move").canceled -= OnMove;
            DisableControls();
        }

        protected override void CacheChildren() {
            base.CacheChildren();
            Controls = GetComponent<PlayerInput>();
        }
    }
}