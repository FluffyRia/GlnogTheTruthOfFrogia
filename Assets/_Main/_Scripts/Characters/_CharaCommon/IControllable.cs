using UnityEngine.InputSystem;

namespace Characters{
    public interface IControllable {
        public PlayerInput Controls { get; set; }
        public void EnableControls();
        public void DisableControls();       
    }
}
